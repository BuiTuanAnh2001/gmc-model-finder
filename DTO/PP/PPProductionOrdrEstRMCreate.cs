using System;
namespace gmc_api.DTO.PP
{
    public class PPProductionOrdrEstRMCreate
    {
        #region Variables
        protected int _pPProductionOrdrEstRMID;
        protected int _fK_ICProductID;
        protected int _fK_ICProductTypeID;
        protected String _pPProductionOrdrEstRMSerialNo = String.Empty;
        protected bool _pPProductionOrdrEstRMIsStkItm = true;
        protected String _pPProductionOrdrEstRMType = String.Empty;
        protected String _pPProductionOrdrEstRMDesc = String.Empty;
        protected decimal _pPProductionOrdrEstRMFact;
        protected decimal _pPProductionOrdrEstRMUnitPrice;
        protected decimal _pPProductionOrdrEstRMUnitCost;
        protected decimal _pPProductionOrdrEstRMQty;
        protected decimal _pPProductionOrdrEstRMStkQty;
        protected decimal _pPProductionOrdrEstRMRQty;
        protected decimal _pPProductionOrdrEstRMPrice;
        protected decimal _pPProductionOrdrEstRMAmtTot;
        protected decimal _pPProductionOrdrEstRMCostTot;
        protected decimal _pPProductionOrdrEstRMAmt;
        protected decimal _pPProductionOrdrEstRMCAmt;
        protected int _fK_ICFGProductID;
        protected int _fK_PPPhaseCfgID;
        protected int _fK_PPProductionOrdrID;
        protected int _fK_PPWOID;
        protected String _aAStatus = "Alive";
        protected bool _aASelected = true;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected decimal _pPProductionOrdrEstRMRStkQty;
        protected int _fK_ICWeightUOMID;
        protected int _fK_ICVolumeUOMID;
        protected decimal _pPProductionOrdrEstRMWTot;
        protected decimal _pPProductionOrdrEstRMVTot;
        protected decimal _pPProductionOrdrEstRMCQty;
        protected String _pPProductionOrdrEstRMLotNo = String.Empty;
        protected String _pPProductionOrdrEstRMFGLotNo = String.Empty;
        protected String _pPProductionOrdrEstRMUOM = String.Empty;
        protected String _pPProductionOrdrEstRMStkUOM = String.Empty;
        protected int _fK_ARShpPlanItemID;
        protected int _fK_ARSOID;
        protected int _fK_ARSOItemID;
        protected int _fK_PPRoutingID;
        protected int _fK_PPWorkCenterID;
        protected int _fK_PPWORID;
        protected decimal _pPProductionOrdrEstRMROQty;
        protected int _fK_ICProductParentID;
        protected decimal _pPProductionOrdrEstRMBOMQty;
        protected decimal _pPProductionOrdrEstRMParentQty;
        protected decimal _pPProductionOrdrEstRMInvQty;
        protected decimal _pPProductionOrdrEstRMPOQty;
        protected decimal _pPProductionOrdrEstRMActAllocateQty;
        protected decimal _pPProductionOrdrEstRMBalanceQty;
        protected decimal _pPProductionOrdrEstRMAllocateQty;
        protected int _fK_ICStockID;
        protected decimal _pPProductionOrdrEstRMScanQty;
        protected decimal _pPProductionOrdrEstRMReturnQty;
        protected decimal _pPProductionOrdrEstRMWOQty;
        protected int _fK_PPResourceID;
        protected decimal _pPProductionOrdrEstRMFGQty;
        protected decimal _pPProductionOrdrEstRMScanStkQty;
        protected String _pPProductionOrdrEstRMBarCodeNo = String.Empty;
        protected byte[] _pPProductionOrdrEstRMBarCode;
        protected decimal _pPProductionOrdrEstRMReturnStkQty;

        #endregion

