using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingApplication
{
    public partial class DrawingApp : Form
    {
        Pen myPen = new Pen(Color.Black)
        {
            StartCap = System.Drawing.Drawing2D.LineCap.Round,
            EndCap = System.Drawing.Drawing2D.LineCap.Round,
            LineJoin = System.Drawing.Drawing2D.LineJoin.Round
        };
        Graphics myGraphics;
        bool isDrawing = false;
        String shape = "line";
        Point p;
        
        public DrawingApp()
        {
            InitializeComponent();
            myGraphics = canvas.CreateGraphics();
        }
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDrawing)
            {
                myGraphics.DrawLine(myPen, p, e.Location);
                
            }
            p = e.Location;
        }

        private void blackButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Black;
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.White;
        }

        private void grayButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Gray;
        }
        private void brownButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Brown;
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Red;
        }
        private void blueButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Blue;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Green;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Yellow;
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Orange;
        }

        private void purpleButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Purple;
        }

        private void limeButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Lime;
        }

        private void cyanButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Cyan;
        }

        private void magentaButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Magenta;
        }

        private void indigoButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Indigo;
        }

        private void tanButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Tan;
        }

        private void beigeButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Beige;
        }

        private void pinkButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Pink;
        }

        private void lightPurpleButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.DarkViolet;
        }

        private void lightBlueButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.DeepSkyBlue;
        }

        private void darkPinkButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.HotPink;
        }

        private void lightGreenButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.LimeGreen;
        }

        private void orangeRedButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.OrangeRed;
        }

        private void silverButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Silver;
        }

        private void goldButton_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Gold;
        }

        private void size1_CheckedChanged(object sender, EventArgs e)
        {
            if(size1.Checked)
            {
                myPen.Width = 1;
            }
        }

        private void size2_CheckedChanged(object sender, EventArgs e)
        {
            if (size2.Checked)
            {
                myPen.Width = 2;
            }
        }

        private void size3_CheckedChanged(object sender, EventArgs e)
        {
            if (size3.Checked)
            {
                myPen.Width = 3;
            }
        }

        private void size5_CheckedChanged(object sender, EventArgs e)
        {
            if (size5.Checked)
            {
                myPen.Width = 5;
            }
        }

        private void size7point5_CheckedChanged(object sender, EventArgs e)
        {
            if (size7point5.Checked)
            {
                myPen.Width = (float)7.5;
            }
        }

        private void size10_CheckedChanged(object sender, EventArgs e)
        {
            if (size10.Checked)
            {
                myPen.Width = 10;
            }
        }

        private void size12_CheckedChanged(object sender, EventArgs e)
        {
            if (size12.Checked)
            {
                myPen.Width = 12;
            }
        }

        private void size15_CheckedChanged(object sender, EventArgs e)
        {
            if (size15.Checked)
            {
                myPen.Width = 15;
            }
        }

        private void size17point5_CheckedChanged(object sender, EventArgs e)
        {
            if (size17point5.Checked)
            {
                myPen.Width = (float)17.5;
            }
        }

        private void size20_CheckedChanged(object sender, EventArgs e)
        {
            if (size20.Checked)
            {
                myPen.Width = 20;
            }
        }

        private void eraserButton_Click(object sender, EventArgs e)
        {
            myPen.Color = SystemColors.ControlLight;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            myGraphics.Clear(SystemColors.ControlLight);
        }
    }
}
