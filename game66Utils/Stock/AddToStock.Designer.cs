namespace game66Utils.Stock
{
    partial class AddToStock
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
            this.BarCode_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddToStock_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BarCode_TextBox
            // 
            this.BarCode_TextBox.Location = new System.Drawing.Point(104, 78);
            this.BarCode_TextBox.Name = "BarCode_TextBox";
            this.BarCode_TextBox.Size = new System.Drawing.Size(430, 20);
            this.BarCode_TextBox.TabIndex = 0;
            this.BarCode_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarCode_TextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(101, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "В это поле необходимо ввести штрихкод. По умолчанию оно выбрано - можно просто по" +
    "днести сканер к штрихкоду. Если после сканирования ничего не происходит - значит" +
    ", надо нажать кнопку \"пополнить\"";
            // 
            // AddToStock_button
            // 
            this.AddToStock_button.Location = new System.Drawing.Point(104, 125);
            this.AddToStock_button.Name = "AddToStock_button";
            this.AddToStock_button.Size = new System.Drawing.Size(75, 23);
            this.AddToStock_button.TabIndex = 2;
            this.AddToStock_button.Text = "Пополнить";
            this.AddToStock_button.UseVisualStyleBackColor = true;
            this.AddToStock_button.Click += new System.EventHandler(this.AddToStock_button_Click);
            // 
            // AddToStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 232);
            this.Controls.Add(this.AddToStock_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarCode_TextBox);
            this.Name = "AddToStock";
            this.Text = "Пополнение склада";
            this.Shown += new System.EventHandler(this.AddToStock_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BarCode_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddToStock_button;
    }
}