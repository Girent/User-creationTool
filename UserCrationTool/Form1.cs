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
        read_xlsx read = new read_xlsx();
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void buttonRead_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            read._start = comboStart_str.SelectedIndex;//set start string index
            int string_num = comboStart_str.SelectedIndex;

            string colums_name, colums_position;
            colums_name = comboName.SelectedItem.ToString();
            colums_position = comboPos.SelectedItem.ToString();

            var input_data = read._Data(colums_name+colums_position);
            string[] countries = new string[read.sheet.Rows.Length - read._start];

            for (int column = 0; column < input_data.Length; column++)
            {
                for (; string_num < input_data[column].Length; string_num++)
                {
                    countries[string_num- comboStart_str.SelectedIndex] = input_data[0][string_num] + " - "+input_data[1][string_num];
                }
            }
            listBox1.Items.AddRange(countries);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            f_name.Text = openFileDialog1.FileName;
            read._path = openFileDialog1.FileName;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
