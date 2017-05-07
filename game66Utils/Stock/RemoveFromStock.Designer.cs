namespace game66Utils.Stock
{
    partial class RemoveFromStock
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
            this.RemoveToStock_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BarCode_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RemoveToStock_button
            // 
            this.RemoveToStock_button.Location = new System.Drawing.Point(104, 125);
            this.RemoveToStock_button.Name = "RemoveToStock_button";
            this.RemoveToStock_button.Size = new System.Drawing.Size(75, 23);
            this.RemoveToStock_button.TabIndex = 5;
            this.RemoveToStock_button.Text = "Списать";
            this.RemoveToStock_button.UseVisualStyleBackColor = true;
            this.RemoveToStock_button.Click += new System.EventHandler(this.RemoveFromStock_button_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(101, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "В это поле необходимо ввести штрихкод. По умолчанию оно выбрано - можно просто по" +
    "днести сканер к штрихкоду. Если после сканирования ничего не происходит - значит" +
    ", надо нажать кнопку \"списать\"";
            // 
            // BarCode_TextBox
            // 
            this.BarCode_TextBox.Location = new System.Drawing.Point(104, 78);
            this.BarCode_TextBox.Name = "BarCode_TextBox";
            this.BarCode_TextBox.Size = new System.Drawing.Size(430, 20);
            this.BarCode_TextBox.TabIndex = 3;
            this.BarCode_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarCode_TextBox_KeyPress);
            // 
            // RemoveFromStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 232);
            this.Controls.Add(this.RemoveToStock_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarCode_TextBox);
            this.Name = "RemoveFromStock";
            this.Text = "Списание со склада";
            this.Shown += new System.EventHandler(this.RemoveFromStock_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveToStock_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BarCode_TextBox;
    }
}