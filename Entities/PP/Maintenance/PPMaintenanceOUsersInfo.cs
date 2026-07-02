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
    [Table("PPMaintenanceOUsers")]
    public class PPMaintenanceOUsersInfo : BaseInfo
    {
        public PPMaintenanceOUsersInfo()
        {
        }
        #region Variables
        protected int _pPMaintenanceOUserID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _pPMaintenanceOUserDesc = String.Empty;
        protected int _fK_HREmployeeID;
        protected int _fK_HRDepartmentID;
        protected String _pPMaintenanceOUserStatusCombo = DefaultStatus;
        protected int _fK_PPMaintenanceOID;
        protected Nullable<DateTime> _pPMaintenanceOUserStarDate;
        protected Nullable<DateTime> _pPMaintenanceOUserEndDate;
        protected decimal _pPMaintenanceOUserQty;
        protected decimal _pPMaintenanceOUserRQty;

        #endregion
        #region Public properties
        [Key]
        public int PPMaintenanceOUserID
        {
            get { return _pPMaintenanceOUserID; }
            set
            {
                if (value != this._pPMaintenanceOUserID)
                {
                    _pPMaintenanceOUserID = value;
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
        public String PPMaintenanceOUserDesc
        {
            get { return _pPMaintenanceOUserDesc; }
            set
            {
                if (value != this._pPMaintenanceOUserDesc)
                {
                    _pPMaintenanceOUserDesc = value;
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
        public String PPMaintenanceOUserStatusCombo
        {
            get { return _pPMaintenanceOUserStatusCombo; }
            set
            {
                if (value != this._pPMaintenanceOUserStatusCombo)
                {
                    _pPMaintenanceOUserStatusCombo = value;
                }
            }
        }
        public int FK_PPMaintenanceOID
        {
            get { return _fK_PPMaintenanceOID; }
            set
            {
                if (value != this._fK_PPMaintenanceOID)
                {
                    _fK_PPMaintenanceOID = value;
                }
            }
        }
        public Nullable<DateTime> PPMaintenanceOUserStarDate
        {
            get { return _pPMaintenanceOUserStarDate; }
            set
            {
                if (value != this._pPMaintenanceOUserStarDate)
                {
                    _pPMaintenanceOUserStarDate = value;
                }
            }
        }
        public Nullable<DateTime> PPMaintenanceOUserEndDate
        {
            get { return _pPMaintenanceOUserEndDate; }
            set
            {
                if (value != this._pPMaintenanceOUserEndDate)
                {
                    _pPMaintenanceOUserEndDate = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPMaintenanceOUserQty
        {
            get { return _pPMaintenanceOUserQty; }
            set
            {
                if (value != this._pPMaintenanceOUserQty)
                {
                    _pPMaintenanceOUserQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPMaintenanceOUserRQty
        {
            get { return _pPMaintenanceOUserRQty; }
            set
            {
                if (value != this._pPMaintenanceOUserRQty)
                {
                    _pPMaintenanceOUserRQty = value;
                }
            }
        }

        #endregion

    }
}
