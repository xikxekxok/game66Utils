using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game66Utils
{
    public partial class PriceCompareForm : Form
    {
        public PriceCompareForm()
        {
            InitializeComponent();
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

        }
    }
}
