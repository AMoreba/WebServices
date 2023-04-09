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
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
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
