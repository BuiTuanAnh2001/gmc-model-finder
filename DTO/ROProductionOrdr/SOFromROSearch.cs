using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using gmc_api.Base.dto;

namespace gmc_api.DTO.ROProductionOrdr
{
    public class SOFromROSearch
    {
        public string ARSONo { get; set; }
        public Nullable<DateTime> fromdate { get; set; }
        public Nullable<DateTime> todate { get; set; }
        public Nullable<DateTime> fromShpdate { get; set; }
        public Nullable<DateTime> toShpdate { get; set; }
        public int FK_ARSellerID { get; set; }
        public int FK_ARCustomerID { get; set; }
        public int FK_BRBranchID { get; set; }


    }
}
