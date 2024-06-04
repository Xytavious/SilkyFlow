namespace SilkyFlow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.Show();
            this.Hide();

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Form1.GetImage(Properties.Settings.Default.ProfilePic);
            label3.Text = Properties.Settings.Default.UserName1;
            label4.Text = Properties.Settings.Default.UserName2;
            userToolStripMenuItem.Text = "User:" + Properties.Settings.Default.UserName1;
            userToolStripMenuItem.Image = Form1.GetImage(Properties.Settings.Default.ProfilePic);

        }
        public static Image GetImage(string value)
        {
            byte[] bytes = Convert.FromBase64String(value);
            Image image;
            try
            { 
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    image = Image.FromStream(ms);
                }
                return image;
            } catch (Exception ex)
            {
                return null;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}