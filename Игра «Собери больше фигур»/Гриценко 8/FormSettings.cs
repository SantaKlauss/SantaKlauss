using System;
using System.Drawing;
using System.Windows.Forms;

namespace Гриценко_8
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        Graphics graph;

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnRhombusPen_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnRhombusPen.BackColor = colorDialog1.Color;
                DrawFigure.penRhombus.Color = colorDialog1.Color;
                FormSettings_Paint(this, null);
            }
        }

        private void btnRhombusBrush_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnRhombusBrush.BackColor = colorDialog1.Color;
                DrawFigure.brushRhombus.Color = colorDialog1.Color;
                FormSettings_Paint(this, null);
            }
        }

        private void btnEllipsePen_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnEllipsePen.BackColor = colorDialog1.Color;
                DrawFigure.penEllipse.Color = colorDialog1.Color;
                FormSettings_Paint(this, null);
            }
        }

        private void btnEllipseBrush_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnEllipseBrush.BackColor = colorDialog1.Color;
                DrawFigure.brushEllipse.Color = colorDialog1.Color;
                FormSettings_Paint(this, null);
            }
        }

        private void FormSettings_Shown(object sender, EventArgs e)
        {
            btnRhombusPen.BackColor = DrawFigure.penRhombus.Color;
            btnRhombusBrush.BackColor = DrawFigure.brushRhombus.Color;
            btnEllipsePen.BackColor = DrawFigure.penEllipse.Color;
            btnEllipseBrush.BackColor = DrawFigure.brushEllipse.Color;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            graph  = this.CreateGraphics();
        }

        private void FormSettings_Paint(object sender, PaintEventArgs e)
        {
            DrawFigure.doDrawRhombus(graph, DrawFigure.penRhombus, DrawFigure.brushRhombus, 
                50 / 10, 20, 20);
            DrawFigure.doDrawEllipse(graph, DrawFigure.penEllipse, DrawFigure.brushEllipse, 50 / 10,
                70, 20);
        }

        

        
    }
}
