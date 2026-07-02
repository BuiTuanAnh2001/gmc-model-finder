using gmc_api.Base.dto;
using gmc_api.DTO.PO;
using gmc_api.DTO.PP;
using gmc_api.DTO.Shipment;
using gmc_api.Entities;
using gmc_api.Entities.IC.Receipt;
using gmc_api.Entities.PP;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.Json.Serialization;

namespace gmc_api.DTO
{
    public class ROEntities
    {
        public ICROs MainObject { get; set; } = new ICROs();
        public ICROItems ItemObject { get; set; } = new ICROItems();
        public List<ICROItems> lstICROItems { get; set; } = new List<ICROItems>();

    }

    public class VoucherEntity
    {
        public GLVouchers MainObject { get; set; } = new GLVouchers();
        public List<GLVoucherItems> lstGLVoucherItems { get; set; } = new List<GLVoucherItems>();

    }
    public class CountInventoryResultEntity
    {
        public ICCountInventoryResultsInfo MainObject { get; set; } = new ICCountInventoryResultsInfo();
        public ICCountInventoryResultItemsInfo ItemObject { get; set; } = new ICCountInventoryResultItemsInfo();
        public List<ICCountInventoryResultItemsInfo> lstICCountInventoryResultItems { get; set; } = new List<ICCountInventoryResultItemsInfo>();

    }

    public class ProductionOrdrEntity
    {
        public PPProductionOrdrs MainObject { get; set; } = new PPProductionOrdrs();
        public List<PPProductionOrdrEstFGs> lstPPProductionOrdrEstFGs { get; set; } = new List<PPProductionOrdrEstFGs>();
        public List<PPProductionOrdrEstRMs> lstPPProductionOrdrEstRMs { get; set; } = new List<PPProductionOrdrEstRMs>();

    }
    public class ProductionEntity
    {
        public PPProductionOrdrs MainObject { get; set; } = new PPProductionOrdrs();
        public ProductionOrdrEstFGItemEntity ItemObject { get; set; } = new ProductionOrdrEstFGItemEntity();
        public List<ProductionOrdrEstFGItemEntity> lstPPProductionOrdrEstFGs { get; set; } = new List<ProductionOrdrEstFGItemEntity>();
        public List<PPProductionOrdrEstRMs> lstPPProductionOrdrEstRMs { get; set; } = new List<PPProductionOrdrEstRMs>();
        public List<PPProductionOrdrFGLinkBarcodesInfo> lstPPProductionOrdrFGLinkBarcodes { get; set; } = new List<PPProductionOrdrFGLinkBarcodesInfo>();
        public List<ProductionOrdrEstFGItemEntity> lstFGLinkBarcode { get; set; } = new List<ProductionOrdrEstFGItemEntity>();
        public List<ICShipmentItems> lstRMShipmentItemPaperCut { get; set; } = new List<ICShipmentItems>();
    }

    public class ARPriceListEntity
    {
        public ARPriceLists MainObject { get; set; } = new ARPriceLists();
        public ARPriceListDetails ItemObject { get; set; } = new ARPriceListDetails();
        public List<ARPriceListDetails> lstARPriceListDetails { get; set; } = new List<ARPriceListDetails>();

    }
    public class APPriceListEntities
    {
        public APPriceLists MainObject { get; set; } = new APPriceLists();
        public APPriceListDetails ItemObject { get; set; } = new APPriceListDetails();
        public List<APPriceListDetails> lstAPPriceListDetails { get; set; } = new List<APPriceListDetails>();

    }
    public class TranferItemTotal
    {
        public ICTransferItems ItemTotal { get; set; } = new ICTransferItems();
        public List<TransferItemsEntity> lstICTransferItemAllocates { get; set; } = new List<TransferItemsEntity>();
    }
    public class TranfersEntity
    {
        public ICTransfers MainObject { get; set; } = new ICTransfers();
        public TransferItemsEntity ItemObject { get; set; } = new TransferItemsEntity(); //bổ sung thêm
        public List<ICTransferROs> lstICTransferROs { get; set; } = new List<ICTransferROs>();
        public List<ICTransferQCsInfo> lstICTransferQCs { get; set; } = new List<ICTransferQCsInfo>();
        public List<ICReceiptItemsInfo> lstICReceiptItems
        { get; set; } = new List<ICReceiptItemsInfo>();
        public List<TransferItemsEntity> lstICTransferItems { get; set; } = new List<TransferItemsEntity>();
        public List<TranferItemTotal> lstDicTotal { get; set; } = new List<TranferItemTotal>();

    }
    public class POPurchaseReceiptQCEntity
    {
        public ICReceiptsInfo MainObject { get; set; } = new ICReceiptsInfo();
        public List<ICReceiptItemsInfo> lstICReceiptItems { get; set; } = new List<ICReceiptItemsInfo>();
    }

