using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class ProdRstCreateRequest
    {
        public string description { get; set; }
        public int transConfgId { get; set; } = 0;
        public int transOrgConfigId { get; set; } = 0;
        public string no { get; set; }
        public Nullable<DateTime> estStartDate { get; set; } = null;
        public Nullable<DateTime> estEndDate { get; set; } = null;
        public Nullable<DateTime> actStartDate { get; set; } = null;
        public Nullable<DateTime> actEndDate { get; set; } = null;
        public int employeeId { get; set; } = 0;
        public Nullable<DateTime> ordrDate { get; set; } = null;

        [JsonPropertyName("detail")]
        public List<ProdRstItemsInfo> detail { get; set; }

    }
}
