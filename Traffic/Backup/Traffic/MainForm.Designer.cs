namespace Traffic
{
    partial class cMainForm
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
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.IntervalBox = new System.Windows.Forms.TextBox();
            this.PeriodBox = new System.Windows.Forms.TextBox();
            this.PeriodLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(9, 20);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(116, 13);
            this.IntervalLabel.TabIndex = 0;
            this.IntervalLabel.Text = "Интервал появления:";
            // 
            // IntervalBox
            // 
            this.IntervalBox.Location = new System.Drawing.Point(12, 36);
            this.IntervalBox.Name = "IntervalBox";
            this.IntervalBox.Size = new System.Drawing.Size(120, 20);
            this.IntervalBox.TabIndex = 1;
            this.IntervalBox.Text = "1";
            // 
            // PeriodBox
            // 
            this.PeriodBox.Location = new System.Drawing.Point(152, 36);
            this.PeriodBox.Name = "PeriodBox";
            this.PeriodBox.Size = new System.Drawing.Size(120, 20);
            this.PeriodBox.TabIndex = 3;
            this.PeriodBox.Text = "7";
            // 
            // PeriodLabel
            // 
            this.PeriodLabel.AutoSize = true;
            this.PeriodLabel.Location = new System.Drawing.Point(149, 20);
            this.PeriodLabel.Name = "PeriodLabel";
            this.PeriodLabel.Size = new System.Drawing.Size(106, 13);
            this.PeriodLabel.TabIndex = 2;
            this.PeriodLabel.Text = "Период светофора:";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 72);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(260, 24);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Начать моделирование";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // cMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 113);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PeriodBox);
            this.Controls.Add(this.PeriodLabel);
            this.Controls.Add(this.IntervalBox);
            this.Controls.Add(this.IntervalLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры движения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.TextBox IntervalBox;
        private System.Windows.Forms.TextBox PeriodBox;
        private System.Windows.Forms.Label PeriodLabel;
        private System.Windows.Forms.Button StartButton;

    }
}

