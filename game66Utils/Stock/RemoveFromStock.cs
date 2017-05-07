using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game66Utils.Catalog.Domain.Products;
using game66Utils.Stock.Command;

namespace game66Utils.Stock
{
    public partial class RemoveFromStock : Form
    {
        private IRemoveFromStock _removeFromStock;
        private Guid _categoryId;

        public RemoveFromStock(
            IRemoveFromStock removeFromStock,
            Guid categoryId
        )
        {
            _categoryId = categoryId;
            _removeFromStock = removeFromStock;
            InitializeComponent();
        }
        private void RemoveFromStock_Shown(object sender, EventArgs e)
        {
            BarCode_TextBox.Focus();
        }
        private async void BarCode_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                await TryRemove();
            }
        }
        private async void RemoveFromStock_button_Click(object sender, EventArgs e)
        {
            await TryRemove();
        }

        private async Task TryRemove()
        {
            var barCode = BarCode_TextBox.Text.Trim();
            if (string.IsNullOrEmpty(barCode))
            {
                MessageBox.Show("Введите штрихкод!");
                return;
            }
            await _removeFromStock.Execute(new ProductId(barCode, _categoryId));
            MessageBox.Show("Списание успешно проведено!");
        }
    }
}
