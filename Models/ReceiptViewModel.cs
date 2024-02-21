using System.Collections.Generic;

namespace MAM.Models
{
    public class ReceiptViewModel
    {
        public List<ReceiptItemViewModel> ReceiptItems { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalCost { get; set; }
    }
}
