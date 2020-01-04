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
    public partial class RSACryptFormNew : Form
    {
        public RSACryptFormNew()
        {
            InitializeComponent();
        }

        private void selectPublicKeyFileButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = openPublicKeyDialog.ShowDialog();
            //获取所打开文件的文件名
            string filename = openPublicKeyDialog.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                publicKeyPathBox.Text = filename;
                publicKeyPreview.Text = FileCrypto.RsaReadKeyFromFile(filename);
            }
        }

        private void selectPrivateKeyFileButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = openPrivateKeyDialog.ShowDialog();
            //获取所打开文件的文件名
            string filename = openPrivateKeyDialog.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                privateKeyPathBox.Text = filename;
                privateKeyPreview.Text = FileCrypto.RsaReadKeyFromFile(filename);
            }
        }

        private void generateKeyButton_Click(object sender, EventArgs e)
        {
            string publicKeyPath = publicKeyPathBox.Text;
            string privateKeyPath = privateKeyPathBox.Text;
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
            publicKeyPreview.Text = FileCrypto.RsaReadKeyFromFile(publicKeyPath);
            privateKeyPreview.Text = FileCrypto.RsaReadKeyFromFile(privateKeyPath);
            MessageBox.Show("生成成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void selectSrcFileButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = openSrcFileDialog.ShowDialog();
            //获取所打开文件的文件名
            string filename = openSrcFileDialog.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                srcFileBox.Text = filename;
                srcPreview.Text = Encoding.UTF8.GetString(FileCrypto.ReadBytesFromFile(filename));
                destPreview.Clear();
            }
        }

        private void selectDestFileButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveDestFileDialog.ShowDialog();
            //获取所打开文件的文件名
            string filename = saveDestFileDialog.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                destFileBox.Text = filename;
                //destPreview.Text = Encoding.UTF8.GetString(FileCrypto.ReadBytesFromFile(filename));
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string srcPath = srcFileBox.Text;
            string destPath = destFileBox.Text;
            if (string.IsNullOrEmpty(srcPath) || string.IsNullOrEmpty(destPath))
            {
                MessageBox.Show("文件地址不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string publicKeyPath = publicKeyPathBox.Text;
            if (string.IsNullOrEmpty(publicKeyPath))
            {
                MessageBox.Show("私钥地址不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string publicKey = FileCrypto.RsaReadKeyFromFile(publicKeyPath);
            if(!FileCrypto.RsaEncrypt(srcPath, destPath, publicKey))
            {
                MessageBox.Show("公钥加密失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("加密文件成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            destPreview.Text = Encoding.UTF8.GetString(FileCrypto.ReadBytesFromFile(destPath));
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string srcPath = srcFileBox.Text;
            string destPath = destFileBox.Text;
            if (string.IsNullOrEmpty(srcPath) || string.IsNullOrEmpty(destPath))
            {
                MessageBox.Show("文件地址不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string privateKeyPath = privateKeyPathBox.Text;
            if (string.IsNullOrEmpty(privateKeyPath))
            {
                MessageBox.Show("私钥地址不能为空", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string privateKey = FileCrypto.RsaReadKeyFromFile(privateKeyPath);
            if (!FileCrypto.RsaDecrypt(srcPath, destPath, privateKey))
            {
                MessageBox.Show("私钥解密失败\n请确认是否选择了正确的文件", "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("解密文件成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            destPreview.Text = Encoding.UTF8.GetString(FileCrypto.ReadBytesFromFile(destPath));
        }
    }
}
