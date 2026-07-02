using gmc_api.Base.dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ICBarCodeSetupItems")]
    public class ICBarCodeSetupItems : FixFiveProps
    {
        [Key]
        public int ICBarCodeSetupItemID { get; set; }
        public int FK_ICBarCodeSetupID { get; set; }
        public string ICBarCodeSetupItemName { get; set; }
        public string ICBarCodeSetupItemDesc { get; set; }
        public string ICBarCodeSetupItemTableName { get; set; }
        public string ICBarCodeSetupItemColumnName { get; set; }
        public string ICBarCodeSetupItemFormat { get; set; }
        public string ICBarCodeSetupItemRelationColumnName { get; set; }
        public int ICBarCodeSetupItemSortOrder { get; set; }

    }
}
