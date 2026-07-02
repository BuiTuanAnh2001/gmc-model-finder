using gmc_api.Base.Helpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class ProdRstUpdateRequest
    {
        public string description { get; set; } = Constants.DEFAULT_VALUE_STRING;
        //public DateTime ordDate { get; set; }
        public Nullable<DateTime> estStartDate { get; set; } = Constants.DEFAULT_VALUE_DATETIME;
        public Nullable<DateTime> estEndDate { get; set; } = Constants.DEFAULT_VALUE_DATETIME;
        public Nullable<DateTime> actStartDate { get; set; } = Constants.DEFAULT_VALUE_DATETIME;
        public Nullable<DateTime> actEndDate { get; set; } = Constants.DEFAULT_VALUE_DATETIME;
        public int employeeId { get; set; } = Constants.DEFAULT_VALUE_INT;
        public int transConfgId { get; set; }= Constants.DEFAULT_VALUE_INT;
        public Nullable<DateTime> ordrDate { get; set; } = null;

        [JsonPropertyName("detail")]
        public List<ProdRstItemsUpdate> detail { get; set; }

    }
}
