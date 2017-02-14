namespace game66Utils.Models
{
    public class UserInputMessage
    {
        public string FileUrl { get; set; }
        public string TitleColumn { get; set; }
        public string PriceColumn { get; set; }
        public PriceTypeEnum CurrentPriceType { get; set; }
    }
}
