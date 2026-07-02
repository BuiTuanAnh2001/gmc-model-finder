using System;

namespace gmc_api.DTO.HR
{
    public class EmployeeInfo
    {
        public string employeeNo { get; set; } = "";
        public string employeeName { get; set; } = "";
        public int employeeId { get; set; } = 0;
        public int userId { get; set; } = 0;
        public int positionID { get; set; } = 0;
        public int sectionID { get; set; } = 0;
        public int departmentID { get; set; } = 0;
        public int levelID { get; set; } = 0;
        public string tCSlrTypeCombo { get; set; } = "";
        public DateTime startWorkingDate { get; set; }
    }
}
