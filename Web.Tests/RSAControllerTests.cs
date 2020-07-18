﻿using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Web.Controllers;

namespace Web.Tests
{
    [TestClass]
    public class RSAControllerTests
    {
        private string PublicKey = "65537";

        private string Modulus =
            "145906768007583323230186939349070635292401872375357164399581871019873438799005358938369571402670149802121818086292467422828157022922076746906543401224889672472407926969987100581290103199317858753663710862357656510507883714297115637342788911463535102712032765166518411726859837988672111837205085526346618740053";

        private string PrivateKey =
            "89489425009274444368228545921773093919669586065884257445497854456487674839629818390934941973262879616797970608917283679875499331574161113854088813275488110588247193077582527278437906504015680623423550067240042466665654232383502922215493623289472138866445818789127946123407807725702626644091036502372545139713";

        private RSAController controller;
        [TestInitialize]
        public void TestSetUp()
        { controller = new RSAController(); }

        [TestMethod]
        public void EncryptTest()
        {
            var m = "1976620216402300889624482718775150";
            var expectedEncryptedMessage = "35052111338673026690212423937053328511880760811579981620642802346685810623109850235943049080973386241113784040794704193978215378499765413083646438784740952306932534945195080183861574225226218879827232453912820596886440377536082465681750074417459151485407445862511023472235560823053497791518928820272257787786";
            var actualEncryptedMessage = controller.Static_Encrypt(m);
            Assert.AreEqual(expectedEncryptedMessage, actualEncryptedMessage);
        }
        [TestMethod]
        public void DecryptTest()
        {
            var encryptedMessage = "35052111338673026690212423937053328511880760811579981620642802346685810623109850235943049080973386241113784040794704193978215378499765413083646438784740952306932534945195080183861574225226218879827232453912820596886440377536082465681750074417459151485407445862511023472235560823053497791518928820272257787786";
            var actualDecryptedMessage = controller.Static_Decrypt(encryptedMessage);
            var expectedDecryptedMessage = "1976620216402300889624482718775150";
            Assert.AreEqual(expectedDecryptedMessage, actualDecryptedMessage);
        }
        [TestMethod]
        public void GetPublicKeyTest()
        {
            CollectionAssert.AreEqual(new[] { PublicKey, Modulus }, controller.Get_Static_Public_Key());
        }
        [TestMethod]
        public void RSAIntegrationTest()
        {
            int[] ints = { 123, 234, 233, 323, 999, 888, 245, 101, 100, 1000, 1999 };
            foreach (var m in ints)
            {
                string[] keys = controller.Get_Keys();
                var publicKey = keys[0];
                var privateKey = keys[1];
                var modulus = keys[2];

                Console.WriteLine("Initial Message: " + m);
                var encryptedMessage = controller.Encrypt(m.ToString(), publicKey, modulus);
                Console.WriteLine("Encrypted Message: " + encryptedMessage);
                var decryptedMessage = controller.Decrypt(encryptedMessage, privateKey, modulus);
                Console.WriteLine("Decrypted Message: " + decryptedMessage);
                Assert.AreEqual(m.ToString(), decryptedMessage);
            }
        }
    }
}
