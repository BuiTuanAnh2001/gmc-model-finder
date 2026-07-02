using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using gmc_api.Base.dto;

namespace gmc_api.DTO.ROProductionOrdr
{
    public class ROItemUpdate
    {
        public int ICROItemID { get; set; }
        [JsonPropertyName("tppbtpId")]
        public int FK_ICProductIDWO { get; set; }
        public string ICROItemFGLotNo { get; set; }
        [JsonPropertyName("productId")]
        public int FK_ICProductID { get; set; }
        public decimal ICROItemQty { get; set; }
        public decimal ICROItemStkQty { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStockID { get; set; }
        public string ICROItemDesc { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_PPWOID { get; set; }
        public string ICROItemLotNo { get; set; }
      //  public decimal ICROItemFact { get; set; }
        public Nullable<DateTime> ICROItemShpDate { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public int FK_ICStockSlotID { get; set; }
    }
}
