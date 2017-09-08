namespace Lab9
{
    partial class Form2
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.grbBasic1 = new System.Windows.Forms.GroupBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTask3 = new System.Windows.Forms.GroupBox();
            this.btnTask3 = new System.Windows.Forms.Button();
            this.grvTask3 = new System.Windows.Forms.DataGridView();
            this.mnuMain.SuspendLayout();
            this.grbBasic1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            this.grbTask3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTask3)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu,
            this.mnu3});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(430, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnu
            // 
            this.mnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.mnuOpen});
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(61, 20);
            this.mnu.Text = "Массив";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(132, 22);
            this.mnuSave.Text = "Сохранить";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(132, 22);
            this.mnuOpen.Text = "Открыть";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnu3
            // 
            this.mnu3.Name = "mnu3";
            this.mnu3.Size = new System.Drawing.Size(66, 20);
            this.mnu3.Text = "Задача 3";
            this.mnu3.Click += new System.EventHandler(this.mnu3_Click);
            // 
            // grbBasic1
            // 
            this.grbBasic1.Controls.Add(this.txt2);
            this.grbBasic1.Controls.Add(this.txt1);
            this.grbBasic1.Controls.Add(this.label2);
            this.grbBasic1.Controls.Add(this.button1);
            this.grbBasic1.Controls.Add(this.grv);
            this.grbBasic1.Controls.Add(this.label1);
            this.grbBasic1.Location = new System.Drawing.Point(12, 27);
            this.grbBasic1.Name = "grbBasic1";
            this.grbBasic1.Size = new System.Drawing.Size(389, 174);
            this.grbBasic1.TabIndex = 6;
            this.grbBasic1.TabStop = false;
            this.grbBasic1.Text = "Исходный двуменрный массив";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(166, 23);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(71, 20);
            this.txt2.TabIndex = 12;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(71, 23);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(71, 20);
            this.txt1.TabIndex = 11;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grv
            // 
            this.grv.AllowUserToAddRows = false;
            this.grv.AllowUserToDeleteRows = false;
            this.grv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv.Location = new System.Drawing.Point(22, 49);
            this.grv.Name = "grv";
            this.grv.ReadOnly = true;
            this.grv.Size = new System.Drawing.Size(354, 110);
            this.grv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Массив";
            // 
            // grbTask3
            // 
            this.grbTask3.Controls.Add(this.btnTask3);
            this.grbTask3.Controls.Add(this.grvTask3);
            this.grbTask3.Location = new System.Drawing.Point(12, 207);
            this.grbTask3.Name = "grbTask3";
            this.grbTask3.Size = new System.Drawing.Size(389, 201);
            this.grbTask3.TabIndex = 7;
            this.grbTask3.TabStop = false;
            this.grbTask3.Text = "Задача3";
            this.grbTask3.Visible = false;
            // 
            // btnTask3
            // 
            this.btnTask3.Location = new System.Drawing.Point(245, 160);
            this.btnTask3.Name = "btnTask3";
            this.btnTask3.Size = new System.Drawing.Size(66, 23);
            this.btnTask3.TabIndex = 8;
            this.btnTask3.Text = "OK";
            this.btnTask3.UseVisualStyleBackColor = true;
            this.btnTask3.Click += new System.EventHandler(this.btnTask3_Click);
            // 
            // grvTask3
            // 
            this.grvTask3.AllowUserToAddRows = false;
            this.grvTask3.AllowUserToDeleteRows = false;
            this.grvTask3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTask3.Location = new System.Drawing.Point(20, 42);
            this.grvTask3.Name = "grvTask3";
            this.grvTask3.ReadOnly = true;
            this.grvTask3.Size = new System.Drawing.Size(354, 112);
            this.grvTask3.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 433);
            this.Controls.Add(this.grbTask3);
            this.Controls.Add(this.grbBasic1);
            this.Controls.Add(this.mnuMain);
            this.Name = "Form2";
            this.Text = "Form2";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.grbBasic1.ResumeLayout(false);
            this.grbBasic1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            this.grbTask3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvTask3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnu;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnu3;
        private System.Windows.Forms.GroupBox grbBasic1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbTask3;
        private System.Windows.Forms.Button btnTask3;
        private System.Windows.Forms.DataGridView grvTask3;
    }
}