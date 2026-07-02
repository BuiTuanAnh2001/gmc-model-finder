using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ICWareHouseStocks")]
    public class ICWareHouseStocks
    {
        [Key]
        public int ICWareHouseStockID
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
        public int FK_ICWareHouseID
        { get; set; }
        public String ICWareHouseStockDesc
        { get; set; }
        public String ICWareHouseStockType
        { get; set; }
        public String ICWareHouseStockSize
        { get; set; }
        public String ICWareHouseStockMinSize
        { get; set; }
        public String ICWareHouseStockLocation
        { get; set; }
        public String ICWareHouseStockAppData
        { get; set; }
        public bool ICWareHouseStockAllowMoveCheck
        { get; set; }

    }
}
