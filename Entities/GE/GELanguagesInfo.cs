using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities.GE
{
    [Table("GELanguages")]
    public class GELanguagesInfo
    {
        [Key]
        public int GELanguageID { get; set; }
        public string AAStatus { get; set; } = "Alive";
        public string GELanguageNo { get; set; } = String.Empty;
        public string GELanguageCultur { get; set; } = String.Empty;
        public string GELanguageName { get; set; } = String.Empty;
        public string GELanguageDesc { get; set; } = String.Empty;

    }
}
