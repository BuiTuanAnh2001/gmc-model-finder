using gmc_api.Base.dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ADUserTokens")]
    public class ADUserTokens 
    {
        [Key]
        public int ADUserTokenID { get; set; }
        public string ADUserName { get; set; }
        public string ADUserTokenNotify { get; set; }
        public string ADUserTokenDeviceName { get; set; }
    }
}
