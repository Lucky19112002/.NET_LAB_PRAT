using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Size = new Size(Convert.ToInt32(numericUpDown1.Value), textBox1.Height);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Size = new Size(Convert.ToInt32(numericUpDown1.Value), textBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Disable")
            {
                button1.Text = "Enable";
                textBox1.Enabled = false;
            }
            else
            {
                button1.Text = "Disable";
                textBox1.Enabled = true;
            }
        }
    }
}
