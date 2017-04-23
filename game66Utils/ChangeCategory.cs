using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game66Utils.Catalog.Command;
using game66Utils.Catalog.Query.CategoryList;

namespace game66Utils
{
    public partial class ChangeCategory : Form
    {
        private IAddCategoryCommand _addCategoryCommand;
        private IUpdateCategoryCommand _updateCategoryCommand;
        private CategoryListDto _categoryListDto;

        public ChangeCategory(IAddCategoryCommand addCategoryCommand)
        {
            _addCategoryCommand = addCategoryCommand;
            InitializeComponent();
            this.Text = "Создание категории";
        }

        public ChangeCategory(IUpdateCategoryCommand updateCategoryCommand, CategoryListDto categoryListDto)
        {
            _categoryListDto = categoryListDto;
            _updateCategoryCommand = updateCategoryCommand;
            InitializeComponent();
            this.Text = "Переименование категории";
            this.categoryNameText.Text = _categoryListDto.Name;
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            if (_categoryListDto == null)
            {
                await _addCategoryCommand.Execute(this.categoryNameText.Text);
            }
            else
            {
                await _updateCategoryCommand.Execute(_categoryListDto.Id, this.categoryNameText.Text);
            }
            this.Close();
        }
    }
}
