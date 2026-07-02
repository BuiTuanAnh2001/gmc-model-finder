using gmc_api.Base.dto;
using gmc_api.Entities;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PO
{
    public class APPOInputSave
    {
        public APPOsInfo MainObject { get; set; } = new APPOsInfo();
        public List<POItemsEntity> lstAPPOItems { get; set; } = new List<POItemsEntity>();
        public List<APPRPOsInfo> lstAPPRPOs { get; set; } = new List<APPRPOsInfo>();
        public List<APPOPurchaseCostItemsEntity> lstAPPOPurchaseCostItems { get; set; } = new List<APPOPurchaseCostItemsEntity>();
    }
}
