using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Image image1;
        public Image image2;
        public Image image3;
        public Bitmap imageilk1;
        public Bitmap imageilk2;
        public Bitmap imageilk3;
        public Bitmap image11;
        public Bitmap image22;
        public Bitmap image33;
        public Bitmap imageson1;
        public Bitmap imageson2;
        public Bitmap imageson3;
        Modul modul = new Modul();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (checkBox1.Checked)
                {
                    imageson1 = modul.GriDonusum(image11);
                    pictureBox1.Image = imageson1;
                    image11 = imageson1;

                }
                if (checkBox2.Checked)
                {
                    imageson2 = modul.GriDonusum(image22);
                    pictureBox2.Image = imageson2;
                    image22 = imageson2;
                }
                if (checkBox3.Checked)
                {
                    imageson3 = modul.GriDonusum(image22);
                    pictureBox3.Image = imageson3;
                    image33 = imageson3;
                }
            }
            if (radioButton2.Checked)
            {
                if (checkBox1.Checked)
                {
                    imageson1 = modul.Negatif(image11);
                    pictureBox1.Image = imageson1;
                    image11 = imageson1;

                }
                if (checkBox2.Checked)
                {
                    imageson2 = modul.Negatif(image22);
                    pictureBox2.Image = imageson2;
                    image22 = imageson2;
                }
                if (checkBox3.Checked)
                {
                    imageson3 = modul.Negatif(image22);
                    pictureBox3.Image = imageson3;
                    image33 = imageson3;
                }
            }
            if (radioButton3.Checked)
            {
                if (checkBox1.Checked)
                {

                    imageson1 = modul.SiyahBeyaz(modul.GriDonusum(image11));
                    pictureBox1.Image = imageson1;
                    image11 = imageson1;

                }
                if (checkBox2.Checked)
                {
                    imageson2 = modul.SiyahBeyaz(modul.GriDonusum(image22));
                    pictureBox2.Image = imageson2;
                    image22 = imageson2;
                }
                if (checkBox3.Checked)
                {
                    imageson3 = modul.SiyahBeyaz(modul.GriDonusum(image22));
                    pictureBox3.Image = imageson3;
                    image33 = imageson3;
                }
            }
            if (radioButton5.Checked)
            {
                if (checkBox1.Checked && checkBox2.Checked)
                {
                    imageson3 = modul.Toplama(image11,image22);
                    pictureBox3.Image = imageson3;
                    image33 = imageson3;

                }
                if (checkBox2.Checked && checkBox3.Checked)
                {
                    imageson1 = modul.Toplama(image22,image22);
                    pictureBox1.Image = imageson1;
                    image11 = imageson1;
                }
                if (checkBox3.Checked && checkBox1.Checked)
                {
                    imageson2 = modul.Toplama(image33,image11);
                    pictureBox2.Image = imageson2;
                    image22 = imageson2;
                }
            }
            if (radioButton6.Checked)
            {
                if (checkBox1.Checked && checkBox2.Checked)
                {
                    imageson3 = modul.Cıkarma(image11, image22);
                    pictureBox3.Image = imageson3;
                    image33 = imageson3;

                }
                if (checkBox2.Checked && checkBox3.Checked)
                {
                    imageson1 = modul.Cıkarma(image22, image22);
                    pictureBox1.Image = imageson1;
                    image11 = imageson1;
                }
                if (checkBox3.Checked && checkBox1.Checked)
                {
                    imageson2 = modul.Cıkarma(image33, image11);
                    pictureBox2.Image = imageson2;
                    image22 = imageson2;
                }
            }
            if (radioButton7.Checked)
            {
                if (checkBox1.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("1. Resim icin Deger giriniz", "Olcekleme X deger", "", 20, 20);
                        string b = Interaction.InputBox("1. Resim icin Deger giriniz", "Olcekleme Y deger", "", 20, 20);
                        int deger1 = Convert.ToInt16(a);
                        int deger2 = Convert.ToInt16(b);
                        imageson1 = modul.Olcekleme(deger1, deger2, image11);
                        pictureBox1.Image = imageson1;
                        image11 = imageson1;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                   
                }
                if (checkBox2.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("2. Resim icin Deger giriniz", "Olcekleme X deger", "", 20, 20);
                        string b = Interaction.InputBox("2. Resim icin Deger giriniz", "Olcekleme Y deger", "", 20, 20);
                        int deger1 = Convert.ToInt16(a);
                        int deger2 = Convert.ToInt16(b);
                        imageson2 = modul.Olcekleme(deger1, deger2, image22);
                        pictureBox2.Image = imageson2;
                        image22 = imageson2;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
                if (checkBox3.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("3. Resim icin Deger giriniz", "Olcekleme X deger", "", 20, 20);
                        string b = Interaction.InputBox("3. Resim icin Deger giriniz", "Olcekleme Y deger", "", 20, 20);
                        int deger1 = Convert.ToInt16(a);
                        int deger2 = Convert.ToInt16(b);
                        imageson3 = modul.Olcekleme(deger1, deger2, image22);
                        pictureBox3.Image = imageson3;
                        image33 = imageson3;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
            }
            if (radioButton8.Checked)
            {
                if (checkBox1.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("1. Resim icin Deger giriniz", "Dondurme Derecesi", "", 20, 20);
                        int deger = Convert.ToInt16(a);
                        imageson1 = modul.Dondurme(deger, image11);
                        pictureBox1.Image = imageson1;
                        image11 = imageson1;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }

                }
                if (checkBox2.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("1. Resim icin Deger giriniz", "Dondurme Derecesi", "", 20, 20);
                        int deger = Convert.ToInt16(a);
                        imageson2 = modul.Dondurme(deger, image22);
                        pictureBox2.Image = imageson2;
                        image22 = imageson2;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                    
                }
                if (checkBox3.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("3. Resim icin Deger giriniz", "Dondurme Derecesi", "", 20, 20);
                        int deger = Convert.ToInt16(a);
                        imageson3 = modul.Dondurme(deger, image22);
                        pictureBox3.Image = imageson3;
                        image33 = imageson3;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
            }
            if (radioButton9.Checked)
            {
                if (checkBox1.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("1. Resim icin Deger giriniz", "Oteleme X Degeri", "", 20, 20);
                        string b = Interaction.InputBox("1. Resim icin Deger giriniz", "Oteleme Y Degeri", "", 20, 20);
                        int deger1 = Convert.ToInt16(a);
                        int deger2 = Convert.ToInt16(b);
                        imageson1 = modul.Oteleme(deger1, deger2, image11);
                        pictureBox1.Image = imageson1;
                        image11 = imageson1;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }

                }
                if (checkBox2.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("2. Resim icin Deger giriniz", "Oteleme X deger", "", 20, 20);
                        string b = Interaction.InputBox("2. Resim icin Deger giriniz", "Oteleme Y deger", "", 20, 20);
                        int deger1 = Convert.ToInt16(a);
                        int deger2 = Convert.ToInt16(b);
                        imageson2 = modul.Oteleme(deger1, deger2, image22);
                        pictureBox2.Image = imageson2;
                        image22 = imageson2;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
                if (checkBox3.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("3. Resim icin Deger giriniz", "Oteleme X deger", "", 20, 20);
                        string b = Interaction.InputBox("3. Resim icin Deger giriniz", "Oteleme Y deger", "", 20, 20);
                        int deger1 = Convert.ToInt16(a);
                        int deger2 = Convert.ToInt16(b);
                        imageson3 = modul.Oteleme(deger1, deger2, image22);
                        pictureBox3.Image = imageson3;
                        image33 = imageson3;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
            }
            if (radioButton10.Checked)
            {
                if (checkBox1.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("1. Resim icin Deger giriniz", "Egme Dikey Deger", "", 20, 20);
                        double deger = Convert.ToDouble(a);
                        imageson1 = modul.EgmeDikey(deger, image11);
                        pictureBox1.Image = imageson1;
                        image11 = imageson1;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }    
                }
                if (checkBox2.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("2. Resim icin Deger giriniz", "Egme Dikey Deger", "", 20, 20);
                        double deger = Convert.ToDouble(a);
                        imageson2 = modul.EgmeDikey(deger, image22);
                        pictureBox2.Image = imageson2;
                        image22 = imageson2;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
                if (checkBox3.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("3. Resim icin Deger giriniz", "Egme Dikey Deger", "", 20, 20);
                        double deger = Convert.ToDouble(a);
                        imageson3 = modul.EgmeDikey(deger, image22);
                        pictureBox3.Image = imageson3;
                        image33 = imageson3;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
            }
            if (radioButton11.Checked)
            {
                if (checkBox1.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("1. Resim icin Deger giriniz", "Egme Yatay Deger", "", 20, 20);
                        double deger = Convert.ToDouble(a);
                        imageson1 = modul.EgmeYatay(deger, image11);
                        pictureBox1.Image = imageson1;
                        image11 = imageson1;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }  
                if (checkBox2.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("2. Resim icin Deger giriniz", "Egme Yatay Deger", "", 20, 20);
                        double deger = Convert.ToDouble(a);
                        imageson2 = modul.EgmeYatay(deger, image22);
                        pictureBox2.Image = imageson2;
                        image22 = imageson2;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
                if (checkBox3.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("3. Resim icin Deger giriniz", "Egme Yatay Deger", "", 20, 20);
                        double deger = Convert.ToDouble(a);
                        imageson3 = modul.EgmeYatay(deger, image22);
                        pictureBox3.Image = imageson3;
                        image33 = imageson3;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
            }
            if (radioButton12.Checked)
            {
                if (checkBox1.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("1. Resim icin Deger giriniz", "Trashold Degeri", "", 20, 20);
                        int deger = Convert.ToInt16(a);
                        imageson1 = modul.Trashold(image11, deger);
                        pictureBox1.Image = imageson1;
                        image11 = imageson1;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
                if (checkBox2.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("2. Resim icin Deger giriniz", "Trashold Degeri", "", 20, 20);
                        int deger = Convert.ToInt16(a);
                        imageson2 = modul.Trashold(image22, deger);
                        pictureBox2.Image = imageson2;
                        image22 = imageson2;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
                if (checkBox3.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("3. Resim icin Deger giriniz", "Trashold Degeri", "", 20, 20);
                        int deger = Convert.ToInt16(a);
                        imageson3 = modul.Trashold(image33, deger);
                        pictureBox3.Image = imageson3;
                        image33 = imageson3;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
            }
            if (radioButton13.Checked)
            {
                if (checkBox1.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("1. Resim icin Deger giriniz", "X deger", "", 20, 20);
                        string b = Interaction.InputBox("1. Resim icin Deger giriniz", "Y deger", "", 20, 20);
                        int deger1 = Convert.ToInt16(a);
                        int deger2 = Convert.ToInt16(b);
                        Form4 frm4 = new Form4(deger1, deger2, image11);
                        frm4.ShowDialog();
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }

                }
                if (checkBox2.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("2. Resim icin Deger giriniz", "X deger", "", 20, 20);
                        string b = Interaction.InputBox("2. Resim icin Deger giriniz", "Y deger", "", 20, 20);
                        int deger1 = Convert.ToInt16(a);
                        int deger2 = Convert.ToInt16(b);
                        Form4 frm4 = new Form4(deger1, deger2, image22);
                        frm4.ShowDialog();
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
                if (checkBox3.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("3. Resim icin Deger giriniz", "X deger", "", 20, 20);
                        string b = Interaction.InputBox("3. Resim icin Deger giriniz", "Y deger", "", 20, 20);
                        int deger1 = Convert.ToInt16(a);
                        int deger2 = Convert.ToInt16(b);
                        Form4 frm4 = new Form4(deger1, deger2, image33);
                        frm4.ShowDialog();
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
            }
            if (radioButton14.Checked)
            {
                if (checkBox1.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("1. Resim icin Deger giriniz", "Logaritma Deger", "", 20, 20);
                        double deger = Convert.ToDouble(a);
                        imageson1 = modul.Logaritma(deger, image11);
                        pictureBox1.Image = imageson1;
                        image11 = imageson1;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
                if (checkBox2.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("2. Resim icin Deger giriniz", "Logaritma Deger", "", 20, 20);
                        double deger = Convert.ToDouble(a);
                        imageson2 = modul.Logaritma(deger, image22);
                        pictureBox2.Image = imageson2;
                        image22 = imageson2;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
                if (checkBox3.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("3. Resim icin Deger giriniz", "Logaritma Deger", "", 20, 20);
                        double deger = Convert.ToDouble(a);
                        imageson3 = modul.Logaritma(deger, image22);
                        pictureBox3.Image = imageson3;
                        image33 = imageson3;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
            }
            if (radioButton15.Checked)
            {
                if (checkBox1.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("1. Resim icin Deger giriniz", "Gama Degeri", "", 20, 20);
                        double deger = Convert.ToDouble(a);
                        imageson1 = modul.Gama(deger, image11);
                        pictureBox1.Image = imageson1;
                        image11 = imageson1;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
                if (checkBox2.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("2. Resim icin Deger giriniz", "Gama Deger", "", 20, 20);
                        double deger = Convert.ToDouble(a);
                        imageson2 = modul.Logaritma(deger, image22);
                        pictureBox2.Image = imageson2;
                        image22 = imageson2;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
                if (checkBox3.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("3. Resim icin Deger giriniz", "Gama Deger", "", 20, 20);
                        double deger = Convert.ToDouble(a);
                        imageson3 = modul.Logaritma(deger, image22);
                        pictureBox3.Image = imageson3;
                        image33 = imageson3;
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }

            }
            if (radioButton16.Checked)
            {
                if (checkBox1.Checked)
                {
                    Form2 frm2 = new Form2(image11);
                    frm2.ShowDialog();
                    
                }
                if (checkBox2.Checked)
                {
                    Form2 frm2 = new Form2(image22);
                    frm2.ShowDialog();
                }
                if (checkBox3.Checked)
                {
                    Form2 frm2 = new Form2(image33);
                    frm2.ShowDialog();
                }

            }
            if (radioButton17.Checked)
            {
                if (checkBox1.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("1. Resim icin Deger giriniz", "X  Degeri", "", 20, 20);
                        string b = Interaction.InputBox("1. Resim icin Deger giriniz", "Y  Degeri", "", 20, 20);
                        string c = Interaction.InputBox("1. Resim icin Deger giriniz", "Seviye Alt Degeri", "", 20, 20);
                        string d = Interaction.InputBox("1. Resim icin Deger giriniz", "Seviye Ust Degeri", "", 20, 20);
                        int deger1 = Convert.ToInt16(a);
                        int deger2 = Convert.ToInt16(b);
                        int deger3 = Convert.ToInt16(c);
                        int deger4 = Convert.ToInt16(d);
                        Bitmap yeniresim = modul.HistogramGerme(deger1, deger2, deger3, deger4, image11);
                        Form3 frm3 = new Form3(image11, yeniresim);
                        frm3.ShowDialog();
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
                if (checkBox2.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("2. Resim icin Deger giriniz", "X  Degeri", "", 20, 20);
                        string b = Interaction.InputBox("2. Resim icin Deger giriniz", "Y  Degeri", "", 20, 20);
                        string c = Interaction.InputBox("2. Resim icin Deger giriniz", "Seviye Alt Degeri", "", 20, 20);
                        string d = Interaction.InputBox("2. Resim icin Deger giriniz", "Seviye Ust Degeri", "", 20, 20);
                        int deger1 = Convert.ToInt16(a);
                        int deger2 = Convert.ToInt16(b);
                        int deger3 = Convert.ToInt16(c);
                        int deger4 = Convert.ToInt16(d);
                        Bitmap yeniresim = modul.HistogramGerme(deger1, deger2, deger3, deger4, image22);
                        Form3 frm3 = new Form3(image22, yeniresim);
                        frm3.ShowDialog();
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }
                if (checkBox3.Checked)
                {
                    try
                    {
                        string a = Interaction.InputBox("3. Resim icin Deger giriniz", "X  Degeri", "", 20, 20);
                        string b = Interaction.InputBox("3. Resim icin Deger giriniz", "Y  Degeri", "", 20, 20);
                        string c = Interaction.InputBox("3. Resim icin Deger giriniz", "Seviye Alt Degeri", "", 20, 20);
                        string d = Interaction.InputBox("3. Resim icin Deger giriniz", "Seviye Ust Degeri", "", 20, 20);
                        int deger1 = Convert.ToInt16(a);
                        int deger2 = Convert.ToInt16(b);
                        int deger3 = Convert.ToInt16(c);
                        int deger4 = Convert.ToInt16(d);
                        Bitmap yeniresim = modul.HistogramGerme(deger1, deger2, deger3, deger4, image33);
                        Form3 frm3 = new Form3(image33, yeniresim);
                        frm3.ShowDialog();
                    }
                    catch
                    {
                        MessageBox.Show("Hata Olustu Degerleri Tekrar Giriniz");
                    }
                }

            }
            if (radioButton18.Checked)
            {
                if (checkBox1.Checked)
                {
                    imageson1 = modul.HistogramEsitleme(image11);
                    pictureBox1.Image = imageson1;
                    image11 = imageson1;

                }
                if (checkBox2.Checked)
                {
                    imageson2 = modul.HistogramEsitleme(image22);
                    pictureBox2.Image = imageson2;
                    image22 = imageson2;
                }
                if (checkBox3.Checked && checkBox1.Checked)
                {
                    imageson3 = modul.HistogramEsitleme(image33);
                    pictureBox3.Image = imageson3;
                    image33 = imageson3;
                }
            }
            if (radioButton19.Checked)
            {
                if (checkBox1.Checked)
                {
                    imageson1 = modul.MeanFitre(image11);
                    pictureBox1.Image = imageson1;
                    image11 = imageson1;

                }
                if (checkBox2.Checked)
                {
                    imageson2 = modul.MeanFitre(image22);
                    pictureBox2.Image = imageson2;
                    image22 = imageson2;
                }
                if (checkBox3.Checked && checkBox1.Checked)
                {
                    imageson3 = modul.MeanFitre(image33);
                    pictureBox3.Image = imageson3;
                    image33 = imageson3;
                }
            }
            if (radioButton20.Checked)
            {
                if (checkBox1.Checked)
                {
                    imageson1 = modul.MedianFitre(image11);
                    pictureBox1.Image = imageson1;
                    image11 = imageson1;

                }
                if (checkBox2.Checked)
                {
                    imageson2 = modul.MedianFitre(image22);
                    pictureBox2.Image = imageson2;
                    image22 = imageson2;
                }
                if (checkBox3.Checked && checkBox1.Checked)
                {
                    imageson3 = modul.MedianFitre(image33);
                    pictureBox3.Image = imageson3;
                    image33 = imageson3;
                }
            }
            if (radioButton21.Checked)
            {
                if (checkBox1.Checked)
                {
                    imageson1 = modul.SobelFitre(image11);
                    pictureBox1.Image = imageson1;
                    image11 = imageson1;

                }
                if (checkBox2.Checked)
                {
                    imageson2 = modul.SobelFitre(image22);
                    pictureBox2.Image = imageson2;
                    image22 = imageson2;
                }
                if (checkBox3.Checked)
                {
                    imageson3 = modul.SobelFitre(image33);
                    pictureBox3.Image = imageson3;
                    image33 = imageson3;
                }
            }
            if (radioButton22.Checked)
            {
                if (checkBox1.Checked)
                {
                    imageson1 = modul.PrewittFitre(image11);
                    pictureBox1.Image = imageson1;
                    image11 = imageson1;

                }
                if (checkBox2.Checked)
                {
                    imageson2 = modul.PrewittFitre(image22);
                    pictureBox2.Image = imageson2;
                    image22 = imageson2;
                }
                if (checkBox3.Checked)
                {
                    imageson3 = modul.PrewittFitre(image33);
                    pictureBox3.Image = imageson3;
                    image33 = imageson3;
                }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog();

            ac.Filter = "Image Files(*.png;*.jpg; *.jpeg; *.gif; *.bmp)|*.png;*.jpg; *.jpeg; *.gif; *.bmp";
            if (ac.ShowDialog() == DialogResult.OK)
            {
                image1 = Image.FromFile(ac.FileName);
                pictureBox1.Image = image1;
                image11 = new Bitmap(image1);
                imageilk1 = image11;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog();

            ac.Filter = "Image Files(*.png;*.jpg; *.jpeg; *.gif; *.bmp)|*.png;*.jpg; *.jpeg; *.gif; *.bmp";
            if (ac.ShowDialog() == DialogResult.OK)
            {
                image2 = Image.FromFile(ac.FileName);
                pictureBox2.Image = image2;
                image22 = new Bitmap(image2);
                imageilk2 = image22;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    pictureBox1.Image = image1;
                    image11 = new Bitmap(image1);
                }

                if (checkBox2.Checked)
                {
                    pictureBox2.Image = image2;
                    image22 = new Bitmap(image2);
                }
            }
            catch
            {
                MessageBox.Show("Hata olustu tekrar deneyin.");
            }
           
            
               
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        Image Zoom(Image img, Size size)
        {
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }
        protected override void OnMouseWheel(MouseEventArgs ea)
        {
            if (radioButton4.Checked)
            {
                if (checkBox1.Checked)
                {
                    if (pictureBox1.Image != null)
                    {
                        if (ea.Delta > 0)
                        {
                            pictureBox1.Image = Zoom(image11, new Size(i, i));
                            i += 3;
                        }
                        else
                        {
                            pictureBox1.Image = Zoom(image11, new Size(i, i));
                            i -= 3;
                        }
                    }
                }
                if (checkBox2.Checked)
                {
                    if (pictureBox1.Image != null)
                    {
                        if (ea.Delta > 0)
                        {
                            pictureBox2.Image = Zoom(image22, new Size(i, i));
                            i += 3;
                        }
                        else
                        {
                            pictureBox2.Image = Zoom(image22, new Size(i, i));
                            i -= 3;
                        }
                    }
                }
            }
           

        }
    }
}
