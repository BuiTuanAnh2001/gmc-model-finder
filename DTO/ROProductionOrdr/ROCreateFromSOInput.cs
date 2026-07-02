using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using gmc_api.Base.dto;
using gmc_api.DTO.dto;
using gmc_api.DTO.IC;

namespace gmc_api.DTO.ROProductionOrdr
{
    public class ROCreateFromSOInput
    {
        public int transConfgId { get; set; }
        public string no { get; set; }
        public string description { get; set; }
        public int employeeId { get; set; }
        public int branchId { get; set; }
        //public int currencyId { get; set; }
        // public decimal excRate { get; set; }
        public int stockId { get; set; }
        public int customerId { get; set; }
        public Nullable<DateTime> roDate { get; set; } = null;
        public Nullable<DateTime> shpDate { get; set; } = null;
        public string address { get; set; }
        //   public string statusCombo { get; set; }
        public string soListID { get; set; }
        [JsonPropertyName("items")]
        public List<ROItemFromInput> items { get; set; }

    }
}
