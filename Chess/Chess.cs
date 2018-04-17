using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class FormChess : Form
    {
        Graphics g;
        Image image;
        PictureBox pewka1W;
        PictureBox pewka2W;
        PictureBox pewka3W;
        PictureBox pewka4W;
        PictureBox pewka5W;
        PictureBox pewka6W;
        PictureBox pewka7W;
        PictureBox pewka8W;
        PictureBox pewka1Bl;
        PictureBox pewka2Bl;
        PictureBox pewka3Bl;
        PictureBox pewka4Bl;
        PictureBox pewka5Bl;
        PictureBox pewka6Bl;
        PictureBox pewka7Bl;
        PictureBox pewka8Bl;
        PictureBox tura1W;
        PictureBox tura2W;
        PictureBox hors1W;
        PictureBox hors2W;
        PictureBox let1W;
        PictureBox let2W;
        PictureBox lediW;
        PictureBox kingW;
        PictureBox tura1Bl;
        PictureBox tura2Bl;
        PictureBox hors1Bl;
        PictureBox hors2Bl;
        PictureBox let1Bl;
        PictureBox let2Bl;
        PictureBox lediBl;
        PictureBox kingBl;


        public FormChess()
        {
            InitializeComponent();
        }

        private void FormChess_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            int width = ClientSize.Width / 8;
            int height = ClientSize.Height / 8;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0 || i % 2 == 1 && j % 2 == 1)
                        g.FillRectangle(Brushes.White, new Rectangle(new Point(i * width, j * height), new Size(width, height)));
                    else
                        g.FillRectangle(Brushes.Black, new Rectangle(new Point(i * width, j * height), new Size(width, height)));
                }
            }

            LoadBlackFigures(width, height);
            LoadWhitekFigures(width, height);


            g.Dispose();

        }

        private void LoadBlackFigures(int width, int height)
        {
            image = Image.FromFile("rookB.png");
            Bitmap bmp = new Bitmap(image, width - 4, height - 4);
            tura1Bl.Size = new Size(width - 4, height - 4);
            tura1Bl.Location = new Point(2, 2);
            tura1Bl.Image = bmp;
            tura1Bl.ContextMenuStrip = contextMenuStripTura1Bl;
           
            image = Image.FromFile("knightB.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            hors1Bl.Size = new Size(width - 4, height - 4);
            hors1Bl.Location = new Point(width + 2, 2);
            hors1Bl.Image = bmp;
            hors1Bl.ContextMenuStrip = contextMenuStripHors1Bl;

            image = Image.FromFile("bishopB.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            let1Bl.Size = new Size(width - 4, height - 4);
            let1Bl.Location = new Point(width * 2 + 2, 2);
            let1Bl.Image = bmp;

            image = Image.FromFile("queenB.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            lediBl.Size = new Size(width - 4, height - 4);
            lediBl.Location = new Point(width * 3 + 2, 2);
            lediBl.Image = bmp;

            image = Image.FromFile("kingB.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            kingBl.Size = new Size(width - 4, height - 4);
            kingBl.Location = new Point(width * 4 + 2, 2);
            kingBl.Image = bmp;

            image = Image.FromFile("bishopB.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            let2Bl.Size = new Size(width - 4, height - 4);
            let2Bl.Location = new Point(width * 5 + 2, 2);
            let2Bl.Image = bmp;

            image = Image.FromFile("knightB.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            hors2Bl.Size = new Size(width - 4, height - 4);
            hors2Bl.Location = new Point(width * 6 + 2, 2);
            hors2Bl.Image = bmp;

            image = Image.FromFile("rookB.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            tura2Bl.Size = new Size(width - 4, height - 4);
            tura2Bl.Location = new Point(width * 7 + 2, 2);
            tura2Bl.Image = bmp;

            image = Image.FromFile("pawnB.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            pewka1Bl.Size = new Size(width - 4, height - 4);
            pewka1Bl.Location = new Point(0 + 2, height + 2);
            pewka1Bl.Image = bmp;

            image = Image.FromFile("pawnB.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            pewka2Bl.Size = new Size(width - 4, height - 4);
            pewka2Bl.Location = new Point(width + 2, height + 2);
            pewka2Bl.Image = bmp;

            image = Image.FromFile("pawnB.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            pewka3Bl.Size = new Size(width - 4, height - 4);
            pewka3Bl.Location = new Point(width * 2 + 2, height + 2);
            pewka3Bl.Image = bmp;

            image = Image.FromFile("pawnB.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            pewka4Bl.Size = new Size(width - 4, height - 4);
            pewka4Bl.Location = new Point(width * 3 + 2, height + 2);
            pewka4Bl.Image = bmp;

            image = Image.FromFile("pawnB.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            pewka5Bl.Size = new Size(width - 4, height - 4);
            pewka5Bl.Location = new Point(width * 4 + 2, height + 2);
            pewka5Bl.Image = bmp;

            image = Image.FromFile("pawnB.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            pewka6Bl.Size = new Size(width - 4, height - 4);
            pewka6Bl.Location = new Point(width * 5 + 2, height + 2);
            pewka6Bl.Image = bmp;

            image = Image.FromFile("pawnB.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            pewka7Bl.Size = new Size(width - 4, height - 4);
            pewka7Bl.Location = new Point(width * 6 + 2, height + 2);
            pewka7Bl.Image = bmp;

            image = Image.FromFile("pawnB.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            pewka8Bl.Size = new Size(width - 4, height - 4);
            pewka8Bl.Location = new Point(width * 7 + 2, height + 2);
            pewka8Bl.Image = bmp;

            this.Controls.Add(tura1Bl);
            this.Controls.Add(hors1Bl);
            this.Controls.Add(let1Bl);
            this.Controls.Add(lediBl);
            this.Controls.Add(kingBl);
            this.Controls.Add(let2Bl);
            this.Controls.Add(hors2Bl);
            this.Controls.Add(tura2Bl);
            this.Controls.Add(pewka1Bl);
            this.Controls.Add(pewka2Bl);
            this.Controls.Add(pewka3Bl);
            this.Controls.Add(pewka4Bl);
            this.Controls.Add(pewka5Bl);
            this.Controls.Add(pewka6Bl);
            this.Controls.Add(pewka7Bl);
            this.Controls.Add(pewka8Bl);
        }


        private void LoadWhitekFigures(int width, int height)
        {
            image = Image.FromFile("rookW.png");
            Bitmap bmp = new Bitmap(image, width - 4, height - 4);
            tura1W.Size = new Size(width - 4, height - 4);
            tura1W.Location = new Point(2, height * 7 + 2);
            tura1W.Image = bmp;

            image = Image.FromFile("knightW.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            hors1W.Size = new Size(width - 4, height - 4);
            hors1W.Location = new Point(width + 2, height * 7 + 2);
            hors1W.Image = bmp;

            image = Image.FromFile("bishopW.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            let1W.Size = new Size(width - 4, height - 4);
            let1W.Location = new Point(width * 2 + 2, height * 7 + 2);
            let1W.Image = bmp;

            image = Image.FromFile("queenW.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            lediW.Size = new Size(width - 4, height - 4);
            lediW.Location = new Point(width * 3 + 2, height * 7 + 2);
            lediW.Image = bmp;

            image = Image.FromFile("kingW.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            kingW.Size = new Size(width - 4, height - 4);
            kingW.Location = new Point(width * 4 + 2, height * 7 + 2);
            kingW.Image = bmp;

            image = Image.FromFile("bishopW.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            let2W.Size = new Size(width - 4, height - 4);
            let2W.Location = new Point(width * 5 + 2, height * 7 + 2);
            let2W.Image = bmp;

            image = Image.FromFile("knightW.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            hors2W.Size = new Size(width - 4, height - 4);
            hors2W.Location = new Point(width * 6 + 2, height * 7 + 2);
            hors2W.Image = bmp;

            image = Image.FromFile("rookW.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            tura2W.Size = new Size(width - 4, height - 4);
            tura2W.Location = new Point(width * 7 + 2, height * 7 + 2);
            tura2W.Image = bmp;

            image = Image.FromFile("pawnW.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            pewka1W.Size = new Size(width - 4, height - 4);
            pewka1W.Location = new Point(0 + 2, height * 6 + 2);
            pewka1W.Image = bmp;

            image = Image.FromFile("pawnW.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            pewka2W.Size = new Size(width - 4, height - 4);
            pewka2W.Location = new Point(width + 2, height * 6 + 2);
            pewka2W.Image = bmp;

            image = Image.FromFile("pawnW.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            pewka3W.Size = new Size(width - 4, height - 4);
            pewka3W.Location = new Point(width * 2 + 2, height * 6 + 2);
            pewka3W.Image = bmp;

            image = Image.FromFile("pawnW.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            pewka4W.Size = new Size(width - 4, height - 4);
            pewka4W.Location = new Point(width * 3 + 2, height * 6 + 2);
            pewka4W.Image = bmp;

            image = Image.FromFile("pawnW.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            pewka5W.Size = new Size(width - 4, height - 4);
            pewka5W.Location = new Point(width * 4 + 2, height * 6 + 2);
            pewka5W.Image = bmp;

            image = Image.FromFile("pawnW.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            pewka6W.Size = new Size(width - 4, height - 4);
            pewka6W.Location = new Point(width * 5 + 2, height * 6 + 2);
            pewka6W.Image = bmp;

            image = Image.FromFile("pawnW.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            pewka7W.Size = new Size(width - 4, height - 4);
            pewka7W.Location = new Point(width * 6 + 2, height * 6 + 2);
            pewka7W.Image = bmp;

            image = Image.FromFile("pawnW.png");
            bmp = new Bitmap(image, width - 4, height - 4);
            pewka8W.Size = new Size(width - 4, height - 4);
            pewka8W.Location = new Point(width * 7 + 2, height * 6 + 2);
            pewka8W.Image = bmp;

            this.Controls.Add(tura1W);
            this.Controls.Add(hors1W);
            this.Controls.Add(let1W);
            this.Controls.Add(lediW);
            this.Controls.Add(kingW);
            this.Controls.Add(let2W);
            this.Controls.Add(hors2W);
            this.Controls.Add(tura2W);
            this.Controls.Add(pewka1W);
            this.Controls.Add(pewka2W);
            this.Controls.Add(pewka3W);
            this.Controls.Add(pewka4W);
            this.Controls.Add(pewka5W);
            this.Controls.Add(pewka6W);
            this.Controls.Add(pewka7W);
            this.Controls.Add(pewka8W);
        }


        private void FormChess_Load(object sender, EventArgs e)
        {
            pewka1W = new PictureBox();
            pewka2W = new PictureBox();
            pewka3W = new PictureBox();
            pewka4W = new PictureBox();
            pewka5W = new PictureBox();
            pewka6W = new PictureBox();
            pewka7W = new PictureBox();
            pewka8W = new PictureBox();
            pewka1Bl = new PictureBox();
            pewka2Bl = new PictureBox();
            pewka3Bl = new PictureBox();
            pewka4Bl = new PictureBox();
            pewka5Bl = new PictureBox();
            pewka6Bl = new PictureBox();
            pewka7Bl = new PictureBox();
            pewka8Bl = new PictureBox();
            tura1W = new PictureBox();
            tura2W = new PictureBox();
            hors1W = new PictureBox();
            hors2W = new PictureBox();
            let1W = new PictureBox();
            let2W = new PictureBox();
            lediW = new PictureBox();
            kingW = new PictureBox();
            tura1Bl = new PictureBox();
            tura2Bl = new PictureBox();
            hors1Bl = new PictureBox();
            hors2Bl = new PictureBox();
            let1Bl = new PictureBox();
            let2Bl = new PictureBox();
            lediBl = new PictureBox();
            kingBl = new PictureBox();
        }



        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Black Tura_1");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Black Hors_1");
        }

        private void contextMenuStripLet1Bl_Opening(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Black Lejtenant_1!");
        }

        private void contextMenuStripLediBl_Opening(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Black Qeen!");
        }

        private void contextMenuStripKingBl_Opening(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Black King!");
        }

        private void contextMenuStripLet2Bl_Opening(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Black Lejtenant_2!");
        }

        private void contextMenuStripHors2Bl_Opening(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Black Hors_2");
        }

        private void contextMenuStripTura2Bl_Opening(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Black Tura_2");
        }
    }
}
