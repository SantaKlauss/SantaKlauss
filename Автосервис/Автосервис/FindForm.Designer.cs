namespace Завод
{
    partial class FindForm
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
            this.btnFind = new System.Windows.Forms.Button();
            this.lstfind = new System.Windows.Forms.ListBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.lblfind = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(259, 230);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(107, 29);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Искать товары";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lstfind
            // 
            this.lstfind.FormattingEnabled = true;
            this.lstfind.Location = new System.Drawing.Point(12, 25);
            this.lstfind.Name = "lstfind";
            this.lstfind.Size = new System.Drawing.Size(354, 199);
            this.lstfind.TabIndex = 1;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(12, 235);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(231, 20);
            this.txtFind.TabIndex = 2;
            // 
            // lblfind
            // 
            this.lblfind.AutoSize = true;
            this.lblfind.Location = new System.Drawing.Point(12, 9);
            this.lblfind.Name = "lblfind";
            this.lblfind.Size = new System.Drawing.Size(206, 13);
            this.lblfind.TabIndex = 3;
            this.lblfind.Text = "Найденные по вашему запросу товары";
            // 
            // btnadd
            // 
            this.btnadd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnadd.Location = new System.Drawing.Point(259, 267);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(107, 30);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Добавить";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 309);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblfind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lstfind);
            this.Controls.Add(this.btnFind);
            this.Name = "FindForm";
            this.Text = "Поиск товара";
            this.Shown += new System.EventHandler(this.FindForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ListBox lstfind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label lblfind;
        private System.Windows.Forms.Button btnadd;
    }
}