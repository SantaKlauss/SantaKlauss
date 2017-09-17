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
    public partial class frmLinq : Form
    {
        private List<Details> Uslugi;
        public frmLinq(List<Details> items)
        {
            InitializeComponent();
            Uslugi = items;
        }

        private void btnlinq_Click(object sender, EventArgs e)
        {
            if (txtlinq.Text == "") { MessageBox.Show("Введите сумму"); txtlinq.Focus(); return; }
            int sum = Convert.ToInt32(txtlinq.Text);
            var result = from u in Uslugi
                         where u.cost <= sum
                         select u;
            lstlinq.Items.Clear();
            foreach (var item in result)
            {
                lstlinq.Items.Add(item.GetService());
            }
            if (lstlinq.Items.Count == 0) { MessageBox.Show("Таких дешевых товаров нет"); txtlinq.Text = null; txtlinq.Focus(); }
        }

        private void frmLinq_Shown(object sender, EventArgs e)
        {
            txtlinq.Focus();
        }


    }
}
