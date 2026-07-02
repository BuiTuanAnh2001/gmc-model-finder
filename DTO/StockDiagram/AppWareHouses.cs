using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.Inventoty
{
    public class AppWareHouses
    {
        public int ICWareHouseID
        { get; set; } = 0;
        public String ICWareHouseNo
        { get; set; } = String.Empty;
        public String ICWareHouseName
        { get; set; } = String.Empty;
        public String ICWareHouseType
        { get; set; } = String.Empty;
        public String ICWareHouseDesc
        { get; set; } = String.Empty;
        public String ICWareHouseSize
        { get; set; } = String.Empty;
        public String ICWareHouseMinSize
        { get; set; } = String.Empty;
        public String ICWareHouseLocation
        { get; set; } = String.Empty;
        public String ICWareHouseAppData
        { get; set; } = String.Empty;
        public bool ICWareHouseAllowMoveCheck
        { get; set; } = true;
        public decimal ICWareHouseGridGapQty
        { get; set; } = 0;
        public decimal ICWareHouseGridGapFact
        { get; set; } = 0;
        public List<AppWareHouseStocks> ListStock
        { get; set; } = new List<AppWareHouseStocks>();
    }
}
