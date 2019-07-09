using System;
using System.Linq;
using System.Security.Cryptography;

namespace TakeCareOfPlants_BUS
{
    public static class Function_BUS
    {
        public static string GenerateHash(string input, string salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            MD5 hashAlgoritm = MD5.Create();
            bytes = hashAlgoritm.ComputeHash(bytes);
            return Convert.ToBase64String(bytes);
        }

        public static string CreateSalt(int size)
        {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        //Write password checker method - must contain min 8 char and max 22 char,
        //No two similar chars consecutively, 1 lower case, 1 upper case, 1 special char, no white space 
        public static bool CheckPassword(string pass)
        {
            //min 8 chars, max 22 chars
            if (pass.Length < 8 || pass.Length > 22) {
                return false;
            }

            //No white space
            if (pass.Contains(" ")) {
                return false;
            }

            //At least 1 upper case letter
            if (!pass.Any(char.IsUpper)) {
                return false;
            }

            //At least 1 lower case letter
            if (!pass.Any(char.IsLower)) {
                return false;
            }

            //No two similar chars consecutively
            for (int i = 0; i < pass.Length - 1; i++) {
                if (pass[i] == pass[i + 1]) {
                    return false;
                }
            }

            //At least 1 special char
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialCharactersArray = specialCharacters.ToCharArray();
            foreach (char c in specialCharactersArray) {
                if (pass.Contains(c)) {
                    return true;
                }
            }
            return false;
        }
    }
}
