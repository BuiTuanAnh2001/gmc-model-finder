using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.IC
{
    public class AppSearchData
    {
        public string DocNo { get; set; } = string.Empty;
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_ICStockID { get; set; }
        public int FK_GLTranCfgID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_ARCustomerID { get; set; }
        public int FK_HRSectionID { get; set; }
        public int FK_HREmployeeID { get; set; }
        public int FK_ARSOID { get; set; }
        public int FK_ICShipmentID { get; set; }
        public int FK_ICProductID { get; set; }
    }
}
