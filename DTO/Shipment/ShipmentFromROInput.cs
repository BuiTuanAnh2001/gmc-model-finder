using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.Shipment
{
    public class ShipmentFromROInput
    {
        public int transConfgId { get; set; }
        public int transOrgConfigId { get; set; }
        public int fk_customer { get; set; }
        public int branchId { get; set; }
        public int currencyId { get; set; }
        public string no { get; set; }
        public string description { get; set; }
        public int employeeId { get; set; }
        public decimal excRate { get; set; }
        public int stockId { get; set; }
        public string address { get; set; }
        public string destination { get; set; }
        public bool isPassWaringStock { get; set; } = false;
        public Nullable<DateTime> shipDate { get; set; } 
        public string roListID { get; set; }
        [JsonPropertyName("items")]
        public List<ShipmentItemFromInput> items { get; set; }
    }
}
