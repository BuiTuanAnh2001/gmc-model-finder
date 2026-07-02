using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using gmc_api.Base.dto;

namespace gmc_api.DTO.ROProductionOrdr
{
    public class ROItemResponses
    {
        [JsonPropertyName("itemId")]
        public int ICROItemID { get; set; }
        [JsonPropertyName("tppbtpId")]
        public int FK_ICProductIDWO { get; set; }
        [JsonPropertyName("tpbtpNo")]
        public string tpbtpNo { get; set; }
        [JsonPropertyName("tpbtpName")]
        public string tpbtpName { get; set; }
        [JsonPropertyName("fglotNo")]
        public string ICROItemFGLotNo { get; set; }
        [JsonPropertyName("productId")]
        public int FK_ICProductID { get; set; }
        [JsonPropertyName("productNo")]
        public string ICProductNo { get; set; }
        [JsonPropertyName("productName")]
        public string ICProductName { get; set; }
        [JsonPropertyName("qty")]
        public decimal ICROItemQty { get; set; }
        [JsonPropertyName("stkqty")]
        public decimal ICROItemStkQty { get; set; }
        [JsonPropertyName("uomId")]
        public int FK_ICUOMID { get; set; }
        [JsonPropertyName("uomNo")]
        public string ICUOMNo { get; set; }
        [JsonPropertyName("uomName")]
        public string ICUOMName { get; set; }
        [JsonPropertyName("stockId")]
        public int FK_ICStockID { get; set; }
        [JsonPropertyName("stockNo")]
        public string ICStockNo { get; set; }
        [JsonPropertyName("stockName")]
        public string ICStockName { get; set; }
        [JsonPropertyName("itemDesc")]
        public string ICROItemDesc { get; set; }
        [JsonPropertyName("phaseId")]
        public int FK_PPPhaseCfgID { get; set; }
        [JsonPropertyName("phaseNo")]
        public string PPPhaseCfgNo { get; set; }
        [JsonPropertyName("phaseName")]
        public string PPPhaseCfgName { get; set; }
        [JsonPropertyName("woId")]
        public int FK_PPWOID { get; set; }
        [JsonPropertyName("woNo")]
        public string PPWONo { get; set; }
        [JsonPropertyName("woName")]
        public string PPWOName { get; set; }
        [JsonPropertyName("lotNo")]
        public string ICROItemLotNo { get; set; }
        [JsonPropertyName("itemFact")]
        public decimal ICROItemFact { get; set; }
        [JsonPropertyName("shpDate")]
        public Nullable<DateTime> ICROItemShpDate { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public int FK_ICStockSlotID { get; set; }
        public string ARSONo { get; set; }
        public decimal ICROItemEstQty { get; set; }
        public decimal ICROItemActQty { get; set; }
        public int FK_ARSOID { get; set; }
    }
}
