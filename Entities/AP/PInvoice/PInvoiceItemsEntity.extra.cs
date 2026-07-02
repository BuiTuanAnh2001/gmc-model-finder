using ExpertLib;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    public partial class PInvoiceItemsEntity 
    {
        #region List Object variables
        private List<APPInvoiceItemReceiptItemsInfo> _aPPInvoiceItemReceiptItemsList;
        //private List<APCreditNoteItemPInvoiceItemsInfo> _aAPCreditNoteItemPInvoiceItemsList;
        //private List<APPurchaseReturnItemPInvoiceItemsInfo> _aAPPurchaseReturnItemPInvoiceItemsList;

        private List<APPInvoiceItemPurchaseOrderItemsInfo> _aPPInvoiceItemPurchaseOrderItemsList;
        public List<APPInvoiceImportDocAllocatesInfo> lstAPPInvoiceImportDocAllocates { get; set; } = new List<APPInvoiceImportDocAllocatesInfo>();

        #endregion

        #region Constructor
        public PInvoiceItemsEntity()
            : base()
        {
            _aPPInvoiceItemReceiptItemsList = new List<APPInvoiceItemReceiptItemsInfo>();
            //_aAPCreditNoteItemPInvoiceItemsList = new List<APCreditNoteItemPInvoiceItemsInfo>();
            //_aAPPurchaseReturnItemPInvoiceItemsList = new List<APPurchaseReturnItemPInvoiceItemsInfo>();
            _aPPInvoiceItemPurchaseOrderItemsList = new List<APPInvoiceItemPurchaseOrderItemsInfo>();
        }
        #endregion

        #region Public Properties
        public List<APPInvoiceItemReceiptItemsInfo> APPInvoiceItemReceiptItemsList
        {
            get
            {
                return _aPPInvoiceItemReceiptItemsList;
            }
            set
            {
                _aPPInvoiceItemReceiptItemsList = value;
            }
        }
        //public List<APCreditNoteItemPInvoiceItemsInfo> AAPCreditNoteItemPInvoiceItemsList
        //{
        //    get { return _aAPCreditNoteItemPInvoiceItemsList; }
        //    set { _aAPCreditNoteItemPInvoiceItemsList = value; }
        //}

        //public List<APPurchaseReturnItemPInvoiceItemsInfo> AAPPurchaseReturnItemPInvoiceItemsList
        //{
        //    get { return _aAPPurchaseReturnItemPInvoiceItemsList; }
        //    set { _aAPPurchaseReturnItemPInvoiceItemsList = value; }
        //}

        public List<APPInvoiceItemPurchaseOrderItemsInfo> APPInvoiceItemPurchaseOrderItemsList
        {
            get { return _aPPInvoiceItemPurchaseOrderItemsList; }
            set { _aPPInvoiceItemPurchaseOrderItemsList = value; }
        }
        #endregion
    }

}