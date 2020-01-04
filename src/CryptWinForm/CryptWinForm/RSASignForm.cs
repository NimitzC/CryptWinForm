using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CryptWinForm
{
    public partial class RSASignForm : Form
    {
        public RSASignForm()
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
                textBox2.Text = Encoding.UTF8.GetString(FileCrypto.ReadBytesFromFile(filename));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textPath = textBox1.Text;
            if (string.IsNullOrEmpty(textPath))
            {
                MessageBox.Show("文件地址不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string outPath = Path.GetDirectoryName(textPath) + "\\signed_" + Path.GetFileName(textPath);

            string privateKeyPath = privateKeyBox.Text;
            if (string.IsNullOrEmpty(privateKeyPath))
            {
                MessageBox.Show("私钥地址不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string privateKey = FileCrypto.RsaReadKeyFromFile(privateKeyPath);

            //sign
            if(!FileCrypto.RsaSign(textPath, outPath, privateKey))
            {
                MessageBox.Show($"签名文件失败\n", "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            textBox2.Text = Encoding.UTF8.GetString(FileCrypto.ReadBytesFromFile(outPath));
            MessageBox.Show($"成功签名文件！\n已保存至路径：{outPath}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = openPublicKeyDialog.ShowDialog();
            //获取所打开文件的文件名
            string filename = openPublicKeyDialog.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                publicKeyBox.Text = filename;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = openPrivateKeyDialog.ShowDialog();
            //获取所打开文件的文件名
            string filename = openPrivateKeyDialog.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                privateKeyBox.Text = filename;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string publicKeyPath = publicKeyBox.Text;
            string privateKeyPath = privateKeyBox.Text;

            if (string.IsNullOrEmpty(publicKeyPath) || string.IsNullOrEmpty(privateKeyPath))
            {
                MessageBox.Show("公钥/私钥地址不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!FileCrypto.RsaGenerateKeyToFile(publicKeyPath, privateKeyPath))
            {
                MessageBox.Show("生成失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dr = MessageBox.Show("是否打开生成的公钥与私钥文件？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(publicKeyPath);
                System.Diagnostics.Process.Start(privateKeyPath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string signedTextPath = textBox1.Text;
            if (string.IsNullOrEmpty(signedTextPath))
            {
                MessageBox.Show("文件地址不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string publicKeyPath = publicKeyBox.Text;
            if (string.IsNullOrEmpty(publicKeyPath))
            {
                MessageBox.Show("公钥地址不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string publicKey = FileCrypto.RsaReadKeyFromFile(publicKeyPath);
            if(!FileCrypto.RsaVerify(signedTextPath, publicKey))
            {
                MessageBox.Show("验证失败\n请确认文件路径与公钥路径", "失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show("验证成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
