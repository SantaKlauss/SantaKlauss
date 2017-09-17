using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;

namespace Turism
{
    public partial class Form1 : Form
    {
        Tours tours;

        public Form1()
        {
            InitializeComponent();
        }

        //выбор страны и сезона
        private void click(object sender, EventArgs e)
        {
            //ищем кнопку, в которую ткнул пользователь

            int x, y;       //х - сезон, у страна
            PictureBox btn = (sender as PictureBox);
            string str = (string)btn.Tag;
            string[] coords = str.Split('-');
            y = int.Parse(coords[0]);
            x = int.Parse(coords[1]);

            tours.select(x, y);
            
            label1.Text = tours.selected.name;
            label2.Text = tours.selected.name;
            label4.Text = tours.selected.name;
            label6.Text = tours.selected.name;
            label8.Text = tours.selected.name;
            tours.selected.loadTransport();

            //заполняем следующую необходимую таблицу с транспортом
            dataGridView1.RowCount = tours.selected.transport.Count;
            dataGridView1.ColumnCount = 2;
            dataGridView1.RowHeadersWidth = 160;

            dataGridView1.Columns[0].HeaderCell.Value = "Класс";
            dataGridView1.Columns[1].HeaderCell.Value = "Цена";

            for (int i = 0; i < tours.selected.transport.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = tours.selected.transport[i].company;
                dataGridView1.Rows[i].Cells[0].Value = tours.selected.transport[i].classType;
                dataGridView1.Rows[i].Cells[1].Value = tours.selected.transport[i].cost;
            }
           
            //переключаем панель на новую таблицу
            panel1.Hide();
            panel2.Show();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        //инициализация формы
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!MySql.init())   //подключаемся к бд
            {
                MessageBox.Show("Не удалось подключиться к базе данных");
                return;
            }

            tours = new Tours();    //создаем класс для туров

            tours.loadCountries();  //загружаем список стран
           
            //создаем массив кнопок с названием стран
            for (int i = 0; i < tours.counries.Count; i++)
            {
                Button b = new Button();
                b.Text = tours.counries[i].name;
                b.Width = 100;
                //Размещаем ее правее 
                b.Location = new System.Drawing.Point(20, 110 + i * 22);
                //Добавляем  кнопку на форму
                this.panel1.Controls.Add(b);
            }

            string[] months = {"январь","февраль","март","апрель","май","июнь","июль","август","сентябрь","октябрь","ноябрь","декабрь" };
            //файлы иконок
            string[] files = { "plyag.png", "shop.png", "ekskursion.png", "ligi.png", "nothing.png" };
            for (int i = 0; i < 12; i++)
            {
                Button b = new Button();
                b.Text = months[i];
                b.Width = 20;
                b.Height = 100;
                //Размещаем ее правее (на 10px) кнопки, на которую мы нажали
                b.Location = new System.Drawing.Point(120 + i * 20, 10);

                //Добавляем  кнопку на форму
                this.panel1.Controls.Add(b);
            }

            //добавление кнопок с иконками сезонов
            for (int i = 0; i < tours.counries.Count; i++)
                for (int j = 0; j < 12; j++)
                {
                    PictureBox b = new PictureBox();
                    b.Tag = i+"-"+j;

                    b.ImageLocation = files[tours.counries[i].seasons[j]];
                   
                    b.Width = 24;
                    b.Height = 18;
                    //Размещаем 
                    b.Location = new System.Drawing.Point(120 + j * 20, 112 + i * 22);

                    //Добавляем событие нажатия на новую кнопку 
                   
                    b.Click += new EventHandler(click);
                    //Добавляем  кнопку на форму
                    this.panel1.Controls.Add(b);
                }

            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //кнопка перехода на предыдущую страницу
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Show();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();

            //загрузка скидок
            tours.loadDiscounts();

            //назначаем транспорт
            label3.Text = dataGridView1.SelectedRows[0].HeaderCell.Value + " "
                    + dataGridView1.SelectedRows[0].Cells[0].Value;
            label5.Text = dataGridView1.SelectedRows[0].HeaderCell.Value + " "
                    + dataGridView1.SelectedRows[0].Cells[0].Value;
            label7.Text = dataGridView1.SelectedRows[0].HeaderCell.Value + " "
                    + dataGridView1.SelectedRows[0].Cells[0].Value;
            label9.Text = dataGridView1.SelectedRows[0].HeaderCell.Value + " "
                    + dataGridView1.SelectedRows[0].Cells[0].Value;

            //очищаем от предыдущих элементов список скидок
            checkedListBox1.Items.Clear();
            //формируем заново
            for (int i = 0; i < tours.discounts.Count; i++ )
                checkedListBox1.Items.Add(tours.discounts[i].name + " - " + tours.discounts[i].cost + "%");
        }

        //кнопка перехода на предыдущую страницу
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Show();
            panel5.Hide();
            panel6.Hide();

            tours.selected.loadHotels();    //загружаем из бд отели

            //заносим отели в бд
            dataGridView2.RowCount = tours.selected.hotels.Count;
            dataGridView2.ColumnCount = 2;
            dataGridView2.RowHeadersWidth = 160;

            dataGridView2.Columns[0].HeaderCell.Value = "Категория";
            dataGridView2.Columns[1].HeaderCell.Value = "Цена";

