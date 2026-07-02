using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPResourceParamItemsInput
    {
        [JsonPropertyName("toolManagementId")]
        public int PPToolManagementID { get; set; }
       [JsonPropertyName("productionOrdrItemId")]
        public int PPProductionOrdrEstFGID { get; set; }
        [JsonPropertyName("productId")]
        public int FK_ICProductID { get; set; }
        [JsonPropertyName("resourceId")]
        public int FK_PPResourceID { get; set; }
        [JsonPropertyName("jobTicketId")]
        public int PPProductionOrdrID { get; set; }
        [JsonPropertyName("qty")]
        public int PPProductionOrdrEstFGQty { get; set; }
    }
}
