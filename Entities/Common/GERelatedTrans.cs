using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("GERelatedTrans")]
    public class GERelatedTrans
    {
        [Key]
        public int GERelatedTranID { get; set; }
        public int GERelatedTranFromDocID { get; set; }
        public string GERelatedTranFromDocTableName { get; set; }
        public string GERelatedTranFromDocModuleName { get; set; }
        public int GERelatedTranToDocID { get; set; }
        public string GERelatedTranToDocTableName { get; set; }
        public string GERelatedTranToDocModuleName { get; set; }
        public Nullable<DateTime> GERelatedTranDate { get; set; }
        public string GERelatedTranUser { get; set; }

    }
}
