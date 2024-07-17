using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtpNet;
using QRCoder;
using System.Drawing;

namespace SecureAppProject
{
    internal class MultiFactorAuthentication
    {
        // Generates a randomized 20-byte key
        public static string GenerateTotpSecret()
        {
            var key = KeyGeneration.GenerateRandomKey(20);
            var base32Secret = Base32Encoding.ToString(key);
            return base32Secret;
        }

        public static Bitmap GenerateTotpQrCode(string username, string secret)
        {
            var totp = new Totp(Base32Encoding.ToBytes(secret));
            string uri = $"otpauth://totp/SecureAppProject:{username}?secret={secret}&issuer=SecureAppProject";


            using (var qrGenerator = new QRCodeGenerator())
            {
                var qrCodeData = qrGenerator.CreateQrCode(uri, QRCodeGenerator.ECCLevel.Q);
                var qrCode = new QRCode(qrCodeData);
                return qrCode.GetGraphic(20);
            }
        }

        public static bool ValidateTotp(string secret, string code)
        {
            var totp = new Totp(Base32Encoding.ToBytes(secret));
            return totp.VerifyTotp(code, out long timeStepMatched, VerificationWindow.RfcSpecifiedNetworkDelay);
        }

    }
}
