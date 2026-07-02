using gmc_api.Base.dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ADSendEMailCfgs")]
    public class ADSendEMailCfgs 
    {
        [Key]
        public int ADSendEMailCfgID { get; set; }
        public string ADSendEMailCfgSMTP { get; set; }
        public int ADSendEMailCfgPort { get; set; }
        public int ADSendEMailCfgTLS { get; set; }
        public string ADSendEMailCfgEmail { get; set; }
        public string ADSendEMailCfgPass { get; set; }
    }
}
