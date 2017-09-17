using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turism
{
    public partial class FormEdit : Form
    {
        string[] seasons = { "Пляж", "Шопинг", "Экскурсии", "Лыжи", "Ничего" };
        public FormEdit()
        {
            InitializeComponent();

            MySql.init();

            for (int i = 0; i < 12; i++)
            {
                DataGridViewComboBoxColumn theColumn = (DataGridViewComboBoxColumn)this.dataGridView1.Columns[i+2];
                foreach (string str in seasons)
                    theColumn.Items.Add(str);
               
            }

            update();
        }

        public void update()
        {
            loadCountry();
            loadTransports();
            loadTransportTarifs();
            loadDiscount();
            loadHotels();
            loadStrahov();
            loadCoefs();
        }

        public void loadCountry()
        {
            List<Country> countries = MySql.getCountries();
            MySql.getSeasons(countries);

            dataGridView1.RowCount = countries.Count;
            comboBox1.Items.Clear();

            for (int i = 0; i < countries.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = countries[i].name;
                dataGridView1.Rows[i].Cells[1].Value = countries[i].description;
                
                for (int j=0; j<12; j++)
                {
                    dataGridView1.Rows[i].Cells[j + 2].Value = seasons[countries[i].seasons[j]];
                }

                comboBox1.Items.Add(countries[i].name);
            }
        }

        public void loadTransports()
        {
            List<string> transports = MySql.getTransportName();

            dataGridView2.RowCount = transports.Count;
            comboBox2.Items.Clear();

            for (int i = 0; i < transports.Count; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = transports[i];

                comboBox2.Items.Add(transports[i]);
            }
        }

        public void loadTransportTarifs()
        {
            List<Transport> transports = MySql.getTransportTarifs();
            dataGridView3.RowCount = transports.Count;
            comboBox5.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();

            List<Country> countries = MySql.getCountries();
            DataGridViewComboBoxColumn theColumn = (DataGridViewComboBoxColumn)this.dataGridView3.Columns[2];
            foreach (Country c in countries)
            {
                theColumn.Items.Add(c.name);
                comboBox4.Items.Add(c.name);
            }

            List<string> company = MySql.getTransportName();
            theColumn = (DataGridViewComboBoxColumn)this.dataGridView3.Columns[1];
            theColumn.Items.Clear();
            foreach (string c in company)
            {
                theColumn.Items.Add(c);
                comboBox3.Items.Add(c);
            }
            
            for (int i = 0; i < transports.Count; i++)
            {
                dataGridView3.Rows[i].Cells[0].Value = transports[i].id.ToString();
                dataGridView3.Rows[i].Cells[1].Value = transports[i].companyName;

                for (int j = 0; j < countries.Count; j++)
                    if (countries[j].id == transports[i].country)
                    {
                        dataGridView3.Rows[i].Cells[2].Value = countries[j].name;
                        break;
                    }

                dataGridView3.Rows[i].Cells[3].Value = transports[i].classType;
                dataGridView3.Rows[i].Cells[4].Value = transports[i].cost.ToString();

                comboBox5.Items.Add(transports[i].id);
            }
        }

        public void loadDiscount()
        {
            List<Discount> disc = MySql.getDiscountes();

            dataGridView4.RowCount = disc.Count;
            comboBox6.Items.Clear();

            for (int i = 0; i < disc.Count; i++)
            {
                dataGridView4.Rows[i].Cells[0].Value = disc[i].name;
                dataGridView4.Rows[i].Cells[1].Value = disc[i].cost.ToString();
         
                comboBox6.Items.Add(disc[i].name);
            }
        }

        public void loadHotels()
        {
            List<Hotel> hotels = MySql.getHotels();
            dataGridView5.RowCount = hotels.Count;
            comboBox7.Items.Clear();
            comboBox8.Items.Clear();

            List<Country> countries = MySql.getCountries();
            DataGridViewComboBoxColumn theColumn = (DataGridViewComboBoxColumn)this.dataGridView5.Columns[3];
            theColumn.Items.Clear();
            foreach (Country c in countries)
            {
                theColumn.Items.Add(c.name);
                comboBox8.Items.Add(c.name);
            }

            for (int i = 0; i < hotels.Count; i++)
            {
                dataGridView5.Rows[i].Cells[0].Value = hotels[i].name;
                dataGridView5.Rows[i].Cells[1].Value = hotels[i].category.ToString();
                dataGridView5.Rows[i].Cells[2].Value = hotels[i].cost.ToString();

                for (int j = 0; j < countries.Count; j++ )
                    if (countries[j].id == hotels[i].country)
                    {
                        dataGridView5.Rows[i].Cells[3].Value = countries[j].name;
                        break;
                    }

                comboBox7.Items.Add(hotels[i].name);
            }
        }

        public void loadStrahov()
        {
            List<Strahovka> strahovka = MySql.getStrahovka();
            dataGridView7.RowCount = strahovka.Count;
            comboBox9.Items.Clear();


            for (int i = 0; i < strahovka.Count; i++)
            {
                dataGridView7.Rows[i].Cells[0].Value = strahovka[i].name;
                dataGridView7.Rows[i].Cells[1].Value = strahovka[i].cost.ToString();

                comboBox9.Items.Add(strahovka[i].name);
            }
        }

        public void loadCoefs()
        {
            List<SeasonKoefs> koefs = MySql.getSeasonsKoefs();
            dataGridView6.RowCount = koefs.Count;

            for (int i = 0; i < koefs.Count; i++)
            {
                dataGridView6.Rows[i].Cells[0].Value = koefs[i].name;
                dataGridView6.Rows[i].Cells[1].Value = koefs[i].koef.ToString();
            }
        }

        private void FormEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            MySql.close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxCountry.Text == "" || textBoxDescr.Text == "")
            {
                MessageBox.Show("Введите название и описание страны");
                return;
            }

            MySql.addCountry(textBoxCountry.Text, textBoxDescr.Text);

            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                return;
            }

            MySql.deleteCountry(comboBox1.Items[comboBox1.SelectedIndex].ToString());

            update();

            comboBox1.SelectedIndex = -1;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int[] seasonsCell = new int[12];
            for (int i = 0; i < 12; i++)
            {
                for (int j=0; j<seasons.Length; j++)
                {
                    if (seasons[j] == dataGridView1.Rows[e.RowIndex].Cells[i+2].Value.ToString())
                    {
                        seasonsCell[i] = j + 1;
                        break;
                    }
                }
                
            }
         
            MySql.editCountry(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                  dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                  seasonsCell
                                  );

            update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Введите название компании");
                return;
            }

            MySql.addTransport(textBox2.Text);

            update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                return;
            }

            MySql.deleteTransport(comboBox2.Items[comboBox2.SelectedIndex].ToString());

            update();

            comboBox2.SelectedIndex = -1;
        }

        private void dataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MySql.editTransportTarif(int.Parse(dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString()),
                dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString(),
                float.Parse(dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString()),
                dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString(),
                dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString()
                );

            update();
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MySql.editCompany(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());

            update();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == -1)
            {
                return;
            }

            MySql.deleteTransportTarif(int.Parse(comboBox5.Items[comboBox5.SelectedIndex].ToString()));

            update();

            comboBox5.SelectedIndex = -1;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySql.addTransportTarif(comboBox3.Items[comboBox3.SelectedIndex].ToString(), 
                    comboBox4.Items[comboBox4.SelectedIndex].ToString(), textBox3.Text, (int)numericUpDown1.Value);

            MessageBox.Show("Добавлено");

            update();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MySql.addDisc(textBox4.Text, (float)numericUpDown2.Value);

            MessageBox.Show("Добавлено");

            update();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == -1)
            {
                return;
            }

            MySql.deleteDisc(comboBox6.Items[comboBox6.SelectedIndex].ToString());

            update();

            comboBox6.SelectedIndex = -1;

        }

        private void dataGridView4_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MySql.editDisc(dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString(),
                        dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString());

            update();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MySql.addHotel(textBox5.Text, comboBox8.Items[comboBox8.SelectedIndex].ToString(),
                ((int)numericUpDown4.Value).ToString(), (float)numericUpDown3.Value);

            MessageBox.Show("Добавлено");
            update();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox7.SelectedIndex == -1)
            {
                return;
            }

            MySql.deleteHotel(comboBox7.Items[comboBox7.SelectedIndex].ToString());

            update();

            comboBox7.SelectedIndex = -1;
        }

        private void dataGridView5_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MySql.editHotel(dataGridView5.Rows[e.RowIndex].Cells[0].Value.ToString(),
                        dataGridView5.Rows[e.RowIndex].Cells[3].Value.ToString(),
                        dataGridView5.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        float.Parse(dataGridView5.Rows[e.RowIndex].Cells[2].Value.ToString()));

            update();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MySql.addStrahovka(textBox6.Text, (float)numericUpDown5.Value);

            MessageBox.Show("Добавлено");
            update();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox9.SelectedIndex == -1)
                return;

            MySql.deleteStrahovka(comboBox9.Items[comboBox9.SelectedIndex].ToString());

            update();

            comboBox9.SelectedIndex = -1;
        }

        private void dataGridView7_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MySql.editStrahovka(dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString(),
                        dataGridView7.Rows[e.RowIndex].Cells[1].Value.ToString());

            update();
        }

        private void dataGridView6_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MySql.editSeasonsKoefs(dataGridView6.Rows[e.RowIndex].Cells[0].Value.ToString(),
                        dataGridView6.Rows[e.RowIndex].Cells[1].Value.ToString());

            update();
        }
    }
}
