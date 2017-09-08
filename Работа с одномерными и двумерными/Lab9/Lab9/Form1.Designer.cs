namespace Lab9
{
    partial class Form1
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
            this.mnuTask = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTask1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTask2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTask3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArray = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.grbBasic = new System.Windows.Forms.GroupBox();
            this.grvBasic = new System.Windows.Forms.DataGridView();
            this.grbTask1 = new System.Windows.Forms.GroupBox();
            this.lblEnter1 = new System.Windows.Forms.Label();
            this.btnTask1 = new System.Windows.Forms.Button();
            this.grvTask1 = new System.Windows.Forms.DataGridView();
            this.txtTask1 = new System.Windows.Forms.TextBox();
            this.grbTask2 = new System.Windows.Forms.GroupBox();
            this.btnTask2 = new System.Windows.Forms.Button();
            this.grvTask2 = new System.Windows.Forms.DataGridView();
            this.lblTask1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTask2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            this.grbBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBasic)).BeginInit();
            this.grbTask1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTask1)).BeginInit();
            this.grbTask2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTask2)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTask,
            this.mnuArray,
            this.mnuExit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(435, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuTask
            // 
            this.mnuTask.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTask1,
            this.mnuTask2,
            this.mnuTask3});
            this.mnuTask.Name = "mnuTask";
            this.mnuTask.Size = new System.Drawing.Size(58, 20);
            this.mnuTask.Text = "Задачи";
            // 
            // mnuTask1
            // 
            this.mnuTask1.Name = "mnuTask1";
            this.mnuTask1.Size = new System.Drawing.Size(152, 22);
            this.mnuTask1.Text = "Задача 1";
            this.mnuTask1.Click += new System.EventHandler(this.mnuTask1_Click);
            // 
            // mnuTask2
            // 
            this.mnuTask2.Name = "mnuTask2";
            this.mnuTask2.Size = new System.Drawing.Size(152, 22);
            this.mnuTask2.Text = "Задача 2";
            this.mnuTask2.Click += new System.EventHandler(this.mnuTask2_Click);
            // 
            // mnuTask3
            // 
            this.mnuTask3.Name = "mnuTask3";
            this.mnuTask3.Size = new System.Drawing.Size(152, 22);
            this.mnuTask3.Text = "Задача 3";
            this.mnuTask3.Click += new System.EventHandler(this.mnuTask3_Click);
            // 
            // mnuArray
            // 
            this.mnuArray.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.mnuOpen});
            this.mnuArray.Name = "mnuArray";
            this.mnuArray.Size = new System.Drawing.Size(61, 20);
            this.mnuArray.Text = "Массив";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(152, 22);
            this.mnuSave.Text = "Сохранить";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(152, 22);
            this.mnuOpen.Text = "Открыть";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(53, 20);
            this.mnuExit.Text = "Выход";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(22, 34);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(168, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Введите количество элементов";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(196, 31);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 2;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(324, 28);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "OK";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // grbBasic
            // 
            this.grbBasic.Controls.Add(this.grvBasic);
            this.grbBasic.Location = new System.Drawing.Point(25, 57);
            this.grbBasic.Name = "grbBasic";
            this.grbBasic.Size = new System.Drawing.Size(389, 138);
            this.grbBasic.TabIndex = 4;
            this.grbBasic.TabStop = false;
            this.grbBasic.Text = "Исходный массив";
            // 
            // grvBasic
            // 
            this.grvBasic.AllowUserToAddRows = false;
            this.grvBasic.AllowUserToDeleteRows = false;
            this.grvBasic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBasic.Location = new System.Drawing.Point(20, 42);
            this.grvBasic.Name = "grvBasic";
            this.grvBasic.ReadOnly = true;
            this.grvBasic.Size = new System.Drawing.Size(354, 72);
            this.grvBasic.TabIndex = 0;
            // 
            // grbTask1
            // 
            this.grbTask1.Controls.Add(this.label1);
            this.grbTask1.Controls.Add(this.lblTask1);
            this.grbTask1.Controls.Add(this.lblEnter1);
            this.grbTask1.Controls.Add(this.btnTask1);
            this.grbTask1.Controls.Add(this.grvTask1);
            this.grbTask1.Controls.Add(this.txtTask1);
            this.grbTask1.Location = new System.Drawing.Point(25, 201);
            this.grbTask1.Name = "grbTask1";
            this.grbTask1.Size = new System.Drawing.Size(389, 163);
            this.grbTask1.TabIndex = 5;
            this.grbTask1.TabStop = false;
            this.grbTask1.Text = "Задача1";
            this.grbTask1.Visible = false;
            // 
            // lblEnter1
            // 
            this.lblEnter1.AutoSize = true;
            this.lblEnter1.Location = new System.Drawing.Point(20, 126);
            this.lblEnter1.Name = "lblEnter1";
            this.lblEnter1.Size = new System.Drawing.Size(81, 13);
            this.lblEnter1.TabIndex = 9;
            this.lblEnter1.Text = "Введите число";
            // 
            // btnTask1
            // 
            this.btnTask1.Location = new System.Drawing.Point(247, 120);
            this.btnTask1.Name = "btnTask1";
            this.btnTask1.Size = new System.Drawing.Size(66, 23);
            this.btnTask1.TabIndex = 8;
            this.btnTask1.Text = "OK";
            this.btnTask1.UseVisualStyleBackColor = true;
            this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);
            // 
            // grvTask1
            // 
            this.grvTask1.AllowUserToAddRows = false;
            this.grvTask1.AllowUserToDeleteRows = false;
            this.grvTask1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTask1.Location = new System.Drawing.Point(20, 45);
            this.grvTask1.Name = "grvTask1";
            this.grvTask1.ReadOnly = true;
            this.grvTask1.Size = new System.Drawing.Size(354, 72);
            this.grvTask1.TabIndex = 0;
            // 
            // txtTask1
            // 
            this.txtTask1.Location = new System.Drawing.Point(119, 123);
            this.txtTask1.Name = "txtTask1";
            this.txtTask1.Size = new System.Drawing.Size(100, 20);
            this.txtTask1.TabIndex = 7;
            // 
            // grbTask2
            // 
            this.grbTask2.Controls.Add(this.label2);
            this.grbTask2.Controls.Add(this.lblTask2);
            this.grbTask2.Controls.Add(this.btnTask2);
            this.grbTask2.Controls.Add(this.grvTask2);
            this.grbTask2.Location = new System.Drawing.Point(25, 370);
            this.grbTask2.Name = "grbTask2";
            this.grbTask2.Size = new System.Drawing.Size(389, 171);
            this.grbTask2.TabIndex = 6;
            this.grbTask2.TabStop = false;
            this.grbTask2.Text = "Задача2";
            this.grbTask2.Visible = false;
            // 
            // btnTask2
            // 
            this.btnTask2.Location = new System.Drawing.Point(246, 137);
            this.btnTask2.Name = "btnTask2";
            this.btnTask2.Size = new System.Drawing.Size(66, 23);
            this.btnTask2.TabIndex = 8;
            this.btnTask2.Text = "OK";
            this.btnTask2.UseVisualStyleBackColor = true;
            this.btnTask2.Click += new System.EventHandler(this.btnTask2_Click);
            // 
            // grvTask2
            // 
            this.grvTask2.AllowUserToAddRows = false;
            this.grvTask2.AllowUserToDeleteRows = false;
            this.grvTask2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTask2.Location = new System.Drawing.Point(17, 59);
            this.grvTask2.Name = "grvTask2";
            this.grvTask2.ReadOnly = true;
            this.grvTask2.Size = new System.Drawing.Size(354, 72);
            this.grvTask2.TabIndex = 0;
            // 
            // lblTask1
            // 
            this.lblTask1.AutoSize = true;
            this.lblTask1.Location = new System.Drawing.Point(17, 16);
            this.lblTask1.Name = "lblTask1";
            this.lblTask1.Size = new System.Drawing.Size(332, 13);
            this.lblTask1.TabIndex = 10;
            this.lblTask1.Text = "Положительные элементы массива, кратные заданному числу ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "переставить в начало массива";
            // 
            // lblTask2
            // 
            this.lblTask2.AutoSize = true;
            this.lblTask2.Location = new System.Drawing.Point(20, 16);
            this.lblTask2.Name = "lblTask2";
            this.lblTask2.Size = new System.Drawing.Size(351, 13);
            this.lblTask2.TabIndex = 9;
            this.lblTask2.Text = "Вставить число, равное минимальному положительному элементу,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = " перед и после минимального элемента.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 568);
            this.Controls.Add(this.grbTask2);
            this.Controls.Add(this.grbTask1);
            this.Controls.Add(this.grbBasic);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "Form1";
            this.Text = "Работа с массивами, Гриценко";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.grbBasic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvBasic)).EndInit();
            this.grbTask1.ResumeLayout(false);
            this.grbTask1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTask1)).EndInit();
            this.grbTask2.ResumeLayout(false);
            this.grbTask2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTask2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuTask;
        private System.Windows.Forms.ToolStripMenuItem mnuTask1;
        private System.Windows.Forms.ToolStripMenuItem mnuTask2;
        private System.Windows.Forms.ToolStripMenuItem mnuTask3;
        private System.Windows.Forms.ToolStripMenuItem mnuArray;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.GroupBox grbBasic;
        private System.Windows.Forms.DataGridView grvBasic;
        private System.Windows.Forms.GroupBox grbTask1;
        private System.Windows.Forms.Label lblEnter1;
        private System.Windows.Forms.Button btnTask1;
        private System.Windows.Forms.DataGridView grvTask1;
        private System.Windows.Forms.TextBox txtTask1;
        private System.Windows.Forms.GroupBox grbTask2;
        private System.Windows.Forms.Button btnTask2;
        private System.Windows.Forms.DataGridView grvTask2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTask1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTask2;
    }
}

