namespace Завод
{
    partial class frmLinq
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
            this.lstlinq = new System.Windows.Forms.ListBox();
            this.btnlinq = new System.Windows.Forms.Button();
            this.txtlinq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstlinq
            // 
            this.lstlinq.FormattingEnabled = true;
            this.lstlinq.Location = new System.Drawing.Point(13, 13);
            this.lstlinq.Name = "lstlinq";
            this.lstlinq.Size = new System.Drawing.Size(354, 186);
            this.lstlinq.TabIndex = 0;
            // 
            // btnlinq
            // 
            this.btnlinq.Location = new System.Drawing.Point(13, 205);
            this.btnlinq.Name = "btnlinq";
            this.btnlinq.Size = new System.Drawing.Size(192, 38);
            this.btnlinq.TabIndex = 1;
            this.btnlinq.Text = "Вывести товары не дороже";
            this.btnlinq.UseVisualStyleBackColor = true;
            this.btnlinq.Click += new System.EventHandler(this.btnlinq_Click);
            // 
            // txtlinq
            // 
            this.txtlinq.Location = new System.Drawing.Point(211, 218);
            this.txtlinq.Name = "txtlinq";
            this.txtlinq.Size = new System.Drawing.Size(100, 20);
            this.txtlinq.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "рублей";
            // 
            // frmLinq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlinq);
            this.Controls.Add(this.btnlinq);
            this.Controls.Add(this.lstlinq);
            this.Name = "frmLinq";
            this.Text = "LINQ";
            this.Shown += new System.EventHandler(this.frmLinq_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstlinq;
        private System.Windows.Forms.Button btnlinq;
        private System.Windows.Forms.TextBox txtlinq;
        private System.Windows.Forms.Label label1;
    }
}