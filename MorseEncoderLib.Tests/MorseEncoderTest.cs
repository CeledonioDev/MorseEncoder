using MorseEncoderFacts;
using NUnit.Framework;
using System;

namespace MorseEncoderTest
{
    public class MorseEncoderTest
    {
        /*
         Vowels Test Cases:
            A: With A Returns .-
            E: With E Returns .
            I: With I Returns ..
            O: With O Returns ---
            U: With U Returns ..-
         */

        [Test]
        public void Encode_A_To_Single_Point_And_Single_Dash()
        {
            const string message = "A";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = ".-";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Encodes_E_To_Single_Point()
        {
            const string message = "E";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = ".";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Encodes_I_To_Two_Points()
        {
            const string message = "I";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "..";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Encodes_O_To_Three_Dashes()
        {
            const string message = "O";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "---";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Encodes_U_To_Two_Points_And_One_Dash()
        {
            const string message = "U";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "..-";

            Assert.That(actual, Is.EqualTo(expected));
        }

        /*
         Consonants Test Cases:
            B: With B Returns -...
            C: With C Returns -.-.
            D: With D Returns -..
            F: With F Returns ..-.
            G: With G Returns --.
            H: With H Returns ....
            J: With J Returns .---
            K: With K Returns .-.
            L: With L Returns .-..
            M: With M Returns --
            N: With N Returns -.
            P: With P Returns .--.
            Q: With Q Returns --.-
            R: With R Returns .-.
            S: With S Returns ...
            T: With T Returns -
            V: With V Returns ...-
            W: With W Returns .--
            X: With X Returns -..-
            Y: With Y Returns -.--
            Z: With Z Returns --..
         */

        [Test]
        public void With_B_Returns_One_Dash_And_Three_Points()
        {
            const string message = "B";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "-...";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_C_Returns_Dash_Point_Dash_Point()
        {
            const string message = "C";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "-.-.";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_D_Returns_One_Dash_And_Two_Points()
        {
            const string message = "D";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "-..";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_F_Returns_Two_Points_One_Dash_And_One_Point()
        {
            const string message = "F";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "..-.";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_G_Returns_Two_Dashes_And_One_Point()
        {
            const string message = "G";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "--.";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_H_Returns_Four_Points()
        {
            const string message = "H";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "....";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_J_Returns_One_Point_And_Three_Dashes()
        {
            const string message = "J";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = ".---";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_K_Returns_Dash_Point_Dash()
        {
            const string message = "K";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "-.-";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_L_Returns_One_Point_One_Dash_And_Two_Points()
        {
            const string message = "L";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = ".-..";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_M_Returns_Two_Dashes()
        {
            const string message = "M";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "--";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_N_Returns_One_Dash_And_One_Point()
        {
            const string message = "N";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "-.";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_P_Returns_One_Point_Two_Dashes_And_One_Point()
        {
            const string message = "P";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = ".--.";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_Q_Returns_Two_Dashes_One_Point_And_One_Dash()
        {
            const string message = "Q";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "--.-";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_R_Returns_Point_Dash_Point()
        {
            const string message = "R";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = ".-.";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_S_Returns_Three_Points()
        {
            const string message = "S";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "...";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_T_Returns_One_Dash()
        {
            const string message = "T";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "-";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_V_Returns_Three_Points_And_One_Dash()
        {
            const string message = "V";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "...-";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_W_Returns_One_Point_And_Two_Dashes()
        {
            const string message = "W";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = ".--";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_X_Returns_One_Dash_Two_Points_And_One_Dash()
        {
            const string message = "X";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "-..-";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_Y_Returns_One_Dash_One_Point_And_Two_Dashes()
        {
            const string message = "Y";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "-.--";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_Z_Returns_Two_Dashes_And_Two_Points()
        {
            const string message = "Z";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "--..";

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

        [Test]
        public void With_E_Accute_Throws_FormatException()
        {
            MorseEncoder encode = new MorseEncoder();
            Assert.That(() => encode.Encode("é"), Throws.InstanceOf<FormatException>());
        }

        /*
        Numbers Test Cases:
           0: With 0 Returns -----
           1: With 1 Returns .----
           2: With 2 Returns ..---
           3: With 3 Returns ...--
           4: With 4 Returns ....-
           5: With 5 Returns .....
           6: With 6 Returns -....
           7: With 7 Returns --...
           8: With 8 Returns ---..
           9: With 9 Returns ----.
        */

        [TestCase("0", "-----")]
        public void With_Zero_Returns_Five_Dashes(string message, string expected)
        {
            MorseEncoder encode = new MorseEncoder();

            string actual = encode.Encode(message);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_One_Returns_One_Point_And_Four_Dashes()
        {
            const string message = "1";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = ".----";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_Two_Returns_Two_Points_And_Three_Dashes()
        {
            const string message = "2";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "..---";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_Three_Returns_Three_Points_And_Two_Dashes()
        {
            const string message = "3";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "...--";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_Four_Returns_Four_Points_And_One_Dash()
        {
            const string message = "4";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "....-";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_Five_Returns_Five_Points()
        {
            const string message = "5";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = ".....";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_Six_Returns_One_Dash_And_Four_Points()
        {
            const string message = "6";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "-....";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_Seven_Returns_Two_Dashes_And_Three_Points()
        {
            const string message = "7";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "--...";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_Eight_Returns_Three_Dashes_And_Two_Points()
        {
            const string message = "8";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "---..";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_ENine_Returns_Four_Dashes_And_One_Point()
        {
            const string message = "9";

            MorseEncoder encode = new MorseEncoder();
            string actual = encode.Encode(message);

            string expected = "----.";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_Space_Returns_ArgumentException()
        {
            MorseEncoder encode = new MorseEncoder();

            Assert.That(() => encode.Encode(" "), Throws.InstanceOf<FormatException>());
        }
    }
}