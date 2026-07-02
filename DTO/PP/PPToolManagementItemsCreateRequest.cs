using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPToolManagementItemsCreateRequest
    {
        [JsonPropertyName("toolManagementItemId")]
        public int PPToolManagementItemID { get; set; }
        [JsonPropertyName("productionOrdrEstFGId")]
        public int FK_PPProductionOrdrEstFGID { get; set; }
        [JsonPropertyName("toolId")]
        public int FK_ICToolProductID { get; set; }
        [JsonPropertyName("toolSatus")]
        public string PPToolManagementItemStatus { get; set; }
        [JsonPropertyName("aAStatus")]
        public string AAStatus { get; set; }
        [JsonPropertyName("replaceItemID")]
        public int FK_PPToolManagementItemID { get; set; }
        [JsonPropertyName("jobTicketId")]
        public int FK_PPProductionOrdrID { get; set; }
        [JsonPropertyName("useStatus")] 
        public int  PPToolManagementItemUseStatus{ get; set; }
    }
}
