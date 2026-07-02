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
    [Table("ARSaleReturnItemInvoiceItems")]
    public class ARSaleReturnItemInvoiceItemsInfo : BaseInfo
    {
        public ARSaleReturnItemInvoiceItemsInfo()
        {
        }
        #region Variables
        protected int _aRSaleReturnItemInvoiceItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARInvoiceItemID;
        protected int _fK_ARSaleReturnItemID;
        #endregion
        [Key]
        #region Public properties
        public int ARSaleReturnItemInvoiceItemID
        {
            get { return _aRSaleReturnItemInvoiceItemID; }
            set
            {
                if (value != this._aRSaleReturnItemInvoiceItemID)
                {
                    _aRSaleReturnItemInvoiceItemID = value;
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
        public int FK_ARSaleReturnItemID
        {
            get { return _fK_ARSaleReturnItemID; }
            set
            {
                if (value != this._fK_ARSaleReturnItemID)
                {
                    _fK_ARSaleReturnItemID = value;
                }
            }
        }
        #endregion
    }
}
