using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.PP
{
    public class JobticketItemForPrdRst
    {
        [JsonPropertyName("itemId")]
        public int PPProductionOrdrEstFGID { get; set; }
        [JsonPropertyName("lotNo")]
        public string PPProductionOrdrEstFGLotNo { get; set; }
        [JsonPropertyName("productId")]
        public int FK_ICProductID { get; set; }
        [JsonPropertyName("productName")]
        public string productName { get; set; }
        [JsonPropertyName("productNo")]
        public string productNo { get; set; }
        [JsonPropertyName("phaseId")]
        public int FK_PPPhaseCfgID { get; set; }
        [JsonPropertyName("resourceId")]
        public int FK_PPResourceID { get; set; }
        [JsonPropertyName("unitId")]
        public int FK_ICUOMID { get; set; }
        [JsonPropertyName("unitStockId")]
        public int FK_ICStkUOMID { get; set; }
        
        [JsonPropertyName("qty")]
        public decimal PPProductionOrdrEstFGQty { get; set; }
        [JsonPropertyName("mfQty")]
        public decimal PPProductionOrdrEstFGMFQty { get; set; }
        [JsonPropertyName("remainQty")]
        public decimal PPProductionOrdrEstFGRQty { get; set; }
        [JsonPropertyName("stockId")]
        public int FK_ICStockID { get; set; }
        [JsonPropertyName("shipDate")]
        public Nullable<DateTime> PPProductionOrdrEstFGFODate { get; set; }
        [JsonPropertyName("productDate")]
        public Nullable<DateTime> PPProductionOrdrEstFGPlanDate { get; set; }
        [JsonPropertyName("inputStockItemQty")]
        public decimal inputStockItemQty { get; set; }
        [JsonPropertyName("ncQty")]
        public decimal PPProductionOrdrEstFGNCRQty { get; set; }
        [JsonPropertyName("cancelQty")]
        public decimal PPProductionOrdrEstFGCQty { get; set; }
        [JsonPropertyName("setupQty")]
        public decimal PPProductionOrdrEstFGSetupQty { get; set; }
        [JsonPropertyName("qcStatus")]
        public string PPProductionOrdrEstFGQCStatusCombo { get; set; }
        [JsonPropertyName("qcDescription")]
        public string PPProductionOrdrEstFGQCDesc { get; set; }
        [JsonPropertyName("routingId")]
        public int FK_PPRoutingID{ get; set; }
        [JsonPropertyName("startTime")]
        public Nullable<DateTime> PPProductionOrdrEstFGStarTime { get; set; }
        [JsonPropertyName("endTime")]
        public Nullable<DateTime> PPProductionOrdrEstFGEndTime { get; set; }
        [JsonPropertyName("description")]
        public string PPProductionOrdrEstFGDesc { get; set; }
        [JsonPropertyName("fact")]
        public decimal PPProductionOrdrEstFGFact { get; set; }
        [JsonPropertyName("downTimeQty")]
        public decimal PPProductionOrdrEstFGDownTimeQty { get; set; }
    }
}