    public class PInvoiceEntities
    {
        public APPInvoicesInfo MainObject { get; set; } = new APPInvoicesInfo();
        public PInvoiceItemsEntity ItemObject { get; set; } = new PInvoiceItemsEntity();
        public List<PInvoiceItemsEntity> lstAPPInvoiceItems { get; set; } = new List<PInvoiceItemsEntity>();
        public List<APPInvoiceReceiptsInfo> lstAPPInvoiceReceipts { get; set; } = new List<APPInvoiceReceiptsInfo>();
        public List<GLVoucherTransactionItemsInfo> lstGLVoucherTransactionItems { get; set; } = new List<GLVoucherTransactionItemsInfo>(); //list màn hình cấn trừ
        public List<APPInvoicePOsInfo> lstAPPInvoicePOs { get; set; } = new List<APPInvoicePOsInfo>();
    }
    public class InvoiceEntities
    {
        public ARInvoicesInfo MainObject { get; set; } = new ARInvoicesInfo();
        public InvoiceItemsEntity ItemObject { get; set; } = new InvoiceItemsEntity();
        public List<InvoiceItemsEntity> lstARInvoiceItems { get; set; } = new List<InvoiceItemsEntity>();
        public List<ARInvoiceShipmentsInfo> lstARInvoiceShipments { get; set; } = new List<ARInvoiceShipmentsInfo>();
        public List<ARInvoiceItemKitsInfo> lstARInvoiceItemKits { get; set; } = new List<ARInvoiceItemKitsInfo>();
        public List<GLVoucherTransactionItemsInfo> lstGLVoucherTransactionItems { get; set; } = new List<GLVoucherTransactionItemsInfo>(); //list màn hình cấn trừ
    }
    public class ComplainEntities
    {
        public ARComplainsInfo MainObject { get; set; } = new ARComplainsInfo();
        public ComplainItemsEntity ItemObject { get; set; } = new ComplainItemsEntity();
        public List<ComplainItemsEntity> lstARComplainItems { get; set; } = new List<ComplainItemsEntity>();
    }
    public class ResultMaintenanceEntities
    {
        public PPMaintenanceResultsInfo MainObject { get; set; } = new PPMaintenanceResultsInfo();
        public PPMaintenanceResultItemsInfo ItemObject { get; set; } = new PPMaintenanceResultItemsInfo();
        public List<PPMaintenanceResultItemsInfo> lstPPMaintenanceResultItems { get; set; } = new List<PPMaintenanceResultItemsInfo>();
        public List<PPMaintenanceResultRMsInfo> lstPPMaintenanceResultRMs { get; set; } = new List<PPMaintenanceResultRMsInfo>();
        public List<PPMaintenanceResultUsersInfo> lstPPMaintenanceResultUsers { get; set; } = new List<PPMaintenanceResultUsersInfo>();
    }
    public class MaintenanceOEntities
    {
        public PPMaintenanceOsInfo MainObject { get; set; } = new PPMaintenanceOsInfo();
        public PPMaintenanceOItemsInfo ItemObject { get; set; } = new PPMaintenanceOItemsInfo();
        public List<PPMaintenanceOItemsInfo> lstPPMaintenanceOItems { get; set; } = new List<PPMaintenanceOItemsInfo>();
        public List<PPMaintenanceORMsInfo> lstPPMaintenanceORMs { get; set; } = new List<PPMaintenanceORMsInfo>();
        public List<PPMaintenanceOUsersInfo> lstPPMaintenanceOUsers { get; set; } = new List<PPMaintenanceOUsersInfo>();
    }
    public class PlanMaintenanceEntities
    {
        public PPPlanMaintenancesInfo MainObject { get; set; } = new PPPlanMaintenancesInfo();
        public PPPlanMaintenanceItemsInfo ItemObject { get; set; } = new PPPlanMaintenanceItemsInfo();
        public List<PPPlanMaintenanceItemsInfo> lstPPPlanMaintenanceItems { get; set; } = new List<PPPlanMaintenanceItemsInfo>();
        public List<PPPlanMaintenanceItemCategorysInfo> lstPPPlanMaintenanceItemCategorys { get; set; } = new List<PPPlanMaintenanceItemCategorysInfo>();
    }
    public class PlanMaintenanceItemApprove
    {

