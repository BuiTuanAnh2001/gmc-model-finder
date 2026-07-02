using gmc_api.Entities;
using System;
using System.Collections.Generic;

namespace gmc_api.DTO.PP
{
    public class AppProductionOrdr
    {
        #region Variables
        protected int _pPProductionOrdrID;
        protected String _aAStatus = "Alive";
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAPostStatus = "New";
        protected String _aALastPostNo = String.Empty;
        protected Nullable<DateTime> _aALastPostDate;
        protected String _pPProductionOrdrNo = String.Empty;
        protected String _pPProductionOrdrName = String.Empty;
        protected String _pPProductionOrdrDesc = String.Empty;
        protected DateTime _pPProductionOrdrDate = DateTime.Now;
        protected String _pPProductionOrdrStatus = "New";
        protected Nullable<DateTime> _pPProductionOrdrEstDate;
        protected Nullable<DateTime> _pPProductionOrdrActDate;
        protected int _fK_HREmployeeID;
        protected int _fK_PPWOID;
        protected int _fK_PPPhaseCfgID;
        protected int _fK_ICFromStockID;
        protected int _fK_ICToStockID;
        protected Nullable<DateTime> _pPProductionOrdrEstStartDate;
        protected Nullable<DateTime> _pPProductionOrdrEstEndDate;
        protected Nullable<DateTime> _pPProductionOrdrActStartDate;
        protected Nullable<DateTime> _pPProductionOrdrActEndDate;
        protected String _pPProductionOrdrTypeCombo = String.Empty;
        protected String _pPProductionOrdrLotNo = String.Empty;
        protected bool _aASelected = true;
        protected String _aACompanyTypeCombo = String.Empty;
        protected String _aAOrgDocNo = String.Empty;
        protected int _fK_PPProductionOrdrParentID;
        protected int _fK_PPWorkCenterID;
        protected int _fK_PPResourceID;
        protected Nullable<DateTime> _pPProductionOrdrJrnDate;
        protected int _fK_BRBranchID;
        protected String _pPProductionOrdrConvertTypeCombo = String.Empty;
        protected int _fK_PPPrdQCID;
        protected String _pPProductionOrdrJrnNo = String.Empty;
        protected int _fK_GLTranCfgID;
        protected int _fK_ICConvertProductID;
        protected String _pPProductionOrdrGroupCombo = String.Empty;
        protected int _fK_HRMachineID;
        protected int _fK_ICProductRootID;
        protected Nullable<DateTime> _pPProductionOrdrCloseDate;
        protected String _pPProductionOrdrQCStatusCombo = "New";
        protected String _pPProductionOrdrCStatusCombo = "New";

        #endregion

