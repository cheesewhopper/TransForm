namespace formTrans
{
    public partial class Form1 : Form
    {
        Form2 f = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {          
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(f.textBox1.Text);
        }
    }
}