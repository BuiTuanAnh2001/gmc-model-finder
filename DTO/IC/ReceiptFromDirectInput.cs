using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class ReceiptFromDirectInput
    {
        public int transConfgId { get; set; }
       // public int transOrgConfigId { get; set; }
        public string no { get; set; }
        public string description { get; set; }
        public int nccId { get; set; }
        public int employeeId { get; set; }
        public int branchId { get; set; }
        public int currencyId { get; set; }
        public decimal excRate { get; set; }
        public Nullable<DateTime> receiptDate { get; set; } = DateTime.Now;
        public int stockId { get; set; }
        [JsonPropertyName("items")]
        public List<ReceiptItemFromDirectInput> items { get; set; }
        //   public int items { get; set; }
    }
}
