using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyPatternWF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.cbSub.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subject subject = null;
           if(cbSub.SelectedIndex == 0)
            {
                subject = new Toan();
            }
           else
            {
                subject = new Van();
            }

            Subject proxy = new Proxy(subject);
            rtbContent.Text += proxy.DoSomeWork();

        }
    }
}
