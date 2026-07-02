using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.PP
{
    public class ProductionOrderWebSearch : Paging
    {
        public string no { get; set; } = "";
        public int phaseId { get; set; } = 0;
        public int branchId { get; set; } = 0;
        public int productId { get; set; } = 0;
        public Nullable<DateTime> fromDate { get; set; } = null;
        public Nullable<DateTime> toDate { get; set; } = null;
    }
}
