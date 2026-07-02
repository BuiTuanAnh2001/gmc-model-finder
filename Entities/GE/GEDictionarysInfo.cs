using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities.GE
{
    [Table("GEDictionarys")]
    public class GEDictionarysInfo
    {
        [Key]
        public int GEDictionaryID { get; set; }
        public string GEDictionaryTypeCombo { get; set; } = String.Empty;
        public string GEDictionaryText { get; set; } = String.Empty;
        public string GEDictionaryText1 { get; set; } = String.Empty;
        public string GEDictionaryText2 { get; set; } = String.Empty;
        public string GEDictionaryText3 { get; set; } = String.Empty;

    }
}
