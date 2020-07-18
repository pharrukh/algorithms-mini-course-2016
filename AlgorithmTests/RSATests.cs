using System;
using System.Numerics;
using System.Security.AccessControl;
using AlgorithmsCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests
{
    [TestClass]
    public class RSATests
    {
        [TestMethod]
        public void RSATest()
        {
            int[] ints = { 123, 234, 233, 323, 999, 888, 245, 101, 100, 1000, 1999 };
            var privateKey = 2753;
            var publicKey = 17;
            var modulus = 3233;
            foreach (var m in ints)
            {
                Console.WriteLine("Initial Message: " + m);
                var encryptedMessage = Algorithms.RSAEncrypt(publicKey, modulus, m);
                Console.WriteLine("Encrypted Message: " + encryptedMessage);
                var decryptedMessage = Algorithms.RSADecrypt(privateKey, modulus, encryptedMessage);
                Console.WriteLine("Decrypted Message: " + decryptedMessage);
                Assert.AreEqual(m, decryptedMessage);
            }
        }
        public void RSATest_Two(BigInteger m)
        {
            var keys = Algorithms.RSAGetKeys();
            var privateKey = keys.GetPrivateKey();
            var publicKey = keys.GetPublicKey();
            var modulus = keys.GetModulus();
            Console.WriteLine("Initial Message: " + m);
            var encryptedMessage = Algorithms.RSAEncrypt(publicKey, modulus, m);
            Console.WriteLine("Encrypted Message: " + encryptedMessage);
            var decryptedMessage = Algorithms.RSADecrypt(privateKey, modulus, encryptedMessage);
            Console.WriteLine("Decrypted Message: " + decryptedMessage);
            Console.WriteLine("My value: " + decryptedMessage + ". Correct: " + m);
            Assert.AreEqual(m, decryptedMessage);
        }
        [TestMethod]
        public void RSATest_Three()
        {
            var m = BigInteger.Parse("1976620216402300889624482718775150");
            var p = BigInteger.Parse("12131072439211271897323671531612440428472427633701410925634549312301964373042085619324197365322416866541017057361365214171711713797974299334871062829803541");
            var q = BigInteger.Parse("12027524255478748885956220793734512128733387803682075433653899983955179850988797899869146900809131611153346817050832096022160146366346391812470987105415233");
            var modulus = BigInteger.Parse("145906768007583323230186939349070635292401872375357164399581871019873438799005358938369571402670149802121818086292467422828157022922076746906543401224889672472407926969987100581290103199317858753663710862357656510507883714297115637342788911463535102712032765166518411726859837988672111837205085526346618740053");
            var totient = BigInteger.Parse("145906768007583323230186939349070635292401872375357164399581871019873438799005358938369571402670149802121818086292467422828157022922076746906543401224889648313811232279966317301397777852365301547848273478871297222058587457152891606459269718119268971163555070802643999529549644116811947516513938184296683521280");
            var public_key = BigInteger.Parse("65537");
            var private_key = BigInteger.Parse("89489425009274444368228545921773093919669586065884257445497854456487674839629818390934941973262879616797970608917283679875499331574161113854088813275488110588247193077582527278437906504015680623423550067240042466665654232383502922215493623289472138866445818789127946123407807725702626644091036502372545139713");
            Console.WriteLine("Initial Message: " + m);
            BigInteger encryptedMessage = Algorithms.RSAEncrypt(public_key, modulus, m);
            Console.WriteLine("Encrypted Message: " + encryptedMessage);
            BigInteger decryptedMessage = Algorithms.RSADecrypt(private_key, modulus, encryptedMessage);
            Console.WriteLine("Decrypted Message: " + decryptedMessage);
            Console.WriteLine("My value: " + decryptedMessage + ". Correct: " + m);
            Assert.AreEqual(m, decryptedMessage);
        }

        [TestMethod]
        public void TestRunner()
        {
            for (int i = 0; i < 10; i++)
            {
                var length = i + 10;
                var message = Algorithms.GetBigPrime(length);
                Console.WriteLine("The test number: " + i);
                RSATest_Two(message);
            }
        }

        [TestMethod]
        public void Encryption()
        {
            var encrypted = Algorithms.RSAEncrypt(17, 3233, 123);
            Assert.AreEqual(855, encrypted);
        }
        [TestMethod]
        public void Decryption()
        {
            var encrypted = Algorithms.RSADecrypt(2753, 3233, 855);
            Assert.AreEqual(123, encrypted);
        }
        /////////////////////
        /// Integration Testing
        /////////////////////
        [TestMethod]
        public void RSAIntegrationTest_NumbersSpelled()
        {
            var keys = Algorithms.RSAGetKeys();
            var modulus = keys.GetModulus();
            var publicKey = keys.GetPublicKey();
            var privateKey = keys.GetPrivateKey();
            for (var i = 1000; i > 900; i--)
            {
                var initialMessage = "'" + StringHelpers.SpellNumber(i) + "'";
                RunRSATest(publicKey, privateKey, modulus, initialMessage);
            }
        }
        [TestMethod]
        public void RSAIntegrationTest_LongMessages()
        {
            var keys = Algorithms.RSAGetKeys();
            var modulus = keys.GetModulus();
            var publicKey = keys.GetPublicKey();
            var privateKey = keys.GetPrivateKey();

            for (var i = 2; i < 100; i++)
            {
                var randomNumber = Algorithms.GenerateRandomWithString(i);
                RunRSATest(publicKey, privateKey, modulus, randomNumber.ToString());
            }
        }
        public void RunRSATest(BigInteger publicKey, BigInteger privateKey, BigInteger modulus, string message)
        {
            string messageInitialAsNumbers = StringHelpers.EncryptToNumbers(message);
            BigInteger messageAsNumber = BigInteger.Parse(messageInitialAsNumbers);
            BigInteger encryptedMessage = Algorithms.RSAEncrypt(publicKey, modulus, messageAsNumber);
            BigInteger decryptedMessage = Algorithms.RSADecrypt(privateKey, modulus, encryptedMessage);
            string actualMessage = StringHelpers.DecryptToWords(decryptedMessage.ToString());
            Console.WriteLine("Initial message: " + message);
            Console.WriteLine("Resulting message: " + actualMessage);
            Assert.AreEqual(message, actualMessage, "Messages are different");
        }
    }
}
