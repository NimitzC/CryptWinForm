namespace CryptWinForm
{
    partial class RSACryptForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openPublicKeyDialog = new System.Windows.Forms.OpenFileDialog();
            this.openPrivateKeyDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox4 = new System.Windows.Forms.RichTextBox();
            this.textBox5 = new System.Windows.Forms.RichTextBox();
            this.publicKeyBox = new System.Windows.Forms.RichTextBox();
            this.privateKeyBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.86059F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.13941F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(528, 591);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.privateKeyBox);
            this.groupBox1.Controls.Add(this.publicKeyBox);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "公钥/私钥";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(469, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 96);
            this.button3.TabIndex = 4;
            this.button3.Text = "选择私钥";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "选择公钥";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 148);
            this.button1.TabIndex = 1;
            this.button1.Text = "生成公钥/私钥对";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(3, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "导出公钥/私钥";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(377, 47);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(61, 23);
            this.button10.TabIndex = 6;
            this.button10.Text = "私钥导出";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(168, 47);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(62, 23);
            this.button9.TabIndex = 5;
            this.button9.Text = "公钥导出";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(236, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 21);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "privateKey.txt";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "publicKey.txt";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(444, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 22);
            this.button5.TabIndex = 2;
            this.button5.Text = "选择目录";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(444, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "全部导出";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(432, 21);
            this.textBox2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Location = new System.Drawing.Point(3, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 307);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "使用【公钥/私钥】进行【加密/解密】文件";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 276);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(418, 21);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "这里显示了当前导出文件后的地址";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(430, 276);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(86, 22);
            this.button11.TabIndex = 8;
            this.button11.Text = "导出生成文件";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(463, 212);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(53, 60);
            this.button8.TabIndex = 7;
            this.button8.Text = "使用密钥解密";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(463, 149);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 60);
            this.button7.TabIndex = 6;
            this.button7.Text = "使用公钥加密";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(463, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 123);
            this.button6.TabIndex = 5;
            this.button6.Text = "选择文件";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openPublicKeyDialog
            // 
            this.openPublicKeyDialog.FileName = "publicKey.txt";
            // 
            // openPrivateKeyDialog
            // 
            this.openPrivateKeyDialog.FileName = "privateKey.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Text.txt";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(451, 123);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(7, 150);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(450, 122);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "";
            // 
            // publicKeyBox
            // 
            this.publicKeyBox.Location = new System.Drawing.Point(78, 20);
            this.publicKeyBox.Name = "publicKeyBox";
            this.publicKeyBox.ReadOnly = true;
            this.publicKeyBox.Size = new System.Drawing.Size(385, 46);
            this.publicKeyBox.TabIndex = 5;
            this.publicKeyBox.Text = "";
            // 
            // privateKeyBox
            // 
            this.privateKeyBox.Location = new System.Drawing.Point(78, 73);
            this.privateKeyBox.Name = "privateKeyBox";
            this.privateKeyBox.ReadOnly = true;
            this.privateKeyBox.Size = new System.Drawing.Size(385, 95);
            this.privateKeyBox.TabIndex = 6;
            this.privateKeyBox.Text = "";
            // 
            // RSACryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 615);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RSACryptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RSACryptForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openPublicKeyDialog;
        private System.Windows.Forms.OpenFileDialog openPrivateKeyDialog;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox textBox4;
        private System.Windows.Forms.RichTextBox textBox5;
        private System.Windows.Forms.RichTextBox privateKeyBox;
        private System.Windows.Forms.RichTextBox publicKeyBox;
    }
}