using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("APPRs")]
    public class APPRsInfo : FixFiveProps
    {
        [Key]
        public int APPRID { get; set; }
        public Boolean AASelected { get; set; }
        public int FK_GECurrencyID { get; set; }
        public int FK_APSupplierID { get; set; }
        public int FK_GEShpMthID { get; set; }
        public int FK_GEVATRegionID { get; set; }
        public int FK_HREmployeeID { get; set; }
        public string APPREmployeeRequire { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APSellerrProvisionFix { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APSellerProvisionPct { get; set; }
        public string APPRStatusCombo { get; set; } = "New";
        public string APPRPmtTerm { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRSupplierBonus { get; set; }
        public string APPmtMthCombo { get; set; } = String.Empty;
        public string APPRNo { get; set; } = String.Empty;
        public string APPRName { get; set; } = String.Empty;
        public string APPRDesc { get; set; } = String.Empty;
        public Boolean APPROnHoldCheck { get; set; }
        public string APPRText { get; set; } = String.Empty;
        public Nullable<DateTime> APPRDate { get; set; }
        public Nullable<DateTime> APPRExpireDate { get; set; }
        public Nullable<DateTime> APPRShpDate { get; set; }
        public Nullable<DateTime> APPRShpDate1 { get; set; }
        public Nullable<DateTime> APPRShpDate2 { get; set; }
        public Boolean APPRIsDiscPctCheck { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRDiscPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRDiscAmt { get; set; }
        public string APPRRef { get; set; } = String.Empty;
        public string APPRSupRef { get; set; } = String.Empty;
        public string APPRRemark { get; set; } = String.Empty;
        public int APPRQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRWeight { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRVolume { get; set; }
        public Boolean APPRActiveCheck { get; set; }
        public string APPRTxNo { get; set; } = String.Empty;
        public string APPRTypeCombo { get; set; } = String.Empty;
        public string APPROF01Combo { get; set; } = String.Empty;
        public string APPROF02Combo { get; set; } = String.Empty;
        public string APPROF03Combo { get; set; } = String.Empty;
        public string APPROF04Combo { get; set; } = String.Empty;
        public string APPROF05Combo { get; set; } = String.Empty;
        public string APPROF06Combo { get; set; } = String.Empty;
        public string APPROF07Combo { get; set; } = String.Empty;
        public string APPROF08Combo { get; set; } = String.Empty;
        public string APPROF09Combo { get; set; } = String.Empty;
        public string APPROF10Combo { get; set; } = String.Empty;
        public string APPROF11Combo { get; set; } = String.Empty;
        public string APPROF12Combo { get; set; } = String.Empty;
        public string APPRInfo { get; set; } = String.Empty;
        public string APPRPrj { get; set; } = String.Empty;
        public int FK_APSupplierBTConID { get; set; }
        public string APPRBTConName { get; set; } = String.Empty;
        public string APPRBTConFName { get; set; } = String.Empty;
        public string APPRBTConLName { get; set; } = String.Empty;
        public string APPRBTConTitle { get; set; } = String.Empty;
        public string APPRBTConHLet { get; set; } = String.Empty;
        public string APPRBTConHMsg { get; set; } = String.Empty;
        public string APPRBTConEmail1 { get; set; } = String.Empty;
        public string APPRBTConEmail2 { get; set; } = String.Empty;
        public string APPRBTConWebsite { get; set; } = String.Empty;
        public string APPRBTConPhonePri { get; set; } = String.Empty;
        public string APPRBTConPhone { get; set; } = String.Empty;
        public string APPRBTConPhone1 { get; set; } = String.Empty;
        public string APPRBTConCPhone { get; set; } = String.Empty;
        public string APPRBTConCPhone1 { get; set; } = String.Empty;
        public string APPRBTConCPhonePrivt { get; set; } = String.Empty;
        public string APPRBTConFax { get; set; } = String.Empty;
        public string APPRBTConType { get; set; } = String.Empty;
        public string APPRBTConInfo { get; set; } = String.Empty;
        public string APPRBTConDept { get; set; } = String.Empty;
        public string APPRBTConRoom { get; set; } = String.Empty;
        public string APPRBTAddL1 { get; set; } = String.Empty;
        public string APPRBTAddL2 { get; set; } = String.Empty;
        public string APPRBTAddL3 { get; set; } = String.Empty;
        public string APPRBTAddStreet { get; set; } = String.Empty;
        public string APPRBTAddCity { get; set; } = String.Empty;
        public string APPRBTAddPCode { get; set; } = String.Empty;
        public string APPRBTAddStProv { get; set; } = String.Empty;
        public string APPRBTAddZCode { get; set; } = String.Empty;
        public string APPRBTAddCountry { get; set; } = String.Empty;
        public int FK_APSupplierCMID { get; set; }
        public string APPRCMName { get; set; } = String.Empty;
        public Nullable<DateTime> APPRCMBirthday { get; set; }
        public string APPRCMFName { get; set; } = String.Empty;
        public string APPRCMLName { get; set; } = String.Empty;
        public string APPRCMTitle { get; set; } = String.Empty;
        public string APPRCMHLetter { get; set; } = String.Empty;
        public string APPRCMHMsg { get; set; } = String.Empty;
        public string APPRCMEmail1 { get; set; } = String.Empty;
        public string APPRCMEmail2 { get; set; } = String.Empty;
        public string APPRCMWebsite { get; set; } = String.Empty;
        public string APPRCMPhonePriv { get; set; } = String.Empty;
        public string APPRCMPhone { get; set; } = String.Empty;
        public string APPRCMPhone1 { get; set; } = String.Empty;
        public string APPRCMCellPhone { get; set; } = String.Empty;
        public string APPRCMCellPhone1 { get; set; } = String.Empty;
        public string APPRCMFax { get; set; } = String.Empty;
        public string APPRCMType { get; set; } = String.Empty;
        public string APPRCMInfo { get; set; } = String.Empty;
        public string APPRCMDept { get; set; } = String.Empty;
        public string APPRCMRoom { get; set; } = String.Empty;
        public string APPRCMAddL1 { get; set; } = String.Empty;
        public string APPRCMAddL2 { get; set; } = String.Empty;
        public string APPRCMAddL3 { get; set; } = String.Empty;
        public string APPRCMAddStreet { get; set; } = String.Empty;
        public string APPRCMAddCity { get; set; } = String.Empty;
        public string APPRCMAddPCode { get; set; } = String.Empty;
        public string APPRCMAddStPrv { get; set; } = String.Empty;
        public string APPRCMAddZCode { get; set; } = String.Empty;
        public string APPRCMAddCountry { get; set; } = String.Empty;
        public int FK_APSupplierShipToID { get; set; }
        public string APPRShipToName { get; set; } = String.Empty;
        public Nullable<DateTime> APPRShipToBirthday { get; set; }
        public string APPRShipToFName { get; set; } = String.Empty;
        public string APPRShipToLName { get; set; } = String.Empty;
        public string APPRShipToTitle { get; set; } = String.Empty;
        public string APPRShipToHLetter { get; set; } = String.Empty;
        public string APPRShipToHMsg { get; set; } = String.Empty;
        public string APPRShipToEmail1 { get; set; } = String.Empty;
        public string APPRShipToEmail2 { get; set; } = String.Empty;
        public string APPRShipToWebsite { get; set; } = String.Empty;
        public string APPRShipToPhonePriv { get; set; } = String.Empty;
        public string APPRShipToPhone { get; set; } = String.Empty;
        public string APPRShipToPhone1 { get; set; } = String.Empty;
        public string APPRShipToCPhone { get; set; } = String.Empty;
        public string APPRShipToCPhone1 { get; set; } = String.Empty;
        public string APPRShipToCPhonePriv { get; set; } = String.Empty;
        public string APPRShipToFax { get; set; } = String.Empty;
        public string APPRShipToType { get; set; } = String.Empty;
        public string APPRShipToInfo { get; set; } = String.Empty;
        public string APPRShipToDept { get; set; } = String.Empty;
        public string APPRShipToRoom { get; set; } = String.Empty;
        public byte[] APPRShipToImage { get; set; }
        public string APPRShipToAddName { get; set; } = String.Empty;
        public string APPRShipToAddL1 { get; set; } = String.Empty;
        public string APPRShipToAddL2 { get; set; } = String.Empty;
        public string APPRShipToAddL3 { get; set; } = String.Empty;
        public string APPRShipToAddStreet { get; set; } = String.Empty;
        public string APPRShipToAddHouseNumber { get; set; } = String.Empty;
        public string APPRShipToAddCity { get; set; } = String.Empty;
        public string APPRShipToAddPCode { get; set; } = String.Empty;
        public string APPRShipToAddStProv { get; set; } = String.Empty;
        public string APPRShipToAddZCode { get; set; } = String.Empty;
        public string APPRShipToAddCountry { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRShpFees { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRShpExtraFees { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRShpInsuranceFees { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRShpPackagingFees { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRShpReservedFees1 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRShpReservedFees2 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRShpReservedFees3 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRShpReservedFees4 { get; set; }
        public string APPRShpMethodDesc { get; set; } = String.Empty;
        public string APPRShpMethodName { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRShpAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItmPriceTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItmDiscAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItmAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRTxAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRNetAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRMiscChargeAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRCostTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRMargPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRSupCrdLimit { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRSupOverCrdLimit { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPREstOverCrdLimit { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRSupOutStandBalance { get; set; }
        public int FK_APPmtTermID { get; set; }
        public int FK_PMProjectID { get; set; }
        public int FK_BRBranchID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRExcRate { get; set; }
        public Nullable<DateTime> APPRArrivalDate { get; set; }
        public int FK_ADApprovalProcID { get; set; }
        public string ApprovalStatusCombo { get; set; } = "New";
        public int FK_ADApprovalProcStepCurrentID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_PPProductPlnID { get; set; }
        public int FK_ARSOID { get; set; }
        public int FK_APProcurementPlnID { get; set; }
        public int FK_GLTranCfgID { get; set; }
        public string AAModule { get; set; } = String.Empty;
        public int FK_APPRFromID { get; set; }
        public int FK_GLOrgTranCfgID { get; set; }
        public string APPRContractNo { get; set; } = String.Empty;
        public Nullable<DateTime> APPRContractDate { get; set; }
        public string APPRWOTypeCombo { get; set; } = String.Empty;
    }
}
