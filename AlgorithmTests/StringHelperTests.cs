using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void ReverseStringTest()
        {
            var initialStrings = new string[] { "12321", "farrukh" };
            var expectedStrings = new string[] { "12321", "hkurraf" };
            for (var i = 0; i < initialStrings.Length; i++)
            {
                var resultingString = StringHelpers.Reverse(initialStrings[i]);
                Assert.AreEqual(expectedStrings[i], resultingString);
            }
        }

        [TestMethod]
        public void GetDigitsTest()
        {
            Assert.AreEqual(1, StringHelpers.GetDigits(11));
            Assert.AreEqual(2, StringHelpers.GetDigits(1112));
            Assert.AreEqual(6, StringHelpers.GetDigits(115316));
        }
        [TestMethod]
        public void GetDecatesTest()
        {
            Assert.AreEqual(1, StringHelpers.GetDecates(11));
            Assert.AreEqual(1, StringHelpers.GetDecates(1112));
            Assert.AreEqual(1, StringHelpers.GetDecates(115316));
        }
        [TestMethod]
        public void GetHunderdsTest()
        {
            Assert.AreEqual(2, StringHelpers.GetHundreds(222));
            Assert.AreEqual(3, StringHelpers.GetHundreds(322));
            Assert.AreEqual(9, StringHelpers.GetHundreds(115916));
        }
        private List<Tuple<int, string>> Spellings = new List<Tuple<int, string>>()
        {
            new Tuple<int, string>(1,"one"),
            new Tuple<int, string>(2,"two"),
            new Tuple<int, string>(3,"three"),
            new Tuple<int, string>(4,"four"),
            new Tuple<int, string>(5,"five"),
            new Tuple<int, string>(6,"six"),
            new Tuple<int, string>(7,"seven"),
            new Tuple<int, string>(8,"eight"),
            new Tuple<int, string>(9,"nine"),
            new Tuple<int, string>(10,"ten"),
            new Tuple<int, string>(11,"eleven"),
            new Tuple<int, string>(12,"twelve"),
            new Tuple<int, string>(13,"thirteen"),
            new Tuple<int, string>(14,"fourteen"),
            new Tuple<int, string>(15,"fifteen"),
            new Tuple<int, string>(16,"sixteen"),
            new Tuple<int, string>(17,"seventeen"),
            new Tuple<int, string>(18,"eighteen"),
            new Tuple<int, string>(19,"nineteen"),
            new Tuple<int, string>(20,"twenty"),
            new Tuple<int, string>(30,"thirty"),
            new Tuple<int, string>(21,"twenty-one"),
            new Tuple<int, string>(22,"twenty-two"),
            new Tuple<int, string>(23,"twenty-three"),
            new Tuple<int, string>(34,"thirty-four"),
            new Tuple<int, string>(45,"forty-five"),
            new Tuple<int, string>(40,"forty"),
            new Tuple<int, string>(56,"fifty-six"),
            new Tuple<int, string>(50,"fifty"),
            new Tuple<int, string>(67,"sixty-seven"),
            new Tuple<int, string>(60,"sixty"),
            new Tuple<int, string>(78,"seventy-eight"),
            new Tuple<int, string>(70,"seventy"),
            new Tuple<int, string>(89,"eighty-nine"),
            new Tuple<int, string>(80,"eighty"),
            new Tuple<int, string>(98,"ninety-eight"),
            new Tuple<int, string>(90,"ninety"),
            new Tuple<int, string>(100,"one hundred"),
            new Tuple<int, string>(101,"one hundred and one"),
            new Tuple<int, string>(120,"one hundred and twenty"),
            new Tuple<int, string>(200,"two hundred"),
            new Tuple<int, string>(300,"three hundred"),
            new Tuple<int, string>(568,"five hundred and sixty-eight"),
            new Tuple<int, string>(1000,"one thousand"),
        };
        [TestMethod]
        public void TestRunner()
        {
            foreach (var tuple in Spellings)
            {
                var number = tuple.Item1;
                var spelling = tuple.Item2;
                GenericWordTest(number, spelling);
            }
        }
        public void GenericWordTest(int n, string spelling)
        {
            var resultSpelling = StringHelpers.SpellNumber(n);
            Assert.AreEqual(spelling, resultSpelling);
        }

        [TestMethod]
        public void EncryptTest()
        {
            Assert.AreEqual("10", StringHelpers.EncryptToNumbers("a"));
            Assert.AreEqual("11", StringHelpers.EncryptToNumbers("b"));
            Assert.AreEqual("56", StringHelpers.EncryptToNumbers(" "));
            Assert.AreEqual("1011", StringHelpers.EncryptToNumbers("ab"));
            Assert.AreEqual("321710295618285634243027562310221448", StringHelpers.EncryptToNumbers("What is your name?"));
            Assert.AreEqual("223456231022145618285651151027273020175147", StringHelpers.EncryptToNumbers("My name is 'Farrukh'."));
        }
        [TestMethod]
        public void DecryptTest()
        {
            Assert.AreEqual("a", StringHelpers.DecryptToWords("10"));
            Assert.AreEqual("b", StringHelpers.DecryptToWords("11"));
            Assert.AreEqual(" ", StringHelpers.DecryptToWords("56"));
            Assert.AreEqual("ab", StringHelpers.DecryptToWords("1011"));
            Assert.AreEqual("What is your name?".ToLower(), StringHelpers.DecryptToWords("321710295618285634243027562310221448"));
            Assert.AreEqual("My name is 'Farrukh'.".ToLower(), StringHelpers.DecryptToWords("223456231022145618285651151027273020175147"));
        }
        [TestMethod]
        public void EncryptDecryptIntegrationTest()
        {
            var messages = new string[]
            {
                @"But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure?",
                @"Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
            };
            foreach (var message in messages)
            {
                var messageToLower = message.ToLower();
                string messageInitialAsNumbers = StringHelpers.EncryptToNumbers(messageToLower);
                string actualMessage = StringHelpers.DecryptToWords(messageInitialAsNumbers);
                Console.WriteLine("Initial message: " + message);
                Console.WriteLine("Resulting message: " + actualMessage);
                Assert.AreEqual(messageToLower, actualMessage, "Messages are different");
            }
        }
    }
}
