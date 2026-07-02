using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.Inventoty
{
    public class AppWareHouseStocks
    {
        public int ICWareHouseStockID
        { get; set; } = 0;
        public int FK_ICStockID
        { get; set; } = 0;
        public int FK_ICWareHouseID
        { get; set; } = 0;
        public String ICWareHouseStockType
        { get; set; } = string.Empty;
        public String ICWareHouseStockSize
        { get; set; } = string.Empty;
        public String ICWareHouseStockMinSize
        { get; set; }= string.Empty;
        public String ICWareHouseStockLocation
        { get; set; } = String.Empty;
        public String ICWareHouseStockAppData
        { get; set; }= String.Empty;
        public bool ICWareHouseStockAllowMoveCheck
        { get; set; }= false;
        public String ICStockNo
        { get; set; }=  String.Empty ;
        public String ICStockName
        { get; set; }= String.Empty ;
        public List<AppPalletteStocks> ListPallette
        { get; set; } = new List<AppPalletteStocks>();
    }
}
