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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Form1.GetImage(Properties.Settings.Default.ProfilePic);
            textBox1.Text = Properties.Settings.Default.UserName1;
            textBox2.Text = Properties.Settings.Default.UserName2;
            userToolStripMenuItem.Text = "User:" + Properties.Settings.Default.UserName1;
            userToolStripMenuItem.Image = Form1.GetImage(Properties.Settings.Default.ProfilePic);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text + textBox2.Text;
            Properties.Settings.Default.UserName1 = textBox1.Text;
            Properties.Settings.Default.UserName2 = textBox2.Text;

            

            string pfp = ConvImgToB64(pictureBox1.Image);
            Properties.Settings.Default.ProfilePic = pfp;
            Properties.Settings.Default.Save();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        public string ConvImgToB64(Image img)
        {
            var base64 = string.Empty;
            using (MemoryStream ms = new MemoryStream()) {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                base64 = Convert.ToBase64String(ms.ToArray());
            }
            return base64;
        }



        private void button2_Click(object sender, EventArgs e)
        {
           
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image|*.png;*.jpg;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(@openFileDialog.FileName);
                    string pfp = ConvImgToB64(pictureBox1.Image);
                    Properties.Settings.Default.ProfilePic = pfp;
                    Properties.Settings.Default.Save();
                }

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
