namespace game66Utils
{
    partial class PriceCompareForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OldPriceOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.OldSelectPriceBtn = new System.Windows.Forms.Button();
            this.OldTitleColumn = new System.Windows.Forms.TextBox();
            this.OldPriceColumn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NewPriceColumn = new System.Windows.Forms.TextBox();
            this.NewTitleColumn = new System.Windows.Forms.TextBox();
            this.NewSelectPriceBtn = new System.Windows.Forms.Button();
            this.NewPriceOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.CompareResultSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.CompareBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OldSelectPriceBtn
            // 
            this.OldSelectPriceBtn.Location = new System.Drawing.Point(31, 66);
            this.OldSelectPriceBtn.Name = "OldSelectPriceBtn";
            this.OldSelectPriceBtn.Size = new System.Drawing.Size(154, 23);
            this.OldSelectPriceBtn.TabIndex = 0;
            this.OldSelectPriceBtn.Text = "Выберите файл";
            this.OldSelectPriceBtn.UseVisualStyleBackColor = true;
            this.OldSelectPriceBtn.Click += new System.EventHandler(this.OldSelectPriceBtn_Click);
            // 
            // OldTitleColumn
            // 
            this.OldTitleColumn.Location = new System.Drawing.Point(31, 145);
            this.OldTitleColumn.Name = "OldTitleColumn";
            this.OldTitleColumn.Size = new System.Drawing.Size(100, 20);
            this.OldTitleColumn.TabIndex = 2;
            // 
            // OldPriceColumn
            // 
            this.OldPriceColumn.Location = new System.Drawing.Point(31, 210);
            this.OldPriceColumn.Name = "OldPriceColumn";
            this.OldPriceColumn.Size = new System.Drawing.Size(100, 20);
            this.OldPriceColumn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Буква колонки с названием товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Старый прайс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Буква колонки с ценой";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Буква колонки с ценой";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(593, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Новый прайс";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Буква колонки с названием товара";
            // 
            // NewPriceColumn
            // 
            this.NewPriceColumn.Location = new System.Drawing.Point(593, 210);
            this.NewPriceColumn.Name = "NewPriceColumn";
            this.NewPriceColumn.Size = new System.Drawing.Size(100, 20);
            this.NewPriceColumn.TabIndex = 9;
            // 
            // NewTitleColumn
            // 
            this.NewTitleColumn.Location = new System.Drawing.Point(593, 145);
            this.NewTitleColumn.Name = "NewTitleColumn";
            this.NewTitleColumn.Size = new System.Drawing.Size(100, 20);
            this.NewTitleColumn.TabIndex = 8;
            // 
            // NewSelectPriceBtn
            // 
            this.NewSelectPriceBtn.Location = new System.Drawing.Point(593, 66);
            this.NewSelectPriceBtn.Name = "NewSelectPriceBtn";
            this.NewSelectPriceBtn.Size = new System.Drawing.Size(154, 23);
            this.NewSelectPriceBtn.TabIndex = 7;
            this.NewSelectPriceBtn.Text = "Выберите файл";
            this.NewSelectPriceBtn.UseVisualStyleBackColor = true;
            this.NewSelectPriceBtn.Click += new System.EventHandler(this.NewSelectPriceBtn_Click);
            // 
            // CompareBtn
            // 
            this.CompareBtn.Location = new System.Drawing.Point(328, 310);
            this.CompareBtn.Name = "CompareBtn";
            this.CompareBtn.Size = new System.Drawing.Size(155, 23);
            this.CompareBtn.TabIndex = 13;
            this.CompareBtn.Text = "Сравнить прайсы";
            this.CompareBtn.UseVisualStyleBackColor = true;
            this.CompareBtn.Click += new System.EventHandler(this.CompareBtn_Click);
            // 
            // PriceCompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 363);
            this.Controls.Add(this.CompareBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NewPriceColumn);
            this.Controls.Add(this.NewTitleColumn);
            this.Controls.Add(this.NewSelectPriceBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OldPriceColumn);
            this.Controls.Add(this.OldTitleColumn);
            this.Controls.Add(this.OldSelectPriceBtn);
            this.Name = "PriceCompareForm";
            this.Text = "PriceCompareForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OldPriceOpenDialog;
        private System.Windows.Forms.Button OldSelectPriceBtn;
        private System.Windows.Forms.TextBox OldTitleColumn;
        private System.Windows.Forms.TextBox OldPriceColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NewPriceColumn;
        private System.Windows.Forms.TextBox NewTitleColumn;
        private System.Windows.Forms.Button NewSelectPriceBtn;
        private System.Windows.Forms.OpenFileDialog NewPriceOpenDialog;
        private System.Windows.Forms.SaveFileDialog CompareResultSaveDialog;
        private System.Windows.Forms.Button CompareBtn;
    }
}

