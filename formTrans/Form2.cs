using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formTrans
{   

    public partial class Form2 : Form
    {
        public int a = 0;
        Form1 f = null;

        public Form2(string title, Form1 frm)
        {
            InitializeComponent();
            f = frm;
            this.Text = title;
            //타이틀변경
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pub.shredA = textBox1.Text;
        }
    }
}
