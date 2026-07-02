using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ARAdjPriceListDetails")]
    public class ARAdjPriceListDetails
    {
        [Key]
        public int ARAdjPriceListDetailID { get; set; }
        public string AAStatus { get; set; }
        public Boolean AASelected { get; set; }
        public int FK_ARAdjPriceListID { get; set; }
        public int FK_ICProductGroupID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_GECurrencyID { get; set; }
        public string ARAdjPriceListDetailName { get; set; }
        public decimal ARAdjPriceListDetailOrgPrice { get; set; }
        public decimal ARAdjPriceListDetailAdjUnitPrice01 { get; set; }
        public decimal ARAdjPriceListDetailAdjUnitPrice02 { get; set; }
        public decimal ARAdjPriceListDetailAdjUnitPrice03 { get; set; }
        public decimal ARAdjPriceListDetailAdjUnitPrice04 { get; set; }
        public decimal ARAdjPriceListDetailAdjUnitPrice05 { get; set; }
        public decimal ARAdjPriceListDetailIncreasePct { get; set; }
        public decimal ARAdjPriceListDetailProductDiscountPct { get; set; }
        public Nullable<DateTime> ARAdjPriceListDetailFromDate { get; set; }
        public Nullable<DateTime> ARAdjPriceListDetailToDate { get; set; }
        public decimal ARAdjPriceListDetailFromQuantity { get; set; }
        public decimal ARAdjPriceListDetailToQuantity { get; set; }
        public int FK_ACCostSimulationMethodID { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public decimal ARAdjPriceListDetailQty { get; set; }
        public decimal ARAdjPriceListDetailRQty { get; set; }
        public decimal ARAdjPriceListDetailStkQty { get; set; }
        public decimal ARAdjPriceListDetailRStkQty { get; set; }
        public int FK_ICWeightUOMID { get; set; }
        public int FK_ICVolumeUOMID { get; set; }
        public decimal ARAdjPriceListDetailWTot { get; set; }
        public decimal ARAdjPriceListDetailVTot { get; set; }
        public string ARAdjPriceListDetailIOF01Combo { get; set; }
        public string ARAdjPriceListDetailIOF02Combo { get; set; }
        public string ARAdjPriceListDetailIOF03Combo { get; set; }
        public string ARAdjPriceListDetailIOF04Combo { get; set; }
        public string ARAdjPriceListDetailIOF05Combo { get; set; }
        public string ARAdjPriceListDetailIOF06Combo { get; set; }
        public string ARAdjPriceListDetailIOF07Combo { get; set; }
        public string ARAdjPriceListDetailIOF08Combo { get; set; }
        public string ARAdjPriceListDetailIOF09Combo { get; set; }
        public string ARAdjPriceListDetailIOF10Combo { get; set; }
        public decimal ARAdjPriceListDetailAdjUnitPricePct01 { get; set; }
        public decimal ARAdjPriceListDetailAdjUnitPricePct02 { get; set; }
        public decimal ARAdjPriceListDetailAdjUnitPricePct03 { get; set; }
        public decimal ARAdjPriceListDetailAdjUnitPricePct04 { get; set; }
        public decimal ARAdjPriceListDetailAdjUnitPricePct05 { get; set; }
        public decimal ARAdjPriceListDetailAdjDiscPct01 { get; set; }
        public decimal ARAdjPriceListDetailAdjDiscPct02 { get; set; }
        public decimal ARAdjPriceListDetailAdjDiscPct03 { get; set; }
        public decimal ARAdjPriceListDetailAdjDiscPct04 { get; set; }
        public decimal ARAdjPriceListDetailAdjDiscPct05 { get; set; }
        public decimal ARAdjPriceListDetailAdjDiscAmt01 { get; set; }
        public decimal ARAdjPriceListDetailAdjDiscAmt02 { get; set; }
        public decimal ARAdjPriceListDetailAdjDiscAmt03 { get; set; }
        public decimal ARAdjPriceListDetailAdjDiscAmt04 { get; set; }
        public decimal ARAdjPriceListDetailAdjDiscAmt05 { get; set; }
        public int FK_ADOFID { get; set; }
        public int FK_ADOFItemID { get; set; }

    }
}
