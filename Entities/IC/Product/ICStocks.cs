using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICStocks")]
    public class ICStocks : FixFiveProps
    {
        [Key]
        public int ICStockID { get; set; }
        public int FK_GECurrencyID { get; set; }
        public int FK_ICStockParentID { get; set; }
        public int FK_BRBranchID { get; set; }
        public string ICStockNo { get; set; }
        public string ICStockName { get; set; }
        public string ICStockDesc { get; set; }
        public string ICStockType { get; set; }
        public string ICStockOF01Combo { get; set; }
        public string ICStockOF02Combo { get; set; }
        public string ICStockOF03Combo { get; set; }
        public string ICStockOF04Combo { get; set; }
        public string ICStockOF05Combo { get; set; }
        public string ICStockOF06Combo { get; set; }
        public string ICStockOF07Combo { get; set; }
        public string ICStockOF08Combo { get; set; }
        public string ICStockOF09Combo { get; set; }
        public string ICStockOF10Combo { get; set; }
        public Boolean ICStockActiveCheck { get; set; }
        public string ICStockInfo { get; set; }
        public string ICStockConName { get; set; }
        public Nullable<DateTime> ICStockConBday { get; set; }
        public string ICStockConFName { get; set; }
        public string ICStockConLName { get; set; }
        public string ICStockConTitle { get; set; }
        public string ICStockConHLet { get; set; }
        public string ICStockConHMsg { get; set; }
        public string ICStockConEmail { get; set; }
        public string ICStockConEmail1 { get; set; }
        public string ICStockConWebsite { get; set; }
        public string ICStockConPhonePriv { get; set; }
        public string ICStockConPhone { get; set; }
        public string ICStockConPhone1 { get; set; }
        public string ICStockConCPhone { get; set; }
        public string ICStockConCPhone1 { get; set; }
        public string ICStockConFax { get; set; }
        public string ICStockConInfo { get; set; }
        public string ICStockConDept { get; set; }
        public string ICStockConRoom { get; set; }
        public string ICStockAddStr { get; set; }
        public string ICStockAddL1 { get; set; }
        public string ICStockAddL2 { get; set; }
        public string ICStockAddL3 { get; set; }
        public string ICStockAddCity { get; set; }
        public string ICStockAddPCode { get; set; }
        public string ICStockAddStProv { get; set; }
        public string ICStockAddZCode { get; set; }
        public string ICStockAddCountry { get; set; }
        public Boolean AASelected { get; set; }
        public int FK_ICStockTypeID { get; set; }
        public int FK_GLInventoryAccountID { get; set; }
        public int FK_GLCostAccountID { get; set; }
        public int ICStockSortOrder { get; set; }
        public string AAOrgDocNo { get; set; }
        public Boolean ICStockLotNoCheck { get; set; }
        public Boolean ICStockSlotCheck { get; set; }
        public string ICStockExportStatus { get; set; }
        public int ICStockExportCount { get; set; }
        public Boolean ICStockProductionCheck { get; set; }
        public Boolean ICStockHoldCheck { get; set; }

    }
}
