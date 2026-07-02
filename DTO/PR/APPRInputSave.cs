using gmc_api.Base.dto;
using gmc_api.Entities;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PR
{
    public class APPRInputSave
    {
        public APPRsInfo MainObject { get; set; } = new APPRsInfo();
        public List<APPRItemsInfo> lstAPPRItems { get; set; } = new List<APPRItemsInfo>();

    }
}