        public List<PPPlanMaintenanceItemsInfo> lstPPPlanMaintenanceItems { get; set; } = new List<PPPlanMaintenanceItemsInfo>();
        public List<PPPlanMaintenanceItemCategorysInfo> lstPPPlanMaintenanceItemCategorys { get; set; } = new List<PPPlanMaintenanceItemCategorysInfo>();
    }
    public class CustomerEntities
    {
        public ARCustomersInfo MainObject { get; set; } = new ARCustomersInfo();
        public ARCustomerConsInfo ItemObject { get; set; } = new ARCustomerConsInfo();
        public List<ARCustomerConsInfo> lstARCustomerCons { get; set; } = new List<ARCustomerConsInfo>();
        public List<ARCustomerBanksInfo> lstARCustomerBanks { get; set; } = new List<ARCustomerBanksInfo>();

    }
    public class CustomerActivityEntities
    {
        public ARCustomerActivitysInfo MainObject { get; set; } = new ARCustomerActivitysInfo();
    }
    public class ROProductionOrdrEntities
    {
        public ICROs MainObject { get; set; } = new ICROs();
        public ICROItems ItemObject { get; set; } = new ICROItems();
        public List<ICROItems> lstICROItems { get; set; } = new List<ICROItems>();

    }
    public class CustomerReqEntities
    {
        public ARCustomerReqsInfo MainObject { get; set; } = new ARCustomerReqsInfo();
        public CustomerProductReqItemsEntity ItemObject { get; set; } = new CustomerProductReqItemsEntity();
        public List<CustomerProductReqItemsEntity> lstARCustomerProductReqItems { get; set; } = new List<CustomerProductReqItemsEntity>();
    }
    public class POOSEntities
    {
        public APPOsInfo MainObject { get; set; } = new APPOsInfo();
        public POOSItemsEntity ItemObject { get; set; } = new POOSItemsEntity();
        public List<POOSItemsEntity> lstAPPOItems { get; set; } = new List<POOSItemsEntity>();
        public List<APPOBOMItemsInfo> lstAPPOBOMItemsTemp { get; set; } = new List<APPOBOMItemsInfo>(); //list tạm để chia tab NVl ra riêng
    }
    public class TranferOSEntity
    {
        public ICTransfers MainObject { get; set; } = new ICTransfers();
        public TransferItemsEntity ItemObject { get; set; } = new TransferItemsEntity();
        public List<ICTransferROs> lstICTransferROs { get; set; } = new List<ICTransferROs>();
        public List<TransferItemsEntity> lstICTransferItems { get; set; } = new List<TransferItemsEntity>();

    }
    public class FGReceiptOSEntities
    {
        public ICReceiptsInfo MainObject { get; set; } = new ICReceiptsInfo();
        public ReceiptItemsEntity ItemObject { get; set; } = new ReceiptItemsEntity();
        public List<ReceiptItemsEntity> lstICReceiptItems { get; set; } = new List<ReceiptItemsEntity>();
        // public List<ICReceiptItemsInfo> lstScanBarCode { get; set; } = new List<ICReceiptItemsInfo>();
        // public List<ICReceiptSaleReturnsInfo> lstICReceiptSaleReturns { get; set; } = new List<ICReceiptSaleReturnsInfo>();
        public List<ICReceiptPOs> lstICReceiptPOs { get; set; } = new List<ICReceiptPOs>(); //tạo từ PO
                                                                                            // public List<ICReceiptRequestReceipts> lstICReceiptRequestReceipts { get; set; } = new List<ICReceiptRequestReceipts>(); //tạo từ đề nghị nhập kho
    }
    public class RMShipmentOSEntities
    {
        public ICShipments MainObject { get; set; } = new ICShipments();
        public ShipmentItemsEntity ItemObject { get; set; } = new ShipmentItemsEntity();
        public List<ShipmentItemsEntity> lstICShipmentItems { get; set; } = new List<ShipmentItemsEntity>();

        //public List<ICReceiptItemsInfo> lstICReceiptItems
        //{ get; set; } = new List<ICReceiptItemsInfo>();
        //public List<ICShipmentPurchaseReturnsInfo> lstICShipmentPurchaseReturns { get; set; } = new List<ICShipmentPurchaseReturnsInfo>(); //link master trả hàng NCC
        //public List<ICShipmentROs> lstICShipmentROs { get; set; } = new List<ICShipmentROs>(); //link master đề nghị nhập kho
    }
    public class ROPOEntities
    {
        public ICROs MainObject { get; set; } = new ICROs();
        public ICROItems ItemObject { get; set; } = new ICROItems();
        public List<ICROItems> lstICROItems { get; set; } = new List<ICROItems>();

    }
    public class PInvoiceImportPurchaseReceiptEntities
    {
        public ICReceiptsInfo MainObject { get; set; } = new ICReceiptsInfo();
        public ReceiptItemsEntity ItemObject { get; set; } = new ReceiptItemsEntity();
        public List<ReceiptItemsEntity> lstICReceiptItems { get; set; } = new List<ReceiptItemsEntity>();
        public List<ICReceiptPInvoicesInfo> lstICReceiptPInvoices { get; set; } = new List<ICReceiptPInvoicesInfo>();