        #region Public properties
        public int PPProductionOrdrID
        {
            get { return _pPProductionOrdrID; }
            set
            {
                if (value != this._pPProductionOrdrID)
                {
                    _pPProductionOrdrID = value;
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
        public String AAPostStatus
        {
            get { return _aAPostStatus; }
            set
            {
                if (value != this._aAPostStatus)
                {
                    _aAPostStatus = value;
                }
            }
        }
        public String AALastPostNo
        {
            get { return _aALastPostNo; }
            set
            {
                if (value != this._aALastPostNo)
                {
                    _aALastPostNo = value;
                }
            }
        }
        public Nullable<DateTime> AALastPostDate
        {
            get { return _aALastPostDate; }
            set
            {
                if (value != this._aALastPostDate)
                {
                    _aALastPostDate = value;
                }
            }
        }
        public String PPProductionOrdrNo
        {
            get { return _pPProductionOrdrNo; }
            set
            {
                if (value != this._pPProductionOrdrNo)
                {
                    _pPProductionOrdrNo = value;
                }
            }
        }
        public String PPProductionOrdrName
        {
            get { return _pPProductionOrdrName; }
            set
            {
                if (value != this._pPProductionOrdrName)
                {
                    _pPProductionOrdrName = value;
                }
            }
        }
        public String PPProductionOrdrDesc
        {
            get { return _pPProductionOrdrDesc; }
            set
            {
                if (value != this._pPProductionOrdrDesc)
                {
                    _pPProductionOrdrDesc = value;
                }
            }
        }
        public DateTime PPProductionOrdrDate
        {
            get { return _pPProductionOrdrDate; }
            set
            {
                if (value != this._pPProductionOrdrDate)
                {
                    _pPProductionOrdrDate = value;
                }
            }
        }
        public String PPProductionOrdrStatus
        {
            get { return _pPProductionOrdrStatus; }
            set
            {
                if (value != this._pPProductionOrdrStatus)
                {
                    _pPProductionOrdrStatus = value;
                }
            }
        }
        public Nullable<DateTime> PPProductionOrdrEstDate
        {
            get { return _pPProductionOrdrEstDate; }
            set
            {
                if (value != this._pPProductionOrdrEstDate)
                {
                    _pPProductionOrdrEstDate = value;
                }
            }
        }
        public Nullable<DateTime> PPProductionOrdrActDate
        {
            get { return _pPProductionOrdrActDate; }
            set
            {
                if (value != this._pPProductionOrdrActDate)
                {
                    _pPProductionOrdrActDate = value;
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
        public int FK_PPWOID
        {
            get { return _fK_PPWOID; }
            set
            {
                if (value != this._fK_PPWOID)
                {
                    _fK_PPWOID = value;
                }
            }
        }
        public int FK_PPPhaseCfgID
        {
            get { return _fK_PPPhaseCfgID; }
            set
            {
                if (value != this._fK_PPPhaseCfgID)
                {
                    _fK_PPPhaseCfgID = value;
                }
            }
        }
        public int FK_ICFromStockID
        {
            get { return _fK_ICFromStockID; }
            set
            {
                if (value != this._fK_ICFromStockID)
                {
                    _fK_ICFromStockID = value;
                }
            }
        }
        public int FK_ICToStockID
        {
            get { return _fK_ICToStockID; }
            set
            {
                if (value != this._fK_ICToStockID)
                {
                    _fK_ICToStockID = value;
                }
            }
        }
        public Nullable<DateTime> PPProductionOrdrEstStartDate
        {
            get { return _pPProductionOrdrEstStartDate; }
            set
            {
                if (value != this._pPProductionOrdrEstStartDate)
                {
                    _pPProductionOrdrEstStartDate = value;
                }
            }
        }
        public Nullable<DateTime> PPProductionOrdrEstEndDate
        {
            get { return _pPProductionOrdrEstEndDate; }
            set
            {
                if (value != this._pPProductionOrdrEstEndDate)
                {
                    _pPProductionOrdrEstEndDate = value;
                }
            }
        }
        public Nullable<DateTime> PPProductionOrdrActStartDate
        {
            get { return _pPProductionOrdrActStartDate; }
            set
            {
                if (value != this._pPProductionOrdrActStartDate)
                {
                    _pPProductionOrdrActStartDate = value;
                }
            }
        }
        public Nullable<DateTime> PPProductionOrdrActEndDate
        {
            get { return _pPProductionOrdrActEndDate; }
            set
            {
                if (value != this._pPProductionOrdrActEndDate)
                {
                    _pPProductionOrdrActEndDate = value;
                }
            }
        }
        public String PPProductionOrdrTypeCombo
        {
            get { return _pPProductionOrdrTypeCombo; }
            set
            {
                if (value != this._pPProductionOrdrTypeCombo)
                {
                    _pPProductionOrdrTypeCombo = value;
                }
            }
        }
        public String PPProductionOrdrLotNo
        {
            get { return _pPProductionOrdrLotNo; }
            set
            {
                if (value != this._pPProductionOrdrLotNo)
                {
                    _pPProductionOrdrLotNo = value;
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
        public String AACompanyTypeCombo
        {
            get { return _aACompanyTypeCombo; }
            set
            {
                if (value != this._aACompanyTypeCombo)
                {
                    _aACompanyTypeCombo = value;
                }
            }
        }
        public String AAOrgDocNo
        {
            get { return _aAOrgDocNo; }
            set
            {
                if (value != this._aAOrgDocNo)
                {
                    _aAOrgDocNo = value;
                }
            }
        }
        public int FK_PPProductionOrdrParentID
        {
            get { return _fK_PPProductionOrdrParentID; }
            set
            {
                if (value != this._fK_PPProductionOrdrParentID)
                {
                    _fK_PPProductionOrdrParentID = value;
                }
            }
        }
        public int FK_PPWorkCenterID
        {
            get { return _fK_PPWorkCenterID; }
            set
            {
                if (value != this._fK_PPWorkCenterID)
                {
                    _fK_PPWorkCenterID = value;
                }
            }
        }
        public int FK_PPResourceID
        {
            get { return _fK_PPResourceID; }
            set
            {
                if (value != this._fK_PPResourceID)
                {
                    _fK_PPResourceID = value;
                }
            }
        }
        public Nullable<DateTime> PPProductionOrdrJrnDate
        {
            get { return _pPProductionOrdrJrnDate; }
            set
            {
                if (value != this._pPProductionOrdrJrnDate)
                {
                    _pPProductionOrdrJrnDate = value;
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
        public String PPProductionOrdrConvertTypeCombo
        {
            get { return _pPProductionOrdrConvertTypeCombo; }
            set
            {
                if (value != this._pPProductionOrdrConvertTypeCombo)
                {
                    _pPProductionOrdrConvertTypeCombo = value;
                }
            }
        }
        public int FK_PPPrdQCID
        {
            get { return _fK_PPPrdQCID; }
            set
            {
                if (value != this._fK_PPPrdQCID)
                {
                    _fK_PPPrdQCID = value;
                }
            }
        }
        public String PPProductionOrdrJrnNo
        {
            get { return _pPProductionOrdrJrnNo; }
            set
            {
                if (value != this._pPProductionOrdrJrnNo)
                {
                    _pPProductionOrdrJrnNo = value;
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
        public int FK_ICConvertProductID
        {
            get { return _fK_ICConvertProductID; }
            set
            {
                if (value != this._fK_ICConvertProductID)
                {
                    _fK_ICConvertProductID = value;
                }
            }
        }
        public String PPProductionOrdrGroupCombo
        {
            get { return _pPProductionOrdrGroupCombo; }
            set
            {
                if (value != this._pPProductionOrdrGroupCombo)
                {
                    _pPProductionOrdrGroupCombo = value;
                }
            }
        }
        public int FK_HRMachineID
        {
            get { return _fK_HRMachineID; }
            set
            {
                if (value != this._fK_HRMachineID)
                {
                    _fK_HRMachineID = value;
                }
            }
        }
        public int FK_ICProductRootID
        {
            get { return _fK_ICProductRootID; }
            set
            {
                if (value != this._fK_ICProductRootID)
                {
                    _fK_ICProductRootID = value;
                }
            }
        }
        public Nullable<DateTime> PPProductionOrdrCloseDate
        {
            get { return _pPProductionOrdrCloseDate; }
            set
            {
                if (value != this._pPProductionOrdrCloseDate)
                {
                    _pPProductionOrdrCloseDate = value;
                }
            }
        }
        public String PPProductionOrdrQCStatusCombo
        {
            get { return _pPProductionOrdrQCStatusCombo; }
            set
            {
                if (value != this._pPProductionOrdrQCStatusCombo)
                {
                    _pPProductionOrdrQCStatusCombo = value;
                }
            }
        }
        public String PPProductionOrdrCStatusCombo
        {
            get { return _pPProductionOrdrCStatusCombo; }
            set
            {
                if (value != this._pPProductionOrdrCStatusCombo)
                {
                    _pPProductionOrdrCStatusCombo = value;
                }
            }
        }

        #endregion
        public List<PPProductionOrdrEstFGs> lstPPProductionOrdrEstFGs
            { get; set; } = new List<PPProductionOrdrEstFGs>();
        public List<PPProductionOrdrEstRMs> lstPPProductionOrdrEstRMs
            { get; set; } = new List<PPProductionOrdrEstRMs>(); 
    }
}
