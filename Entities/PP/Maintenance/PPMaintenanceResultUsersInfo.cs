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
    [Table("PPMaintenanceResultUsers")]
    public class PPMaintenanceResultUsersInfo : BaseInfo
    {
        public PPMaintenanceResultUsersInfo()
        {
        }
        #region Variables
        protected int _pPMaintenanceResultUserID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _pPMaintenanceResultUserDesc = String.Empty;
        protected int _fK_HREmployeeID;
        protected int _fK_HRDepartmentID;
        protected String _pPMaintenanceResultUserStatusCombo = DefaultStatus;
        protected int _fK_PPMaintenanceResultID;
        protected int _fK_PPMaintenanceOUserID;
        protected Nullable<DateTime> _pPMaintenanceResultUserStarDate;
        protected Nullable<DateTime> _pPMaintenanceResultUserEndDate;
        protected Nullable<DateTime> _pPMaintenanceResultUserActStarDate;
        protected Nullable<DateTime> _pPMaintenanceResultUserActEndDate;
        protected decimal _pPMaintenanceResultUserQty;
        protected decimal _pPMaintenanceResultUserRQty;
        protected decimal _pPMaintenanceResultUserActQty;
        protected decimal _pPMaintenanceResultUserActRQty;

        #endregion
        [Key]
        #region Public properties
        public int PPMaintenanceResultUserID
        {
            get { return _pPMaintenanceResultUserID; }
            set
            {
                if (value != this._pPMaintenanceResultUserID)
                {
                    _pPMaintenanceResultUserID = value;
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
        public String PPMaintenanceResultUserDesc
        {
            get { return _pPMaintenanceResultUserDesc; }
            set
            {
                if (value != this._pPMaintenanceResultUserDesc)
                {
                    _pPMaintenanceResultUserDesc = value;
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
        public int FK_HRDepartmentID
        {
            get { return _fK_HRDepartmentID; }
            set
            {
                if (value != this._fK_HRDepartmentID)
                {
                    _fK_HRDepartmentID = value;
                }
            }
        }
        public String PPMaintenanceResultUserStatusCombo
        {
            get { return _pPMaintenanceResultUserStatusCombo; }
            set
            {
                if (value != this._pPMaintenanceResultUserStatusCombo)
                {
                    _pPMaintenanceResultUserStatusCombo = value;
                }
            }
        }
        public int FK_PPMaintenanceResultID
        {
            get { return _fK_PPMaintenanceResultID; }
            set
            {
                if (value != this._fK_PPMaintenanceResultID)
                {
                    _fK_PPMaintenanceResultID = value;
                }
            }
        }
        public int FK_PPMaintenanceOUserID
        {
            get { return _fK_PPMaintenanceOUserID; }
            set
            {
                if (value != this._fK_PPMaintenanceOUserID)
                {
                    _fK_PPMaintenanceOUserID = value;
                }
            }
        }
        public Nullable<DateTime> PPMaintenanceResultUserStarDate
        {
            get { return _pPMaintenanceResultUserStarDate; }
            set
            {
                if (value != this._pPMaintenanceResultUserStarDate)
                {
                    _pPMaintenanceResultUserStarDate = value;
                }
            }
        }
        public Nullable<DateTime> PPMaintenanceResultUserEndDate
        {
            get { return _pPMaintenanceResultUserEndDate; }
            set
            {
                if (value != this._pPMaintenanceResultUserEndDate)
                {
                    _pPMaintenanceResultUserEndDate = value;
                }
            }
        }
        public Nullable<DateTime> PPMaintenanceResultUserActStarDate
        {
            get { return _pPMaintenanceResultUserActStarDate; }
            set
            {
                if (value != this._pPMaintenanceResultUserActStarDate)
                {
                    _pPMaintenanceResultUserActStarDate = value;
                }
            }
        }
        public Nullable<DateTime> PPMaintenanceResultUserActEndDate
        {
            get { return _pPMaintenanceResultUserActEndDate; }
            set
            {
                if (value != this._pPMaintenanceResultUserActEndDate)
                {
                    _pPMaintenanceResultUserActEndDate = value;
                }
            }
        }
        public decimal PPMaintenanceResultUserQty
        {
            get { return _pPMaintenanceResultUserQty; }
            set
            {
                if (value != this._pPMaintenanceResultUserQty)
                {
                    _pPMaintenanceResultUserQty = value;
                }
            }
        }
        public decimal PPMaintenanceResultUserRQty
        {
            get { return _pPMaintenanceResultUserRQty; }
            set
            {
                if (value != this._pPMaintenanceResultUserRQty)
                {
                    _pPMaintenanceResultUserRQty = value;
                }
            }
        }
        public decimal PPMaintenanceResultUserActQty
        {
            get { return _pPMaintenanceResultUserActQty; }
            set
            {
                if (value != this._pPMaintenanceResultUserActQty)
                {
                    _pPMaintenanceResultUserActQty = value;
                }
            }
        }
        public decimal PPMaintenanceResultUserActRQty
        {
            get { return _pPMaintenanceResultUserActRQty; }
            set
            {
                if (value != this._pPMaintenanceResultUserActRQty)
                {
                    _pPMaintenanceResultUserActRQty = value;
                }
            }
        }

        #endregion
    }
}