        //    public List<ICReceiptItemsInfo> lstScanBarCode { get; set; } = new List<ICReceiptItemsInfo>();
        //    public List<ICReceiptSaleReturnsInfo> lstICReceiptSaleReturns { get; set; } = new List<ICReceiptSaleReturnsInfo>();
        //    public List<ICReceiptPOs> lstICReceiptPOs { get; set; } = new List<ICReceiptPOs>(); //tạo từ PO
        //    public List<ICReceiptRequestReceipts> lstICReceiptRequestReceipts { get; set; } = new List<ICReceiptRequestReceipts>(); //tạo từ đề nghị nhập kho
    }
    public class SupplierEntities
    {
        public APSuppliersInfo MainObject { get; set; } = new APSuppliersInfo();
        public APSupplierConsInfo ItemObject { get; set; } = new APSupplierConsInfo();
        public List<APSupplierConsInfo> lstAPSupplierCons { get; set; } = new List<APSupplierConsInfo>();
        public List<APSupplierBanksInfo> lstAPSupplierBanks { get; set; } = new List<APSupplierBanksInfo>();
        public List<APSupplierCriteriasInfo> lstAPSupplierCriterias { get; set; } = new List<APSupplierCriteriasInfo>();
    }
    public class PInvoiceImportEntities
    {
        public APPInvoicesInfo MainObject { get; set; } = new APPInvoicesInfo();
        public PInvoiceItemsEntity ItemObject { get; set; } = new PInvoiceItemsEntity();
        public List<PInvoiceItemsEntity> lstAPPInvoiceItems { get; set; } = new List<PInvoiceItemsEntity>();
        //public List<APPInvoiceReceiptsInfo> lstAPPInvoiceReceipts { get; set; } = new List<APPInvoiceReceiptsInfo>();
        //public List<GLVoucherTransactionItemsInfo> lstGLVoucherTransactionItems { get; set; } = new List<GLVoucherTransactionItemsInfo>(); //list màn hình cấn trừ
        public List<APPInvoicePOsInfo> lstAPPInvoicePOs { get; set; } = new List<APPInvoicePOsInfo>();
        public List<APPInvoiceImportDocsInfo> lstAPPInvoiceImportDocs { get; set; } = new List<APPInvoiceImportDocsInfo>();
    }
    public class ProductEntities
    {
        public ICProductsInfo MainObject { get; set; } = new ICProductsInfo();
        public ICProductDocsInfo ItemObject { get; set; } = new ICProductDocsInfo();
        public List<ICProductUOMs> lstICProductUOMs { get; set; } = new List<ICProductUOMs>();
        public List<ICProductionUOMsInfo> lstICProductionUOMs { get; set; } = new List<ICProductionUOMsInfo>();
        public List<ICProductDocsInfo> lstICProductDocs { get; set; } = new List<ICProductDocsInfo>();
        public List<ICAccountSetsInfo> lstICAccountSets { get; set; } = new List<ICAccountSetsInfo>(); //list này chỉ 1 item
    }
    public class ApprovedPriceEntities
    {
        public APApprovedPricesInfo MainObject { get; set; } = new APApprovedPricesInfo();
        public APApprovedPriceItemsInfo ItemObject { get; set; } = new APApprovedPriceItemsInfo();
        public List<APApprovedPriceItemsInfo> lstAPApprovedPriceItems { get; set; } = new List<APApprovedPriceItemsInfo>();
        public List<APApprovedPriceSuppliersInfo> lstAPApprovedPriceSuppliers { get; set; } = new List<APApprovedPriceSuppliersInfo>();
        public List<APApprovedPriceCriteriasInfo> lstAPApprovedPriceCriterias { get; set; } = new List<APApprovedPriceCriteriasInfo>();
        public List<APPRItemRFQsInfo> lstAPPRItemRFQs { get; set; } = new List<APPRItemRFQsInfo>();
        public List<APApprovedPriceDocsInfo> lstAPApprovedPriceDocs { get; set; } = new List<APApprovedPriceDocsInfo>();
        public List<Dictionary<string, dynamic>> lstAPApprovedPriceItems_View { get; set; } = new List<Dictionary<string, dynamic>>();
        public List<APPRItemRFQsInfo> lstAPPRItemRFQAllocates_View { get; set; } = new List<APPRItemRFQsInfo>();
    }

    public class VoucherEntities
    {
        public GLVouchers MainObject { get; set; } = new GLVouchers();
        public GLVoucherItems ItemObject { get; set; } = new GLVoucherItems();
        public List<GLVoucherItems> lstGLVoucherItems { get; set; } = new List<GLVoucherItems>();
        public List<GLVoucherTransactionItemsInfo> lstGLVoucherTransactionItems { get; set; } = new List<GLVoucherTransactionItemsInfo>();
        public List<GLVoucherDocsInfo> lstGLVoucherDocs { get; set; } = new List<GLVoucherDocsInfo>();
        public List<GLVoucherFeeItemsInfo> lstGLVoucherFeeItems { get; set; } = new List<GLVoucherFeeItemsInfo>();
    }
    public class InPmtEntities : VoucherEntities
    {
        //public GLVouchers MainObject { get; set; } = new GLVouchers();
        //public GLVoucherItems ItemObject { get; set; } = new GLVoucherItems();
        //public List<GLVoucherItems> lstGLVoucherItems { get; set; } = new List<GLVoucherItems>();
        //public List<GLVoucherTransactionItemsInfo> lstGLVoucherTransactionItems { get; set; } = new List<GLVoucherTransactionItemsInfo>();
        //public List<GLVoucherDocsInfo> lstGLVoucherDocs { get; set; } = new List<GLVoucherDocsInfo>();
    }
    public class OutPmtEntities : VoucherEntities
    {
        //public GLVouchers MainObject { get; set; } = new GLVouchers();
        //public GLVoucherItems ItemObject { get; set; } = new GLVoucherItems();
        //public List<GLVoucherItems> lstGLVoucherItems { get; set; } = new List<GLVoucherItems>();
        //public List<GLVoucherTransactionItemsInfo> lstGLVoucherTransactionItems { get; set; } = new List<GLVoucherTransactionItemsInfo>();
        //public List<GLVoucherDocsInfo> lstGLVoucherDocs { get; set; } = new List<GLVoucherDocsInfo>();
    }
    public class PmtReqEntities : VoucherEntities
    {
        public List<GLVoucherItemPOSchPmtsInfo> lstGLVoucherItemPOSchPmts { get; set; } = new List<GLVoucherItemPOSchPmtsInfo>();
        //public GLVouchers MainObject { get; set; } = new GLVouchers();
        //public GLVoucherItems ItemObject { get; set; } = new GLVoucherItems();
        //public List<GLVoucherItems> lstGLVoucherItems { get; set; } = new List<GLVoucherItems>();
        //public List<GLVoucherTransactionItemsInfo> lstGLVoucherTransactionItems { get; set; } = new List<GLVoucherTransactionItemsInfo>();
        //public List<GLVoucherDocsInfo> lstGLVoucherDocs { get; set; } = new List<GLVoucherDocsInfo>();

    }
    public class CreditNoteEntities
    {
        public ARCreditNotesInfo MainObject { get; set; } = new ARCreditNotesInfo();
        public CreditNoteItemsEntity ItemObject { get; set; } = new CreditNoteItemsEntity();
        public List<CreditNoteItemsEntity> lstARCreditNoteItems { get; set; } = new List<CreditNoteItemsEntity>();
        public List<ARCreditNoteSaleReturnsInfo> lstARCreditNoteSaleReturns { get; set; } = new List<ARCreditNoteSaleReturnsInfo>();
    }

