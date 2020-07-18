using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgorithmsCore;

namespace Chat
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        private void btnGetPublicKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTunnel.Text))
            {
                tbxChat.Text += "The tunnel should not be empty \n";
                return;
            }
            var tunnelUrl = tbxTunnel.Text;
            var keys = HttpClientHelper.GetStaticPublicKey(tunnelUrl);
            if (keys == null)
            {
                tbxChat.Text += "No keys returned \n";
                return;
            }
            var publicKey = keys[0];
            var modulus = keys[1];
            tbxPartnerModulus.Text = modulus.Trim('"');
            tbxPartnerPublicKey.Text = publicKey.Trim('"');
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTunnel.Text))
            {
                tbxChat.Text += "The tunnel should not be empty \n";
                return;
            }
            var tunnelUrl = tbxTunnel.Text;
            var keys = HttpClientHelper.GetKeys(tunnelUrl);
            var publicKey = keys[0];
            var privateKey = keys[1];
            var modulus = keys[2];
            tbxMyModulus.Text = modulus.Trim('"');
            tbxMyPrivateKey.Text = privateKey.Trim('"');
            tbxMyPublicKey.Text = publicKey.Trim('"');
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTunnel.Text))
            {
                tbxChat.Text += "The tunnel should not be empty " + Environment.NewLine;
                return;
            }
            if (string.IsNullOrEmpty(tbxMessage.Text))
            {
                tbxChat.Text += "The message should not be empty \n" + Environment.NewLine;
                return;
            }
            var tunnelUrl = tbxTunnel.Text;
            var message = tbxMessage.Text;
            var messagesAsNumbers = BigInteger.Parse(StringHelpers.EncryptToNumbers(message));
            var publicKey = BigInteger.Parse(tbxPartnerPublicKey.Text);
            var modulus = BigInteger.Parse(tbxPartnerModulus.Text);
            var encryptedMessage = Algorithms.RSAEncrypt(publicKey, modulus, messagesAsNumbers);
            var serverResponce = HttpClientHelper.Send(tunnelUrl, encryptedMessage.ToString());
            tbxChat.Text += "Your message: " + message + Environment.NewLine;
            tbxChat.Text += "Your message as numbers: " + messagesAsNumbers + Environment.NewLine;
            tbxChat.Text += "Server responce: " + serverResponce + "\n";
            tbxChat.Text += "======================================" + Environment.NewLine;


        }
    }
}
