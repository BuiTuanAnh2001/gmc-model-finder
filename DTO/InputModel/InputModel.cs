using gmc_api.Base.dto;
using gmc_api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.InputModel
{
    public class DocDefaultSearch
    {
        public string DocNo { get; set; } = string.Empty;
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
    }
    public class SearchRo : DocDefaultSearch
    {

    }
    public class SearchPO : DocDefaultSearch
    {

    }
    public class SearchFromPO : DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
    }
    public class UserToken
    {
        public string username { get; set; } = string.Empty;
        public string token { get; set; } = string.Empty;
        public string DeviceName { get; set; } = string.Empty;
        public string OSName { get; set; } = string.Empty;

    }
    public class UserHistory
    {
        public string UserName { get; set; } = string.Empty;
        public string DeviceName { get; set; } = string.Empty;
        public string IP { get; set; } = string.Empty;
        public bool Action { get; set; }

    }
    public class LoadNotifyInput
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public string UserName { get; set; } = string.Empty;
    }
    public class NotifyRespond
    {
        public string ADInboxItemSubject { get; set; } = string.Empty;
        public Nullable<DateTime> ADInboxItemDate { get; set; }
    }
    public class SCanInfo
    {
        public int ObjectID { get; set; }
        public string ApprovalStatus { get; set; } = string.Empty;

    }
    public class SearchPOProductionOrdr : DocDefaultSearch
    {

    }
    public class AllServerInfo
    {
        public string serverName { get; set; }
        public string urlApi { get; set; }
        public string NewUrlApi { get; set; }
        public string keys { get; set; }
        public string moduleEnv { get; set; }
    }



    public class ServerResponseInfo
    {
        public string serverName { get; set; }
        public string urlApi { get; set; }
        public string NewUrlApi { get; set; }
        public string keys { get; set; }
        public List<int> moduleEnv { get; set; }
    }
    public class UpdateQtyProductionOrdrEstFGs
    {
        public int id { get; set; }
        public decimal qty { get; set; }
        public decimal cancelQty { get; set; }
        public decimal NCRQty { get; set; }
    }
    public class SearchROFromTransfer : DocDefaultSearch
    {
    }
    public class SearchFromProductionOrdr : DocDefaultSearch
    {
    }
    public class SearchPOPurchaseReceiptQC : DocDefaultSearch
    {

    }
    public class SearchPurchaseReceipt : DocDefaultSearch
    {
        public int FK_ICProductID { get; set; }
    }
    public class SearchFromFromRequestReceipt : DocDefaultSearch
    {
        public string ModuleName {get; set; }
    }
    public class ShipmentSearchFromProductionOrdr : DocDefaultSearch
    {

    }
    public class ReceiptSearFromProductionOrdr : DocDefaultSearch
    {

    }
    public class SearchPInvoice : DocDefaultSearch
    {
        public int FK_BRBranchID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_APSupplierID { get; set; }

    }
    public class SearchReceipt : DocDefaultSearch
    { }
    public class SearchDataRO : DocDefaultSearch
    {
        public int FK_ARCustomerID { get; set; }
        public int FK_BRBranchID { get; set; }
    }
    public class SearchSOFromRO : DocDefaultSearch
    {
        public DateTime ShpFromDate { get; set; } = DateTime.Now;
        public DateTime ShpToDate { get; set; } = DateTime.Now;
    }
    public class SearchShpPlanFromRO
    {
        public Nullable<DateTime> fromdate { get; set; }
        public Nullable<DateTime> todate { get; set; }
    }
    public class SearchInvoice : DocDefaultSearch
    {
        public int FK_BRBranchID { get; set; }
        public int FK_ICProductID { get; set; }

    }
    public class SearchShipment : DocDefaultSearch
    {

    }
    public class SearchComplain : DocDefaultSearch
    {

        public int FK_ARCustomerID { get; set; }
        public int FK_ARSOID { get; set; }
        public string LotNo { get; set; }
        public int FK_ICProductID { get; set; }
    }
    public class SearchRptQuoteComplain : DocDefaultSearch
    {
        public int FK_ARSOID { get; set; }
        public int FK_ARCustomerID { get; set; }
    }
    public class SearchResultMaintenance : DocDefaultSearch
    {
        public int FK_BRBranchID { get; set; }
    }
    public class SearchMaintenanceO : DocDefaultSearch
    {
        public string PPMaintenanceOStatusCombo { get; set; } = string.Empty;
        public string PPMaintenanceOTypeCombo { get; set; } = string.Empty;
    }
    public class SearchViewCalendarMaintenance
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_PPDeviceID { get; set; }
        public int FK_PPMaintenanceCategroyCfgID { get; set; }
        public string PPMaintenanceCategroyCfgTypeCombo { get; set; } = string.Empty;

    }
    public class ViewCalendarMaintenance
    {
        public int FK_PPDeviceID { get; set; }
        public string PPDeviceNo { get; set; } = string.Empty;
        public string PPDeviceName { get; set; } = string.Empty;
        public string PPDeviceTypeNo { get; set; } = string.Empty;
        public string PPDeviceTypeName { get; set; } = string.Empty;
        public int FK_PPMaintenanceCategroyCfgID { get; set; }
        public string PPMaintenanceCategroyCfgNo { get; set; } = string.Empty;
        public string PPMaintenanceCategroyCfgName { get; set; } = string.Empty;
        public DateTime PPMaintenanceDate { get; set; }
        public string Value { get; set; } = string.Empty;
    }
    public class SearchPlanMaintenance : DocDefaultSearch
    {
        public int FK_BRBranchID { get; set; }
    }
    public class SearchRequestMaintenance : DocDefaultSearch
    {

    }
    public class SearchInPmt : DocDefaultSearch
    {
        public int FK_BRBranchID { get; set; }
    }
    public class SearchFromPInvoice : DocDefaultSearch
    {

    }
    public class SearchCustomer
    {
        public string DocNo { get; set; } = string.Empty;
        public string DocName { get; set; } = string.Empty;
        public string ARCustomerOOF01Combo { get; set; } = string.Empty;
        public string ARCustomerOOF02Combo { get; set; } = string.Empty;
    }
    public class SearchCustomerActivity
    {
        public int FK_ARCustomerID { get; set; }
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
    }
    public class SearchDataROROProductionOrdr : DocDefaultSearch
    {
        public int FK_ICStockID { get; set; }
    }
    public class SearchdataWO : DocDefaultSearch
    {
    }
    public class SearchdataProductionOrdr : DocDefaultSearch
    {
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_PPWOID { get; set; }
    }
    public class SearchRemainStockSlot
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iStockID { get; set; }
        public int iStockTypeID { get; set; }
        public int iProductID { get; set; }
        public int iProductTypeID { get; set; }
        public int iProductGroupID { get; set; }
        public int iSlot { get; set; }
        public int iBranchID { get; set; }
    }
    public class SearchRemainStockSlotDetail
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iProductID { get; set; }
        public int iStockID { get; set; }
        public int iSlotID { get; set; }
        public int iBranchID { get; set; }
    }
    public class SearchRemainStockSlotDetailsTock
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iProductID { get; set; }
        public int iStockID { get; set; }
        public string strLotNo { get; set; }
        public int iBranchID { get; set; }
    }
    public class SearchInvUOMLotNoSlot
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iStockID { get; set; }
        public int iStockTypeID { get; set; }
        public int iProductID { get; set; }
        public int iProductTypeID { get; set; }
        public int iProductGroupID { get; set; }
        public string strLotNo { get; set; }
        public string strSerialNo { get; set; }
        public int iSlotID { get; set; }
        public int iDimention1ID { get; set; }
        public int iDimention2ID { get; set; }
        public int iDimention3ID { get; set; }
        public int iDimention4ID { get; set; }
        public int iDimention5ID { get; set; }
    }
    public class SearchInvUOMLotNoSlotDetail
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iProductID { get; set; }
        public int iStockID { get; set; }
        public int iICUOMID { get; set; }
        public int iStockTypeID { get; set; }
        public int iSlotID { get; set; }
        public string strLotNo { get; set; }
        public string strSerialNo { get; set; }

    }
    public class SearchInvUOMLotNoSlotDetailStock
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iProductID { get; set; }
        public int iStockID { get; set; }
        public int iICUOMID { get; set; }
        public int iSlotID { get; set; }
        public string strLotNo { get; set; }
        public string strSerialNo { get; set; }
        public int iBranchID { get; set; }

    }
    public class SearchCustomerReq : DocDefaultSearch
    {
        public int FK_ARCustomerID { get; set; }
        public int FK_ICProductTypeID { get; set; }
        public string ARCustomerReqTypeCombo  { get; set; }
    }
    public class SearchPOMonitor
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iSupplierID { get; set; }
        public string strAPPONo { get; set; }
    }
    public class SearchSOMonitor
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iCustomer { get; set; }
        public string strSONo { get; set; }
        public string sKeyBranch { get; set; }
    }
    public class SearchROProductionShipmentRpt
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iProductionOrdrID { get; set; }
        public int iWOID { get; set; }
    }
    public class SearchRptProductionDownTime
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public string strViewReportNo { get; set; }
        public int iWOID { get; set; }
        public int iResourceID { get; set; }
    }
    public class SearchRptWOMRPFollow
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
    }
    public class SearchDrillDownRptWOMRPFollow
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iProductID { get; set; }
    }
    public class SearchDataProductionFGDate
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iPhaseCfgID { get; set; }
        public bool isChecked { get; set; } = false;
    }
    public class SearchProductionOrdrTotal
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iPhaseCfgID { get; set; }
        public bool isBTP { get; set; } = false;
        public bool isNVL { get; set; } = false;
        public bool isLot { get; set; } = false;
    }
    public class SearchProductionCalendar
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iPPPhaseCfgID { get; set; }
        public int iPPWorkCenterID { get; set; } 
    }
    public class SearchDrillDownDataProductionFGDateFG
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iSearchPhaseCfgID { get; set; }
        public bool isChecked { get; set; } = false;
        public int iDrillDPhaseCfgID { get; set; }
        public DateTime DrillDProductionOrdrDate { get; set; } = DateTime.Now;
        public int iDrillDResourceID { get; set; }
        public int iDrillDWOID { get; set; }
        public int iDrillDFGProductID { get; set; }
        public int iDrillDStkFGUOMID { get; set; }
        public string strDrillDProductionOrdrEstFGLotNo { get; set; }
    }
    public class SearchDrillDownDataProductionFGDateRM
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iSearchPhaseCfgID { get; set; }
        public bool isChecked { get; set; } = false;
        public int iDrillDPhaseCfgID { get; set; }
        public DateTime DrillDProductionOrdrDate { get; set; } = DateTime.Now;
        public int iDrillDFGProductID { get; set; }
        public int iDrillDWOID { get; set; }
        public int iDrillDProductID { get; set; }
        public int iDrillDUOMID { get; set; }
        public int iDrillDStkUOMID { get; set; }
        public string strDrillDProductionOrdrEstRMLotNo { get; set; }
        public string strDrillDProductionOrdrEstRMSerialNo { get; set; }
        public string strDrillDProductionOrdrEstRMFGLotNo { get; set; }
    }
    public class SearchDrillDownROProductionShipmentRpt
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iSearchProductionOrdrID { get; set; }
        public int iSearchWOID { get; set; }
        public int iDrillDproductionOrdrID { get; set; }
        public int iDrillwoID { get; set; }
        public int iDrillDproductID { get; set; }
        public int iDrillDuomID { get; set; }
        public int iDrillstkUomID { get; set; }
    }
    public class SearchMaterialMonitor
    {
        public string strProductNo { get; set; }
        public int iProductType { get; set; }
        public int iProductGroup { get; set; }
        public int iPhaseCfg { get; set; }
        public int iPeriod { get; set; }
        public int iYear { get; set; }
        public bool isShowInvalidNorm { get; set; } = false;
    }
    public class SaleAnalysisStatistic
    {
        public string sKeyCustomerID { get; set; }
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public string DocumentType { get; set; }
        public string TimeType { get; set; }
        public string CustomerType {  get; set; }
    }
    public class ProductAnalysisStatistic
    {
        public int FK_ICProductID { get; set; }
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public string DocumentType { get; set; }
        public string TimeType { get; set; }
        public string ProductType { get; set; }
    }
    public class ViewProductSale
    {
        public int FK_ICProductID { get; set; }
        public string DocumentType { get; set; }
    }
    public class DrillDownChartSaleAnalysisStatistics
    {
        public DrillDownChartSaleAnalysisStatistics()
        {

        }

        public DrillDownChartSaleAnalysisStatistics(String Module, DateTime DateFrom, DateTime DateTo, String Type, int iCustomerID, int iCustomerGroupID, int iProductID, int iProductGroupID, Boolean ExistProfit)
        {
            _module = Module;
            _dateFrom = DateFrom;
            _dateTo = DateTo;
            _type = Type;
            _fk_ARCustomerID = iCustomerID;
            _fk_ARCustomerGroupID = iCustomerGroupID;
            _fk_ICProductID = iProductID;
            _fk_ICProductGroupID = iProductGroupID;
            _existProfit = ExistProfit;
        }

        public String _module;
        public DateTime _dateFrom;
        public DateTime _dateTo;
        public String _type;
        public int _fk_ARCustomerID;
        public int _fk_ARCustomerGroupID;
        public int _fk_ICProductID;
        public int _fk_ICProductGroupID;
        public Boolean _existProfit;
        public String _viewNo;
        public String _viewName;

        public String ViewNo
        {
            get { return _viewNo; }
            set { _viewNo = value; }
        }
        public String ViewName
        {
            get { return _viewName; }
            set { _viewName = value; }
        }
        public String Module
        {
            get { return _module; }
            set { _module = value; }
        }
        public DateTime DateFrom
        {
            get { return _dateFrom; }
            set { _dateFrom = value; }
        }

        public DateTime DateTo
        {
            get { return _dateTo; }
            set { _dateTo = value; }
        }
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int FK_ARCustomerID
        {
            get { return _fk_ARCustomerID; }
            set { _fk_ARCustomerID = value; }
        }
        public int FK_ARCustomerGroupID
        {
            get { return _fk_ARCustomerGroupID; }
            set { _fk_ARCustomerGroupID = value; }
        }

        public int FK_ICProductID
        {
            get { return _fk_ICProductID; }
            set { _fk_ICProductID = value; }
        }
        public int FK_ICProductGroupID
        {
            get { return _fk_ICProductGroupID; }
            set { _fk_ICProductGroupID = value; }
        }
        public Boolean ExistProfit
        {
            get { return _existProfit; }
            set { _existProfit = value; }
        }
    }
    public class POOSSearch:DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_ICProductID { get; set; }
    }
    public class SearchWO : DocDefaultSearch
    {

    }
    public class TransferOSSearch : DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
        public int FK_ICFromStockID { get; set; }
        public int FK_ICToStockID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_ICProductID { get; set; }
    }
    public class FGReceiptOSSearch : DocDefaultSearch
    {
        public int FK_ICProductID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_APSupplierID { get; set; }
        public int FK_ARCustomerID { get; set; }
    }
    public class FGReceiptOSSearchDetail : DocDefaultSearch
    {
        public int FK_ICProductID { get; set; }
        public string ICReceiptItemFGLotNo { get; set; }
    }
    public class RMShipmentOSSearch : DocDefaultSearch
    {
        public int FK_ICProductID { get; set; }
        public int FK_ARCustomerID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_ICStockID { get; set; }
    }
    public class RMShipmentOSSearchDetail : DocDefaultSearch
    {
        public int FK_ICProductID { get; set; }
        public string ICShipmentItemFGLotNo { get; set; }
    }
    public class SearchReceiptOS : DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
    }
    public class SearchPOFromTransfer : DocDefaultSearch
    {
    }
    public class ROPOSearch : DocDefaultSearch
    {
        public int FK_PPWOID { get; set; }
        public int FK_ICStockID { get; set; }
    }
    public class SearchPOFromROPO : DocDefaultSearch
    {

    }
    public class PInvoiceImportPurchaseReceiptSearch : DocDefaultSearch
    {
        public int FK_ICProductID { get; set; }
        public int FK_APSupplierID { get; set; }
        public int FK_ARCustomerID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_BRBranchID { get; set; }
    }
    public class Company
    {
        public static string KeyWW = "WW";
        public static string KeyLDC = "LDC";
        public static string KeyKVI = "KVI";
        public static string KeyNVP = "NVP";
    }
    public class ViewDayOff
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
       public decimal iRegDay { get; set; }
    }
    public class SearchPInvoiceFromReceipt : DocDefaultSearch
    { 
        public int FK_APSupplierID { get; set; }
        public int FK_APPOID { get; set; }
    }
    public class SearchSupplier
    {
        public string DocNo { get; set; } = string.Empty;
        public string DocName { get; set; } = string.Empty;
        public string APSupplierAddL { get; set; } = string.Empty;
        public string APSupplierTxNo { get; set; } = string.Empty;
    }
    public class GetRegDayOff
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
    }
    public class InvQueryInOutSearch : DocDefaultSearch
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_ICProductID { get; set; }
        public int FK_ICStockID { get; set; }
        public string strBRBranchID { get; set; }
        public string Module { get; set; }
    }
    public class SearchPInvoiceImport : DocDefaultSearch
    {
        public DateTime ShpFromDate { get; set; } = DateTime.Now;
        //public DateTime ShpToDate { get; set; } = DateTime.Now;
        //public DateTime ExpFromDate { get; set; } = DateTime.Now;
        //public DateTime ExpToDate { get; set; } = DateTime.Now;
        public int FK_APSupplierID { get; set; }
        public int FK_HREmployeeID { get; set; }
        public int FK_BRBranchID { get; set; }
    }
    public class SearchPOFromPInvoiceImport : DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
    }
    public class APPriceListSearch
    {
        public string DocNo { get; set; } = string.Empty;
        public string DocName { get; set; } = string.Empty;
        public int FK_ICProductID { get; set; }
        public int FK_APSupplierID { get; set; }
    }
    public class ProductSearch
    {
        public string ICProductNo { get; set; }=string.Empty;
        public string ICProductName { get; set; } = string.Empty;
        public string ICProductBarCode { get; set; } = string.Empty;
        public bool ICProductIsStkItm { get; set; } = true;
        public int FK_APSupplierID { get; set; }
        public int FK_ICProductGroupID { get; set; }
        public int FK_ICProductTypeID { get; set; }
        public int FK_ICBrandID { get; set; }

    }
    public class ApprovedPriceSearch : DocDefaultSearch
    {
        public int FK_APPRID { get; set; }
    }
    public class SearchFromInvoice : DocDefaultSearch
    {

    }
    public class SearchOutPmt : DocDefaultSearch
    {
        public int FK_BRBranchID { get; set; }
    }
    public class SearchPInvoiceFromOutPmt : DocDefaultSearch
    {

    }
    public class SearchPmtReqFromOutPmt : DocDefaultSearch
    {

    }
    public class SearchPmtReq : DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
    }
    public class SearchPInvoiceFromPmtReq : DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
        public int FK_BRBranchID { get; set; }
    }
    public class SearchPOFromPmtReq : DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
    }
    public class SearchApprovedPriceFromPO:DocDefaultSearch
    {

    }
    public class SearchCreditNote : DocDefaultSearch
    {
        public int FK_ARCustomerID { get; set; }
        public int FK_BRBranchID { get; set; }
    }
    public class SearchSaleReturnFromReceipt : DocDefaultSearch
    {
        public int FK_ARCustomerID { get; set; }
        public int FK_BRBranchID { get; set; }
    }
    public class SearchSaleReturnFromCreditNote : DocDefaultSearch
    {
        public int FK_ARCustomerID { get; set; }
        public int FK_BRBranchID { get; set; }
    }
    public class SearchAPCreditNote : DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
        public int FK_BRBranchID { get; set; }
    }
    public class SearchShipmentFromAPCreditNote : DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
        public int APPOID { get; set; }
    }
    public class SearchPInvoiceFromAPCreditNote : DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
    }
    public class SearchComplainFromSaleReturn : DocDefaultSearch
    {
        public int FK_ARCustomerID { get; set; }
    }
    public class ViewTrackingSO
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_ARCustomerID { get; set; }
        public string ARCustomerOOF01Combo { get; set; } = string.Empty;
        public string ARCustomerOOF02Combo { get; set; } = string.Empty;
        public string ARCustomerOOF03Combo { get; set; } = string.Empty;
        public string ARCustomerOOF04Combo { get; set; } = string.Empty;
        public string ARCustomerOOF05Combo { get; set; } = string.Empty;
        public string ARCustomerOOF06Combo { get; set; } = string.Empty;
        public string ARCustomerOOF07Combo { get; set; } = string.Empty;
        public string ARCustomerOOF08Combo { get; set; } = string.Empty;
        public string ARCustomerOOF09Combo { get; set; } = string.Empty;
        public string ARCustomerOOF10Combo { get; set; } = string.Empty;
        public string ARCustomerOOF11Combo { get; set; } = string.Empty;
        public string ARCustomerOOF12Combo { get; set; } = string.Empty;
        public string ARCustomerOOF13Combo { get; set; } = string.Empty;
        public string ARCustomerOOF14Combo { get; set; } = string.Empty;
        public string ARCustomerOOF15Combo { get; set; } = string.Empty;
        public int FK_ARSOID { get; set; }
        public string GLTOF01Combo { get; set; } = string.Empty;
        public string GLTOF02Combo { get; set; } = string.Empty;
        public string GLTOF03Combo { get; set; } = string.Empty;
        public string GLTOF04Combo { get; set; } = string.Empty;
        public string GLTOF05Combo { get; set; } = string.Empty;
        public string GLTOF06Combo { get; set; } = string.Empty;
        public string GLTOF07Combo { get; set; } = string.Empty;
        public string GLTOF08Combo { get; set; } = string.Empty;
        public string GLTOF09Combo { get; set; } = string.Empty;
        public string GLTOF10Combo { get; set; } = string.Empty;
        public string GLTOF11Combo { get; set; } = string.Empty;
        public string GLTOF12Combo { get; set; } = string.Empty;
        public string GLTOF13Combo { get; set; } = string.Empty;
        public string GLTOF14Combo { get; set; } = string.Empty;
        public string GLTOF15Combo { get; set; } = string.Empty;
        public string sKeyBranch { get; set; } = string.Empty;
    }
    public class ViewROSOMonitor 
    {
        public string DocNo { get; set; } = string.Empty;
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_BRBranchID { get; set; }
        public int FK_ARCustomerID { get; set; }
        public DateTime ShpFromDate { get; set; } = DateTime.Now;
        public DateTime ShpToDate { get; set; } = DateTime.Now;
    }
    public class ViewPOYearSupRpt
    {
        public int Year { get; set; }
        public int FK_APSupplierID { get; set; }
        public int FK_ICProductID { get; set; }

    }
    public class ViewPRMonitor:DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
    }
    public class ViewSalesRpt 
    {
        public int iMonth { get; set; }
        public int iYear { get; set; }
    }
    public class ViewWOMonitor
    {
        public int iMonth { get; set; }
        public int iYear { get; set; }
        public int FK_PPWOID { get; set; }
    }
    public class RptROProduction:DocDefaultSearch
    {
        public int FK_BRBranchID { get; set; }
        public int FK_PPProductionOrdrID { get; set; }
    }
    public class ViewRptResourceQuery:DocDefaultSearch 
    {
        public int FK_PPResourceGroupID { get; set; }
        public string PPResourceTypeCombo { get; set; }
    }
    public class RptResourceData
    {
        public DateTime Date { get; set; }
        public int PPResourceID { get; set; }
        public decimal Value { get; set; }
        public string BackColor { get; set; }=string.Empty;
        public string ForeColor { get; set; }= string.Empty;

    }
    public class RptResource
    {
        public List<PPResourcesInfo> lstPPResources { get; set; } = new List<PPResourcesInfo>();
        public List<RptResourceData> lstPPResourceDataByDate { get; set; } = new List<RptResourceData>();
        public List<ViewProductionOrdrsInfo> lstCreatProductionOrdr { get; set; } = new List<ViewProductionOrdrsInfo>();
    }
    public class ViewTrackingPO
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_APSupplierID { get; set; }
        public string APSupplierOOF01Combo { get; set; } = string.Empty;
        public string APSupplierOOF02Combo { get; set; } = string.Empty;
        public string APSupplierOOF03Combo { get; set; } = string.Empty;
        public string APSupplierOOF04Combo { get; set; } = string.Empty;
        public string APSupplierOOF05Combo { get; set; } = string.Empty;
        public string APSupplierOOF06Combo { get; set; } = string.Empty;
        public string APSupplierOOF07Combo { get; set; } = string.Empty;
        public string APSupplierOOF08Combo { get; set; } = string.Empty;
        public string APSupplierOOF09Combo { get; set; } = string.Empty;
        public string APSupplierOOF10Combo { get; set; } = string.Empty;
        public string APSupplierOOF11Combo { get; set; } = string.Empty;
        public string APSupplierOOF12Combo { get; set; } = string.Empty;
        public string APSupplierOOF13Combo { get; set; } = string.Empty;
        public string APSupplierOOF14Combo { get; set; } = string.Empty;
        public string APSupplierOOF15Combo { get; set; } = string.Empty;
        public int FK_APPOID { get; set; }
        public string GLTOF01Combo { get; set; } = string.Empty;
        public string GLTOF02Combo { get; set; } = string.Empty;
        public string GLTOF03Combo { get; set; } = string.Empty;
        public string GLTOF04Combo { get; set; } = string.Empty;
        public string GLTOF05Combo { get; set; } = string.Empty;
        public string GLTOF06Combo { get; set; } = string.Empty;
        public string GLTOF07Combo { get; set; } = string.Empty;
        public string GLTOF08Combo { get; set; } = string.Empty;
        public string GLTOF09Combo { get; set; } = string.Empty;
        public string GLTOF10Combo { get; set; } = string.Empty;
        public string GLTOF11Combo { get; set; } = string.Empty;
        public string GLTOF12Combo { get; set; } = string.Empty;
        public string GLTOF13Combo { get; set; } = string.Empty;
        public string GLTOF14Combo { get; set; } = string.Empty;
        public string GLTOF15Combo { get; set; } = string.Empty;
        public string ICProductIOF01Combo { get; set; } = string.Empty;
        public string ICProductIOF02Combo { get; set; } = string.Empty;
        public string ICProductIOF03Combo { get; set; } = string.Empty;
        public string ICProductIOF04Combo { get; set; } = string.Empty;
        public string ICProductIOF05Combo { get; set; } = string.Empty;
        public string ICProductIOF06Combo { get; set; } = string.Empty;
        public string ICProductIOF07Combo { get; set; } = string.Empty;
        public string ICProductIOF08Combo { get; set; } = string.Empty;
        public string ICProductIOF09Combo { get; set; } = string.Empty;
        public string ICProductIOF10Combo { get; set; } = string.Empty;
        public string ICProductIOF11Combo { get; set; } = string.Empty;
        public string ICProductIOF12Combo { get; set; } = string.Empty;
        public string ICProductIOF13Combo { get; set; } = string.Empty;
        public string ICProductIOF14Combo { get; set; } = string.Empty;
        public string ICProductIOF15Combo { get; set; } = string.Empty;
        public int FK_ICReceiptID { get; set; }
        public int FK_ICProductID { get; set; }
    }
    public class ViewPurchaseCost
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_ICProductID { get; set; }
        public int FK_APPOID { get; set; }
    }
    public class ViewTrackingPO_Detail
    {
        public List<View_TrackingPOPurchaseCostsInfo> lstViewTrackingPOPurchaseCosts { get; set; } = new List<View_TrackingPOPurchaseCostsInfo>();
        public List<View_TrackingPOPostReceiptsInfo> lstViewTrackingPOPostReceipts { get; set; } = new List<View_TrackingPOPostReceiptsInfo>();
        public List<View_TrackingPOPostServiceInvoicesInfo> lstView_TrackingPOPostServiceInvoices { get; set; } = new List<View_TrackingPOPostServiceInvoicesInfo>();
    }
    public class ViewPurchaseCostPost
    {
        public int ICProductID { get; set; }
        public string NotePostDocument { get; set; } = string.Empty;
        public int APPInvoiceItemID { get; set; }
        public int APPurchaseCostItemID { get; set; }
    }
    public class ViewRptProductionSchedule
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_PPWOID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_PPWorkCenterID { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
        public string LotNo { get; set; }
    }
    public class ViewRptProductionSO
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_BRBranchID { get; set; }
        public int FK_ARCustomerID { get; set; }
        public int FK_ICProductID { get; set; }
        public string ARSONo { get; set; }
    }
    public class ViewRptProductInventory
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_ICProductTypeID { get; set; }
        public string ICProductNo { get; set; }
    }
    public class ShipmentSearchFromPPurchaseExchange : DocDefaultSearch
    {
        public int FK_APPOID { get; set; }    
    }
    public class ViewSaleReturnMonitor
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_ARCustomerID { get; set; }
        public int FK_ARSellerID { get; set; }
        public string ARCustomerOOF01Combo { get; set; } = string.Empty;
        public string ARCustomerOOF02Combo { get; set; } = string.Empty;
        public string ARCustomerOOF03Combo { get; set; } = string.Empty;
        public string ARCustomerOOF04Combo { get; set; } = string.Empty;
        public string ARCustomerOOF05Combo { get; set; } = string.Empty;
        public string ARCustomerOOF06Combo { get; set; } = string.Empty;
        public string ARCustomerOOF07Combo { get; set; } = string.Empty;
        public string ARCustomerOOF08Combo { get; set; } = string.Empty;
        public string ARCustomerOOF09Combo { get; set; } = string.Empty;
        public string ARCustomerOOF10Combo { get; set; } = string.Empty;
        public string ARCustomerOOF11Combo { get; set; } = string.Empty;
        public string ARCustomerOOF12Combo { get; set; } = string.Empty;
        public string ARCustomerOOF13Combo { get; set; } = string.Empty;
        public string ARCustomerOOF14Combo { get; set; } = string.Empty;
        public string ARCustomerOOF15Combo { get; set; } = string.Empty;
        public string ARSaleReturnNo { get; set; } = string.Empty;
        public string GLTOF01Combo { get; set; } = string.Empty;
        public string GLTOF02Combo { get; set; } = string.Empty;
        public string GLTOF03Combo { get; set; } = string.Empty;
        public string GLTOF04Combo { get; set; } = string.Empty;
        public string GLTOF05Combo { get; set; } = string.Empty;
        public string GLTOF06Combo { get; set; } = string.Empty;
        public string GLTOF07Combo { get; set; } = string.Empty;
        public string GLTOF08Combo { get; set; } = string.Empty;
        public string GLTOF09Combo { get; set; } = string.Empty;
        public string GLTOF10Combo { get; set; } = string.Empty;
        public string GLTOF11Combo { get; set; } = string.Empty;
        public string GLTOF12Combo { get; set; } = string.Empty;
        public string GLTOF13Combo { get; set; } = string.Empty;
        public string GLTOF14Combo { get; set; } = string.Empty;
        public string GLTOF15Combo { get; set; } = string.Empty;
        public string sKeyBranch { get; set; } = string.Empty;
    }
    public class ViewAPPriceListStatistic
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_APSupplierID { get; set; }
        public int FK_ICProductID { get; set; }

    }
    public class ComplainSupplier : DocDefaultSearch
    {

        public int FK_APSupplierID { get; set; }
        public int FK_ARSOID { get; set; }
        public string LotNo { get; set; }
        public int FK_ICProductID { get; set; }
    }
    public class SearchReceiptFromComplain : DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_APPOID { get; set; }
    }
    public class SearchComplainFromPurchaseReturn : DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
    }
    public class PurchaseReceiptOSSearch : DocDefaultSearch
    {
        public int FK_ICProductID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_APSupplierID { get; set; }
        public int FK_ARCustomerID { get; set; }
    }
    public class PurchaseReceiptOSSearchDetail : DocDefaultSearch
    {
        public int FK_ICProductID { get; set; }
        public string ICReceiptItemFGLotNo { get; set; }
    }
    public class PlanMaintenanceSearch : DocDefaultSearch
    {
        public string PPPlanMaintenanceStatusCombo { get; set; }
    }
    public class PPPlanMaintenanceApprove: PPPlanMaintenancesInfo
    {
        public int FK_ADApprovalProcStepID { get; set; }
        public int displayReject { get; set; }
        public int ADInboxItemID { get; set; }
    }
    public class ComplainInternal : DocDefaultSearch
    {

        public int FK_ARCustomerID { get; set; }
        public int FK_ARSOID { get; set; }
        public string LotNo { get; set; }
        public int FK_ICProductID { get; set; }
    }
    public class STUserGroupAppModule_New: STUserGroupAppModules
    {
        public string STAppModuleType { get; set; } = String.Empty;
        public string STAppModuleBIUrl { get; set; } = String.Empty;
    }
    public class SaleChangeSearch: DocDefaultSearch
    {
        public int FK_ARCustomerID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_GLTranCfgID { get; set; }
    }
    public class SearchComplainFromSaleChange : DocDefaultSearch
    {
        public int FK_ARCustomerID { get; set; }
    }
    public class SearchShipmentFromSaleChange:DocDefaultSearch
    {
        public int FK_ARCustomerID { get; set; }
    }
    public class PurchaseExchangeSearch:DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
        public int FK_BRBranchID { get; set; }
    }
    public class SearchComplainPurchaseExchange : DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
    }
    public class SearchReceiptFromPurchaseExchange:DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
    }
    public class NotifyComment
    {
        public string ADInboxItemDocType { get; set; } = string.Empty;
        public int ADInboxItemObjectID { get; set; }
        public string ADMailToUsers { get; set; } = string.Empty;
        public string ADInboxItemMessage { get; set; } = string.Empty;
    }
    public class ScanPallet
    {
        public string PalletBarCode { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
        public string sBRBranchID { get; set; }=string.Empty;
    }
    public class DatMES
    {
        public string TagName { get; set; } = string.Empty;
        public object Data { get; set; }
        public string DataType { get; set; } = string.Empty;
    }
    public class TaskhDocumentSearch
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public string ModuleName { get; set; } = string.Empty;
    }
    public class SearchProductionOrdrEstFGs: DocDefaultSearch
    {
        public string qcStatus { get; set; } = string.Empty;
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_PPWorkCenterID { get; set; }
        public int FK_ICProductID { get; set; }
        public int pageNo { get; set; } = 0;
        public int numberRows { get; set; } = 0;
    }
    public class NotifyProjectTask
    {
        public int ADInboxItemObjectID { get; set; }
        public string ADMailToUsers { get; set; } = string.Empty;
        public string ADInboxItemSubject { get; set; } = string.Empty;
    }
    public class ReplaceTemRFID
    {
        public string CustomerName { get; set; } = string.Empty;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public string desc { get; set; } = string.Empty;
    }
    public class SearchContractFromSO : DocDefaultSearch
    {
        public int FK_ARCustomerID { get; set; }
    }
    public class SearchSaleForecastFromSO : DocDefaultSearch
    {
        public int FK_ARCustomerID { get; set; }
    }
    public class SearchRO : DocDefaultSearch
    {
        public int FK_ARCustomerID { get; set; }
        public int FK_BRBranchID { get; set; }
        public string ModuleName { get; set; }
    }
    public class ICRequestReceiptSearch
    {
        public string DocNo { get; set; } = string.Empty;
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_ICProductID { get; set; }

    }
    public class ShipmentSearch: DocDefaultSearch
    {
        public int FK_ICProductID { get; set; }
        public string ModuleName { get; set; }
        public int FK_ARCustomerID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_GLTranCfgID { get; set; }
    }
    public class ShipmentActionNew
    {
        public string ModuleName { get; set; }
    }
    public class ReceiptSearch : DocDefaultSearch
    {
        public int FK_ICProductID { get; set; }
        public string ModuleName { get; set; }
        public int FK_ARCustomerID { get; set; }
        public int FK_APSupplierID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_GLTranCfgID { get; set; }
    }
    public class ReceiptActionNew
    {
        public string ModuleName { get; set; }
    }
    public class TransferSearch : DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
        public int FK_ICFromStockID { get; set; }
        public int FK_ICToStockID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_ICProductID { get; set; }
    }
    public class RptROProductionDrilldown : DocDefaultSearch
    {
        public int FK_BRBranchID { get; set; }
        public int FK_PPProductionOrdrID { get; set; }
        public int ICROItemID { get; set; }
    }
    public class RptROProductionDrilldownShip : DocDefaultSearch
    {
        public int FK_BRBranchID { get; set; }
        public int FK_PPProductionOrdrID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_PPWOID { get; set; }
    }
    public class EmployeeOvertimeSearch
    {
        public string DocNo { get; set; } = string.Empty;
        public DateTime fromDate { get; set; } = DateTime.Now;
        public DateTime toDate { get; set; } = DateTime.Now;
        public int isApprove { get; set; } = 0;
        public string ApprovalStatusCombo { get; set; }
        public int id { get; set; } = 0;
    }
    public class EmployeeOffWorkSearch
    {
        public string DocNo { get; set; } = string.Empty;
        public DateTime fromDate { get; set; } = DateTime.Now;
        public DateTime toDate { get; set; } = DateTime.Now;
        public int isApprove { get; set; } = 0;
        public string ApprovalStatusCombo { get; set; }
        public int id { get; set; } = 0;
    }
    public class TravelCalendarSearch
    {
        public string DocNo { get; set; } = string.Empty;
        public DateTime fromDate { get; set; } = DateTime.Now;
        public DateTime toDate { get; set; } = DateTime.Now;
        public int isApprove { get; set; } = 0;
        public string ApprovalStatusCombo { get; set; }
        public int id { get; set; } = 0;
    }
    public class ProductionOrdrSearch : DocDefaultSearch
    {
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_PPResourceID { get; set; }
        public int FK_ICProductID { get; set; }
        public string moduleName { get; set; }
    }
    public class ProductionOrdrActionNew
    {
        public string ModuleName { get; set; }
    }
    public class ProductionOrdrParamSearch : DocDefaultSearch
    {
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_PPResourceID { get; set; }
        public int FK_ICProductID { get; set; }
        public string moduleName { get; set; }
    }
    public class ProductionOrdrQCSearch : DocDefaultSearch
    {
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_PPResourceID { get; set; }
        public int FK_ICProductID { get; set; }
        public string moduleName { get; set; }
    }
    public class InvUOMLotNoSlotGetModuleName
    {
        public string type {get; set; }
        public int docID { get; set; }
    }
    public class SearchFromWO 
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int PPWOID { get; set; }
        public int PPPhaseCfgID { get; set; }
        public int PPWorkCenterID { get; set; }
        public int PPRoutingID { get; set; }
        public int BranchID { get; set; }
        public bool ViewOrdrRQty { get; set; } = false;
        public bool ViewCalQty { get; set; } = false;
    }
    public class SearchFromPlan
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_PPWOPlanID { get; set; }
        public int FK_PPPhaseCfgGroupID { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
    }
    public class SearchFromPlanItems
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_PPWOPlanID { get; set; }
        public int FK_PPPhaseCfgGroupID { get; set; }
        public int FK_PPPhaseCfgID { get; set; }

        public int PPWOPlanItemID { get; set; }
        public int FK_PPPhaseCfgIDItemFocus { get; set; }

    }
    public class UpdateReadNotify
    {
        public string ADInboxItemID { get; set; } = string.Empty;
    }
    public class SearchWOR : DocDefaultSearch
    {
        public int FK_ARSOID { get; set; }
    }
    public class SearchSOFromWOR
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
    }
    public class CostSimulationSearch : DocDefaultSearch
    {
        public int FK_ICProductID { get; set; }
        public int FK_HREmployeeID { get; set; }
    }
    public class SearchQuot : DocDefaultSearch
    {
        public int FK_ARCustomerID { get; set; }
        public int FK_ARSellerID { get; set; }
        public string ARQuotRef { get; set; }
        public string ARQuotCusRef { get; set; }
        public string ARQuotStatusCombo { get; set; }
        public int FK_ICProductID { get; set; }
    }
    public class WOSearch : DocDefaultSearch
    {
        public int FK_BRBranchID { get; set; }
        public int FK_HREmployeeID { get; set; }
        public int FK_ICProductID { get; set; }
    }
    public class WOMRPSearch : DocDefaultSearch
    {

    }
    public class SearchWOFromWOMRP:DocDefaultSearch
    {

    }
    public class SearchQCFromTransfer : DocDefaultSearch
    {
        public string strPONo { get; set; }
        public string strReceiptNo { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_APSupplierID { get; set; }
    }

    public class InvQueryInOutPhaseSearch 
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_ICProductID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_PMProjectID { get; set; }
        public int FK_PMProjectPhaseID { get; set; }
        public string Module { get; set; }
    }
    public class SearchINRPTProjectInventory
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iStockID { get; set; }
        public int iStockTypeID { get; set; }
        public int iProductID { get; set; }
        public int iProductTypeID { get; set; }
        public int iProductGroupID { get; set; }
        public int iDimention1ID { get; set; }
        public int iDimention2ID { get; set; }
        public int iDimention3ID { get; set; }
        public int iDimention4ID { get; set; }
        public int iDimention5ID { get; set; }
        public int iProjectID { get; set; }
    }
    public class SearchINRPTProjectInventoryDetail
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iProductID { get; set; }
        public int iStockID { get; set; }
        //public int iICUOMID { get; set; }
        //public int iStockTypeID { get; set; }
        public string strLotNo { get; set; }

    }
    public class SearchINRPTProjectInventoryDetailStock
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
       // public int iProductID { get; set; }
        public int iStockID { get; set; }
        //public int iICUOMID { get; set; }
        //public int iStockTypeID { get; set; }
        public string strLotNo { get; set; }

    }
    public class SearchINRPTProjectPhaseInventory
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iStockID { get; set; }
        public int iStockTypeID { get; set; }
        public int iProductID { get; set; }
        public int iProductTypeID { get; set; }
        public int iProductGroupID { get; set; }
        public int iDimention1ID { get; set; }
        public int iDimention2ID { get; set; }
        public int iDimention3ID { get; set; }
        public int iDimention4ID { get; set; }
        public int iDimention5ID { get; set; }
        public int iProjectID { get; set; }
        public int iPhaseID { get; set; }

    }
    public class SearchINRPTProjectPhaseInventoryDetail
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iProductID { get; set; }
        public int iStockID { get; set; }
        //public int iICUOMID { get; set; }
        //public int iStockTypeID { get; set; }
        public string strLotNo { get; set; }
    }
    public class SearchINRPTProjectPhaseInventoryDetailStock
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
      //  public int iProductID { get; set; }
        public int iStockID { get; set; }
        //public int iICUOMID { get; set; }
        //public int iStockTypeID { get; set; }
        public string strLotNo { get; set; }

    }

    public class SearchPOMonitor_SB
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int iSupplierID { get; set; }
        public int iEmployee { get; set; }
        public string APPRNo { get; set; }
        public int iProjectID { get; set; }
        public int iPhaseID { get; set; }
    }
    public class ViewRptRequestReceipt:DocDefaultSearch
    {

    }
    public class SearchRptInventoryAge
    {
        public DateTime date { get; set; } = DateTime.Now;
        public int FK_BRBranchID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_ICProductID { get; set; }
    }
    public class SearchRptInventoryAgeExpire
    {
        public DateTime date { get; set; } = DateTime.Now;
        public int FK_BRBranchID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_ICProductID { get; set; }
        public int iDayReview { get; set; }
    }
    public class SearchJTProductionResultTool
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;

    }
    public class SearchRptTrackingWO
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public string PPWONo { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_ARSOID { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_ICProductID { get; set; }
    }
    public class ViewQCProductionRpt
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_PPWOID { get; set; }
        public string viewCard { get; set; }
        public int FK_PPProductionOrdrJobID { get; set; }
        public int FK_PPProductionOrdrID { get; set; }
    }
    public class SearchDeliveryStatusTrackingRpt
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_PPWOID { get; set; }
        public int FK_APPOID { get; set; }
    }
    public class SearchDeliveryStatusTrackingRptDetail: SearchDeliveryStatusTrackingRpt
    {
        public int APPOItemID { get; set; }
    }
    public class SearchPOMonitorWO
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_PPWOID { get; set; }
        public int FK_APPOID { get; set; }
        public int FK_APSupplierID { get; set; }
    }
    public class SearchPOMonitorWODetail: SearchPOMonitorWO
    {
        public int FK_APPOItemID { get; set; }
    }
    public class SearchWOEstRMItemDetails
    {
        public int FK_PPWOID { get; set; }
        public int FK_ARSOID { get; set; }
        public int FK_ICProductID { get; set; }
    }
    public class SearchWOEstRMItemTotal: SearchWOEstRMItemDetails
    {

    }
    public class SearchWOEstRMItemTotalDetails : SearchWOEstRMItemDetails
    {

    }
    public class SearchWOEstRMItemSOWO : SearchWOEstRMItemDetails
    {
    }
    public class SearchWOEstRMItemSOWODetails : SearchWOEstRMItemDetails
    {
       public int FK_APPOItemID { get; set; }
    }
    public class SearchClaimRptSupplier
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_APSupplierID { get; set; }
        public int FK_ICProductID { get; set; }
        public string DocNo { get; set; }=string.Empty;
        public string LotNo { get; set; } = string.Empty;
    }
    public class SearchClaimRptCustomer
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_ARCustomerID { get; set; }
        public int FK_ICProductID { get; set; }
        public string DocNo { get; set; } = string.Empty;
        public string LotNo { get; set; } = string.Empty;
    }
    public class SearchInternalNCR
    {
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_ICProductID { get; set; }
        public string DocNo { get; set; } = string.Empty;
    }
    public class SearchRelatedTransHistory
    {
        public string ModuleName { get; set; } = string.Empty;
        public string MainTableName { get; set; } = string.Empty;
        public int DocID { get; set; }
    }
    public class RelatedTransHistory
    {
        public List<ViewRelatedTransHistorysInfo> lstViewRelatedTransHistorysFrom { get; set; } = new List<ViewRelatedTransHistorysInfo>();
        public List<ViewRelatedTransHistorysInfo> lstViewRelatedTransHistorysTo { get; set; } = new List<ViewRelatedTransHistorysInfo>();

    }
    public class SearchSTFieldFormatGroup
    {
        public string ModuleName { get; set; } = string.Empty;
        public string TableName { get; set; } = string.Empty;
        public string ColumnName { get; set; } = string.Empty;
    }
    public class FtpUploadedFileResult
    {
        public string OriginalFileName { get; set; } // tên file gốc
        public string StoredFileName { get; set; }   // tên file lưu FTP
        public string FileUrl { get; set; }          // đường dẫn FTP
    }
    public class MESData
    {
        public string colName { get; set; } = string.Empty;
        public string tableName { get; set; } = string.Empty;
        public object value { get; set; }
    }
    public class TCPIP
    {
        public string IP { get; set; } = string.Empty;
        public int Port { get; set; }
    }
    public class SearchQuotFromSO : DocDefaultSearch
    {
        public int FK_ARCustomerID { get; set; }
    }
    public class SearchPOFromSO : DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
        public int FK_BRBranchID { get; set; }
    }
    public class SearchSOFromInvoice : DocDefaultSearch
    {
        public int FK_ARCustomerID { get; set; }
        public int FK_ARSellerID { get; set; }
    }
    public class SearchInvoiceFromSaleReturn :DocDefaultSearch
    {
        public int FK_ARCustomerID { get; set; }
        public int FK_BRBranchID { get; set; }
        public string SaleReturnStatusCombo { get; set; }
    }
    public class SearchPInvoicePurchaseFromReceipt: DocDefaultSearch
    {
        public int FK_APSupplierID { get; set; }
        public int FK_APPOID { get; set; }
    }
    public class AttachmentDocUpload
    {
        public string module { get; set; }
        public int docID { get; set; }
        public string desc { get; set; }
        public IFormFile files { get; set; }
    }
}

