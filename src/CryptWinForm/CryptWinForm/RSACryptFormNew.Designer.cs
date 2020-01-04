namespace CryptWinForm
{
    partial class RSACryptFormNew
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.srcFileBox = new System.Windows.Forms.TextBox();
            this.selectSrcFileButton = new System.Windows.Forms.Button();
            this.destFileBox = new System.Windows.Forms.TextBox();
            this.selectDestFileButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.publicKeyPathBox = new System.Windows.Forms.TextBox();
            this.selectPublicKeyFileButton = new System.Windows.Forms.Button();
            this.privateKeyPathBox = new System.Windows.Forms.TextBox();
            this.selectPrivateKeyFileButton = new System.Windows.Forms.Button();
            this.generateKeyButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.publicKeyPreview = new System.Windows.Forms.RichTextBox();
            this.privateKeyPreview = new System.Windows.Forms.RichTextBox();
            this.srcPreview = new System.Windows.Forms.RichTextBox();
            this.destPreview = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.openPublicKeyDialog = new System.Windows.Forms.OpenFileDialog();
            this.openPrivateKeyDialog = new System.Windows.Forms.OpenFileDialog();
            this.openSrcFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDestFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectSrcFileButton);
            this.groupBox1.Controls.Add(this.srcFileBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "源文件";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectDestFileButton);
            this.groupBox2.Controls.Add(this.destFileBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "目的文件";
            // 
            // srcFileBox
            // 
            this.srcFileBox.Location = new System.Drawing.Point(7, 21);
            this.srcFileBox.Name = "srcFileBox";
            this.srcFileBox.Size = new System.Drawing.Size(225, 21);
            this.srcFileBox.TabIndex = 0;
            // 
            // selectSrcFileButton
            // 
            this.selectSrcFileButton.Location = new System.Drawing.Point(6, 48);
            this.selectSrcFileButton.Name = "selectSrcFileButton";
            this.selectSrcFileButton.Size = new System.Drawing.Size(227, 23);
            this.selectSrcFileButton.TabIndex = 1;
            this.selectSrcFileButton.Text = "选择源文件";
            this.selectSrcFileButton.UseVisualStyleBackColor = true;
            this.selectSrcFileButton.Click += new System.EventHandler(this.selectSrcFileButton_Click);
            // 
            // destFileBox
            // 
            this.destFileBox.Location = new System.Drawing.Point(7, 20);
            this.destFileBox.Name = "destFileBox";
            this.destFileBox.Size = new System.Drawing.Size(225, 21);
            this.destFileBox.TabIndex = 0;
            // 
            // selectDestFileButton
            // 
            this.selectDestFileButton.Location = new System.Drawing.Point(6, 47);
            this.selectDestFileButton.Name = "selectDestFileButton";
            this.selectDestFileButton.Size = new System.Drawing.Size(227, 23);
            this.selectDestFileButton.TabIndex = 1;
            this.selectDestFileButton.Text = "选择目的文件";
            this.selectDestFileButton.UseVisualStyleBackColor = true;
            this.selectDestFileButton.Click += new System.EventHandler(this.selectDestFileButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.publicKeyPreview, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.privateKeyPreview, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.srcPreview, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.destPreview, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(262, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(348, 423);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.generateKeyButton);
            this.groupBox3.Controls.Add(this.selectPrivateKeyFileButton);
            this.groupBox3.Controls.Add(this.privateKeyPathBox);
            this.groupBox3.Controls.Add(this.selectPublicKeyFileButton);
            this.groupBox3.Controls.Add(this.publicKeyPathBox);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 184);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "选择公钥/私钥";
            // 
            // publicKeyPathBox
            // 
            this.publicKeyPathBox.Location = new System.Drawing.Point(6, 21);
            this.publicKeyPathBox.Name = "publicKeyPathBox";
            this.publicKeyPathBox.Size = new System.Drawing.Size(226, 21);
            this.publicKeyPathBox.TabIndex = 0;
            // 
            // selectPublicKeyFileButton
            // 
            this.selectPublicKeyFileButton.Location = new System.Drawing.Point(6, 48);
            this.selectPublicKeyFileButton.Name = "selectPublicKeyFileButton";
            this.selectPublicKeyFileButton.Size = new System.Drawing.Size(227, 23);
            this.selectPublicKeyFileButton.TabIndex = 1;
            this.selectPublicKeyFileButton.Text = "选择公钥";
            this.selectPublicKeyFileButton.UseVisualStyleBackColor = true;
            this.selectPublicKeyFileButton.Click += new System.EventHandler(this.selectPublicKeyFileButton_Click);
            // 
            // privateKeyPathBox
            // 
            this.privateKeyPathBox.Location = new System.Drawing.Point(7, 79);
            this.privateKeyPathBox.Name = "privateKeyPathBox";
            this.privateKeyPathBox.Size = new System.Drawing.Size(225, 21);
            this.privateKeyPathBox.TabIndex = 2;
            // 
            // selectPrivateKeyFileButton
            // 
            this.selectPrivateKeyFileButton.Location = new System.Drawing.Point(6, 106);
            this.selectPrivateKeyFileButton.Name = "selectPrivateKeyFileButton";
            this.selectPrivateKeyFileButton.Size = new System.Drawing.Size(227, 23);
            this.selectPrivateKeyFileButton.TabIndex = 3;
            this.selectPrivateKeyFileButton.Text = "选择私钥";
            this.selectPrivateKeyFileButton.UseVisualStyleBackColor = true;
            this.selectPrivateKeyFileButton.Click += new System.EventHandler(this.selectPrivateKeyFileButton_Click);
            // 
            // generateKeyButton
            // 
            this.generateKeyButton.Location = new System.Drawing.Point(6, 136);
            this.generateKeyButton.Name = "generateKeyButton";
            this.generateKeyButton.Size = new System.Drawing.Size(227, 42);
            this.generateKeyButton.TabIndex = 4;
            this.generateKeyButton.Text = "在以上路径自动生成公钥/私钥";
            this.generateKeyButton.UseVisualStyleBackColor = true;
            this.generateKeyButton.Click += new System.EventHandler(this.generateKeyButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // publicKeyPreview
            // 
            this.publicKeyPreview.Location = new System.Drawing.Point(3, 3);
            this.publicKeyPreview.Name = "publicKeyPreview";
            this.publicKeyPreview.ReadOnly = true;
            this.publicKeyPreview.Size = new System.Drawing.Size(342, 68);
            this.publicKeyPreview.TabIndex = 0;
            this.publicKeyPreview.Text = "";
            // 
            // privateKeyPreview
            // 
            this.privateKeyPreview.Location = new System.Drawing.Point(3, 79);
            this.privateKeyPreview.Name = "privateKeyPreview";
            this.privateKeyPreview.ReadOnly = true;
            this.privateKeyPreview.Size = new System.Drawing.Size(342, 104);
            this.privateKeyPreview.TabIndex = 1;
            this.privateKeyPreview.Text = "";
            // 
            // srcPreview
            // 
            this.srcPreview.Location = new System.Drawing.Point(3, 190);
            this.srcPreview.Name = "srcPreview";
            this.srcPreview.ReadOnly = true;
            this.srcPreview.Size = new System.Drawing.Size(342, 107);
            this.srcPreview.TabIndex = 2;
            this.srcPreview.Text = "";
            // 
            // destPreview
            // 
            this.destPreview.Location = new System.Drawing.Point(3, 303);
            this.destPreview.Name = "destPreview";
            this.destPreview.ReadOnly = true;
            this.destPreview.Size = new System.Drawing.Size(342, 117);
            this.destPreview.TabIndex = 3;
            this.destPreview.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.encryptButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.decryptButton, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 359);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(238, 64);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(3, 3);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(113, 58);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "使用公钥加密";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(122, 3);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(113, 58);
            this.decryptButton.TabIndex = 1;
            this.decryptButton.Text = "使用私钥解密";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // openPublicKeyDialog
            // 
            this.openPublicKeyDialog.FileName = "publicKey.txt";
            // 
            // openPrivateKeyDialog
            // 
            this.openPrivateKeyDialog.FileName = "privateKey.txt";
            // 
            // openSrcFileDialog
            // 
            this.openSrcFileDialog.FileName = "src.txt";
            // 
            // saveDestFileDialog
            // 
            this.saveDestFileDialog.FileName = "dest.txt";
            // 
            // RSACryptFormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RSACryptFormNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RSACryptFormNew";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button selectSrcFileButton;
        private System.Windows.Forms.TextBox srcFileBox;
        private System.Windows.Forms.Button selectDestFileButton;
        private System.Windows.Forms.TextBox destFileBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox publicKeyPreview;
        private System.Windows.Forms.RichTextBox privateKeyPreview;
        private System.Windows.Forms.Button generateKeyButton;
        private System.Windows.Forms.Button selectPrivateKeyFileButton;
        private System.Windows.Forms.TextBox privateKeyPathBox;
        private System.Windows.Forms.Button selectPublicKeyFileButton;
        private System.Windows.Forms.TextBox publicKeyPathBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox srcPreview;
        private System.Windows.Forms.RichTextBox destPreview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.OpenFileDialog openPublicKeyDialog;
        private System.Windows.Forms.OpenFileDialog openPrivateKeyDialog;
        private System.Windows.Forms.OpenFileDialog openSrcFileDialog;
        private System.Windows.Forms.SaveFileDialog saveDestFileDialog;
    }
}