    public class APCreditNoteEntities
    {
        public APCreditNotesInfo MainObject { get; set; } = new APCreditNotesInfo();
        public APCreditNoteItemsEntity ItemObject { get; set; } = new APCreditNoteItemsEntity();
        public List<APCreditNoteItemsEntity> lstAPCreditNoteItems { get; set; } = new List<APCreditNoteItemsEntity>();
        public List<APCreditNotePInvoicesInfo> lstAPCreditNotePInvoices { get; set; } = new List<APCreditNotePInvoicesInfo>();
        public List<APCreditNoteShipmentsInfo> lstAPCreditNoteShipments { get; set; } = new List<APCreditNoteShipmentsInfo>();
    }
    public class PurchaseReceiptOSEntities
    {
        public ICReceiptsInfo MainObject { get; set; } = new ICReceiptsInfo();
        public ReceiptItemsEntity ItemObject { get; set; } = new ReceiptItemsEntity();
        public List<ReceiptItemsEntity> lstICReceiptItems { get; set; } = new List<ReceiptItemsEntity>();
        // public List<ICReceiptItemsInfo> lstScanBarCode { get; set; } = new List<ICReceiptItemsInfo>();
        // public List<ICReceiptSaleReturnsInfo> lstICReceiptSaleReturns { get; set; } = new List<ICReceiptSaleReturnsInfo>();
        public List<ICReceiptPOs> lstICReceiptPOs { get; set; } = new List<ICReceiptPOs>(); //tạo từ PO
                                                                                            // public List<ICReceiptRequestReceipts> lstICReceiptRequestReceipts { get; set; } = new List<ICReceiptRequestReceipts>(); //tạo từ đề nghị nhập kho
    }
    public class POItemDataRT
    {
        public List<APPOItemsInfo> lstAPPOItems { get; set; } = new List<APPOItemsInfo>();
        public List<APPOBOMItemsInfo> lstAPPOBOMItems { get; set; } = new List<APPOBOMItemsInfo>();
    }
    public class PurchaseExchangeEntities
    {
        public APPurchaseExchangesInfo MainObject { get; set; } = new APPurchaseExchangesInfo();
        public PurchaseExchangeItemsEntity ItemObject { get; set; } = new PurchaseExchangeItemsEntity();
        public List<PurchaseExchangeItemsEntity> lstAPPurchaseExchangeItems { get; set; } = new List<PurchaseExchangeItemsEntity>();
        public List<APPurchaseExchangeReceiptsInfo> lstAPPurchaseExchangeReceipts { get; set; } = new List<APPurchaseExchangeReceiptsInfo>();
    }
    public class GetDataInventoryPallet
    {
        public int FK_ICProductID { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public int FK_ICStockSlotID { get; set; }
        public decimal ICReceiptItemQty { get; set; }
        public decimal ICReceiptItemStkQty { get; set; }
        public string ICReceiptItemLotNo { get; set; } = string.Empty;
        public string ICReceiptItemSerialNo { get; set; } = string.Empty;
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
    }
    public class ProjectTaskDataViewBoard
    {
        public List<PMProjectTasksInfo> lstPMProjectTaskBacklogs { get; set; } = new List<PMProjectTasksInfo>();
        public List<PMProjectTasksInfo> lstPMProjectTaskTodos { get; set; } = new List<PMProjectTasksInfo>();
        public List<PMProjectTasksInfo> lstPMProjectTaskDoings { get; set; } = new List<PMProjectTasksInfo>();
        public List<PMProjectTasksInfo> lstPMProjectTaskDones { get; set; } = new List<PMProjectTasksInfo>();
    }
    public class ProjectTaskEntities
    {
        public PMProjectTasksInfo MainObject { get; set; } = new PMProjectTasksInfo();
        public List<PMProjectTaskDocsInfo> lstPMProjectTaskDocs { get; set; } = new List<PMProjectTaskDocsInfo>();
        public List<PMProjectTaskCommentsInfo> lstPMProjectTaskComments { get; set; } = new List<PMProjectTaskCommentsInfo>();
        public List<PMProjectTaskDocumentsInfo> lstPMProjectTaskDocuments { get; set; } = new List<PMProjectTaskDocumentsInfo>();

    }
    public class PrintTemShipment
    {
        public ICShipments MainObject { get; set; } = new ICShipments();
        public ShipmentItemsEntity ICShipmentItems { get; set; } = new ShipmentItemsEntity();
    }
    public class SOEntities
    {
        public ARSOsInfo MainObject { get; set; } = new ARSOsInfo();
        public SOItemsEntity ItemObject { get; set; } = new SOItemsEntity();
        public List<SOItemsEntity> lstARSOItems { get; set; } = new List<SOItemsEntity>();
        public List<ARQuotSOsInfo> lstARQuotSOs { get; set; } = new List<ARQuotSOsInfo>();
        public List<ARSOItemAttrsInfo> lstARSOItemAttrs { get; set; } = new List<ARSOItemAttrsInfo>();
        public List<ARSOPOsInfo> lstARSOPOs { get; set; }= new List<ARSOPOsInfo>();
    }
    public class POEntities
    {
        public APPOsInfo MainObject { get; set; } = new APPOsInfo();
        public POItemsEntity ItemObject { get; set; } = new POItemsEntity();
        public List<POItemsEntity> lstAPPOItems { get; set; } = new List<POItemsEntity>();
        public List<APPRPOsInfo> lstAPPRPOs { get; set; } = new List<APPRPOsInfo>();
        public List<APPOPurchaseCostItemsEntity> lstAPPOPurchaseCostItems { get; set; } = new List<APPOPurchaseCostItemsEntity>();
    }
    public class PREntities
    {
        public APPRsInfo MainObject { get; set; } = new APPRsInfo();
        public APPRItemsInfo ItemObject { get; set; } = new APPRItemsInfo();
        public List<APPRItemsInfo> lstAPPRItems { get; set; } = new List<APPRItemsInfo>();
    }
    public class RequestReceiptEntities
    {
        public ICRequestReceipts MainObject { get; set; } = new ICRequestReceipts();
        public RequestReceiptItemsEntity ItemObject { get; set; } = new RequestReceiptItemsEntity();
        public List<RequestReceiptItemsEntity> lstICRequestReceiptItems { get; set; } = new List<RequestReceiptItemsEntity>();
    }
    public class ProductionEntityAddDetail
    {
        public PPProductionOrdrs MainObject { get; set; } = new PPProductionOrdrs();
        public ProductionOrdrEstFGItemEntity objItem { get; set; } = new ProductionOrdrEstFGItemEntity();
        public List<ProductionOrdrEstFGItemEntity> lstPPProductionOrdrEstFGs { get; set; } = new List<ProductionOrdrEstFGItemEntity>();
        public List<PPProductionOrdrEstRMs> lstPPProductionOrdrEstRMs { get; set; } = new List<PPProductionOrdrEstRMs>();
        public List<PPProductionOrdrEstFGs> lstPPProductionOrdrEstFGCreateNews { get; set; } = new List<PPProductionOrdrEstFGs>(); //list item cần add vào

    }
    public class SaleReturnEntities
    {
        public ARSaleReturnsInfo MainObject { get; set; } = new ARSaleReturnsInfo();
        public SaleReturnItemsEntity ItemObject { get; set; } = new SaleReturnItemsEntity();
        public List<SaleReturnItemsEntity> lstARSaleReturnItems { get; set; } = new List<SaleReturnItemsEntity>();
        public List<ARSaleReturnShipmentsInfo> lstARSaleReturnShipments { get; set; } = new List<ARSaleReturnShipmentsInfo>();
        public List<ARSaleReturnInvoicesInfo> lstARSaleReturnInvoices { get; set; } = new List<ARSaleReturnInvoicesInfo>();
    }
    public class PurchaseReturnEntities
    {
        public APPurchaseReturnsInfo MainObject { get; set; } = new APPurchaseReturnsInfo();
        public PurchaseReturnItemsEntity ItemObject { get; set; } = new PurchaseReturnItemsEntity();
        public List<PurchaseReturnItemsEntity> lstAPPurchaseReturnItems { get; set; } = new List<PurchaseReturnItemsEntity>();
        public List<APPurchaseReturnReceiptsInfo> lstAPPurchaseReturnReceipts { get; set; } = new List<APPurchaseReturnReceiptsInfo>();
    }

