using System.Collections.Generic;

namespace gmc_api.Entities
{
    public class RMFinalizationEntities
    {
        public PPRMFinalizationsInfo MainObject { get; set; } = new PPRMFinalizationsInfo();
        public PPRMFinalizationItemsInfo ItemObject { get; set; } = new PPRMFinalizationItemsInfo();
        public PPRMFinalizationTotalsInfo objTotalCal { get; set; } = new PPRMFinalizationTotalsInfo();
        public List<PPRMFinalizationItemsInfo> lstPPRMFinalizationItems { get; set; } = new List<PPRMFinalizationItemsInfo>();
        public List<PPRMFinalizationItemNextsInfo> lstPPRMFinalizationItemNexts { get; set; } = new List<PPRMFinalizationItemNextsInfo>();
        public List<PPRMFinalizationTotalsInfo> lstPPRMFinalizationTotals { get; set; } = new List<PPRMFinalizationTotalsInfo>();
        public List<PPRMFinalizationProductionOrdrsInfo> lstPPRMFinalizationProductionOrdrs { get; set; } = new List<PPRMFinalizationProductionOrdrsInfo>();
        public List<PPRMFinalizationFGsInfo> lstPPRMFinalizationFGs { get; set; } = new List<PPRMFinalizationFGsInfo>();
        public List<PPRMFinalizationReturnsInfo> lstPPRMFinalizationReturns { get; set; } = new List<PPRMFinalizationReturnsInfo>();
    }
}
