namespace Завод
{
    partial class goodsForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddUsluga = new System.Windows.Forms.Button();
            this.lstgoods = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlinq = new System.Windows.Forms.TextBox();
            this.btnlinq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(115, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddUsluga
            // 
            this.btnAddUsluga.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddUsluga.Location = new System.Drawing.Point(12, 243);
            this.btnAddUsluga.Name = "btnAddUsluga";
            this.btnAddUsluga.Size = new System.Drawing.Size(97, 30);
            this.btnAddUsluga.TabIndex = 4;
            this.btnAddUsluga.Text = "Выбрать";
            this.btnAddUsluga.UseVisualStyleBackColor = true;
            this.btnAddUsluga.Click += new System.EventHandler(this.btnAddUsluga_Click);
            // 
            // lstgoods
            // 
            this.lstgoods.FormattingEnabled = true;
            this.lstgoods.Location = new System.Drawing.Point(12, 12);
            this.lstgoods.Name = "lstgoods";
            this.lstgoods.Size = new System.Drawing.Size(356, 225);
            this.lstgoods.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "рублей";
            // 
            // txtlinq
            // 
            this.txtlinq.Location = new System.Drawing.Point(220, 290);
            this.txtlinq.Name = "txtlinq";
            this.txtlinq.Size = new System.Drawing.Size(100, 20);
            this.txtlinq.TabIndex = 6;
            // 
            // btnlinq
            // 
            this.btnlinq.Location = new System.Drawing.Point(12, 279);
            this.btnlinq.Name = "btnlinq";
            this.btnlinq.Size = new System.Drawing.Size(202, 32);
            this.btnlinq.TabIndex = 5;
            this.btnlinq.Text = "Вывести товары не дороже";
            this.btnlinq.UseVisualStyleBackColor = true;
            this.btnlinq.Click += new System.EventHandler(this.btnlinq_Click);
            // 
            // goodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlinq);
            this.Controls.Add(this.btnlinq);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddUsluga);
            this.Controls.Add(this.lstgoods);
            this.Name = "goodsForm";
            this.Text = "Выбрать товар";
            this.Load += new System.EventHandler(this.goodsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddUsluga;
        private System.Windows.Forms.ListBox lstgoods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlinq;
        private System.Windows.Forms.Button btnlinq;
    }
}