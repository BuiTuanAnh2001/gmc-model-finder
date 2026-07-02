using gmc_api.Base.dto;
using gmc_api.Base.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.Shipment
{
    public class SearchPurchaseReturn 
    {
        public string DocNo { get; set; } = string.Empty;
        public int FK_APSupplierID { get; set; }
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public string APPONo { get; set; } = string.Empty;
    }
}
