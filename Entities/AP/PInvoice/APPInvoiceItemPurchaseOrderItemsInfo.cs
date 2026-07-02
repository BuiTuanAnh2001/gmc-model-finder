using ExpertLib;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("APPInvoiceItemPurchaseOrderItems")]
    public class APPInvoiceItemPurchaseOrderItemsInfo : BaseInfo
    {
        public APPInvoiceItemPurchaseOrderItemsInfo()
        {
        }
        #region Variables
        protected int _aPPInvoiceItemPurchaseOrderItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_APPOItemID;
        protected int _fK_APPInvoiceItemID;
        #endregion
        [Key]
        #region Public properties
        public int APPInvoiceItemPurchaseOrderItemID
        {
            get { return _aPPInvoiceItemPurchaseOrderItemID; }
            set
            {
                if (value != this._aPPInvoiceItemPurchaseOrderItemID)
                {
                    _aPPInvoiceItemPurchaseOrderItemID = value;
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
        public int FK_APPOItemID
        {
            get { return _fK_APPOItemID; }
            set
            {
                if (value != this._fK_APPOItemID)
                {
                    _fK_APPOItemID = value;
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