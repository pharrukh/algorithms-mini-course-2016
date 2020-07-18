using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public static class HttpClientHelper
    {
        public static string[] GetKeys(string url)
        {
            string[] keys = new string[3];
            // Create a request for the URL. 
            WebRequest request = WebRequest.Create(url + "/api/RSA/Get_Keys");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            if (dataStream != null)
            {
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                responseFromServer = responseFromServer.Trim(new char[] { '[', ']' });
                keys = responseFromServer.Split(',');
                // Display the content.
                Console.WriteLine(responseFromServer);
                // Clean up the streams and the response.
                reader.Close();
            }
            response.Close();
            return keys;
        }
        public static string[] GetStaticPublicKey(string url)
        {
            string[] keys = new string[2];
            try
            {
                // Create a request for the URL. 
                WebRequest request = WebRequest.Create(url + "/api/RSA/Get_Static_Public_Key");
                // If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials;
                // Get the response.
                WebResponse response = request.GetResponse();
                // Display the status.
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                if (dataStream != null)
                {
                    StreamReader reader = new StreamReader(dataStream);
                    // Read the content.
                    string responseFromServer = reader.ReadToEnd();
                    responseFromServer = responseFromServer.Trim(new char[] { '[', ']' });
                    keys = responseFromServer.Split(',');
                    // Display the content.
                    Console.WriteLine(responseFromServer);
                    // Clean up the streams and the response.
                    reader.Close();
                }
                response.Close();
            }
            catch (Exception ex) { }
            return keys;
        }
        public static string Send(string url, string message)
        {
            string responseFromServer;
            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.GetAsync(url + "/api/rsa/send" + "?message=" + message).Result;

                    responseFromServer = response.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                responseFromServer = ex.Message;
            }
            return responseFromServer;
        }
    }
}
