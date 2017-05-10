using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game66Utils.Catalog.Command;
using game66Utils.Catalog.Domain.Products;
using game66Utils.Catalog.Query.ProductExists;
using game66Utils.Stock.Command;

namespace game66Utils.Stock
{
    public partial class AddToStock : Form
    {
        private IProductExistsQuery _productExistsQuery;
        private IAddToStockCommand _addToStockCommand;
        private Guid _categoryId;
        private IAddProductCommand _addProductCommand;

        public AddToStock(
            IProductExistsQuery productExistsQuery,
            IAddToStockCommand addToStockCommand,
            IAddProductCommand addProductCommand,
            Guid categoryId
        )
        {
            _addProductCommand = addProductCommand;
            _categoryId = categoryId;
            _addToStockCommand = addToStockCommand;
            _productExistsQuery = productExistsQuery;
            InitializeComponent();
        }

        private void AddToStock_Shown(object sender, EventArgs e)
        {
            BarCode_TextBox.Focus();
        }

        private void BarCode_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TryAdd();
            }
        }

        private async Task TryAdd()
        {
            var barCode = BarCode_TextBox.Text.Trim();
            if (string.IsNullOrEmpty(barCode))
            {
                MessageBox.Show("Введите штрихкод!");
                return;
            }
            if (_productExistsQuery.Exist(barCode, _categoryId))
            {
                await _addToStockCommand.Execute(_categoryId, barCode);
                MessageBox.Show("Склад успешно пополнен!");
            }
            else
            {
                var dialog = new AddProduct(_addProductCommand, _addToStockCommand, barCode, _categoryId);
                dialog.ShowDialog();
                this.Close();
            }
        }

        private async void AddToStock_button_Click(object sender, EventArgs e)
        {
            await TryAdd();
        }
    }
}
