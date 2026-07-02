using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.Inventoty
{
    public class StkQtyByProductAndStockInfo
    {
        [JsonPropertyName("productId")]
        public int FK_ICProductID { get; set; } = 0;
        [JsonPropertyName("stockId")]
        public int FK_ICStockID { get; set; } = 0;
        [JsonPropertyName("productType")]
        public int FK_ICProductTypeID { get; set; } = 0;
        [JsonPropertyName("productGroupType")]
        public int FK_ICProductGroupID { get; set; } = 0;
        [JsonPropertyName("stockType")]
        public int FK_ICStockTypeID { get; set; } = 0;
        [JsonPropertyName("prdDimention1")]
        public int FK_ICProductDimention1ID { get; set; } = 0;
        [JsonPropertyName("prdDimention2")]
        public int FK_ICProductDimention2ID { get; set; } = 0;
        [JsonPropertyName("prdDimention3")]
        public int FK_ICProductDimention3ID { get; set; } = 0;
        [JsonPropertyName("prdDimention4")]
        public int FK_ICProductDimention4ID { get; set; } = 0;
        [JsonPropertyName("prdDimention5")]
        public int FK_ICProductDimention5ID { get; set; } = 0;
        [JsonPropertyName("branchId")]
        public int FK_BRBranchID { get; set; } = 0;
        [JsonPropertyName("fromDate")]
        public Nullable<DateTime> fromDate { get; set; } = DateTime.Now;
        [JsonPropertyName("toDate")]
        public Nullable<DateTime> toDate { get; set; } = DateTime.Now;
    }
}
