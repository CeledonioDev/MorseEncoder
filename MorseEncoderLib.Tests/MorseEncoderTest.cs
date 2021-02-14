using MorseEncoderFacts;
using MorseEncoderLib.Tests;
using NUnit.Framework;
using System;
using System.IO;

namespace MorseEncoderTest
{
    //[Parallelizable(ParallelScope.Children)]
    public class MorseEncoderTest
    {
        [OneTimeSetUp]
        public void Setup()
        {
            var dir = @"c:\prueba\execiseSetupAndTearDown";

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            File.WriteAllText(Path.Combine(dir, "log.txt"), "blah blah, text");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() 
        {
            var dir = @"c:\prueba\execiseSetupAndTearDown";
            if(Directory.Exists(dir))
                Directory.Delete(dir);
        }

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

        //[Test]
        [Test]
        public void With_Null_Throws_ArgumentNullException()
        {
            const string message = null;
            int numberProcesador = Environment.ProcessorCount;

            //Assume.That(Environment.ProcessorCount >= 2);

            Warn.If(Environment.ProcessorCount >= 2);
            Warn.Unless(Environment.ProcessorCount >= 2, "No cumple con la condición");
            MorseEncoder encode = new MorseEncoder();

            Assert.That(() => encode.Encode(message), Throws.ArgumentNullException);
        }

        [Test]
        public void With_Empty_Throws_ArgumentOutOfRangeException()
        {
            MorseEncoder encode = new MorseEncoder();
            //Assume.That(Environment.ProcessorCount <= 2);
            Warn.If(Environment.ProcessorCount <= 2);
            Warn.Unless(Environment.ProcessorCount <= 2, "No cumple con la condición");
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

        [Test]
        public void Encodes_phrases_words()
        {
            string path = @"c:\Users\Wepsys\Documents\prueba.txt";
            string[] lines = File.ReadAllLines(path);
            MorseEncoder encoder = new MorseEncoder();
            var firstValue = "";
            var secondValue = "";
            //var array1 = lines[0].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0];
            //var array2 = lines[1].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1];

            foreach (var line in lines)
            {
                firstValue = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0];
                secondValue = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1];
            }

            string message2 = encoder.Encode(firstValue);
            Assert.That(message2, Is.EqualTo(secondValue));
        }

        [Test]
        public void valid_equals_message()
        {
            DriveInfo info = new DriveInfo("C");

            Assume.That(info.TotalSize <= 1024);

            Assert.That("Hola", Is.EqualTo("Hola"));
        }

        [Test]
        public void valid_equals_number()
        {
            DriveInfo info = new DriveInfo("C");

            Assume.That(info.TotalSize >= 1024);

            Assert.That("1", Is.EqualTo("1"));
        }

        //[TestCaseSource(typeof(MorseEncoderTestData), nameof(MorseEncoderTestData.phrasesTestCases))]

    }
}