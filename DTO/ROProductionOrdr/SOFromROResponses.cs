using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using gmc_api.Base.dto;

namespace gmc_api.DTO.ROProductionOrdr
{
    public class SOFromROResponses
    {
        public int ARSOID { get; set; }
        public string ARSONo { get; set; }
        public string ARSOName { get; set; }
        public Nullable<DateTime> ARSODate { get; set; }
        public string ARSODesc { get; set; }
        public int FK_ARCustomerID { get; set; }
        public string ARCustomerNo { get; set; }
        public string ARCustomerName { get; set; }
        public decimal ARSOAmtTot { get; set; }
        public int FK_ARSellerID { get; set; }
        public string ARSellerNo { get; set; }
        public string ARSellerName { get; set; }
        public int FK_BRBranchID { get; set; }
        public string BRBranchNo { get; set; }
        public string BRBranchName { get; set; }
        public Nullable<DateTime> ARSOShpDate { get; set; }
        public string ARSOBTAddL1 { get; set; }
    }
}
