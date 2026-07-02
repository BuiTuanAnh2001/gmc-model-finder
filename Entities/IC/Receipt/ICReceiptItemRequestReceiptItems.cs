using gmc_api.Base.dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities.IC.Receipt
{
    [Table("ICReceiptItemRequestReceiptItems")]
    public class ICReceiptItemRequestReceiptItems : FixFiveProps
    {
        [Key]
        public int ICReceiptItemRequestReceiptItemID { get; set; }
        public int FK_ICReceiptItemID { get; set; }
        public int FK_ICRequestReceiptItemID { get; set; }


    }
}
