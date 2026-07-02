using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("APPriceLists")]
    public class APPriceLists
    {
        [Key]
        public int APPriceListID { get; set; }
        public string AAStatus { get; set; } = "Alive";
        public Boolean AASelected { get; set; }
        public string AACreatedUser { get; set; } = String.Empty;
        public string AAUpdatedUser { get; set; } = String.Empty;
        public Nullable<DateTime> AACreatedDate { get; set; }
        public Nullable<DateTime> AAUpdatedDate { get; set; }
        public int FK_GECurrencyID { get; set; }
        public int FK_APSupplierID { get; set; }
        public string APPriceListNo { get; set; } = String.Empty;
        public string APPriceListName { get; set; } = String.Empty;
        public string APPriceListDesc { get; set; } = String.Empty;
        public string APPriceListInfo { get; set; } = String.Empty;
        public Nullable<DateTime> APPriceListStartDate { get; set; }
        public Nullable<DateTime> APPriceListEndDate { get; set; }
        public string APPriceListOF01Combo { get; set; } = String.Empty;
        public string APPriceListOF02Combo { get; set; } = String.Empty;
        public string APPriceListOF03Combo { get; set; } = String.Empty;
        public string APPriceListOF04Combo { get; set; } = String.Empty;
        public string APPriceListOF05Combo { get; set; } = String.Empty;
        public string APPriceListOF06Combo { get; set; } = String.Empty;
        public string APPriceListOF07Combo { get; set; } = String.Empty;
        public string APPriceListOF08Combo { get; set; } = String.Empty;
        public string APPriceListOF09Combo { get; set; } = String.Empty;
        public string APPriceListOF10Combo { get; set; } = String.Empty;
        public Boolean APPriceListActiveCheck { get; set; }
        public decimal APPriceListExcRate { get; set; }
        public string AAOrgDocNo { get; set; } = String.Empty;
        public string ApprovalStatusCombo { get; set; } = "New";
        public string APPriceListObjectCombo { get; set; } = String.Empty;
        public string APPriceListTypeCombo { get; set; } = String.Empty;
        public int FK_ADOFID { get; set; }
        public int FK_ARCustomerGroupID { get; set; }
        public int FK_ADOFItemID { get; set; }
        public int FK_ADApprovalProcID { get; set; }

    }
}
