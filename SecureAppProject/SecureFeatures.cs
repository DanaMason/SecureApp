using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SecureAppProject
{
    public class SecureFeatures
    {
        // Consts.
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int Iterations = 100000;
        private const int AESKeySize = 32;
        private const int AESIVSize = 16;

        // Function for producing a salt for security measures.
        public static byte[] GenerateSalt()
        {
            byte[] salt = new byte[SaltSize];

            // Sets the array to the new random bits of data to salt with.
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return salt;

        }


        // Hashes the password.
        public static byte[] HashPassword(string password, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations))
            {
                return pbkdf2.GetBytes(HashSize);
            }
        }

        // Produces the sign.
        public static byte[] SignData(byte[] data, RSAParameters rsaParameters)
        {
            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(rsaParameters);

                return rsa.SignData(data, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            }
        }

        // Function for encrypting the information.
        public static byte[] Encryption(byte[] data, byte[] AESKey, byte[] AESIV)
        {
            using (Aes aes = Aes.Create())
            {

                // The following sets the correct Key and IV to the previously calculated values.

                aes.Key = AESKey;
                aes.IV = AESIV;

                // The following takes the information and turns the plaintext into ciphertext.

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var memoryStream = new MemoryStream())
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {

                    cryptoStream.Write(data, 0, data.Length);
                    cryptoStream.Close();

                    return memoryStream.ToArray();

                }
            }
        }

        // Function for decrypting the data.
        public static byte[] Decryption(byte[] data, byte[] AESKey, byte[] AESIV)
        {
            using (Aes aes = Aes.Create())
            {

                // These set the Key and IV to needed values.

                aes.Key = AESKey;
                aes.IV = AESIV;

                // These revert the information into the necessary format for viewing.

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var memoryStream = new MemoryStream(data))
                using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                using (var binaryReader = new BinaryReader(cryptoStream))
                {
                    return binaryReader.ReadBytes(data.Length);
                }
            }
        }

        // Combines functions to Hash, Sign, and Encrypt information.
        public static byte[] HashSignAndEncrypt(string password, RSAParameters rsaKey, out byte[] aesKey, out byte[] aesIV)
        {
            // Creates a new instance of these keys for the user.

            aesKey = GenerateUserAESKey();
            aesIV = GenerateUserAESIV();

            // Establishes bytes and sets them to values from previous functions.

            byte[] salt = GenerateSalt();
            byte[] hash = HashPassword(password, salt);
            byte[] signedHash = SignData(hash, rsaKey);

            // Combine the salt and hashing functions.

            byte[] combined = new byte[salt.Length + signedHash.Length];

            Buffer.BlockCopy(salt, 0, combined, 0, salt.Length);
            Buffer.BlockCopy(signedHash, 0, combined, salt.Length, signedHash.Length);

            // Returns newly encrypted, hashed, salted, and signed code.

            return Encryption(salt, aesKey, aesIV);
        }

        // Generates a new AES key for a user.
        public static byte[] GenerateUserAESKey()
        {
            return GenerateSecureKey(AESKeySize);
        }

        // Generates a new AES IV for a user.
        public static byte[] GenerateUserAESIV()
        {
            return GenerateSecureIV(AESIVSize);
        }

        // Generates the RSA key for a user.
        public static RSAParameters GenerateUserRSAKey()
        {
            using (var rsa = RSA.Create(2048))
            {
                return rsa.ExportParameters(true);
            }
        }

        // Generates a security key for the program. Does this by creating a cryptographically
        // secure key using a secure and well known library.
        public static byte[] GenerateSecureKey(int size)
        {
            byte[] key = new byte[size];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(key);
            }

            return key;

        }

        // Generates an Initial Vector for the program. Similar to the Secure Key, it does this
        // by using a library that is secure, and creates a secure initial vector.
        public static byte[] GenerateSecureIV(int size) // Generates a Initial Vector for the program. 
        {
            byte[] iv = new byte[size];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(iv);
            }

            return iv;

        }

        // Stores the recently created data into a file.
        public static void StorePasswordToFile(string filename, string username, byte[] encryptedData, byte[] aesKey, byte[] aesIV, RSAParameters rsaKey)
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            using (var writer = new BinaryWriter(stream))
            {
                // Goes through and writes each piece of data to the file.

                writer.Write(username);
                writer.Write(aesKey.Length);
                writer.Write(aesKey);
                writer.Write(aesIV.Length);
                writer.Write(aesIV);
                writer.Write(rsaKey.Modulus.Length);    // Ignore I think. Issue may be in UserRSA.
                writer.Write(rsaKey.Modulus);
                writer.Write(rsaKey.Exponent.Length);   // Ignore I think. Issue may be in UserRSA.
                writer.Write(rsaKey.Exponent);
                writer.Write(encryptedData.Length);
                writer.Write(encryptedData);
            }
        }

        // Verifies the password for a given username.
        public static bool VerifyPassword(string filename, string username, string password)
        {
            using (var stream = new FileStream(filename, FileMode.Open))
            using (var reader = new BinaryReader(stream))
            { 
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        // Reads the information for comparison.

                        var storedUsername = reader.ReadString();
                        var aesKeyLength = reader.ReadInt32();
                        var aesKey = reader.ReadBytes(aesKeyLength);
                        var aesIVLength = reader.ReadInt32();
                        var aesIV = reader.ReadBytes(aesIVLength);
                        var rsaModulusLength = reader.ReadInt32();
                        var rsaModulus = reader.ReadBytes(rsaModulusLength);
                        var rsaExponentLength = reader.ReadInt32();
                        var rsaExponent = reader.ReadBytes(rsaExponentLength);
                        var encryptedDataLength = reader.ReadInt32();
                        var encryptedData = reader.ReadBytes(encryptedDataLength);

                        // If statement to decrypt the data, rehash/salt/encrypt it, and compare the two.

                        if (storedUsername == username)
                        {
                            var rsaParameters = new RSAParameters
                            {
                                Modulus = rsaModulus,
                                Exponent = rsaExponent
                            };

                            // Decrypts and re-encrypts.

                            var decryptedData = Decryption(encryptedData, aesKey, aesIV);
                            var salt = new byte[SaltSize];
                            var storedSignedHash = new byte[decryptedData.Length - SaltSize];
                            
                            Buffer.BlockCopy(decryptedData, 0, salt, 0, SaltSize);
                            Buffer.BlockCopy(decryptedData, SaltSize, storedSignedHash, 0, storedSignedHash.Length);

                            var hashToVerify = HashPassword(password, salt);

                            using (var rsa = RSA.Create())
                            {
                                rsa.ImportParameters(rsaParameters);
                                return rsa.VerifyData(hashToVerify, storedSignedHash, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                            }
                        }
                    }
            }

            // Reached if the use isn't found.
            return false; 

        }


    }
}