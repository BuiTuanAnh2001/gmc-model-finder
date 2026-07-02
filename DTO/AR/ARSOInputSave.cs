using gmc_api.Base.dto;
using gmc_api.Entities;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.AR
{
    public class ARSOInputSave
    {
        public ARSOsInfo MainObject { get; set; } = new ARSOsInfo ();
        public List<ARSOItemsInfo> lstARSOItems { get; set; } = new List<ARSOItemsInfo>();
    }
}
