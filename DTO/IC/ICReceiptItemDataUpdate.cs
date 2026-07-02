using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class ICReceiptItemDataUpdate
    {
        public int ICReceiptItemID { get; set; }
        public int FK_ICReceiptID { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public int FK_ICStockID { get; set; }
        public string ICReceiptItemLotNo { get; set; } = String.Empty;
        public decimal ICReceiptItemQty { get; set; }
        public decimal ICReceiptItemStkQty { get; set; }
        public int FK_PPCostCenterID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
        public decimal ICReceiptItemFact { get; set; }
        public byte[] ICReceiptItemBarCode { get; set; }
        public string ICReceiptItemBarCodeNo { get; set; } = String.Empty;
        public string ICReceiptItemSerialNo { get; set; } = String.Empty;
        public Nullable<DateTime> ICReceiptItemExpireDate { get; set; }
        public string GLTOF01Combo { get; set; } = String.Empty;
        public string GLTOF02Combo { get; set; } = String.Empty;
        public string GLTOF03Combo { get; set; } = String.Empty;
        public string GLTOF04Combo { get; set; } = String.Empty;
        public string GLTOF05Combo { get; set; } = String.Empty;
        public string GLTOF06Combo { get; set; } = String.Empty;
        public string GLTOF07Combo { get; set; } = String.Empty;
        public string GLTOF08Combo { get; set; } = String.Empty;
        public string GLTOF09Combo { get; set; } = String.Empty;
        public string GLTOF10Combo { get; set; } = String.Empty;
        public string GLTOF11Combo { get; set; } = String.Empty;
        public string GLTOF12Combo { get; set; } = String.Empty;
        public string GLTOF13Combo { get; set; } = String.Empty;
        public string GLTOF14Combo { get; set; } = String.Empty;
        public string GLTOF15Combo { get; set; } = String.Empty;
    }
}
