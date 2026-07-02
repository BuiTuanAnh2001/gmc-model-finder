using gmc_api.Entities.IC.Receipt;
using System;
using System.Collections.Generic;

namespace gmc_api.Entities
{
    public partial class ReceiptItemsEntity 
    {
        #region List Object variables
        private List<ICReceiptItemPurchaseOrderItems> _iCReceiptItemPurchaseOrderItemsList;
        //private List<ICReceiptItemCreditNoteItemsInfo> _iCReceiptItemCreditNoteItemsList;
        private List<ICReceiptItemSaleReturnItemsInfo> _iCReceiptItemSaleReturnItemsList;

        //private List<ICReceiptItemQCItemsInfo> _iCReceiptItemQCItemsList;
        //      private List<ICReceiptItemPRItemsInfo> _iCReceiptItemPRItemsList;

        private List<ICReceiptItemPInvoiceItemsInfo> _iCReceiptItemPInvoiceItemsList;

        private List<ICReceiptItemRequestReceiptItems> _iCReceiptItemRequestReceiptItemsList;

        //private GMCList<ICReceiptItemShipmentItemsInfo> _iCReceiptItemShipmentItemsList;
        //private GMCList<ICReceiptItemInvoiceItemsInfo> _iCReceiptItemInvoiceItemsList;

        //private GMCList<ICReceiptItemPurchaseCostItemAllocatesInfo> _iCReceiptItemPurchaseCostItemAllocatesList;

        //private GMCList<APLandedCostItemsInfo> _aPLandedCostItemsList;
        //public List<APPOImportDocAllocatesInfo> lstAPPOImportDocAllocates;
        #endregion

        #region Constructor
        public ReceiptItemsEntity()
            : base()
        {
            _iCReceiptItemPurchaseOrderItemsList = new List<ICReceiptItemPurchaseOrderItems>();
            //_iCReceiptItemCreditNoteItemsList = new List<ICReceiptItemCreditNoteItemsInfo>();
            _iCReceiptItemSaleReturnItemsList = new List<ICReceiptItemSaleReturnItemsInfo>();
            //_iCReceiptItemQCItemsList = new List<ICReceiptItemQCItemsInfo>();
            _iCReceiptItemPInvoiceItemsList = new List<ICReceiptItemPInvoiceItemsInfo>();
            _iCReceiptItemRequestReceiptItemsList = new List<ICReceiptItemRequestReceiptItems>();
            //_iCReceiptItemShipmentItemsList = new GMCList<ICReceiptItemShipmentItemsInfo>();
            //_iCReceiptItemInvoiceItemsList = new GMCList<ICReceiptItemInvoiceItemsInfo>();
            //_iCReceiptItemPurchaseCostItemAllocatesList = new GMCList<ICReceiptItemPurchaseCostItemAllocatesInfo>();
            //_aPLandedCostItemsList = new GMCList<APLandedCostItemsInfo>();
            //_iCReceiptItemPRItemsList = new List<ICReceiptItemPRItemsInfo>();
            //lstAPPOImportDocAllocates = new List<APPOImportDocAllocatesInfo>();
        }

        #endregion

        #region Public Properties
        //public List<ICReceiptItemCreditNoteItemsInfo> ICReceiptItemCreditNoteItemsList
        //{
        //    get { return _iCReceiptItemCreditNoteItemsList; }
        //    set { _iCReceiptItemCreditNoteItemsList = value; }
        //}
        public List<ICReceiptItemPurchaseOrderItems> ICReceiptItemPurchaseOrderItemsList
        {
            get
            {
                return _iCReceiptItemPurchaseOrderItemsList;
            }
            set
            {
                _iCReceiptItemPurchaseOrderItemsList = value;
            }
        }

        public List<ICReceiptItemSaleReturnItemsInfo> ICReceiptItemSaleReturnItemsList
        {
            get { return _iCReceiptItemSaleReturnItemsList; }
            set { _iCReceiptItemSaleReturnItemsList = value; }
        }
        //public List<ICReceiptItemQCItemsInfo> ICReceiptItemQCItemsList
        //{
        //    get { return _iCReceiptItemQCItemsList; }
        //    set { _iCReceiptItemQCItemsList = value; }
        //}
        //public List<ICReceiptItemPRItemsInfo> ICReceiptItemPRItemsList
        //{
        //    get { return _iCReceiptItemPRItemsList; }
        //    set { _iCReceiptItemPRItemsList = value; }
        //}
        public List<ICReceiptItemPInvoiceItemsInfo> ICReceiptItemPInvoiceItemsList
        {
            get { return _iCReceiptItemPInvoiceItemsList; }
            set { _iCReceiptItemPInvoiceItemsList = value; }
        }

        public List<ICReceiptItemRequestReceiptItems> ICReceiptItemRequestReceiptItemsList
        {
            get { return _iCReceiptItemRequestReceiptItemsList; }
            set { _iCReceiptItemRequestReceiptItemsList = value; }
        }

        //public GMCList<ICReceiptItemShipmentItemsInfo> ICReceiptItemShipmentItemsList
        //{
        //    get { return _iCReceiptItemShipmentItemsList; }
        //    set { _iCReceiptItemShipmentItemsList = value; }
        //}

        //public GMCList<ICReceiptItemInvoiceItemsInfo> ICReceiptItemInvoiceItemsList
        //{
        //    get { return _iCReceiptItemInvoiceItemsList; }
        //    set { _iCReceiptItemInvoiceItemsList = value; }
        //}

        //public GMCList<ICReceiptItemPurchaseCostItemAllocatesInfo> ICReceiptItemPurchaseCostItemAllocatesList
        //{
        //    get { return _iCReceiptItemPurchaseCostItemAllocatesList; }
        //    set { _iCReceiptItemPurchaseCostItemAllocatesList = value; }
        //}

        //public GMCList<APLandedCostItemsInfo> APLandedCostItemsList
        //{
        //    get { return _aPLandedCostItemsList; }
        //    set { _aPLandedCostItemsList = value; }
        //}

        #endregion
    }
}
