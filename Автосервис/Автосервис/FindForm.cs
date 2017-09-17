using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;using System.Text.RegularExpressions;

namespace Завод
{
    public partial class FindForm : Form
    {
        private List<Details> Uslugi;
        private List<Details> FindUslugi;
        public FindForm(List<Details> items)
        {
            InitializeComponent();
            Uslugi = items;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFind.Text == "") { MessageBox.Show("Введите искомую строку"); txtFind.Focus(); return; }
            string s = txtFind.Text;
            Regex regex = new Regex(s, RegexOptions.IgnoreCase);
            int n = 0;
            lstfind.Items.Clear();
            FindUslugi = new List<Details>();
            for (int i = 0; i < Uslugi.Count; i++)
            {
                string m = Uslugi[i].GetService();
                if (regex.IsMatch(m))
                {
                    FindUslugi.Add(Uslugi[i]);
                    lstfind.Items.Add(Uslugi[i].GetService());
                    n++;
                }
            }
            if (n == 0) { MessageBox.Show("Совпадений не найдено"); }
            n = 0;
            txtFind.Text = null;
            txtFind.Focus();
           
        }

        private void FindForm_Shown(object sender, EventArgs e)
        {
            txtFind.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (lstfind.SelectedIndex == -1)
            {
                MessageBox.Show("Товар не выбран");
                return;
            }
            frmService.Detal = FindUslugi[lstfind.SelectedIndex];
            FindUslugi.Clear();
        }

    }
}
