using gmc_api.DTO.AP;
using gmc_api.Entities;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PO
{
    public class APPOItemLoad
    {
       public List<POItemsEntity> lstAPPOItems { get; set; } = new List<POItemsEntity>();
       public List<APPRPOsInfo> lstAPPRPOs { get; set; } = new List<APPRPOsInfo>();
    }
}
