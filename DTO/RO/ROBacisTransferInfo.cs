using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.RO
{
    public class ROBacisTransferInfo
    {
        public int FK_GLOrgTranCfgID { get; set; }
        public int FK_GLTranCfgID { get; set; }
        public int FK_GECurrencyID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_GECurrencyExObjID { get; set; }
        public int FK_HREmployeeID { get; set; }
        public int FK_ARCustomerID { get; set; }
        public Nullable<DateTime> ICRODate { get; set; }
    }
}
