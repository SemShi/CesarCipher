using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesarCipher.Classes
{
    internal static class Encrypter
    {
		private static char Cipher(char ch, int key)
		{
			if (!char.IsLetter(ch))
				return ch;

			char offset = char.IsUpper(ch) ? 'А' : 'а';
			return (char)((((ch + key) - offset) % 32) + offset);
		}

		public static string OnEncrypt(string input, int key)
		{
			string output = string.Empty;

			foreach (char ch in input)
				output += Cipher(ch, key);

			return output;
		}

		public static string OnDecrypt(string input, int key)
		{
			return OnEncrypt(input, 32 - key);
		}
	}
}
