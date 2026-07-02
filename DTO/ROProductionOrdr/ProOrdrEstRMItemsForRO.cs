using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using gmc_api.Base.dto;

namespace gmc_api.DTO.ROProductionOrdr
{
    public class ProOrdrEstRMItemsForRO
    {
        [JsonPropertyName("itemId")]
        public int PPProductionOrdrEstRMID { get; set; }
        [JsonPropertyName("nvlId")]
        public int FK_ICProductID { get; set; }
        [JsonPropertyName("nvlNo")]
        public String ProductNVLNo { get; set; }
        [JsonPropertyName("nvlName")]
        public String ProductNVLName { get; set; }
        [JsonPropertyName("lotNo")]
        public String PPProductionOrdrEstRMLotNo { get; set; }
        [JsonPropertyName("rqty")]
        public decimal PPProductionOrdrEstRMRQty { get; set; }
        [JsonPropertyName("qty")]
        public decimal PPProductionOrdrEstRMQty { get; set; }
        [JsonPropertyName("stockId")]
        public int FK_ICStockID { get; set; }
        [JsonPropertyName("stocko")]
        public String ICStockNo { get; set; }
        [JsonPropertyName("stockName")]
        public String ICStockName { get; set; }
        [JsonPropertyName("invQty")]
        public decimal PPProductionOrdrEstRMInvQty { get; set; }
        [JsonPropertyName("fact")]
        public decimal PPProductionOrdrEstRMFact { get; set; }
        [JsonPropertyName("tpId")]
        public int FK_ICFGProductID { get; set; }
        [JsonPropertyName("tpNo")]
        public String FGProductNo { get; set; }
        [JsonPropertyName("tpName")]
        public String FGProductName { get; set; }
        [JsonPropertyName("fgLotNo")]
        public String PPProductionOrdrEstRMFGLotNo { get; set; }

    }
}
