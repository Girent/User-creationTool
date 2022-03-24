using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserCrationTool
{
    public partial class Form1 : Form
    {
        private int start_Index;
        private string path_File;
        private string[] get_Data;
        private string[] user_Description;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            f_name.Text = openFileDialog1.FileName;
            path_File = openFileDialog1.FileName;
            if (f_name.Text != "Path")
            {
                comboName.Enabled = true;
                checkBox_description.Enabled = true;
                buttonRead.Enabled = true;
            }
        }
        private void checkBoxDescript_CheckedChanged(object sender, EventArgs e)
        {
            comboPos.Enabled = checkBox_description.Checked ? true : false;
        }
        private void checkBoxLogin_CheckedChanged(object sender, EventArgs e)
        {
            comboLogin.Enabled = checkBoxLogin.Checked ? false : false;
        }
        private void buttonRead_Click(object sender, EventArgs e)
        {
            buttonCreate.Enabled = true;

            start_Index = comboStart_str.SelectedIndex;


            listBox1.Items.Clear();
            if (checkBox_description.Checked)
            {
                ReadXlsx readFile_position = new ReadXlsx();
                user_Description = readFile_position.ColumnData(comboPos.SelectedIndex, start_Index, path_File);
            }
                ReadXlsx readFile_name = new ReadXlsx();


            get_Data = readFile_name.ColumnData(comboName.SelectedIndex, start_Index, path_File);

            listBox1.Items.AddRange(get_Data);
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Generator pass = new Generator();
            List<string[]> headerRow = new List<string[]>()
                {
                  new string[] { "Name", "Password", "Descr" }
                };
            string usr_password;
            if (checkBox_description.Checked)
            {
                for (int i = 0; i < get_Data.Length; i++)
                {
                    usr_password = pass.GeneratePass();
                    UserCreator.Create(get_Data[i], usr_password, user_Description[i]);
                    headerRow.Add(new string[] { get_Data[i], usr_password, user_Description[i] });
                }
            }
            else
            {
                for (int i = 0; i < get_Data.Length; i++)
                {
                    usr_password = pass.GeneratePass();
                    UserCreator.Create(get_Data[i], usr_password, get_Data[i]);
                    headerRow.Add(new string[] { get_Data[i], usr_password, get_Data[i] });
                }
            }
            UsersDataExport.AddXlsx(headerRow);
            MessageBox.Show("Created: "+get_Data.Length + " users", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
