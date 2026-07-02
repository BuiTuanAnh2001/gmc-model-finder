using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.RO
{
    public class ROForShipment
    {
        [JsonPropertyName("id")]
        public int ICROID { get; set; }
        [JsonPropertyName("no")]
        public string ICRONo { get; set; }
        [JsonPropertyName("roDate")]
        public Nullable<DateTime> ICRODate { get; set; }
        [JsonPropertyName("description")]
        public string ICRODesc { get; set; }
        [JsonPropertyName("fk_stock")]
        public int FK_ICStockID { get; set; }
        [JsonPropertyName("fk_customer")]
        public int FK_ARCustomerID { get; set; }
        [JsonPropertyName("fk_branch")]
        public int FK_BRBranchID { get; set; }
        [JsonPropertyName("fk_currency")]
        public int FK_GECurrencyID { get; set; }
        [JsonPropertyName("excRate")]
        public decimal ICROExcRate { get; set; }
        public string ARSONo { get; set; }
    }
}
