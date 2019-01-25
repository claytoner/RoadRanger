using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadRanger_LLC
{
    public partial class RoadRangerInventoryForm : Form
    {
        public RoadRangerInventoryForm()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
        }

        private void PtRpt_Button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(checkedListBox1.CheckedItems );
        }
    }
}
