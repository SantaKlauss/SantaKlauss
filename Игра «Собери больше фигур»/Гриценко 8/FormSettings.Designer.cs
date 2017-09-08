namespace Гриценко_8
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRhombusBrush = new System.Windows.Forms.Button();
            this.btnRhombusPen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEllipseBrush = new System.Windows.Forms.Button();
            this.btnEllipsePen = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRhombusBrush);
            this.groupBox1.Controls.Add(this.btnRhombusPen);
            this.groupBox1.Location = new System.Drawing.Point(135, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ромб";
            // 
            // btnRhombusBrush
            // 
            this.btnRhombusBrush.Location = new System.Drawing.Point(6, 48);
            this.btnRhombusBrush.Name = "btnRhombusBrush";
            this.btnRhombusBrush.Size = new System.Drawing.Size(102, 23);
            this.btnRhombusBrush.TabIndex = 1;
            this.btnRhombusBrush.Text = "Заливка";
            this.btnRhombusBrush.UseVisualStyleBackColor = true;
            this.btnRhombusBrush.Click += new System.EventHandler(this.btnRhombusBrush_Click);
            // 
            // btnRhombusPen
            // 
            this.btnRhombusPen.Location = new System.Drawing.Point(6, 19);
            this.btnRhombusPen.Name = "btnRhombusPen";
            this.btnRhombusPen.Size = new System.Drawing.Size(102, 23);
            this.btnRhombusPen.TabIndex = 0;
            this.btnRhombusPen.Text = "Контур";
            this.btnRhombusPen.UseVisualStyleBackColor = true;
            this.btnRhombusPen.Click += new System.EventHandler(this.btnRhombusPen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEllipseBrush);
            this.groupBox2.Controls.Add(this.btnEllipsePen);
            this.groupBox2.Location = new System.Drawing.Point(135, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 86);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Элипс";
            // 
            // btnEllipseBrush
            // 
            this.btnEllipseBrush.Location = new System.Drawing.Point(6, 48);
            this.btnEllipseBrush.Name = "btnEllipseBrush";
            this.btnEllipseBrush.Size = new System.Drawing.Size(102, 23);
            this.btnEllipseBrush.TabIndex = 2;
            this.btnEllipseBrush.Text = "Заливка";
            this.btnEllipseBrush.UseVisualStyleBackColor = true;
            this.btnEllipseBrush.Click += new System.EventHandler(this.btnEllipseBrush_Click);
            // 
            // btnEllipsePen
            // 
            this.btnEllipsePen.Location = new System.Drawing.Point(6, 19);
            this.btnEllipsePen.Name = "btnEllipsePen";
            this.btnEllipsePen.Size = new System.Drawing.Size(102, 23);
            this.btnEllipsePen.TabIndex = 1;
            this.btnEllipsePen.Text = "Контур";
            this.btnEllipsePen.UseVisualStyleBackColor = true;
            this.btnEllipsePen.Click += new System.EventHandler(this.btnEllipsePen_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 150);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 37);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Закрыть";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 217);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSettings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.Shown += new System.EventHandler(this.FormSettings_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormSettings_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRhombusBrush;
        private System.Windows.Forms.Button btnRhombusPen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEllipseBrush;
        private System.Windows.Forms.Button btnEllipsePen;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}