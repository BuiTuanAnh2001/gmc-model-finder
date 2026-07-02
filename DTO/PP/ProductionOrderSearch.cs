using gmc_api.Base.dto;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.PP
{
    //Search jticket: Status, Work Center, WorkOrder, Phase
    //Group job: Status, Work Center, WorkOrder, Phase, Work Center, Date
    // Bỏ
    // Group KQSX: Status, Work Center, WorkOrder, Job Ticket, Phase, Date
    public class ProductionOrderSearch
    {
        public string status { get; set; } = Constants.DEFAULT_VALUE_STRING;
        public string workCenter { get; set; } = Constants.DEFAULT_VALUE_STRING;
        public string workOrder { get; set; } = Constants.DEFAULT_VALUE_STRING;
        public string jobTicket { get; set; } = Constants.DEFAULT_VALUE_STRING;
        public string phase { get; set; } = Constants.DEFAULT_VALUE_STRING;
        public string fromDate { get; set; } = Constants.DEFAULT_VALUE_STRING;
        public string toDate { get; set; } = Constants.DEFAULT_VALUE_STRING;
        public string groupByColumn { get; set; } = Constants.DEFAULT_VALUE_STRING;
        public string groupByValue { get; set; } = Constants.DEFAULT_VALUE_STRING;
        public int FK_ICProductID { get; set; } = 0;
        public UserLoginInfo userInfo { get; set; } = new UserLoginInfo();
    }
}
