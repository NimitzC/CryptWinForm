namespace CryptWinForm
{
    partial class RSASignForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.publicKeyBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.privateKeyBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.openPublicKeyDialog = new System.Windows.Forms.OpenFileDialog();
            this.openPrivateKeyDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "签名/验证文件";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "选择文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "验证";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "签名";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 21);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(13, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 183);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "签名数据";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 55);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 122);
            this.textBox2.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "text.txt";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.privateKeyBox);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.publicKeyBox);
            this.groupBox3.Location = new System.Drawing.Point(13, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 108);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "选择公钥/私钥";
            // 
            // publicKeyBox
            // 
            this.publicKeyBox.Location = new System.Drawing.Point(8, 21);
            this.publicKeyBox.Name = "publicKeyBox";
            this.publicKeyBox.Size = new System.Drawing.Size(164, 21);
            this.publicKeyBox.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(174, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "选择公钥";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // privateKeyBox
            // 
            this.privateKeyBox.Location = new System.Drawing.Point(8, 49);
            this.privateKeyBox.Name = "privateKeyBox";
            this.privateKeyBox.Size = new System.Drawing.Size(164, 21);
            this.privateKeyBox.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(174, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "选择私钥";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(229, 26);
            this.button6.TabIndex = 4;
            this.button6.Text = "在以上路径生成公钥/私钥";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // openPublicKeyDialog
            // 
            this.openPublicKeyDialog.FileName = "publicKey.txt";
            // 
            // openPrivateKeyDialog
            // 
            this.openPrivateKeyDialog.FileName = "privateKey.txt";
            // 
            // RSASignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 408);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RSASignForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RSASignForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox privateKeyBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox publicKeyBox;
        private System.Windows.Forms.OpenFileDialog openPublicKeyDialog;
        private System.Windows.Forms.OpenFileDialog openPrivateKeyDialog;
    }
}