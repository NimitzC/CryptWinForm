using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptWinForm
{
    public partial class AESCryptForm : Form
    {
        public AESCryptForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            //获取所打开文件的文件名
            string filename = openFileDialog1.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                textBox1.Text = filename;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            string filename = saveFileDialog1.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                textBox2.Text = filename;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "201630598565zzy";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string pwd = textBox3.Text;
            string plainTextPath = textBox1.Text;
            string encryptedPath = textBox2.Text;
            if(string.IsNullOrEmpty(plainTextPath) || string.IsNullOrEmpty(encryptedPath))
            {
                MessageBox.Show("文件地址不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!FileCrypto.AesEncrypt(plainTextPath, encryptedPath, pwd))
            {
                MessageBox.Show($"加密文件失败\n", "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show("加密文件成功！\n是否打开生成源文件与生成文件？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(plainTextPath);
                System.Diagnostics.Process.Start(encryptedPath);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string pwd = textBox3.Text;
            string encryptedPath = textBox1.Text;
            string decryptedPath = textBox2.Text;
            if (string.IsNullOrEmpty(encryptedPath) || string.IsNullOrEmpty(decryptedPath))
            {
                MessageBox.Show("文件地址不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!FileCrypto.AesDecrypt(encryptedPath, decryptedPath, pwd))
            {
                MessageBox.Show($"解密文件失败或口令错误\n", "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show("解密文件成功！\n是否打开生成源文件与生成文件？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(encryptedPath);
                System.Diagnostics.Process.Start(decryptedPath);
            }
        }
    }
}
