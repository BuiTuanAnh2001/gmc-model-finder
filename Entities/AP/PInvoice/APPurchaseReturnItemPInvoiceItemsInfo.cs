using ExpertLib;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table(" APPurchaseReturnItemPInvoiceItems")]
    public class APPurchaseReturnItemPInvoiceItemsInfo : BaseInfo
    {
        public APPurchaseReturnItemPInvoiceItemsInfo()
        {
        }
        #region Variables
        protected int _aPPurchaseReturnItemPInvoiceItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_APPurchaseReturnItemID;
        protected int _fK_APPInvoiceItemID;
        #endregion
        [Key]
        #region Public properties
        public int APPurchaseReturnItemPInvoiceItemID
        {
            get { return _aPPurchaseReturnItemPInvoiceItemID; }
            set
            {
                if (value != this._aPPurchaseReturnItemPInvoiceItemID)
                {
                    _aPPurchaseReturnItemPInvoiceItemID = value;
                }
            }
        }
        public String AAStatus
        {
            get { return _aAStatus; }
            set
            {
                if (value != this._aAStatus)
                {
                    _aAStatus = value;
                }
            }
        }
        public int FK_APPurchaseReturnItemID
        {
            get { return _fK_APPurchaseReturnItemID; }
            set
            {
                if (value != this._fK_APPurchaseReturnItemID)
                {
                    _fK_APPurchaseReturnItemID = value;
                }
            }
        }
        public int FK_APPInvoiceItemID
        {
            get { return _fK_APPInvoiceItemID; }
            set
            {
                if (value != this._fK_APPInvoiceItemID)
                {
                    _fK_APPInvoiceItemID = value;
                }
            }
        }
        #endregion
    }

}