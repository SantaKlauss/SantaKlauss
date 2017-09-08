namespace Гриценко02
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
            this.grbReader = new System.Windows.Forms.GroupBox();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.txtKol = new System.Windows.Forms.TextBox();
            this.chkBook = new System.Windows.Forms.CheckBox();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.rdbStatus3 = new System.Windows.Forms.RadioButton();
            this.rdbStatus2 = new System.Windows.Forms.RadioButton();
            this.rdbStatus1 = new System.Windows.Forms.RadioButton();
            this.cmbReader = new System.Windows.Forms.ComboBox();
            this.lblKol = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblReader = new System.Windows.Forms.Label();
            this.grbInfrom = new System.Windows.Forms.GroupBox();
            this.lstInform = new System.Windows.Forms.ListBox();
            this.btnInform = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnVisibleInform = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbReader.SuspendLayout();
            this.grbStatus.SuspendLayout();
            this.grbInfrom.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbReader
            // 
            this.grbReader.Controls.Add(this.lstBooks);
            this.grbReader.Controls.Add(this.txtKol);
            this.grbReader.Controls.Add(this.chkBook);
            this.grbReader.Controls.Add(this.grbStatus);
            this.grbReader.Controls.Add(this.cmbReader);
            this.grbReader.Controls.Add(this.lblKol);
            this.grbReader.Controls.Add(this.lblBooks);
            this.grbReader.Controls.Add(this.lblReader);
            this.grbReader.Location = new System.Drawing.Point(26, 22);
            this.grbReader.Name = "grbReader";
            this.grbReader.Size = new System.Drawing.Size(407, 211);
            this.grbReader.TabIndex = 0;
            this.grbReader.TabStop = false;
            this.grbReader.Text = "Карточка читателя";
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.Items.AddRange(new object[] {
            "Достоевский \"Идиот\"",
            "Куприн \"Сборник рассказов\"",
            "Лермонтов \"Мцыри\"",
            "Толстой \"Война и мир\""});
            this.lstBooks.Location = new System.Drawing.Point(230, 69);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(152, 95);
            this.lstBooks.TabIndex = 13;
            // 
            // txtKol
            // 
            this.txtKol.Location = new System.Drawing.Point(230, 184);
            this.txtKol.Name = "txtKol";
            this.txtKol.Size = new System.Drawing.Size(152, 20);
            this.txtKol.TabIndex = 0;
            // 
            // chkBook
            // 
            this.chkBook.AutoSize = true;
            this.chkBook.Location = new System.Drawing.Point(12, 170);
            this.chkBook.Name = "chkBook";
            this.chkBook.Size = new System.Drawing.Size(102, 17);
            this.chkBook.TabIndex = 12;
            this.chkBook.Text = "Книги на руках";
            this.chkBook.UseVisualStyleBackColor = true;
            // 
            // grbStatus
            // 
            this.grbStatus.Controls.Add(this.rdbStatus3);
            this.grbStatus.Controls.Add(this.rdbStatus2);
            this.grbStatus.Controls.Add(this.rdbStatus1);
            this.grbStatus.Location = new System.Drawing.Point(13, 49);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(200, 100);
            this.grbStatus.TabIndex = 11;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "Статус";
            // 
            // rdbStatus3
            // 
            this.rdbStatus3.AutoSize = true;
            this.rdbStatus3.Location = new System.Drawing.Point(6, 62);
            this.rdbStatus3.Name = "rdbStatus3";
            this.rdbStatus3.Size = new System.Drawing.Size(73, 17);
            this.rdbStatus3.TabIndex = 2;
            this.rdbStatus3.TabStop = true;
            this.rdbStatus3.Text = "Работник";
            this.rdbStatus3.UseVisualStyleBackColor = true;
            // 
            // rdbStatus2
            // 
            this.rdbStatus2.AutoSize = true;
            this.rdbStatus2.Location = new System.Drawing.Point(6, 39);
            this.rdbStatus2.Name = "rdbStatus2";
            this.rdbStatus2.Size = new System.Drawing.Size(65, 17);
            this.rdbStatus2.TabIndex = 1;
            this.rdbStatus2.TabStop = true;
            this.rdbStatus2.Text = "Студент";
            this.rdbStatus2.UseVisualStyleBackColor = true;
            // 
            // rdbStatus1
            // 
            this.rdbStatus1.AutoSize = true;
            this.rdbStatus1.Checked = true;
            this.rdbStatus1.Location = new System.Drawing.Point(6, 16);
            this.rdbStatus1.Name = "rdbStatus1";
            this.rdbStatus1.Size = new System.Drawing.Size(76, 17);
            this.rdbStatus1.TabIndex = 0;
            this.rdbStatus1.TabStop = true;
            this.rdbStatus1.Text = "Школьник";
            this.rdbStatus1.UseVisualStyleBackColor = true;
            // 
            // cmbReader
            // 
            this.cmbReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReader.FormattingEnabled = true;
            this.cmbReader.Items.AddRange(new object[] {
            "Арбузов Н.В.",
            "Вылежгина О.Ю",
            "Иванов П.Р",
            "Сидоров А.И"});
            this.cmbReader.Location = new System.Drawing.Point(75, 16);
            this.cmbReader.Name = "cmbReader";
            this.cmbReader.Size = new System.Drawing.Size(121, 21);
            this.cmbReader.Sorted = true;
            this.cmbReader.TabIndex = 10;
            // 
            // lblKol
            // 
            this.lblKol.AutoSize = true;
            this.lblKol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKol.Location = new System.Drawing.Point(7, 191);
            this.lblKol.Name = "lblKol";
            this.lblKol.Size = new System.Drawing.Size(108, 13);
            this.lblKol.TabIndex = 9;
            this.lblKol.Text = "Количество дней";
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBooks.Location = new System.Drawing.Point(227, 53);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(164, 13);
            this.lblBooks.TabIndex = 8;
            this.lblBooks.Text = "Список текстовых фондов";
            // 
            // lblReader
            // 
            this.lblReader.AutoSize = true;
            this.lblReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReader.Location = new System.Drawing.Point(6, 16);
            this.lblReader.Name = "lblReader";
            this.lblReader.Size = new System.Drawing.Size(63, 13);
            this.lblReader.TabIndex = 7;
            this.lblReader.Text = "Читатель";
            // 
            // grbInfrom
            // 
            this.grbInfrom.Controls.Add(this.lstInform);
            this.grbInfrom.Location = new System.Drawing.Point(36, 276);
            this.grbInfrom.Name = "grbInfrom";
            this.grbInfrom.Size = new System.Drawing.Size(397, 125);
            this.grbInfrom.TabIndex = 1;
            this.grbInfrom.TabStop = false;
            this.grbInfrom.Text = "Информация";
            // 
            // lstInform
            // 
            this.lstInform.FormattingEnabled = true;
            this.lstInform.Location = new System.Drawing.Point(9, 24);
            this.lstInform.Name = "lstInform";
            this.lstInform.Size = new System.Drawing.Size(355, 82);
            this.lstInform.TabIndex = 0;
            // 
            // btnInform
            // 
            this.btnInform.Location = new System.Drawing.Point(481, 22);
            this.btnInform.Name = "btnInform";
            this.btnInform.Size = new System.Drawing.Size(137, 23);
            this.btnInform.TabIndex = 2;
            this.btnInform.Text = "Получить информацию";
            this.btnInform.UseVisualStyleBackColor = true;
            this.btnInform.Click += new System.EventHandler(this.btnInform_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(481, 55);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(137, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Удалить строку";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(481, 84);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnVisibleInform
            // 
            this.btnVisibleInform.Enabled = false;
            this.btnVisibleInform.Location = new System.Drawing.Point(481, 113);
            this.btnVisibleInform.Name = "btnVisibleInform";
            this.btnVisibleInform.Size = new System.Drawing.Size(137, 23);
            this.btnVisibleInform.TabIndex = 5;
            this.btnVisibleInform.Text = "Скрыть информацию";
            this.btnVisibleInform.UseVisualStyleBackColor = true;
            this.btnVisibleInform.Click += new System.EventHandler(this.btnVisibleInform_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(481, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 22);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 427);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVisibleInform);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInform);
            this.Controls.Add(this.grbInfrom);
            this.Controls.Add(this.grbReader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbReader.ResumeLayout(false);
            this.grbReader.PerformLayout();
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            this.grbInfrom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbReader;
        private System.Windows.Forms.ComboBox cmbReader;
        private System.Windows.Forms.Label lblKol;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblReader;
        private System.Windows.Forms.GroupBox grbInfrom;
        private System.Windows.Forms.Button btnInform;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnVisibleInform;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.TextBox txtKol;
        private System.Windows.Forms.CheckBox chkBook;
        private System.Windows.Forms.GroupBox grbStatus;
        private System.Windows.Forms.RadioButton rdbStatus3;
        private System.Windows.Forms.RadioButton rdbStatus2;
        private System.Windows.Forms.RadioButton rdbStatus1;
        private System.Windows.Forms.ListBox lstInform;
    }
}

