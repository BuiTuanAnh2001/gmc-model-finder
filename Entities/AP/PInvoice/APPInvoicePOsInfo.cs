using ExpertLib;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{

    [Table("APPInvoicePOs")]
    public class APPInvoicePOsInfo : BaseInfo
    {
        public APPInvoicePOsInfo()
        {
        }
        #region Variables
        protected int _aPPInvoicePOID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_APPInvoiceID;
        protected int _fK_APPOID;

        #endregion
        [Key]
        #region Public properties
        public int APPInvoicePOID
        {
            get { return _aPPInvoicePOID; }
            set
            {
                if (value != this._aPPInvoicePOID)
                {
                    _aPPInvoicePOID = value;
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
        public int FK_APPInvoiceID
        {
            get { return _fK_APPInvoiceID; }
            set
            {
                if (value != this._fK_APPInvoiceID)
                {
                    _fK_APPInvoiceID = value;
                }
            }
        }
        public int FK_APPOID
        {
            get { return _fK_APPOID; }
            set
            {
                if (value != this._fK_APPOID)
                {
                    _fK_APPOID = value;
                }
            }
        }

        #endregion
    }
}