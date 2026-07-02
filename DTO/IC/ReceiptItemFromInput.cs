using System;

namespace gmc_api.DTO.IC
{
    public class ReceiptItemFromInput
    {
        public int id { get; set; }
        public int itemId { get; set; }
        public int productId { get; set; }
        public int stockId { get; set; }
        public decimal factor { get; set; }
        public decimal inputStockItemQty { get; set; }
        public decimal stkQty { get; set; }
        public int unitId { get; set; }
        public int unitStkId { get; set; }
        public string description { get; set; }
        public int costCenter { get; set; } = 0;
        public string lotNo { get; set; }
        public string fglotNo { get; set; }
        public byte[] ICReceiptItemBarCode { get; set; }
        public string ICReceiptItemBarCodeNo { get; set; }
        public Nullable<DateTime> ICReceiptItemExpireDate { get; set; }
        public string ICReceiptItemSerialNo { get; set; }
    }
}
