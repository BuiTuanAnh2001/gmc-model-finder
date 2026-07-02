using System;

namespace gmc_api.DTO.CommonData
{
    public class CommentHistory
    {
        public string createUser { get; set; }
        public DateTime createDate { get; set; }
        public string content { get; set; }
        public string types { get; set; }
        public int objectID { get; set; }
        public int id { get; set; }
    }
}
