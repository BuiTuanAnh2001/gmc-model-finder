using System.Collections.Generic;

namespace gmc_api.DTO.HR
{
    public class Salary
    {
        public decimal TotalSalary { get; set;}
        public List<SalaryDetail> lstSalaryDetail { get; set; } = new List<SalaryDetail>();
        public List<EmployeeSlr> EmpployeeInfo { get; set; } = new List<EmployeeSlr>();
    }
    public class SalaryDetail
    {
        public string HRSalaryBandName { get; set; } = string.Empty;
        public string HRSalaryColCaption { get; set; } = string.Empty;
        public decimal HRSalaryValue { get; set; }

    }
    public class EmployeeSlr
    {
        public string HRSalaryColCaption { get; set; } = string.Empty;
        public string HRSalaryValue { get; set; } = string.Empty;

    }
}
