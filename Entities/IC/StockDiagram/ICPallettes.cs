using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ICPallettes")]
    public class ICPallettes 
    {
        [Key]
        public int ICPalletteID
        { get; set; }
        public String ICPalletteNo
        { get; set; } = String.Empty;
        public String ICPalletteName
        { get; set; } = String.Empty;
        public String ICPalletteTypeCombo
        { get; set; } = String.Empty;
        public String AAStatus
        { get; set; } = "Alive";
        public String AACreatedUser
        { get; set; } = String.Empty;
        public String AAUpdatedUser
        { get; set; } = String.Empty;
        public Nullable<DateTime> AACreatedDate
        { get; set; } = DateTime.Now;
        public Nullable<DateTime> AAUpdatedDate
        { get; set; }
        public bool AASelected
        { get; set; }
        public String ICPalletteDesc
        { get; set; } = String.Empty; 
        public String ICPalletteSize
        { get; set; } = String.Empty;
    }
}