            for (int i = 0; i < tours.selected.hotels.Count; i++)
            {
                dataGridView2.Rows[i].HeaderCell.Value = tours.selected.hotels[i].name;

                //считаем количество звезд
                string categ = "";
                for (int j = 0; j < tours.selected.hotels[i].category; j++)
                    categ += "*";

                dataGridView2.Rows[i].Cells[0].Value = categ;
                dataGridView2.Rows[i].Cells[1].Value = tours.selected.hotels[i].cost;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //активируем кнопку
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Show();
            panel6.Hide();

            tours.loadStrahovka();  //загрузка страховки

            //загружаем ее в бд
            dataGridView3.RowCount = tours.strahovka.Count;
            dataGridView3.ColumnCount = 1;
            dataGridView3.RowHeadersWidth = 160;
                      

            dataGridView3.Columns[0].HeaderCell.Value = "Цена страховки";

            for (int i = 0; i < tours.strahovka.Count; i++)
            {
                dataGridView3.Rows[i].HeaderCell.Value = tours.strahovka[i].name;
                dataGridView3.Rows[i].Cells[0].Value = tours.strahovka[i].cost;
            }
        }

        //кнопка перехода на предыдущую страницу
        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Show();
            panel5.Hide();
            panel6.Hide();   
        }

        //кнопка перехода на последнюю страницу
        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Show();
            richTextBox1.Text = "";
        }

        //кнопка перехода на предыдущую страницу
        private void button12_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Show();
            panel6.Hide();
        }

        //кнопка перехода на первую страницу
        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        //расчет стоимости
        private void button9_Click(object sender, EventArgs e)
        {
            float summa = 0;
            string report = "";
            float cost = 0;

            //выводим отчет
            report += label1.Text + " " + tours.selected.getSeasonName( tours.season) +
                " на " + numericUpDown1.Value + " дней \n";

            report += "Транспорт: " + label3.Text + " " + dataGridView1.SelectedRows[0].Cells[0].Value  + " "
                + dataGridView1.SelectedRows[0].Cells[1].Value + "  \n";

            report += "Проживание: " + dataGridView2.SelectedRows[0].HeaderCell.Value + " " + dataGridView2.SelectedRows[0].Cells[0].Value + " "
               + dataGridView2.SelectedRows[0].Cells[1].Value + "  \n";

            report += "Страховка: " + dataGridView3.SelectedRows[0].HeaderCell.Value + " " + dataGridView3.SelectedRows[0].Cells[0].Value + " "
              + "  \n";

            int peoples = (int)numericUpDown2.Value;    //количество взрослых
            report += "Взрослых: " + peoples + "  \n";

            //для каждого взрослого считаем
            for (int i = 0; i < peoples; i++)
            {
                float s = tours.selected.getAdditionalCost() +
                    tours.strahovka[dataGridView3.SelectedRows[0].Index].cost +
                    tours.selected.transport[dataGridView1.SelectedRows[0].Index].cost * 2+
                    ((int)numericUpDown1.Value) * tours.selected.hotels[dataGridView2.SelectedRows[0].Index].cost;
                float n = 10000 + 0.3f * s;
                float kv = 0.15f * s;
                float p = kv - s - n;
                float act = tours.selected.getSeasonK(tours.season);
                float d = 0;

                //учитываем скидки
                for (int j = 1; j < checkedListBox1.Items.Count; j++)
                    if (checkedListBox1.GetItemChecked(j))
                    {
                        d += tours.discounts[j].cost;
                        report += "Скидка: " + checkedListBox1.GetItemText(checkedListBox1.Items[j]) + "\n";
                    }

                if (d > 0)
                {
                    d = s * (1 - d / 100);
                    report += "Общая скидка: " + d + "\n";
                }
                

                cost = s + n - d + kv * act;

                summa += cost;
            }
            report += "Цена за одного взрослого: " + cost;

            //для каждого ребенка считаем
            peoples = (int)numericUpDown3.Value;
            if (peoples != 0)
            {
                report += "Детей: " + peoples + "  \n";
                for (int i = 0; i < peoples; i++)
                {
                    float s = tours.selected.getAdditionalCost() +
                        tours.strahovka[dataGridView3.SelectedRows[0].Index].cost +
                        tours.selected.transport[dataGridView1.SelectedRows[0].Index].cost * 2 +
                        ((int)numericUpDown1.Value) * tours.selected.hotels[dataGridView2.SelectedRows[0].Index].cost;
                    float n = 10000 + 0.3f * s;
                    float kv = 0.15f * s;
                    float p = kv - s - n;
                    float act = tours.selected.getSeasonK(tours.season);

                    //учитываем скидки
                    float d = 0;
                    for (int j = 1; j < checkedListBox1.Items.Count; j++)
                        if (checkedListBox1.GetItemChecked(j))
                        {
                            d += tours.discounts[j].cost;
                            report += "Скидка: " + checkedListBox1.GetItemText(checkedListBox1.Items[j]) + "\n";
                        }

                    //учитываем скидку на ребенка
                    d = s*(1-(d+tours.discounts[0].cost)/100);
                    report += "Общая скидка: " + d + "\n";
                    cost = s + n - d + kv * act;

                    summa += cost;
                }
                report += "Цена за одного ребенка: " + cost;
            }
            

            report += "Полная стоимость: " + summa;

            richTextBox1.Text = report;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //сохранить отчет
            object oMissing = System.Reflection.Missing.Value;

            Word._Application oWord;    //ворд
            Word._Document oDoc;            //документ
            oWord = new Word.Application(); //запускаем

            //добавляем созданный документ в ворд
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
               ref oMissing, ref oMissing);

            //Добавляем текст 
            Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Text = richTextBox1.Text;
            oPara1.Format.SpaceAfter = 24;    //размер шрифта
            oPara1.Range.InsertParagraphAfter();

            oDoc.Save();
            oDoc.Close();
            oWord.Quit();
        }

        private void редактированиеДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
