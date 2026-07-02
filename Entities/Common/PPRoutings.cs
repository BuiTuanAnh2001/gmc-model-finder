using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("PPRoutings")]
    public class PPRoutings : FixFiveProps
    {
        [Key]
        public int PPRoutingID { get; set; }
        public Boolean AASelected { get; set; }
        public string PPRoutingNo { get; set; }
        public string PPRoutingDesc { get; set; }
        public Nullable<DateTime> PPRoutingDate { get; set; }
        public string PPRoutingRevision { get; set; }
        public int FK_ARCustomerID { get; set; }
        public int FK_HREmployeeID { get; set; }
        public decimal PPRoutingEstRMCost { get; set; }
        public decimal PPRoutingEstLabourCost { get; set; }
        public decimal PPRoutingEstOverheadCost { get; set; }
        public decimal PPRoutingEstCost { get; set; }
        public string PPRoutingNormRevision { get; set; }
        public string PPRoutingTypeCombo { get; set; }
        public string AAModule { get; set; }
        public int FK_ARCustomerProductReqItemID { get; set; }
        public Boolean PPRoutingActiveCheck { get; set; }

    }
}
