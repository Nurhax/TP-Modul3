namespace tpmodul3_1302223050
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            label1.Text = "Halo " + text;
        }
    }
}
