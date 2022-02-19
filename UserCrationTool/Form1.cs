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

            int str = comboStart_str.SelectedIndex;
            string colums_name, colums_position;

            read._start = comboStart_str.SelectedIndex;
            colums_name = comboName.SelectedItem.ToString();
            colums_position = comboPos.SelectedItem.ToString();

            var input_data = read._Data(colums_name+colums_position);
            string[] countries = new string[read.sheet.Rows.Length - read._start];

            for (int column = 0; column < input_data.Length; column++)
            {
                for (; str < input_data[column].Length; str++)
                {
                    countries[str- comboStart_str.SelectedIndex] = input_data[0][str] + " - "+input_data[1][str];
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
    }
}
