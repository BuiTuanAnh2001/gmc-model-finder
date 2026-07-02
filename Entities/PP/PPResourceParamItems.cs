using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("PPResourceParamItems")]
    public class PPResourceParamItems : FixFiveProps
    {
        [Key]

        public int PPResourceParamItemID { get; set; }
        public int FK_PPResourceParamID { get; set; }
        public String PPResourceParamItemDftValue { get; set; }
        public String PPResourceParamItemLastValue { get; set; }
        public String PPResourceParamItemValue { get; set; }
        public int FK_PPProductionOrdrEstFGID { get; set; }
        public bool AASelected { get; set; }
        public bool PPResourceParamItemCheck { get; set; }
        public string PPResourceParamItemNote { get; set; }
        public decimal PPResourceParamItemMinValue { get; set; }
        public decimal PPResourceParamItemMaxValue { get; set; }
    }
}
