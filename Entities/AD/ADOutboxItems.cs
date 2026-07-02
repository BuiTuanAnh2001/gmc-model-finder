using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ADOutboxItems")]
    public class ADOutboxItems
    {
        [Key]
        public int ADOutboxItemID { get; set; }
        public string AAStatus { get; set; }="Alive";
        public string ADOutboxItemSubject { get; set; } = string.Empty;
        public string ADOutboxItemDocNo { get; set; } = string.Empty;
        public string ADOutboxItemDocType { get; set; } = string.Empty;
        public Nullable<DateTime> ADOutboxItemDate { get; set; } = DateTime.Now;
        public string ADOutboxItemMessage { get; set; } = string.Empty;
        public string ADOutboxItemProtocol { get; set; } = string.Empty;
        public string ADOutboxItemPriorityCombo { get; set; } = string.Empty;
        public int FK_ADFromUserID { get; set; }
        public int FK_HRFromEmployeeID { get; set; }
        public string ADMailToUsers { get; set; } = string.Empty;
        public string ADMailCCUsers { get; set; } = string.Empty;
        public string ADOutboxItemTaskStatusCombo { get; set; } = "New";
        public bool ADOutboxItemUnRead { get; set; } = true;
        public string ADOutboxItemAction { get; set; } = string.Empty;
        public int FK_ADApprovalProcID { get; set; }
        public string ADOutboxItemRemark { get; set; } = string.Empty;
        public int FK_ADApprovalProcStepID { get; set; }
        public int FK_ADToUserID { get; set; } = 0;
        public string ADOutboxItemDocApprovalStatusCombo { get; set; } = "New";
        public string ADOutboxItemTableName { get; set; } = string.Empty;
        public int ADOutboxItemObjectID { get; set; }
        public string ADApprovalTypeCombo { get; set; } = string.Empty;
    }
}
