namespace MilkPlant.Models
{
    public class Counterparty
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Inn { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsSupplier { get; set; }
        public bool IsBuyer { get; set; }
    }
}