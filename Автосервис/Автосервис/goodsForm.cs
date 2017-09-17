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
    public partial class goodsForm : Form
    {
        private List<Details> UslugiItems;
        private List<Details> UslugiItemslinq;
        int linq = 0;
        public goodsForm(List<Details> items)
        {
            InitializeComponent();
            UslugiItems = items;
        }

        private void goodsForm_Load(object sender, EventArgs e)
        {
            foreach (Details su in UslugiItems)
            {
                lstgoods.Items.Add(su.GetService());
            }
        }

        private void btnAddUsluga_Click(object sender, EventArgs e)
        {
            
            if (lstgoods.SelectedIndex == -1)
            {
                MessageBox.Show("Услуга не выбрана");
                return;
            }
            if (linq == 0)
            {

                frmService.Detal = UslugiItems[lstgoods.SelectedIndex];
            }
            else
            {
                frmService.Detal = UslugiItemslinq[lstgoods.SelectedIndex];
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlinq_Click(object sender, EventArgs e)
        {
            linq = 1;
            UslugiItemslinq = new List<Details>();
            if (txtlinq.Text == "") { MessageBox.Show("Введите сумму"); txtlinq.Focus(); return; }
            int sum = Convert.ToInt32(txtlinq.Text);
            var result = from u in UslugiItems
                         where u.cost <= sum
                         select u;
            lstgoods.Items.Clear();
            foreach (var item in result)
            {
                UslugiItemslinq.Add(item);
                lstgoods.Items.Add(item.GetService());
            }
            if (lstgoods.Items.Count == 0) 
            { 
                MessageBox.Show("Таких услуг нет"); 
                txtlinq.Text = null; 
                txtlinq.Focus(); 
                linq = 0;
                foreach (Details item in UslugiItems)
                {
                    lstgoods.Items.Add(item.GetService());
                }
            }
            //UslugiItems.Clear();
        }
    }
}
