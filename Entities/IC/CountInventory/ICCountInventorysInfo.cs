using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICCountInventorys")]
    public class ICCountInventorysInfo
    {
        [Key]
        public int ICCountInventoryID
        { get; set; }
        public Nullable<DateTime> AACreatedDate
        { get; set; }
        public String AACreatedUser { get; set; } = String.Empty;
        public Nullable<DateTime> AAUpdatedDate
        { get; set; }
        public String AAUpdatedUser { get; set; } = String.Empty;
        public String AAStatus { get; set; } = "Alive";
        public bool AASelected
        { get; set; } = true;
        public String AAModule { get; set; } = String.Empty;
        public int FK_GECurrencyID
        { get; set; }
        public String ICCountInventoryNo { get; set; } = String.Empty;
        public String ICCountInventoryName { get; set; } = String.Empty;
        public String ICCountInventoryDesc { get; set; } = String.Empty;
        public DateTime ICCountInventoryDate
        { get; set; } = DateTime.Now;
        public String ICCountInventoryTypeCombo { get; set; } = String.Empty;
        public String ICCountInventoryStatusCombo { get; set; } = "New";
        public int FK_ICStockID
        { get; set; }
        public int FK_BRBranchID
        { get; set; }
        public int FK_GLTranCfgID
        { get; set; }
        public int FK_HREmployeeID
        { get; set; }
    }
}
