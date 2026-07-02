using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ARPriceListDetails")]
    public class ARPriceListDetails
    {
        [Key]
        public int ARPriceListDetailID { get; set; }
        public string AAStatus { get; set; } = "Alive";
        public Boolean AASelected { get; set; }
        public int FK_ARPriceListID { get; set; }
        public int FK_ICProductGroupID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_GECurrencyID { get; set; }
        public string ARPriceListDetailName { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal ARPriceListDetailOrgPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARPriceListDetailProductSalePrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARPriceListDetailIncreasePct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARPriceListDetailProductDiscountPct { get; set; }
        public Nullable<DateTime> ARPriceListDetailFromDate { get; set; }
        public Nullable<DateTime> ARPriceListDetailToDate { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARPriceListDetailFromQuantity { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARPriceListDetailToQuantity { get; set; }
        public int FK_ACCostSimulationMethodID { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARPriceListDetailQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARPriceListDetailRQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARPriceListDetailStkQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARPriceListDetailRStkQty { get; set; }
        public int FK_ICWeightUOMID { get; set; }
        public int FK_ICVolumeUOMID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARPriceListDetailWTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARPriceListDetailVTot { get; set; }
        public string ARPriceListDetailIOF01Combo { get; set; } = String.Empty;
        public string ARPriceListDetailIOF02Combo { get; set; } = String.Empty;
        public string ARPriceListDetailIOF03Combo { get; set; } = String.Empty;
        public string ARPriceListDetailIOF04Combo { get; set; } = String.Empty;
        public string ARPriceListDetailIOF05Combo { get; set; } = String.Empty;
        public string ARPriceListDetailIOF06Combo { get; set; }  = String.Empty;
        public string ARPriceListDetailIOF07Combo { get; set; }  = String.Empty;
        public string ARPriceListDetailIOF08Combo { get; set; }  = String.Empty;
        public string ARPriceListDetailIOF09Combo { get; set; }  = String.Empty;
        public string ARPriceListDetailIOF10Combo { get; set; }  = String.Empty;
        public string ARPriceListDetailIOF11Combo { get; set; }  = String.Empty;
        public string ARPriceListDetailIOF12Combo { get; set; }  = String.Empty;
        public string ARPriceListDetailIOF13Combo { get; set; }  = String.Empty;
        public string ARPriceListDetailIOF14Combo { get; set; }  = String.Empty;
        public string ARPriceListDetailIOF15Combo { get; set; } = String.Empty;
        public int FK_PPNormID { get; set; }
        public int FK_ARQuotItemID { get; set; }
        public int FK_ARCustomerProductNumberID { get; set; }
        public int FK_ICExUOMID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARPriceListDetailProductExPrice { get; set; }

    }
}
