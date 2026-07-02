using gmc_api.Base.dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ICLotSegments")]
    public class ICLotSegments : FixFiveProps
    {
        [Key]
        public int ICLotSegmentID { get; set; }
        public int FK_ICLotID { get; set; }
        public string ICLotSegmentName { get; set; }
        public string ICLotSegmentDesc { get; set; }
        public string ICLotSegmentTypeCombo { get; set; }
        public string ICLotSegmentValue { get; set; }
        public string ICLotSegmentTableName { get; set; }
        public string ICLotSegmentColumnName { get; set; }
        public string ICLotSegmentSeperatorCombo { get; set; }
        public string ICLotSegmentFormat { get; set; }
        public string ICLotSegmentRelationColumnName { get; set; }
        public int ICLotSegmentSortOrder { get; set; }

    }
}
