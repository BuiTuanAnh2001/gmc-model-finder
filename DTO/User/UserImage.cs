using gmc_api.Base.dto;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.User
{
    public class UserImage
    {
        public string employeeNo { get; set; } = "";
        public string employeeName { get; set; } = "";
        public int employeeId { get; set; } = 0;
        public byte[] image { get; set; }

    }
}
