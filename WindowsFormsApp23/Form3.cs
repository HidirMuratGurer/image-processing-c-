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
    public partial class Form3 : Form
    {
        Bitmap resim1;
        Bitmap resim2;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Bitmap resim1, Bitmap resim2)
        {
            this.resim1 = resim1;
            this.resim2 = resim2;
            InitializeComponent();
        }
        public void Histogram()
        {
            Graphics g2d;
            Pen cizim1 = new Pen(Color.Black, 2);
            g2d = pictureBox2.CreateGraphics();

            int rgb;
            Color c;
            int[] degerler = new int[256];
            for (int i = 0; i < 256; i++)
            {
                degerler[i] = 0;
            }
            int Xbaslangic = 10;
            int Ybaslangic = 350;
            for (int y = 0; y < resim1.Height; y++)
            {
                for (int x = 0; x < resim1.Width; x++)
                {
                    c = resim1.GetPixel(x, y);
                    rgb = (int)Math.Round(.299 * c.R + .587 * c.G + .114 * c.B);
                    resim1.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                    degerler[rgb]++;


                }
            }
                
            pictureBox1.Image = resim1;
            for (int i = 0; i < 256; i++)
            {
                g2d.DrawLine(cizim1, Xbaslangic, Ybaslangic, Xbaslangic + 1, Ybaslangic - degerler[i] / 5);
                Xbaslangic += 2;
                listBox1.Items.Add("Renk:" + i + "=" + degerler[i]);
            }

        }
        public void Histogram2()
        {
            Graphics g2d;
            Pen cizim1 = new Pen(Color.Black, 2);
            g2d = pictureBox3.CreateGraphics();

            int rgb;
            Color c;
            int[] degerler = new int[256];
            for (int i = 0; i < 256; i++)
            {
                degerler[i] = 0;
            }
            int Xbaslangic = 10;
            int Ybaslangic = 350;
            for (int y = 0; y < resim2.Height; y++)
            {
                for (int x = 0; x < resim2.Width; x++)
                {
                    c = resim2.GetPixel(x, y);
                    rgb = (int)Math.Round(.299 * c.R + .587 * c.G + .114 * c.B);
                    resim2.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                    degerler[rgb]++;


                }
            }
                
            pictureBox4.Image = resim2;
            for (int i = 0; i < 256; i++)
            {
                g2d.DrawLine(cizim1, Xbaslangic, Ybaslangic, Xbaslangic + 1, Ybaslangic - degerler[i] / 5);
                Xbaslangic += 2;
                listBox2.Items.Add("Renk:" + i + "=" + degerler[i]);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Histogram();
            Histogram2();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = true;
            this.HorizontalScroll.Visible = true;
            this.VerticalScroll.Enabled = true;
            this.VerticalScroll.Visible = true;
            
        }
    }
}
