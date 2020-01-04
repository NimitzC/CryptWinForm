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
    public partial class RSACryptForm : Form
    {

        private byte[] pdata = null;

        public RSACryptForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = openPublicKeyDialog.ShowDialog();
            //获取所打开文件的文件名
            string filename = openPublicKeyDialog.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                //publicKeyTmp = FileCrypto.RsaReadKeyFromFile(filename);
                publicKeyBox.Text = FileCrypto.RsaReadKeyFromFile(filename);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string publicKey;
            string privateKey;
            if(!CryptoUtils.RsaGenerateKey(out publicKey, out privateKey))
            {
                MessageBox.Show("生成失败\n", "失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            publicKeyBox.Text = publicKey;
            privateKeyBox.Text = privateKey;
            MessageBox.Show("生成成功！\n如需保存到硬盘需在下方导出", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            //获取所打开目录地址
            string path = folderBrowserDialog1.SelectedPath;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(path))
            {
                textBox2.Text = path;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            //获取所打开文件的文件名
            string filename = openFileDialog1.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                byte[] bytes = FileCrypto.ReadBytesFromFile(filename);
                textBox4.Text = Encoding.UTF8.GetString(bytes);
                //textBox6.Text = Path.GetDirectoryName(filename);
                textBox5.Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string plainText = textBox4.Text;
            if (string.IsNullOrEmpty(plainText))
            {
                MessageBox.Show("请选择文件", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            string publicKey = publicKeyBox.Text;
            byte[] encrypted = CryptoUtils.RsaEncrypt(plainTextBytes, publicKey);
            if (encrypted == null)
            {
                MessageBox.Show("加密失败\n请确认公钥是否正确", "失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            pdata = encrypted; //set global
            textBox5.Text = Encoding.UTF8.GetString(encrypted);
            MessageBox.Show($"{encrypted.Length}加密成功！\n加密后的内容将显示在下方\n若要导出请在下方设置路径导出", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = openPrivateKeyDialog.ShowDialog();
            //获取所打开文件的文件名
            string filename = openPrivateKeyDialog.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                privateKeyBox.Text = FileCrypto.RsaReadKeyFromFile(filename);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string directory = textBox2.Text;
            if (string.IsNullOrWhiteSpace(directory))
            {
                MessageBox.Show("目录不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
 
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("公钥/私钥文件名不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string publicKeyPath = directory + "\\" + textBox1.Text;
            string privateKeyPath = directory + "\\" + textBox3.Text;
            string publicKey = publicKeyBox.Text;
            string privateKey = privateKeyBox.Text;

            if (!FileCrypto.RsaWriteKeyToFile(publicKeyPath, publicKey))
            {
                MessageBox.Show("公钥导出失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (!FileCrypto.RsaWriteKeyToFile(privateKeyPath, privateKey))
            {
                MessageBox.Show("私钥导出失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dr = MessageBox.Show($"导出成功！已保存至目录：{directory}\n是否打开对应目录?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("explorer.exe", directory);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string directory = textBox2.Text;
            if (string.IsNullOrWhiteSpace(directory))
            {
                MessageBox.Show("目录不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("公钥文件名不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string publicKeyPath = directory + "\\" + textBox1.Text;
            Console.WriteLine(publicKeyPath);
            string publicKey = publicKeyBox.Text;

            if(!FileCrypto.RsaWriteKeyToFile(publicKeyPath, publicKey))
            {
                MessageBox.Show("导出失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dr = MessageBox.Show($"导出成功！已保存至目录：{directory}\n是否打开对应目录?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("explorer.exe", directory);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string directory = textBox2.Text;
            if (string.IsNullOrWhiteSpace(directory))
            {
                MessageBox.Show("目录不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("私钥文件名不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string privateKeyPath = directory + "\\" + textBox3.Text;
            string privateKey = privateKeyBox.Text;

            if(!FileCrypto.RsaWriteKeyToFile(privateKeyPath, privateKey))
            {
                MessageBox.Show("导出失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dr = MessageBox.Show($"导出成功！已保存至目录：{directory}\n是否打开对应目录?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("explorer.exe", directory);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            //获取所打开文件的文件名
            string filename = saveFileDialog1.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                textBox6.Text = filename;
                string data = textBox5.Text;
                //byte[] dataBytes = Encoding.UTF8.GetBytes(data);
                byte[] dataBytes = pdata;
                MessageBox.Show($"{dataBytes.Length}", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FileCrypto.WriteBytesToFile(filename, dataBytes);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string cipherText = textBox4.Text;
            if (string.IsNullOrEmpty(cipherText))
            {
                MessageBox.Show("请选择文件", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            byte[] cipherTextBytes = Encoding.UTF8.GetBytes(cipherText);
            //byte[] cipherTextBytes = pdata;
            string privateKey = privateKeyBox.Text;

            byte[] decrypted = CryptoUtils.RsaDecrypt(cipherTextBytes, privateKey);
            if (decrypted == null)
            {
                MessageBox.Show($"{cipherTextBytes.Length}解密密失败\n请确认私钥是否正确", "失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            textBox5.Text = Encoding.UTF8.GetString(decrypted);
            MessageBox.Show("解密成功！\n解密后的内容将显示在下方\n若要导出请在下方设置路径导出", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
