using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Lab2_Uchebniy_otdel
{
    public partial class Form1 : Form
    {
       public Form1()
        { 
            InitializeComponent();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            this.textBox_name.Tag = false;
            this.textBox_lastname.Tag = false;
            this.textBox_otchestvo.Tag = false;
            this.textBox_audience.Tag = false;
            this.comboBox_subject.Tag = false;
            this.numericUpDown_numberLab.Tag = false;
            this.comboBox_control.Tag = false;
            this.dateTimePicker1.Tag = false;
            this.button_inXML.Enabled = false;
            this.textBox_name.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_FI_Validating); //отложенное событие валидации
            this.textBox_lastname.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_FI_Validating);
            this.textBox_otchestvo.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Otchestvo_Validating);
            this.textBox_audience.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Aud_Validating);
        }

        private void textBox_FI_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = System.Drawing.SystemColors.Window;
            tb.Tag = true;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                Regex reg1 = new Regex("[A-ZА-Я]{1}[a-zа-я]+");
                Match match = reg1.Match(tb.Text);
                if (!match.Success)
                {
                    tb.Tag = false;
                    tb.BackColor = Color.Red;
                }
                else
                {
                    tb.Tag = true;
                    tb.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            ValidateOK();
        }

        private void textBox_Otchestvo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            textBox_otchestvo.BackColor = System.Drawing.SystemColors.Window;
            textBox_otchestvo.Tag = true;
            if (textBox_otchestvo.Text.Length == 0)
            {
                textBox_otchestvo.BackColor = Color.Red;
                textBox_otchestvo.Tag = false;
            }
            else
            {
                Regex reg = new Regex("[A-ZА-Я]{1}[a-zа-я]+(вич)|(вна)$");
                Match match = reg.Match(textBox_otchestvo.Text);
                if (!match.Success)
                {
                    textBox_otchestvo.Tag = false;
                    textBox_otchestvo.BackColor = Color.Red;
                }
                else
                {
                    textBox_otchestvo.Tag = true;
                    textBox_otchestvo.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            ValidateOK();
        }

        private void textBox_Aud_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            textBox_audience.BackColor = System.Drawing.SystemColors.Window;
            textBox_audience.Tag = true;
            if (textBox_audience.Text.Length == 0)
            {
                textBox_audience.BackColor = Color.Red;
                textBox_audience.Tag = false;
            }
            else
            {
                Regex reg1 = new Regex("[1-9]{3}-[1-9]{1}[а-я]{0,1}");
                Match match = reg1.Match(textBox_audience.Text);
                if (!match.Success)
                {
                    textBox_audience.Tag = false;
                    textBox_audience.BackColor = Color.Red;
                }
                else
                {
                    textBox_audience.Tag = true;
                    textBox_audience.BackColor = System.Drawing.SystemColors.Window;
                }
            }

            ValidateOK();

        }

        public void textBox_NotNumber_KeyPress(object sender, KeyPressEventArgs e) // запрет на ввод цифр в конкретные текстовые поля
        {
            if (Char.IsDigit(e.KeyChar)) // IsDigit - относится ли символ к десятичным цфирам 
            {
                e.Handled = true;
            }
        }

        private void ValidateOK()
        { // Активизирует кнопку ОК, если значения всех свойств Tags — true.
            this.button_inXML.Enabled = ((bool)(this.textBox_name.Tag) &&
            (bool)(this.textBox_lastname.Tag) &&
            (bool)(this.textBox_otchestvo.Tag) &&
            (bool)(this.textBox_audience.Tag));
        }

        [Serializable]
        public class Subject
        {
            public Lector lector { get; set; }
            public string subject { get; set; }
            public int cource { get; set; }
            public string specialty { get; set; }
            public int numberLect { get; set; }
            public int numberLab { get; set; }
            public string control { get; set; }
            public string date { get; set; }
        }

   

        List<Subject> sub = new List<Subject>();
        List<Lector> lect = new List<Lector>();

        int num = 0;

        private void Click_inXML(object sender, EventArgs e)
        {
            List<ValidationResult> error = new List<ValidationResult>();

            int kurs = 0;
            if (radioButton1.Checked)
                kurs = 1;
            else
            if (radioButton2.Checked)
                kurs = 2;
            else
            if (radioButton3.Checked)
                kurs = 2;
            else
            if (radioButton4.Checked)
                kurs = 3;

            try
            {
                lect.Add(new Lector
                {
                    lastname = textBox_lastname.Text,
                    name = textBox_name.Text,
                    otchestvo = textBox_otchestvo.Text,
                    audience = textBox_audience.Text
                });


                sub.Add(new Subject
                {
                    lector = lect[num],
                    subject = comboBox_subject.Text,
                    numberLect = int.Parse(label_countLect.Text),
                    numberLab = int.Parse(numericUpDown_numberLab.Text),
                    cource = kurs,
                    specialty = comboBox_spec.Text,
                    control = comboBox_control.Text,
                    date = dateTimePicker1.Text
                });
                num++;

                File.Delete("Lector.xml");
                using (FileStream fs = new FileStream("Lector.xml", FileMode.Create))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Subject>));
                    xml.Serialize(fs, sub);
                    fs.Close();
                }
                MessageBox.Show("Запись в XML произведена!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_countLect.Text = (trackBar1.Value).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_outInXML_Click(object sender, EventArgs e)
        {
            try
            {
                lect.Clear();
                sub.Clear();
                richTextBox1.Clear();
                num = 0;
                List<Subject> subj = new List<Subject>();
                if (File.Exists("Lector.xml"))
                {
                    using (FileStream fs = new FileStream("Lector.xml", FileMode.Open))
                    {
                        XmlSerializer xs = new XmlSerializer(typeof(List<Subject>));
                        subj = (List<Subject>)xs.Deserialize(fs);
                        fs.Close();
                    }

                    foreach (Subject sb in subj)
                    {
                        richTextBox1.Text += "\r\n" + "Фамилия: " + sb.lector.lastname + "\r\n"
                            + "Имя: "+ sb.lector.name + "\r\n"
                            + "Отчество: " + sb.lector.otchestvo + "\r\n"
                            + "Аудитория: " + sb.lector.audience + "\r\n"
                            + "Предмет: " + sb.subject + "\r\n"
                            + "Курс: " + sb.cource + "\r\n"
                            + "Специальность: " + sb.specialty + "\r\n"
                            + "Количество лекций: " + sb.numberLect + "\r\n"
                            + "Количество лабороторных работ: " + sb.numberLab + "\r\n"
                            + "Вид контроля: " + sb.control + "\r\n"
                            + "Дата: " + sb.date + "\r\n";
                    }
                    MessageBox.Show("Вывод из XML файла!");

                    foreach(Subject sb in subj)
                    {
                        lect.Add(new Lector
                        {
                            lastname = sb.lector.lastname,
                            name = sb.lector.name,
                            otchestvo = sb.lector.otchestvo,
                            audience = sb.lector.audience
                        });


                        sub.Add(new Subject
                        {
                            lector = lect[num],
                            subject = sb.subject,
                            numberLect = sb.numberLect,
                            numberLab = sb.numberLab,
                            cource = sb.cource,
                            specialty = sb.specialty,
                            control = sb.control,
                            date = sb.date
                        });
                        num++;
                    }
                }
                else
                    MessageBox.Show("Файла не существует");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Help()
        {
            MessageBox.Show("Версия 1.0" + "\r\n" + "Сухаревич Сергей Леонидович");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButtonHelp_Click(object sender, EventArgs e)
        {
            Help();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            textBox_audience.Clear();
            textBox_lastname.Clear();
            textBox_name.Clear();
            textBox_otchestvo.Clear();
        }


        private void скрытьПанельИнтрументовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStrip1.Visible == true)
            {
                toolStrip1.Visible = false;
                скрытьРанельИнтрументовToolStripMenuItem.Checked = true;
            }
            else
            {
                toolStrip1.Visible = true;
                скрытьРанельИнтрументовToolStripMenuItem.Checked = false;
            }

        }

        List<string> undo = new List<string>();
        List<string> redo = new List<string>();
        TextBox box = null;

        List<TextBox> text_box = new List<TextBox>();

        private void textBoxTextChanged(object sender, EventArgs e)
        {
            box = (TextBox)sender;
            text_box.Add(box);
            undo.Add(box.Text);
        }

        int cn = 0;

        private void toolStripButton_undo_Click(object sender, EventArgs e)
        {
            cn = undo.Count() - 1;
            if (box.Text != "")
            {
                if (cn > 0)
                {
                    redo.Add(text_box[cn].Text);
                    text_box[cn].Text = undo[cn - 1];
                    undo.RemoveAt(cn);
                    if (cn != -1)
                        undo.RemoveAt(cn);
                }
                else
                {
                    redo.Add(text_box[cn].Text);
                    cn = 0;
                    text_box[cn].Clear();
                }
                //richTextBox1.Text = cn.ToString();
                //SendKeys.Send("^z");
            }
        }

        int cr = 0;

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            cr = redo.Count() - 1;
            if (cr>=0)
            {
                text_box[cr].Text = redo[cr];
                redo.RemoveAt(cr);
            }
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form_2 = new Form2();
            form_2.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        IEnumerable<Subject> sort;
        private void Sort_Lect_Click(object sender, EventArgs e)// сортировка по количеству лекций
        {
            int n = 1;
            richTextBox1.Clear();
            sort = sub.OrderBy(s => s.numberLect);

            foreach (Subject sb in sort)
            {
                richTextBox1.Text += "\r\n" + "Фамилия: " + sb.lector.lastname + "\r\n"
                                        + "Имя: " + sb.lector.name + "\r\n"
                                        + "Отчество: " + sb.lector.otchestvo + "\r\n"
                                        + "Аудитория: " + sb.lector.audience + "\r\n"
                                        + "Предмет: " + sb.subject + "\r\n"
                                        + "Курс: " + sb.cource + "\r\n"
                                        + "Специальность: " + sb.specialty + "\r\n"
                                        + "Количество лекций: " + sb.numberLect + "\r\n"
                                        + "Количество лабороторных работ: " + sb.numberLab + "\r\n"
                                        + "Вид контроля: " + sb.control + "\r\n"
                                        + "Дата: " + sb.date + "\r\n";
                if (sub.Count() != 1)
                {
                    sub.RemoveAt(sub.Count() - n);
                    n++;
                }
                else
                    sub.RemoveAt(sub.Count());
                sub.Add(sb);
            }
        }

        private void Sort_Control_Click(object sender, EventArgs e)// сортирока по виду контроля
        {
            int n = 1;
            richTextBox1.Clear();
            sort = sub.OrderBy(s => s.control);
            foreach (Subject sb in sort)
            {
                richTextBox1.Text += "\r\n" + "Фамилия: " + sb.lector.lastname + "\r\n"
                                        + "Имя: " + sb.lector.name + "\r\n"
                                        + "Отчество: " + sb.lector.otchestvo + "\r\n"
                                        + "Аудитория: " + sb.lector.audience + "\r\n"
                                        + "Предмет: " + sb.subject + "\r\n"
                                        + "Курс: " + sb.cource + "\r\n"
                                        + "Специальность: " + sb.specialty + "\r\n"
                                        + "Количество лекций: " + sb.numberLect + "\r\n"
                                        + "Количество лабороторных работ: " + sb.numberLab + "\r\n"
                                        + "Вид контроля: " + sb.control + "\r\n"
                                        + "Дата: " + sb.date + "\r\n";
                if (sub.Count() != 1)
                {
                    sub.RemoveAt(sub.Count() - n);
                    n++;
                }
                else
                    sub.RemoveAt(sub.Count());
                sub.Add(sb);
            }
        }

        private void Sort_Save_Click(object sender, EventArgs e)
        {
            using (FileStream f = new FileStream("Sort.xml", FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Subject>));
                xml.Serialize(f, sub);
                f.Close();
                MessageBox.Show("Данные сортировки сохранены");
            }
        }
    }
}

