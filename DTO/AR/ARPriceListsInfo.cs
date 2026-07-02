using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.AR
{
    public class ARPriceListsInfo : NumberRecord
    {
        [JsonPropertyName("employeeNo")]
        public string employeeNo { get; set; }
        [JsonPropertyName("employeeName")]
        public string employeeFullName { get; set; }
        public int ARPriceListID { get; set; }
        public string ARPriceListNo { get; set; }
        public string ARPriceListName { get; set; }
        public string ARPriceListDesc { get; set; }
        public Nullable<DateTime> ARPriceListStartDate { get; set; }
        public Nullable<DateTime> ARPriceListEndDate { get; set; }
        public Nullable<DateTime> ARPriceListDate { get; set; }
        public bool ARPriceListActiveCheck { get; set; }
        public string AACreatedUser { get; set; }
        public string ApprovalStatusCombo { get; set; }
        public int FK_ADApprovalProcStepID { get; set; }
        public int displayReject { get; set; }
        public int ADInboxItemID { get; set; }
        public int FK_ARCustomerID { get; set; }
    }
}
