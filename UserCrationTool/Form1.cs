using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserCrationTool
{
    public partial class Form1 : Form
    {
        private int start_index;
        private string pathFile;
        private string[] getData;
        private string[] position;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            f_name.Text = openFileDialog1.FileName;
            pathFile = openFileDialog1.FileName;
            if (f_name.Text != "Path")
            {
                comboName.Enabled = true;
                checkBox_position.Enabled = true;
            }
        }
        private void checkBox_position_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_position.Checked)
            {
                comboPos.Enabled = true;
            }
            else
            {
                comboPos.Enabled = false;
            }
        }
        private void checkBoxLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLogin.Checked)
            {
                //comboLogin.Enabled = true;
            }
            else
            {
                comboLogin.Enabled = false;
            }

        }
        private void buttonRead_Click(object sender, EventArgs e)
        {
            buttonCreate.Enabled = true;

            start_index = comboStart_str.SelectedIndex;


            listBox1.Items.Clear();
            if (checkBox_position.Checked)
            {
                read_xlsx readFile_position = new read_xlsx();
                position = readFile_position.ColumnData(comboPos.SelectedIndex, start_index, pathFile);
            }
                read_xlsx readFile_name = new read_xlsx();


            getData = readFile_name.ColumnData(comboName.SelectedIndex, start_index, pathFile);

            listBox1.Items.AddRange(getData);
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Generator pass = new Generator();
            List<string[]> headerRow = new List<string[]>()
                {
                  new string[] { "Name", "Password", "Descr" }
                };
            string password;
            if (checkBox_position.Checked)
            {
                for (int i = 0; i < getData.Length; i++)
                {
                    password = pass.generatePass();
                    UserCreator.Create(getData[i], password, position[i]);
                    headerRow.Add(new string[] { getData[i], password, position[i] });
                }
            }
            else
            {
                for (int i = 0; i < getData.Length; i++)
                {
                    password = pass.generatePass();
                    UserCreator.Create(getData[i], password, getData[i]);
                    headerRow.Add(new string[] { getData[i], password, getData[i] });
                }
            }
            UsersDataExport.addXlsx(headerRow);
            MessageBox.Show("Created: "+getData.Length + " users", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
