namespace MAM.Models
{
    public class ReceiptItemViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 1;
        public decimal Tax { get; set; }
        public decimal ImportDuty { get; set; }
        public decimal ItemCost { get; set; }
    }
}
