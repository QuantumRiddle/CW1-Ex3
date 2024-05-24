using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Задание_3
{
    public partial class Form2 : Form
    {
        
        
        public Form2()
        {
            InitializeComponent();

            label4.Text = DateTime.Now.ToString("T");

        }
        

        public void SetTimer(string text8)
        {

            label3.Text = text8;
        }


        public void SetGroup(string text)
        {
            textBox6.Text = text;
        }

        public void SetText(string text1, string text2, string text3)
        {
            textBox5.Text = text1 + " " + text2 + " " + text3;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

