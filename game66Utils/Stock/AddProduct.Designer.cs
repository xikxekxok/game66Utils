namespace game66Utils.Stock
{
    partial class AddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.PurchasePrice_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SalePrice_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Title_textbox = new System.Windows.Forms.TextBox();
            this.Create_button = new System.Windows.Forms.Button();
            this.BarCode_label = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Цена закупки";
            // 
            // PurchasePrice_textbox
            // 
            this.PurchasePrice_textbox.Location = new System.Drawing.Point(47, 160);
            this.PurchasePrice_textbox.Name = "PurchasePrice_textbox";
            this.PurchasePrice_textbox.Size = new System.Drawing.Size(577, 20);
            this.PurchasePrice_textbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Цена продажи";
            // 
            // SalePrice_textbox
            // 
            this.SalePrice_textbox.Location = new System.Drawing.Point(47, 233);
            this.SalePrice_textbox.Name = "SalePrice_textbox";
            this.SalePrice_textbox.Size = new System.Drawing.Size(577, 20);
            this.SalePrice_textbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Название";
            // 
            // Title_textbox
            // 
            this.Title_textbox.Location = new System.Drawing.Point(47, 86);
            this.Title_textbox.Name = "Title_textbox";
            this.Title_textbox.Size = new System.Drawing.Size(577, 20);
            this.Title_textbox.TabIndex = 8;
            // 
            // Create_button
            // 
            this.Create_button.Location = new System.Drawing.Point(47, 285);
            this.Create_button.Name = "Create_button";
            this.Create_button.Size = new System.Drawing.Size(226, 23);
            this.Create_button.TabIndex = 10;
            this.Create_button.Text = "Создать и добавить единицу на склад";
            this.Create_button.UseVisualStyleBackColor = true;
            this.Create_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // BarCode_label
            // 
            this.BarCode_label.AutoSize = true;
            this.BarCode_label.Location = new System.Drawing.Point(44, 23);
            this.BarCode_label.Name = "BarCode_label";
            this.BarCode_label.Size = new System.Drawing.Size(56, 13);
            this.BarCode_label.TabIndex = 11;
            this.BarCode_label.Text = "Штрихкод";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(685, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 12;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 336);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BarCode_label);
            this.Controls.Add(this.Create_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SalePrice_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PurchasePrice_textbox);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PurchasePrice_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SalePrice_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Title_textbox;
        private System.Windows.Forms.Button Create_button;
        private System.Windows.Forms.Label BarCode_label;
        private System.Windows.Forms.ListBox listBox1;
    }
}