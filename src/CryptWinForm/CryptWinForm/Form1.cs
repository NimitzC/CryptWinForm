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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AESCryptForm form2 = new AESCryptForm();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RSACryptFormNew form3 = new RSACryptFormNew();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RSASignForm form4 = new RSASignForm();
            form4.ShowDialog();
        }
    }
}
