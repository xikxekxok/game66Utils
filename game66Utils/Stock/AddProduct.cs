using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game66Utils.Catalog.Command;
using game66Utils.Catalog.Command.AddGroup;
using game66Utils.Catalog.Command.AddProductToGroup;
using game66Utils.Catalog.Domain.Products;
using game66Utils.Catalog.Query.SimularGroup;
using game66Utils.Stock.Command;

namespace game66Utils.Stock
{
    public partial class AddProduct : Form
    {
        private IAddToStockCommand _addToStockCommand;
        private string _barCode;
        private Guid _categoryId;
        public AddProduct(
            ISimularGroupQuery simularGroupQuery,
            IAddToStockCommand addToStockCommand,
            IAddGroupCommand addGroupCommand,
            IAddProductToGroupCommand addProductToGroupCommand,
            string barCode,
            Guid categoryId
            )
        {
            _addProductToGroupCommand = addProductToGroupCommand;
            _addGroupCommand = addGroupCommand;
            _simularGroupQuery = simularGroupQuery;
            _categoryId = categoryId;
            _barCode = barCode;
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
            if (_selectedGroup.GroupId == _notSelected)
            {
                await _addGroupCommand.Execute(new AddGroupContext
                {
                    BarCode = _barCode,
                    CategoryId = _categoryId,
                    ProductGroupId = Guid.NewGuid(),
                    PurchasePrice = purchasePrice,
                    SellingPrice = salePrice,
                    Title = Title_textbox.Text
                });
            }
            else
            {
                await _addProductToGroupCommand.Execute(new AddProductToGroupContext
                {
                    BarCode = _barCode,
                    ProductGroupId = _selectedGroup.GroupId,
                    PurchasePrice = purchasePrice,
                    SellingPrice = salePrice
                });
            }
            //await _addProductCommand.Execute(new AddGroupContext
            //{
            //    BarCode = _barCode,
            //    CategoryId = _categoryId,
            //    PurchasePrice = purchasePrice,
            //    SellingPrice = salePrice,
            //    Title = Title_textbox.Text
            //});

            await _addToStockCommand.Execute(_categoryId, _barCode);

            MessageBox.Show("Склад пополнен!");
        }

        private ISimularGroupQuery _simularGroupQuery;

        private Guid _notSelected = Guid.NewGuid();
        private async Task<List<SimularGroupDto>> GenerateList()
        {
            var list = new List<SimularGroupDto>();

            list.Add(new SimularGroupDto {GroupTitle = "Не выбрано", GroupId = _notSelected});

            var serverList = await _simularGroupQuery.SimularByTitle(Title_textbox.Text, _categoryId);
            list.AddRange(serverList);

            return list;
        }

        private SimularGroupDto _selectedGroup;
        private IAddGroupCommand _addGroupCommand;
        private IAddProductToGroupCommand _addProductToGroupCommand;

        private void titleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedGroup = (titleListBox.SelectedItem as SimularGroupDto);
            if (_selectedGroup.GroupId != _notSelected)
            {
                Title_textbox.ReadOnly = true;
                Title_textbox.Text = _selectedGroup.GroupTitle;
            }
            else
            {
                Title_textbox.ReadOnly = false;
            }
        }

        private async void Title_textbox_TextChanged(object sender, EventArgs e)
        {
            if (!Title_textbox.ReadOnly)
            {
                List<SimularGroupDto> list = await GenerateList();

                titleListBox.DataSource = list;
            }
        }
    }
}
