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
            int set1 = 1;
            int set2 = 2;
            int set3 = 3;
            int set4 = 4;
            int set5 = 5;
            label1.Visible = false;
            if (lcv >= 5)
                lcv = 0;
            lcv++;
            if (lcv == set1)
            {
                textBox1.Visible = true;
                set1++;
            }
                
            else if (lcv == set2)
            {
                textBox2.Visible = true;
                set2++;
            }
                
            else if (lcv == set3)
            {
                textBox3.Visible = true;
            }
                
            else if (lcv == set4)
            {
                textBox4.Visible = true;
            }
                
            else if (lcv == set5)
            {
                textBox5.Visible = true;
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // This will open just a little note pad ig 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = false;
            label1.Text = "1: " + textBox1.Text + "\n\n" + "2: " + textBox2.Text + "\n\n" + "3: " + textBox3.Text + "\n\n" + "4: " + textBox4.Text + "\n\n" + "5: " + textBox5.Text;
            Properties.Settings.Default.label1 = label1.Text;
            Properties.Settings.Default.Save();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = Properties.Settings.Default.label1;
        }
    }
}
