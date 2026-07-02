using gmc_api.Base.dto;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.User
{
    public class ChangeUserPasswordRequest
    {
        public int ADUserID { get; set; }
        public string oldPassword { get; set; }
        public string newPassword { get; set; }
    }
}
