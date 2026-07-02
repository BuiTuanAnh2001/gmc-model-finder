using gmc_api.Entities.IC.Receipt;
using System.Collections.Generic;

namespace gmc_api.Entities
{
    public class ReceiptEntities
    {
        public ICReceiptsInfo MainObject { get; set; } = new ICReceiptsInfo();
        public ReceiptItemsEntity ItemObject { get; set; } = new ReceiptItemsEntity();
        public List<ReceiptItemsEntity> lstICReceiptItems { get; set; } = new List<ReceiptItemsEntity>();
        public List<ICReceiptItemsInfo> lstScanBarCode { get; set; } = new List<ICReceiptItemsInfo>();
        public List<ICReceiptSaleReturnsInfo> lstICReceiptSaleReturns { get; set; } = new List<ICReceiptSaleReturnsInfo>();
        public List<ICReceiptPOs> lstICReceiptPOs { get; set;} = new List<ICReceiptPOs>(); //tạo từ PO
        public List<ICReceiptRequestReceipts> lstICReceiptRequestReceipts { get; set; } = new List<ICReceiptRequestReceipts>(); //tạo từ đề nghị nhập kho
        public List<ICReceiptPInvoicesInfo> lstICReceiptPInvoices { get; set; } = new List<ICReceiptPInvoicesInfo>(); //tạo từ hóa đơn mua hàng
    }
}
