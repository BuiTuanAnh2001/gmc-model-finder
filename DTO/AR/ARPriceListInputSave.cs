using gmc_api.Base.dto;
using gmc_api.Entities;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.AR
{
    public class ARPriceListInputSave
    {
        public ARPriceLists MainObject { get; set; } = new ARPriceLists();
        public List<ARPriceListDetails> lstARPriceListDetails { get; set; } = new List<ARPriceListDetails>();
    }
}
