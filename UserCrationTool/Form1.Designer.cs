
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
            this.comboName = new System.Windows.Forms.ComboBox();
            this.comboPos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.f_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboStart_str = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(416, 407);
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
            this.buttonRead.Location = new System.Drawing.Point(713, 415);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // comboName
            // 
            this.comboName.FormattingEnabled = true;
            this.comboName.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboName.Location = new System.Drawing.Point(667, 28);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(121, 21);
            this.comboName.TabIndex = 4;
            this.comboName.Text = "A";
            // 
            // comboPos
            // 
            this.comboPos.FormattingEnabled = true;
            this.comboPos.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboPos.Location = new System.Drawing.Point(667, 55);
            this.comboPos.Name = "comboPos";
            this.comboPos.Size = new System.Drawing.Size(121, 21);
            this.comboPos.TabIndex = 5;
            this.comboPos.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберите столбец имени";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выберите столбец должности";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Excel Files|*.xls;*.xlsx;*.xlsm\"";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(632, 415);
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
            this.f_name.Location = new System.Drawing.Point(448, 415);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(0, 13);
            this.f_name.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 90);
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
            "2"});
            this.comboStart_str.Location = new System.Drawing.Point(667, 82);
            this.comboStart_str.Name = "comboStart_str";
            this.comboStart_str.Size = new System.Drawing.Size(121, 21);
            this.comboStart_str.TabIndex = 12;
            this.comboStart_str.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboStart_str);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.f_name);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboPos);
            this.Controls.Add(this.comboName);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.ComboBox comboPos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label f_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboStart_str;
    }
}

