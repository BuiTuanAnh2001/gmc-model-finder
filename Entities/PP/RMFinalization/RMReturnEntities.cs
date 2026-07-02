using System.Collections.Generic;

namespace gmc_api.Entities
{
    public class RMReturnEntities
    {
        public PPRMReturnsInfo MainObject { get; set; } = new PPRMReturnsInfo();
        public PPRMReturnItemsInfo ItemObject { get; set; } = new PPRMReturnItemsInfo();
        public PPRMReturnTotalsInfo objTotalCal { get; set; } = new PPRMReturnTotalsInfo();
        public List<PPRMReturnItemsInfo> lstPPRMReturnItems { get; set; } = new List<PPRMReturnItemsInfo>();
        public List<PPRMReturnTotalsInfo> lstPPRMReturnTotals { get; set; } = new List<PPRMReturnTotalsInfo>();
    }
}