    public class HREmployeeOffWorksDTO
    {
        public HREmployeeOffWorks EmployeeOffWork { get; set; }

        public int FK_ADApprovalProcStepID { get; set; } = 0;
        public int ADInboxItemID { get; set; } = 0;
    }
    public class HREmployeeOvertimesDTO
    {
        public HREmployeeOvertimes EmployeeOvertime { get; set; }

        public int FK_ADApprovalProcStepID { get; set; } = 0;
        public int ADInboxItemID { get; set; } = 0;
    }
    public class HRTravelCalendarsDTO
    {
        public HRTravelCalendars TravelCalendar { get; set; }
        public int FK_HREmployeeID { get; set; } = 0;
        public int FK_ADApprovalProcStepID { get; set; } = 0;
        public int ADInboxItemID { get; set; } = 0;
    }
    public class WOPlanInput
    {
        public List<PPWOPlanInputData> lstPPWOPlanInputData { get; set; } = new List<PPWOPlanInputData>();
        public List<PPWOPlanItemInputData> lstPPWOPlanItemInputData { get; set; } = new List<PPWOPlanItemInputData>();
    }
    public class WOREntities
    {
        public PPWORsInfo MainObject { get; set; } = new PPWORsInfo();
        public PPWORItemsInfo ItemObject { get; set; } = new PPWORItemsInfo();
        public List<PPWORItemsInfo> lstPPWORItems { get; set; } = new List<PPWORItemsInfo>();

    }
    //dự toán giá
    public class ItemSpecs
    {
        public string CaptionTab { get; set; } = string.Empty;
        public List<ACCostSimulationItemSpecsInfo> lstACCostSimulationItemSpecs { get; set; } = new List<ACCostSimulationItemSpecsInfo>();
    }
    public class ItemParam
    {
        public string CaptionTab { get; set; } = string.Empty;
        public List<ACCostSimulationProductColumnsInfo> lstACCostSimulationProductColumns { get; set; } = new List<ACCostSimulationProductColumnsInfo>();
    }
    public class CostSimulationItemTotal
    {
        public string No { get; set; }
        public string Name { get; set; }
        public decimal FPrice { get; set; }
        public decimal Price { get; set; }
    }
    public class ItemTotal
    {
        public string CaptionTab { get; set; } = string.Empty;
        public List<CostSimulationItemTotal> lstACCostSimulationItemTotals { get; set; } = new List<CostSimulationItemTotal>();
    }
    public class CostSimulationFactor
    {
        public int ACCostSimulationItemID { get; set; }
        public int ACCostSimulationFactorID { get; set; }
        public int FK_ACCostSimulationMethodItemID { get; set; }
        public int FK_ACCostSimulationID { get; set; }
        public string ACCostSimulationFactorNo { get; set; } = string.Empty;
        public string ACCostSimulationFactorName { get; set; } = string.Empty;
        public decimal ACCostSimulationItemFPrice { get; set; }
        public decimal ACCostSimulationItemPrice { get; set; }
    }
    public class ItemTabChild
    {
        public string CaptionTabDetailChild { get; set; }
        public List<CostSimulationFactor> lstData { get; set; } = new List<CostSimulationFactor>();
    }
    public class ItemTab
    {
        public string CaptionTabDetail { get; set; }
        public List<ItemTabChild> lstItemTabChild { get; set; } = new List<ItemTabChild>();
    }
    public class ItemDetails
    {
        public string CaptionTab { get; set; } = string.Empty;
        public List<ItemTab> lstItemTab { get; set; } = new List<ItemTab>();
    }
    public class DetailParam
    {
        public string ACCostSimulationItemColumnColDisplay { get; set; }
        public string ACCostSimulationItemColumnColDisplayName { get; set; } = string.Empty;
        //  public int FK_ACCostSimulationMethodItemParamID { get; set; }
        public decimal ACCostSimulationItemColumnViewData { get; set; }
    }
    public class Local
    {
        public SortedList<int, decimal> lstResult { get; set; } = new SortedList<int, decimal>();
        public SortedList<String, double> lstItemData { get; set; } = new SortedList<string, double>();
        public List<CostSimulationObjectType> lstCostSimulationObjectType { get; set; } = new List<CostSimulationObjectType>();
        public Dictionary<string, DataTable> LookupTables { get; set; } = new Dictionary<string, DataTable>();
        public ICProductsInfo objProductTemp { get; set; }=new ICProductsInfo();

