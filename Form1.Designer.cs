namespace DS_Anketa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_GoodNout = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown_PriceNout = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.maskTextBox_DateBuy = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_NoutBrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_HomeComp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Work = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton_J = new System.Windows.Forms.RadioButton();
            this.radioButton_M = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.maskTextBox_DateBirth = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Family = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_Save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_Load = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PriceNout)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox_GoodNout);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.numericUpDown_PriceNout);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.maskTextBox_DateBuy);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_NoutBrand);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox_HomeComp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_Work);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.maskTextBox_DateBirth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_Family);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(261, 482);
            this.panel1.TabIndex = 0;
            // 
            // comboBox_GoodNout
            // 
            this.comboBox_GoodNout.FormattingEnabled = true;
            this.comboBox_GoodNout.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBox_GoodNout.Location = new System.Drawing.Point(8, 448);
            this.comboBox_GoodNout.Name = "comboBox_GoodNout";
            this.comboBox_GoodNout.Size = new System.Drawing.Size(100, 23);
            this.comboBox_GoodNout.TabIndex = 19;
            this.comboBox_GoodNout.Text = "Да";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Устраивает ли Вас ваш ноутбук?";
            // 
            // numericUpDown_PriceNout
            // 
            this.numericUpDown_PriceNout.Location = new System.Drawing.Point(8, 404);
            this.numericUpDown_PriceNout.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_PriceNout.Name = "numericUpDown_PriceNout";
            this.numericUpDown_PriceNout.Size = new System.Drawing.Size(100, 23);
            this.numericUpDown_PriceNout.TabIndex = 17;
            this.numericUpDown_PriceNout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_PriceNout.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "По какой цене Вы его приобретали?";
            // 
            // maskTextBox_DateBuy
            // 
            this.maskTextBox_DateBuy.Location = new System.Drawing.Point(8, 360);
            this.maskTextBox_DateBuy.Mask = "00/00/0000";
            this.maskTextBox_DateBuy.Name = "maskTextBox_DateBuy";
            this.maskTextBox_DateBuy.Size = new System.Drawing.Size(100, 23);
            this.maskTextBox_DateBuy.TabIndex = 15;
            this.maskTextBox_DateBuy.Text = "01012000";
            this.maskTextBox_DateBuy.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Когда Вы приобрели ноутбук?";
            // 
            // textBox_NoutBrand
            // 
            this.textBox_NoutBrand.Location = new System.Drawing.Point(8, 316);
            this.textBox_NoutBrand.Name = "textBox_NoutBrand";
            this.textBox_NoutBrand.Size = new System.Drawing.Size(243, 23);
            this.textBox_NoutBrand.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Какой марки Ваш ноутбук?";
            // 
            // comboBox_HomeComp
            // 
            this.comboBox_HomeComp.FormattingEnabled = true;
            this.comboBox_HomeComp.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBox_HomeComp.Location = new System.Drawing.Point(8, 272);
            this.comboBox_HomeComp.Name = "comboBox_HomeComp";
            this.comboBox_HomeComp.Size = new System.Drawing.Size(100, 23);
            this.comboBox_HomeComp.TabIndex = 11;
            this.comboBox_HomeComp.Text = "Да";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Есть ли у Вас дома домашний компьютер?";
            // 
            // textBox_Work
            // 
            this.textBox_Work.Location = new System.Drawing.Point(8, 228);
            this.textBox_Work.Name = "textBox_Work";
            this.textBox_Work.Size = new System.Drawing.Size(243, 23);
            this.textBox_Work.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Род занятий";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioButton_J);
            this.panel2.Controls.Add(this.radioButton_M);
            this.panel2.Location = new System.Drawing.Point(8, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 51);
            this.panel2.TabIndex = 7;
            // 
            // radioButton_J
            // 
            this.radioButton_J.AutoSize = true;
            this.radioButton_J.Location = new System.Drawing.Point(6, 28);
            this.radioButton_J.Name = "radioButton_J";
            this.radioButton_J.Size = new System.Drawing.Size(36, 19);
            this.radioButton_J.TabIndex = 1;
            this.radioButton_J.Text = "Ж";
            this.radioButton_J.UseVisualStyleBackColor = true;
            // 
            // radioButton_M
            // 
            this.radioButton_M.AutoSize = true;
            this.radioButton_M.Checked = true;
            this.radioButton_M.Location = new System.Drawing.Point(6, 3);
            this.radioButton_M.Name = "radioButton_M";
            this.radioButton_M.Size = new System.Drawing.Size(36, 19);
            this.radioButton_M.TabIndex = 0;
            this.radioButton_M.TabStop = true;
            this.radioButton_M.Text = "М";
            this.radioButton_M.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пол";
            // 
            // maskTextBox_DateBirth
            // 
            this.maskTextBox_DateBirth.Location = new System.Drawing.Point(8, 112);
            this.maskTextBox_DateBirth.Mask = "00/00/0000";
            this.maskTextBox_DateBirth.Name = "maskTextBox_DateBirth";
            this.maskTextBox_DateBirth.Size = new System.Drawing.Size(100, 23);
            this.maskTextBox_DateBirth.TabIndex = 5;
            this.maskTextBox_DateBirth.Text = "01012000";
            this.maskTextBox_DateBirth.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата рождения";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(8, 68);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 23);
            this.textBox_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // textBox_Family
            // 
            this.textBox_Family.Location = new System.Drawing.Point(8, 23);
            this.textBox_Family.Name = "textBox_Family";
            this.textBox_Family.Size = new System.Drawing.Size(100, 23);
            this.textBox_Family.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(12, 500);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(67, 23);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Удалить все";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(279, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(981, 482);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Фамилия";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата рождения";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Пол";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 40;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Род занятий";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Домашний компьютер?";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Марка ноутбука";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Дата покупки";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 90;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Цена ноутбука";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Устраивает ли ноутбук?";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 150;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(566, 500);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(194, 23);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "Сохранить в файл";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt | *.txt";
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(766, 500);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(194, 23);
            this.button_Load.TabIndex = 6;
            this.button_Load.Text = "Загрузить из файла";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 540);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анкета";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PriceNout)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox comboBox_GoodNout;
        private Label label10;
        private NumericUpDown numericUpDown_PriceNout;
        private Label label9;
        private MaskedTextBox maskTextBox_DateBuy;
        private Label label8;
        private TextBox textBox_NoutBrand;
        private Label label7;
        private ComboBox comboBox_HomeComp;
        private Label label6;
        private TextBox textBox_Work;
        private Label label5;
        private Panel panel2;
        private RadioButton radioButton_J;
        private RadioButton radioButton_M;
        private Label label4;
        private MaskedTextBox maskTextBox_DateBirth;
        private Label label3;
        private TextBox textBox_Name;
        private Label label2;
        private TextBox textBox_Family;
        private Button button_Add;
        private Button button1;
        private Button button2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ErrorProvider errorProvider1;
        private Button button_Save;
        private SaveFileDialog saveFileDialog1;
        private Button button_Load;
        private OpenFileDialog openFileDialog1;
    }
}