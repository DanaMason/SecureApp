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
        // Quickly generates a randomized 20-byte key for this program.
        public static string GenerateTotpSecret()
        {
            var key = KeyGeneration.GenerateRandomKey(20);
            var base32Secret = Base32Encoding.ToString(key);
            return base32Secret;
        }

        // Validates the information so it ensures the MFA information matches.
        public static bool ValidateTotp(string key, string code)
        {
            var totp = new Totp(Base32Encoding.ToBytes(key));
            return totp.VerifyTotp(code, out long timeStepMatched, VerificationWindow.RfcSpecifiedNetworkDelay);
        }

    }
}
