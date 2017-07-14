using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gynvael_misja_008
{
    public partial class Form1 : Form
    {
        PointF[] lastPoints;
        PointF scanFrom;
        SingleRead lastPosition;
        Bitmap Backbuffer;

        public Form1()
        {
            InitializeComponent();
            getReadAndDraw(DataDownloader.startFile);
        }

        private void getReadAndDraw(string file)
        {
            if (file != "not possible")
                lastPosition = DataDownloader.readPosition(file);
            else
                System.Media.SystemSounds.Beep.Play();
            lastPoints = calculatePoints(lastPosition);
            pictureBox1.Refresh();
        }

        private PointF[] calculatePoints(SingleRead position)
        {
            int shift = 0;
            float zoom = 1F;

            scanFrom = new PointF(shift + position.x * zoom, shift + position.y * zoom);
            var points = new List<PointF>();
            float x, y;
            for(int i = 0; i < position.distance.Length; i++)
            {
                if(position.distance[i] >= 0)
                {
                    x = position.x * zoom + (float)(position.distance[i] * Math.Sin(i * Math.PI / 18.0) * zoom);
                    y = position.y * zoom - (float)(position.distance[i] * Math.Cos(i * Math.PI / 18.0) * zoom);
                    points.Add(new PointF(shift + x, shift + y));
                }
            }
            
            return points.ToArray();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 1);
            
            if (lastPoints != null)
            {
                using (var g = Graphics.FromImage(Backbuffer))
                {
                    foreach(PointF p in lastPoints)
                    {
                        g.FillRectangle(Brushes.Black, p.X, p.Y, 1, 1);
                    }
                }
                e.Graphics.DrawImageUnscaled(Backbuffer, 0, 0);
            }

            if (scanFrom != null)
            {
                e.Graphics.FillRectangle(Brushes.Black, scanFrom.X, scanFrom.Y, 2, 2);
                e.Graphics.DrawString(scanFrom.X + ", " + scanFrom.Y, DefaultFont, Brushes.Black, scanFrom.X + 3, scanFrom.Y - 10);
            }

        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            getReadAndDraw(lastPosition.MOVE_NORTH);
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            getReadAndDraw(lastPosition.MOVE_SOUTH);
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            getReadAndDraw(lastPosition.MOVE_WEST);
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            getReadAndDraw(lastPosition.MOVE_EAST);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Backbuffer = new Bitmap(1600, 1200);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                buttonN_Click(null, null);
            if (e.KeyCode == Keys.Down)
                buttonS_Click(null, null);
            if (e.KeyCode == Keys.Left)
                buttonW_Click(null, null);
            if (e.KeyCode == Keys.Right)
                buttonE_Click(null, null);
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }
    }
}
