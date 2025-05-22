namespace DairyManagement.Domain.RawMilk
{
    public class RawMilk
    {
        public Guid Id { get; set; }
        public string BatchNumber { get; set; }
        public string SupplierName { get; set; }
        public DateTime ReceiptDate { get; set; }
        public decimal Quantity { get; set; }
        public decimal FatPercentage { get; set; }
        public decimal AcidityDegree { get; set; }
        public decimal Temperature { get; set; }
        public QualityStatus QualityStatus { get; set; }
        public string Notes { get; set; }


    }
}
