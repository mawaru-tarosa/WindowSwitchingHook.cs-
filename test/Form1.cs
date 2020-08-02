using System.Windows.Forms;
using System;

namespace test
{
    public partial class Form1 : Form
    {
        WindowSwitchingHook wsh = new WindowSwitchingHook();
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                wsh.Window += new WindowSwitchingHook.Callback(WindowHook);
                wsh.Install();
            }
            else
            {
                wsh.Uninstall();
            }
        }

        private void WindowHook(WindowSwitchEventArgs e)
        {
            label1.Text = e.GetProcessName();
            label2.Text = e.GetTitle();
            label3.Text = e.GetProcessID().ToString();                        
        }
    }
}
