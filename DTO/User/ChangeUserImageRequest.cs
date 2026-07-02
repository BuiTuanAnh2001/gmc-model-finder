using gmc_api.Base.dto;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.User
{
    public class ChangeUserImageRequest
    {
        public int ADUserID { get; set; }
        public string image { get; set; }

    }
}
