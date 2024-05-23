
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Задание_3
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.Black;
            vScrollBar1.Value = 0;
            vScrollBar2.Value = 0;
            vScrollBar3.Value = 0;
        }
       

       private void paint(object sender,PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Color color = Color.FromArgb(255, vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);

           //Brush myBrush = new SolidBrush(color);

            if (radioButton1.Checked)
                if (checkBox1.Checked)
                {
                    e.Graphics.DrawRectangle(Pens.Black, 50, 50, 100, 25);
                    //e.Graphics.FillRectangle(myBrush, 50, 50, 100, 25);
                }
            else e.Graphics.DrawRectangle(Pens.Black, 50, 50, 100, 25);
            
            if (radioButton2.Checked)
                if (checkBox1.Checked)
                {
                    e.Graphics.DrawEllipse(Pens.Black, 50, 50, 100, 25);
                    //e.Graphics.FillEllipse(myBrush, 50, 50, 100, 25);
                }
                else e.Graphics.DrawEllipse(Pens.Black, 50, 50, 100, 25);
            
            if (radioButton3.Checked)
                if (checkBox1.Checked)
                {
                    e.Graphics.DrawEllipse(Pens.Black, 50, 50, 50, 50);
                    //e.Graphics.FillEllipse(myBrush, 50, 50, 50, 50);
                }
                else e.Graphics.DrawEllipse(Pens.Black, 50, 50, 50,50);

        }




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }


        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
        }
    }
}
