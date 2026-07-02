using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.Inventoty
{
    public class AppPalletteStocks
    {
        public int ICPalletteStockID
        { get; set; } = 0;
        public int FK_ICStockID
        { get; set; } = 0;
        public int FK_ICPalletteID
        { get; set; } = 0;
        public String ICPalletteStockType
        { get; set; } = string.Empty;
        public String ICPalletteStockSize
        { get; set; } = string.Empty;
        public String ICPalletteStockMinSize
        { get; set; }= string.Empty;
        public String ICPalletteStockLocation
        { get; set; } = String.Empty;
        public String ICPalletteStockAppData
        { get; set; }= String.Empty;
        public String ICPalletteStockDesc
        { get; set; } = String.Empty;
        public String ICPalletteStockStatusCombo
        { get; set; } = String.Empty;
        public bool ICPalletteStockAllowMoveCheck
        { get; set; }= false;
        public String ICPalletteNo
        { get; set; }=  String.Empty ;
        public String ICPalletteName
        { get; set; }= String.Empty;
        public String ICPalletteTypeCombo
        { get; set; } = String.Empty;
        public String ICPalletteSize
        { get; set; } = String.Empty;
        public List<AppPalletteProducts> ListProduct
        { get; set; } = new List<AppPalletteProducts>();
    }
}
