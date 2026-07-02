using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("PPNormRMs")]
    public class PPNormRMs : BaseInfo
    {
        #region Variables
        protected int _pPNormRMID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_PPNormID;
        protected int _fK_ICProductID;
        protected decimal _pPNormRMQty;
        protected String _pPNormRMDesc = String.Empty;
        protected int _fK_PPPhaseCfgID;
        protected bool _pPNormRMIsMajorMaterial = true;
        protected decimal _pPNormRMLossPct;
        protected String _pPNormRMPictureLink = String.Empty;
        protected int _fK_PPWorkCenterID;
        protected int _fK_ICStockUOMID;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected decimal _pPNormRMStkQty;
        protected decimal _pPNormRMRQty;
        protected decimal _pPNormRMRStkQty;
        protected int _fK_ICWeightUOMID;
        protected int _fK_ICVolumeUOMID;
        protected decimal _pPNormRMWTot;
        protected decimal _pPNormRMVTot;
        protected decimal _pPNormRMFact;
        protected decimal _pPNormRMAllocatePct;
        protected int _fK_GEAnalysisID;
        protected int _fK_ADOFID;
        protected int _fK_ADOFItemID;
        protected String _pPNormRMRevision = String.Empty;
        protected bool _pPNormRMIsMainProductionCheck = true;
        protected bool _pPNormRMIsSemiFinishedProduct = true;
        protected bool _pPNormRMIsOutSource = false;
        protected decimal _pPNormRMSetupQty;
        protected bool _pPNormRMOSSupplyCheck = false;
        protected int _fK_PPLossCfgID;
        protected String _pPNormRMPOF01Combo = String.Empty;
        protected String _pPNormRMPOF02Combo = String.Empty;
        protected String _pPNormRMPOF03Combo = String.Empty;
        protected String _pPNormRMPOF04Combo = String.Empty;
        protected String _pPNormRMPOF05Combo = String.Empty;
        protected String _pPNormRMFGPOF01Combo = String.Empty;
        protected String _pPNormRMFGPOF02Combo = String.Empty;
        protected String _pPNormRMApplyTypeCombo = String.Empty;
        protected int _fK_PPNormRMID;
        protected int _fK_PPGeneralNormItemID;

        #endregion
        #region Public properties
        [Key]
        public int PPNormRMID
        {
            get { return _pPNormRMID; }
            set
            {
                if (value != this._pPNormRMID)
                {
                    _pPNormRMID = value;
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
        public int FK_PPNormID
        {
            get { return _fK_PPNormID; }
            set
            {
                if (value != this._fK_PPNormID)
                {
                    _fK_PPNormID = value;
                }
            }
        }
        public int FK_ICProductID
        {
            get { return _fK_ICProductID; }
            set
            {
                if (value != this._fK_ICProductID)
                {
                    _fK_ICProductID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPNormRMQty
        {
            get { return _pPNormRMQty; }
            set
            {
                if (value != this._pPNormRMQty)
                {
                    _pPNormRMQty = value;
                }
            }
        }
        public String PPNormRMDesc
        {
            get { return _pPNormRMDesc; }
            set
            {
                if (value != this._pPNormRMDesc)
                {
                    _pPNormRMDesc = value;
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
        public bool PPNormRMIsMajorMaterial
        {
            get { return _pPNormRMIsMajorMaterial; }
            set
            {
                if (value != this._pPNormRMIsMajorMaterial)
                {
                    _pPNormRMIsMajorMaterial = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPNormRMLossPct
        {
            get { return _pPNormRMLossPct; }
            set
            {
                if (value != this._pPNormRMLossPct)
                {
                    _pPNormRMLossPct = value;
                }
            }
        }
        public String PPNormRMPictureLink
        {
            get { return _pPNormRMPictureLink; }
            set
            {
                if (value != this._pPNormRMPictureLink)
                {
                    _pPNormRMPictureLink = value;
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
        public int FK_ICStockUOMID
        {
            get { return _fK_ICStockUOMID; }
            set
            {
                if (value != this._fK_ICStockUOMID)
                {
                    _fK_ICStockUOMID = value;
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
        public int FK_ICStkUOMID
        {
            get { return _fK_ICStkUOMID; }
            set
            {
                if (value != this._fK_ICStkUOMID)
                {
                    _fK_ICStkUOMID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPNormRMStkQty
        {
            get { return _pPNormRMStkQty; }
            set
            {
                if (value != this._pPNormRMStkQty)
                {
                    _pPNormRMStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPNormRMRQty
        {
            get { return _pPNormRMRQty; }
            set
            {
                if (value != this._pPNormRMRQty)
                {
                    _pPNormRMRQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPNormRMRStkQty
        {
            get { return _pPNormRMRStkQty; }
            set
            {
                if (value != this._pPNormRMRStkQty)
                {
                    _pPNormRMRStkQty = value;
                }
            }
        }
        public int FK_ICWeightUOMID
        {
            get { return _fK_ICWeightUOMID; }
            set
            {
                if (value != this._fK_ICWeightUOMID)
                {
                    _fK_ICWeightUOMID = value;
                }
            }
        }
        public int FK_ICVolumeUOMID
        {
            get { return _fK_ICVolumeUOMID; }
            set
            {
                if (value != this._fK_ICVolumeUOMID)
                {
                    _fK_ICVolumeUOMID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPNormRMWTot
        {
            get { return _pPNormRMWTot; }
            set
            {
                if (value != this._pPNormRMWTot)
                {
                    _pPNormRMWTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPNormRMVTot
        {
            get { return _pPNormRMVTot; }
            set
            {
                if (value != this._pPNormRMVTot)
                {
                    _pPNormRMVTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPNormRMFact
        {
            get { return _pPNormRMFact; }
            set
            {
                if (value != this._pPNormRMFact)
                {
                    _pPNormRMFact = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPNormRMAllocatePct
        {
            get { return _pPNormRMAllocatePct; }
            set
            {
                if (value != this._pPNormRMAllocatePct)
                {
                    _pPNormRMAllocatePct = value;
                }
            }
        }
        public int FK_GEAnalysisID
        {
            get { return _fK_GEAnalysisID; }
            set
            {
                if (value != this._fK_GEAnalysisID)
                {
                    _fK_GEAnalysisID = value;
                }
            }
        }
        public int FK_ADOFID
        {
            get { return _fK_ADOFID; }
            set
            {
                if (value != this._fK_ADOFID)
                {
                    _fK_ADOFID = value;
                }
            }
        }
        public int FK_ADOFItemID
        {
            get { return _fK_ADOFItemID; }
            set
            {
                if (value != this._fK_ADOFItemID)
                {
                    _fK_ADOFItemID = value;
                }
            }
        }
        public String PPNormRMRevision
        {
            get { return _pPNormRMRevision; }
            set
            {
                if (value != this._pPNormRMRevision)
                {
                    _pPNormRMRevision = value;
                }
            }
        }
        public bool PPNormRMIsMainProductionCheck
        {
            get { return _pPNormRMIsMainProductionCheck; }
            set
            {
                if (value != this._pPNormRMIsMainProductionCheck)
                {
                    _pPNormRMIsMainProductionCheck = value;
                }
            }
        }
        public bool PPNormRMIsSemiFinishedProduct
        {
            get { return _pPNormRMIsSemiFinishedProduct; }
            set
            {
                if (value != this._pPNormRMIsSemiFinishedProduct)
                {
                    _pPNormRMIsSemiFinishedProduct = value;
                }
            }
        }
        public bool PPNormRMIsOutSource
        {
            get { return _pPNormRMIsOutSource; }
            set
            {
                if (value != this._pPNormRMIsOutSource)
                {
                    _pPNormRMIsOutSource = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPNormRMSetupQty
        {
            get { return _pPNormRMSetupQty; }
            set
            {
                if (value != this._pPNormRMSetupQty)
                {
                    _pPNormRMSetupQty = value;
                }
            }
        }
        public bool PPNormRMOSSupplyCheck
        {
            get { return _pPNormRMOSSupplyCheck; }
            set
            {
                if (value != this._pPNormRMOSSupplyCheck)
                {
                    _pPNormRMOSSupplyCheck = value;
                }
            }
        }
        public int FK_PPLossCfgID
        {
            get { return _fK_PPLossCfgID; }
            set
            {
                if (value != this._fK_PPLossCfgID)
                {
                    _fK_PPLossCfgID = value;
                }
            }
        }
        public String PPNormRMPOF01Combo
        {
            get { return _pPNormRMPOF01Combo; }
            set
            {
                if (value != this._pPNormRMPOF01Combo)
                {
                    _pPNormRMPOF01Combo = value;
                }
            }
        }
        public String PPNormRMPOF02Combo
        {
            get { return _pPNormRMPOF02Combo; }
            set
            {
                if (value != this._pPNormRMPOF02Combo)
                {
                    _pPNormRMPOF02Combo = value;
                }
            }
        }
        public String PPNormRMPOF03Combo
        {
            get { return _pPNormRMPOF03Combo; }
            set
            {
                if (value != this._pPNormRMPOF03Combo)
                {
                    _pPNormRMPOF03Combo = value;
                }
            }
        }
        public String PPNormRMPOF04Combo
        {
            get { return _pPNormRMPOF04Combo; }
            set
            {
                if (value != this._pPNormRMPOF04Combo)
                {
                    _pPNormRMPOF04Combo = value;
                }
            }
        }
        public String PPNormRMPOF05Combo
        {
            get { return _pPNormRMPOF05Combo; }
            set
            {
                if (value != this._pPNormRMPOF05Combo)
                {
                    _pPNormRMPOF05Combo = value;
                }
            }
        }
        public String PPNormRMFGPOF01Combo
        {
            get { return _pPNormRMFGPOF01Combo; }
            set
            {
                if (value != this._pPNormRMFGPOF01Combo)
                {
                    _pPNormRMFGPOF01Combo = value;
                }
            }
        }
        public String PPNormRMFGPOF02Combo
        {
            get { return _pPNormRMFGPOF02Combo; }
            set
            {
                if (value != this._pPNormRMFGPOF02Combo)
                {
                    _pPNormRMFGPOF02Combo = value;
                }
            }
        }
        public String PPNormRMApplyTypeCombo
        {
            get { return _pPNormRMApplyTypeCombo; }
            set
            {
                if (value != this._pPNormRMApplyTypeCombo)
                {
                    _pPNormRMApplyTypeCombo = value;
                }
            }
        }
        public int FK_PPNormRMID
        {
            get { return _fK_PPNormRMID; }
            set
            {
                if (value != this._fK_PPNormRMID)
                {
                    _fK_PPNormRMID = value;
                }
            }
        }
        public int FK_PPGeneralNormItemID
        {
            get { return _fK_PPGeneralNormItemID; }
            set
            {
                if (value != this._fK_PPGeneralNormItemID)
                {
                    _fK_PPGeneralNormItemID = value;
                }
            }
        }

        #endregion
    }
}