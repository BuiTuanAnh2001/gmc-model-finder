using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("GLTranCfgGroups")]
    public class GLTranCfgGroupsInfo 
    {
        [Key]
        public int GLTranCfgGroupID { get; set; }
        public string GLTranCfgGroupNo { get; set; }
        public string GLTranCfgGroupName { get; set; }
        public string GLTranCfgGroupDesc { get; set; }
        public bool GLTranCfgGroupSearchByCU { get; set; }
        public bool GLTranCfgGroupSearchByGLUser { get; set; }
        
    }
}
