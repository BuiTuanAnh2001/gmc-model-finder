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
    [Table("PPMaintenanceResults")]
    public class PPMaintenanceResultsInfo : BaseInfo
    {
        public PPMaintenanceResultsInfo()
        {
        }
        #region Variables
        protected int _pPMaintenanceResultID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _aAModule = String.Empty;
        protected String _pPMaintenanceResultNo = String.Empty;
        protected String _pPMaintenanceResultName = String.Empty;
        protected String _pPMaintenanceResultDesc = String.Empty;
        protected Nullable<DateTime> _pPMaintenanceResultDate;
        protected int _fK_GLTranCfgID;
        protected int _fK_HREmployeeID;
        protected int _fK_BRBranchID;
        protected String _pPMaintenanceResultStatusCombo = DefaultStatus;
        protected String _pPMaintenanceResultTypeCombo = String.Empty;

        #endregion
        [Key]
        #region Public properties
        public int PPMaintenanceResultID
        {
            get { return _pPMaintenanceResultID; }
            set
            {
                if (value != this._pPMaintenanceResultID)
                {
                    _pPMaintenanceResultID = value;
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
        public String PPMaintenanceResultNo
        {
            get { return _pPMaintenanceResultNo; }
            set
            {
                if (value != this._pPMaintenanceResultNo)
                {
                    _pPMaintenanceResultNo = value;
                }
            }
        }
        public String PPMaintenanceResultName
        {
            get { return _pPMaintenanceResultName; }
            set
            {
                if (value != this._pPMaintenanceResultName)
                {
                    _pPMaintenanceResultName = value;
                }
            }
        }
        public String PPMaintenanceResultDesc
        {
            get { return _pPMaintenanceResultDesc; }
            set
            {
                if (value != this._pPMaintenanceResultDesc)
                {
                    _pPMaintenanceResultDesc = value;
                }
            }
        }
        public Nullable<DateTime> PPMaintenanceResultDate
        {
            get { return _pPMaintenanceResultDate; }
            set
            {
                if (value != this._pPMaintenanceResultDate)
                {
                    _pPMaintenanceResultDate = value;
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
        public String PPMaintenanceResultStatusCombo
        {
            get { return _pPMaintenanceResultStatusCombo; }
            set
            {
                if (value != this._pPMaintenanceResultStatusCombo)
                {
                    _pPMaintenanceResultStatusCombo = value;
                }
            }
        }
        public String PPMaintenanceResultTypeCombo
        {
            get { return _pPMaintenanceResultTypeCombo; }
            set
            {
                if (value != this._pPMaintenanceResultTypeCombo)
                {
                    _pPMaintenanceResultTypeCombo = value;
                }
            }
        }

        #endregion
    }
}
