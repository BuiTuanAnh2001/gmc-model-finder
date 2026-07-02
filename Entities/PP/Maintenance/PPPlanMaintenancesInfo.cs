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
    [Table("PPPlanMaintenances")]
    public class PPPlanMaintenancesInfo : BaseInfo
    {
        public PPPlanMaintenancesInfo()
        {
        }
        #region Variables
        protected int _pPPlanMaintenanceID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _aAModule = String.Empty;
        protected String _pPPlanMaintenanceNo = String.Empty;
        protected String _pPPlanMaintenanceName = String.Empty;
        protected String _pPPlanMaintenanceDesc = String.Empty;
        protected Nullable<DateTime> _pPPlanMaintenanceDate;
        protected int _fK_GLTranCfgID;
        protected int _fK_HREmployeeID;
        protected int _fK_BRBranchID;
        protected String _pPPlanMaintenanceStatusCombo = DefaultStatus;
        protected int _fK_ADApprovalProcID;
        protected String _approvalStatusCombo = DefaultStatus;
        protected int _pPPlanMaintenancePeriod;
        protected int _pPPlanMaintenanceYear;

        #endregion
        #region Public properties
        [Key]
        public int PPPlanMaintenanceID
        {
            get { return _pPPlanMaintenanceID; }
            set
            {
                if (value != this._pPPlanMaintenanceID)
                {
                    _pPPlanMaintenanceID = value;
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
        public String PPPlanMaintenanceNo
        {
            get { return _pPPlanMaintenanceNo; }
            set
            {
                if (value != this._pPPlanMaintenanceNo)
                {
                    _pPPlanMaintenanceNo = value;
                }
            }
        }
        public String PPPlanMaintenanceName
        {
            get { return _pPPlanMaintenanceName; }
            set
            {
                if (value != this._pPPlanMaintenanceName)
                {
                    _pPPlanMaintenanceName = value;
                }
            }
        }
        public String PPPlanMaintenanceDesc
        {
            get { return _pPPlanMaintenanceDesc; }
            set
            {
                if (value != this._pPPlanMaintenanceDesc)
                {
                    _pPPlanMaintenanceDesc = value;
                }
            }
        }
        public Nullable<DateTime> PPPlanMaintenanceDate
        {
            get { return _pPPlanMaintenanceDate; }
            set
            {
                if (value != this._pPPlanMaintenanceDate)
                {
                    _pPPlanMaintenanceDate = value;
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
        public String PPPlanMaintenanceStatusCombo
        {
            get { return _pPPlanMaintenanceStatusCombo; }
            set
            {
                if (value != this._pPPlanMaintenanceStatusCombo)
                {
                    _pPPlanMaintenanceStatusCombo = value;
                }
            }
        }
        public int FK_ADApprovalProcID
        {
            get { return _fK_ADApprovalProcID; }
            set
            {
                if (value != this._fK_ADApprovalProcID)
                {
                    _fK_ADApprovalProcID = value;
                }
            }
        }
        public String ApprovalStatusCombo
        {
            get { return _approvalStatusCombo; }
            set
            {
                if (value != this._approvalStatusCombo)
                {
                    _approvalStatusCombo = value;
                }
            }
        }
        public int PPPlanMaintenancePeriod
        {
            get { return _pPPlanMaintenancePeriod; }
            set
            {
                if (value != this._pPPlanMaintenancePeriod)
                {
                    _pPPlanMaintenancePeriod = value;
                }
            }
        }
        public int PPPlanMaintenanceYear
        {
            get { return _pPPlanMaintenanceYear; }
            set
            {
                if (value != this._pPPlanMaintenanceYear)
                {
                    _pPPlanMaintenanceYear = value;
                }
            }
        }

        #endregion
    }
}
