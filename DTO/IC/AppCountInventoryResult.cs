using gmc_api.Entities;
using System;
using System.Collections.Generic;

namespace gmc_api.DTO.PP
{
    public class AppCountInventoryResult
    {
        public ICCountInventoryResultsInfo MainObject
        { get; set; } = new ICCountInventoryResultsInfo();
        public ICCountInventoryResultItemsInfo ItemObject { get; set; } = new ICCountInventoryResultItemsInfo();
        public List<ICCountInventoryResultItemsInfo> lstICCountInventoryResultItems
        { get; set; } = new List<ICCountInventoryResultItemsInfo>();
    }
}
