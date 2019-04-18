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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
        Form1 form_1 = new Form1();
        int num = 0;
        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox_Search.Clear();
                lect.Clear();
                sub.Clear();
                richTextBox_Search.Clear();
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

                    string q = "";
                    if (textBox_Reg_ex.Text != "")
                    {
                        foreach (Subject sb in subj)
                        {
                            if (radioButton1.Checked)
                                q = sb.lector.lastname;
                            else
                                if (radioButton2.Checked)
                                q = sb.specialty;
                            else
                                if (radioButton3.Checked)
                                q = sb.cource.ToString();
                            string pattern = textBox_Reg_ex.Text;
                            Regex regex = new Regex(pattern);
                            Match match = regex.Match(q);
                            if (match.Success)
                            {
                                richTextBox_Search.Text += "\r\n" + "Фамилия: " + sb.lector.lastname + "\r\n"
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
                        if (richTextBox_Search.Text == "")
                            MessageBox.Show("Извините, ничего не найдено!");
                    }
                    else
                        MessageBox.Show("Поля поиска пусты!!!");
                }
                else
                    MessageBox.Show("Файла не существует");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton_Find_Save_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("Save.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Subject>));
                xml.Serialize(fs, sub);
                fs.Close();
                MessageBox.Show("Данные поиска сохранены");
            }
        }
    }
}
