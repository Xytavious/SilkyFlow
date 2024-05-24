using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilkyFlow
{
    public partial class Form2 : Form
    {
  
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
            
        }
        int lcv = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            lcv++;
            if (lcv == 1)
                textBox1.Visible = true;
            else if (lcv == 2)
                textBox2.Visible = true;
            else if (lcv == 3)
                textBox3.Visible = true;
            else if (lcv == 4)
                textBox4.Visible = true;
            else if (lcv == 5)
                textBox5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // This will open just a little note pad ig 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = false;
            label1.Text = "First Task: " + textBox1.Text + "\n\n" + "Second Task: " + textBox2.Text;
        }
    }
}
