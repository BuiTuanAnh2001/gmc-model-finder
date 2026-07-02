using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.Inventoty
{
    public class AppPalletteProducts
    {
        public int ICPalletteProductID
        { get; set; } = 0;
        public int FK_ICProductID
        { get; set; } = 0;
        public int FK_ICUOMID
        { get; set; } = 0;
        public int FK_ICPalletteStockID
        { get; set; } = 0;
        public decimal ICPalletteProductQty
        { get; set; } = 0;
        public int FK_ICStockID
        { get; set; } = 0;
        public int FK_ICPalletteID
        { get; set; } = 0;
        public String ICPalletteProductType
        { get; set; } = string.Empty;
        public String ICPalletteProductSize
        { get; set; } = string.Empty;
        public String ICPalletteProductMinSize
        { get; set; } = string.Empty;
        public String ICPalletteProductLocation
        { get; set; } = String.Empty;
        public String ICPalletteProductAppData
        { get; set; } = String.Empty;
        public String ICPalletteProductStatusCombo
        { get; set; } = String.Empty;
        public bool ICPalletteProductAllowMoveCheck
        { get; set; } = false;
        public String ICProductNo
        { get; set; } = String.Empty;
        public String ICProductName
        { get; set; } = String.Empty;
        public string ICProductSticker 
        { get; set; } = String.Empty;
    }
}
