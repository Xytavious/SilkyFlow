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
            textBox1.Visible = false; // This is weird work on this later, something is weird with the variables n stuff, if it isnt fixed its totally intentional
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            label1.Visible = false;
            if (lcv >= 5)
                lcv = 0;
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
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            textBox1.Visible = false;
            label1.Text = "1: " + textBox1.Text + "\n\n" + "2: " + textBox2.Text + "\n\n" + "3: " + textBox3.Text + "\n\n" + "4: " + textBox4.Text + "\n\n" + "5: " + textBox5.Text;
            label3.Text = "1: " + textBox6.Text + "\n\n" + "2: " + textBox7.Text + "\n\n" + "3: " + textBox8.Text + "\n\n" + "4: " + textBox9.Text + "\n\n" + "5: " + textBox10.Text;
            label4.Text = "1: " + textBox11.Text + "\n\n" + "2: " + textBox12.Text + "\n\n" + "3: " + textBox13.Text + "\n\n" + "4: " + textBox14.Text + "\n\n" + "5: " + textBox15.Text;
            label5.Text = "1: " + textBox16.Text + "\n\n" + "2: " + textBox17.Text + "\n\n" + "3: " + textBox18.Text + "\n\n" + "4: " + textBox19.Text + "\n\n" + "5: " + textBox20.Text;
            label6.Text = "1: " + textBox21.Text + "\n\n" + "2: " + textBox22.Text + "\n\n" + "3: " + textBox23.Text + "\n\n" + "4: " + textBox24.Text + "\n\n" + "5: " + textBox25.Text;
            label7.Text = "1: " + textBox26.Text + "\n\n" + "2: " + textBox27.Text + "\n\n" + "3: " + textBox28.Text + "\n\n" + "4: " + textBox29.Text + "\n\n" + "5: " + textBox30.Text;
            label8.Text = "1: " + textBox31.Text + "\n\n" + "2: " + textBox32.Text + "\n\n" + "3: " + textBox33.Text + "\n\n" + "4: " + textBox34.Text + "\n\n" + "5: " + textBox35.Text;

            Properties.Settings.Default.label1 = label1.Text; // 2 doesnt exist because label2 already existed
            Properties.Settings.Default.label3 = label3.Text;
            Properties.Settings.Default.label4 = label4.Text;
            Properties.Settings.Default.label5 = label5.Text;
            Properties.Settings.Default.label6 = label6.Text;
            Properties.Settings.Default.label7 = label7.Text;
            Properties.Settings.Default.label8 = label8.Text;
            Properties.Settings.Default.Save();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label1.Text = Properties.Settings.Default.label1;
        }
        int lcv2 = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            textBox6.Visible = false; // This is weird work on this later, something is weird with the variables n stuff, if it isnt fixed its totally intentional
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            label3.Visible = false;
            if (lcv2 >= 5)
                lcv2 = 0;
            lcv2++;
            if (lcv2 == 1)
                textBox6.Visible = true;
            else if (lcv2 == 2)
                textBox7.Visible = true;
            else if (lcv2 == 3)
                textBox8.Visible = true;
            else if (lcv2 == 4)
                textBox9.Visible = true;
            else if (lcv2 == 5)
                textBox10.Visible = true;
            
        }
        int lcv3 = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            textBox11.Visible = false; // This is weird work on this later, something is weird with the variables n stuff, if it isnt fixed its totally intentional
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            label4.Visible = false;
            if (lcv3 >= 5)
                lcv3 = 0;
            lcv3++;
            if (lcv3 == 1)
                textBox11.Visible = true;
            else if (lcv3 == 2)
                textBox12.Visible = true;
            else if (lcv3 == 3)
                textBox13.Visible = true;
            else if (lcv3 == 4)
                textBox14.Visible = true;
            else if (lcv3 == 5)
                textBox15.Visible = true;
        }
        int lcv4 = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            textBox16.Visible = false; // This is weird work on this later, something is weird with the variables n stuff, if it isnt fixed its totally intentional
            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            textBox20.Visible = false;
            label5.Visible = false;
            if (lcv4 >= 5)
                lcv4 = 0;
            lcv4++;
            if (lcv4 == 1)
                textBox16.Visible = true;
            else if (lcv4 == 2)
                textBox17.Visible = true;
            else if (lcv4 == 3)
                textBox18.Visible = true;
            else if (lcv4 == 4)
                textBox19.Visible = true;
            else if (lcv4 == 5)
                textBox20.Visible = true;
        }
        int lcv5 = 0;
        int lcv6 = 0;
        
        private void button7_Click(object sender, EventArgs e)
        {
            textBox21.Visible = false; // This is weird work on this later, something is weird with the variables n stuff, if it isnt fixed its totally intentional
            textBox22.Visible = false;
            textBox23.Visible = false;
            textBox24.Visible = false;
            textBox25.Visible = false;
            label6.Visible = false;
            if (lcv5 >= 5)
                lcv5 = 0;
            lcv5++;
            if (lcv5 == 1)
                textBox21.Visible = true;
            else if (lcv5 == 2)
                textBox22.Visible = true;
            else if (lcv5 == 3)
                textBox23.Visible = true;
            else if (lcv5 == 4)
                textBox24.Visible = true;
            else if (lcv5 == 5)
                textBox25.Visible = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox26.Visible = false; // This is weird work on this later, something is weird with the variables n stuff, if it isnt fixed its totally intentional
            textBox27.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            textBox30.Visible = false;
            label7.Visible = false;
            if (lcv6 >= 5)
                lcv6 = 0;
            lcv6++;
            if (lcv6 == 1)
                textBox26.Visible = true;
            else if (lcv6 == 2)
                textBox27.Visible = true;
            else if (lcv6 == 3)
                textBox28.Visible = true;
            else if (lcv6 == 4)
                textBox29.Visible = true;
            else if (lcv6 == 5)
                textBox30.Visible = true;
        }
        int lcv7 = 0;
        private void button9_Click(object sender, EventArgs e)
        {
            textBox31.Visible = false; // This is weird work on this later, something is weird with the variables n stuff, if it isnt fixed its totally intentional
            textBox32.Visible = false;
            textBox33.Visible = false;
            textBox34.Visible = false;
            textBox35.Visible = false;
            label7.Visible = false;
            if (lcv7 >= 5)
                lcv7 = 0;
            lcv7++;
            
            if (lcv7 == 1)
                textBox31.Visible = true;
            else if (lcv7 == 2)
                textBox32.Visible = true;
            else if (lcv7 == 3)
                textBox33.Visible = true;
            else if (lcv7 == 4)
                textBox34.Visible = true;
            else if (lcv7 == 5)
                textBox35.Visible = true;

        }
    }
}
