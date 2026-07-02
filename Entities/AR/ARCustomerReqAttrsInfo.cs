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
    [Table("ARCustomerReqAttrs")]
    public class ARCustomerReqAttrsInfo : BaseInfo
    {
        public ARCustomerReqAttrsInfo()
        {
        }
        #region Variables
        protected int _aRCustomerReqAttrID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _aRCustomerReqAttrNo = String.Empty;
        protected String _aRCustomerReqAttrName = String.Empty;
        protected String _aRCustomerReqAttrGroup = String.Empty;
        protected DateTime _aRCustomerReqAttrDate = DateTime.Now;
        protected String _aRCustomerReqAttrDesc = String.Empty;
        protected int _fK_ICProductModelID;
        protected bool _aRCustomerReqAttrIsOptional = true;
        protected String _aRCustomerReqAttrTypeCombo = String.Empty;
        protected int _fK_ARCustomerReqAttrID;
        protected String _aRCustomerReqAttrDataType = String.Empty;
        protected int _fK_ICUOMID;
        protected String _aRCustomerReqAttTableName = String.Empty;
        protected String _aRCustomerReqAttColumnName = String.Empty;
        protected int _fK_ICProductTypeID;
        protected int _fK_ICProductGroupID;
        protected String _aRCustomerReqAttrTypeName = String.Empty;
        protected String _aRCustomerReqAttrGroupName = String.Empty;

        #endregion
        [Key]
        #region Public properties
        public int ARCustomerReqAttrID
        {
            get { return _aRCustomerReqAttrID; }
            set
            {
                if (value != this._aRCustomerReqAttrID)
                {
                    _aRCustomerReqAttrID = value;
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
        public String ARCustomerReqAttrNo
        {
            get { return _aRCustomerReqAttrNo; }
            set
            {
                if (value != this._aRCustomerReqAttrNo)
                {
                    _aRCustomerReqAttrNo = value;
                }
            }
        }
        public String ARCustomerReqAttrName
        {
            get { return _aRCustomerReqAttrName; }
            set
            {
                if (value != this._aRCustomerReqAttrName)
                {
                    _aRCustomerReqAttrName = value;
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
        public DateTime ARCustomerReqAttrDate
        {
            get { return _aRCustomerReqAttrDate; }
            set
            {
                if (value != this._aRCustomerReqAttrDate)
                {
                    _aRCustomerReqAttrDate = value;
                }
            }
        }
        public String ARCustomerReqAttrDesc
        {
            get { return _aRCustomerReqAttrDesc; }
            set
            {
                if (value != this._aRCustomerReqAttrDesc)
                {
                    _aRCustomerReqAttrDesc = value;
                }
            }
        }
        public int FK_ICProductModelID
        {
            get { return _fK_ICProductModelID; }
            set
            {
                if (value != this._fK_ICProductModelID)
                {
                    _fK_ICProductModelID = value;
                }
            }
        }
        public bool ARCustomerReqAttrIsOptional
        {
            get { return _aRCustomerReqAttrIsOptional; }
            set
            {
                if (value != this._aRCustomerReqAttrIsOptional)
                {
                    _aRCustomerReqAttrIsOptional = value;
                }
            }
        }
        public String ARCustomerReqAttrTypeCombo
        {
            get { return _aRCustomerReqAttrTypeCombo; }
            set
            {
                if (value != this._aRCustomerReqAttrTypeCombo)
                {
                    _aRCustomerReqAttrTypeCombo = value;
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
        public String ARCustomerReqAttrDataType
        {
            get { return _aRCustomerReqAttrDataType; }
            set
            {
                if (value != this._aRCustomerReqAttrDataType)
                {
                    _aRCustomerReqAttrDataType = value;
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
        public String ARCustomerReqAttTableName
        {
            get { return _aRCustomerReqAttTableName; }
            set
            {
                if (value != this._aRCustomerReqAttTableName)
                {
                    _aRCustomerReqAttTableName = value;
                }
            }
        }
        public String ARCustomerReqAttColumnName
        {
            get { return _aRCustomerReqAttColumnName; }
            set
            {
                if (value != this._aRCustomerReqAttColumnName)
                {
                    _aRCustomerReqAttColumnName = value;
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
        public String ARCustomerReqAttrTypeName
        {
            get { return _aRCustomerReqAttrTypeName; }
            set
            {
                if (value != this._aRCustomerReqAttrTypeName)
                {
                    _aRCustomerReqAttrTypeName = value;
                }
            }
        }
        public String ARCustomerReqAttrGroupName
        {
            get { return _aRCustomerReqAttrGroupName; }
            set
            {
                if (value != this._aRCustomerReqAttrGroupName)
                {
                    _aRCustomerReqAttrGroupName = value;
                }
            }
        }

        #endregion
    }
}
