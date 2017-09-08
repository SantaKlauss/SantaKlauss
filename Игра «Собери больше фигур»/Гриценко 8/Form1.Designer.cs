namespace Гриценко_8
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
            this.components = new System.ComponentModel.Container();
            this.pctField = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEllipsePC = new System.Windows.Forms.Label();
            this.lblRhombusPC = new System.Windows.Forms.Label();
            this.pctUser = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEllipseUser = new System.Windows.Forms.Label();
            this.lblRhombusUser = new System.Windows.Forms.Label();
            this.pctPC = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnShow = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pctField)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUser)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // pctField
            // 
            this.pctField.Location = new System.Drawing.Point(12, 39);
            this.pctField.Name = "pctField";
            this.pctField.Size = new System.Drawing.Size(241, 241);
            this.pctField.TabIndex = 0;
            this.pctField.TabStop = false;
            this.pctField.Paint += new System.Windows.Forms.PaintEventHandler(this.pctField_Paint_1);
            this.pctField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctField_MouseUp_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSettings,
            this.статистикаToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.mnuExit});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // mnuSettings
            // 
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(135, 22);
            this.mnuSettings.Text = "Настройка";
            this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click_1);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(135, 22);
            this.mnuExit.Text = "Выход";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click_1);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаИгрыToolStripMenuItem,
            this.оПрограмеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // правилаИгрыToolStripMenuItem
            // 
            this.правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            this.правилаИгрыToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.правилаИгрыToolStripMenuItem.Text = "Правила игры";
            this.правилаИгрыToolStripMenuItem.Click += new System.EventHandler(this.правилаИгрыToolStripMenuItem_Click);
            // 
            // оПрограмеToolStripMenuItem
            // 
            this.оПрограмеToolStripMenuItem.Name = "оПрограмеToolStripMenuItem";
            this.оПрограмеToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.оПрограмеToolStripMenuItem.Text = "О програме ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEllipsePC);
            this.groupBox1.Controls.Add(this.lblRhombusPC);
            this.groupBox1.Controls.Add(this.pctUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Компьютер";
            // 
            // lblEllipsePC
            // 
            this.lblEllipsePC.AutoSize = true;
            this.lblEllipsePC.Location = new System.Drawing.Point(73, 56);
            this.lblEllipsePC.Name = "lblEllipsePC";
            this.lblEllipsePC.Size = new System.Drawing.Size(13, 13);
            this.lblEllipsePC.TabIndex = 2;
            this.lblEllipsePC.Text = "0";
            // 
            // lblRhombusPC
            // 
            this.lblRhombusPC.AutoSize = true;
            this.lblRhombusPC.Location = new System.Drawing.Point(73, 19);
            this.lblRhombusPC.Name = "lblRhombusPC";
            this.lblRhombusPC.Size = new System.Drawing.Size(13, 13);
            this.lblRhombusPC.TabIndex = 1;
            this.lblRhombusPC.Text = "0";
            // 
            // pctUser
            // 
            this.pctUser.Location = new System.Drawing.Point(6, 19);
            this.pctUser.Name = "pctUser";
            this.pctUser.Size = new System.Drawing.Size(51, 59);
            this.pctUser.TabIndex = 0;
            this.pctUser.TabStop = false;
            this.pctUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pctUser_Paint_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEllipseUser);
            this.groupBox2.Controls.Add(this.lblRhombusUser);
            this.groupBox2.Controls.Add(this.pctPC);
            this.groupBox2.Location = new System.Drawing.Point(136, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 99);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Человек";
            // 
            // lblEllipseUser
            // 
            this.lblEllipseUser.AutoSize = true;
            this.lblEllipseUser.Location = new System.Drawing.Point(73, 54);
            this.lblEllipseUser.Name = "lblEllipseUser";
            this.lblEllipseUser.Size = new System.Drawing.Size(13, 13);
            this.lblEllipseUser.TabIndex = 3;
            this.lblEllipseUser.Text = "0";
            // 
            // lblRhombusUser
            // 
            this.lblRhombusUser.AutoSize = true;
            this.lblRhombusUser.Location = new System.Drawing.Point(73, 28);
            this.lblRhombusUser.Name = "lblRhombusUser";
            this.lblRhombusUser.Size = new System.Drawing.Size(13, 13);
            this.lblRhombusUser.TabIndex = 3;
            this.lblRhombusUser.Text = "0";
            // 
            // pctPC
            // 
            this.pctPC.Location = new System.Drawing.Point(6, 19);
            this.pctPC.Name = "pctPC";
            this.pctPC.Size = new System.Drawing.Size(51, 59);
            this.pctPC.TabIndex = 1;
            this.pctPC.TabStop = false;
            this.pctPC.Paint += new System.Windows.Forms.PaintEventHandler(this.pctPC_Paint_1);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(259, 39);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(82, 43);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Начать игру";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(310, 88);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(31, 142);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "->";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(368, 39);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(238, 160);
            this.grid.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 396);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pctField);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Игра \"Набери больше\", Гриценко ";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pctField)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUser)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctField;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограмеToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label lblEllipsePC;
        private System.Windows.Forms.Label lblRhombusPC;
        private System.Windows.Forms.PictureBox pctUser;
        private System.Windows.Forms.Label lblEllipseUser;
        private System.Windows.Forms.Label lblRhombusUser;
        private System.Windows.Forms.PictureBox pctPC;
    }
}

