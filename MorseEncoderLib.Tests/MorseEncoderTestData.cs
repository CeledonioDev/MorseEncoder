using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace MorseEncoderLib.Tests
{
    
    public static class MorseEncoderTestData
    {
        public static string[] InvalidVowels = { "á", "é", "í", "ó", "ú" };

        public static IEnumerable<TestCaseParameters> DigitTestCases
        {
            get
            {
                yield return new TestCaseData("0").Returns("-----");
                yield return new TestCaseData("1").Returns(".----");
            }
        }

        public static IEnumerable<TestCaseParameters> DigitTestCasesVoid
        {
            get
            {
                yield return new TestCaseData("0","-----");
                yield return new TestCaseData("1",".----");
            }
        }

        public static IEnumerable<TestCaseParameters> FileTestCasesVoid
        {
            get
            {
                yield return new TestCaseData("hola", "....---.-...-");
                yield return new TestCaseData("sos", "...---.....");
            }
        }

        private static TestCaseParameters[] PhrasesCode =
        {

        };
    }
}
