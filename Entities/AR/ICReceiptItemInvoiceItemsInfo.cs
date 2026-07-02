using ExpertLib;
using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICReceiptItemInvoiceItems")]
    public class ICReceiptItemInvoiceItemsInfo : BaseInfo
    {
        public ICReceiptItemInvoiceItemsInfo()
        {
        }
        #region Variables
        protected int _iCReceiptItemInvoiceItemID;
        protected int _fK_ICReceiptItemID;
        protected int _fK_ARInvoiceItemID;
        protected String _aAStatus = DefaultAAStatus;
        #endregion
        [Key]
        #region Public properties
        public int ICReceiptItemInvoiceItemID
        {
            get { return _iCReceiptItemInvoiceItemID; }
            set
            {
                if (value != this._iCReceiptItemInvoiceItemID)
                {
                    _iCReceiptItemInvoiceItemID = value;
                }
            }
        }
        public int FK_ICReceiptItemID
        {
            get { return _fK_ICReceiptItemID; }
            set
            {
                if (value != this._fK_ICReceiptItemID)
                {
                    _fK_ICReceiptItemID = value;
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
        #endregion
    }
}
