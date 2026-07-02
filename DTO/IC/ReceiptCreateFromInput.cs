using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class ReceiptCreateFromInput
    {
        public int transConfgId { get; set; }
        public int transOrgConfigId { get; set; }
        public string no { get; set; }
        public string description { get; set; }
        public int nccId { get; set; }
        public int employeeId { get; set; }
        public int branchId { get; set; }
        public int currencyId { get; set; }
        public decimal excRate { get; set; }
        public int stockId { get; set; }
        public Nullable<DateTime> docDate { get; set; } = null;
        public bool isPassWaringStock { get; set; } = false;
        public string poListID { get; set; }
        [JsonPropertyName("items")]
        public List<ReceiptItemFromInput> items { get; set; }
        //   public int items { get; set; }
    }
}
