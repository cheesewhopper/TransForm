namespace formTrans
{

    public static class pub
    {
        public static string shredA = "";
    }

    public partial class Form1 : Form
    {

        Form2 f;

        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {          
            f = new Form2("Á¦¸ñ",this);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pub.shredA.ToString());
        }
    }
}