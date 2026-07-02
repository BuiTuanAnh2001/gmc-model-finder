using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ICPalletteProducts")]
    public class ICPalletteProducts
    {
        [Key]
        public int ICPalletteProductID
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
        public int FK_ICProductID
        { get; set; }
        public int FK_ICUOMID
        { get; set; }
        public int FK_ICPalletteStockID
        { get; set; }
        public int FK_ICPalletteID
        { get; set; }
        public decimal ICPalletteProductQty
        { get; set; }
        public String ICPalletteProductDesc
        { get; set; }
        public String ICPalletteProductType
        { get; set; }
        public String ICPalletteProductSize
        { get; set; }
        public String ICPalletteProductMinSize
        { get; set; }
        public String ICPalletteProductLocation
        { get; set; }
        public String ICPalletteProductAppData
        { get; set; }
        public bool ICPalletteProductAllowMoveCheck
        { get; set; }
        public String ICPalletteProductStatusCombo
        { get; set; } = String.Empty;

    }
}
