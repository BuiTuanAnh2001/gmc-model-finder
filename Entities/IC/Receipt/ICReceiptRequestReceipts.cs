using gmc_api.Base.dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities.IC.Receipt
{
    [Table("ICReceiptRequestReceipts")]
    public class ICReceiptRequestReceipts : FixFiveProps
    {
        [Key]
        public int ICReceiptRequestReceiptID { get; set; }
        public int FK_ICReceiptID { get; set; }
        public int FK_ICRequestReceiptID { get; set; }

    }
}
