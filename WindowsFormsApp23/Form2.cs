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
    public partial class Form2 : Form
    {
        Bitmap resim;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Bitmap resim)
        {
            this.resim = resim;
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           


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
            for (int y = 0; y < resim.Height; y++)
                for (int x = 0; x < resim.Width; x++)
                {
                    c = resim.GetPixel(x, y);
                    rgb = (int)Math.Round(.299 * c.R + .587 * c.G + .114 * c.B);
                    resim.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                    degerler[rgb]++;
                    

                }
            pictureBox1.Image = resim;
            for (int i = 0; i < 256; i++)
            {
                g2d.DrawLine(cizim1, Xbaslangic, Ybaslangic, Xbaslangic + 1, Ybaslangic - degerler[i]/5);
                Xbaslangic+=2;
                listBox1.Items.Add("Renk:" + i + "=" + degerler[i]);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Histogram();
        }
    }
}
