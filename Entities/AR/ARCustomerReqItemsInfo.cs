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
    [Table("ARCustomerReqItems")]
    public class ARCustomerReqItemsInfo : BaseInfo
    {
        public ARCustomerReqItemsInfo()
        {
        }
        #region Variables
        protected int _aRCustomerReqItemID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_ARCustomerReqAttrID;
        protected String _aRCustomerReqItemValue = String.Empty;
        protected String _aRCustomerReqItemDesc = String.Empty;
        protected String _aRCustomerReqItemGroup = String.Empty;
        protected String _aRCustomerReqAttrGroup = String.Empty;
        protected int _fK_ARCustomerProductReqItemID;
        protected int _fK_ICProductTypeID;
        protected int _fK_ICProductGroupID;
        protected String _aRCustomerReqItemPaperKindCombo = String.Empty;
        protected String _aRCustomerReqItemTypeCombo = String.Empty;
        protected String _aRCustomerReqItemFinishingNameCombo = String.Empty;
        protected String _aRCustomerReqItemPaperGSMCombo = String.Empty;

        #endregion
        [Key]
        #region Public properties
        public int ARCustomerReqItemID
        {
            get { return _aRCustomerReqItemID; }
            set
            {
                if (value != this._aRCustomerReqItemID)
                {
                    _aRCustomerReqItemID = value;
                }
            }
        }
        public Nullable<DateTime> AACreatedDate
        {
            get { return _aACreatedDate; }
            set
            {
                if (value != this._aACreatedDate)
                {
                    _aACreatedDate = value;
                }
            }
        }
        public String AACreatedUser
        {
            get { return _aACreatedUser; }
            set
            {
                if (value != this._aACreatedUser)
                {
                    _aACreatedUser = value;
                }
            }
        }
        public Nullable<DateTime> AAUpdatedDate
        {
            get { return _aAUpdatedDate; }
            set
            {
                if (value != this._aAUpdatedDate)
                {
                    _aAUpdatedDate = value;
                }
            }
        }
        public String AAUpdatedUser
        {
            get { return _aAUpdatedUser; }
            set
            {
                if (value != this._aAUpdatedUser)
                {
                    _aAUpdatedUser = value;
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
        public int FK_ARCustomerReqAttrID
        {
            get { return _fK_ARCustomerReqAttrID; }
            set
            {
                if (value != this._fK_ARCustomerReqAttrID)
                {
                    _fK_ARCustomerReqAttrID = value;
                }
            }
        }
        public String ARCustomerReqItemValue
        {
            get { return _aRCustomerReqItemValue; }
            set
            {
                if (value != this._aRCustomerReqItemValue)
                {
                    _aRCustomerReqItemValue = value;
                }
            }
        }
        public String ARCustomerReqItemDesc
        {
            get { return _aRCustomerReqItemDesc; }
            set
            {
                if (value != this._aRCustomerReqItemDesc)
                {
                    _aRCustomerReqItemDesc = value;
                }
            }
        }
        public String ARCustomerReqItemGroup
        {
            get { return _aRCustomerReqItemGroup; }
            set
            {
                if (value != this._aRCustomerReqItemGroup)
                {
                    _aRCustomerReqItemGroup = value;
                }
            }
        }
        public String ARCustomerReqAttrGroup
        {
            get { return _aRCustomerReqAttrGroup; }
            set
            {
                if (value != this._aRCustomerReqAttrGroup)
                {
                    _aRCustomerReqAttrGroup = value;
                }
            }
        }
        public int FK_ARCustomerProductReqItemID
        {
            get { return _fK_ARCustomerProductReqItemID; }
            set
            {
                if (value != this._fK_ARCustomerProductReqItemID)
                {
                    _fK_ARCustomerProductReqItemID = value;
                }
            }
        }
        public int FK_ICProductTypeID
        {
            get { return _fK_ICProductTypeID; }
            set
            {
                if (value != this._fK_ICProductTypeID)
                {
                    _fK_ICProductTypeID = value;
                }
            }
        }
        public int FK_ICProductGroupID
        {
            get { return _fK_ICProductGroupID; }
            set
            {
                if (value != this._fK_ICProductGroupID)
                {
                    _fK_ICProductGroupID = value;
                }
            }
        }
        public String ARCustomerReqItemPaperKindCombo
        {
            get { return _aRCustomerReqItemPaperKindCombo; }
            set
            {
                if (value != this._aRCustomerReqItemPaperKindCombo)
                {
                    _aRCustomerReqItemPaperKindCombo = value;
                }
            }
        }
        public String ARCustomerReqItemTypeCombo
        {
            get { return _aRCustomerReqItemTypeCombo; }
            set
            {
                if (value != this._aRCustomerReqItemTypeCombo)
                {
                    _aRCustomerReqItemTypeCombo = value;
                }
            }
        }
        public String ARCustomerReqItemFinishingNameCombo
        {
            get { return _aRCustomerReqItemFinishingNameCombo; }
            set
            {
                if (value != this._aRCustomerReqItemFinishingNameCombo)
                {
                    _aRCustomerReqItemFinishingNameCombo = value;
                }
            }
        }
        public String ARCustomerReqItemPaperGSMCombo
        {
            get { return _aRCustomerReqItemPaperGSMCombo; }
            set
            {
                if (value != this._aRCustomerReqItemPaperGSMCombo)
                {
                    _aRCustomerReqItemPaperGSMCombo = value;
                }
            }
        }

        #endregion
    }
}
