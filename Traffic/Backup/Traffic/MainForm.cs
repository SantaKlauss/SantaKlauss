using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Traffic
{
    public partial class cMainForm : Form
    {
        public cRenderForm RenderForm;
        public cMainForm()
        {
            InitializeComponent();
            RenderForm = new cRenderForm();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                RenderForm.pAddCarInterval = float.Parse(this.IntervalBox.Text);
                RenderForm.pLightTime      = float.Parse(this.PeriodBox.Text);            
            }
            catch 
            {
                MessageBox.Show("Параметры введены неверно!");
                return;
            }
            if (RenderForm.pAddCarInterval < 1) RenderForm.pAddCarInterval = 1;
            RenderForm.ShowDialog();
        }
    }
}
