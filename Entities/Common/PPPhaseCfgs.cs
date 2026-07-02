using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("PPPhaseCfgs")]
    public class PPPhaseCfgs : BaseInfo
    {
        #region Variables
        protected int _pPPhaseCfgID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected String _pPPhaseCfgNo = String.Empty;
        protected String _pPPhaseCfgName = String.Empty;
        protected int _fK_ICStockID;
        protected decimal _pPPhaseCfgPerFinish;
        protected String _pPPhaseCfgDesc = String.Empty;
        protected decimal _pPPhaseCfgRMPct;
        protected decimal _pPPhaseCfgLabourPct;
        protected decimal _pPPhaseCfgOverheadPct;
        protected int _pPPhaseCfgSortOrder;
        protected decimal _pPPhaseCfgProductivityQty;
        protected decimal _pPPhaseLossPct;
        protected String _aAOrgDocNo = String.Empty;
        protected bool _aASelected = true;
        protected int _fK_PPWorkCenterID;
        protected int _fK_ICNCRStockID;
        protected int _fK_ICWIPStockID;
        protected int _fK_PPPhaseCfgGroupID;
        protected int _fK_PPCostCenterID;
        protected double _pPPhaseCfgEstFinishDayQty;
        protected bool _pPPhaseCfgNotProducedCheck = false;
        protected int _fK_ICUOMID;

        #endregion
        #region Public properties
        [Key]
        public int PPPhaseCfgID
        {
            get { return _pPPhaseCfgID; }
            set
            {
                if (value != this._pPPhaseCfgID)
                {
                    _pPPhaseCfgID = value;
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
        public String PPPhaseCfgNo
        {
            get { return _pPPhaseCfgNo; }
            set
            {
                if (value != this._pPPhaseCfgNo)
                {
                    _pPPhaseCfgNo = value;
                }
            }
        }
        public String PPPhaseCfgName
        {
            get { return _pPPhaseCfgName; }
            set
            {
                if (value != this._pPPhaseCfgName)
                {
                    _pPPhaseCfgName = value;
                }
            }
        }
        public int FK_ICStockID
        {
            get { return _fK_ICStockID; }
            set
            {
                if (value != this._fK_ICStockID)
                {
                    _fK_ICStockID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPPhaseCfgPerFinish
        {
            get { return _pPPhaseCfgPerFinish; }
            set
            {
                if (value != this._pPPhaseCfgPerFinish)
                {
                    _pPPhaseCfgPerFinish = value;
                }
            }
        }
        public String PPPhaseCfgDesc
        {
            get { return _pPPhaseCfgDesc; }
            set
            {
                if (value != this._pPPhaseCfgDesc)
                {
                    _pPPhaseCfgDesc = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPPhaseCfgRMPct
        {
            get { return _pPPhaseCfgRMPct; }
            set
            {
                if (value != this._pPPhaseCfgRMPct)
                {
                    _pPPhaseCfgRMPct = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPPhaseCfgLabourPct
        {
            get { return _pPPhaseCfgLabourPct; }
            set
            {
                if (value != this._pPPhaseCfgLabourPct)
                {
                    _pPPhaseCfgLabourPct = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPPhaseCfgOverheadPct
        {
            get { return _pPPhaseCfgOverheadPct; }
            set
            {
                if (value != this._pPPhaseCfgOverheadPct)
                {
                    _pPPhaseCfgOverheadPct = value;
                }
            }
        }
        public int PPPhaseCfgSortOrder
        {
            get { return _pPPhaseCfgSortOrder; }
            set
            {
                if (value != this._pPPhaseCfgSortOrder)
                {
                    _pPPhaseCfgSortOrder = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPPhaseCfgProductivityQty
        {
            get { return _pPPhaseCfgProductivityQty; }
            set
            {
                if (value != this._pPPhaseCfgProductivityQty)
                {
                    _pPPhaseCfgProductivityQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPPhaseLossPct
        {
            get { return _pPPhaseLossPct; }
            set
            {
                if (value != this._pPPhaseLossPct)
                {
                    _pPPhaseLossPct = value;
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
        public int FK_ICNCRStockID
        {
            get { return _fK_ICNCRStockID; }
            set
            {
                if (value != this._fK_ICNCRStockID)
                {
                    _fK_ICNCRStockID = value;
                }
            }
        }
        public int FK_ICWIPStockID
        {
            get { return _fK_ICWIPStockID; }
            set
            {
                if (value != this._fK_ICWIPStockID)
                {
                    _fK_ICWIPStockID = value;
                }
            }
        }
        public int FK_PPPhaseCfgGroupID
        {
            get { return _fK_PPPhaseCfgGroupID; }
            set
            {
                if (value != this._fK_PPPhaseCfgGroupID)
                {
                    _fK_PPPhaseCfgGroupID = value;
                }
            }
        }
        public int FK_PPCostCenterID
        {
            get { return _fK_PPCostCenterID; }
            set
            {
                if (value != this._fK_PPCostCenterID)
                {
                    _fK_PPCostCenterID = value;
                }
            }
        }
        public double PPPhaseCfgEstFinishDayQty
        {
            get { return _pPPhaseCfgEstFinishDayQty; }
            set
            {
                if (value != this._pPPhaseCfgEstFinishDayQty)
                {
                    _pPPhaseCfgEstFinishDayQty = value;
                }
            }
        }
        public bool PPPhaseCfgNotProducedCheck
        {
            get { return _pPPhaseCfgNotProducedCheck; }
            set
            {
                if (value != this._pPPhaseCfgNotProducedCheck)
                {
                    _pPPhaseCfgNotProducedCheck = value;
                }
            }
        }
        public int FK_ICUOMID
        {
            get { return _fK_ICUOMID; }
            set
            {
                if (value != this._fK_ICUOMID)
                {
                    _fK_ICUOMID = value;
                }
            }
        }

        #endregion
    }

}