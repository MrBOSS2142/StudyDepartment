namespace Lab2_Uchebniy_otdel
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
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.textBox_otchestvo = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_Lastname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_otchestvo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_number_of_lectures = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_numberLab = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label_course = new System.Windows.Forms.Label();
            this.label_specialty = new System.Windows.Forms.Label();
            this.label_control = new System.Windows.Forms.Label();
            this.label_audience = new System.Windows.Forms.Label();
            this.comboBox_subject = new System.Windows.Forms.ComboBox();
            this.label_subject = new System.Windows.Forms.Label();
            this.textBox_audience = new System.Windows.Forms.TextBox();
            this.label_date = new System.Windows.Forms.Label();
            this.comboBox_control = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_inXML = new System.Windows.Forms.Button();
            this.button_outInXML = new System.Windows.Forms.Button();
            this.label_countLect = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_spec = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКоличествуЛекцийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВидуКонтроляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скрытьРанельИнтрументовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_undo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonHelp = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numberLab)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_lastname.Location = new System.Drawing.Point(139, 102);
            this.textBox_lastname.MaxLength = 15;
            this.textBox_lastname.Multiline = true;
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(189, 37);
            this.textBox_lastname.TabIndex = 0;
            this.textBox_lastname.TextChanged += new System.EventHandler(this.textBoxTextChanged);
            this.textBox_lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NotNumber_KeyPress);
            // 
            // textBox_otchestvo
            // 
            this.textBox_otchestvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_otchestvo.Location = new System.Drawing.Point(139, 216);
            this.textBox_otchestvo.MaxLength = 15;
            this.textBox_otchestvo.Multiline = true;
            this.textBox_otchestvo.Name = "textBox_otchestvo";
            this.textBox_otchestvo.Size = new System.Drawing.Size(189, 37);
            this.textBox_otchestvo.TabIndex = 1;
            this.textBox_otchestvo.TextChanged += new System.EventHandler(this.textBoxTextChanged);
            this.textBox_otchestvo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NotNumber_KeyPress);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name.Location = new System.Drawing.Point(139, 156);
            this.textBox_name.MaxLength = 15;
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(189, 37);
            this.textBox_name.TabIndex = 2;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBoxTextChanged);
            this.textBox_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NotNumber_KeyPress);
            // 
            // label_Lastname
            // 
            this.label_Lastname.AutoSize = true;
            this.label_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Lastname.Location = new System.Drawing.Point(12, 102);
            this.label_Lastname.Name = "label_Lastname";
            this.label_Lastname.Size = new System.Drawing.Size(104, 24);
            this.label_Lastname.TabIndex = 3;
            this.label_Lastname.Text = "Фамилия:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(12, 156);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(55, 24);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Имя:";
            // 
            // label_otchestvo
            // 
            this.label_otchestvo.AutoSize = true;
            this.label_otchestvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_otchestvo.Location = new System.Drawing.Point(11, 212);
            this.label_otchestvo.Name = "label_otchestvo";
            this.label_otchestvo.Size = new System.Drawing.Size(112, 24);
            this.label_otchestvo.TabIndex = 5;
            this.label_otchestvo.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(91, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Лектор";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(216, 569);
            this.trackBar1.Maximum = 40;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(141, 56);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label_number_of_lectures
            // 
            this.label_number_of_lectures.AutoSize = true;
            this.label_number_of_lectures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number_of_lectures.Location = new System.Drawing.Point(24, 572);
            this.label_number_of_lectures.Name = "label_number_of_lectures";
            this.label_number_of_lectures.Size = new System.Drawing.Size(173, 20);
            this.label_number_of_lectures.TabIndex = 8;
            this.label_number_of_lectures.Text = "Количество лекций";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 21);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1 курс";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 21);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "2 курс";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 21);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.Text = "3 курс";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(15, 100);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(70, 21);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.Text = "4 курс";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(29, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 141);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // numericUpDown_numberLab
            // 
            this.numericUpDown_numberLab.Location = new System.Drawing.Point(225, 629);
            this.numericUpDown_numberLab.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown_numberLab.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_numberLab.Name = "numericUpDown_numberLab";
            this.numericUpDown_numberLab.Size = new System.Drawing.Size(84, 22);
            this.numericUpDown_numberLab.TabIndex = 15;
            this.numericUpDown_numberLab.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(24, 617);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 40);
            this.label6.TabIndex = 16;
            this.label6.Text = "Количество\r\nлабороторных работ";
            // 
            // label_course
            // 
            this.label_course.AutoSize = true;
            this.label_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_course.Location = new System.Drawing.Point(40, 394);
            this.label_course.Name = "label_course";
            this.label_course.Size = new System.Drawing.Size(47, 20);
            this.label_course.TabIndex = 17;
            this.label_course.Text = "Курс";
            // 
            // label_specialty
            // 
            this.label_specialty.AutoSize = true;
            this.label_specialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_specialty.Location = new System.Drawing.Point(179, 394);
            this.label_specialty.Name = "label_specialty";
            this.label_specialty.Size = new System.Drawing.Size(140, 20);
            this.label_specialty.TabIndex = 18;
            this.label_specialty.Text = "Специальность";
            // 
            // label_control
            // 
            this.label_control.AutoSize = true;
            this.label_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_control.Location = new System.Drawing.Point(25, 672);
            this.label_control.Name = "label_control";
            this.label_control.Size = new System.Drawing.Size(127, 20);
            this.label_control.TabIndex = 19;
            this.label_control.Text = "Вид контроля";
            // 
            // label_audience
            // 
            this.label_audience.AutoSize = true;
            this.label_audience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_audience.Location = new System.Drawing.Point(12, 275);
            this.label_audience.Name = "label_audience";
            this.label_audience.Size = new System.Drawing.Size(123, 24);
            this.label_audience.TabIndex = 20;
            this.label_audience.Text = "Аудитория:";
            // 
            // comboBox_subject
            // 
            this.comboBox_subject.FormattingEnabled = true;
            this.comboBox_subject.Items.AddRange(new object[] {
            "ООП",
            "ОЗИ",
            "БД",
            "ТЦ",
            "КГИГ",
            "ППСКГИД"});
            this.comboBox_subject.Location = new System.Drawing.Point(138, 330);
            this.comboBox_subject.Name = "comboBox_subject";
            this.comboBox_subject.Size = new System.Drawing.Size(121, 24);
            this.comboBox_subject.TabIndex = 21;
            this.comboBox_subject.Text = "ООП";
            // 
            // label_subject
            // 
            this.label_subject.AutoSize = true;
            this.label_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_subject.Location = new System.Drawing.Point(12, 328);
            this.label_subject.Name = "label_subject";
            this.label_subject.Size = new System.Drawing.Size(104, 24);
            this.label_subject.TabIndex = 23;
            this.label_subject.Text = "Предмет:";
            // 
            // textBox_audience
            // 
            this.textBox_audience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_audience.Location = new System.Drawing.Point(139, 277);
            this.textBox_audience.MaxLength = 6;
            this.textBox_audience.Multiline = true;
            this.textBox_audience.Name = "textBox_audience";
            this.textBox_audience.Size = new System.Drawing.Size(189, 37);
            this.textBox_audience.TabIndex = 24;
            this.textBox_audience.TextChanged += new System.EventHandler(this.textBoxTextChanged);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_date.Location = new System.Drawing.Point(25, 708);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(57, 20);
            this.label_date.TabIndex = 25;
            this.label_date.Text = "Дата:";
            // 
            // comboBox_control
            // 
            this.comboBox_control.FormattingEnabled = true;
            this.comboBox_control.Items.AddRange(new object[] {
            "Зачет",
            "Экзамен"});
            this.comboBox_control.Location = new System.Drawing.Point(162, 672);
            this.comboBox_control.Name = "comboBox_control";
            this.comboBox_control.Size = new System.Drawing.Size(121, 24);
            this.comboBox_control.TabIndex = 26;
            this.comboBox_control.Text = "Зачет";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(902, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(546, 568);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "";
            // 
            // button_inXML
            // 
            this.button_inXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(240)))));
            this.button_inXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_inXML.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_inXML.Location = new System.Drawing.Point(902, 657);
            this.button_inXML.Name = "button_inXML";
            this.button_inXML.Size = new System.Drawing.Size(274, 63);
            this.button_inXML.TabIndex = 28;
            this.button_inXML.Text = "Запись информации в XML";
            this.button_inXML.UseVisualStyleBackColor = false;
            this.button_inXML.Click += new System.EventHandler(this.Click_inXML);
            // 
            // button_outInXML
            // 
            this.button_outInXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(240)))));
            this.button_outInXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_outInXML.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_outInXML.Location = new System.Drawing.Point(1174, 657);
            this.button_outInXML.Name = "button_outInXML";
            this.button_outInXML.Size = new System.Drawing.Size(274, 63);
            this.button_outInXML.TabIndex = 29;
            this.button_outInXML.Text = "Чтение информации из XML";
            this.button_outInXML.UseVisualStyleBackColor = false;
            this.button_outInXML.Click += new System.EventHandler(this.button_outInXML_Click);
            // 
            // label_countLect
            // 
            this.label_countLect.AutoSize = true;
            this.label_countLect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_countLect.Location = new System.Drawing.Point(363, 569);
            this.label_countLect.Name = "label_countLect";
            this.label_countLect.Size = new System.Drawing.Size(18, 20);
            this.label_countLect.TabIndex = 30;
            this.label_countLect.Text = "0";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 708);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 22);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // comboBox_spec
            // 
            this.comboBox_spec.FormattingEnabled = true;
            this.comboBox_spec.Items.AddRange(new object[] {
            "ИСИТ",
            "ПОИТ",
            "ПОИБМС",
            "ДЭИВИ"});
            this.comboBox_spec.Location = new System.Drawing.Point(183, 433);
            this.comboBox_spec.Name = "comboBox_spec";
            this.comboBox_spec.Size = new System.Drawing.Size(121, 24);
            this.comboBox_spec.TabIndex = 32;
            this.comboBox_spec.Text = "ИСИТ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(152)))), ((int)(((byte)(226)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1491, 31);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поКоличествуЛекцийToolStripMenuItem,
            this.поВидуКонтроляToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поКоличествуЛекцийToolStripMenuItem
            // 
            this.поКоличествуЛекцийToolStripMenuItem.Name = "поКоличествуЛекцийToolStripMenuItem";
            this.поКоличествуЛекцийToolStripMenuItem.Size = new System.Drawing.Size(262, 28);
            this.поКоличествуЛекцийToolStripMenuItem.Text = "По количеству лекций";
            this.поКоличествуЛекцийToolStripMenuItem.Click += new System.EventHandler(this.Sort_Lect_Click);
            // 
            // поВидуКонтроляToolStripMenuItem
            // 
            this.поВидуКонтроляToolStripMenuItem.Name = "поВидуКонтроляToolStripMenuItem";
            this.поВидуКонтроляToolStripMenuItem.Size = new System.Drawing.Size(262, 28);
            this.поВидуКонтроляToolStripMenuItem.Text = "По виду контроля";
            this.поВидуКонтроляToolStripMenuItem.Click += new System.EventHandler(this.Sort_Control_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(262, 28);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.Sort_Save_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скрытьРанельИнтрументовToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(47, 27);
            this.файлToolStripMenuItem.Text = "Вид";
            // 
            // скрытьРанельИнтрументовToolStripMenuItem
            // 
            this.скрытьРанельИнтрументовToolStripMenuItem.Name = "скрытьРанельИнтрументовToolStripMenuItem";
            this.скрытьРанельИнтрументовToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.скрытьРанельИнтрументовToolStripMenuItem.Text = "Скрыть панель интрументов";
            this.скрытьРанельИнтрументовToolStripMenuItem.Click += new System.EventHandler(this.скрытьПанельИнтрументовToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.toolStripButton10,
            this.toolStripButton_undo,
            this.toolStripSeparator4,
            this.toolStripButton8,
            this.toolStripSeparator2,
            this.toolStripButtonHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1491, 27);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(92, 24);
            this.toolStripLabel2.Text = "Сортировка";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Сортировка по количеству лекций";
            this.toolStripButton1.Click += new System.EventHandler(this.Sort_Lect_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "Сортровка по виду контроля";
            this.toolStripButton2.Click += new System.EventHandler(this.Sort_Control_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "Сохранить соритровку";
            this.toolStripButton3.Click += new System.EventHandler(this.Sort_Save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(52, 24);
            this.toolStripLabel3.Text = "Поиск";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton10.Text = "toolStripButtonRedo";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripButton_undo
            // 
            this.toolStripButton_undo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_undo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_undo.Image")));
            this.toolStripButton_undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_undo.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.toolStripButton_undo.Name = "toolStripButton_undo";
            this.toolStripButton_undo.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_undo.Text = "toolStripButton11";
            this.toolStripButton_undo.Click += new System.EventHandler(this.toolStripButton_undo_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton8.Text = "Очитстить поля формы";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonHelp
            // 
            this.toolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHelp.Image")));
            this.toolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHelp.Name = "toolStripButtonHelp";
            this.toolStripButtonHelp.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonHelp.Text = "Инфо";
            this.toolStripButtonHelp.Click += new System.EventHandler(this.toolStripButtonHelp_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 807);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1491, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1491, 829);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.comboBox_spec);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_countLect);
            this.Controls.Add(this.button_outInXML);
            this.Controls.Add(this.button_inXML);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox_control);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.textBox_audience);
            this.Controls.Add(this.label_subject);
            this.Controls.Add(this.comboBox_subject);
            this.Controls.Add(this.label_audience);
            this.Controls.Add(this.label_control);
            this.Controls.Add(this.label_specialty);
            this.Controls.Add(this.label_course);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_numberLab);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_number_of_lectures);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_otchestvo);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_Lastname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_otchestvo);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numberLab)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.TextBox textBox_otchestvo;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_Lastname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_otchestvo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label_number_of_lectures;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_numberLab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_course;
        private System.Windows.Forms.Label label_specialty;
        private System.Windows.Forms.Label label_control;
        private System.Windows.Forms.Label label_audience;
        private System.Windows.Forms.ComboBox comboBox_subject;
        private System.Windows.Forms.Label label_subject;
        private System.Windows.Forms.TextBox textBox_audience;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.ComboBox comboBox_control;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_inXML;
        private System.Windows.Forms.Button button_outInXML;
        private System.Windows.Forms.Label label_countLect;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_spec;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКоличествуЛекцийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВидуКонтроляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton_undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скрытьРанельИнтрументовToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonHelp;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    }
}

