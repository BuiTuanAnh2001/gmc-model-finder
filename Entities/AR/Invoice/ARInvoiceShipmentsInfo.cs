using ExpertLib;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{

    [Table("ARInvoiceShipments")]
    public class ARInvoiceShipmentsInfo : BaseInfo
    {
        public ARInvoiceShipmentsInfo()
        {
        }
        #region Variables
        protected int _aRInvoiceShipmentID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARInvoiceID;
        protected int _fK_ICShipmentID;
        #endregion
        [Key]
        #region Public properties
        public int ARInvoiceShipmentID
        {
            get { return _aRInvoiceShipmentID; }
            set
            {
                if (value != this._aRInvoiceShipmentID)
                {
                    _aRInvoiceShipmentID = value;
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
        public int FK_ARInvoiceID
        {
            get { return _fK_ARInvoiceID; }
            set
            {
                if (value != this._fK_ARInvoiceID)
                {
                    _fK_ARInvoiceID = value;
                }
            }
        }
        public int FK_ICShipmentID
        {
            get { return _fK_ICShipmentID; }
            set
            {
                if (value != this._fK_ICShipmentID)
                {
                    _fK_ICShipmentID = value;
                }
            }
        }
        #endregion
    }
}