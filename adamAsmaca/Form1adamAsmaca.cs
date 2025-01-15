using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        
        String[] kelimeler = { "ali" };
        private int no;
        private char[] gizliKelime;
        private string secilenKelime;
        private string dogruKelime;
        private string tahminKelime;
        private char karakterler;
        private string charİcin;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgelesayi = new Random();
            no = rastgelesayi.Next(0, kelimeler.Length);
            dogruKelime = kelimeler[no];
            secilenKelime = kelimeler[no];
            charİcin = secilenKelime;
            gizliKelime = new char[secilenKelime.Length];
            for (int i = 0; i < gizliKelime.Length; i++)
            {
                gizliKelime[i] = '*';  // kelimeyi gizli olarak yazma
          
                textBox1.Text = (secilenKelime);
            }

            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            // harf alma
            string girilenHarf = textEdit2.Text.Trim();

            // tek harf girme
            if (string.IsNullOrEmpty(girilenHarf) || girilenHarf.Length != 1)
            {
                MessageBox.Show("Lütfen sadece bir harf girin.");
                return;
            }

            bool harfBulundu = false;  // harf var mı yokmu kontrolü

            if (secilenKelime.Contains(girilenHarf))
            {
                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    // harf varsa kelime güncelleme
                    if (secilenKelime[i] == girilenHarf[0])
                    {
                        gizliKelime[i] = girilenHarf[0];  
                        harfBulundu = true;  
                    }
                }
            }
            // harfi ekrana yazdırma
            if (harfBulundu)
            {
                label1.Text = new string(gizliKelime); 
            }
            else
            {
                // yanlış harf uyarısı
                MessageBox.Show("Yanlış tahmin! Tekrar deneyin.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {

            string kullaniciGirdisi = textBox2.Text;
            textBox2.Text = (kullaniciGirdisi); //tahmin doğruysa kazandınız, yanlışsa kaybettiniz bildirimi

            if (dogruKelime == kullaniciGirdisi)
            {
                textBox3.Text = ("Kelime: " + secilenKelime);
                textBox4.Text = ("KAZANDINIZ");

            }
            else
            {
                textBox3.Text = ("Kelime: " + secilenKelime);
                textBox4.Text = ("KAYBETTİNİZ");

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }

    

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
