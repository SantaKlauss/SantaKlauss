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
    public partial class ClientsForm : Form
    {
        private List<Clients> ClientsItems;
        private SelectionMade Func;

        public ClientsForm(List<Clients> items, SelectionMade func)
        {
            InitializeComponent();
            ClientsItems = items;
            Func = func;
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            foreach (Clients sc in ClientsItems)
            {
                lstclients.Items.Add(sc.GetInfo());
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (lstclients.SelectedIndex == -1)
            {
                MessageBox.Show("Клиент не выбран");
                return;
            }
            Func(lstclients.SelectedItem);
            frmService.Client = ClientsItems[lstclients.SelectedIndex];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
