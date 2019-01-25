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



    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClose()
        {
            System.IO.StreamWriter wr = new System.IO.StreamWriter("F:\\WriteInventory.txt");
            wr.WriteLine(comboBox1.Text);
            wr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"F:\RoadRangerTest\WriteInventory.txt"))
            {
                if ((System.IO.File.Exists("F:\\WriteInventory.txt") && new System.IO.FileInfo("F:\\WriteInventory.txt").Length > 0))
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader("F:\\WriteInventory.txt");
                    string item = sr.ReadLine();
                    int index = comboBox1.FindString(item);

                    
                    MessageBox.Show("The Following Store Has Been Selected For the Due Date : " + "\n" + DueDateCldr.SelectionStart );
                    MessageBox.Show("The Store Number is : " + comboBox1.Text);
                    



                    if ((index != -1 & !string.IsNullOrEmpty(item)))
                    {
                        comboBox1.SelectedIndex = index;
                        
                    }
                    sr.Close();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RoadRangerInventoryForm inventory = new RoadRangerInventoryForm();
            inventory.Show();
        }
    }
}
