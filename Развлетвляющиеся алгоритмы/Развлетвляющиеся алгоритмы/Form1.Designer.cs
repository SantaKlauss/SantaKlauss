namespace Развлетвляющиеся_алгоритмы
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbBasic = new System.Windows.Forms.GroupBox();
            this.mskT = new System.Windows.Forms.MaskedTextBox();
            this.mskX = new System.Windows.Forms.MaskedTextBox();
            this.lblT = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.lblY = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.chkFormat = new System.Windows.Forms.CheckBox();
            this.btnDecide = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbBasic.SuspendLayout();
            this.grbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBasic
            // 
            this.grbBasic.Controls.Add(this.mskT);
            this.grbBasic.Controls.Add(this.mskX);
            this.grbBasic.Controls.Add(this.lblT);
            this.grbBasic.Controls.Add(this.lblX);
            this.grbBasic.Location = new System.Drawing.Point(23, 25);
            this.grbBasic.Name = "grbBasic";
            this.grbBasic.Size = new System.Drawing.Size(205, 109);
            this.grbBasic.TabIndex = 0;
            this.grbBasic.TabStop = false;
            this.grbBasic.Text = "Исходные данные";
            // 
            // mskT
            // 
            this.mskT.Location = new System.Drawing.Point(69, 58);
            this.mskT.Mask = "##.###";
            this.mskT.Name = "mskT";
            this.mskT.Size = new System.Drawing.Size(100, 20);
            this.mskT.TabIndex = 3;
            this.mskT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskT_KeyPress_1);
            // 
            // mskX
            // 
            this.mskX.Location = new System.Drawing.Point(69, 26);
            this.mskX.Mask = "##.###";
            this.mskX.Name = "mskX";
            this.mskX.Size = new System.Drawing.Size(100, 20);
            this.mskX.TabIndex = 2;
            this.mskX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskX_KeyPress_1);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(6, 61);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(55, 13);
            this.lblT.TabIndex = 1;
            this.lblT.Text = "Введите t";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(6, 29);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(57, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "Введите x";
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.txtY);
            this.grbResult.Controls.Add(this.txtP);
            this.grbResult.Controls.Add(this.txtZ);
            this.grbResult.Controls.Add(this.lblY);
            this.grbResult.Controls.Add(this.lblP);
            this.grbResult.Controls.Add(this.lblZ);
            this.grbResult.Location = new System.Drawing.Point(23, 155);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(205, 137);
            this.grbResult.TabIndex = 1;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Результат";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(24, 91);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(18, 13);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "y=";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(23, 61);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(19, 13);
            this.lblP.TabIndex = 1;
            this.lblP.Text = "p=";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(24, 35);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(18, 13);
            this.lblZ.TabIndex = 0;
            this.lblZ.Text = "z=";
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(57, 35);
            this.txtZ.Name = "txtZ";
            this.txtZ.ReadOnly = true;
            this.txtZ.Size = new System.Drawing.Size(100, 20);
            this.txtZ.TabIndex = 3;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(57, 61);
            this.txtP.Name = "txtP";
            this.txtP.ReadOnly = true;
            this.txtP.Size = new System.Drawing.Size(100, 20);
            this.txtP.TabIndex = 4;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(57, 91);
            this.txtY.Name = "txtY";
            this.txtY.ReadOnly = true;
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 5;
            // 
            // chkFormat
            // 
            this.chkFormat.AutoSize = true;
            this.chkFormat.Location = new System.Drawing.Point(263, 65);
            this.chkFormat.Name = "chkFormat";
            this.chkFormat.Size = new System.Drawing.Size(135, 17);
            this.chkFormat.TabIndex = 2;
            this.chkFormat.Text = "Результат в формате";
            this.chkFormat.UseVisualStyleBackColor = true;
            // 
            // btnDecide
            // 
            this.btnDecide.Location = new System.Drawing.Point(263, 99);
            this.btnDecide.Name = "btnDecide";
            this.btnDecide.Size = new System.Drawing.Size(167, 35);
            this.btnDecide.TabIndex = 3;
            this.btnDecide.Text = "Вычислить";
            this.btnDecide.UseVisualStyleBackColor = true;
            this.btnDecide.Click += new System.EventHandler(this.btnDecide_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(263, 155);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(167, 38);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить результат";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(263, 216);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 43);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 332);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecide);
            this.Controls.Add(this.chkFormat);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.grbBasic);
            this.Name = "Form1";
            this.Text = "Разветвляющиеся алгоритмы";
            this.Shown += new System.EventHandler(this.Form1_Shown_1);
            this.grbBasic.ResumeLayout(false);
            this.grbBasic.PerformLayout();
            this.grbResult.ResumeLayout(false);
            this.grbResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBasic;
        private System.Windows.Forms.MaskedTextBox mskT;
        private System.Windows.Forms.MaskedTextBox mskX;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.CheckBox chkFormat;
        private System.Windows.Forms.Button btnDecide;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

