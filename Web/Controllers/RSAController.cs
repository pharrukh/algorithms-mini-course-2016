using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Numerics;
using System.Web.Http;
using AlgorithmsCore;
using Data;

namespace Web.Controllers
{
    public class RSAController : ApiController
    {
        public string PublicKey = "65537";
        public string Modulus = "145906768007583323230186939349070635292401872375357164399581871019873438799005358938369571402670149802121818086292467422828157022922076746906543401224889672472407926969987100581290103199317858753663710862357656510507883714297115637342788911463535102712032765166518411726859837988672111837205085526346618740053";
        public string PrivateKey = "89489425009274444368228545921773093919669586065884257445497854456487674839629818390934941973262879616797970608917283679875499331574161113854088813275488110588247193077582527278437906504015680623423550067240042466665654232383502922215493623289472138866445818789127946123407807725702626644091036502372545139713";
        [HttpGet]
        public string[] Get_Static_Public_Key()
        {
            return new[] { PublicKey, Modulus };
        }
        [HttpPost]
        public string Static_Encrypt([FromBody] string message)
        {
            return Algorithms.RSAEncrypt(BigInteger.Parse(PublicKey), BigInteger.Parse(Modulus), BigInteger.Parse(message)).ToString();
        }
        [HttpPost]
        public string Static_Decrypt([FromBody] string message)
        {
            return Algorithms.RSADecrypt(BigInteger.Parse(PrivateKey), BigInteger.Parse(Modulus), BigInteger.Parse(message)).ToString();
        }

        /// <summary>
        /// Returns 3 keys in the following order: public, private, modulus
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string[] Get_Keys()
        {
            var keys = Algorithms.RSAGetKeys();
            var privateKey = keys.GetPrivateKey().ToString();
            var publicKey = keys.GetPublicKey().ToString();
            var modulus = keys.GetModulus().ToString();
            return new[] { publicKey, privateKey, modulus };
        }
        [HttpGet]
        public string Encrypt(string message, string publicKey, string modulus)
        {
            return Algorithms.RSAEncrypt(BigInteger.Parse(publicKey), BigInteger.Parse(modulus), BigInteger.Parse(message)).ToString();
        }
        [HttpGet]
        public string Decrypt(string message, string privateKey, string modulus)
        {
            return Algorithms.RSADecrypt(BigInteger.Parse(privateKey), BigInteger.Parse(modulus), BigInteger.Parse(message)).ToString();
        }

        [HttpGet]
        public IHttpActionResult Send(string message)
        {
            if (string.IsNullOrEmpty(message))
                return BadRequest("Message must not be null");
            var decryptedMessageInNumbers = Algorithms.RSADecrypt(BigInteger.Parse(PrivateKey), BigInteger.Parse(Modulus), BigInteger.Parse(message));
            var decryptedMessageInWords = StringHelpers.DecryptToWords(decryptedMessageInNumbers.ToString());
            var dbManager = new DatabaseManager();
            dbManager.AddMessage(message, decryptedMessageInWords, PrivateKey, PublicKey, Modulus);
            return Ok("I added your message to DB");
        }

        [HttpPost]
        public IHttpActionResult Test()
        {
            return Ok("Works");
        }
        [HttpPost]
        public HttpResponseMessage TestWithParam([FromBody]object message)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
