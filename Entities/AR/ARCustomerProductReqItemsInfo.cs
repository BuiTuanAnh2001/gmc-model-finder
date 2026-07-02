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
    [Table("ARCustomerProductReqItems")]
    public class ARCustomerProductReqItemsInfo : BaseInfo
    {
        public ARCustomerProductReqItemsInfo()
        {
        }
        #region Variables
        protected int _aRCustomerProductReqItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_ICProductID;
        protected String _aRCustomerProductReqItemNo = String.Empty;
        protected String _aRCustomerProductReqItemName = String.Empty;
        protected String _aRCustomerProductReqItemDesc = String.Empty;
        protected int _fK_ARCustomerReqID;
        protected String _aRCustomerProductReqItemAction = String.Empty;
        protected decimal _aRCustomerProductReqItemQty;
        protected int _fK_ICUOMID;
        protected decimal _aRCustomerProductReqItemRQty;

        #endregion
        [Key]
        #region Public properties
        public int ARCustomerProductReqItemID
        {
            get { return _aRCustomerProductReqItemID; }
            set
            {
                if (value != this._aRCustomerProductReqItemID)
                {
                    _aRCustomerProductReqItemID = value;
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
        public bool AASelected
        {
            get { return _aASelected; }
            set
            {
                if (value != this._aASelected)
                {
                    _aASelected = value;
                }
            }
        }
        public int FK_ICProductID
        {
            get { return _fK_ICProductID; }
            set
            {
                if (value != this._fK_ICProductID)
                {
                    _fK_ICProductID = value;
                }
            }
        }
        public String ARCustomerProductReqItemNo
        {
            get { return _aRCustomerProductReqItemNo; }
            set
            {
                if (value != this._aRCustomerProductReqItemNo)
                {
                    _aRCustomerProductReqItemNo = value;
                }
            }
        }
        public String ARCustomerProductReqItemName
        {
            get { return _aRCustomerProductReqItemName; }
            set
            {
                if (value != this._aRCustomerProductReqItemName)
                {
                    _aRCustomerProductReqItemName = value;
                }
            }
        }
        public String ARCustomerProductReqItemDesc
        {
            get { return _aRCustomerProductReqItemDesc; }
            set
            {
                if (value != this._aRCustomerProductReqItemDesc)
                {
                    _aRCustomerProductReqItemDesc = value;
                }
            }
        }
        public int FK_ARCustomerReqID
        {
            get { return _fK_ARCustomerReqID; }
            set
            {
                if (value != this._fK_ARCustomerReqID)
                {
                    _fK_ARCustomerReqID = value;
                }
            }
        }
        public String ARCustomerProductReqItemAction
        {
            get { return _aRCustomerProductReqItemAction; }
            set
            {
                if (value != this._aRCustomerProductReqItemAction)
                {
                    _aRCustomerProductReqItemAction = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARCustomerProductReqItemQty
        {
            get { return _aRCustomerProductReqItemQty; }
            set
            {
                if (value != this._aRCustomerProductReqItemQty)
                {
                    _aRCustomerProductReqItemQty = value;
                }
            }
        }
        public int FK_ICUOMID
        {
            get { return _fK_ICUOMID; }
            set
            {
                if (value != this._fK_ICUOMID)
                {
                    _fK_ICUOMID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARCustomerProductReqItemRQty
        {
            get { return _aRCustomerProductReqItemRQty; }
            set
            {
                if (value != this._aRCustomerProductReqItemRQty)
                {
                    _aRCustomerProductReqItemRQty = value;
                }
            }
        }

        #endregion
    }
}
