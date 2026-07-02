using System;

namespace gmc_api.DTO.PO
{
    public class APPOBacisReceiptInfo
    {
        public int FK_GLOrgTranCfgID { get; set; }
        public int FK_GLTranCfgID { get; set; }
        public int FK_GECurrencyID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_GECurrencyExObjID { get; set; }
        public Nullable<DateTime> APPODate { get; set; }
    }
}
