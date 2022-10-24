using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProtectionLab1
{
    public class PasswordManager
    {

        public static string PermutationDecryption(string username, string password)
        {
            return PermutationEncryption(username, password, true);
        }

        public static string PermutationEncryption(string username, string password, bool decryption = false)
        {
            string result = "";
            if (username.Length > password.Length)
            {
                username = username.Remove(password.Length);
            }
            List<KeyValuePair<char, int>> indexes = new List<KeyValuePair<char, int>>();
            for (int i = 0; i < username.Length; i++)
            {
                KeyValuePair<char, int> new_pair = new KeyValuePair<char, int>(username[i], i);
                indexes.Add(new_pair);
            }
            indexes = indexes.OrderBy(x => x.Key).ToList();
            int idx = 0;
            int key_length = username.Length;
            while (idx < password.Length)
            {
                string block;
                int chars_left = password.Length - idx;
                if (chars_left < key_length)
                {
                    block = password.Substring(idx, chars_left);
                    string addition = new string(' ', key_length - chars_left);
                    block += addition;
                }
                else
                    block = password.Substring(idx, key_length);
                if (decryption)
                {
                    char[] correct_order = new char[key_length];
                    int block_index = 0;
                    foreach (KeyValuePair<char, int> pair in indexes)
                    {
                        correct_order[pair.Value] = block[block_index];
                        block_index++;
                    }
                    for (int i = 0; i < correct_order.Length; i++)
                    {
                        result += correct_order[i];
                    }
                }
                else
                {
                    foreach (KeyValuePair<char, int> pair in indexes)
                    {
                        result += block[pair.Value];
                    }
                }
                idx += key_length;
            }
            if (decryption) return result.TrimEnd();
            return result;
        }

        public static string GammaEncryption(string password)
        {
            string result_string = "";
            char[] char_arr = password.ToCharArray();

            int G_b = 1;
            for (int i = 0; i < char_arr.Length; i++)
            {
                char c = (char)(char_arr[i] ^ G_b);
                result_string += c;
                G_b = (5 * G_b + 3) % 256;
            }
            return result_string;
        }

        public static string Decrypt(string username, string password)
        {
            return PermutationDecryption(username, GammaEncryption(password));
        }

        public static string Encrypt(string username, string password)
        {
            return GammaEncryption(PermutationEncryption(username, password));
        }

        public static bool CheckPassword(string password)
        {
            var hasLetter = false;
            var hasOperation = false;
            var hasKirill = false;
            foreach (var symbol in password)
            {
                hasLetter |= char.IsLetter(symbol);
                hasOperation |= IsOperation(symbol);
                hasKirill |= IsKiril(symbol);
                if (hasLetter && hasOperation)
                    return true;
            }
            return false;
        }

        private static bool IsKiril(char c)
        {
            return ((((int)c > 1024)) && ((int)c < 1106));
        }

        private static bool IsOperation(char c)
        {
            return c == '*' || c == '/' || c == '+' || c == '-';
        }

        public static bool rePassword(string inputPassword, string confirmPassword)
        {
            return inputPassword == confirmPassword;
        }

        public static bool rePassword(string username, string inputPassword, string ciphertext)
        {
            var decryptedPassword = Decrypt(username, ciphertext);
            return decryptedPassword == inputPassword;
        }
    }
}
