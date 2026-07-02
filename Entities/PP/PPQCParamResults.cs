using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("PPQCParamResults")]
    public class PPQCParamResults : FixFiveProps
    {
        [Key]
        public int PPQCParamResultID { get; set; }
        public string PPQCParamResultNo { get; set; }
        public string PPQCParamResultName { get; set; }
        public Nullable<DateTime> PPQCParamResultDate { get; set; }
        public string PPQCParamResultDesc { get; set; }
        public Boolean AASelected { get; set; }
        public int FK_PPProductionOrdrEstFGID { get; set; }
        public int FK_PPProductionOrdrID { get; set; }
        public string PPQCParamResultUser { get; set; }
        public string PPQCParamResultStatus { get; set; }


    }
}
