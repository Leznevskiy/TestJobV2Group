using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestJobV2Group
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Список координат для отрисовки фигур
        /// </summary>
        private List<Point> points = new List<Point>();
        /// <summary>
        /// Проверка выполнение действий. true - рисуем. false - проверяем
        /// </summary>
        private bool PointsCheck = true;

        public Form1()
        {
            InitializeComponent();
            PictureBox.MouseClick += PictureBox_MouseClick;
            PictureBox.Paint += PictureBox_Paint;

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Рисуем точки
            foreach (Point point in points)
            {
                g.FillEllipse(Brushes.Red, point.X - 3, point.Y - 3, 6, 6);
            }
            // Соединяем точки линиями
            if (points.Count > 1)
            {
                for (int i = 1; i < points.Count; i++)
                {
                    int Previous = i - 1;
                    g.DrawLine(Pens.Blue, points[i], points[Previous]);
                }
                g.DrawLine(Pens.Blue, points[points.Count -1], points[0]);
            }
        }

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (PointsCheck) // рисуем
            {
                if (e.Button == MouseButtons.Left)
                {
                    points.Add(e.Location); // добавляем новую точку в наш массив
                    PictureBox.Invalidate(); // Перерисовываем PictureBox для отображения новой точки
                }
            }
            else // проверяем
            {
                bool isInside = IsPointInPolygon(e.Location, points);
                MessageBox.Show("Точка " + (isInside == true ? "внутри" : "снаружи") + " фигуры") ;
            }
        }

        private static bool IsPointInPolygon(Point point, List<Point> polygon)
        {
            int polygonLength = polygon.Count, i = 0;
            bool inside = false;

            // За каждую сторону полигона
            for (int j = polygonLength - 1; i < polygonLength; j = i++)
            {
                if (((polygon[i].Y <= point.Y && point.Y < polygon[j].Y) ||
                    (polygon[j].Y <= point.Y) && (point.Y < polygon[i].Y)) &&
                    (point.X < (polygon[j].X - polygon[i].X) * (point.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) + polygon[i].X))
                {
                    inside = !inside;
                }
            }
            return inside;
        }

        private void SearchPointButton_Click(object sender, EventArgs e)
        {
            PointsCheck = !PointsCheck;
            if (PointsCheck)
                MessageBox.Show("Режим рисование фигуры", "v2-Grupp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Режим проверки точки", "v2-Grupp", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// убирем последнюю точку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBackButton_Click(object sender, EventArgs e)
        {
            points.RemoveAt(points.Count -1);
            PictureBox.Invalidate();
        }

        private void сохранитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(points.Count == 0)
            {
                MessageBox.Show("Сохранять нечего", "v2-Grupp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем в файл
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    for (int i = 0; i < points.Count; i++)
                    {
                        writer.WriteLine(points[i].X + "." + points[i].Y);
                    }
                }
                MessageBox.Show("Файл успешно сохранен.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
            }
        }

        private void загрузитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = openFileDialog1.FileName;
                // Открываем файл для чтения
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line;

                    // Читаем файл построчно, пока не достигнем конца файла
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] coordinates = line.Split(new char[] { '.' });
                        Point point = new Point() { X = Convert.ToInt32(coordinates[0]), Y = Convert.ToInt32(coordinates[1]) };
                        points.Add(point);
                    }
                }
                PictureBox.Invalidate(); // нарисуем
            }
            catch (Exception ex)
            {
                // Обрабатываем возможные ошибки при чтении файла
                MessageBox.Show("Ошибка чтения файла:" + ex.Message);
            }
        }
    }
}
