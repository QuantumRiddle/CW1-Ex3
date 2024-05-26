using System;
using System.Drawing;
using System.Windows.Forms;

namespace Задание_3
{
    public partial class Form1 : Form
    {

        private DateTime startTime;

        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.Empty;
            startTime = DateTime.Now;

        }
       

       private void paint(object sender,PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Color color = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);

           Brush myBrush = new SolidBrush(color);

        
                if (radioButton1.Checked)
                {
                    
                    g.DrawRectangle(Pens.Black, 50, 50, 150, 80);
                    if (checkBox1.Checked) { g.FillRectangle(myBrush, 50, 50, 150, 80); }
                }


                if (radioButton2.Checked)
                {
                    g.DrawEllipse(Pens.Black, 50, 50, 50, 50);
                if (checkBox1.Checked ) { g.FillEllipse(myBrush, 50, 50, 50, 50); }
                }

                if (radioButton3.Checked)
                {
                    g.DrawEllipse(Pens.Black, 50, 50, 100, 55);
                    if (checkBox1.Checked) { g.FillEllipse(myBrush, 50, 50, 100, 55); }
                }
            

        }


        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.Invalidate();
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.Invalidate();
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.Invalidate();
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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Безденежных Артем Сергеевич группа 24101");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            
            form2.SetText(textBox1.Text, textBox2.Text, textBox3.Text);

            form2.SetGroup(textBox4.Text);

            form2.SetTimer(startTime.ToString("T"));

            form2.ShowDialog();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
    }
}
