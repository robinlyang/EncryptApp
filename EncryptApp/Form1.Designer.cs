namespace EncryptApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.encrypt = new System.Windows.Forms.Button();
            this.cipher = new System.Windows.Forms.TextBox();
            this.decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(16, 30);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(593, 20);
            this.message.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key";
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(19, 74);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(590, 20);
            this.key.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cipher";
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(19, 101);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(590, 23);
            this.encrypt.TabIndex = 5;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // cipher
            // 
            this.cipher.Location = new System.Drawing.Point(19, 144);
            this.cipher.Name = "cipher";
            this.cipher.Size = new System.Drawing.Size(590, 20);
            this.cipher.TabIndex = 6;
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(19, 171);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(590, 23);
            this.decrypt.TabIndex = 7;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 210);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.cipher);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Encrypt App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.TextBox cipher;
        private System.Windows.Forms.Button decrypt;
    }
}

