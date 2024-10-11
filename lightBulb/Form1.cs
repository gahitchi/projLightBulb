using Microsoft.VisualBasic.ApplicationServices;

namespace lightBulb
{
    public partial class Form1 : Form
    {
        Lightbulb l1 = new Lightbulb();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l1.Toggle();

            if (l1.State == true)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/gahia/source/repos/lightBulb/light_on.png");
            }
            else
            {
                pictureBox1.Image = Image.FromFile("C:/Users/gahia/source/repos/lightBulb/light_off.png");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            l1.PosUp();
            pictureBox1.Location = new Point(pictureBox1.Location.X, l1.Position);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            l1.PosDown();  
            pictureBox1.Location = new Point(pictureBox1.Location.X, l1.Position);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(870, 540);
        }
    }
}
