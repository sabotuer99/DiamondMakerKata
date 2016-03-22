using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamonds
{
    [TestFixture]
    class DiamondMakerTests
    {
        private DiamondMaker _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new DiamondMaker();
        }

        [Test]
        public void ctor_sanityCheck()
        {
            Assert.NotNull(_sut);
        }

        [Test]
        public void MakeDiamond_GivenA_FirstLineContainsA()
        {
            var output = _sut.MakeDiamond('A');

            Assert.NotNull(output);
            Assert.AreEqual("A", output[0]);
        }

        [Test]
        public void MakeDiamond_GivenA_ReturnsOneLineOnly()
        {
            var output = _sut.MakeDiamond('A');

            Assert.AreEqual(1, output.Count);
        }

        [Test]
        public void MakeDiamond_GivenB_ReturnsThreeLines()
        {
            var output = _sut.MakeDiamond('B');

            Assert.AreEqual(3, output.Count);
        }

        [Test]
        public void MakeDiamond_GivenB_MiddleLineTwoBs()
        {
            var output = _sut.MakeDiamond('B');

            Assert.AreEqual("B B", output[1]);
        }

        [Test]
        public void MakeDiamond_GivenB_FirstLastLineAWithSpaces()
        {
            var output = _sut.MakeDiamond('B');

            Assert.AreEqual(" A ", output[0]);
            Assert.AreEqual(" A ", output[2]);
        }

        [TestCase('C', 5)]
        [TestCase('D', 7)]
        [TestCase('E', 9)]
        public void MakeDiamond_GivenLetter_ReturnsRightNumberOfLines(char letter, int lineCount)
        {
            var output = _sut.MakeDiamond(letter);

            Assert.AreEqual(lineCount, output.Count);
        }

        [TestCase('C', "  A  ")]
        [TestCase('D', "   A   ")]
        [TestCase('E', "    A    ")]
        public void MakeDiamond_GivenLetter_FirstLastLinesAreAWithSpaces(char letter, string expected)
        {
            var output = _sut.MakeDiamond(letter);

            Assert.AreEqual(expected, output.First());
            Assert.AreEqual(expected, output.Last());
        }


        [TestCase('C')]
        [TestCase('D')]
        [TestCase('E')]
        public void MakeDiamond_GivenLetter_SecondLineContainsB(char letter)
        {
            var output = _sut.MakeDiamond(letter);

            Assert.True(output[1].Contains("B"));
        }

        [TestCase('C', " B B ")]
        [TestCase('D', "  B B  ")]
        [TestCase('E', "   B B   ")]
        public void MakeDiamond_GivenLetter_SecondLineBWithSpaces(char letter, string expected)
        {
            var output = _sut.MakeDiamond(letter);

            Assert.AreEqual(expected, output[1]);
        }

        [TestCase('C', "C   C")]
        [TestCase('D', " C   C ")]
        [TestCase('E', "  C   C  ")]
        public void MakeDiamond_GivenLetter_ThirdLineCWithSpaces(char letter, string expected)
        {
            var output = _sut.MakeDiamond(letter);

            Assert.AreEqual(expected, output[2]);
        }


    }
}
