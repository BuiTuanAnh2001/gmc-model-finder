using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using gmc_api.Base.dto;

namespace gmc_api.DTO.ROProductionOrdr
{
    public class ROProductionOrdrResponses : NumberRecord
    {
        public int ICROID { get; set; }
        public string ICRONo { get; set; }
        public string ICRODesc { get; set; }
        public Nullable<DateTime> ICRODate { get; set; }
        public int FK_ICStockID { get; set; }
        public string ICStockNo { get; set; }
        public string ICStockName { get; set; }
        public int FK_GLTranCfgID { get; set; }
        public string GLTranCfgNo { get; set; }
        public string GLTranCfgName { get; set; }
        public int FK_HREmployeeID { get; set; }
        public string HREmployeeNo { get; set; }
        public string HREmployeeName { get; set; }
        public int FK_PPWOID { get; set; }
        public string PPWONo { get; set; }
        public string PPWOName { get; set; }
        public string ApprovalStatusCombo { get; set; }
        public int FK_PPProductionOrdrID { get; set; }
        public string PPProductionOrdrNo { get; set; }
        public string PPProductionOrdrName { get; set; }
        public string ICROTransferStatusCombo { get; set; }
        public int FK_ARCustomerID { get; set; }
        public string BRBranchNo { get; set; }
        public string BRBranchName { get; set; }
        public string ARCustomerName { get; set; }
        public Nullable<DateTime> ICROShpDate { get; set; }
        public string ARShpPlanNo { get; set; }
        public string ICROSTAddL1 { get; set; }
        public int FK_BRBranchID { get; set; }
    }
}
