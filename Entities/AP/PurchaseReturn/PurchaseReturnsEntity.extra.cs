using System.Collections.Generic;

namespace gmc_api.Entities
{
    public partial class PurchaseReturnItemsEntity
    {
        #region List Object variables

        //private List<APPurchaseReturnItemPInvoiceItemsInfo> _aPPurchaseReturnItemPInvoiceItemsList;


        private List<APPurchaseReturnItemReceiptItemsInfo> _aPPurchaseReturnItemReceiptItemsList;

        //private List<APCreditNoteItemPurchaseReturnItemsInfo> _aAPCreditNoteItemPInvoiceItemsList;

       

        #endregion

        #region Constructor
        public PurchaseReturnItemsEntity()
            : base()
        {
            //_aPPurchaseReturnItemPInvoiceItemsList = new List<APPurchaseReturnItemPInvoiceItemsInfo>();
            _aPPurchaseReturnItemReceiptItemsList = new List<APPurchaseReturnItemReceiptItemsInfo>();
            //_aAPCreditNoteItemPInvoiceItemsList = new List<APCreditNoteItemPurchaseReturnItemsInfo>();
			//TableName = "APPurchaseReturnItems";
        }
        #endregion

        #region Public Properties

        //public List<APPurchaseReturnItemPInvoiceItemsInfo> APPurchaseReturnItemPInvoiceItemsList
        //{
        //    get { return _aPPurchaseReturnItemPInvoiceItemsList; }
        //    set { _aPPurchaseReturnItemPInvoiceItemsList = value; }
        //}
        public List<APPurchaseReturnItemReceiptItemsInfo> APPurchaseReturnItemReceiptItemsList
        {
            get { return _aPPurchaseReturnItemReceiptItemsList; }
            set { _aPPurchaseReturnItemReceiptItemsList = value; }
        }

        //public List<APCreditNoteItemPurchaseReturnItemsInfo> AAPCreditNoteItemPInvoiceItemsList
        //{
        //    get { return _aAPCreditNoteItemPInvoiceItemsList; }
        //    set { _aAPCreditNoteItemPInvoiceItemsList = value; }
        //}

        #endregion
    }
}
