namespace WindowsFormsApp2
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
            this.tb1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtg = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.str = new System.Windows.Forms.TextBox();
            this.chb3 = new System.Windows.Forms.CheckBox();
            this.chb2 = new System.Windows.Forms.CheckBox();
            this.chb1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.add1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(106, 3);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(211, 27);
            this.tb1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.rtg);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.str);
            this.panel1.Controls.Add(this.chb3);
            this.panel1.Controls.Add(this.chb2);
            this.panel1.Controls.Add(this.chb1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb1);
            this.panel1.Controls.Add(this.add1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 87);
            this.panel1.TabIndex = 1;
            // 
            // rtg
            // 
            this.rtg.FormattingEnabled = true;
            this.rtg.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.rtg.Location = new System.Drawing.Point(516, 27);
            this.rtg.Name = "rtg";
            this.rtg.Size = new System.Drawing.Size(65, 21);
            this.rtg.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Рейтинг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Страница";
            // 
            // str
            // 
            this.str.Location = new System.Drawing.Point(516, 52);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(65, 20);
            this.str.TabIndex = 8;
            // 
            // chb3
            // 
            this.chb3.AutoSize = true;
            this.chb3.Location = new System.Drawing.Point(350, 52);
            this.chb3.Name = "chb3";
            this.chb3.Size = new System.Drawing.Size(84, 17);
            this.chb3.TabIndex = 7;
            this.chb3.Text = "В процессе";
            this.chb3.UseVisualStyleBackColor = true;
            this.chb3.CheckedChanged += new System.EventHandler(this.chb3_CheckedChanged);
            // 
            // chb2
            // 
            this.chb2.AutoSize = true;
            this.chb2.Location = new System.Drawing.Point(350, 29);
            this.chb2.Name = "chb2";
            this.chb2.Size = new System.Drawing.Size(80, 17);
            this.chb2.TabIndex = 6;
            this.chb2.Text = "Прочитана";
            this.chb2.UseVisualStyleBackColor = true;
            this.chb2.CheckedChanged += new System.EventHandler(this.chb2_CheckedChanged);
            // 
            // chb1
            // 
            this.chb1.AutoSize = true;
            this.chb1.Location = new System.Drawing.Point(350, 6);
            this.chb1.Name = "chb1";
            this.chb1.Size = new System.Drawing.Size(79, 17);
            this.chb1.TabIndex = 5;
            this.chb1.Text = "Прочитать";
            this.chb1.UseVisualStyleBackColor = true;
            this.chb1.CheckedChanged += new System.EventHandler(this.chb1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Категория";
            // 
            // cb1
            // 
            this.cb1.AutoCompleteCustomSource.AddRange(new string[] {
            "Драмма",
            "Комедия",
            "Поэма",
            "Сказка"});
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Боевик",
            "Комедия",
            "Драмма",
            "Поэма"});
            this.cb1.Location = new System.Drawing.Point(106, 42);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(211, 21);
            this.cb1.TabIndex = 2;
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(783, 3);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(75, 37);
            this.add1.TabIndex = 2;
            this.add1.Text = "Добавить";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавьте книгу";
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(620, 118);
            this.textbox1.Multiline = true;
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(133, 32);
            this.textbox1.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(569, 355);
            this.listBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(640, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "поиск по книге";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "Найти похожие книги";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox str;
        private System.Windows.Forms.CheckBox chb3;
        private System.Windows.Forms.CheckBox chb2;
        private System.Windows.Forms.CheckBox chb1;
        private System.Windows.Forms.ComboBox rtg;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}

