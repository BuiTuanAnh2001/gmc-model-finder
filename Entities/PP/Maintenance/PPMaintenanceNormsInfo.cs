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
    [Table("PPMaintenanceNorms")]
    public class PPMaintenanceNormsInfo : BaseInfo
    {
        public PPMaintenanceNormsInfo()
        {
        }
        #region Variables
        protected int _pPMaintenanceNormID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _pPMaintenanceNormNo = String.Empty;
        protected String _pPMaintenanceNormName = String.Empty;
        protected double _pPMaintenanceNormQty;
        protected String _pPMaintenanceNormDesc = String.Empty;
        protected Nullable<DateTime> _pPMaintenanceNormDate;
        protected bool _pPMaintenanceNormActiveCheck = true;
        protected Nullable<DateTime> _pPMaintenanceNormFromDate;
        protected int _fK_PPDeviceID;
        protected int _fK_HREmployeeID;
        protected Nullable<DateTime> _pPMaintenanceNormToDate;

        #endregion
        [Key]
        #region Public properties
        public int PPMaintenanceNormID
        {
            get { return _pPMaintenanceNormID; }
            set
            {
                if (value != this._pPMaintenanceNormID)
                {
                    _pPMaintenanceNormID = value;
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
        public String PPMaintenanceNormNo
        {
            get { return _pPMaintenanceNormNo; }
            set
            {
                if (value != this._pPMaintenanceNormNo)
                {
                    _pPMaintenanceNormNo = value;
                }
            }
        }
        public String PPMaintenanceNormName
        {
            get { return _pPMaintenanceNormName; }
            set
            {
                if (value != this._pPMaintenanceNormName)
                {
                    _pPMaintenanceNormName = value;
                }
            }
        }
        public double PPMaintenanceNormQty
        {
            get { return _pPMaintenanceNormQty; }
            set
            {
                if (value != this._pPMaintenanceNormQty)
                {
                    _pPMaintenanceNormQty = value;
                }
            }
        }
        public String PPMaintenanceNormDesc
        {
            get { return _pPMaintenanceNormDesc; }
            set
            {
                if (value != this._pPMaintenanceNormDesc)
                {
                    _pPMaintenanceNormDesc = value;
                }
            }
        }
        public Nullable<DateTime> PPMaintenanceNormDate
        {
            get { return _pPMaintenanceNormDate; }
            set
            {
                if (value != this._pPMaintenanceNormDate)
                {
                    _pPMaintenanceNormDate = value;
                }
            }
        }
        public bool PPMaintenanceNormActiveCheck
        {
            get { return _pPMaintenanceNormActiveCheck; }
            set
            {
                if (value != this._pPMaintenanceNormActiveCheck)
                {
                    _pPMaintenanceNormActiveCheck = value;
                }
            }
        }
        public Nullable<DateTime> PPMaintenanceNormFromDate
        {
            get { return _pPMaintenanceNormFromDate; }
            set
            {
                if (value != this._pPMaintenanceNormFromDate)
                {
                    _pPMaintenanceNormFromDate = value;
                }
            }
        }
        public int FK_PPDeviceID
        {
            get { return _fK_PPDeviceID; }
            set
            {
                if (value != this._fK_PPDeviceID)
                {
                    _fK_PPDeviceID = value;
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
        public Nullable<DateTime> PPMaintenanceNormToDate
        {
            get { return _pPMaintenanceNormToDate; }
            set
            {
                if (value != this._pPMaintenanceNormToDate)
                {
                    _pPMaintenanceNormToDate = value;
                }
            }
        }

        #endregion
    }

}
