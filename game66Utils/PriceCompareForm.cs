using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game66Utils.Models;
using game66Utils.Services;

namespace game66Utils
{
    public partial class PriceCompareForm : Form
    {
        private CompareService _compareService;
        public PriceCompareForm()
        {
            InitializeComponent();
            _compareService = new CompareService(
                new ParserFactory(new ParseInputRowService()), 
                new ComparePriceTableService(), 
                new CreateResultFileService()
                );
        }

        private string _oldPriceUrl;
        private string _newPriceUrl;
        private void OldSelectPriceBtn_Click(object sender, EventArgs e)
        {
            if (OldPriceOpenDialog.ShowDialog() == DialogResult.OK)
                _oldPriceUrl = OldPriceOpenDialog.FileName;
        }

        private void NewSelectPriceBtn_Click(object sender, EventArgs e)
        {
            if (NewPriceOpenDialog.ShowDialog() == DialogResult.OK)
                _newPriceUrl = NewPriceOpenDialog.FileName;
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
            if (CompareResultSaveDialog.ShowDialog() == DialogResult.OK)
            {
                using (var myStream = CompareResultSaveDialog.OpenFile())
                {
                    myStream.Write(compareResultFile, 0, compareResultFile.Length);
                    myStream.Close();
                }
            }
        }
    }
}
