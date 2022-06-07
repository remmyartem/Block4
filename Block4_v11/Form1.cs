using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Block4_v11
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Pen pen;
        Graphics g;
        Point FixedPoint;
        float Angle = 0;
        int LineLength = 100;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pen = new Pen(Color.Black, 1);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Image = bitmap;
            g.Clear(Color.White);
            Rectangle top = new Rectangle(150, 100, 150, 60);
            Rectangle corpTop = new Rectangle(145, 95, 160, 70);
            Rectangle corpT = new Rectangle(145, 97, 160, 75);
            Rectangle corpL = new Rectangle(145, 198, 160, 70);
            Rectangle corpLow = new Rectangle(145, 189, 160, 70);
            Point[] corp = new Point[] { new Point(145,130),new Point(145,225),new Point(305,225),new Point(305,130), new Point(145, 130) };
            Point[] l1 = new Point[] { new Point(145, 130), new Point(145, 235) };
            Point[] l2 = new Point[] { new Point(305, 235), new Point(305, 130) };
            Point[] orn = new Point[] { new Point(145, 130), new Point(190,240), new Point(235, 130), new Point(280, 235), new Point(305, 130) };
            Rectangle stickL = new Rectangle(75, 125, 135, 5);
            Rectangle stickR = new Rectangle(240, 125, 135, 5);
            g.FillPie(new SolidBrush(Color.Brown), corpL, 0, 180);
            g.DrawPie(pen, corpL, 0, 180);
            g.FillPie(new SolidBrush(Color.Orange), corpLow, 0, 180);
            g.DrawPie(pen, corpLow, 0, 180);
            g.FillPolygon(new SolidBrush(Color.Orange), corp);
            g.DrawLines(new Pen(Color.LightYellow,10),orn);
            g.FillEllipse(new SolidBrush(Color.Brown), corpT);
            g.DrawLines(pen,l1);
            g.DrawLines(pen, l2);
            g.FillEllipse(new SolidBrush(Color.Brown), corpTop);
            g.FillEllipse(new SolidBrush(Color.LightYellow), top);
            g.DrawEllipse(pen, top);
            g.DrawEllipse(pen, corpTop);
            g.DrawEllipse(pen, corpT);

            g.FillEllipse(new SolidBrush(Color.SaddleBrown), stickL);
            g.DrawEllipse(pen, stickL);
            g.FillEllipse(new SolidBrush(Color.SaddleBrown), stickR);
            g.DrawEllipse(pen, stickR);
        }
    }
}
