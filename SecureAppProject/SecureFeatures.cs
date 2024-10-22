﻿using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Security;
using System.Runtime.InteropServices;
using System.Reflection.Emit;

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

            return Encryption(combined, aesKey, aesIV);
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
        public static void StorePasswordToFile(string filename, string username, byte[] encryptedData, byte[] aesKey, byte[] aesIV, RSAParameters rsaKey, string mfaData)
        {
            using (var stream = new FileStream(filename, FileMode.Append, FileAccess.Write))
            using (var writer = new BinaryWriter(stream))
            {
                // Goes through and writes each piece of data to the file.
                writer.Write("USER_START");

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

                writer.Write(mfaData);

                writer.Write("USER_END");
            }
        }

        // Verifies the password for a given username. 

        public static bool VerifyPassword(string filename, string username, SecureString securePassword, string code)
        {
            IntPtr passwordBSTR = Marshal.SecureStringToBSTR(securePassword);
            string password = Marshal.PtrToStringBSTR(passwordBSTR);

            try
            {
                using (var stream = new FileStream(filename, FileMode.Open))
                {
                    if (stream.Length == 0)
                    {
                        MessageBox.Show("The file is empty.");
                        return false;
                    }

                    using (var reader = new BinaryReader(stream))
                    {
                        while (reader.BaseStream.Position < reader.BaseStream.Length)
                        {
                            // Reads the information for comparison.

                            var start = reader.ReadString();

                            if (start != "USER_START")
                            {
                                MessageBox.Show("Corrupted file format.");
                                return false;
                            }

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

                            var secretCode = reader.ReadString();

                            var end = reader.ReadString();

                            if (end != "USER_END")
                            {
                                MessageBox.Show("Corrupted file format.");
                                return false;
                            }

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
                                    bool isPasswordVerified = rsa.VerifyData(hashToVerify, storedSignedHash, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

                                    if (isPasswordVerified)
                                    {
                                        return MultiFactorAuthentication.ValidateTotp(secretCode, code);
                                    }
                                }
                            }
                        }
                    }
                }

                return false;

            }

            finally
            {
                Marshal.ZeroFreeBSTR(passwordBSTR);
            }
        }

        // Function to connect the SignUp Process functions.
        public static void SignUp(string filename, string username, SecureString SecurePassword, string mfaSecret)
        {
            if (DoesUsernameExist(filename, username))
            {
                MessageBox.Show("Please enter a different Username. That Username is taken.");
                return;
            }

            IntPtr passwordBSTR = Marshal.SecureStringToBSTR(SecurePassword);
            string password = Marshal.PtrToStringBSTR(passwordBSTR);

            try
            {
                RSAParameters rsaKey = GenerateUserRSAKey();

                byte[] aesKey;
                byte[] aesIV;
                byte[] encryptedData = HashSignAndEncrypt(password, rsaKey, out aesKey, out aesIV);

                StorePasswordToFile(filename, username, encryptedData, aesKey, aesIV, rsaKey, mfaSecret);
            }

            finally
            {
                Marshal.ZeroFreeBSTR(passwordBSTR);
            }
        }

        // Reads the file, and skips the non-username information.
        public static bool DoesUsernameExist(string filename, string username)
        {
            try
            {
                using (var stream = new FileStream(filename, FileMode.Open, FileAccess.Read))
                using (var reader = new BinaryReader(stream))
                {
                    if (stream.Length == 0)
                    {
                        MessageBox.Show("Error! Database file is empty");
                        return false;
                    }

                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        var start = reader.ReadString();
                        if (start != "USER_START")
                        {
                            // Seek back to the start of the record if the format is unexpected
                            reader.BaseStream.Seek(-start.Length, SeekOrigin.Current);
                            continue;
                        }

                        var storedUsername = reader.ReadString();

                        // Skip the rest of the fields in the record
                        var aesKeyLength = reader.ReadInt32();
                        reader.BaseStream.Seek(aesKeyLength, SeekOrigin.Current);

                        var aesIVLength = reader.ReadInt32();
                        reader.BaseStream.Seek(aesIVLength, SeekOrigin.Current);

                        var rsaModulusLength = reader.ReadInt32();
                        reader.BaseStream.Seek(rsaModulusLength, SeekOrigin.Current);

                        var rsaExponentLength = reader.ReadInt32();
                        reader.BaseStream.Seek(rsaExponentLength, SeekOrigin.Current);

                        var encryptedDataLength = reader.ReadInt32();
                        reader.BaseStream.Seek(encryptedDataLength, SeekOrigin.Current);

                        reader.ReadString(); // Skip mfaData

                        var end = reader.ReadString();
                        if (end != "USER_END")
                        {
                            // Seek back to the start of the record if the format is unexpected
                            reader.BaseStream.Seek(-end.Length, SeekOrigin.Current);
                            continue;
                        }

                        if (storedUsername == username)
                        {
                            MessageBox.Show("Username already exists!");
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking username existence: {ex.Message}");
            }
            return false;
        }
    }
}