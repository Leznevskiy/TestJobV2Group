using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestJobV2Group
{
    public partial class Form1 : Form
    {
        private bool isDrawing;
        private Point startPoint;
        private Point endPoint;
        List<Point> points = new List<Point>();
        List<Point> pointLasts = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            pointLasts.Clear();
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            Point clickedPoint = mouseEvent.Location;
            points.Add(clickedPoint);
            PictureBox.Invalidate(); // Перерисовываем PictureBox
            pointLasts = points;
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (points.Count >= 2)
            {
                using (Pen pen = new Pen(Color.Black))
                {
                    e.Graphics.DrawLines(pen, pointLasts.ToArray());
                }
            }
        }
    }
}
