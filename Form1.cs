using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldApp
{
    public partial class HWApplication : Form
    {
        public HWApplication()
        {
            InitializeComponent();

        
        }

        private void HWButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am coming for your soul on" + sellSoulTime.Text);
        }

        private void helloWorldButton_Click(object sender, EventArgs e)
        {
            helloWorldLabel.Text = "Hello Friend!";
        }
    }
}
