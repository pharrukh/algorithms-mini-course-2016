using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore
{
    public static class StringHelpers
    {
        private static string Alphabet = "abcdefghijklmnopqrstuvwxyz0123456789,.?:!'+-=@ \'абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string SpellNumber(int n)
        {
            if (n <= 15 || n == 18)
                return SpellSimpleNumber(n);
            if (n < 20)
                return SpellSimpleNumber(int.Parse(n.ToString().Substring(1))) + "teen";
            if (n >= 20 && GetNumberOfDigits(n) > 1 && n < 100)
            {
                var digit = SpellSimpleNumber(GetDigits(n));
                if (digit != "")
                    return SpellDecades(GetDecates(n)) + "-" + digit;
                return SpellDecades(GetDecates(n));
            }
            if (n >= 100 && n < 1000)
            {
                var spelledDecate = SpellDecades(GetDecates(n));
                var spelledDigit = SpellSimpleNumber(GetDigits(n));
                if (spelledDigit == "" && spelledDecate == "")
                    return SpellSimpleNumber(GetHundreds(n)) + " hundred";
                return SpellSimpleNumber(GetHundreds(n)) + " hundred and " + SpellNumber(n % 100);
            }
            if (n == 1000)
                return "one thousand";
            throw new Exception("Out of range");
        }

        public static string SpellSimpleNumber(int n)
        {
            switch (n)
            {
                case 0:
                    return "";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                case 10:
                    return "ten";
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";
                case 13:
                    return "thirteen";
                case 14:
                    return "fourteen";
                case 15:
                    return "fifteen";
                case 18:
                    return "eighteen";
            }
            throw new Exception("I do not know this number");
        }
        public static string SpellDecades(int n)
        {
            switch (n)
            {
                case 0:
                    return "";
                case 2:
                    return "twenty";
                case 3:
                    return "thirty";
                case 4:
                    return "forty";
                case 5:
                    return "fifty";
                case 8:
                    return "eighty";
                default:
                    return SpellSimpleNumber(n) + "ty";
            }
        }
        private static int GetNumberOfDigits(int n)
        {
            return n.ToString().Length;
        }

        public static int GetDecates(int n)
        {
            var len = n.ToString().Length;
            if (GetNumberOfDigits(n) > 1)
                return int.Parse(n.ToString().Substring(len - 2, 1));
            throw new Exception("More than 2 digits present");
        }
        public static int GetDigits(int n)
        {
            return n % 10;
        }
        public static int GetHundreds(int n)
        {
            var len = n.ToString().Length;
            if (GetNumberOfDigits(n) > 2)
                return int.Parse(n.ToString().Substring(len - 3, 1));
            throw new Exception("More than 3 digits present");
        }

        public static string EncryptToNumbers(string text)
        {
            var encryptedText = new StringBuilder();
            foreach (char sign in text.ToLower())
            {
                if (!Alphabet.Contains(sign))
                    encryptedText.Append("56");
                else
                {
                    var signIndex = Alphabet.IndexOf(sign);
                    encryptedText.Append(signIndex + 10);
                }
            }
            return encryptedText.ToString();
        }
        public static string DecryptToWords(string encryptedText)
        {
            var length = encryptedText.Length;
            if (length % 2 != 0)
                throw new Exception("That is a wrong message");
            var decryptedText = new StringBuilder();
            for (var i = 0; i < length / 2; i++)
            {
                var encryptedSign = int.Parse(encryptedText.Substring(2 * i, 2));
                if (encryptedSign > 56)
                    decryptedText.Append("?");
                else
                {
                    var index = encryptedSign - 10;
                    var decryptedSign = Alphabet.ElementAt(index);
                    decryptedText.Append(decryptedSign);
                }
            }
            return decryptedText.ToString();
        }
    }
}
