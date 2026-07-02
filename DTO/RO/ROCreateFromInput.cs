using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class ROCreateFromInput
    {
        public int transConfgId { get; set; }
        public string no { get; set; } = string.Empty;
        public string description { get; set; }=string.Empty;
        public int employeeId { get; set; }
        public int branchId { get; set; }
        public int currencyId { get; set; }
        public decimal excRate { get; set; }
        public int stockId { get; set; }
        public Nullable<DateTime> roDate { get; set; } = null;
        public int productionOrdrId { get; set; }
        public string statusCombo { get; set; } = "New";
        public string woListID { get; set; }=string.Empty;
        [JsonPropertyName("items")]
        public List<ROItemFromInput> items { get; set; }
        //   public int items { get; set; }
    }
}