       public List<ACCostSimulationDetailsInfo> lstACCostSimulationDetailsTemp { get; set; } = new List<ACCostSimulationDetailsInfo>();
       public List<ACCostSimulationDetailsInfo> lstACCostSimulationDetailLaborsTemp { get; set; } = new List<ACCostSimulationDetailsInfo>();
        // public SortedList<String, object> lstProductProperty { get; set; } = new SortedList<String, object>();
    }
    public class CostSimulationObjectType
    {
        public CostSimulationObjectType()
        {
        }
        public string ObjectType { get; set; }
        public int iCatalogID { get; set; }
        public string ColName { get; set; }
        public decimal Value { get; set; }
    }
    public class CostSimulationEntities
    {
        public ACCostSimulationsInfo MainObject { get; set; } = new ACCostSimulationsInfo();
        public List<CostSimulationItemsEntity> lstACCostSimulationItems { get; set; } = new List<CostSimulationItemsEntity>();
        public List<ACCostSimulationDetailsInfo> lstACCostSimulationDetails { get; set; } = new List<ACCostSimulationDetailsInfo>();
        public List<ACCostSimulationItemSpecsInfo> lstACCostSimulationItemSpecs { get; set; } = new List<ACCostSimulationItemSpecsInfo>();
        public List<ACCostSimulationProductColumnsInfo> lstACCostSimulationProductColumns { get; set; } = new List<ACCostSimulationProductColumnsInfo>();
        public List<ACCostSimulationLaborsInfo> lstACCostSimulationLabors { get; set; } = new List<ACCostSimulationLaborsInfo>();
        //vẽ giao diện
        //public ItemSpecs itemSpecs { get; set; } = new ItemSpecs();
        //public ItemParam itemParam { get; set; } = new ItemParam();
        public ItemDetails itemDetails { get; set; } = new ItemDetails();
        public ItemTotal itemTotal { get; set; } = new ItemTotal();
        [JsonIgnore]
        public Local local { get; set; }= new Local();
        public string LogErrorCalculate { get; set; } = string.Empty;
    }
    //
    public class QuotEntities
    {
        public ARQuotsInfo MainObject { get; set; } = new ARQuotsInfo();
        public ARQuotItemsInfo ItemObject { get; set; } = new ARQuotItemsInfo();
        public List<ARQuotItemsInfo> lstARQuotItems { get; set; } = new List<ARQuotItemsInfo>();

    }
    public class QuotCostSimulationEntities
    {
        public ARQuotsInfo MainObject { get; set; } = new ARQuotsInfo();
        public ARQuotItemsInfo ARQuotItemsObject { get; set; } = new ARQuotItemsInfo();
        public ACCostSimulationsInfo ACCostSimulationsObject { get; set; } = new ACCostSimulationsInfo();

    }
    public class WOEntities
    {
        public PPWOsInfo MainObject { get; set; } = new PPWOsInfo();
        public PPWOPItemsInfo ItemObject { get; set; } = new PPWOPItemsInfo();
        public List<PPWOPItemsInfo> lstPPWOPItems { get; set; } = new List<PPWOPItemsInfo>();
        public List<PPWOEstFGItemsInfo> lstPPWOEstFGItems { get; set; } = new List<PPWOEstFGItemsInfo>();
        public List<WOEstRMItemsEntity> lstPPWOEstRMItems { get; set; } = new List<WOEstRMItemsEntity>();
        public List<ARSOsInfo> lstARSOs { get; set; } = new List<ARSOsInfo>();
        public List<ARSOItemsInfo> lstARSOItems { get; set; } = new List<ARSOItemsInfo>();
        public List<PPWORsInfo> lstPPWORs { get; set; } = new List<PPWORsInfo>();
        public List<PPWORItemsInfo> lstPPWORItems { get; set; } = new List<PPWORItemsInfo>();

