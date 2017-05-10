using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game66Utils.Catalog.Command;
using game66Utils.Catalog.Domain.Products;
using game66Utils.Stock.Command;

namespace game66Utils.Stock
{
    public partial class AddProduct : Form
    {
        private IAddToStockCommand _addToStockCommand;
        private IAddProductCommand _addProductCommand;
        private string _barCode;
        private Guid _categoryId;

        public AddProduct(
            IAddProductCommand addProductCommand,
            IAddToStockCommand addToStockCommand,
            string barCode,
            Guid categoryId
            )
        {
            _categoryId = categoryId;
            _barCode = barCode;
            _addProductCommand = addProductCommand;
            _addToStockCommand = addToStockCommand;
            InitializeComponent();
        }

        private async void Create_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Title_textbox.Text))
            {
                MessageBox.Show("Введите название!");
                return;
            }

            decimal purchasePrice;
            decimal salePrice;
            if (!decimal.TryParse(PurchasePrice_textbox.Text.Replace(',','.'), NumberStyles.Any, CultureInfo.InvariantCulture, out purchasePrice))
            {
                MessageBox.Show("Введите корректную цену закупки!");
                return;
            }

            if (!decimal.TryParse(SalePrice_textbox.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out salePrice))
            {
                MessageBox.Show("Введите корректную цену продажи!");
                return;
            }

            await _addProductCommand.Execute(new AddProductContext
            {
                BarCode = _barCode,
                CategoryId = _categoryId,
                PurchasePrice = purchasePrice,
                SellingPrice = salePrice,
                Title = Title_textbox.Text
            });

            await _addToStockCommand.Execute(_categoryId, _barCode);

            MessageBox.Show("Склад пополнен!");
        }
    }
}
