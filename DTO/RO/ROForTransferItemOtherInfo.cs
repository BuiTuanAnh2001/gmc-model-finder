using gmc_api.DTO.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.RO
{
    public class ROForTransferItemOtherInfo
    {
        [JsonPropertyName("itemId")]
        public int itemId { get; set; }
        [JsonPropertyName("fromSktId")]
        public int fromSktId { get; set; }
        [JsonPropertyName("toSktId")]
        public int toSktId { get; set; }

    }
}
