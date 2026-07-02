using System.Collections.Generic;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports
{
    public class ReportBIData
    {
        public List<BIDataSupplier> BIDataSupplier { get; set; }
        public List<BIDataPO> BIDataPO { get; set; }
        public List<BIDataProduct> BIDataProduct { get; set; }
        public List<BIDataEmployee> BIDataEmployee { get; set; }
        public List<BIDataProductGroupMonth> BIDataProductGroupMonth { get; set; }
        public List<BIDataProductGroup> BIDataProductGroup { get; set; }
        public List<BIDataSumMonth> BIDataSumMonth { get; set; }
        public List<BIDataSumPO> BIDataSumPO { get; set; }

    }
}
