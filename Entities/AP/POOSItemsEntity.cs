using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("APPOItems")]
    public partial class POOSItemsEntity:BaseInfo
    {
        #region Variables
        protected int _aPPOItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _aPPOItemStatus = DefaultStatus;
        protected int _fK_APPOID;
        protected int _fK_ICProductID;
        protected int _fK_ICProductTypeID;
        protected int _fK_ICStockID;
        protected int _fK_ICStockSlotID;
        protected int _fK_ARPriceListID;
        protected int _fK_TXTaxCodeID;
        protected String _aPPOItemSerialNo = String.Empty;
        protected bool _aPPOItemIsStkItm = true;
        protected String _aPPOItemType = String.Empty;
        protected int _aPPOItemSrtOrder;
        protected String _aPPOItemDesc = String.Empty;
        protected String _aPPOItemSellUnit = String.Empty;
        protected String _aPPOItemBasicUnit = String.Empty;
        protected String _aPPOItemPackUnit = String.Empty;
        protected decimal _aPPOItemSellFact;
        protected decimal _aPPOItemPackFact;
        protected decimal _aPPOItemUnitPrice;
        protected decimal _aPPOItemUnitCost;
        protected decimal _aPPOItemGrpDisc;
        protected decimal _aPPOItemDisc;
        protected decimal _aPPOItemTxPct;
        protected decimal _aPPOItemQtyOld;
        protected decimal _aPPOItemRQty;
        protected decimal _aPPOItemQty;
        protected decimal _aPPOItemBasicQty;
        protected decimal _aPPOItemPckQty;
        protected decimal _aPPOItemQty1;
        protected decimal _aPPOItemQty2;
        protected decimal _aPPOItemQty3;
        protected decimal _aPPOItemQty4;
        protected decimal _aPPOItemQty5;
        protected decimal _aPPOItemQty6;
        protected decimal _aPPOItemPrice;
        protected String _aPPOItemComment = String.Empty;
        protected decimal _aPPOItemUnitVolumn;
        protected decimal _aPPOItemUnitWeight;
        protected decimal _aPPOItemTxAmt;
        protected decimal _aPPOItemDiscAmt;
        protected decimal _aPPOItemDiscPct;
        protected decimal _aPPOItemNetAmt;
        protected decimal _aPPOItemAmtTot;
        protected decimal _aPPOItemCostTot;
        protected decimal _aPPOItemFUnitPrice;
        protected decimal _aPPOItemFPrice;
        protected decimal _aPPOItemFTxAmt;
        protected decimal _aPPOItemFNetAmt;
        protected decimal _aPPOItemFAmtTot;
        protected decimal _aPPOItemFImpTxAmt;
        protected decimal _aPPOItemFDiscAmt;
        protected Nullable<DateTime> _aPPOItemArrivalDate;
        protected decimal _aPPOItemRcpPct;
        protected int _fK_PPProductPlnItemID;
        protected int _fK_PPProductPlnRMItemID;
        protected int _fK_APOrdrPlnItemPOBatchID;
        protected int _fK_APOrdrPlnItemPPBatchID;
        protected int _fK_APSemiOrdPlanID;
        protected int _fK_APSemiDetailOrdPlanID;
        protected Nullable<DateTime> _aPPOItemLastDate;
        protected int _fK_APSupplierID;
        protected decimal _aPPOItemCQty;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected decimal _aPPOItemStkQty;
        protected decimal _aPPOItemRStkQty;
        protected int _fK_ICWeightUOMID;
        protected int _fK_ICVolumeUOMID;
        protected decimal _aPPOItemWTot;
        protected decimal _aPPOItemVTot;
        protected int _fK_PPProductPlnID;
        protected int _fK_ARSOID;
        protected decimal _aPPOItemFact;
        protected decimal _aPPOItemOrgQty;
        protected decimal _aPPOItemExcQty;
        protected int _fK_ICOrgUOMID;
        protected int _fK_GEAnalysisID;
        protected String _aPPOItemOrigin = String.Empty;
        protected String _aPPOItemProductNo = String.Empty;
        protected String _aPPOItemProductName = String.Empty;
        protected int _fK_APPriceListID;
        protected int _aPPOItemPriceListCnt;
        protected decimal _aPPOItemReturnQty;
        protected decimal _aPPOItemDocRQty;
        protected int _fK_APPriceListDetailID;
        protected int _fK_APPOItemID;
        protected int _fK_FAAssetConstructionID;
        protected int _fK_FAAssetID;
        protected String _gLTOF01Combo = String.Empty;
        protected String _gLTOF02Combo = String.Empty;
        protected String _gLTOF03Combo = String.Empty;
        protected String _gLTOF04Combo = String.Empty;
        protected String _gLTOF05Combo = String.Empty;
        protected String _gLTOF06Combo = String.Empty;
        protected String _gLTOF07Combo = String.Empty;
        protected String _gLTOF08Combo = String.Empty;
        protected String _gLTOF09Combo = String.Empty;
        protected String _gLTOF10Combo = String.Empty;
        protected String _gLTOF11Combo = String.Empty;
        protected String _gLTOF12Combo = String.Empty;
        protected String _gLTOF13Combo = String.Empty;
        protected String _gLTOF14Combo = String.Empty;
        protected String _gLTOF15Combo = String.Empty;
        protected decimal _aPPOItemPurchaseCostFAmt;
        protected decimal _aPPOItemPurchaseCostAmt;
        protected decimal _aPPOItemPurchaseCostUnitPrice;
        protected decimal _aPPOItemPurchaseCostFUnitPrice;
        protected Nullable<DateTime> _aPPOItemSerialDate;
        protected decimal _aPPOItemVirtualUnitPrice;
        protected decimal _aPPOItemAdjStkQty;
        protected int _fK_GLBudgetCfgID;
        protected int _fK_GLBudgetAllocateAdjID;
        protected int _fK_GLBudgetAllocateAdjDetailID;
        protected decimal _aPPOItemInvQty;
        protected decimal _aPPOItemUsedTime;
        protected int _fK_ARSOItemID;
        protected int _fK_PPWOID;
        protected int _fK_PPPhaseCfgID;
        protected int _fK_ICFGProductID;
        protected int _fK_APPRID;
        protected int _fK_APApprovedPriceID;
        protected int _fK_TXDiffTaxCodeID;
        protected decimal _aPPOItemTxDiffPct;
        protected decimal _aPPOItemTxDiffFAmt;
        protected decimal _aPPOItemTxDiffAmt;
        protected decimal _aPPOItemTxDiffFAmtTot;
        protected decimal _aPPOItemTxDiffAmtTot;
        protected decimal _aPPOItemImpTxPct;
        protected decimal _aPPOItemCalcImpTaxFAmt;
        protected decimal _aPPOItemCalcImpTaxAmt;
        protected decimal _aPPOItemFImpTxAmtTot;
        protected decimal _aPPOItemImpTxAmtTot;
        protected decimal _aPPOItemFTxAmtTot;
        protected decimal _aPPOItemTxAmtTot;
        protected decimal _aPPOItemImpTxAmt;
        protected decimal _aPPOItemFImportCostAmt;
        protected decimal _aPPOItemImportCostAmt;
        protected int _fK_TXImpTaxCodeID;
        protected decimal _aPPOItemRcpRQty;
        protected int _fK_PPWOMRPID;
        protected int _fK_PPWOMRPItemID;
        protected int _fK_PPWOEstFGItemID;
        protected String _aPPOItemFGLotNo = String.Empty;
        protected String _aPPOItemDesc1 = String.Empty;
        protected String _aPPOItemLotNo = String.Empty;
        protected Nullable<DateTime> _aPPOItemExpireDate;
        protected String _aPPOItemPOF01Combo = String.Empty;
        protected String _aPPOItemPOF02Combo = String.Empty;
        protected String _aPPOItemPOF03Combo = String.Empty;
        protected String _aPPOItemPOF04Combo = String.Empty;
        protected String _aPPOItemPOF05Combo = String.Empty;
        protected decimal _aPPOItemOrgFUnitPrice;
        protected decimal _aPPOItemOrgUnitPrice;
        protected int _fK_PPMaterialPlanID;
        protected int _fK_PPPlanProductionRMID;

        #endregion

        #region Public properties
        public int APPOItemID
        {
            get { return _aPPOItemID; }
            set
            {
                if (value != this._aPPOItemID)
                {
                    _aPPOItemID = value;
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
        public String APPOItemStatus
        {
            get { return _aPPOItemStatus; }
            set
            {
                if (value != this._aPPOItemStatus)
                {
                    _aPPOItemStatus = value;
                }
            }
        }
        public int FK_APPOID
        {
            get { return _fK_APPOID; }
            set
            {
                if (value != this._fK_APPOID)
                {
                    _fK_APPOID = value;
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
        public int FK_ICStockSlotID
        {
            get { return _fK_ICStockSlotID; }
            set
            {
                if (value != this._fK_ICStockSlotID)
                {
                    _fK_ICStockSlotID = value;
                }
            }
        }
        public int FK_ARPriceListID
        {
            get { return _fK_ARPriceListID; }
            set
            {
                if (value != this._fK_ARPriceListID)
                {
                    _fK_ARPriceListID = value;
                }
            }
        }
        public int FK_TXTaxCodeID
        {
            get { return _fK_TXTaxCodeID; }
            set
            {
                if (value != this._fK_TXTaxCodeID)
                {
                    _fK_TXTaxCodeID = value;
                }
            }
        }
        public String APPOItemSerialNo
        {
            get { return _aPPOItemSerialNo; }
            set
            {
                if (value != this._aPPOItemSerialNo)
                {
                    _aPPOItemSerialNo = value;
                }
            }
        }
        public bool APPOItemIsStkItm
        {
            get { return _aPPOItemIsStkItm; }
            set
            {
                if (value != this._aPPOItemIsStkItm)
                {
                    _aPPOItemIsStkItm = value;
                }
            }
        }
        public String APPOItemType
        {
            get { return _aPPOItemType; }
            set
            {
                if (value != this._aPPOItemType)
                {
                    _aPPOItemType = value;
                }
            }
        }
        public int APPOItemSrtOrder
        {
            get { return _aPPOItemSrtOrder; }
            set
            {
                if (value != this._aPPOItemSrtOrder)
                {
                    _aPPOItemSrtOrder = value;
                }
            }
        }
        public String APPOItemDesc
        {
            get { return _aPPOItemDesc; }
            set
            {
                if (value != this._aPPOItemDesc)
                {
                    _aPPOItemDesc = value;
                }
            }
        }
        public String APPOItemSellUnit
        {
            get { return _aPPOItemSellUnit; }
            set
            {
                if (value != this._aPPOItemSellUnit)
                {
                    _aPPOItemSellUnit = value;
                }
            }
        }
        public String APPOItemBasicUnit
        {
            get { return _aPPOItemBasicUnit; }
            set
            {
                if (value != this._aPPOItemBasicUnit)
                {
                    _aPPOItemBasicUnit = value;
                }
            }
        }
        public String APPOItemPackUnit
        {
            get { return _aPPOItemPackUnit; }
            set
            {
                if (value != this._aPPOItemPackUnit)
                {
                    _aPPOItemPackUnit = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemSellFact
        {
            get { return _aPPOItemSellFact; }
            set
            {
                if (value != this._aPPOItemSellFact)
                {
                    _aPPOItemSellFact = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemPackFact
        {
            get { return _aPPOItemPackFact; }
            set
            {
                if (value != this._aPPOItemPackFact)
                {
                    _aPPOItemPackFact = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemUnitPrice
        {
            get { return _aPPOItemUnitPrice; }
            set
            {
                if (value != this._aPPOItemUnitPrice)
                {
                    _aPPOItemUnitPrice = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemUnitCost
        {
            get { return _aPPOItemUnitCost; }
            set
            {
                if (value != this._aPPOItemUnitCost)
                {
                    _aPPOItemUnitCost = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemGrpDisc
        {
            get { return _aPPOItemGrpDisc; }
            set
            {
                if (value != this._aPPOItemGrpDisc)
                {
                    _aPPOItemGrpDisc = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemDisc
        {
            get { return _aPPOItemDisc; }
            set
            {
                if (value != this._aPPOItemDisc)
                {
                    _aPPOItemDisc = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemTxPct
        {
            get { return _aPPOItemTxPct; }
            set
            {
                if (value != this._aPPOItemTxPct)
                {
                    _aPPOItemTxPct = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemQtyOld
        {
            get { return _aPPOItemQtyOld; }
            set
            {
                if (value != this._aPPOItemQtyOld)
                {
                    _aPPOItemQtyOld = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemRQty
        {
            get { return _aPPOItemRQty; }
            set
            {
                if (value != this._aPPOItemRQty)
                {
                    _aPPOItemRQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemQty
        {
            get { return _aPPOItemQty; }
            set
            {
                if (value != this._aPPOItemQty)
                {
                    _aPPOItemQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemBasicQty
        {
            get { return _aPPOItemBasicQty; }
            set
            {
                if (value != this._aPPOItemBasicQty)
                {
                    _aPPOItemBasicQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemPckQty
        {
            get { return _aPPOItemPckQty; }
            set
            {
                if (value != this._aPPOItemPckQty)
                {
                    _aPPOItemPckQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemQty1
        {
            get { return _aPPOItemQty1; }
            set
            {
                if (value != this._aPPOItemQty1)
                {
                    _aPPOItemQty1 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemQty2
        {
            get { return _aPPOItemQty2; }
            set
            {
                if (value != this._aPPOItemQty2)
                {
                    _aPPOItemQty2 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemQty3
        {
            get { return _aPPOItemQty3; }
            set
            {
                if (value != this._aPPOItemQty3)
                {
                    _aPPOItemQty3 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemQty4
        {
            get { return _aPPOItemQty4; }
            set
            {
                if (value != this._aPPOItemQty4)
                {
                    _aPPOItemQty4 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemQty5
        {
            get { return _aPPOItemQty5; }
            set
            {
                if (value != this._aPPOItemQty5)
                {
                    _aPPOItemQty5 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemQty6
        {
            get { return _aPPOItemQty6; }
            set
            {
                if (value != this._aPPOItemQty6)
                {
                    _aPPOItemQty6 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemPrice
        {
            get { return _aPPOItemPrice; }
            set
            {
                if (value != this._aPPOItemPrice)
                {
                    _aPPOItemPrice = value;
                }
            }
        }
        public String APPOItemComment
        {
            get { return _aPPOItemComment; }
            set
            {
                if (value != this._aPPOItemComment)
                {
                    _aPPOItemComment = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemUnitVolumn
        {
            get { return _aPPOItemUnitVolumn; }
            set
            {
                if (value != this._aPPOItemUnitVolumn)
                {
                    _aPPOItemUnitVolumn = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemUnitWeight
        {
            get { return _aPPOItemUnitWeight; }
            set
            {
                if (value != this._aPPOItemUnitWeight)
                {
                    _aPPOItemUnitWeight = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemTxAmt
        {
            get { return _aPPOItemTxAmt; }
            set
            {
                if (value != this._aPPOItemTxAmt)
                {
                    _aPPOItemTxAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemDiscAmt
        {
            get { return _aPPOItemDiscAmt; }
            set
            {
                if (value != this._aPPOItemDiscAmt)
                {
                    _aPPOItemDiscAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemDiscPct
        {
            get { return _aPPOItemDiscPct; }
            set
            {
                if (value != this._aPPOItemDiscPct)
                {
                    _aPPOItemDiscPct = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemNetAmt
        {
            get { return _aPPOItemNetAmt; }
            set
            {
                if (value != this._aPPOItemNetAmt)
                {
                    _aPPOItemNetAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemAmtTot
        {
            get { return _aPPOItemAmtTot; }
            set
            {
                if (value != this._aPPOItemAmtTot)
                {
                    _aPPOItemAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemCostTot
        {
            get { return _aPPOItemCostTot; }
            set
            {
                if (value != this._aPPOItemCostTot)
                {
                    _aPPOItemCostTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemFUnitPrice
        {
            get { return _aPPOItemFUnitPrice; }
            set
            {
                if (value != this._aPPOItemFUnitPrice)
                {
                    _aPPOItemFUnitPrice = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemFPrice
        {
            get { return _aPPOItemFPrice; }
            set
            {
                if (value != this._aPPOItemFPrice)
                {
                    _aPPOItemFPrice = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemFTxAmt
        {
            get { return _aPPOItemFTxAmt; }
            set
            {
                if (value != this._aPPOItemFTxAmt)
                {
                    _aPPOItemFTxAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemFNetAmt
        {
            get { return _aPPOItemFNetAmt; }
            set
            {
                if (value != this._aPPOItemFNetAmt)
                {
                    _aPPOItemFNetAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemFAmtTot
        {
            get { return _aPPOItemFAmtTot; }
            set
            {
                if (value != this._aPPOItemFAmtTot)
                {
                    _aPPOItemFAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemFImpTxAmt
        {
            get { return _aPPOItemFImpTxAmt; }
            set
            {
                if (value != this._aPPOItemFImpTxAmt)
                {
                    _aPPOItemFImpTxAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemFDiscAmt
        {
            get { return _aPPOItemFDiscAmt; }
            set
            {
                if (value != this._aPPOItemFDiscAmt)
                {
                    _aPPOItemFDiscAmt = value;
                }
            }
        }
        public Nullable<DateTime> APPOItemArrivalDate
        {
            get { return _aPPOItemArrivalDate; }
            set
            {
                if (value != this._aPPOItemArrivalDate)
                {
                    _aPPOItemArrivalDate = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemRcpPct
        {
            get { return _aPPOItemRcpPct; }
            set
            {
                if (value != this._aPPOItemRcpPct)
                {
                    _aPPOItemRcpPct = value;
                }
            }
        }
        public int FK_PPProductPlnItemID
        {
            get { return _fK_PPProductPlnItemID; }
            set
            {
                if (value != this._fK_PPProductPlnItemID)
                {
                    _fK_PPProductPlnItemID = value;
                }
            }
        }
        public int FK_PPProductPlnRMItemID
        {
            get { return _fK_PPProductPlnRMItemID; }
            set
            {
                if (value != this._fK_PPProductPlnRMItemID)
                {
                    _fK_PPProductPlnRMItemID = value;
                }
            }
        }
        public int FK_APOrdrPlnItemPOBatchID
        {
            get { return _fK_APOrdrPlnItemPOBatchID; }
            set
            {
                if (value != this._fK_APOrdrPlnItemPOBatchID)
                {
                    _fK_APOrdrPlnItemPOBatchID = value;
                }
            }
        }
        public int FK_APOrdrPlnItemPPBatchID
        {
            get { return _fK_APOrdrPlnItemPPBatchID; }
            set
            {
                if (value != this._fK_APOrdrPlnItemPPBatchID)
                {
                    _fK_APOrdrPlnItemPPBatchID = value;
                }
            }
        }
        public int FK_APSemiOrdPlanID
        {
            get { return _fK_APSemiOrdPlanID; }
            set
            {
                if (value != this._fK_APSemiOrdPlanID)
                {
                    _fK_APSemiOrdPlanID = value;
                }
            }
        }
        public int FK_APSemiDetailOrdPlanID
        {
            get { return _fK_APSemiDetailOrdPlanID; }
            set
            {
                if (value != this._fK_APSemiDetailOrdPlanID)
                {
                    _fK_APSemiDetailOrdPlanID = value;
                }
            }
        }
        public Nullable<DateTime> APPOItemLastDate
        {
            get { return _aPPOItemLastDate; }
            set
            {
                if (value != this._aPPOItemLastDate)
                {
                    _aPPOItemLastDate = value;
                }
            }
        }
        public int FK_APSupplierID
        {
            get { return _fK_APSupplierID; }
            set
            {
                if (value != this._fK_APSupplierID)
                {
                    _fK_APSupplierID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemCQty
        {
            get { return _aPPOItemCQty; }
            set
            {
                if (value != this._aPPOItemCQty)
                {
                    _aPPOItemCQty = value;
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
        public decimal APPOItemStkQty
        {
            get { return _aPPOItemStkQty; }
            set
            {
                if (value != this._aPPOItemStkQty)
                {
                    _aPPOItemStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemRStkQty
        {
            get { return _aPPOItemRStkQty; }
            set
            {
                if (value != this._aPPOItemRStkQty)
                {
                    _aPPOItemRStkQty = value;
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
        public decimal APPOItemWTot
        {
            get { return _aPPOItemWTot; }
            set
            {
                if (value != this._aPPOItemWTot)
                {
                    _aPPOItemWTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemVTot
        {
            get { return _aPPOItemVTot; }
            set
            {
                if (value != this._aPPOItemVTot)
                {
                    _aPPOItemVTot = value;
                }
            }
        }
        public int FK_PPProductPlnID
        {
            get { return _fK_PPProductPlnID; }
            set
            {
                if (value != this._fK_PPProductPlnID)
                {
                    _fK_PPProductPlnID = value;
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
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemFact
        {
            get { return _aPPOItemFact; }
            set
            {
                if (value != this._aPPOItemFact)
                {
                    _aPPOItemFact = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemOrgQty
        {
            get { return _aPPOItemOrgQty; }
            set
            {
                if (value != this._aPPOItemOrgQty)
                {
                    _aPPOItemOrgQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemExcQty
        {
            get { return _aPPOItemExcQty; }
            set
            {
                if (value != this._aPPOItemExcQty)
                {
                    _aPPOItemExcQty = value;
                }
            }
        }
        public int FK_ICOrgUOMID
        {
            get { return _fK_ICOrgUOMID; }
            set
            {
                if (value != this._fK_ICOrgUOMID)
                {
                    _fK_ICOrgUOMID = value;
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
        public String APPOItemOrigin
        {
            get { return _aPPOItemOrigin; }
            set
            {
                if (value != this._aPPOItemOrigin)
                {
                    _aPPOItemOrigin = value;
                }
            }
        }
        public String APPOItemProductNo
        {
            get { return _aPPOItemProductNo; }
            set
            {
                if (value != this._aPPOItemProductNo)
                {
                    _aPPOItemProductNo = value;
                }
            }
        }
        public String APPOItemProductName
        {
            get { return _aPPOItemProductName; }
            set
            {
                if (value != this._aPPOItemProductName)
                {
                    _aPPOItemProductName = value;
                }
            }
        }
        public int FK_APPriceListID
        {
            get { return _fK_APPriceListID; }
            set
            {
                if (value != this._fK_APPriceListID)
                {
                    _fK_APPriceListID = value;
                }
            }
        }
        public int APPOItemPriceListCnt
        {
            get { return _aPPOItemPriceListCnt; }
            set
            {
                if (value != this._aPPOItemPriceListCnt)
                {
                    _aPPOItemPriceListCnt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemReturnQty
        {
            get { return _aPPOItemReturnQty; }
            set
            {
                if (value != this._aPPOItemReturnQty)
                {
                    _aPPOItemReturnQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemDocRQty
        {
            get { return _aPPOItemDocRQty; }
            set
            {
                if (value != this._aPPOItemDocRQty)
                {
                    _aPPOItemDocRQty = value;
                }
            }
        }
        public int FK_APPriceListDetailID
        {
            get { return _fK_APPriceListDetailID; }
            set
            {
                if (value != this._fK_APPriceListDetailID)
                {
                    _fK_APPriceListDetailID = value;
                }
            }
        }
        public int FK_APPOItemID
        {
            get { return _fK_APPOItemID; }
            set
            {
                if (value != this._fK_APPOItemID)
                {
                    _fK_APPOItemID = value;
                }
            }
        }
        public int FK_FAAssetConstructionID
        {
            get { return _fK_FAAssetConstructionID; }
            set
            {
                if (value != this._fK_FAAssetConstructionID)
                {
                    _fK_FAAssetConstructionID = value;
                }
            }
        }
        public int FK_FAAssetID
        {
            get { return _fK_FAAssetID; }
            set
            {
                if (value != this._fK_FAAssetID)
                {
                    _fK_FAAssetID = value;
                }
            }
        }
        public String GLTOF01Combo
        {
            get { return _gLTOF01Combo; }
            set
            {
                if (value != this._gLTOF01Combo)
                {
                    _gLTOF01Combo = value;
                }
            }
        }
        public String GLTOF02Combo
        {
            get { return _gLTOF02Combo; }
            set
            {
                if (value != this._gLTOF02Combo)
                {
                    _gLTOF02Combo = value;
                }
            }
        }
        public String GLTOF03Combo
        {
            get { return _gLTOF03Combo; }
            set
            {
                if (value != this._gLTOF03Combo)
                {
                    _gLTOF03Combo = value;
                }
            }
        }
        public String GLTOF04Combo
        {
            get { return _gLTOF04Combo; }
            set
            {
                if (value != this._gLTOF04Combo)
                {
                    _gLTOF04Combo = value;
                }
            }
        }
        public String GLTOF05Combo
        {
            get { return _gLTOF05Combo; }
            set
            {
                if (value != this._gLTOF05Combo)
                {
                    _gLTOF05Combo = value;
                }
            }
        }
        public String GLTOF06Combo
        {
            get { return _gLTOF06Combo; }
            set
            {
                if (value != this._gLTOF06Combo)
                {
                    _gLTOF06Combo = value;
                }
            }
        }
        public String GLTOF07Combo
        {
            get { return _gLTOF07Combo; }
            set
            {
                if (value != this._gLTOF07Combo)
                {
                    _gLTOF07Combo = value;
                }
            }
        }
        public String GLTOF08Combo
        {
            get { return _gLTOF08Combo; }
            set
            {
                if (value != this._gLTOF08Combo)
                {
                    _gLTOF08Combo = value;
                }
            }
        }
        public String GLTOF09Combo
        {
            get { return _gLTOF09Combo; }
            set
            {
                if (value != this._gLTOF09Combo)
                {
                    _gLTOF09Combo = value;
                }
            }
        }
        public String GLTOF10Combo
        {
            get { return _gLTOF10Combo; }
            set
            {
                if (value != this._gLTOF10Combo)
                {
                    _gLTOF10Combo = value;
                }
            }
        }
        public String GLTOF11Combo
        {
            get { return _gLTOF11Combo; }
            set
            {
                if (value != this._gLTOF11Combo)
                {
                    _gLTOF11Combo = value;
                }
            }
        }
        public String GLTOF12Combo
        {
            get { return _gLTOF12Combo; }
            set
            {
                if (value != this._gLTOF12Combo)
                {
                    _gLTOF12Combo = value;
                }
            }
        }
        public String GLTOF13Combo
        {
            get { return _gLTOF13Combo; }
            set
            {
                if (value != this._gLTOF13Combo)
                {
                    _gLTOF13Combo = value;
                }
            }
        }
        public String GLTOF14Combo
        {
            get { return _gLTOF14Combo; }
            set
            {
                if (value != this._gLTOF14Combo)
                {
                    _gLTOF14Combo = value;
                }
            }
        }
        public String GLTOF15Combo
        {
            get { return _gLTOF15Combo; }
            set
            {
                if (value != this._gLTOF15Combo)
                {
                    _gLTOF15Combo = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemPurchaseCostFAmt
        {
            get { return _aPPOItemPurchaseCostFAmt; }
            set
            {
                if (value != this._aPPOItemPurchaseCostFAmt)
                {
                    _aPPOItemPurchaseCostFAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemPurchaseCostAmt
        {
            get { return _aPPOItemPurchaseCostAmt; }
            set
            {
                if (value != this._aPPOItemPurchaseCostAmt)
                {
                    _aPPOItemPurchaseCostAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemPurchaseCostUnitPrice
        {
            get { return _aPPOItemPurchaseCostUnitPrice; }
            set
            {
                if (value != this._aPPOItemPurchaseCostUnitPrice)
                {
                    _aPPOItemPurchaseCostUnitPrice = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemPurchaseCostFUnitPrice
        {
            get { return _aPPOItemPurchaseCostFUnitPrice; }
            set
            {
                if (value != this._aPPOItemPurchaseCostFUnitPrice)
                {
                    _aPPOItemPurchaseCostFUnitPrice = value;
                }
            }
        }
        public Nullable<DateTime> APPOItemSerialDate
        {
            get { return _aPPOItemSerialDate; }
            set
            {
                if (value != this._aPPOItemSerialDate)
                {
                    _aPPOItemSerialDate = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemVirtualUnitPrice
        {
            get { return _aPPOItemVirtualUnitPrice; }
            set
            {
                if (value != this._aPPOItemVirtualUnitPrice)
                {
                    _aPPOItemVirtualUnitPrice = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemAdjStkQty
        {
            get { return _aPPOItemAdjStkQty; }
            set
            {
                if (value != this._aPPOItemAdjStkQty)
                {
                    _aPPOItemAdjStkQty = value;
                }
            }
        }
        public int FK_GLBudgetCfgID
        {
            get { return _fK_GLBudgetCfgID; }
            set
            {
                if (value != this._fK_GLBudgetCfgID)
                {
                    _fK_GLBudgetCfgID = value;
                }
            }
        }
        public int FK_GLBudgetAllocateAdjID
        {
            get { return _fK_GLBudgetAllocateAdjID; }
            set
            {
                if (value != this._fK_GLBudgetAllocateAdjID)
                {
                    _fK_GLBudgetAllocateAdjID = value;
                }
            }
        }
        public int FK_GLBudgetAllocateAdjDetailID
        {
            get { return _fK_GLBudgetAllocateAdjDetailID; }
            set
            {
                if (value != this._fK_GLBudgetAllocateAdjDetailID)
                {
                    _fK_GLBudgetAllocateAdjDetailID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemInvQty
        {
            get { return _aPPOItemInvQty; }
            set
            {
                if (value != this._aPPOItemInvQty)
                {
                    _aPPOItemInvQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemUsedTime
        {
            get { return _aPPOItemUsedTime; }
            set
            {
                if (value != this._aPPOItemUsedTime)
                {
                    _aPPOItemUsedTime = value;
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
        public int FK_APPRID
        {
            get { return _fK_APPRID; }
            set
            {
                if (value != this._fK_APPRID)
                {
                    _fK_APPRID = value;
                }
            }
        }
        public int FK_APApprovedPriceID
        {
            get { return _fK_APApprovedPriceID; }
            set
            {
                if (value != this._fK_APApprovedPriceID)
                {
                    _fK_APApprovedPriceID = value;
                }
            }
        }
        public int FK_TXDiffTaxCodeID
        {
            get { return _fK_TXDiffTaxCodeID; }
            set
            {
                if (value != this._fK_TXDiffTaxCodeID)
                {
                    _fK_TXDiffTaxCodeID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemTxDiffPct
        {
            get { return _aPPOItemTxDiffPct; }
            set
            {
                if (value != this._aPPOItemTxDiffPct)
                {
                    _aPPOItemTxDiffPct = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemTxDiffFAmt
        {
            get { return _aPPOItemTxDiffFAmt; }
            set
            {
                if (value != this._aPPOItemTxDiffFAmt)
                {
                    _aPPOItemTxDiffFAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemTxDiffAmt
        {
            get { return _aPPOItemTxDiffAmt; }
            set
            {
                if (value != this._aPPOItemTxDiffAmt)
                {
                    _aPPOItemTxDiffAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemTxDiffFAmtTot
        {
            get { return _aPPOItemTxDiffFAmtTot; }
            set
            {
                if (value != this._aPPOItemTxDiffFAmtTot)
                {
                    _aPPOItemTxDiffFAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemTxDiffAmtTot
        {
            get { return _aPPOItemTxDiffAmtTot; }
            set
            {
                if (value != this._aPPOItemTxDiffAmtTot)
                {
                    _aPPOItemTxDiffAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemImpTxPct
        {
            get { return _aPPOItemImpTxPct; }
            set
            {
                if (value != this._aPPOItemImpTxPct)
                {
                    _aPPOItemImpTxPct = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemCalcImpTaxFAmt
        {
            get { return _aPPOItemCalcImpTaxFAmt; }
            set
            {
                if (value != this._aPPOItemCalcImpTaxFAmt)
                {
                    _aPPOItemCalcImpTaxFAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemCalcImpTaxAmt
        {
            get { return _aPPOItemCalcImpTaxAmt; }
            set
            {
                if (value != this._aPPOItemCalcImpTaxAmt)
                {
                    _aPPOItemCalcImpTaxAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemFImpTxAmtTot
        {
            get { return _aPPOItemFImpTxAmtTot; }
            set
            {
                if (value != this._aPPOItemFImpTxAmtTot)
                {
                    _aPPOItemFImpTxAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemImpTxAmtTot
        {
            get { return _aPPOItemImpTxAmtTot; }
            set
            {
                if (value != this._aPPOItemImpTxAmtTot)
                {
                    _aPPOItemImpTxAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemFTxAmtTot
        {
            get { return _aPPOItemFTxAmtTot; }
            set
            {
                if (value != this._aPPOItemFTxAmtTot)
                {
                    _aPPOItemFTxAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemTxAmtTot
        {
            get { return _aPPOItemTxAmtTot; }
            set
            {
                if (value != this._aPPOItemTxAmtTot)
                {
                    _aPPOItemTxAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemImpTxAmt
        {
            get { return _aPPOItemImpTxAmt; }
            set
            {
                if (value != this._aPPOItemImpTxAmt)
                {
                    _aPPOItemImpTxAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemFImportCostAmt
        {
            get { return _aPPOItemFImportCostAmt; }
            set
            {
                if (value != this._aPPOItemFImportCostAmt)
                {
                    _aPPOItemFImportCostAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemImportCostAmt
        {
            get { return _aPPOItemImportCostAmt; }
            set
            {
                if (value != this._aPPOItemImportCostAmt)
                {
                    _aPPOItemImportCostAmt = value;
                }
            }
        }
        public int FK_TXImpTaxCodeID
        {
            get { return _fK_TXImpTaxCodeID; }
            set
            {
                if (value != this._fK_TXImpTaxCodeID)
                {
                    _fK_TXImpTaxCodeID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemRcpRQty
        {
            get { return _aPPOItemRcpRQty; }
            set
            {
                if (value != this._aPPOItemRcpRQty)
                {
                    _aPPOItemRcpRQty = value;
                }
            }
        }
        public int FK_PPWOMRPID
        {
            get { return _fK_PPWOMRPID; }
            set
            {
                if (value != this._fK_PPWOMRPID)
                {
                    _fK_PPWOMRPID = value;
                }
            }
        }
        public int FK_PPWOMRPItemID
        {
            get { return _fK_PPWOMRPItemID; }
            set
            {
                if (value != this._fK_PPWOMRPItemID)
                {
                    _fK_PPWOMRPItemID = value;
                }
            }
        }
        public int FK_PPWOEstFGItemID
        {
            get { return _fK_PPWOEstFGItemID; }
            set
            {
                if (value != this._fK_PPWOEstFGItemID)
                {
                    _fK_PPWOEstFGItemID = value;
                }
            }
        }
        public String APPOItemFGLotNo
        {
            get { return _aPPOItemFGLotNo; }
            set
            {
                if (value != this._aPPOItemFGLotNo)
                {
                    _aPPOItemFGLotNo = value;
                }
            }
        }
        public String APPOItemDesc1
        {
            get { return _aPPOItemDesc1; }
            set
            {
                if (value != this._aPPOItemDesc1)
                {
                    _aPPOItemDesc1 = value;
                }
            }
        }
        public String APPOItemLotNo
        {
            get { return _aPPOItemLotNo; }
            set
            {
                if (value != this._aPPOItemLotNo)
                {
                    _aPPOItemLotNo = value;
                }
            }
        }
        public Nullable<DateTime> APPOItemExpireDate
        {
            get { return _aPPOItemExpireDate; }
            set
            {
                if (value != this._aPPOItemExpireDate)
                {
                    _aPPOItemExpireDate = value;
                }
            }
        }
        public String APPOItemPOF01Combo
        {
            get { return _aPPOItemPOF01Combo; }
            set
            {
                if (value != this._aPPOItemPOF01Combo)
                {
                    _aPPOItemPOF01Combo = value;
                }
            }
        }
        public String APPOItemPOF02Combo
        {
            get { return _aPPOItemPOF02Combo; }
            set
            {
                if (value != this._aPPOItemPOF02Combo)
                {
                    _aPPOItemPOF02Combo = value;
                }
            }
        }
        public String APPOItemPOF03Combo
        {
            get { return _aPPOItemPOF03Combo; }
            set
            {
                if (value != this._aPPOItemPOF03Combo)
                {
                    _aPPOItemPOF03Combo = value;
                }
            }
        }
        public String APPOItemPOF04Combo
        {
            get { return _aPPOItemPOF04Combo; }
            set
            {
                if (value != this._aPPOItemPOF04Combo)
                {
                    _aPPOItemPOF04Combo = value;
                }
            }
        }
        public String APPOItemPOF05Combo
        {
            get { return _aPPOItemPOF05Combo; }
            set
            {
                if (value != this._aPPOItemPOF05Combo)
                {
                    _aPPOItemPOF05Combo = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemOrgFUnitPrice
        {
            get { return _aPPOItemOrgFUnitPrice; }
            set
            {
                if (value != this._aPPOItemOrgFUnitPrice)
                {
                    _aPPOItemOrgFUnitPrice = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APPOItemOrgUnitPrice
        {
            get { return _aPPOItemOrgUnitPrice; }
            set
            {
                if (value != this._aPPOItemOrgUnitPrice)
                {
                    _aPPOItemOrgUnitPrice = value;
                }
            }
        }
        public int FK_PPMaterialPlanID
        {
            get { return _fK_PPMaterialPlanID; }
            set
            {
                if (value != this._fK_PPMaterialPlanID)
                {
                    _fK_PPMaterialPlanID = value;
                }
            }
        }
        public int FK_PPPlanProductionRMID
        {
            get { return _fK_PPPlanProductionRMID; }
            set
            {
                if (value != this._fK_PPPlanProductionRMID)
                {
                    _fK_PPPlanProductionRMID = value;
                }
            }
        }

        #endregion

    }
}
