using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ADDocHistorys")]
    public class ADDocHistorys
    {
        [Key]
        public int ADDocHistoryID { get; set; }
        public string AAStatus { get; set; }
        public string DocNo { get; set; }
        public string DocType { get; set; }
        public Nullable<DateTime> Date { get; set; }
        public string UserName { get; set; }
        public string Action { get; set; }
        public int FK_ADApprovalProcID { get; set; }
        public int FK_ADApprovalProdStepID { get; set; }
        public string Remark { get; set; }
        public string TableName { get; set; }
        public int ObjectID { get; set; }
        public string ADApprovalTypeCombo { get; set; }
        public string PositionNo { get; set; }
    }
}
