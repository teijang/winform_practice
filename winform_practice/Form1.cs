using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsFormsDLLApp1;

namespace winform_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(e.ToString());
        }

        private void dialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(e.ToString());
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            

            //MessageBox.Show(e.ClickedItem.Text);

        }
    }
}
