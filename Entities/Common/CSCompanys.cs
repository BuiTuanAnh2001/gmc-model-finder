using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("CSCompanys")]
    public class CSCompanys
    {
        [Key]
        public int CSCompanyID { get; set; }
        public string AAStatus { get; set; }
        public int FK_GECurrencyID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_ICStockID { get; set; }
        public string CSCompanyDesc { get; set; }
        public string CSCompanyLicenceNumber { get; set; }
        public Nullable<DateTime> CSCompanyLicenceDate { get; set; }
        public string CSCompanyVersionNumber { get; set; }
        public Nullable<DateTime> CSCompanyVersionDate { get; set; }
        public string CSCompanyAddressStreet { get; set; }
        public string CSCompanyAddressLine1 { get; set; }
        public string CSCompanyAddressLine2 { get; set; }
        public string CSCompanyAddressLine3 { get; set; }
        public string CSCompanyAddressCity { get; set; }
        public string CSCompanyAddressPostalCode { get; set; }
        public string CSCompanyAddressStateProvince { get; set; }
        public string CSCompanyAddressZipCode { get; set; }
        public string CSCompanyAddressCountry { get; set; }
        public string CSCompanyEmail { get; set; }
        public string CSCompanyWebsite { get; set; }
        public string CSCompanyCellPhone { get; set; }
        public string CSCompanyPhone { get; set; }
        public string CSCompanyFax { get; set; }
        public string CSCompanyInformation { get; set; }
        public byte[] CSCompanyLogo { get; set; }
        public string CSCompanyTaxNumber { get; set; }
        public string CSCompanyBankName { get; set; }
        public string CSCompanyBankCode { get; set; }
        public string CSCompanyManager { get; set; }
        public Boolean CSCompanyAllowNegativeInventory { get; set; }
        public string CSCompanyNumDecSeparator { get; set; }
        public string CSCompanyNumGroupSeparator { get; set; }
        public string CSCompanyDateFormat { get; set; }
        public string CSCompanyFileServerPath { get; set; }
        public string CSCompanyFTP { get; set; }
        public string CSCompanyFTPUserName { get; set; }
        public string CSCompanyFTPPassword { get; set; }
        public Boolean CSCompanyIsUserAudit { get; set; }
        public int CSCompanyWarantyDefaultExpireDays { get; set; }
        public int CSCompanyWarantyDefaultMainDays { get; set; }
        public int CSCompanyWarantyDefaultWarningDays { get; set; }
        public int CSCompanyCurrentYear { get; set; }
        public int CSCompanyPreYear { get; set; }
        public string CSCompanyTreasurer { get; set; }
        public string CSCompanyCFO { get; set; }
        public string CSCompanyAccPolicyNo { get; set; }
        public decimal CSCompanyCurrency { get; set; }
        public int CSCompanyBeginDay { get; set; }
        public int CSCompanyBeginPeriod { get; set; }
        public Nullable<DateTime> CSCompanyInputDataDate { get; set; }
        public int FK_HRTreasurerID { get; set; }
        public Nullable<DateTime> CSCompanyCheckinDocDay { get; set; }
        public Nullable<DateTime> CSCompanyFiscalYear { get; set; }
        public int FK_HRCFOID { get; set; }
        public int FK_HRManagerID { get; set; }
        public string CSCompanyLanDelimeter { get; set; }
        public Boolean CSCompanyIsObjHistory { get; set; }
        public Boolean CSCompanyIsPostHistory { get; set; }
        public Boolean CSCompanyIsCalcCostOnSave { get; set; }
        public int CSCompanyQtyDecRound { get; set; }
    }
}
