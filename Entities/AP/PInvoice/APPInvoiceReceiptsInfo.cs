using ExpertLib;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{

    [Table("APPInvoiceReceipts")]
    public class APPInvoiceReceiptsInfo : BaseInfo
    {
        public APPInvoiceReceiptsInfo()
        {
        }
        #region Variables
        protected int _aPPInvoiceReceiptID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_APPInvoiceID;
        protected int _fK_ICReceiptID;
        #endregion
        [Key]
        #region Public properties
        public int APPInvoiceReceiptID
        {
            get { return _aPPInvoiceReceiptID; }
            set
            {
                if (value != this._aPPInvoiceReceiptID)
                {
                    _aPPInvoiceReceiptID = value;
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
        public int FK_ICReceiptID
        {
            get { return _fK_ICReceiptID; }
            set
            {
                if (value != this._fK_ICReceiptID)
                {
                    _fK_ICReceiptID = value;
                }
            }
        }
        #endregion
    }
}