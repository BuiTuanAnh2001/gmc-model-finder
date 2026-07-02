using System;

namespace gmc_api.DTO.CommonData
{
    public class ADInboxItemInfo
    {
        public int ADInboxItemID { get; set; }
        public Nullable<DateTime> ADInboxItemDate { get; set; } = DateTime.Now;
        public string AAStatus { get; set; } = "Alive";
        public int FK_ADApprovalProcID { get; set; }
        public int FK_ADApprovalProcStepID { get; set; }
        public string ADMailToUsers { get; set; } = string.Empty;
        public string ADMailCCUsers { get; set; } = string.Empty;
        public string type { get; set; } = string.Empty;
        public string ADInboxItemProtocol { get; set; } = string.Empty;
        public string ADInboxItemSubject { get; set; } = string.Empty;
        public string ADInboxItemMessage { get; set; } = string.Empty;
        public int ADInboxItemObjectID { get; set; }
        public string ADInboxItemTableName { get; set; } = string.Empty;
        public string ADInboxItemDocApprovalStatusCombo { get; set; } = string.Empty;
        public string ADInboxItemAction { get; set; } = string.Empty;
        public string ADInboxItemTaskStatusCombo { get; set; } = string.Empty;
        public string ADInboxItemPriorityCombo { get; set; } = string.Empty;
        public string ADInboxItemDocType { get; set; } = string.Empty;
        public string ADInboxItemDocNo { get; set; } = string.Empty;
        public int FK_ADFromUserID { get; set; }
        public int FK_HRFromEmployeeID { get; set; }
        public string ADInboxItemRemark { get; set; } = string.Empty;
        public Nullable<DateTime> ADInboxItemDeadline { get; set; }
        public string ADMailReadUsers { get; set; } = string.Empty;
        public string ADApprovalTypeCombo { get; set; } = string.Empty;


    }
}