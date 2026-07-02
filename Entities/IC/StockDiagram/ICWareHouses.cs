using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ICWareHouses")]
    public class ICWareHouses 
    {
        [Key]
        public int ICWareHouseID
        { get; set; }
        public String ICWareHouseNo
        { get; set; } = String.Empty;
        public String ICWareHouseName
        { get; set; } = String.Empty;
        public String ICWareHouseType
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
    }
}
