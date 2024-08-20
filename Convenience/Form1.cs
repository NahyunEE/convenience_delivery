using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convenience
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CU_Click(object sender, EventArgs e)
        {
            SecondPage second = new SecondPage();
            second.storeName = "CU";
            second.ShowDialog();
        }

        private void btn_GS_Click(object sender, EventArgs e)
        {
            SecondPage second = new SecondPage();
            second.storeName = "GS";
            second.ShowDialog();
        }

        private void btn_SEVEN_Click(object sender, EventArgs e)
        {
            SecondPage second = new SecondPage();
            second.storeName = "SEVEN";
            second.ShowDialog();
        }
    }
}
