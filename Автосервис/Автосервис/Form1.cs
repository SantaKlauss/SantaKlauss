using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Завод
{
    public partial class frmService : Form
    {
        List<Clients> Clients;
        List<Details> Detail;
        List<Details> Servis = new List<Details>();

        public static Clients Client;
        public static Details Detal;

        public delegate void Info(Clients c);

        int totalcost;

        public delegate void ProvideService(Clients Client, Details Detal);
        public delegate void SeparateService();

        public frmService()
        {
            InitializeComponent();
        }

        private void frmService_Load(object sender, EventArgs e)
        {
            Clients = new List<Clients>();
            Clients.Add(new Clients("Суворов Иван Генадьевич", 01));
            Clients.Add(new Clients("Добровольцев Сергей Сергеевич", 02));
            Clients.Add(new Clients("Северухин Александр Иванович", 03));
            Clients.Add(new Clients("Мавроди Сергей Пантелеевич", 04));
            Clients.Add(new Clients("Путин Владимир Владимирович", 05));
            Clients.Add(new Clients("Медведев Дмитрий Анатольевич", 06));
            Clients.Add(new Clients("Пушкин Александр Сергеевич", 07));
            Clients.Add(new Clients("Толстой Лев Николаевич", 08));
            Clients.Add(new Clients("Гагарин Юрий Алексеевич", 09));
            Clients.Add(new Clients("Джексон Майкл Джозеф", 10));
            Clients.Add(new Clients("Линдеманн Тилль", 11));
            Clients.Add(new Clients("Круспе Цвен Рихард ", 12));
            Clients.Add(new Clients("Ландерс Пауль Хайко ", 13));
            Clients.Add(new Clients("Ридель Оливер", 14));
            Clients.Add(new Clients("Шнайдер Кристоф ", 15));
            Clients.Add(new Clients("Лоренц Кристиан ", 16));

            Detail = new List<Details>();
            Detail.Add(new Details("Амортизатор задний ИЖ", 495));
            Detail.Add(new Details("Барабан сцепления Иж-Юпиер внутренний", 170));
            Detail.Add(new Details("Набо болтов крепления крышек картера", 150));
            Detail.Add(new Details("Вал кикстартера", 235));
            Detail.Add(new Details("Вал КПП червячный с вилками Иж Юпитер", 290));
            Detail.Add(new Details("Вал промежуточный Иж голый", 200));
            Detail.Add(new Details("Втулка передней вилки Иж металлокерамика", 30));
            Detail.Add(new Details("Головка цилиндра Иж Планета-4", 550));
            Detail.Add(new Details("Дуги безопасности Иж (хромированные)", 775));
            Detail.Add(new Details("Заглушка цилиндра Планета правая", 85));
            Detail.Add(new Details("Звезда задняя Иж", 660));
            Detail.Add(new Details("Звезда Иж 13 зубов", 85));
            Detail.Add(new Details("Звезда Иж 14 зубов", 95));
            Detail.Add(new Details("Звезда Иж 15 зубов", 105));
            Detail.Add(new Details("Звезда Иж 16 зубов", 115));
            Detail.Add(new Details("Звезда Иж 17 зубов", 125));
            Detail.Add(new Details("Звезда Иж 18 зубов", 135));
            Detail.Add(new Details("Звезда Иж 19 зубов", 145));
            Detail.Add(new Details("Звезда Иж 20 зубов", 155));
            Detail.Add(new Details("Звезда Иж 21 зубов", 165));
            Detail.Add(new Details("Звезда Иж 22 зубов", 175));
            Detail.Add(new Details("Двигатель ИЖ-Планета 4", 30000));
            Detail.Add(new Details("Двигатель Днепр", 55000));
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            ClientsForm cf = new ClientsForm(Clients, new SelectionMade(this.ClientSelected));
            cf.ShowDialog();
            //Info inf = new Info(ClientSelected);
            //inf(ClientObject);
        }

        private void ClientSelected(object c)
        {
            txtClient.Text = c.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtClient.Text == "")
            {
                MessageBox.Show("Выберите клиента");
                return;
            }
            goodsForm uf = new goodsForm(Detail);
            uf.ShowDialog();
            if (uf.DialogResult == DialogResult.OK)
            {
                lstDetals.Items.Add(Detal.GetService());
                Servis.Add(Detal);
                UpdateTotalCost(Detal);
            }
        }

        private void UpdateTotalCost(Details dat)
        {
            totalcost += dat.cost;
            cost2.Text = "Итого: " + totalcost + " рублей";
        }

        public void ShowService(Clients Client, Details Detal)
        {
            MessageBox.Show("Товар " + Detal.service + " стоимостью " + Detal.cost + " рублей для клиента " + Client.FIO + " оказана в полном размере");
        }

        public void ShowServiceDiscount(Clients Client, Details Detal)
        {
            MessageBox.Show("Товар " + Detal.service + " стоимостью " + Detal.cost * 0.8 + " рублей для клиента " + Client.FIO + " оказана со скидкой в 18 %");
        }

        private void btnDelegates_Click(object sender, EventArgs e)
        {
            if (txtClient.Text == "" || lstDetals.Items.Count == 0)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            //делегаты
            ProvideService ps = new ProvideService(ShowService);
            ps += ShowServiceDiscount;
            ps += SaleService2;
            for (int i = 0; i < Servis.Count; i++ )
            {
                ps(Client, Servis[i]);
            }
        }

        private void btnLambda_Click(object sender, EventArgs e)
        {
            if (txtClient.Text == "" || lstDetals.Items.Count == 0)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            SeparateService ss;
            ss = () =>
                {
                    int mincost = Servis[0].cost;
                    for (int i = 0; i < Servis.Count; i++)
                    {
                        if (Servis[i].cost < mincost) mincost = Servis[i].cost;
                    }
                    MessageBox.Show("Самая маленькая цена в заказе: " + mincost + " рублей");
                    int maxcost = Servis[0].cost;
                    for (int i = 0; i < Servis.Count; i++)
                    {
                        if (Servis[i].cost > maxcost) maxcost = Servis[i].cost;
                    }
                    MessageBox.Show("Самая большая цена в заказе: " + maxcost + " рублей");
                };
            ss();
        }

        private void btnFindUs_Click(object sender, EventArgs e)
        {
            if (txtClient.Text == "")
            {
                MessageBox.Show("Выберите клиента");
                return;
            }
            FindForm ff = new FindForm(Detail);
            ff.ShowDialog();
            if (ff.DialogResult == DialogResult.OK)
            {
                lstDetals.Items.Add(Detal.GetService());
                Servis.Add(Detal);
                UpdateTotalCost(Detal);
            }
        }

        private void btnlinq_Click(object sender, EventArgs e)
        {
            frmLinq fl = new frmLinq(Detail);
            fl.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void SaleService1(Clients Client, Details Detal)
        {
            MessageBox.Show("Товар " + Detal.service + " стоимостью " + Detal.cost + " рублей для клиента " + Client.FIO + " оказана в полном размере");
        }
        public void SaleService2(Clients Client, Details Detal)
        {
            MessageBox.Show("Товар " + Detal.service + " стоимостью " + (Detal.cost - 250) + " рублей для клиента " + Client.FIO + " оказана со скидкой в 250 рублей");
        }

        private void btn18persent_Click(object sender, EventArgs e)
        {
            if (txtClient.Text == "" || lstDetals.Items.Count == 0)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            if (txtClient.Text == "" || lstDetals.Items.Count < 4)
            {
                MessageBox.Show("Данную скидку можно получить лишь тогда, когда количество заказанных деталей, 4 и более!!!");
            }
            if (txtClient.Text == "" || lstDetals.Items.Count >= 4)
            {
                lblTotalCost.Text = "Итого: " + totalcost + " - " + "скидка 18 % " + " = " + (totalcost * 0.82);
                lblcost.Text = "Итого к оплате : " + (totalcost * 0.82);
            }
        }

        private void btn250rubley_Click(object sender, EventArgs e)
        {
            if (txtClient.Text == "" || lstDetals.Items.Count == 0)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            if (txtClient.Text == "" || lstDetals.Items.Count < 2) 
            {
                MessageBox.Show("Данную скидку можно получить лишь тогда, когда количество заказанных деталей, 2 и более!!!");
            }
            if (txtClient.Text == "" || lstDetals.Items.Count >= 2)
            {
                lblTotalCost.Text = "Итого к оплате со скидкой : " + totalcost + " - " + "скидка 250 рублей" + " = " + (totalcost - 250);
                lblcost.Text = "Итого к оплате со скидкой : " + (totalcost - 250);
                cost2.Text = "Итого : " + totalcost;
            }
                
        }

    }
}
