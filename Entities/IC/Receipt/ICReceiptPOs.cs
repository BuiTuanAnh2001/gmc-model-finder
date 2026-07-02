using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ICReceiptPOs")]
    public class ICReceiptPOs
    {
        [Key]
        public int ICReceiptPOID { get; set; }
        public string AAStatus { get; set; } = string.Empty;
        public int FK_APPOID { get; set; }
        public int FK_ICReceiptID { get; set; }
    }
}
