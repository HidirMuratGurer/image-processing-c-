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
    public partial class Form4 : Form
    {
        int deger1, deger2;
        int[] rgb1 = new int[9];
        Bitmap resim;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(int deger1,int deger2,Bitmap resim)
        {
            this.deger1 = deger1;
            this.deger2 = deger2;
            this.resim = resim;
            InitializeComponent();
        }
        public void KomsuBul(Bitmap resim)
        {
            Color c;
            int syc = 0;
            if(deger1<=0 || deger2 <= 0)
            {
                MessageBox.Show("0 Dan farklı değer için yapınız.");
                return;
            }
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    c = resim.GetPixel(deger1 + i, deger2 + j);
                    rgb1[syc] = (int)c.R + c.G + c.B;
                    syc++;
                }
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            KomsuBul(this.resim);
            Graphics g2d,g3d;
            Pen cizim1 = new Pen(Color.Black, 2);
            g2d = pictureBox1.CreateGraphics();
            g3d = pictureBox2.CreateGraphics();

            g2d.DrawString(rgb1[1].ToString(),this.Font,Brushes.Black, 165, 35);
            g2d.DrawRectangle(cizim1,130, 10, 90, 60);

            g2d.DrawString(rgb1[3].ToString(), this.Font, Brushes.Black, 40, 125);
            g2d.DrawRectangle(cizim1, 10, 100, 90, 60);

            g2d.DrawString(rgb1[4].ToString(), this.Font, Brushes.Black, 160, 125);
            g2d.DrawRectangle(cizim1, 130, 100, 90, 60);

            g2d.DrawString(rgb1[5].ToString(), this.Font, Brushes.Black, 280, 125);
            g2d.DrawRectangle(cizim1, 250, 100, 90, 60);

            g2d.DrawString(rgb1[7].ToString(), this.Font, Brushes.Black, 160, 215);
            g2d.DrawRectangle(cizim1, 130, 190, 90, 60);

            //picturebox2 burdan başlıyor

            g3d.DrawString(rgb1[0].ToString(), this.Font, Brushes.Black, 55, 35);
            g3d.DrawRectangle(cizim1,10, 10, 90, 60);

            g3d.DrawString(rgb1[1].ToString(), this.Font, Brushes.Black, 165, 35);
            g3d.DrawRectangle(cizim1, 130, 10, 90, 60);

            g3d.DrawString(rgb1[2].ToString(), this.Font, Brushes.Black, 280, 35);
            g3d.DrawRectangle(cizim1, 250, 10, 90, 60);

            g3d.DrawString(rgb1[3].ToString(), this.Font, Brushes.Black, 40, 125);
            g3d.DrawRectangle(cizim1, 10, 100, 90, 60);

            g3d.DrawString(rgb1[4].ToString(), this.Font, Brushes.Black, 160, 125);
            g3d.DrawRectangle(cizim1, 130, 100, 90, 60);

            g3d.DrawString(rgb1[5].ToString(), this.Font, Brushes.Black, 280, 125);
            g3d.DrawRectangle(cizim1, 250, 100, 90, 60);

            g3d.DrawString(rgb1[6].ToString(), this.Font, Brushes.Black, 55, 215);
            g3d.DrawRectangle(cizim1, 10, 190, 90, 60);

            g3d.DrawString(rgb1[7].ToString(), this.Font, Brushes.Black, 160, 215);
            g3d.DrawRectangle(cizim1, 130, 190, 90, 60);

            g3d.DrawString(rgb1[8].ToString(), this.Font, Brushes.Black, 280, 215);
            g3d.DrawRectangle(cizim1, 250, 190, 90, 60);

        }
    }
}
