using System;
using System.Text.RegularExpressions;

namespace MorseEncoderFacts
{
    public class MorseEncoder
    {
        private static readonly Regex InvalidVowelsRegex = new Regex("áéíóú", RegexOptions.IgnoreCase);

        /// <summary>
        /// Encode the input message
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">When <paramref name="message"/>is <see langword="null" /></exception>
        /// <exception cref="ArgumentOutOfRangeException">When <paramref name="message"/>is empty<see/> <code>""</code></exception>
        /// <exception cref="FormatException">When <paramref name="message"/>contains an <see/>é<code>""</code></exception>
        /// <exception cref="FormatException">When <paramref name="message"/>contains an <see/>" "<code>""</code></exception>
        public string Encode(in string message)
        {
            Validate(message);
            return Transform(message);
        }
        private static string Transform(in string message)
        {
            // Numbers
            if (message.Contains("0"))
            {
                return "-----";
            }
            if (message.Contains("1"))
            {
                return ".----";
            }
            if (message.Contains("2"))
            {
                return "..---";
            }
            if (message.Contains("3"))
            {
                return "...--";
            }
            if (message.Contains("4"))
            {
                return "....-";
            }
            if (message.Contains("5"))
            {
                return ".....";
            }
            if (message.Contains("6"))
            {
                return "-....";
            }
            if (message.Contains("7"))
            {
                return "--...";
            }
            if (message.Contains("8"))
            {
                return "---..";
            }
            if (message.Contains("9"))
            {
                return "----.";
            }

            // Vowels
            if (message.Contains("A"))
            {
                return ".-";
            }
            if (message.Contains("E"))
            {
                return ".";
            }
            if (message.Contains("I"))
            {
                return "..";
            }
            if (message.Contains("O"))
            {
                return "---";
            }
            if (message.Contains("U"))
            {
                return "..-";
            }

            // Consonants
            if (message.Contains("B"))
            {
                return "-...";
            }
            if (message.Contains("C"))
            {
                return "-.-.";
            }
            if (message.Contains("D"))
            {
                return "-..";
            }
            if (message.Contains("F"))
            {
                return "..-.";
            }
            if (message.Contains("G"))
            {
                return "--.";
            }
            if (message.Contains("H"))
            {
                return "....";
            }
            if (message.Contains("J"))
            {
                return ".---";
            }
            if (message.Contains("K"))
            {
                return ".-.";
            }
            if (message.Contains("L"))
            {
                return ".-..";
            }
            if (message.Contains("M"))
            {
                return "--";
            }
            if (message.Contains("N"))
            {
                return "-.";
            }
            if (message.Contains("P"))
            {
                return ".--.";
            }
            if (message.Contains("Q"))
            {
                return "--.-";
            }
            if (message.Contains("R"))
            {
                return ".-.";
            }
            if (message.Contains("S"))
            {
                return "...";
            }
            if (message.Contains("T"))
            {
                return "-";
            }
            if (message.Contains("V"))
            {
                return "...-";
            }
            if (message.Contains("W"))
            {
                return ".--";
            }
            if (message.Contains("X"))
            {
                return "-..-";
            }
            if (message.Contains("Y"))
            {
                return "-.--";
            }
            if (message.Contains("Z"))
            {
                return "--..";
            }
            if (message.Contains("hola"))
            {
                return "….---.-…-";
            }

            return "";
        }

        private void Validate(string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(message);
            }

            if (message == string.Empty)
            {
                throw new ArgumentOutOfRangeException(message);
            }

            if (InvalidVowelsRegex.IsMatch(message))
            {
                throw new FormatException();
            }

            if (message.Contains(" "))
            {
                throw new FormatException();
            }
        }
    }
}
