using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class ShipmentFromDirectInput
    {
        public int transConfgId { get; set; }
       // public int transOrgConfigId { get; set; }
        public string no { get; set; }
        public string description { get; set; } = "";
        public int employeeId { get; set; }
        public int branchId { get; set; }
        public int currencyId { get; set; } = 0;
        public decimal excRate { get; set; } = 0;
        public Nullable<DateTime> receiptDate { get; set; } = DateTime.Now;
        public int stockId { get; set; }
        public string destination { get; set; } = "";
        public string stAddL1 { get; set; }
        public int customerID { get; set; }
        [JsonPropertyName("items")]
        public List<ShipmentItemFromDirectInput> items { get; set; }
    }
}
