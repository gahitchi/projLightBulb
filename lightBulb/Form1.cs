namespace lightBulb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\gahia\\source\\repos\\lightBulb\\light_on.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\gahia\\source\\repos\\lightBulb\\light_off.png");
        }
    }
}
