using MorseEncoderFacts;
using MorseEncoderLib.Tests;
using NUnit.Framework;
using System;

namespace MorseEncoderTest
{
    public class MorseEncoderTest
    {
        [TestCase("A", ".-")]
        [TestCase("E", ".")]
        [TestCase("I", "..")]
        [TestCase("O", "---")]
        [TestCase("U", "..-")]
        [TestCase("B", "-...")]
        [TestCase("C", "-.-.")]
        [TestCase("D", "-..")]
        [TestCase("F", "..-.")]
        [TestCase("G", "--.")]
        [TestCase("H", "....")]
        [TestCase("J", ".---")]
        [TestCase("K", ".-.")]
        [TestCase("L", ".-..")]
        [TestCase("M", "--")]
        [TestCase("N", "-.")]
        [TestCase("P", ".--.")]
        [TestCase("Q", "--.-")]
        [TestCase("R", ".-.")]
        [TestCase("S", "...")]
        [TestCase("T", "-")]
        [TestCase("V", "...-")]
        [TestCase("W", ".--")]
        [TestCase("X", "-..-")]
        [TestCase("Y", "-.--")]
        [TestCase("Z", "--..")]
        [TestCase("0", "-----")]
        [TestCase("1", ".----")]
        [TestCase("2", "..---")]
        [TestCase("3", "...--")]
        [TestCase("4", "....-")]
        [TestCase("5", ".....")]
        [TestCase("6", "-....")]
        [TestCase("7", "--...")]
        [TestCase("8", "---..")]
        [TestCase("9", "----.")]
        public void Encodes_Digits(string message, string expected)
        {
            MorseEncoder encode = new MorseEncoder();

            string actual = encode.Encode(message);

            Assert.That(actual, Is.EqualTo(expected));
        }

        /*
         With null => ArgumentNullException
         With empty, Empty(" ") => " "
         */

        [Test]
        public void With_Null_Throws_ArgumentNullException()
        {
            const string message = null;

            MorseEncoder encode = new MorseEncoder();

            Assert.That(() => encode.Encode(message), Throws.ArgumentNullException);
        }

        [Test]
        public void With_Empty_Throws_ArgumentOutOfRangeException()
        {
            MorseEncoder encode = new MorseEncoder();
            Assert.That(() => encode.Encode(string.Empty), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [TestCaseSource(typeof(MorseEncoderTestData), nameof(MorseEncoderTestData.DigitTestCases))]
        public string Encodes_Digits2(string message)
        {
            MorseEncoder encode = new MorseEncoder();

            return encode.Encode(message);
        }

        [TestCaseSource(typeof(MorseEncoderTestData), nameof(MorseEncoderTestData.DigitTestCasesVoid))]
        public void Encodes_Digits3(string message, string expected)
        {
            MorseEncoder encode = new MorseEncoder();

            string actual = encode.Encode(message);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}