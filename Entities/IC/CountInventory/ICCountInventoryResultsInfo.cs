using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICCountInventoryResults")]
    public class ICCountInventoryResultsInfo
    {
        [Key]
        public int ICCountInventoryResultID
        { get; set; }
        public Nullable<DateTime> AACreatedDate
        { get; set; }
        public String AACreatedUser { get; set; } = String.Empty;
        public Nullable<DateTime> AAUpdatedDate
        { get; set; }
        public String AAUpdatedUser { get; set; } = String.Empty;
        public String AAStatus
        { get; set; } = "Alive";
        public bool AASelected
        { get; set; } = true;
        public String AAModule { get; set; } = String.Empty;
        public int FK_GECurrencyID
        { get; set; }
        public String ICCountInventoryResultNo { get; set; } = String.Empty;
        public String ICCountInventoryResultName { get; set; } = String.Empty;
        public String ICCountInventoryResultDesc { get; set; } = String.Empty;
        public DateTime ICCountInventoryResultDate
        { get; set; } = DateTime.Now;
        public String ICCountInventoryResultTypeCombo { get; set; } = String.Empty;
        public String ICCountInventoryResultStatusCombo { get; set; } = "New";
        public int FK_ICStockID
        { get; set; }
        public int FK_BRBranchID
        { get; set; }
        public int FK_GLTranCfgID
        { get; set; }
        public int FK_HREmployeeID
        { get; set; }
        public int FK_ICCountInventoryID
        { get; set; }
    }
}
