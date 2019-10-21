using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            string kAdi, kSifre;
            kAdi = txtKullaniciAdi.Text;
            kSifre = txtSifre.Text;

            if (string.IsNullOrEmpty(kAdi) && string.IsNullOrEmpty(kSifre))
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre alanını doldurunuz !");
            }
            else if (kAdi != null && kSifre != null)
            {
                MessageBox.Show("Kullanıcı Adı : " + kAdi + " Şifre :" + kSifre );
            }

        }


    }
}
