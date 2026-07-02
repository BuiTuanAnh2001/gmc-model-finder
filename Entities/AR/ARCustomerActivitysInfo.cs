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
    [Table("ARCustomerActivitys")]
    public class ARCustomerActivitysInfo : BaseInfo
    {
        public ARCustomerActivitysInfo()
        {
        }
        #region Variables
        protected int _aRCustomerActivityID;
        protected String _aRCustomerActivityNo = String.Empty;
        protected String _aRCustomerActivityName = String.Empty;
        protected Nullable<DateTime> _aRCustomerActivityDate;
        protected String _aRCustomerActivityDesc = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected bool _aASelected = true;
        protected int _fK_ARCustomerID;
        protected int _fK_ARActitivityTypeID;
        protected int _fK_ARActivityReasonID;
        protected decimal _aRCustomerActivityHrs;
        protected decimal _aRCustomerActivityCost;
        protected int _fK_HREmployeeID;
        protected String _aRCustomerActivityResult = String.Empty;
        protected String _aRCustomerActivityNextActivityDesc = String.Empty;
        protected Nullable<DateTime> _aRCustomerActivityNextActivityDate;

        #endregion
        [Key]
        #region Public properties
        public int ARCustomerActivityID
        {
            get { return _aRCustomerActivityID; }
            set
            {
                if (value != this._aRCustomerActivityID)
                {
                    _aRCustomerActivityID = value;
                }
            }
        }
        public String ARCustomerActivityNo
        {
            get { return _aRCustomerActivityNo; }
            set
            {
                if (value != this._aRCustomerActivityNo)
                {
                    _aRCustomerActivityNo = value;
                }
            }
        }
        public String ARCustomerActivityName
        {
            get { return _aRCustomerActivityName; }
            set
            {
                if (value != this._aRCustomerActivityName)
                {
                    _aRCustomerActivityName = value;
                }
            }
        }
        public Nullable<DateTime> ARCustomerActivityDate
        {
            get { return _aRCustomerActivityDate; }
            set
            {
                if (value != this._aRCustomerActivityDate)
                {
                    _aRCustomerActivityDate = value;
                }
            }
        }
        public String ARCustomerActivityDesc
        {
            get { return _aRCustomerActivityDesc; }
            set
            {
                if (value != this._aRCustomerActivityDesc)
                {
                    _aRCustomerActivityDesc = value;
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
        public int FK_ARCustomerID
        {
            get { return _fK_ARCustomerID; }
            set
            {
                if (value != this._fK_ARCustomerID)
                {
                    _fK_ARCustomerID = value;
                }
            }
        }
        public int FK_ARActitivityTypeID
        {
            get { return _fK_ARActitivityTypeID; }
            set
            {
                if (value != this._fK_ARActitivityTypeID)
                {
                    _fK_ARActitivityTypeID = value;
                }
            }
        }
        public int FK_ARActivityReasonID
        {
            get { return _fK_ARActivityReasonID; }
            set
            {
                if (value != this._fK_ARActivityReasonID)
                {
                    _fK_ARActivityReasonID = value;
                }
            }
        }
        public decimal ARCustomerActivityHrs
        {
            get { return _aRCustomerActivityHrs; }
            set
            {
                if (value != this._aRCustomerActivityHrs)
                {
                    _aRCustomerActivityHrs = value;
                }
            }
        }
        public decimal ARCustomerActivityCost
        {
            get { return _aRCustomerActivityCost; }
            set
            {
                if (value != this._aRCustomerActivityCost)
                {
                    _aRCustomerActivityCost = value;
                }
            }
        }
        public int FK_HREmployeeID
        {
            get { return _fK_HREmployeeID; }
            set
            {
                if (value != this._fK_HREmployeeID)
                {
                    _fK_HREmployeeID = value;
                }
            }
        }
        public String ARCustomerActivityResult
        {
            get { return _aRCustomerActivityResult; }
            set
            {
                if (value != this._aRCustomerActivityResult)
                {
                    _aRCustomerActivityResult = value;
                }
            }
        }
        public String ARCustomerActivityNextActivityDesc
        {
            get { return _aRCustomerActivityNextActivityDesc; }
            set
            {
                if (value != this._aRCustomerActivityNextActivityDesc)
                {
                    _aRCustomerActivityNextActivityDesc = value;
                }
            }
        }
        public Nullable<DateTime> ARCustomerActivityNextActivityDate
        {
            get { return _aRCustomerActivityNextActivityDate; }
            set
            {
                if (value != this._aRCustomerActivityNextActivityDate)
                {
                    _aRCustomerActivityNextActivityDate = value;
                }
            }
        }

        #endregion
    }
}
