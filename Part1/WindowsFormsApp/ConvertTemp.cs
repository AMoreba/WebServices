using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class ConvertTemp : Form
    {
        public ConvertTemp()
        {
            InitializeComponent();
        }

        private void ctof_Click(object sender, EventArgs e)
        {

            ConvertingService.Service1Client convertingService = new ConvertingService.Service1Client();
            textBox1.Text = (convertingService.c2f(Convert.ToInt32(textBox.Text))).ToString();
        }

        private void ftoc_Click(object sender, EventArgs e)
        {
            ConvertingService.Service1Client convertingService = new ConvertingService.Service1Client();
            textBox1.Text = (convertingService.f2c(Convert.ToInt32(textBox.Text))).ToString();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
        }
        private void sortBtn_Click(object sender, EventArgs e)
        {
            SortingService.Service2Client sortingService = new SortingService.Service2Client();
            sortResult.Text = sortingService.sort(input.Text);
        }
    }
}
