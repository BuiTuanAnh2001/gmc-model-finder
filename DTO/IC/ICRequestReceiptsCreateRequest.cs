using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class ICRequestReceiptsCreateRequest 
    {
        public string description { get; set; }
        public int transConfgId { get; set; } = 0;
        public int transOrgConfigId { get; set; } = 0;
        public string no { get; set; }
        public int employeeId { get; set; } = 0;
        public int stockId { get; set; } = 0;
        public Nullable<DateTime> reqDate { get; set; } = null;
        public bool option { get; set; }
    }
}
