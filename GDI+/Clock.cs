using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_
{
    public partial class FormClock : Form
    {
        Graphics g;
        Timer timer;
        Point center;
        Bitmap bmp;
        Font font;

        public FormClock()
        {
            InitializeComponent();
        }

        private void FormClock_Load(object sender, EventArgs e)
        {
            center = new Point(ClientSize.Width / 2, ClientSize.Height / 2);
            bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            font = new Font("Ariall", 7f);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            for (int i = 0; i < 60; i++)
            {
                g.DrawLine(new Pen(Brushes.Black, 2), ArrowCalc(center, i, 80), ArrowCalc(center, i, 83));
            }

            for (int i = 0; i < 60; i++)
            {
                if(i == 59)
                    g.DrawString("  0", font, Brushes.Black, ArrowCalc(center, i, 100));
                if (i == 15)
                    g.DrawString("15", font, Brushes.Black, ArrowCalc(center, i, 90));
                if (i == 31)
                    g.DrawString(" 30", font, Brushes.Black, ArrowCalc(center, i, 90));
                if (i == 45)
                    g.DrawString("45", font, Brushes.Black, ArrowCalc(center, i, 100));
            }

            g.DrawLine(new Pen(Brushes.Black, 4), center, new Point(ClientSize.Width/2 + 1, ClientSize.Height/2 + 1));

            g.DrawLine(new Pen(Brushes.Black, 1), center, ArrowCalc(center, ss, 80));
            g.DrawLine(new Pen(Brushes.Black, 2), center, ArrowCalc(center, mm, 80));
            g.DrawLine(new Pen(Brushes.Black, 4), center, ArrowCalc(center, hh, 60));

            this.Text = $"{hh}:{mm}:{ss}";
            pictureBoxClock.Image = bmp;
            g.Dispose();
        }

        private Point ArrowCalc(Point cent, int s, int r)
        {
            int x = (int)(center.X + r * Math.Cos(-Math.PI / 2 + Math.PI * s / 30));
            int y = (int)(center.Y + r * Math.Sin(-Math.PI / 2 + Math.PI * s / 30));
            return new Point(x, y);
        }

    }
}
