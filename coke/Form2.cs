using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;

namespace coke
{
    public partial class Form2 : Form
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendString")]
        static extern Int32 mciSendString(String command, StringBuilder buffer, Int32 bufferSize, IntPtr hwndCallback);

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // https://stackoverflow.com/questions/1449410/programatically-ejecting-and-retracting-the-cd-drive-in-vb-net-or-c-sharp
            mciSendString("set CDAudio door open", null, 0, IntPtr.Zero);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
