using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.Transfer
{
    public class ICTransferItemCreateRequest
    {
        public int ICTransferItemID { get; set; } = 0;
        public string AAStatus { get; set; } = "Alive";
        public Boolean AASelected { get; set; }
        public int FK_ICTransferID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICFromStockID { get; set; }
        public int FK_ICToStockID { get; set; }
        public int FK_ICTransitStockID { get; set; }
        public int FK_ICStockSlotID { get; set; }
        public int FK_ICProductTypeID { get; set; }
        public int FK_ARPriceListID { get; set; }
        public int FK_TXTaxCodeID { get; set; }
        public string ICTransferItemSerialNo { get; set; } = string.Empty;
        public Boolean ICTransferItemIsStkItm { get; set; }
        public string ICTransferItemType { get; set; } = string.Empty;
        public string ICTransferItemDesc { get; set; } = string.Empty;
        public decimal ICTransferItemFact { get; set; }
        public string ICSalePriceCombo { get; set; } = string.Empty;
        public decimal ICTransferItemUnitPrice { get; set; }
        public decimal ICTransferItemUnitCost { get; set; }
        public decimal ICTransferItemDiscPct { get; set; }
        public decimal ICTransferItemTxPct { get; set; }
        public decimal ICTransferItemVolume { get; set; }
        public decimal ICTransferItemQty { get; set; }
        public decimal ICTransferItemStkQty { get; set; }
        public decimal ICTransferItemRQty { get; set; }
        public decimal ICTransferItemRStkQty { get; set; }
        public decimal ICTransferItemPrice { get; set; }
        public string ICTransferItemComment { get; set; } = string.Empty;
        public decimal ICTransferItemUnitVol { get; set; }
        public decimal ICTransferItemUnitWeight { get; set; }
        public decimal ICTransferItemTxAmt { get; set; }
        public decimal ICTransferItemDiscAmt { get; set; }
        public decimal ICTransferItemNetAmt { get; set; }
        public decimal ICTransferItemAmtTot { get; set; }
        public decimal ICTransferItemCostTot { get; set; }
        public string ICTransferItemStatus { get; set; } = "New";
        public decimal ICTransferItemAmt { get; set; }
        public decimal ICTransferItemCAmt { get; set; }
        public string ICTransferItemLotNo { get; set; } = string.Empty;
        public int FK_PPWOID { get; set; }
        public int FK_PPPrdQCItemID { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public int FK_ICWeightUOMID { get; set; }
        public int FK_ICVolumeUOMID { get; set; }
        public decimal ICTransferItemWTot { get; set; }
        public decimal ICTransferItemVTot { get; set; }
        public Nullable<DateTime> ICTransferItemExpireDate { get; set; }
        public string GLTOF01Combo { get; set; } = string.Empty;
        public string GLTOF02Combo { get; set; } = string.Empty;
        public string GLTOF03Combo { get; set; } = string.Empty;
        public string GLTOF04Combo { get; set; } = string.Empty;
        public string GLTOF05Combo { get; set; } = string.Empty;
        public string GLTOF06Combo { get; set; } = string.Empty;
        public string GLTOF07Combo { get; set; } = string.Empty;
        public string GLTOF08Combo { get; set; } = string.Empty;
        public string GLTOF09Combo { get; set; } = string.Empty;
        public string GLTOF10Combo { get; set; } = string.Empty;
        public int FK_ICReceiptItemID { get; set; }
        public int FK_ICFromStockSlotID { get; set; }
        public int FK_ICToStockSlotID { get; set; }
        public int FK_PPProductionOrdrEstRMID { get; set; }
        public string ICTransferItemFGLotNo { get; set; } = string.Empty;
        public int FK_ICProductIDWO { get; set; }
        public string GLTOF11Combo { get; set; } = string.Empty;
        public string GLTOF12Combo { get; set; } = string.Empty;
        public string GLTOF13Combo { get; set; } = string.Empty;
        public string GLTOF14Combo { get; set; } = string.Empty;
        public string GLTOF15Combo { get; set; } = string.Empty;
        public decimal ICTransferItemAdjStkQty { get; set; }
        public int FK_ICTransferOSInItemID { get; set; }
        public Boolean ICTransferItemIsIdentifyCost { get; set; }
        public decimal ICTransferItemInvQty { get; set; }
        public string ICTransferItemBarCodeNo { get; set; } = string.Empty;
        public byte[] ICTransferItemBarCode { get; set; }
        public decimal ICTransferItemNeedQCQty { get; set; }
        public decimal ICTransferItemNeedQCStkQty { get; set; }
        public int FK_ARSOID { get; set; }
        public decimal ICTransferItemActQty { get; set; }
        public int FK_ICProductParentID { get; set; }
        public decimal ICTransferItemOrgQty { get; set; }

    }
}
