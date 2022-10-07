using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_wmp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            //Lay thong tin ok hay cancel
            
            DialogResult DR = oFD.ShowDialog();
            if (DR == DialogResult.OK)
            {
                string url = oFD.FileName;
                this.WMP.URL = url;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void oFD_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
