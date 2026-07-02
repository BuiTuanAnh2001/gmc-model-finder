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
    [Table("ARCustomerReqImages")]
    public class ARCustomerReqImagesInfo : BaseInfo
    {
        public ARCustomerReqImagesInfo()
        {
        }
        #region Variables
        protected int _aRCustomerReqImageID;
        protected Nullable<DateTime> _aRCustomerReqImageDate;
        protected String _aRCustomerReqImageDesc = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected byte[] _aRCustomerReqImageData;
        protected int _fK_ARCustomerReqID;
        protected int _fK_ARCustomerReqItemID;
        protected int _fK_ARCustomerProductReqItemID;

        #endregion
        [Key]
        #region Public properties
        public int ARCustomerReqImageID
        {
            get { return _aRCustomerReqImageID; }
            set
            {
                if (value != this._aRCustomerReqImageID)
                {
                    _aRCustomerReqImageID = value;
                }
            }
        }
        public Nullable<DateTime> ARCustomerReqImageDate
        {
            get { return _aRCustomerReqImageDate; }
            set
            {
                if (value != this._aRCustomerReqImageDate)
                {
                    _aRCustomerReqImageDate = value;
                }
            }
        }
        public String ARCustomerReqImageDesc
        {
            get { return _aRCustomerReqImageDesc; }
            set
            {
                if (value != this._aRCustomerReqImageDesc)
                {
                    _aRCustomerReqImageDesc = value;
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
        public byte[] ARCustomerReqImageData
        {
            get { return _aRCustomerReqImageData; }
            set
            {
                if (value != this._aRCustomerReqImageData)
                {
                    _aRCustomerReqImageData = value;
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
        public int FK_ARCustomerReqItemID
        {
            get { return _fK_ARCustomerReqItemID; }
            set
            {
                if (value != this._fK_ARCustomerReqItemID)
                {
                    _fK_ARCustomerReqItemID = value;
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

        #endregion
    }
}
