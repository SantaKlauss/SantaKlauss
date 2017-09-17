using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            lbTime.Text = string.Empty;
            lbStat.Text = string.Empty;
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
            var sw = Stopwatch.StartNew();
            if (RenderForm.ShowDialog() == DialogResult.OK)
            {
                long time = sw.ElapsedMilliseconds / 1000;
                long min = time / 60;
                long sec = time % 60;
                lbTime.Text = "Программа работала " + min.ToString() + " мин. " + sec.ToString() + " сек.";
                lbStat.Text = "Количество машин, покинувших перекресток = " + RenderForm.CountLeaveCars.ToString();
            }
            sw.Stop();
        }
    }
}
