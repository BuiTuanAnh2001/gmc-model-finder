using ExpertLib;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{

    [Table("ARInvoiceItemShipmentItems")]
    public class ARInvoiceItemShipmentItemsInfo : BaseInfo
    {
        public ARInvoiceItemShipmentItemsInfo()
        {
        }
        #region Variables
        protected int _aRInvoiceItemShipmentItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARInvoiceItemID;
        protected int _fK_ICShipmentItemID;
        #endregion
        [Key]
        #region Public properties
        public int ARInvoiceItemShipmentItemID
        {
            get { return _aRInvoiceItemShipmentItemID; }
            set
            {
                if (value != this._aRInvoiceItemShipmentItemID)
                {
                    _aRInvoiceItemShipmentItemID = value;
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
        public int FK_ARInvoiceItemID
        {
            get { return _fK_ARInvoiceItemID; }
            set
            {
                if (value != this._fK_ARInvoiceItemID)
                {
                    _fK_ARInvoiceItemID = value;
                }
            }
        }
        public int FK_ICShipmentItemID
        {
            get { return _fK_ICShipmentItemID; }
            set
            {
                if (value != this._fK_ICShipmentItemID)
                {
                    _fK_ICShipmentItemID = value;
                 }
            }
        }
        #endregion
    }
}