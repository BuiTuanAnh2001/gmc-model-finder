using gmc_api.Base.dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("HRLevs")]
    public class HRLevs : FixFiveProps
    {
        [Key]
        public int HRLevID { get; set; }
        public string HRLevNo { get; set; }
        public string HRLevName { get; set; }
        public string HRLevDesc { get; set; }
        public decimal HRLevDay { get; set; }

    }
}
