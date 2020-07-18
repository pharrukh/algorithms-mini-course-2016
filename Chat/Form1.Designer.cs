namespace Chat
{
    partial class Chat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetPublicKey = new System.Windows.Forms.Button();
            this.tbxChat = new System.Windows.Forms.TextBox();
            this.tbxPartnerPublicKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPartnerModulus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMyPrivateKey = new System.Windows.Forms.TextBox();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxMyModulus = new System.Windows.Forms.TextBox();
            this.tbxMyPublicKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxTunnel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetPublicKey
            // 
            this.btnGetPublicKey.Location = new System.Drawing.Point(401, 330);
            this.btnGetPublicKey.Name = "btnGetPublicKey";
            this.btnGetPublicKey.Size = new System.Drawing.Size(188, 54);
            this.btnGetPublicKey.TabIndex = 0;
            this.btnGetPublicKey.Text = "Get Public Key";
            this.btnGetPublicKey.UseVisualStyleBackColor = true;
            this.btnGetPublicKey.Click += new System.EventHandler(this.btnGetPublicKey_Click);
            // 
            // tbxChat
            // 
            this.tbxChat.Location = new System.Drawing.Point(626, 38);
            this.tbxChat.Multiline = true;
            this.tbxChat.Name = "tbxChat";
            this.tbxChat.Size = new System.Drawing.Size(528, 1068);
            this.tbxChat.TabIndex = 1;
            // 
            // tbxPartnerPublicKey
            // 
            this.tbxPartnerPublicKey.Location = new System.Drawing.Point(44, 71);
            this.tbxPartnerPublicKey.Multiline = true;
            this.tbxPartnerPublicKey.Name = "tbxPartnerPublicKey";
            this.tbxPartnerPublicKey.Size = new System.Drawing.Size(545, 79);
            this.tbxPartnerPublicKey.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Partner Public Key";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(415, 616);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(188, 54);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(44, 450);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(559, 140);
            this.tbxMessage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your Message";
            // 
            // tbxPartnerModulus
            // 
            this.tbxPartnerModulus.AcceptsReturn = true;
            this.tbxPartnerModulus.Location = new System.Drawing.Point(44, 199);
            this.tbxPartnerModulus.Multiline = true;
            this.tbxPartnerModulus.Name = "tbxPartnerModulus";
            this.tbxPartnerModulus.Size = new System.Drawing.Size(545, 93);
            this.tbxPartnerModulus.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Partner Modulus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 655);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Your Private Key";
            // 
            // tbxMyPrivateKey
            // 
            this.tbxMyPrivateKey.Location = new System.Drawing.Point(44, 692);
            this.tbxMyPrivateKey.Multiline = true;
            this.tbxMyPrivateKey.Name = "tbxMyPrivateKey";
            this.tbxMyPrivateKey.Size = new System.Drawing.Size(559, 83);
            this.tbxMyPrivateKey.TabIndex = 6;
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Location = new System.Drawing.Point(415, 1052);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(188, 54);
            this.btnGenerateKeys.TabIndex = 5;
            this.btnGenerateKeys.Text = "Generate Keys";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 906);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Your Modulus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 780);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Your Public Key";
            // 
            // tbxMyModulus
            // 
            this.tbxMyModulus.AcceptsReturn = true;
            this.tbxMyModulus.Location = new System.Drawing.Point(44, 937);
            this.tbxMyModulus.Multiline = true;
            this.tbxMyModulus.Name = "tbxMyModulus";
            this.tbxMyModulus.Size = new System.Drawing.Size(559, 93);
            this.tbxMyModulus.TabIndex = 8;
            // 
            // tbxMyPublicKey
            // 
            this.tbxMyPublicKey.Location = new System.Drawing.Point(44, 815);
            this.tbxMyPublicKey.Multiline = true;
            this.tbxMyPublicKey.Name = "tbxMyPublicKey";
            this.tbxMyPublicKey.Size = new System.Drawing.Size(559, 79);
            this.tbxMyPublicKey.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tunnel";
            // 
            // tbxTunnel
            // 
            this.tbxTunnel.Location = new System.Drawing.Point(44, 342);
            this.tbxTunnel.Multiline = true;
            this.tbxTunnel.Name = "tbxTunnel";
            this.tbxTunnel.Size = new System.Drawing.Size(330, 31);
            this.tbxTunnel.TabIndex = 12;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 1143);
            this.Controls.Add(this.tbxTunnel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxMyModulus);
            this.Controls.Add(this.tbxMyPublicKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxMyPrivateKey);
            this.Controls.Add(this.btnGenerateKeys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.tbxPartnerModulus);
            this.Controls.Add(this.tbxPartnerPublicKey);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxChat);
            this.Controls.Add(this.btnGetPublicKey);
            this.Name = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetPublicKey;
        private System.Windows.Forms.TextBox tbxChat;
        private System.Windows.Forms.TextBox tbxPartnerPublicKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPartnerModulus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxMyPrivateKey;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxMyModulus;
        private System.Windows.Forms.TextBox tbxMyPublicKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxTunnel;
    }
}

