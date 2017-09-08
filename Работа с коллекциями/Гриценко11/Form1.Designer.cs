namespace Гриценко11
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
            this.label1 = new System.Windows.Forms.Label();
            this.listColl = new System.Windows.Forms.ListBox();
            this.cmbCommand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.rbOutType1 = new System.Windows.Forms.RadioButton();
            this.rbOutType2 = new System.Windows.Forms.RadioButton();
            this.rbOutType3 = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumEl = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Операции";
            // 
            // listColl
            // 
            this.listColl.FormattingEnabled = true;
            this.listColl.Location = new System.Drawing.Point(15, 59);
            this.listColl.Name = "listColl";
            this.listColl.Size = new System.Drawing.Size(300, 251);
            this.listColl.TabIndex = 1;
            // 
            // cmbCommand
            // 
            this.cmbCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommand.FormattingEnabled = true;
            this.cmbCommand.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbCommand.Items.AddRange(new object[] {
            "Добавить новый элемент в конец",
            "Добавить новый элемент по индексу",
            "Найти индекс первого элемента с начала списка по значению",
            "Найти индекс первого элемента с конца списка по значению",
            "Удалить элемент по значению",
            "Удалить элемент по индексу",
            "Удалить диапозон элементов по индексу",
            "Отсортировать элементы списка",
            "Изменить порядок следования элементов в списке",
            "Удалить все элементы списка"});
            this.cmbCommand.Location = new System.Drawing.Point(75, 6);
            this.cmbCommand.Name = "cmbCommand";
            this.cmbCommand.Size = new System.Drawing.Size(375, 21);
            this.cmbCommand.TabIndex = 2;
            this.cmbCommand.SelectedIndexChanged += new System.EventHandler(this.cmbCommand_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Значение:";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(75, 33);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(240, 20);
            this.txtItem.TabIndex = 4;
            this.txtItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItem_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Индекс:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(372, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(78, 20);
            this.txtID.TabIndex = 6;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // rbOutType1
            // 
            this.rbOutType1.AutoSize = true;
            this.rbOutType1.Checked = true;
            this.rbOutType1.Location = new System.Drawing.Point(6, 19);
            this.rbOutType1.Name = "rbOutType1";
            this.rbOutType1.Size = new System.Drawing.Size(101, 17);
            this.rbOutType1.TabIndex = 8;
            this.rbOutType1.TabStop = true;
            this.rbOutType1.Text = "Ключ-значение";
            this.rbOutType1.UseVisualStyleBackColor = true;
            this.rbOutType1.CheckedChanged += new System.EventHandler(this.rbOutType1_CheckedChanged);
            // 
            // rbOutType2
            // 
            this.rbOutType2.AutoSize = true;
            this.rbOutType2.Location = new System.Drawing.Point(6, 41);
            this.rbOutType2.Name = "rbOutType2";
            this.rbOutType2.Size = new System.Drawing.Size(112, 17);
            this.rbOutType2.TabIndex = 9;
            this.rbOutType2.Text = "Только значение";
            this.rbOutType2.UseVisualStyleBackColor = true;
            this.rbOutType2.CheckedChanged += new System.EventHandler(this.rbOutType2_CheckedChanged);
            // 
            // rbOutType3
            // 
            this.rbOutType3.AutoSize = true;
            this.rbOutType3.Location = new System.Drawing.Point(6, 64);
            this.rbOutType3.Name = "rbOutType3";
            this.rbOutType3.Size = new System.Drawing.Size(96, 17);
            this.rbOutType3.TabIndex = 10;
            this.rbOutType3.Text = "Только ключи";
            this.rbOutType3.UseVisualStyleBackColor = true;
            this.rbOutType3.CheckedChanged += new System.EventHandler(this.rbOutType3_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(321, 248);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(129, 28);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "Выполнить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(321, 282);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 28);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOutType1);
            this.groupBox1.Controls.Add(this.rbOutType2);
            this.groupBox1.Controls.Add(this.rbOutType3);
            this.groupBox1.Location = new System.Drawing.Point(324, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 87);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вывод данных";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Кол-во элементов:";
            // 
            // lblNumEl
            // 
            this.lblNumEl.Location = new System.Drawing.Point(422, 59);
            this.lblNumEl.Name = "lblNumEl";
            this.lblNumEl.Size = new System.Drawing.Size(28, 13);
            this.lblNumEl.TabIndex = 14;
            this.lblNumEl.Text = "0";
            this.lblNumEl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHelp
            // 
            this.lblHelp.Location = new System.Drawing.Point(327, 175);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(123, 70);
            this.lblHelp.TabIndex = 15;
            this.lblHelp.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 324);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblNumEl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCommand);
            this.Controls.Add(this.listColl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Гриценко11, Коллекции";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listColl;
        private System.Windows.Forms.ComboBox cmbCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.RadioButton rbOutType1;
        private System.Windows.Forms.RadioButton rbOutType2;
        private System.Windows.Forms.RadioButton rbOutType3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumEl;
        private System.Windows.Forms.Label lblHelp;
    }
}

