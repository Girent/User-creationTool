using System;
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
            
            string[] name_ls = readFile_name.ColumnData(comboName.SelectedIndex, start_index, pathFile);

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

        private void checkBoxLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLogin.Checked)
            {
                comboLogin.Enabled = true;
            }
            else
            {
                comboLogin.Enabled = false;
            }
           
        }
    }
}
