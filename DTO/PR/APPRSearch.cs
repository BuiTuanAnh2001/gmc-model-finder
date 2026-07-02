using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PR
{
    public class APPRSearch
    {
        public string DocNo { get; set; } = string.Empty;
        public int FK_BRBranchID { get; set; }
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_ICProductID { get; set; }

    }
}
