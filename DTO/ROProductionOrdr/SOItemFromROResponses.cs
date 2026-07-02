using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using gmc_api.Base.dto;

namespace gmc_api.DTO.ROProductionOrdr
{
    public class SOItemFromROResponses
    {
        public int ARSOItemID { get; set; }
        public int FK_ICProductID { get; set; }
        public string ICProductNo { get; set; }
        public string ICProductName { get; set; }
        public decimal ARSOItemRStkQty { get; set; }
        public decimal ARSOItemShpQty { get; set; }
        public decimal ARSOItemShpPlanRQty { get; set; }
        public decimal ARSOItemOnProductionQty { get; set; }
        public decimal ARSOItemQty { get; set; }
        public decimal ARSOItemStkQty { get; set; }
        public int FK_ICStockID { get; set; }
        public decimal ARSOItemFUnitPrice { get; set; }
        public decimal ARSOItemUnitPrice { get; set; }
        public decimal ARSOItemFPrice { get; set; }
        public decimal ARSOItemPrice { get; set; }
        public int FK_ICUOMID { get; set; }
        public string ICUOMNo { get; set; }
        public string ICUOMName { get; set; }
        public decimal ARSOItemDocRQty { get; set; }
        public decimal ARSOItemRQty { get; set; }
        public decimal ARSOItemExcQty { get; set; }
        public decimal ARSOItemOrgQty { get; set; }
        public Nullable<DateTime> ARSOItemShpDate { get; set; }
        public decimal ARSOItemDiscAmt { get; set; }
        public int FK_ARCampaignID { get; set; }
        public decimal ARSOItemAdjStkQty { get; set; }
        public Nullable<DateTime> ARSOItemPPFinishDate { get; set; }
        public decimal ARSOItemPPFinishQty { get; set; }
        public decimal ARSOItemFact { get; set; }
        public int FK_ICStockSlotID { get; set; }
        public int FK_ICStkUOMID { get; set; }
    }
}
