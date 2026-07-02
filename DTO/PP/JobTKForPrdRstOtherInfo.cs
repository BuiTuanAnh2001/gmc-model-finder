using gmc_api.DTO.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.PP
{
    public class JobTKForPrdRstOtherInfo
    {
        [JsonPropertyName("transConfig")]
        public List<GLTranCfgBasicInfo> transConfigs { get; set; }
        public int glOrgTranCfgID { get; set; }
        public string glOrgTranCfgName { get; set; }
        [JsonPropertyName("fk_branch")]
        public int brBranchID { get; set; }
        public string jobTicketName { get; set; }
        public Nullable<DateTime> estStartDate { get; set; }
        public Nullable<DateTime> estEndDate { get; set; }
        public int employeeId { get; set; }
    }
}
