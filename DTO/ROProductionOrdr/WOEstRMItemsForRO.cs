using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using gmc_api.Base.dto;

namespace gmc_api.DTO.ROProductionOrdr
{
    public class WOEstRMItemsForRO
    {
        [JsonPropertyName("itemId")]
        public int PPWOEstRMItemID { get; set; }
        [JsonPropertyName("tpId")]
        public int FK_ICFGProductID { get; set; }
        [JsonPropertyName("tpNo")]
        public String FGProductNo { get; set; }
        [JsonPropertyName("tpName")]
        public String FGProductName { get; set; }
        [JsonPropertyName("productParentId")]
        public int FK_ICProductParentID { get; set; }
        [JsonPropertyName("productParentNo")]
        public String ProductParentNo { get; set; }
        [JsonPropertyName("productParentName")]
        public String ProductParentName { get; set; }
        [JsonPropertyName("nvlId")]
        public int FK_ICProductID { get; set; }
        [JsonPropertyName("nvlNo")]
        public String ProductNVLNo { get; set; }
        [JsonPropertyName("nvlName")]
        public String ProductNVLName { get; set; }
        [JsonPropertyName("qty")]
        public decimal PPWOEstRMItemQty { get; set; }
        [JsonPropertyName("uomId")]
        public int FK_ICUOMID { get; set; }
        [JsonPropertyName("uomNo")]
        public String UOMNo { get; set; }
        [JsonPropertyName("uomName")]
        public String UOMName { get; set; }
        [JsonPropertyName("stkQty")]
        public decimal PPWOEstRMItemStkQty { get; set; }
        [JsonPropertyName("stkUomId")]
        public int FK_ICStkUOMID { get; set; }
        [JsonPropertyName("stkUomNo")]
        public String StkUOMNo { get; set; }
        [JsonPropertyName("stkUomName")]
        public String StkUOMName { get; set; }
        [JsonPropertyName("itemFact")]
        public decimal PPWOEstRMItemFact { get; set; }
        [JsonPropertyName("invQty")]
        public decimal PPWOEstRMItemInvQty { get; set; }
        [JsonPropertyName("rQty")]
        public decimal PPWOEstRMItemRQty { get; set; }
        [JsonPropertyName("phaseId")]
        public int FK_PPPhaseCfgID { get; set; }
        [JsonPropertyName("phaseNo")]
        public String PPPhaseCfgNo { get; set; }
        [JsonPropertyName("phaseName")]
        public String PPPhaseCfgName { get; set; }
        [JsonPropertyName("stockId")]
        public int FK_ICStockID { get; set; }
        [JsonPropertyName("stocko")]
        public String ICStockNo { get; set; }
        [JsonPropertyName("stockName")]
        public String ICStockName { get; set; }
    }
}
