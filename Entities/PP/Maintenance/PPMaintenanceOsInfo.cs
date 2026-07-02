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
    [Table("PPMaintenanceOs")]
    public class PPMaintenanceOsInfo : BaseInfo
    {
        public PPMaintenanceOsInfo()
        {
        }
        #region Variables
        protected int _pPMaintenanceOID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _aAModule = String.Empty;
        protected String _pPMaintenanceONo = String.Empty;
        protected String _pPMaintenanceOName = String.Empty;
        protected String _pPMaintenanceODesc = String.Empty;
        protected Nullable<DateTime> _pPMaintenanceODate;
        protected int _fK_GLTranCfgID;
        protected int _fK_HREmployeeID;
        protected int _fK_BRBranchID;
        protected String _pPMaintenanceOStatusCombo = DefaultStatus;
        protected String _pPMaintenanceOTypeCombo = String.Empty;

        #endregion
        #region Public properties
        [Key]
        public int PPMaintenanceOID
        {
            get { return _pPMaintenanceOID; }
            set
            {
                if (value != this._pPMaintenanceOID)
                {
                    _pPMaintenanceOID = value;
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
        public String PPMaintenanceONo
        {
            get { return _pPMaintenanceONo; }
            set
            {
                if (value != this._pPMaintenanceONo)
                {
                    _pPMaintenanceONo = value;
                }
            }
        }
        public String PPMaintenanceOName
        {
            get { return _pPMaintenanceOName; }
            set
            {
                if (value != this._pPMaintenanceOName)
                {
                    _pPMaintenanceOName = value;
                }
            }
        }
        public String PPMaintenanceODesc
        {
            get { return _pPMaintenanceODesc; }
            set
            {
                if (value != this._pPMaintenanceODesc)
                {
                    _pPMaintenanceODesc = value;
                }
            }
        }
        public Nullable<DateTime> PPMaintenanceODate
        {
            get { return _pPMaintenanceODate; }
            set
            {
                if (value != this._pPMaintenanceODate)
                {
                    _pPMaintenanceODate = value;
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
        public String PPMaintenanceOStatusCombo
        {
            get { return _pPMaintenanceOStatusCombo; }
            set
            {
                if (value != this._pPMaintenanceOStatusCombo)
                {
                    _pPMaintenanceOStatusCombo = value;
                }
            }
        }
        public String PPMaintenanceOTypeCombo
        {
            get { return _pPMaintenanceOTypeCombo; }
            set
            {
                if (value != this._pPMaintenanceOTypeCombo)
                {
                    _pPMaintenanceOTypeCombo = value;
                }
            }
        }

        #endregion

    }
}
