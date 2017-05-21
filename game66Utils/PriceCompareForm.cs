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
using game66Utils.Catalog.Command.AddGroup;
using game66Utils.Catalog.Command.AddProductToGroup;
using game66Utils.Catalog.Query;
using game66Utils.Catalog.Query.CategoryList;
using game66Utils.Catalog.Query.ProductExists;
using game66Utils.Catalog.Query.SimularGroup;
using game66Utils.Database;
using game66Utils.Models;
using game66Utils.Services;
using game66Utils.Stock;
using game66Utils.Stock.Command;
using game66Utils.StockReport;
using Ninject;

namespace game66Utils
{
    public partial class PriceCompareForm : Form
    {

        public PriceCompareForm(ICategoryListQuery categoryListQuery, IKernel kernel)
        {
            _kernel = kernel;
            _categoryListQuery = categoryListQuery;
            InitializeComponent();
            _compareService = new CompareService(
                new ParserFactory(new ParseInputRowService()),
                new ComparePriceTableService(),
                new CreateResultFileService()
            );
        }
        private async void PriceCompareForm_Load(object sender, EventArgs e)
        {
            await ReloadCategoryList();
        }

        #region comparePrice
        private CompareService _compareService;
        private string _oldPriceUrl;
        private string _newPriceUrl;
        private ICategoryListQuery _categoryListQuery;
        private IKernel _kernel;

        private void OldSelectPriceBtn_Click(object sender, EventArgs e)
        {
            if (OldPriceOpenDialog.ShowDialog() == DialogResult.OK)
            {
                _oldPriceUrl = OldPriceOpenDialog.FileName;
                old_FileName.Text = OldPriceOpenDialog.FileName;
            }
        }

        private void NewSelectPriceBtn_Click(object sender, EventArgs e)
        {
            if (NewPriceOpenDialog.ShowDialog() == DialogResult.OK)
            {
                _newPriceUrl = NewPriceOpenDialog.FileName;
                new_FileName.Text = NewPriceOpenDialog.FileName;
            }
        }

        private void CompareBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_oldPriceUrl))
            {
                MessageBox.Show("Select old price file!");
                return;
            }
            if (string.IsNullOrEmpty(_newPriceUrl))
            {
                MessageBox.Show("Select new price file!");
                return;
            }
            int op;
            int ot;
            int np;
            int nt;
            if (
                !(int.TryParse(OldPriceColumn.Text, out op) && int.TryParse(OldTitleColumn.Text, out ot) &&
                  int.TryParse(NewPriceColumn.Text, out np) && int.TryParse(NewTitleColumn.Text, out nt)))
            {
                MessageBox.Show("column name must be number");
                return;
            }
            var old = new UserInputMessage
            {
                FileUrl = _oldPriceUrl,
                PriceColumn = op,
                TitleColumn = ot,
            };
            var newFile = new UserInputMessage
            {
                FileUrl = _newPriceUrl,
                PriceColumn = op,
                TitleColumn = ot,
            };
            var compareResultFile = _compareService.ComparePrices(old, newFile);
            CompareResultSaveDialog.Filter = "Excel 2007 files (*.xlsx)|*.xlsx";
            CompareResultSaveDialog.DefaultExt = "xlsx";
            CompareResultSaveDialog.AddExtension = true;
            if (CompareResultSaveDialog.ShowDialog() == DialogResult.OK)
            {
                using (var myStream = CompareResultSaveDialog.OpenFile())
                {
                    myStream.Write(compareResultFile, 0, compareResultFile.Length);
                    myStream.Close();
                }
            }
        }


        #endregion

        #region category

        private async Task ReloadCategoryList()
        {
            var categoryList = await _categoryListQuery.Execute();
            CategoryList.DataSource = categoryList;
            stock_categories.DataSource = categoryList;
        }
        private async void RenameCategoryBtn_Click(object sender, EventArgs e)
        {
            var category = CategoryList.SelectedItem as CategoryListDto;
            if (category == null)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }
            var dialog = new ChangeCategory(_kernel.Get<IUpdateCategoryCommand>(), category);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                await ReloadCategoryList();
            }
        }
        private async void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            var dialog = new ChangeCategory(_kernel.Get<IAddCategoryCommand>());
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                await ReloadCategoryList();
            }
        }
        #endregion

        #region stock
        private void addToStockBtn_Click(object sender, EventArgs e)
        {
            var category = stock_categories.SelectedItem as CategoryListDto;
            if (category == null)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }

            var dialog = new AddToStock(_kernel.Get<IProductExistsQuery>(), _kernel.Get<ISimularGroupQuery>(),_kernel.Get<IAddGroupCommand>(), _kernel.Get<IAddProductToGroupCommand>(), _kernel.Get<IAddToStockCommand>(), category.Id);
            dialog.ShowDialog();
        }
        #endregion

        private void removeFromStock_Click(object sender, EventArgs e)
        {
            var category = stock_categories.SelectedItem as CategoryListDto;
            if (category == null)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }

            var dialog = new RemoveFromStock(_kernel.Get<IRemoveFromStockCommand>(), category.Id);
            dialog.ShowDialog();

        }

        private void createCsvReportBtn_Click(object sender, EventArgs e)
        {
            var category = stock_categories.SelectedItem as CategoryListDto;
            if (category == null)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }
            var report = new CsvStockReportBuilder().GetCsvReport(category.Id);
            CompareResultSaveDialog.Filter = "Csv files | *.csv";
            CompareResultSaveDialog.DefaultExt = "csv";
            CompareResultSaveDialog.AddExtension = true;
            if (CompareResultSaveDialog.ShowDialog() == DialogResult.OK)
            {
                using (var myStream = CompareResultSaveDialog.OpenFile())
                {
                    var byt = Encoding.GetEncoding(1251).GetBytes(report);
                    myStream.Write(byt, 0, byt.Length);
                    myStream.Close();
                }
            }
        }
    }
}
