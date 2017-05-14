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
            this.old_FileName = new System.Windows.Forms.Label();
            this.new_FileName = new System.Windows.Forms.Label();
            this.pageManager = new System.Windows.Forms.TabControl();
            this.ComparePricePage = new System.Windows.Forms.TabPage();
            this.CategoriesPage = new System.Windows.Forms.TabPage();
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.RenameCategoryBtn = new System.Windows.Forms.Button();
            this.CategoryList = new System.Windows.Forms.ListBox();
            this.stockPage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.stock_categories = new System.Windows.Forms.ComboBox();
            this.removeFromStock = new System.Windows.Forms.Button();
            this.addToStockBtn = new System.Windows.Forms.Button();
            this.pageManager.SuspendLayout();
            this.ComparePricePage.SuspendLayout();
            this.CategoriesPage.SuspendLayout();
            this.stockPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // OldSelectPriceBtn
            // 
            this.OldSelectPriceBtn.Location = new System.Drawing.Point(35, 70);
            this.OldSelectPriceBtn.Name = "OldSelectPriceBtn";
            this.OldSelectPriceBtn.Size = new System.Drawing.Size(154, 23);
            this.OldSelectPriceBtn.TabIndex = 0;
            this.OldSelectPriceBtn.Text = "Выберите файл";
            this.OldSelectPriceBtn.UseVisualStyleBackColor = true;
            this.OldSelectPriceBtn.Click += new System.EventHandler(this.OldSelectPriceBtn_Click);
            // 
            // OldTitleColumn
            // 
            this.OldTitleColumn.Location = new System.Drawing.Point(32, 171);
            this.OldTitleColumn.Name = "OldTitleColumn";
            this.OldTitleColumn.Size = new System.Drawing.Size(100, 20);
            this.OldTitleColumn.TabIndex = 2;
            // 
            // OldPriceColumn
            // 
            this.OldPriceColumn.Location = new System.Drawing.Point(32, 236);
            this.OldPriceColumn.Name = "OldPriceColumn";
            this.OldPriceColumn.Size = new System.Drawing.Size(100, 20);
            this.OldPriceColumn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Буква колонки с названием товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Старый прайс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Буква колонки с ценой";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(645, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Буква колонки с ценой";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(648, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Новый прайс";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(645, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Буква колонки с названием товара";
            // 
            // NewPriceColumn
            // 
            this.NewPriceColumn.Location = new System.Drawing.Point(645, 236);
            this.NewPriceColumn.Name = "NewPriceColumn";
            this.NewPriceColumn.Size = new System.Drawing.Size(100, 20);
            this.NewPriceColumn.TabIndex = 9;
            // 
            // NewTitleColumn
            // 
            this.NewTitleColumn.Location = new System.Drawing.Point(645, 171);
            this.NewTitleColumn.Name = "NewTitleColumn";
            this.NewTitleColumn.Size = new System.Drawing.Size(100, 20);
            this.NewTitleColumn.TabIndex = 8;
            // 
            // NewSelectPriceBtn
            // 
            this.NewSelectPriceBtn.Location = new System.Drawing.Point(648, 70);
            this.NewSelectPriceBtn.Name = "NewSelectPriceBtn";
            this.NewSelectPriceBtn.Size = new System.Drawing.Size(154, 23);
            this.NewSelectPriceBtn.TabIndex = 7;
            this.NewSelectPriceBtn.Text = "Выберите файл";
            this.NewSelectPriceBtn.UseVisualStyleBackColor = true;
            this.NewSelectPriceBtn.Click += new System.EventHandler(this.NewSelectPriceBtn_Click);
            // 
            // CompareBtn
            // 
            this.CompareBtn.Location = new System.Drawing.Point(379, 313);
            this.CompareBtn.Name = "CompareBtn";
            this.CompareBtn.Size = new System.Drawing.Size(155, 23);
            this.CompareBtn.TabIndex = 13;
            this.CompareBtn.Text = "Сравнить прайсы";
            this.CompareBtn.UseVisualStyleBackColor = true;
            this.CompareBtn.Click += new System.EventHandler(this.CompareBtn_Click);
            // 
            // old_FileName
            // 
            this.old_FileName.AutoSize = true;
            this.old_FileName.Location = new System.Drawing.Point(6, 80);
            this.old_FileName.Name = "old_FileName";
            this.old_FileName.Size = new System.Drawing.Size(0, 13);
            this.old_FileName.TabIndex = 14;
            // 
            // new_FileName
            // 
            this.new_FileName.AutoSize = true;
            this.new_FileName.Location = new System.Drawing.Point(648, 109);
            this.new_FileName.Name = "new_FileName";
            this.new_FileName.Size = new System.Drawing.Size(0, 13);
            this.new_FileName.TabIndex = 15;
            // 
            // pageManager
            // 
            this.pageManager.Controls.Add(this.ComparePricePage);
            this.pageManager.Controls.Add(this.CategoriesPage);
            this.pageManager.Controls.Add(this.stockPage);
            this.pageManager.Location = new System.Drawing.Point(3, 2);
            this.pageManager.Name = "pageManager";
            this.pageManager.SelectedIndex = 0;
            this.pageManager.Size = new System.Drawing.Size(938, 418);
            this.pageManager.TabIndex = 16;
            // 
            // ComparePricePage
            // 
            this.ComparePricePage.Controls.Add(this.label2);
            this.ComparePricePage.Controls.Add(this.CompareBtn);
            this.ComparePricePage.Controls.Add(this.new_FileName);
            this.ComparePricePage.Controls.Add(this.OldSelectPriceBtn);
            this.ComparePricePage.Controls.Add(this.old_FileName);
            this.ComparePricePage.Controls.Add(this.label4);
            this.ComparePricePage.Controls.Add(this.OldTitleColumn);
            this.ComparePricePage.Controls.Add(this.label5);
            this.ComparePricePage.Controls.Add(this.label6);
            this.ComparePricePage.Controls.Add(this.OldPriceColumn);
            this.ComparePricePage.Controls.Add(this.NewPriceColumn);
            this.ComparePricePage.Controls.Add(this.label1);
            this.ComparePricePage.Controls.Add(this.NewTitleColumn);
            this.ComparePricePage.Controls.Add(this.label3);
            this.ComparePricePage.Controls.Add(this.NewSelectPriceBtn);
            this.ComparePricePage.Location = new System.Drawing.Point(4, 22);
            this.ComparePricePage.Name = "ComparePricePage";
            this.ComparePricePage.Padding = new System.Windows.Forms.Padding(3);
            this.ComparePricePage.Size = new System.Drawing.Size(930, 392);
            this.ComparePricePage.TabIndex = 0;
            this.ComparePricePage.Text = "Сравнение прайсов";
            this.ComparePricePage.UseVisualStyleBackColor = true;
            // 
            // CategoriesPage
            // 
            this.CategoriesPage.Controls.Add(this.AddCategoryBtn);
            this.CategoriesPage.Controls.Add(this.RenameCategoryBtn);
            this.CategoriesPage.Controls.Add(this.CategoryList);
            this.CategoriesPage.Location = new System.Drawing.Point(4, 22);
            this.CategoriesPage.Name = "CategoriesPage";
            this.CategoriesPage.Padding = new System.Windows.Forms.Padding(3);
            this.CategoriesPage.Size = new System.Drawing.Size(930, 392);
            this.CategoriesPage.TabIndex = 1;
            this.CategoriesPage.Text = "Категории";
            this.CategoriesPage.UseVisualStyleBackColor = true;
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.Location = new System.Drawing.Point(552, 69);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(252, 23);
            this.AddCategoryBtn.TabIndex = 3;
            this.AddCategoryBtn.Text = "Добавить новую категорию";
            this.AddCategoryBtn.UseVisualStyleBackColor = true;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // RenameCategoryBtn
            // 
            this.RenameCategoryBtn.Location = new System.Drawing.Point(552, 22);
            this.RenameCategoryBtn.Name = "RenameCategoryBtn";
            this.RenameCategoryBtn.Size = new System.Drawing.Size(252, 23);
            this.RenameCategoryBtn.TabIndex = 2;
            this.RenameCategoryBtn.Text = "Переименовать выбранную категорию";
            this.RenameCategoryBtn.UseVisualStyleBackColor = true;
            this.RenameCategoryBtn.Click += new System.EventHandler(this.RenameCategoryBtn_Click);
            // 
            // CategoryList
            // 
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.Location = new System.Drawing.Point(7, 22);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(470, 186);
            this.CategoryList.TabIndex = 1;
            // 
            // stockPage
            // 
            this.stockPage.Controls.Add(this.label7);
            this.stockPage.Controls.Add(this.stock_categories);
            this.stockPage.Controls.Add(this.removeFromStock);
            this.stockPage.Controls.Add(this.addToStockBtn);
            this.stockPage.Location = new System.Drawing.Point(4, 22);
            this.stockPage.Name = "stockPage";
            this.stockPage.Size = new System.Drawing.Size(930, 392);
            this.stockPage.TabIndex = 2;
            this.stockPage.Text = "Склад";
            this.stockPage.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Выберите категорию:";
            // 
            // stock_categories
            // 
            this.stock_categories.FormattingEnabled = true;
            this.stock_categories.Location = new System.Drawing.Point(19, 54);
            this.stock_categories.Name = "stock_categories";
            this.stock_categories.Size = new System.Drawing.Size(316, 21);
            this.stock_categories.TabIndex = 2;
            // 
            // removeFromStock
            // 
            this.removeFromStock.Location = new System.Drawing.Point(553, 105);
            this.removeFromStock.Name = "removeFromStock";
            this.removeFromStock.Size = new System.Drawing.Size(329, 126);
            this.removeFromStock.TabIndex = 1;
            this.removeFromStock.Text = "Списать со склада";
            this.removeFromStock.UseVisualStyleBackColor = true;
            this.removeFromStock.Click += new System.EventHandler(this.removeFromStock_Click);
            // 
            // addToStockBtn
            // 
            this.addToStockBtn.Location = new System.Drawing.Point(19, 105);
            this.addToStockBtn.Name = "addToStockBtn";
            this.addToStockBtn.Size = new System.Drawing.Size(316, 126);
            this.addToStockBtn.TabIndex = 0;
            this.addToStockBtn.Text = "Пополнить склад";
            this.addToStockBtn.UseVisualStyleBackColor = true;
            this.addToStockBtn.Click += new System.EventHandler(this.addToStockBtn_Click);
            // 
            // PriceCompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 432);
            this.Controls.Add(this.pageManager);
            this.Name = "PriceCompareForm";
            this.Text = "Сравнение прайсов, версия 2.0.1";
            this.Load += new System.EventHandler(this.PriceCompareForm_Load);
            this.pageManager.ResumeLayout(false);
            this.ComparePricePage.ResumeLayout(false);
            this.ComparePricePage.PerformLayout();
            this.CategoriesPage.ResumeLayout(false);
            this.stockPage.ResumeLayout(false);
            this.stockPage.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label old_FileName;
        private System.Windows.Forms.Label new_FileName;
        private System.Windows.Forms.TabControl pageManager;
        private System.Windows.Forms.TabPage ComparePricePage;
        private System.Windows.Forms.TabPage CategoriesPage;
        private System.Windows.Forms.Button AddCategoryBtn;
        private System.Windows.Forms.Button RenameCategoryBtn;
        private System.Windows.Forms.ListBox CategoryList;
        private System.Windows.Forms.TabPage stockPage;
        private System.Windows.Forms.Button removeFromStock;
        private System.Windows.Forms.Button addToStockBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox stock_categories;
    }
}

