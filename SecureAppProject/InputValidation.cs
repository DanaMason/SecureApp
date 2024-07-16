using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SecureAppProject
{
    internal class InputValidation
    {

        //Ensures proper password creation proceedure.
        public bool ValidatePassword(SecureString securePassword)
        {
            const int minLength = 12;
            const string specialCharacters = "!@#$%^&*()_+=-{}[]:;'\"\\|,.<>/?`~";
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;
            bool hasSpecial = false;
            var secureStringPointer = IntPtr.Zero;

            if (securePassword == null)
            {
                throw new ArgumentNullException(nameof(securePassword));
            }

            if (securePassword.Length < minLength)
            {
                return false;
            }

            // Try-Finally statement to ensure the password is correctly formatted.
            try
            {
                secureStringPointer = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                
                for (int i = 0; i < securePassword.Length; i++)
                {
                    char c = (char)Marshal.ReadInt16(secureStringPointer, i * 2);

                    if (char.IsUpper(c))
                    { hasUpper = true; }
                    if (char.IsLower(c))
                    { hasLower = true; }
                    if (char.IsDigit(c))
                    { hasDigit = true; }
                    if (specialCharacters.Contains(c))
                    { hasSpecial = true; }

                    if (hasUpper && hasLower && hasDigit && hasSpecial)
                    {
                        return true; 
                    }
                }
            }

            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(secureStringPointer);
            }

            return false;
        }

            /* testing
                    public string ConvertToUnsecureString(SecureString securePassword)
                    {
                        if (securePassword == null)
                            throw new ArgumentNullException(nameof(securePassword));

                        IntPtr unmanagedString = IntPtr.Zero;
                        try
                        {
                            unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                            return Marshal.PtrToStringUni(unmanagedString);
                        }
                        finally
                        {
                            Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
                        }
                    }
            */

    }
}
