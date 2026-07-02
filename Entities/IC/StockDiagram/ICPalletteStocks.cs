using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ICPalletteStocks")]
    public class ICPalletteStocks
    {
        [Key]
        public int ICPalletteStockID
        { get; set; }
        public String AAStatus
        { get; set; } = "Alive";
        public String AACreatedUser
        { get; set; }
        public String AAUpdatedUser
        { get; set; }
        public Nullable<DateTime> AACreatedDate
        { get; set; } = DateTime.Now;
        public Nullable<DateTime> AAUpdatedDate
        { get; set; }
        public bool AASelected
        { get; set; }
        public int FK_ICStockID
        { get; set; }
        public int FK_ICPalletteID
        { get; set; }
        public String ICPalletteStockDesc
        { get; set; }
        public String ICPalletteStockType
        { get; set; }
        public String ICPalletteStockSize
        { get; set; }
        public String ICPalletteStockMinSize
        { get; set; }
        public String ICPalletteStockLocation
        { get; set; }
        public String ICPalletteStockAppData
        { get; set; }
        public bool ICPalletteStockAllowMoveCheck
        { get; set; }
        public String ICPalletteStockStatusCombo
        { get; set; } = String.Empty;

    }
}
