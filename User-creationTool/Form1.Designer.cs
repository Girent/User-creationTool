
namespace UserCrationTool
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.comboPos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.f_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboStart_str = new System.Windows.Forms.ComboBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboLogin = new System.Windows.Forms.ComboBox();
            this.checkBoxLogin = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.checkBox_description = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(414, 407);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users info";
            // 
            // buttonRead
            // 
            this.buttonRead.Enabled = false;
            this.buttonRead.Location = new System.Drawing.Point(432, 191);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // comboPos
            // 
            this.comboPos.Enabled = false;
            this.comboPos.FormattingEnabled = true;
            this.comboPos.Items.AddRange(new object[] {
            "А",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.comboPos.Location = new System.Drawing.Point(657, 79);
            this.comboPos.Name = "comboPos";
            this.comboPos.Size = new System.Drawing.Size(121, 21);
            this.comboPos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберите столбец имени";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Excel Files|*.xls;*.xlsx;*.xlsm\"";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(432, 30);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 9;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // f_name
            // 
            this.f_name.AutoSize = true;
            this.f_name.Location = new System.Drawing.Point(513, 35);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(29, 13);
            this.f_name.TabIndex = 10;
            this.f_name.Text = "Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Выберите начальную строку";
            // 
            // comboStart_str
            // 
            this.comboStart_str.FormattingEnabled = true;
            this.comboStart_str.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboStart_str.Location = new System.Drawing.Point(657, 161);
            this.comboStart_str.Name = "comboStart_str";
            this.comboStart_str.Size = new System.Drawing.Size(121, 21);
            this.comboStart_str.TabIndex = 12;
            this.comboStart_str.Text = "1";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Enabled = false;
            this.buttonCreate.Location = new System.Drawing.Point(703, 415);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 14;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Выберите столбец логина";
            // 
            // comboLogin
            // 
            this.comboLogin.Enabled = false;
            this.comboLogin.FormattingEnabled = true;
            this.comboLogin.Items.AddRange(new object[] {
            "А",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.comboLogin.Location = new System.Drawing.Point(657, 134);
            this.comboLogin.Name = "comboLogin";
            this.comboLogin.Size = new System.Drawing.Size(121, 21);
            this.comboLogin.TabIndex = 16;
            // 
            // checkBoxLogin
            // 
            this.checkBoxLogin.AutoSize = true;
            this.checkBoxLogin.Enabled = false;
            this.checkBoxLogin.Location = new System.Drawing.Point(657, 111);
            this.checkBoxLogin.Name = "checkBoxLogin";
            this.checkBoxLogin.Size = new System.Drawing.Size(86, 17);
            this.checkBoxLogin.TabIndex = 17;
            this.checkBoxLogin.Text = "Custom login";
            this.checkBoxLogin.UseVisualStyleBackColor = true;
            this.checkBoxLogin.CheckedChanged += new System.EventHandler(this.checkBoxLogin_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Выбрать логины из таблицы";
            // 
            // comboName
            // 
            this.comboName.Enabled = false;
            this.comboName.FormattingEnabled = true;
            this.comboName.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.comboName.Location = new System.Drawing.Point(657, 56);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(121, 21);
            this.comboName.TabIndex = 19;
            // 
            // checkBox_position
            // 
            this.checkBox_description.AutoSize = true;
            this.checkBox_description.Enabled = false;
            this.checkBox_description.Location = new System.Drawing.Point(440, 79);
            this.checkBox_description.Name = "checkBox_position";
            this.checkBox_description.Size = new System.Drawing.Size(171, 17);
            this.checkBox_description.TabIndex = 20;
            this.checkBox_description.Text = "Выберите столбец описания";
            this.checkBox_description.UseVisualStyleBackColor = true;
            this.checkBox_description.CheckedChanged += new System.EventHandler(this.checkBoxDescript_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_description);
            this.Controls.Add(this.comboName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxLogin);
            this.Controls.Add(this.comboLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.comboStart_str);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.f_name);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboPos);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "UserCrationTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.ComboBox comboPos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label f_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboStart_str;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboLogin;
        private System.Windows.Forms.CheckBox checkBoxLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.CheckBox checkBox_description;
    }
}

