using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserCrationTool
{
    public partial class Form1 : Form
    {
        private string pathFile;
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void buttonRead_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int start_index = comboStart_str.SelectedIndex+1;
            read_xlsx readFile_name = new read_xlsx();
            string[] name_ls = readFile_name._Data(comboName.Text, start_index, pathFile);

            //readFile_name._start = comboStart_str.SelectedIndex;//set start string index
            
            //string colums_name, colums_position;
            //colums_name = comboName.SelectedItem.ToString();
            //colums_position = comboPos.SelectedItem.ToString();

            //var input_data = readFile_name._Data(colums_name+colums_position);
            string[] countries = name_ls;

            
            listBox1.Items.AddRange(countries);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            f_name.Text = openFileDialog1.FileName;
            pathFile = openFileDialog1.FileName;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
