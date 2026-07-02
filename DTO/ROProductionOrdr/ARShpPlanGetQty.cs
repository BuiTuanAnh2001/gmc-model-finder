using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using gmc_api.Base.dto;

namespace gmc_api.DTO.ROProductionOrdr
{
    public class ARShpPlanGetQty
    {
        public decimal StkQty { get; set; }
        public decimal Qty { get; set; }
    }
}
