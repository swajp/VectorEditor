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
using Newtonsoft.Json;

namespace VectorEditor_IT3B
{
    public partial class Form1 : Form
    {
        Shapes selectedShape = Shapes.None;
        bool firstClick = true;
        Line tempLine = null;
        Circle tempCircle = null;
        List<Shape> shapes;
        System.Drawing.Point mousePoint;
        Color defaultButtonColor;

        int radiusCircle = 1;

        public Form1()
        {
            InitializeComponent();
            defaultButtonColor = btnLine.BackColor;
            shapes = new List<Shape>();
        }

        private void pboxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.Location.ToString();
            mousePoint = e.Location;
            if (tempLine != null)
            {
                tempLine.Point2 = new Point(e.X, e.Y);
            }
            if (tempCircle != null)
            {
                tempCircle.CenterPoint = new Point(e.X, e.Y);
            }
            pboxCanvas.Refresh();
        }

        private void pboxCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedShape == Shapes.Point)
            {
                shapes.Add(new Point(e.Location.X, e.Location.Y));
            }
            if (selectedShape == Shapes.Circle)
            {
               //shapes.Add(new Circle(new Point(e.X, e.Y), new Point(e.X,e.Y)));
                if (firstClick)
                {
                    firstClick = false;
                    tempCircle = new Circle(new Point(e.X, e.Y),radiusCircle);
                }
                else
                {
                    firstClick = true;
                    tempCircle.CenterPoint = new Point(e.X, e.Y);
                    shapes.Add(tempCircle);
                    tempCircle = null;
                }
            }
            if (selectedShape == Shapes.Line)
            {
                if (firstClick)
                {
                    firstClick = false;
                    tempLine = new Line(new Point(e.X, e.Y), new Point(e.X, e.Y));
                }
                else
                {
                    firstClick = true;
                    tempLine.Point2 = new Point(e.X, e.Y);
                    shapes.Add(tempLine);
                    tempLine = null;
                }
            }

            pboxCanvas.Refresh();
            //MessageBox.Show(selectedShape.ToString());
        }

        private void pboxCanvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
            if (tempLine != null)
            {
                tempLine.Draw(e.Graphics);
            }
            if (tempCircle != null)
            {
                tempCircle.Draw(e.Graphics);
            }
        }

        private void sfd_FileOk(object sender, CancelEventArgs e)
        {
            var json = JsonConvert.SerializeObject(shapes, Formatting.Indented);
            File.WriteAllText(sfd.FileName, json);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                sfd.ShowDialog();
            }
            else if (e.KeyCode == Keys.O && e.Control)
            {
                ofd.ShowDialog();
            }
        }

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                var json = File.ReadAllText(ofd.FileName);
                shapes = JsonConvert.DeserializeObject<List<Shape>>(json);
                pboxCanvas.Refresh();
            }
            catch
            {
                MessageBox.Show("Nepodařilo se otevřít.");
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            selectedShape = Shapes.Point;
            btnPoint.BackColor = Color.Lime;
            btnLine.BackColor = defaultButtonColor;
            btnCircle.BackColor = defaultButtonColor;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            selectedShape = Shapes.Line;
            btnPoint.BackColor = defaultButtonColor;
            btnCircle.BackColor = defaultButtonColor;
            btnLine.BackColor = Color.Lime;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            selectedShape = Shapes.Circle;
            btnPoint.BackColor = defaultButtonColor;
            btnLine.BackColor = defaultButtonColor;
            btnCircle.BackColor = Color.Lime;
        }

        private void numRadius_ValueChanged(object sender, EventArgs e)
        {
            radiusCircle = (int)numRadius.Value;
        }
    }
}