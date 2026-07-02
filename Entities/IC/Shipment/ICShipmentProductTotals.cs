using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICShipmentProductTotals")]
    public class ICShipmentProductTotals : FixFiveProps
    {
        [Key]
        public int ICShipmentProductTotalID { get; set; }
        public Boolean AASelected { get; set; }
        public int FK_ICShipmentID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICUOMID { get; set; }
        public decimal ICShipmentProductTotalQty { get; set; }
        public decimal ICShipmentProductTotalActQty { get; set; }
        public decimal ICShipmentProductTotalDiftQty { get; set; }
        public string ICShipmentProductTotalAllocateTypeCombo { get; set; }
        public int FK_ICProductFGID { get; set; }

    }
}
