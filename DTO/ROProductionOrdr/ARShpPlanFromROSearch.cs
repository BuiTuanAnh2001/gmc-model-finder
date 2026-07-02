using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using gmc_api.Base.dto;

namespace gmc_api.DTO.ROProductionOrdr
{
    public class ARShpPlanFromROSearch
    {
        public Nullable<DateTime> fromdate { get; set; }
        public Nullable<DateTime> todate { get; set; }
    }
}
