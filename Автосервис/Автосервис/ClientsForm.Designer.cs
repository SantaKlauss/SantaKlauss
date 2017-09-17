namespace Завод
{
    partial class ClientsForm
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
            this.lstclients = new System.Windows.Forms.ListBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstclients
            // 
            this.lstclients.FormattingEnabled = true;
            this.lstclients.Location = new System.Drawing.Point(13, 13);
            this.lstclients.Name = "lstclients";
            this.lstclients.Size = new System.Drawing.Size(356, 225);
            this.lstclients.TabIndex = 0;
            
            // 
            // btnAddClient
            // 
            this.btnAddClient.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddClient.Location = new System.Drawing.Point(13, 251);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Выбрать";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(116, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 286);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.lstclients);
            this.Name = "ClientsForm";
            this.Text = "Выбрать клиента";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstclients;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnCancel;
    }
}