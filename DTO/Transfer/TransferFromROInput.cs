using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.Transfer
{
    public class TransferFromROInput
    {
        public int transConfgId { get; set; }
        public string no { get; set; }
        public int fk_employee { get; set; }
        public int fromSktId { get; set; }
        public int toSktId { get; set; }
        public string description { get; set; }
        public int branchId { get; set; }
        public bool isPassWaringStock { get; set; } = false;
        public Nullable<DateTime> transferDate { get; set; }
        public string roListID { get; set; }
        [JsonPropertyName("items")]
        public List<TransferItemFromInput> items { get; set; }
    }
}