        #region Public properties
        public int PPProductionOrdrEstRMID
        {
            get { return _pPProductionOrdrEstRMID; }
            set
            {
                if (value != this._pPProductionOrdrEstRMID)
                {
                    _pPProductionOrdrEstRMID = value;
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
        public int FK_ICProductTypeID
        {
            get { return _fK_ICProductTypeID; }
            set
            {
                if (value != this._fK_ICProductTypeID)
                {
                    _fK_ICProductTypeID = value;
                }
            }
        }
        public String PPProductionOrdrEstRMSerialNo
        {
            get { return _pPProductionOrdrEstRMSerialNo; }
            set
            {
                if (value != this._pPProductionOrdrEstRMSerialNo)
                {
                    _pPProductionOrdrEstRMSerialNo = value;
                }
            }
        }
        public bool PPProductionOrdrEstRMIsStkItm
        {
            get { return _pPProductionOrdrEstRMIsStkItm; }
            set
            {
                if (value != this._pPProductionOrdrEstRMIsStkItm)
                {
                    _pPProductionOrdrEstRMIsStkItm = value;
                }
            }
        }
        public String PPProductionOrdrEstRMType
        {
            get { return _pPProductionOrdrEstRMType; }
            set
            {
                if (value != this._pPProductionOrdrEstRMType)
                {
                    _pPProductionOrdrEstRMType = value;
                }
            }
        }
        public String PPProductionOrdrEstRMDesc
        {
            get { return _pPProductionOrdrEstRMDesc; }
            set
            {
                if (value != this._pPProductionOrdrEstRMDesc)
                {
                    _pPProductionOrdrEstRMDesc = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMFact
        {
            get { return _pPProductionOrdrEstRMFact; }
            set
            {
                if (value != this._pPProductionOrdrEstRMFact)
                {
                    _pPProductionOrdrEstRMFact = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMUnitPrice
        {
            get { return _pPProductionOrdrEstRMUnitPrice; }
            set
            {
                if (value != this._pPProductionOrdrEstRMUnitPrice)
                {
                    _pPProductionOrdrEstRMUnitPrice = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMUnitCost
        {
            get { return _pPProductionOrdrEstRMUnitCost; }
            set
            {
                if (value != this._pPProductionOrdrEstRMUnitCost)
                {
                    _pPProductionOrdrEstRMUnitCost = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMQty
        {
            get { return _pPProductionOrdrEstRMQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMQty)
                {
                    _pPProductionOrdrEstRMQty = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMStkQty
        {
            get { return _pPProductionOrdrEstRMStkQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMStkQty)
                {
                    _pPProductionOrdrEstRMStkQty = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMRQty
        {
            get { return _pPProductionOrdrEstRMRQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMRQty)
                {
                    _pPProductionOrdrEstRMRQty = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMPrice
        {
            get { return _pPProductionOrdrEstRMPrice; }
            set
            {
                if (value != this._pPProductionOrdrEstRMPrice)
                {
                    _pPProductionOrdrEstRMPrice = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMAmtTot
        {
            get { return _pPProductionOrdrEstRMAmtTot; }
            set
            {
                if (value != this._pPProductionOrdrEstRMAmtTot)
                {
                    _pPProductionOrdrEstRMAmtTot = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMCostTot
        {
            get { return _pPProductionOrdrEstRMCostTot; }
            set
            {
                if (value != this._pPProductionOrdrEstRMCostTot)
                {
                    _pPProductionOrdrEstRMCostTot = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMAmt
        {
            get { return _pPProductionOrdrEstRMAmt; }
            set
            {
                if (value != this._pPProductionOrdrEstRMAmt)
                {
                    _pPProductionOrdrEstRMAmt = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMCAmt
        {
            get { return _pPProductionOrdrEstRMCAmt; }
            set
            {
                if (value != this._pPProductionOrdrEstRMCAmt)
                {
                    _pPProductionOrdrEstRMCAmt = value;
                }
            }
        }
        public int FK_ICFGProductID
        {
            get { return _fK_ICFGProductID; }
            set
            {
                if (value != this._fK_ICFGProductID)
                {
                    _fK_ICFGProductID = value;
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
        public int FK_PPProductionOrdrID
        {
            get { return _fK_PPProductionOrdrID; }
            set
            {
                if (value != this._fK_PPProductionOrdrID)
                {
                    _fK_PPProductionOrdrID = value;
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
        public decimal PPProductionOrdrEstRMRStkQty
        {
            get { return _pPProductionOrdrEstRMRStkQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMRStkQty)
                {
                    _pPProductionOrdrEstRMRStkQty = value;
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
        public decimal PPProductionOrdrEstRMWTot
        {
            get { return _pPProductionOrdrEstRMWTot; }
            set
            {
                if (value != this._pPProductionOrdrEstRMWTot)
                {
                    _pPProductionOrdrEstRMWTot = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMVTot
        {
            get { return _pPProductionOrdrEstRMVTot; }
            set
            {
                if (value != this._pPProductionOrdrEstRMVTot)
                {
                    _pPProductionOrdrEstRMVTot = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMCQty
        {
            get { return _pPProductionOrdrEstRMCQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMCQty)
                {
                    _pPProductionOrdrEstRMCQty = value;
                }
            }
        }
        public String PPProductionOrdrEstRMLotNo
        {
            get { return _pPProductionOrdrEstRMLotNo; }
            set
            {
                if (value != this._pPProductionOrdrEstRMLotNo)
                {
                    _pPProductionOrdrEstRMLotNo = value;
                }
            }
        }
        public String PPProductionOrdrEstRMFGLotNo
        {
            get { return _pPProductionOrdrEstRMFGLotNo; }
            set
            {
                if (value != this._pPProductionOrdrEstRMFGLotNo)
                {
                    _pPProductionOrdrEstRMFGLotNo = value;
                }
            }
        }
        public String PPProductionOrdrEstRMUOM
        {
            get { return _pPProductionOrdrEstRMUOM; }
            set
            {
                if (value != this._pPProductionOrdrEstRMUOM)
                {
                    _pPProductionOrdrEstRMUOM = value;
                }
            }
        }
        public String PPProductionOrdrEstRMStkUOM
        {
            get { return _pPProductionOrdrEstRMStkUOM; }
            set
            {
                if (value != this._pPProductionOrdrEstRMStkUOM)
                {
                    _pPProductionOrdrEstRMStkUOM = value;
                }
            }
        }
        public int FK_ARShpPlanItemID
        {
            get { return _fK_ARShpPlanItemID; }
            set
            {
                if (value != this._fK_ARShpPlanItemID)
                {
                    _fK_ARShpPlanItemID = value;
                }
            }
        }
        public int FK_ARSOID
        {
            get { return _fK_ARSOID; }
            set
            {
                if (value != this._fK_ARSOID)
                {
                    _fK_ARSOID = value;
                }
            }
        }
        public int FK_ARSOItemID
        {
            get { return _fK_ARSOItemID; }
            set
            {
                if (value != this._fK_ARSOItemID)
                {
                    _fK_ARSOItemID = value;
                }
            }
        }
        public int FK_PPRoutingID
        {
            get { return _fK_PPRoutingID; }
            set
            {
                if (value != this._fK_PPRoutingID)
                {
                    _fK_PPRoutingID = value;
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
        public int FK_PPWORID
        {
            get { return _fK_PPWORID; }
            set
            {
                if (value != this._fK_PPWORID)
                {
                    _fK_PPWORID = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMROQty
        {
            get { return _pPProductionOrdrEstRMROQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMROQty)
                {
                    _pPProductionOrdrEstRMROQty = value;
                }
            }
        }
        public int FK_ICProductParentID
        {
            get { return _fK_ICProductParentID; }
            set
            {
                if (value != this._fK_ICProductParentID)
                {
                    _fK_ICProductParentID = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMBOMQty
        {
            get { return _pPProductionOrdrEstRMBOMQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMBOMQty)
                {
                    _pPProductionOrdrEstRMBOMQty = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMParentQty
        {
            get { return _pPProductionOrdrEstRMParentQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMParentQty)
                {
                    _pPProductionOrdrEstRMParentQty = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMInvQty
        {
            get { return _pPProductionOrdrEstRMInvQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMInvQty)
                {
                    _pPProductionOrdrEstRMInvQty = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMPOQty
        {
            get { return _pPProductionOrdrEstRMPOQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMPOQty)
                {
                    _pPProductionOrdrEstRMPOQty = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMActAllocateQty
        {
            get { return _pPProductionOrdrEstRMActAllocateQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMActAllocateQty)
                {
                    _pPProductionOrdrEstRMActAllocateQty = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMBalanceQty
        {
            get { return _pPProductionOrdrEstRMBalanceQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMBalanceQty)
                {
                    _pPProductionOrdrEstRMBalanceQty = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMAllocateQty
        {
            get { return _pPProductionOrdrEstRMAllocateQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMAllocateQty)
                {
                    _pPProductionOrdrEstRMAllocateQty = value;
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
        public decimal PPProductionOrdrEstRMScanQty
        {
            get { return _pPProductionOrdrEstRMScanQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMScanQty)
                {
                    _pPProductionOrdrEstRMScanQty = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMReturnQty
        {
            get { return _pPProductionOrdrEstRMReturnQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMReturnQty)
                {
                    _pPProductionOrdrEstRMReturnQty = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMWOQty
        {
            get { return _pPProductionOrdrEstRMWOQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMWOQty)
                {
                    _pPProductionOrdrEstRMWOQty = value;
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
        public decimal PPProductionOrdrEstRMFGQty
        {
            get { return _pPProductionOrdrEstRMFGQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMFGQty)
                {
                    _pPProductionOrdrEstRMFGQty = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMScanStkQty
        {
            get { return _pPProductionOrdrEstRMScanStkQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMScanStkQty)
                {
                    _pPProductionOrdrEstRMScanStkQty = value;
                }
            }
        }
        public String PPProductionOrdrEstRMBarCodeNo
        {
            get { return _pPProductionOrdrEstRMBarCodeNo; }
            set
            {
                if (value != this._pPProductionOrdrEstRMBarCodeNo)
                {
                    _pPProductionOrdrEstRMBarCodeNo = value;
                }
            }
        }
        public byte[] PPProductionOrdrEstRMBarCode
        {
            get { return _pPProductionOrdrEstRMBarCode; }
            set
            {
                if (value != this._pPProductionOrdrEstRMBarCode)
                {
                    _pPProductionOrdrEstRMBarCode = value;
                }
            }
        }
        public decimal PPProductionOrdrEstRMReturnStkQty
        {
            get { return _pPProductionOrdrEstRMReturnStkQty; }
            set
            {
                if (value != this._pPProductionOrdrEstRMReturnStkQty)
                {
                    _pPProductionOrdrEstRMReturnStkQty = value;
                }
            }
        }

        #endregion
    }
}
