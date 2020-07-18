using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEulerTests
{
    [TestClass, Ignore]
    public class Problem22
    {
        private static string RawText = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Data\p022_names.txt");
        private List<string> Names = RawText.Split(',').Select(x => x.Trim('"')).ToList();
        private static string Alphabet = "abcdefghijklmnopqrstuvwxyz".ToUpper();
        [TestInitialize]
        public void SetUp()
        {
            Names.Sort();
        }
        [TestMethod]
        public void MainTest()
        {
            var totalScore = 0;
            foreach (var name in Names)
            {
                totalScore += GetNameScore(name);
            }
            Assert.AreEqual(871198282, totalScore);
        }
        [TestMethod]
        public void GetLetterPrice()
        {
            Assert.AreEqual(1, GetLetterPrice('a'));
            Assert.AreEqual(2, GetLetterPrice('b'));
            Assert.AreEqual(3, GetLetterPrice('c'));
            Assert.AreEqual(26, GetLetterPrice('z'));
        }
        [TestMethod]
        public void SampleNameScoreTest()
        {
            Assert.AreEqual(49714, GetNameScore("COLIN"));
        }
        [TestMethod]
        public void SampleNamePriceTest()
        {
            Assert.AreEqual(53, GetNameValue("Colin"));
        }
        public int GetNameValue(string name)
        {
            var total = 0;
            for (var i = 0; i < name.Length; i++)
            {
                var letter = name[i];
                var price = GetLetterPrice(letter);
                total += price;
            }
            return total;
        }

        public int GetLetterPrice(char letter)
        {
            letter = Char.ToUpper(letter);
            if (!Alphabet.Contains(letter))
                throw new Exception("Is not a English letter");
            return Alphabet.IndexOf(letter) + 1;
        }

        public int GetNameScore(string name)
        {
            var nameIndex = Names.FindLastIndex(n => n.Equals(name)) + 1;
            var namePrice = GetNameValue(name);
            return nameIndex * namePrice;
        }
    }
}
