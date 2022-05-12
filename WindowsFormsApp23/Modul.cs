using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Modul : UserControl
    {
        public Modul()
        {
            InitializeComponent();
        }

        private void Modul_Load(object sender, EventArgs e)
        {

        }
        public Bitmap GriDonusum(Bitmap resim)
        {
            try
            {
                int rgb;
                Color c;

                for (int y = 0; y < resim.Height; y++)
                    for (int x = 0; x < resim.Width; x++)
                    {
                        c = resim.GetPixel(x, y);
                        rgb = (int)Math.Round(.299 * c.R + .587 * c.G + .114 * c.B);
                        resim.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));


                    }
               
            }
            catch
            {
                MessageBox.Show("Gri Donusumde Hata Olustu");
                
            }
            return resim;


        }
        public Bitmap Negatif(Bitmap resim)
        {
            try
            {
                int kirmizi, yesil, mavi;
                Color c;

                for (int y = 0; y < resim.Height; y++)
                {
                    for (int x = 0; x < resim.Width; x++)
                    {
                        c = resim.GetPixel(x, y);
                        kirmizi = 255 - c.R;
                        yesil = 255 - c.G;
                        mavi = 255 - c.B;
                        resim.SetPixel(x, y, Color.FromArgb(kirmizi, yesil, mavi));
                    }
                }

            }
            catch
            {
                MessageBox.Show("Negatif Donusumde Hata Olustu");
            }
                

            return resim;
        }
        public Bitmap SiyahBeyaz(Bitmap resim)
        {
            try
            {
                int kirmizi, yesil, mavi; ;
                Color c;

                for (int y = 0; y < resim.Height; y++)
                {
                    for (int x = 0; x < resim.Width; x++)
                    {
                        c = resim.GetPixel(x, y);
                        if (c.R > 128)
                        {
                            kirmizi = 255;
                        }
                        else
                        {
                            kirmizi = 0;
                        }
                        if (c.G > 128)
                        {
                            yesil = 255;
                        }
                        else
                        {
                            yesil = 0;
                        }
                        if (c.B > 128)
                        {
                            mavi = 255;
                        }
                        else
                        {
                            mavi = 0;
                        }


                        resim.SetPixel(x, y, Color.FromArgb(kirmizi, yesil, mavi));
                    }
                }

            }
            catch
            {
                MessageBox.Show("Siyah Beyaz Donusumde Hata Olustu");
            }
            
            return resim;
        }
        public Bitmap Toplama(Bitmap resim,Bitmap resim2)
        {
            try
            {
                int rgb, kirmizi, yesil, mavi; ;
                Color c1, c2;

                for (int y = 0; y < resim.Height; y++)
                {
                    for (int x = 0; x < resim.Width; x++)
                    {
                        c1 = resim.GetPixel(x, y);
                        c2 = resim2.GetPixel(x, y);
                        kirmizi = c1.R & c2.R;
                        yesil = c1.G & c2.G;
                        mavi = c1.B & c2.B;

                        resim.SetPixel(x, y, Color.FromArgb(kirmizi, yesil, mavi));
                    }

                }
            }
            catch
            {
                MessageBox.Show("Toplama Isleminde Hata Olustu");

            }

            return resim;
        }
        public Bitmap Cıkarma(Bitmap resim, Bitmap resim2)
        {
            try
            {
                int rgb, kirmizi, yesil, mavi; ;
                Color c1, c2;

                for (int y = 0; y < resim.Height; y++)
                {
                    for (int x = 0; x < resim.Width; x++)
                    {
                        c1 = resim.GetPixel(x, y);
                        c2 = resim2.GetPixel(x, y);
                        kirmizi = c1.R | c2.R;
                        yesil = c1.G | c2.G;
                        mavi = c1.B | c2.B;

                        resim.SetPixel(x, y, Color.FromArgb(kirmizi, yesil, mavi));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Cıkarma Isleminde Hata Olustu");
            }
               

            return resim;
        }
        public Bitmap EgmeDikey(double deger,Bitmap resim)
        {
            try
            {
                double x = 0, y = 0;
                Color c;
                for (int i = 0; i < resim.Width; i++)
                {
                    for (int j = 0; j < (resim.Height); j++)
                    {
                        c = resim.GetPixel(i, j);
                        resim.SetPixel((int)i, (int)j, Color.White);
                        x = i - deger * j;
                        y = j;
                        if (x > 0 && y > 0 && x < resim.Width && y < resim.Height)
                            resim.SetPixel((int)x, (int)y, c);

                    }
                }
            }
            catch
            {
                MessageBox.Show("Egme Dikey Isleminde Hata Olustu");
            }
            return resim;
        }
        public Bitmap EgmeYatay(double deger, Bitmap resim)
        {
            try
            {
                Color c;
                double x = 0, y = 0;
                for (int i = 0; i < resim.Width; i++)
                {
                    for (int j = 0; j < resim.Height; j++)
                    {
                        c = resim.GetPixel(i, j);
                        resim.SetPixel((int)i, (int)j, Color.White);
                        x = i;
                        y = -deger * i + j;

                        if (x > 0 && x < resim.Width && y > 0 && y < resim.Height)
                            resim.SetPixel((int)x, (int)y, c);

                    }
                }
            }
            catch
            {
                MessageBox.Show("Egme Yatay Isleminde Hata Olustu");
            }
            return resim;
        }
        public Bitmap Olcekleme(int deger1,int deger2, Bitmap resim)
        {
            Size s = new Size(resim.Width * deger1, resim.Height * deger2);
            Bitmap degisim = new Bitmap(resim, s);
            try
            {
                Color c;
                int x2 = 0, y2 = 0;
                for (int x1 = 0; x1 < (resim.Width); x1++)
                {
                    for (int y1 = 0; y1 < (resim.Height); y1++)
                    {
                        c = resim.GetPixel(x1, y1);
                        x2 = x1 * deger1;
                        y2 = y1 * deger2;

                        if (x2 > 0 && y2 > 0)
                            degisim.SetPixel(x2, y2, c);

                    }
                }
            }
            catch
            {
                MessageBox.Show("Olcekleme Isleminde Hata Olustu");
            }
            return degisim;
        }
        public Bitmap Logaritma(double deger,Bitmap resim)
        {
            try
            {
                double kirmizi, yesil, mavi;
                Color c;

                for (int y = 0; y < resim.Height; y++)
                    for (int x = 0; x < resim.Width; x++)
                    {
                        c = resim.GetPixel(x, y);
                        kirmizi = deger * Math.Log10(c.R + 1);
                        if (kirmizi > 255)
                        {
                            kirmizi = 255;
                        }
                        else if (kirmizi < 0)
                        {
                            kirmizi = 0;
                        }
                        yesil = deger * Math.Log10(c.G + 1);
                        if (yesil > 255)
                        {
                            yesil = 255;
                        }
                        else if (yesil < 0)
                        {
                            yesil = 0;
                        }
                        mavi = deger * Math.Log10(c.B + 1);
                        if (mavi > 255)
                        {
                            mavi = 255;
                        }
                        else if (mavi < 0)
                        {
                            mavi = 0;
                        }
                        resim.SetPixel(x, y, Color.FromArgb((int)kirmizi, (int)yesil, (int)mavi));
                    }
            }
            catch
            {
                MessageBox.Show("Logaritma Isleminde Hata Olustu");
            }

            return resim;
        }
        public Bitmap Gama(double deger, Bitmap resim)
        {
            try
            {
                double kirmizi, yesil, mavi;
                Color c;

                for (int y = 0; y < resim.Height; y++)
                {
                    for (int x = 0; x < resim.Width; x++)
                    {
                        c = resim.GetPixel(x, y);
                        kirmizi = 1 * Math.Pow(c.R, deger);
                        if (kirmizi > 255)
                        {
                            kirmizi = 255;
                        }
                        else if (kirmizi < 0)
                        {
                            kirmizi = 0;
                        }
                        yesil = 1 * Math.Pow(c.G, deger);
                        if (yesil > 255)
                        {
                            yesil = 255;
                        }
                        else if (yesil < 0)
                        {
                            yesil = 0;
                        }
                        mavi = 1 * Math.Pow(c.B, deger);
                        if (mavi > 255)
                        {
                            mavi = 255;
                        }
                        else if (mavi < 0)
                        {
                            mavi = 0;
                        }
                        resim.SetPixel(x, y, Color.FromArgb((int)kirmizi, (int)yesil, (int)mavi));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Gama Isleminde Hata Olustu");
            }
                

            return resim;
        }
        public Bitmap Dondurme(int deger, Bitmap resim)
        {
            Bitmap degisim = new Bitmap(resim.Width, resim.Height);
            try
            {
                Color c;
                int x0 = resim.Width / 2;
                int y0 = resim.Height / 2;
                double x2 = 0, y2 = 0;
                for (int i = 0; i < (resim.Width); i++)
                {
                    for (int j = 0; j < (resim.Height); j++)
                    {
                        c = resim.GetPixel(i, j);
                        x2 = (i - x0) * Math.Cos(deger * (Math.PI / 180.0)) - (j - y0) * Math.Sin(deger * (Math.PI / 180.0)) + x0;
                        y2 = (i - x0) * Math.Sin(deger * (Math.PI / 180.0)) + (j - y0) * Math.Cos(deger * (Math.PI / 180.0)) + y0;
                        if (x2 > 0 && x2 < resim.Width && y2 > 0 && y2 < resim.Height)
                            degisim.SetPixel((int)x2, (int)y2, c);

                    }
                }
            }
            catch
            {
                MessageBox.Show("Dondurme Isleminde Hata Olustu");
            }
            return degisim;
        }
        public Bitmap Oteleme(int deger1,int deger2, Bitmap resim)
        {
            double x2 = 0, y2 = 0;
            Color c;
            Bitmap degisim = new Bitmap(10000, 10000);
            for (int i = 0; i < (resim.Width); i++)
            {
                for (int j = 0; j < (resim.Height); j++)
                {
                    c = resim.GetPixel(i, j);
                    x2 = i + deger1;
                    y2 = j + deger2;
                    if (x2 > 0 && y2 > 0)
                        degisim.SetPixel((int)x2, (int)y2, c);

                }
            }
            return degisim;
        }
        public Bitmap HistogramGerme(int deger1, int deger2, int deger3, int deger4, Bitmap resim)
        {
            int rgb;
            Color c;              
            Bitmap degisim = new Bitmap(resim.Width, resim.Height);
            int[] degerler = new int[256];
            for (int i = 0; i < 256; i++)
            {
                degerler[i] = 0;
            }
            for (int y = 0; y < resim.Height; y++)
                for (int x = 0; x < resim.Width; x++)
                {
                    c = resim.GetPixel(x, y);
                    rgb = (int)Math.Round(.299 * c.R + .587 * c.G + .114 * c.B);
                    if (rgb >= deger1 && rgb <= deger2)
                    {
                        rgb = (deger4 - deger3) / (deger2 - deger1) * (rgb - deger1) + deger3;
                    }

                    degisim.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                    

                }
            
            return degisim;
        }
        public Bitmap HistogramEsitleme(Bitmap resim)
        {
            int rgb, hesap;
            Color c;
            int toplamhistog = 0;
            Bitmap degisim = new Bitmap(resim.Width, resim.Height);
            int[] degerler = new int[256];
            int[] yenidegerler = new int[256];
            for (int i = 0; i < 256; i++)
            {
                yenidegerler[i] = 0;
                degerler[i] = 0;
            }
            double x2 = 0, y2 = 0;
            for (int y = 0; y < resim.Height; y++)
            {
                for (int x = 0; x < resim.Width; x++)
                {
                    c = resim.GetPixel(x, y);
                    rgb = (int)Math.Round(.299 * c.R + .587 * c.G + .114 * c.B);
                    degisim.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                    degerler[rgb]++;

                }

            }
            for (int i = 0; i < 256; i++)
            {
                yenidegerler[i] = degerler[i] + toplamhistog;
                toplamhistog += degerler[i];
            }
            for (int y = 0; y < resim.Height; y++)
            {
                for (int x = 0; x < resim.Width; x++)
                {
                    c = resim.GetPixel(x, y);
                    rgb = (int)Math.Round(.299 * c.R + .587 * c.G + .114 * c.B);
                    hesap = (int)Math.Round((double)(yenidegerler[rgb] - 1) / ((resim.Width * resim.Height) - 1) * 255);
                    degisim.SetPixel(x, y, Color.FromArgb((int)hesap, (int)hesap, (int)hesap));
                   

                }

            }


            return degisim;
        }
        public Bitmap MeanFitre(Bitmap resim)
        {
            Color c;
            int resimgen = resim.Width;
            int resimyuk = resim.Height;
            Bitmap degisim = new Bitmap(resimgen, resimyuk);
            int kirmizi=0,yesil=0,mavi=0;
            for (int x1 = 1; x1 < (resimgen-2); x1++)
            {
                for (int y1 = 1; y1 < (resimyuk-2); y1++)
                {
                    kirmizi = 0; yesil = 0; mavi = 0;
                    for (int i = -1; i <=1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            c = resim.GetPixel(x1+i, y1+j);
                            kirmizi += c.R;
                            yesil += c.G;
                            mavi += c.B;
                        }
                    }
                    degisim.SetPixel(x1, y1, Color.FromArgb((kirmizi / 9), (yesil / 9), (mavi / 9)));
                }
            }
            return degisim;
        }
        public Bitmap MedianFitre(Bitmap resim)
        {
            Color c;
            int resimgen = resim.Width;
            int resimyuk = resim.Height;
            Bitmap degisim = new Bitmap(resimgen, resimyuk);
            int syc=0;
            int[] kirmizilar = new int[9];
            int[] yesiller = new int[9];
            int[] maviler = new int[9];
            for (int x1 = 1; x1 < (resimgen - 2); x1++)
            {
                for (int y1 = 1; y1 < (resimyuk - 2); y1++)
                {
                    syc = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            c = resim.GetPixel(x1 + i, y1 + j);
                            kirmizilar[syc] = c.R;
                            yesiller[syc] = c.G;
                            maviler[syc] = c.B;
                            syc++;
                        }
                    }
                    int temp1,temp2,temp3;

                    for (int i = (kirmizilar.Length - 1); i >= 0; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            if (kirmizilar[j - 1] > kirmizilar[j])
                            {
                                temp1 = kirmizilar[j - 1];
                                kirmizilar[j - 1] = kirmizilar[j];
                                kirmizilar[j] = temp1;
                            }
                            if (yesiller[j - 1] > yesiller[j])
                            {
                                temp2 = yesiller[j - 1];
                                yesiller[j - 1] = yesiller[j];
                                yesiller[j] = temp2;
                            }
                            if (maviler[j - 1] > maviler[j])
                            {
                                temp3 = maviler[j - 1];
                                maviler[j - 1] = maviler[j];
                                maviler[j] = temp3;
                            }

                        }
                    }
                    degisim.SetPixel(x1, y1, Color.FromArgb((kirmizilar[5]), (yesiller[5]), (maviler[5])));
                }
            }
            return degisim;
        }
        public Bitmap SobelFitre(Bitmap resim)
        {
            Color c;
            int resimgen = resim.Width;
            int resimyuk = resim.Height;
            Bitmap degisim = new Bitmap(resimgen, resimyuk);
            int kirmizi = 0, yesil = 0, mavi = 0,syc=0;
            int[] kirmizilar = new int[9];
            int[] yesiller = new int[9];
            int[] maviler = new int[9];
            for (int x1 = 1; x1 < (resimgen - 2); x1++)
            {
                for (int y1 = 1; y1 < (resimyuk - 2); y1++)
                {
                    syc = 0;
                    kirmizi = 0; yesil = 0; mavi = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            c = resim.GetPixel(x1 + i, y1 + j);
                            kirmizilar[syc] = c.R;
                            yesiller[syc] = c.G;
                            maviler[syc] = c.B;
                            syc++;
                        }
                    }
                    kirmizi = (int)Math.Sqrt(Math.Pow((kirmizilar[6] + 2 * kirmizilar[7] + kirmizilar[8])- (kirmizilar[0] + 2 * kirmizilar[1] + kirmizilar[2]), 2) - Math.Pow((kirmizilar[2] + 2 * kirmizilar[5] + kirmizilar[8]) - (kirmizilar[0] + 2 * kirmizilar[3] + kirmizilar[6]), 2));
                    yesil = (int)Math.Sqrt(Math.Pow((yesiller[6] + 2 * yesiller[7] + yesiller[8]) - (yesiller[0] + 2 * yesiller[1] + yesiller[2]), 2) - Math.Pow((yesiller[2] + 2 * yesiller[5] + yesiller[8]) - (yesiller[0] + 2 * yesiller[3] + yesiller[6]), 2));
                    mavi = (int)Math.Sqrt(Math.Pow((maviler[6] + 2 * maviler[7] + maviler[8]) - (maviler[0] + 2 * maviler[1] + maviler[2]), 2) - Math.Pow((maviler[2] + 2 * maviler[5] + maviler[8]) - (maviler[0] + 2 * maviler[3] + maviler[6]), 2));
                    if (kirmizi > 255)
                        kirmizi = 255;
                    if (kirmizi < 0)
                        kirmizi = 0;
                    if (yesil > 255)
                        yesil = 255;
                    if (yesil < 0)
                        yesil = 0;
                    if (mavi > 255)
                        mavi = 255;
                    if (mavi < 0)
                        mavi = 0;
                    degisim.SetPixel(x1, y1, Color.FromArgb((kirmizi), (yesil), (mavi)));
                }
            }
            return degisim;
        }
        public Bitmap PrewittFitre(Bitmap resim)
        {
            Color c;
            int resimgen = resim.Width;
            int resimyuk = resim.Height;
            Bitmap degisim = new Bitmap(resimgen, resimyuk);
            int[] maske = { -1, -1, -1, 0, 0, 0, 1, 1, 1 };
                       int kirmizi = 0, yesil = 0, mavi = 0,syc=0;
            for (int x1 = 1; x1 < (resimgen - 2); x1++)
            {
                for (int y1 = 1; y1 < (resimyuk - 2); y1++)
                {
                    syc = 0;
                    kirmizi = 0; yesil = 0; mavi = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            c = resim.GetPixel(x1 + i, y1 + j);
                            kirmizi += c.R*maske[syc];
                            yesil += c.G * maske[syc];
                            mavi += c.B * maske[syc];
                            syc++;
                        }
                    }
                    if (kirmizi > 255)
                        kirmizi = 255;
                    if (kirmizi < 0)
                        kirmizi = 0;
                    if (yesil > 255)
                        yesil = 255;
                    if (yesil < 0)
                        yesil = 0;
                    if (mavi > 255)
                        mavi = 255;
                    if (mavi < 0)
                        mavi = 0;
                    degisim.SetPixel(x1, y1, Color.FromArgb((kirmizi), (yesil), (mavi)));
                }
            }
            return degisim;
        }
        public Bitmap Trashold(Bitmap resim,int deger)
        {
            int kirmizi, yesil, mavi; ;
            Color c;

            for (int y = 0; y < resim.Height; y++)
            {
                for (int x = 0; x < resim.Width; x++)
                {
                    c = resim.GetPixel(x, y);
                    if (c.R > deger)
                    {
                        kirmizi = 255;
                    }
                    else
                    {
                        kirmizi = 0;
                    }
                    if (c.G > deger)
                    {
                        yesil = 255;
                    }
                    else
                    {
                        yesil = 0;
                    }
                    if (c.B > deger)
                    {
                        mavi = 255;
                    }
                    else
                    {
                        mavi = 0;
                    }

                    resim.SetPixel(x, y, Color.FromArgb(kirmizi, yesil, mavi));
                }
            }
            return resim;
        }


    }

 }
