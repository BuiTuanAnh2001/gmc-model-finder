using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICShipmentProductAllocates")]
    public class ICShipmentProductAllocates : FixFiveProps
    {
        [Key]
        public int ICShipmentProductAllocateID { get; set; }
        public Boolean AASelected { get; set; }
        public int FK_ICShipmentProductTotalID { get; set; }
        public int FK_ICFGProductID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_PPWOID { get; set; }
        public int FK_ARSOID { get; set; }
        public int FK_ARSOItemID { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_PPProductionOrdrEstRMID { get; set; }
        public decimal ICShipmentProductAllocateQty { get; set; }
        public decimal ICShipmentProductAllocateActQty { get; set; }
        public decimal ICShipmentProductAllocateDiftQty { get; set; }
        public int ICShipmentProductAllocateLine { get; set; }

    }
}
