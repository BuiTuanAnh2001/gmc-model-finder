using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("PPQCParamResultItems")]
    public class PPQCParamResultItems
    {
        [Key]
        public int PPQCParamResultItemID { get; set; }
        public int FK_PPQCParamResultID { get; set; }
        public int FK_PPQCParamID { get; set; }
        public decimal PPQCParamResultItemMinValue { get; set; }
        public decimal PPQCParamResultItemMaxValue { get; set; }
        public string PPQCParamResultItemValue { get; set; }
        public decimal PPQCParamResultItemInternalMinValue { get; set; }
        public decimal PPQCParamResultItemInternalMaxValue { get; set; }
        public string PPQCParamResultItemDefaultValue { get; set; }
        public decimal PPQCParamResultItemRollNumber { get; set; }
        public string PPQCParamResultItemDesc { get; set; }
        public string  AAStatus { get; set; }

    }
}
