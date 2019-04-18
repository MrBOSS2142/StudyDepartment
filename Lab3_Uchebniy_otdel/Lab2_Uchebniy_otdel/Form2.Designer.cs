namespace Lab2_Uchebniy_otdel
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox_Reg_ex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Find_Save = new System.Windows.Forms.ToolStripButton();
            this.richTextBox_Search = new System.Windows.Forms.RichTextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Reg_ex
            // 
            this.textBox_Reg_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Reg_ex.Location = new System.Drawing.Point(27, 74);
            this.textBox_Reg_ex.Multiline = true;
            this.textBox_Reg_ex.Name = "textBox_Reg_ex";
            this.textBox_Reg_ex.Size = new System.Drawing.Size(488, 34);
            this.textBox_Reg_ex.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите запрос";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 132);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(169, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По фамилии лектора";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(242, 132);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(151, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "По специальности";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(437, 132);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 21);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "По курсу";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Find_Save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(681, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Find_Save
            // 
            this.toolStripButton_Find_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Find_Save.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Find_Save.Image")));
            this.toolStripButton_Find_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Find_Save.Name = "toolStripButton_Find_Save";
            this.toolStripButton_Find_Save.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_Find_Save.Text = "toolStripButton1";
            this.toolStripButton_Find_Save.Click += new System.EventHandler(this.toolStripButton_Find_Save_Click);
            // 
            // richTextBox_Search
            // 
            this.richTextBox_Search.Location = new System.Drawing.Point(27, 186);
            this.richTextBox_Search.Name = "richTextBox_Search";
            this.richTextBox_Search.Size = new System.Drawing.Size(497, 238);
            this.richTextBox_Search.TabIndex = 6;
            this.richTextBox_Search.Text = "";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(27, 440);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(169, 49);
            this.button_search.TabIndex = 9;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 515);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.richTextBox_Search);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Reg_ex);
            this.Name = "Form2";
            this.Text = "Form2";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Reg_ex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Find_Save;
        private System.Windows.Forms.RichTextBox richTextBox_Search;
        private System.Windows.Forms.Button button_search;
    }
}