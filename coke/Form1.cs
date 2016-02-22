using System;
using System.Windows.Forms;

namespace coke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nf = new Form2();
            nf.Show();
            Hide();
        }
    }
}
