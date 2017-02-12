using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game66Utils.Messages
{
    public class UserInputMessage
    {
        public string FileUrl { get; set; }
        public string TitleColumn { get; set; }
        public string PriceColumn { get; set; }
        public FileTypeEnum CurrentFileType { get; set; }
    }

    public class CompareResultMessage
    {
        public List<string> NewProducts { get; set; }
        public List<string> DeletedProducts { get; set; }

        public List<PriceChangeModel> ChangedPrices { get; set; }

        public CompareResultMessage()
        {
            NewProducts = new List<string>();
            DeletedProducts = new List<string>();
            ChangedPrices = new List<PriceChangeModel>();
        }
    }

    public class PriceChangeModel
    {
        public string IdProduct { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
    }
}