        //Các list dùng lưu trữ xử lý tính toán như biến toàn cục ERP
        public SortedList<string, List<decimal>> lstProductAllocate { get; set; } = new SortedList<string, List<decimal>>();
        public SortedList<string, decimal> lstProductReserved { get; set; } = new SortedList<string, decimal>();
        public Dictionary<int, List<PPRoutingOperationsInfo>> lstProductRouting { get; set; } = new Dictionary<int, List<PPRoutingOperationsInfo>>();
        public Dictionary<int, List<ICProductionUOMsInfo>> lstProductionUOM { get; set; } = new Dictionary<int, List<ICProductionUOMsInfo>>();
        public SortedList<string, List<decimal>> lstProductAllocateWOP { get; set; } = new SortedList<string, List<decimal>>();
        public int iEstFGKey { get; set; } = 1;
    }
    public class WODrilldownPItem
    {
        public PPWOsInfo MainObject { get; set; } = new PPWOsInfo();
        public PPWOPItemsInfo PPWOPItems { get; set; } = new PPWOPItemsInfo();
    }
    public class WODrilldownFGItem
    {
        public PPWOsInfo MainObject { get; set; } = new PPWOsInfo();
        public PPWOEstFGItemsInfo PPWOEstFGItems { get; set; } = new PPWOEstFGItemsInfo();
    }
    public class WODrilldownRMItem
    {
        public PPWOsInfo MainObject { get; set; } = new PPWOsInfo();
        public PPWOEstRMItemsInfo PPWOEstRMItems { get; set; } = new PPWOEstRMItemsInfo();
    }

    public class WOMRPEntities
    {
        public PPWOMRPsInfo MainObject { get; set; } = new PPWOMRPsInfo();
        public PPWOMRPItemsInfo ItemObject { get; set; } = new PPWOMRPItemsInfo();
        public List<PPWOEstFGItemsInfo> lstPPWOEstFGItems { get; set; } = new List<PPWOEstFGItemsInfo>();
        public List<WOEstRMItemsEntity> lstPPWOEstRMItems { get; set; } = new List<WOEstRMItemsEntity>();
        public List<PPWOMRPItemsInfo> lstPPWOMRPItems { get; set; } = new List<PPWOMRPItemsInfo>();

        //Các list dùng lưu trữ xử lý tính toán như biến toàn cục ERP
        public SortedList<string, List<decimal>> lstProductAllocate { get; set; } = new SortedList<string, List<decimal>>();
        public SortedList<string, decimal> lstProductInvDate { get; set; } = new SortedList<string, decimal>();
        [JsonIgnore]
       public List<ICProductsInfo> lstDataProduct { get; set; } = new List<ICProductsInfo>();
    }
    public class WOMRPDrilldownRMItem
    {
        public PPWOMRPsInfo MainObject { get; set; } = new PPWOMRPsInfo();
        public PPWOEstRMItemsInfo PPWOEstRMItems { get; set; } = new PPWOEstRMItemsInfo();
    }
    #region  dùng invalidate màn hình phê duyệt, trả về toàn bộ cột của table ko dùng info
    public class APPRToDictionary
    {
        public Dictionary<string, dynamic> MainObject { get; set; } = new Dictionary<string, dynamic>();
        public List<Dictionary<string, dynamic>> lstAPPRItems { get; set; } = new List<Dictionary<string, dynamic>>();

    }
    public class APPOToDictionary
    {
        public Dictionary<string, dynamic> MainObject { get; set; } = new Dictionary<string, dynamic>();
        public List<Dictionary<string, dynamic>> lstAPPOItems { get; set; } = new List<Dictionary<string, dynamic>>();

    }
    public class GLVoucherToDictionary 
    {
        public Dictionary<string, dynamic> MainObject { get; set; }= new Dictionary<string, dynamic>();
        public List<Dictionary<string, dynamic>> lstGLVoucherItems { get; set; } = new List<Dictionary<string, dynamic>>();
    }
    public class ICROToDictionary
    {
        public Dictionary<string, dynamic> MainObject { get; set; } = new Dictionary<string, dynamic>();
        public List<Dictionary<string, dynamic>> lstICROItems { get; set; } = new List<Dictionary<string, dynamic>>();

    }
    #endregion
    public class ErrorCodeResult
    {
        public PPErrorCodeResults MainObject { get; set; } = new PPErrorCodeResults();
        public List<ErrorCodeResultItemsEntity> lstPPErrorCodeResultItems { get; set; } = new List<ErrorCodeResultItemsEntity>();

    }
    public class PrintTemTransfer
    {
        public ICTransfers MainObject { get; set; } = new ICTransfers();
        public TransferItemsEntity ICTransferItems { get; set; } = new TransferItemsEntity();
    }
}
