namespace Gricenko07
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
            this.pctDraw = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.scrk = new System.Windows.Forms.HScrollBar();
            this.lblk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // pctDraw
            // 
            this.pctDraw.BackColor = System.Drawing.SystemColors.Control;
            this.pctDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctDraw.Location = new System.Drawing.Point(12, 12);
            this.pctDraw.Name = "pctDraw";
            this.pctDraw.Size = new System.Drawing.Size(290, 310);
            this.pctDraw.TabIndex = 0;
            this.pctDraw.TabStop = false;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(308, 136);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(165, 31);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Нарисовать";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(308, 286);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // scrk
            // 
            this.scrk.LargeChange = 1;
            this.scrk.Location = new System.Drawing.Point(311, 85);
            this.scrk.Maximum = 10;
            this.scrk.Minimum = 1;
            this.scrk.Name = "scrk";
            this.scrk.Size = new System.Drawing.Size(165, 30);
            this.scrk.TabIndex = 3;
            this.scrk.Value = 1;
            this.scrk.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrb_Scroll);
            // 
            // lblk
            // 
            this.lblk.AutoSize = true;
            this.lblk.Location = new System.Drawing.Point(378, 49);
            this.lblk.Name = "lblk";
            this.lblk.Size = new System.Drawing.Size(26, 13);
            this.lblk.TabIndex = 4;
            this.lblk.Text = "K=1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 334);
            this.Controls.Add(this.lblk);
            this.Controls.Add(this.scrk);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pctDraw);
            this.Name = "Form1";
            this.Text = "Построение графика функции";
            ((System.ComponentModel.ISupportInitialize)(this.pctDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctDraw;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.HScrollBar scrk;
        private System.Windows.Forms.Label lblk;
    }
}

