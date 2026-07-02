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
    [Table("ARCreditNoteItemInvoiceItems")]
    public class ARCreditNoteItemInvoiceItemsInfo : BaseInfo
    {
        public ARCreditNoteItemInvoiceItemsInfo()
        {
        }
        #region Variables
        protected int _aRCreditNoteItemInvoiceItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARInvoiceItemID;
        protected int _fK_ARCreditNoteItemID;
        #endregion
        [Key]
        #region Public properties
        public int ARCreditNoteItemInvoiceItemID
        {
            get { return _aRCreditNoteItemInvoiceItemID; }
            set
            {
                if (value != this._aRCreditNoteItemInvoiceItemID)
                {
                    _aRCreditNoteItemInvoiceItemID = value;
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
        public int FK_ARCreditNoteItemID
        {
            get { return _fK_ARCreditNoteItemID; }
            set
            {
                if (value != this._fK_ARCreditNoteItemID)
                {
                    _fK_ARCreditNoteItemID = value;
                }
            }
        }
        #endregion
    }
}
