using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.AR
{
    public class APPriceListsInfo : NumberRecord
    {
        [JsonPropertyName("employeeNo")]
        public string employeeNo { get; set; }
        [JsonPropertyName("employeeName")]
        public string employeeFullName { get; set; }
        public int APPriceListID { get; set; }
        public string APPriceListNo { get; set; }
        public string APPriceListName { get; set; }
        public string APPriceListDesc { get; set; }
        public int FK_APSupplierID { get; set; }
        public string APSupplierNo { get; set; }
        public string APSupplierName { get; set; }
        public Nullable<DateTime> APPriceListStartDate { get; set; }
        public Nullable<DateTime> APPriceListEndDate { get; set; }
        public bool APPriceListActiveCheck { get; set; }
        public string ApprovalStatusCombo { get; set; }
        public int FK_ADApprovalProcStepID { get; set; }
        public int displayReject { get; set; }
        public int ADInboxItemID { get; set; }
    }
}
