using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class CustomerBasic
    {
        [JsonPropertyName("customerid")]
        public int ARCustomerID { get; set; }
        [JsonPropertyName("customerNo")]
        public string ARCustomerNo { get; set; }
        [JsonPropertyName("customerName")]
        public string ARCustomerName { get; set; }

    }
}
