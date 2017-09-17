namespace Завод
{
    partial class frmService
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
            this.lstDetals = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.btnClient = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnDelegates = new System.Windows.Forms.Button();
            this.btnLambda = new System.Windows.Forms.Button();
            this.btnFindUs = new System.Windows.Forms.Button();
            this.btnlinq = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.grbSkidka = new System.Windows.Forms.GroupBox();
            this.btn18persent = new System.Windows.Forms.Button();
            this.btn250rubley = new System.Windows.Forms.Button();
            this.lblcost = new System.Windows.Forms.Label();
            this.cost2 = new System.Windows.Forms.Label();
            this.grbSkidka.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDetals
            // 
            this.lstDetals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstDetals.FormattingEnabled = true;
            this.lstDetals.ItemHeight = 15;
            this.lstDetals.Location = new System.Drawing.Point(12, 52);
            this.lstDetals.Name = "lstDetals";
            this.lstDetals.Size = new System.Drawing.Size(449, 184);
            this.lstDetals.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Turquoise;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(110, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(351, 73);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить товар";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtClient
            // 
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtClient.Location = new System.Drawing.Point(12, 19);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(292, 21);
            this.txtClient.TabIndex = 2;
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Violet;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClient.Location = new System.Drawing.Point(320, 11);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(141, 35);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Клиенты";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalCost.Location = new System.Drawing.Point(110, 275);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(0, 15);
            this.lblTotalCost.TabIndex = 3;
            // 
            // btnDelegates
            // 
            this.btnDelegates.BackColor = System.Drawing.Color.Yellow;
            this.btnDelegates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelegates.Location = new System.Drawing.Point(2, 253);
            this.btnDelegates.Name = "btnDelegates";
            this.btnDelegates.Size = new System.Drawing.Size(102, 58);
            this.btnDelegates.TabIndex = 4;
            this.btnDelegates.Text = "Делегаты";
            this.btnDelegates.UseVisualStyleBackColor = false;
            this.btnDelegates.Click += new System.EventHandler(this.btnDelegates_Click);
            // 
            // btnLambda
            // 
            this.btnLambda.BackColor = System.Drawing.Color.Lime;
            this.btnLambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLambda.Location = new System.Drawing.Point(473, 52);
            this.btnLambda.Name = "btnLambda";
            this.btnLambda.Size = new System.Drawing.Size(154, 59);
            this.btnLambda.TabIndex = 4;
            this.btnLambda.Text = "Лямбда-выражения";
            this.btnLambda.UseVisualStyleBackColor = false;
            this.btnLambda.Click += new System.EventHandler(this.btnLambda_Click);
            // 
            // btnFindUs
            // 
            this.btnFindUs.BackColor = System.Drawing.Color.DarkViolet;
            this.btnFindUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFindUs.Location = new System.Drawing.Point(2, 335);
            this.btnFindUs.Name = "btnFindUs";
            this.btnFindUs.Size = new System.Drawing.Size(102, 59);
            this.btnFindUs.TabIndex = 5;
            this.btnFindUs.Text = "Поиск товара";
            this.btnFindUs.UseVisualStyleBackColor = false;
            this.btnFindUs.Click += new System.EventHandler(this.btnFindUs_Click);
            // 
            // btnlinq
            // 
            this.btnlinq.BackColor = System.Drawing.Color.Crimson;
            this.btnlinq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnlinq.Location = new System.Drawing.Point(473, 133);
            this.btnlinq.Name = "btnlinq";
            this.btnlinq.Size = new System.Drawing.Size(154, 59);
            this.btnlinq.TabIndex = 6;
            this.btnlinq.Text = "LINQ";
            this.btnlinq.UseVisualStyleBackColor = false;
            this.btnlinq.Click += new System.EventHandler(this.btnlinq_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(473, 335);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(154, 59);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // grbSkidka
            // 
            this.grbSkidka.Controls.Add(this.btn18persent);
            this.grbSkidka.Controls.Add(this.btn250rubley);
            this.grbSkidka.Location = new System.Drawing.Point(467, 230);
            this.grbSkidka.Name = "grbSkidka";
            this.grbSkidka.Size = new System.Drawing.Size(166, 99);
            this.grbSkidka.TabIndex = 8;
            this.grbSkidka.TabStop = false;
            this.grbSkidka.Text = "Sale";
            // 
            // btn18persent
            // 
            this.btn18persent.BackColor = System.Drawing.Color.Lime;
            this.btn18persent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn18persent.Location = new System.Drawing.Point(6, 60);
            this.btn18persent.Name = "btn18persent";
            this.btn18persent.Size = new System.Drawing.Size(154, 33);
            this.btn18persent.TabIndex = 9;
            this.btn18persent.Text = "-18%";
            this.btn18persent.UseVisualStyleBackColor = false;
            this.btn18persent.Click += new System.EventHandler(this.btn18persent_Click);
            // 
            // btn250rubley
            // 
            this.btn250rubley.BackColor = System.Drawing.Color.Violet;
            this.btn250rubley.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn250rubley.Location = new System.Drawing.Point(6, 19);
            this.btn250rubley.Name = "btn250rubley";
            this.btn250rubley.Size = new System.Drawing.Size(154, 35);
            this.btn250rubley.TabIndex = 9;
            this.btn250rubley.Text = "-250 рублей";
            this.btn250rubley.UseVisualStyleBackColor = false;
            this.btn250rubley.Click += new System.EventHandler(this.btn250rubley_Click);
            // 
            // lblcost
            // 
            this.lblcost.AutoSize = true;
            this.lblcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcost.Location = new System.Drawing.Point(110, 296);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(0, 15);
            this.lblcost.TabIndex = 9;
            // 
            // cost2
            // 
            this.cost2.AutoSize = true;
            this.cost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost2.Location = new System.Drawing.Point(110, 253);
            this.cost2.Name = "cost2";
            this.cost2.Size = new System.Drawing.Size(0, 15);
            this.cost2.TabIndex = 10;
            // 
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 399);
            this.Controls.Add(this.cost2);
            this.Controls.Add(this.lblcost);
            this.Controls.Add(this.grbSkidka);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnlinq);
            this.Controls.Add(this.btnFindUs);
            this.Controls.Add(this.btnLambda);
            this.Controls.Add(this.btnDelegates);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstDetals);
            this.Name = "frmService";
            this.Text = "Завод мотозапчастей";
            this.Load += new System.EventHandler(this.frmService_Load);
            this.grbSkidka.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDetals;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnDelegates;
        private System.Windows.Forms.Button btnLambda;
        private System.Windows.Forms.Button btnFindUs;
        private System.Windows.Forms.Button btnlinq;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox grbSkidka;
        private System.Windows.Forms.Button btn18persent;
        private System.Windows.Forms.Button btn250rubley;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.Label cost2;
    }
}

