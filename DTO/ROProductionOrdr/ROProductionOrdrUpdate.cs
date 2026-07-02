using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using gmc_api.Base.dto;

namespace gmc_api.DTO.ROProductionOrdr
{
    public class ROProductionOrdrUpdate
    {
        public int ICROID { get; set; }
        public string ICRONo { get; set; }
        public string ICRODesc { get; set; }
        public int FK_ICStockID { get; set; }
      //  public int FK_GLTranCfgID { get; set; }
        public int FK_HREmployeeID { get; set; }
      //  public int FK_PPWOID { get; set; }
       // public string ApprovalStatusCombo { get; set; }
      //  public int FK_PPProductionOrdrID { get; set; }
      //  public string ICROTransferStatusCombo { get; set; }
        public int FK_ARCustomerID { get; set; }
        public Nullable<DateTime> ICROShpDate { get; set; }
        public string ICROSTAddL1 { get; set; }
        public int FK_BRBranchID { get; set; }
    }
}
