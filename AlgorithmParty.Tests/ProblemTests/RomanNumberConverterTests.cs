using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmParty.Problems.RomanNumerals;
using NUnit.Framework;

namespace AlgorithmParty.Tests
{
    [TestFixture]
    public class RomanNumberConverterTests
    {
        [Test]
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("VII", 7)]
        [TestCase("VIII", 8)]
        [TestCase("IX", 9)]
        [TestCase("X", 10)]
        [TestCase("XI", 11)]
        [TestCase("XII", 12)]
        [TestCase("XIII", 13)]
        [TestCase("XIV", 14)]
        [TestCase("XV", 15)]
        [TestCase("XVI", 16)]
        [TestCase("XVII", 17)]
        [TestCase("XVIII", 18)]
        [TestCase("XIX", 19)]
        [TestCase("XX", 20)]
        [TestCase("XXIV", 24)]
        [TestCase("XXIX", 29)]
        [TestCase("XXX", 30)]
        [TestCase("XL", 40)]
        [TestCase("L", 50)]
        [TestCase("LX", 60)]
        [TestCase("LXX", 70)]
        [TestCase("LXXX", 80)]
        [TestCase("XC", 90)]
        [TestCase("XCIX", 99)]
        [TestCase("C", 100)]
        [TestCase("CC", 200)]
        [TestCase("CCC", 300)]
        [TestCase("CD", 400)]
        [TestCase("D", 500)]
        [TestCase("DC", 600)]
        [TestCase("DCC", 700)]
        [TestCase("DCCC", 800)]
        [TestCase("CM", 900)]
        [TestCase("M", 1000)]
        public void RomanNumberConverter_ToNumber_CorrectOutput(string num, int expectedValue)
        {
            var result = RomanNumberConverter.ToNumberWithValidation(num);

            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        [TestCase("VX")]
        [TestCase("XXXX")]
        [TestCase("VV")]
        [TestCase("B")]
        [TestCase("MCMD")]
        [TestCase("IIV")]
        public void RomanNumberConverter_ToNumber_InvalidCases_ExceptionThrown(string num)
        {
            Assert.Throws<ArgumentException>(() => RomanNumberConverter.ToNumberWithValidation(num));
        }

        [Test]
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("VII", 7)]
        [TestCase("VIII", 8)]
        [TestCase("IX", 9)]
        [TestCase("X", 10)]
        [TestCase("XI", 11)]
        [TestCase("XII", 12)]
        [TestCase("XIII", 13)]
        [TestCase("XIV", 14)]
        [TestCase("XV", 15)]
        [TestCase("XVI", 16)]
        [TestCase("XVII", 17)]
        [TestCase("XVIII", 18)]
        [TestCase("XIX", 19)]
        [TestCase("XX", 20)]
        [TestCase("XXIV", 24)]
        [TestCase("XXIX", 29)]
        [TestCase("XXX", 30)]
        [TestCase("XL", 40)]
        [TestCase("L", 50)]
        [TestCase("LX", 60)]
        [TestCase("LXX", 70)]
        [TestCase("LXXX", 80)]
        [TestCase("XC", 90)]
        [TestCase("XCIX", 99)]
        [TestCase("C", 100)]
        [TestCase("CC", 200)]
        [TestCase("CCC", 300)]
        [TestCase("CD", 400)]
        [TestCase("D", 500)]
        [TestCase("DC", 600)]
        [TestCase("DCC", 700)]
        [TestCase("DCCC", 800)]
        [TestCase("CM", 900)]
        [TestCase("M", 1000)]
        public void RomanNumberConverter_ToRoman_CorrectOutput(string expectedValue, int num)
        {
            var result = RomanNumberConverter.ToRoman(num);

            Assert.AreEqual(expectedValue, result);
        }
    }
}
