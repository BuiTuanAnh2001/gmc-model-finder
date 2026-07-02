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
    [Table("PPRequestMaintenances")]
    public class PPRequestMaintenancesInfo : BaseInfo
    {
        public PPRequestMaintenancesInfo()
        {
        }
        #region Variables
        protected int _pPRequestMaintenanceID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _aAModule = String.Empty;
        protected String _pPRequestMaintenanceNo = String.Empty;
        protected String _pPRequestMaintenanceName = String.Empty;
        protected String _pPRequestMaintenanceDesc = String.Empty;
        protected Nullable<DateTime> _pPRequestMaintenanceDate;
        protected int _fK_GLTranCfgID;
        protected int _fK_HREmployeeID;
        protected int _fK_BRBranchID;
        protected String _pPRequestMaintenanceStatusCombo = DefaultStatus;

        #endregion
        [Key]
        #region Public properties
        public int PPRequestMaintenanceID
        {
            get { return _pPRequestMaintenanceID; }
            set
            {
                if (value != this._pPRequestMaintenanceID)
                {
                    _pPRequestMaintenanceID = value;
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
        public String AAModule
        {
            get { return _aAModule; }
            set
            {
                if (value != this._aAModule)
                {
                    _aAModule = value;
                }
            }
        }
        public String PPRequestMaintenanceNo
        {
            get { return _pPRequestMaintenanceNo; }
            set
            {
                if (value != this._pPRequestMaintenanceNo)
                {
                    _pPRequestMaintenanceNo = value;
                }
            }
        }
        public String PPRequestMaintenanceName
        {
            get { return _pPRequestMaintenanceName; }
            set
            {
                if (value != this._pPRequestMaintenanceName)
                {
                    _pPRequestMaintenanceName = value;
                }
            }
        }
        public String PPRequestMaintenanceDesc
        {
            get { return _pPRequestMaintenanceDesc; }
            set
            {
                if (value != this._pPRequestMaintenanceDesc)
                {
                    _pPRequestMaintenanceDesc = value;
                }
            }
        }
        public Nullable<DateTime> PPRequestMaintenanceDate
        {
            get { return _pPRequestMaintenanceDate; }
            set
            {
                if (value != this._pPRequestMaintenanceDate)
                {
                    _pPRequestMaintenanceDate = value;
                }
            }
        }
        public int FK_GLTranCfgID
        {
            get { return _fK_GLTranCfgID; }
            set
            {
                if (value != this._fK_GLTranCfgID)
                {
                    _fK_GLTranCfgID = value;
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
        public int FK_BRBranchID
        {
            get { return _fK_BRBranchID; }
            set
            {
                if (value != this._fK_BRBranchID)
                {
                    _fK_BRBranchID = value;
                }
            }
        }
        public String PPRequestMaintenanceStatusCombo
        {
            get { return _pPRequestMaintenanceStatusCombo; }
            set
            {
                if (value != this._pPRequestMaintenanceStatusCombo)
                {
                    _pPRequestMaintenanceStatusCombo = value;
                }
            }
        }

        #endregion
    }
}
