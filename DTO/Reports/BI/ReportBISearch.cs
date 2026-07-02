using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports
{
    public class ReportBISearch
    {
        public string fromDate { get; set; } = Constants.DEFAULT_VALUE_STRING;
        public string toDate { get; set; } = Constants.DEFAULT_VALUE_STRING;
    }
}
