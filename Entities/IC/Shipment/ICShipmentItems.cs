using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICShipmentItems")]
    public class ICShipmentItems:BaseInfo
    {
        #region Variables
        protected int _iCShipmentItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_ICShipmentID;
        protected int _fK_ICProductID;
        protected int _fK_ICStockID;
        protected int _fK_ICStockSlotID;
        protected int _fK_ICProductTypeID;
        protected int _fK_ARPriceListID;
        protected int _fK_TXTaxCodeID;
        protected int _fK_ARSOID;
        protected int _fK_ARInvoiceID;
        protected String _iCShipmentItemSerialNo = String.Empty;
        protected String _iCShipmentItemType = String.Empty;
        protected bool _iCShipmentItemIsStkItm = true;
        protected String _iCShipmentItemDesc = String.Empty;
        protected String _iCShipmentItemPkgUOM = String.Empty;
        protected decimal _iCShipmentItemFact;
        protected String _aRSalePriceCombo = String.Empty;
        protected decimal _iCShipmentItemUnitPrice;
        protected decimal _iCShipmentItemUnitCost;
        protected decimal _iCShipmentItemDiscPct;
        protected decimal _iCShipmentItemTxPct;
        protected decimal _iCShipmentItemVolume;
        protected decimal _iCShipmentItemQty;
        protected decimal _iCShipmentItemPkgQty;
        protected decimal _iCShipmentItemStkQty;
        protected decimal _iCShipmentItemRQty;
        protected decimal _iCShipmentItemRStkQty;
        protected decimal _iCShipmentItemPrice;
        protected String _iCShipmentItemComment = String.Empty;
        protected decimal _iCShipmentItemUnitVol;
        protected decimal _iCShipmentItemUnitWeight;
        protected decimal _iCShipmentItemTxAmt;
        protected decimal _iCShipmentItemDiscAmt;
        protected decimal _iCShipmentItemNetAmt;
        protected decimal _iCShipmentItemAmtTot;
        protected decimal _iCShipmentItemCostTot;
        protected String _iCShipmentItemStatus = DefaultStatus;
        protected decimal _iCShipmentItemAmt;
        protected decimal _iCShipmentItemCAmt;
        protected decimal _iCShipmentItemWTot;
        protected decimal _iCShipmentItemVTot;
        protected int _fK_LOShpPlanID;
        protected int _iCShipmentItemSortOrder;
        protected int _fK_ARSOItemID;
        protected int _fK_ARCustomerID;
        protected int _fK_PPPhaseCfgID;
        protected int _fK_ICProductIDWO;
        protected int _fK_HRDerpamentID;
        protected int _fK_ICReceiptItemID;
        protected Nullable<DateTime> _iCShipmentItemExpireDate;
        protected Nullable<DateTime> _iCShipmentItemExpiredDate;
        protected int _fK_ICProductParentID;
        protected decimal _iCShipmentItemFUnitPrice;
        protected decimal _iCShipmentItemFPrice;
        protected decimal _iCShipmentItemFTxAmt;
        protected decimal _iCShipmentItemFNetAmt;
        protected decimal _iCShipmentItemFAmtTot;
        protected decimal _iCShipmentItemFImpTxAmt;
        protected int _fK_GLDebitAccountID;
        protected int _fK_GLCreditAccountID;
        protected int _fK_GLDebitVATAccountID;
        protected int _fK_GLCreditVATAccountID;
        protected decimal _iCShipmentItemAllocateLife;
        protected int _fK_FAAssetID;
        protected int _fK_HRDepartmentID;
        protected decimal _iCShipmentItemAssetLife;
        protected int _fK_ARCampaignID;
        protected int _fK_ARCampaignItemID;
        protected int _fK_ARCreditNoteItemID;
        protected decimal _iCShipmentItemSaleReturnRQty;
        protected String _iCShipmentItemSaleReturnStatusCombo = DefaultStatus;
        protected String _iCShipmentItemLotNo = String.Empty;
        protected decimal _aPSOItemFUnitPrice;
        protected decimal _iCShipmentItemDriverPmtAmt;
        protected decimal _iCShipmentItemDriverPmtPct;
        protected bool _iCShipmentItemIsValidInv = true;
        protected decimal _iCShipmentItemAllocateQty;
        protected decimal _iCShipmentItemRequestQty;
        protected String _iCPackageLockTypeCombo = String.Empty;
        protected decimal _iCShipmentItemPurchaseReturnRQty;
        protected String _iCShipmentItemPurchaseReturnStatusCombo = DefaultStatus;
        protected bool _iCShipmentItemIsCostingItemCheck = true;
        protected int _fK_PPProductionOrdrID;
        protected int _fK_GLCostDistID;
        protected int _fK_ICDistributionRuleID;
        protected int _fK_PPPkgOrderItemID;
        protected int _fK_GLCostCenterID;
        protected int _fK_GLTranCfgID;
        protected int _fK_PPWOID;
        protected bool _iCShipmentItemIsIdentifyCost = false;
        protected int _fK_ICUOMID;
        protected int _fK_ICPkgUOMID;
        protected int _fK_ICStkUOMID;
        protected int _fK_ICWeightUOMID;
        protected int _fK_ICVolumeUOMID;
        protected decimal _iCShipmentItemOrgQty;
        protected decimal _iCShipmentItemExcQty;
        protected int _fK_ICOrgUOMID;
        protected decimal _iCShipmentItemCQty;
        protected int _fK_PPCostCenterID;
        protected int _fK_ICAssemblyID;
        protected int _fK_ICKitID;
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
        protected int _fK_ICReceiptID;
        protected decimal _iCShipmentItemDocRQty;
        protected int _fK_APPInvoiceItemID;
        protected int _fK_FAAssetConstructionID;
        protected decimal _iCShipmentItemActQty;
        protected decimal _iCShipmentItemOtherQty;
        protected int _fK_ICROID;
        protected int _fK_APPOID;
        protected int _fK_PPProductPlnItemID;
        protected int _fK_ICTransferItemID;
        protected String _iCShipmentItemFGLotNo = String.Empty;
        protected String _gLTOF11Combo = String.Empty;
        protected String _gLTOF12Combo = String.Empty;
        protected String _gLTOF13Combo = String.Empty;
        protected String _gLTOF14Combo = String.Empty;
        protected String _gLTOF15Combo = String.Empty;
        protected decimal _iCShipmentItemFDiscAmt;
        protected int _fK_APPOItemID;
        protected decimal _iCShipmentItemGrossWTot;
        protected decimal _iCShipmentItemNetWTot;
        protected String _iCShipmentItemTAN = String.Empty;
        protected decimal _iCShipmentItemAdjStkQty;
        protected decimal _iCShipmentItemAdjUnitPricePct01;
        protected decimal _iCShipmentItemAdjUnitPricePct02;
        protected decimal _iCShipmentItemAdjUnitPricePct03;
        protected decimal _iCShipmentItemAdjUnitPricePct04;
        protected decimal _iCShipmentItemAdjUnitPricePct05;
        protected decimal _iCShipmentItemAdjDiscPct01;
        protected decimal _iCShipmentItemAdjDiscPct02;
        protected decimal _iCShipmentItemAdjDiscPct03;
        protected decimal _iCShipmentItemAdjDiscPct04;
        protected decimal _iCShipmentItemAdjDiscPct05;
        protected decimal _iCShipmentItemAdjDiscFAmt01;
        protected decimal _iCShipmentItemAdjDiscFAmt02;
        protected decimal _iCShipmentItemAdjDiscFAmt03;
        protected decimal _iCShipmentItemAdjDiscFAmt04;
        protected decimal _iCShipmentItemAdjDiscFAmt05;
        protected decimal _iCShipmentItemAdjDiscAmt01;
        protected decimal _iCShipmentItemAdjDiscAmt02;
        protected decimal _iCShipmentItemAdjDiscAmt03;
        protected decimal _iCShipmentItemAdjDiscAmt04;
        protected decimal _iCShipmentItemAdjDiscAmt05;
        protected decimal _iCShipmentItemNetAmtTot;
        protected decimal _iCShipmentItemFNetAmtTot;
        protected int _fK_GLBudgetID;
        protected int _fK_GLBudgetCfgID;
        protected int _fK_GLBudgetAllocateAdjID;
        protected int _fK_GLBudgetAllocateAdjItemID;
        protected int _fK_GLBudgetAllocateAdjDetailID;
        protected decimal _iCShipmentItemFDiscAmtTot;
        protected decimal _iCShipmentItemDiscAmtTot;
        protected int _fK_ICTransferID;
        protected int _fK_PPProductionOrdrEstRMID;
        protected int _fK_PPProductionOrdrEstFGID;
        protected Nullable<DateTime> _iCShipmentItemShpDate;
        protected String _iCShipmentItemAllocateTypeCombo = String.Empty;
        protected int _fK_PPWorkCenterID;
        protected String _iCShipmentItemDesc1 = String.Empty;
        protected String _iCShipmentItemDesc2 = String.Empty;
        protected String _iCShipmentItemDesc3 = String.Empty;
        protected String _iCShipmentItemDesc4 = String.Empty;
        protected String _iCShipmentItemDesc5 = String.Empty;
        protected String _iCShipmentItemPONumber = String.Empty;
        protected int _fK_PPProductionOrdrRelationID;
        protected decimal _iCShipmentItemBarQty;
        protected decimal _iCShipmentItemRcpQty;
        protected int _fK_APSupplierID;
        protected String _iCShipmentItemProductPack = String.Empty;
        protected int _fK_ARCustomerProductNumberID;
        protected String _iCShipmentItemPOF01Combo = String.Empty;
        protected String _iCShipmentItemPOF02Combo = String.Empty;
        protected String _iCShipmentItemPOF03Combo = String.Empty;
        protected String _iCShipmentItemPOF04Combo = String.Empty;
        protected String _iCShipmentItemPOF05Combo = String.Empty;
        protected String _iCShipmentItemFGPOF01Combo = String.Empty;
        protected String _iCShipmentItemFGPOF02Combo = String.Empty;
        protected String _iCShipmentItemFGPOF03Combo = String.Empty;
        protected String _iCShipmentItemFGPOF04Combo = String.Empty;
        protected String _iCShipmentItemFGPOF05Combo = String.Empty;
        protected decimal _iCShipmentItemUnitPkgCBM;
        protected decimal _iCShipmentItemContQty;
        protected decimal _iCShipmentItemContFact;
        protected decimal _iCShipmentItemPkgCBM;
        protected int _fK_ICProductRootID;
        protected int _fK_ICROContID;
        protected String _gLTOF16Combo = String.Empty;
        protected String _gLTOF17Combo = String.Empty;
        protected String _gLTOF18Combo = String.Empty;
        protected String _gLTOF19Combo = String.Empty;
        protected String _gLTOF20Combo = String.Empty;
        protected String _gLTOF21Combo = String.Empty;
        protected String _gLTOF22Combo = String.Empty;
        protected String _gLTOF23Combo = String.Empty;
        protected String _gLTOF24Combo = String.Empty;
        protected String _gLTOF25Combo = String.Empty;
        protected String _gLTOF26Combo = String.Empty;
        protected String _gLTOF27Combo = String.Empty;
        protected String _gLTOF28Combo = String.Empty;
        protected String _gLTOF29Combo = String.Empty;
        protected String _gLTOF30Combo = String.Empty;
        protected String _gLTOF31Combo = String.Empty;
        protected String _gLTOF32Combo = String.Empty;
        protected String _gLTOF33Combo = String.Empty;
        protected String _gLTOF34Combo = String.Empty;
        protected String _gLTOF35Combo = String.Empty;
        protected decimal _iCShipmentItemReturnQty;

        #endregion
        #region Public properties
        [Key]
        public int ICShipmentItemID
        {
            get { return _iCShipmentItemID; }
            set
            {
                if (value != this._iCShipmentItemID)
                {
                    _iCShipmentItemID = value;
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
        public int FK_ICShipmentID
        {
            get { return _fK_ICShipmentID; }
            set
            {
                if (value != this._fK_ICShipmentID)
                {
                    _fK_ICShipmentID = value;
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
        public int FK_ARInvoiceID
        {
            get { return _fK_ARInvoiceID; }
            set
            {
                if (value != this._fK_ARInvoiceID)
                {
                    _fK_ARInvoiceID = value;
                }
            }
        }
        public String ICShipmentItemSerialNo
        {
            get { return _iCShipmentItemSerialNo; }
            set
            {
                if (value != this._iCShipmentItemSerialNo)
                {
                    _iCShipmentItemSerialNo = value;
                }
            }
        }
        public String ICShipmentItemType
        {
            get { return _iCShipmentItemType; }
            set
            {
                if (value != this._iCShipmentItemType)
                {
                    _iCShipmentItemType = value;
                }
            }
        }
        public bool ICShipmentItemIsStkItm
        {
            get { return _iCShipmentItemIsStkItm; }
            set
            {
                if (value != this._iCShipmentItemIsStkItm)
                {
                    _iCShipmentItemIsStkItm = value;
                }
            }
        }
        public String ICShipmentItemDesc
        {
            get { return _iCShipmentItemDesc; }
            set
            {
                if (value != this._iCShipmentItemDesc)
                {
                    _iCShipmentItemDesc = value;
                }
            }
        }
        public String ICShipmentItemPkgUOM
        {
            get { return _iCShipmentItemPkgUOM; }
            set
            {
                if (value != this._iCShipmentItemPkgUOM)
                {
                    _iCShipmentItemPkgUOM = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemFact
        {
            get { return _iCShipmentItemFact; }
            set
            {
                if (value != this._iCShipmentItemFact)
                {
                    _iCShipmentItemFact = value;
                }
            }
        }
        public String ARSalePriceCombo
        {
            get { return _aRSalePriceCombo; }
            set
            {
                if (value != this._aRSalePriceCombo)
                {
                    _aRSalePriceCombo = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemUnitPrice
        {
            get { return _iCShipmentItemUnitPrice; }
            set
            {
                if (value != this._iCShipmentItemUnitPrice)
                {
                    _iCShipmentItemUnitPrice = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemUnitCost
        {
            get { return _iCShipmentItemUnitCost; }
            set
            {
                if (value != this._iCShipmentItemUnitCost)
                {
                    _iCShipmentItemUnitCost = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemDiscPct
        {
            get { return _iCShipmentItemDiscPct; }
            set
            {
                if (value != this._iCShipmentItemDiscPct)
                {
                    _iCShipmentItemDiscPct = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemTxPct
        {
            get { return _iCShipmentItemTxPct; }
            set
            {
                if (value != this._iCShipmentItemTxPct)
                {
                    _iCShipmentItemTxPct = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemVolume
        {
            get { return _iCShipmentItemVolume; }
            set
            {
                if (value != this._iCShipmentItemVolume)
                {
                    _iCShipmentItemVolume = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemQty
        {
            get { return _iCShipmentItemQty; }
            set
            {
                if (value != this._iCShipmentItemQty)
                {
                    _iCShipmentItemQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemPkgQty
        {
            get { return _iCShipmentItemPkgQty; }
            set
            {
                if (value != this._iCShipmentItemPkgQty)
                {
                    _iCShipmentItemPkgQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemStkQty
        {
            get { return _iCShipmentItemStkQty; }
            set
            {
                if (value != this._iCShipmentItemStkQty)
                {
                    _iCShipmentItemStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemRQty
        {
            get { return _iCShipmentItemRQty; }
            set
            {
                if (value != this._iCShipmentItemRQty)
                {
                    _iCShipmentItemRQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemRStkQty
        {
            get { return _iCShipmentItemRStkQty; }
            set
            {
                if (value != this._iCShipmentItemRStkQty)
                {
                    _iCShipmentItemRStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemPrice
        {
            get { return _iCShipmentItemPrice; }
            set
            {
                if (value != this._iCShipmentItemPrice)
                {
                    _iCShipmentItemPrice = value;
                }
            }
        }
        public String ICShipmentItemComment
        {
            get { return _iCShipmentItemComment; }
            set
            {
                if (value != this._iCShipmentItemComment)
                {
                    _iCShipmentItemComment = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemUnitVol
        {
            get { return _iCShipmentItemUnitVol; }
            set
            {
                if (value != this._iCShipmentItemUnitVol)
                {
                    _iCShipmentItemUnitVol = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemUnitWeight
        {
            get { return _iCShipmentItemUnitWeight; }
            set
            {
                if (value != this._iCShipmentItemUnitWeight)
                {
                    _iCShipmentItemUnitWeight = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemTxAmt
        {
            get { return _iCShipmentItemTxAmt; }
            set
            {
                if (value != this._iCShipmentItemTxAmt)
                {
                    _iCShipmentItemTxAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemDiscAmt
        {
            get { return _iCShipmentItemDiscAmt; }
            set
            {
                if (value != this._iCShipmentItemDiscAmt)
                {
                    _iCShipmentItemDiscAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemNetAmt
        {
            get { return _iCShipmentItemNetAmt; }
            set
            {
                if (value != this._iCShipmentItemNetAmt)
                {
                    _iCShipmentItemNetAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAmtTot
        {
            get { return _iCShipmentItemAmtTot; }
            set
            {
                if (value != this._iCShipmentItemAmtTot)
                {
                    _iCShipmentItemAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemCostTot
        {
            get { return _iCShipmentItemCostTot; }
            set
            {
                if (value != this._iCShipmentItemCostTot)
                {
                    _iCShipmentItemCostTot = value;
                }
            }
        }
        public String ICShipmentItemStatus
        {
            get { return _iCShipmentItemStatus; }
            set
            {
                if (value != this._iCShipmentItemStatus)
                {
                    _iCShipmentItemStatus = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAmt
        {
            get { return _iCShipmentItemAmt; }
            set
            {
                if (value != this._iCShipmentItemAmt)
                {
                    _iCShipmentItemAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemCAmt
        {
            get { return _iCShipmentItemCAmt; }
            set
            {
                if (value != this._iCShipmentItemCAmt)
                {
                    _iCShipmentItemCAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemWTot
        {
            get { return _iCShipmentItemWTot; }
            set
            {
                if (value != this._iCShipmentItemWTot)
                {
                    _iCShipmentItemWTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemVTot
        {
            get { return _iCShipmentItemVTot; }
            set
            {
                if (value != this._iCShipmentItemVTot)
                {
                    _iCShipmentItemVTot = value;
                }
            }
        }
        public int FK_LOShpPlanID
        {
            get { return _fK_LOShpPlanID; }
            set
            {
                if (value != this._fK_LOShpPlanID)
                {
                    _fK_LOShpPlanID = value;
                }
            }
        }
        public int ICShipmentItemSortOrder
        {
            get { return _iCShipmentItemSortOrder; }
            set
            {
                if (value != this._iCShipmentItemSortOrder)
                {
                    _iCShipmentItemSortOrder = value;
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
        public int FK_ARCustomerID
        {
            get { return _fK_ARCustomerID; }
            set
            {
                if (value != this._fK_ARCustomerID)
                {
                    _fK_ARCustomerID = value;
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
        public int FK_ICProductIDWO
        {
            get { return _fK_ICProductIDWO; }
            set
            {
                if (value != this._fK_ICProductIDWO)
                {
                    _fK_ICProductIDWO = value;
                }
            }
        }
        public int FK_HRDerpamentID
        {
            get { return _fK_HRDerpamentID; }
            set
            {
                if (value != this._fK_HRDerpamentID)
                {
                    _fK_HRDerpamentID = value;
                }
            }
        }
        public int FK_ICReceiptItemID
        {
            get { return _fK_ICReceiptItemID; }
            set
            {
                if (value != this._fK_ICReceiptItemID)
                {
                    _fK_ICReceiptItemID = value;
                }
            }
        }
        public Nullable<DateTime> ICShipmentItemExpireDate
        {
            get { return _iCShipmentItemExpireDate; }
            set
            {
                if (value != this._iCShipmentItemExpireDate)
                {
                    _iCShipmentItemExpireDate = value;
                }
            }
        }
        public Nullable<DateTime> ICShipmentItemExpiredDate
        {
            get { return _iCShipmentItemExpiredDate; }
            set
            {
                if (value != this._iCShipmentItemExpiredDate)
                {
                    _iCShipmentItemExpiredDate = value;
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
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemFUnitPrice
        {
            get { return _iCShipmentItemFUnitPrice; }
            set
            {
                if (value != this._iCShipmentItemFUnitPrice)
                {
                    _iCShipmentItemFUnitPrice = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemFPrice
        {
            get { return _iCShipmentItemFPrice; }
            set
            {
                if (value != this._iCShipmentItemFPrice)
                {
                    _iCShipmentItemFPrice = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemFTxAmt
        {
            get { return _iCShipmentItemFTxAmt; }
            set
            {
                if (value != this._iCShipmentItemFTxAmt)
                {
                    _iCShipmentItemFTxAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemFNetAmt
        {
            get { return _iCShipmentItemFNetAmt; }
            set
            {
                if (value != this._iCShipmentItemFNetAmt)
                {
                    _iCShipmentItemFNetAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemFAmtTot
        {
            get { return _iCShipmentItemFAmtTot; }
            set
            {
                if (value != this._iCShipmentItemFAmtTot)
                {
                    _iCShipmentItemFAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemFImpTxAmt
        {
            get { return _iCShipmentItemFImpTxAmt; }
            set
            {
                if (value != this._iCShipmentItemFImpTxAmt)
                {
                    _iCShipmentItemFImpTxAmt = value;
                }
            }
        }
        public int FK_GLDebitAccountID
        {
            get { return _fK_GLDebitAccountID; }
            set
            {
                if (value != this._fK_GLDebitAccountID)
                {
                    _fK_GLDebitAccountID = value;
                }
            }
        }
        public int FK_GLCreditAccountID
        {
            get { return _fK_GLCreditAccountID; }
            set
            {
                if (value != this._fK_GLCreditAccountID)
                {
                    _fK_GLCreditAccountID = value;
                }
            }
        }
        public int FK_GLDebitVATAccountID
        {
            get { return _fK_GLDebitVATAccountID; }
            set
            {
                if (value != this._fK_GLDebitVATAccountID)
                {
                    _fK_GLDebitVATAccountID = value;
                }
            }
        }
        public int FK_GLCreditVATAccountID
        {
            get { return _fK_GLCreditVATAccountID; }
            set
            {
                if (value != this._fK_GLCreditVATAccountID)
                {
                    _fK_GLCreditVATAccountID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAllocateLife
        {
            get { return _iCShipmentItemAllocateLife; }
            set
            {
                if (value != this._iCShipmentItemAllocateLife)
                {
                    _iCShipmentItemAllocateLife = value;
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
        public int FK_HRDepartmentID
        {
            get { return _fK_HRDepartmentID; }
            set
            {
                if (value != this._fK_HRDepartmentID)
                {
                    _fK_HRDepartmentID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAssetLife
        {
            get { return _iCShipmentItemAssetLife; }
            set
            {
                if (value != this._iCShipmentItemAssetLife)
                {
                    _iCShipmentItemAssetLife = value;
                }
            }
        }
        public int FK_ARCampaignID
        {
            get { return _fK_ARCampaignID; }
            set
            {
                if (value != this._fK_ARCampaignID)
                {
                    _fK_ARCampaignID = value;
                }
            }
        }
        public int FK_ARCampaignItemID
        {
            get { return _fK_ARCampaignItemID; }
            set
            {
                if (value != this._fK_ARCampaignItemID)
                {
                    _fK_ARCampaignItemID = value;
                }
            }
        }
        public int FK_ARCreditNoteItemID
        {
            get { return _fK_ARCreditNoteItemID; }
            set
            {
                if (value != this._fK_ARCreditNoteItemID)
                {
                    _fK_ARCreditNoteItemID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemSaleReturnRQty
        {
            get { return _iCShipmentItemSaleReturnRQty; }
            set
            {
                if (value != this._iCShipmentItemSaleReturnRQty)
                {
                    _iCShipmentItemSaleReturnRQty = value;
                }
            }
        }
        public String ICShipmentItemSaleReturnStatusCombo
        {
            get { return _iCShipmentItemSaleReturnStatusCombo; }
            set
            {
                if (value != this._iCShipmentItemSaleReturnStatusCombo)
                {
                    _iCShipmentItemSaleReturnStatusCombo = value;
                }
            }
        }
        public String ICShipmentItemLotNo
        {
            get { return _iCShipmentItemLotNo; }
            set
            {
                if (value != this._iCShipmentItemLotNo)
                {
                    _iCShipmentItemLotNo = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal APSOItemFUnitPrice
        {
            get { return _aPSOItemFUnitPrice; }
            set
            {
                if (value != this._aPSOItemFUnitPrice)
                {
                    _aPSOItemFUnitPrice = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemDriverPmtAmt
        {
            get { return _iCShipmentItemDriverPmtAmt; }
            set
            {
                if (value != this._iCShipmentItemDriverPmtAmt)
                {
                    _iCShipmentItemDriverPmtAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemDriverPmtPct
        {
            get { return _iCShipmentItemDriverPmtPct; }
            set
            {
                if (value != this._iCShipmentItemDriverPmtPct)
                {
                    _iCShipmentItemDriverPmtPct = value;
                }
            }
        }
        public bool ICShipmentItemIsValidInv
        {
            get { return _iCShipmentItemIsValidInv; }
            set
            {
                if (value != this._iCShipmentItemIsValidInv)
                {
                    _iCShipmentItemIsValidInv = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAllocateQty
        {
            get { return _iCShipmentItemAllocateQty; }
            set
            {
                if (value != this._iCShipmentItemAllocateQty)
                {
                    _iCShipmentItemAllocateQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemRequestQty
        {
            get { return _iCShipmentItemRequestQty; }
            set
            {
                if (value != this._iCShipmentItemRequestQty)
                {
                    _iCShipmentItemRequestQty = value;
                }
            }
        }
        public String ICPackageLockTypeCombo
        {
            get { return _iCPackageLockTypeCombo; }
            set
            {
                if (value != this._iCPackageLockTypeCombo)
                {
                    _iCPackageLockTypeCombo = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemPurchaseReturnRQty
        {
            get { return _iCShipmentItemPurchaseReturnRQty; }
            set
            {
                if (value != this._iCShipmentItemPurchaseReturnRQty)
                {
                    _iCShipmentItemPurchaseReturnRQty = value;
                }
            }
        }
        public String ICShipmentItemPurchaseReturnStatusCombo
        {
            get { return _iCShipmentItemPurchaseReturnStatusCombo; }
            set
            {
                if (value != this._iCShipmentItemPurchaseReturnStatusCombo)
                {
                    _iCShipmentItemPurchaseReturnStatusCombo = value;
                }
            }
        }
        public bool ICShipmentItemIsCostingItemCheck
        {
            get { return _iCShipmentItemIsCostingItemCheck; }
            set
            {
                if (value != this._iCShipmentItemIsCostingItemCheck)
                {
                    _iCShipmentItemIsCostingItemCheck = value;
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
        public int FK_GLCostDistID
        {
            get { return _fK_GLCostDistID; }
            set
            {
                if (value != this._fK_GLCostDistID)
                {
                    _fK_GLCostDistID = value;
                }
            }
        }
        public int FK_ICDistributionRuleID
        {
            get { return _fK_ICDistributionRuleID; }
            set
            {
                if (value != this._fK_ICDistributionRuleID)
                {
                    _fK_ICDistributionRuleID = value;
                }
            }
        }
        public int FK_PPPkgOrderItemID
        {
            get { return _fK_PPPkgOrderItemID; }
            set
            {
                if (value != this._fK_PPPkgOrderItemID)
                {
                    _fK_PPPkgOrderItemID = value;
                }
            }
        }
        public int FK_GLCostCenterID
        {
            get { return _fK_GLCostCenterID; }
            set
            {
                if (value != this._fK_GLCostCenterID)
                {
                    _fK_GLCostCenterID = value;
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
        public bool ICShipmentItemIsIdentifyCost
        {
            get { return _iCShipmentItemIsIdentifyCost; }
            set
            {
                if (value != this._iCShipmentItemIsIdentifyCost)
                {
                    _iCShipmentItemIsIdentifyCost = value;
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
        public int FK_ICPkgUOMID
        {
            get { return _fK_ICPkgUOMID; }
            set
            {
                if (value != this._fK_ICPkgUOMID)
                {
                    _fK_ICPkgUOMID = value;
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
        public decimal ICShipmentItemOrgQty
        {
            get { return _iCShipmentItemOrgQty; }
            set
            {
                if (value != this._iCShipmentItemOrgQty)
                {
                    _iCShipmentItemOrgQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemExcQty
        {
            get { return _iCShipmentItemExcQty; }
            set
            {
                if (value != this._iCShipmentItemExcQty)
                {
                    _iCShipmentItemExcQty = value;
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
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemCQty
        {
            get { return _iCShipmentItemCQty; }
            set
            {
                if (value != this._iCShipmentItemCQty)
                {
                    _iCShipmentItemCQty = value;
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
        public int FK_ICAssemblyID
        {
            get { return _fK_ICAssemblyID; }
            set
            {
                if (value != this._fK_ICAssemblyID)
                {
                    _fK_ICAssemblyID = value;
                }
            }
        }
        public int FK_ICKitID
        {
            get { return _fK_ICKitID; }
            set
            {
                if (value != this._fK_ICKitID)
                {
                    _fK_ICKitID = value;
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
        public int FK_ICReceiptID
        {
            get { return _fK_ICReceiptID; }
            set
            {
                if (value != this._fK_ICReceiptID)
                {
                    _fK_ICReceiptID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemDocRQty
        {
            get { return _iCShipmentItemDocRQty; }
            set
            {
                if (value != this._iCShipmentItemDocRQty)
                {
                    _iCShipmentItemDocRQty = value;
                }
            }
        }
        public int FK_APPInvoiceItemID
        {
            get { return _fK_APPInvoiceItemID; }
            set
            {
                if (value != this._fK_APPInvoiceItemID)
                {
                    _fK_APPInvoiceItemID = value;
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
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemActQty
        {
            get { return _iCShipmentItemActQty; }
            set
            {
                if (value != this._iCShipmentItemActQty)
                {
                    _iCShipmentItemActQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemOtherQty
        {
            get { return _iCShipmentItemOtherQty; }
            set
            {
                if (value != this._iCShipmentItemOtherQty)
                {
                    _iCShipmentItemOtherQty = value;
                }
            }
        }
        public int FK_ICROID
        {
            get { return _fK_ICROID; }
            set
            {
                if (value != this._fK_ICROID)
                {
                    _fK_ICROID = value;
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
        public int FK_ICTransferItemID
        {
            get { return _fK_ICTransferItemID; }
            set
            {
                if (value != this._fK_ICTransferItemID)
                {
                    _fK_ICTransferItemID = value;
                }
            }
        }
        public String ICShipmentItemFGLotNo
        {
            get { return _iCShipmentItemFGLotNo; }
            set
            {
                if (value != this._iCShipmentItemFGLotNo)
                {
                    _iCShipmentItemFGLotNo = value;
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
        public decimal ICShipmentItemFDiscAmt
        {
            get { return _iCShipmentItemFDiscAmt; }
            set
            {
                if (value != this._iCShipmentItemFDiscAmt)
                {
                    _iCShipmentItemFDiscAmt = value;
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
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemGrossWTot
        {
            get { return _iCShipmentItemGrossWTot; }
            set
            {
                if (value != this._iCShipmentItemGrossWTot)
                {
                    _iCShipmentItemGrossWTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemNetWTot
        {
            get { return _iCShipmentItemNetWTot; }
            set
            {
                if (value != this._iCShipmentItemNetWTot)
                {
                    _iCShipmentItemNetWTot = value;
                }
            }
        }
        public String ICShipmentItemTAN
        {
            get { return _iCShipmentItemTAN; }
            set
            {
                if (value != this._iCShipmentItemTAN)
                {
                    _iCShipmentItemTAN = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjStkQty
        {
            get { return _iCShipmentItemAdjStkQty; }
            set
            {
                if (value != this._iCShipmentItemAdjStkQty)
                {
                    _iCShipmentItemAdjStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjUnitPricePct01
        {
            get { return _iCShipmentItemAdjUnitPricePct01; }
            set
            {
                if (value != this._iCShipmentItemAdjUnitPricePct01)
                {
                    _iCShipmentItemAdjUnitPricePct01 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjUnitPricePct02
        {
            get { return _iCShipmentItemAdjUnitPricePct02; }
            set
            {
                if (value != this._iCShipmentItemAdjUnitPricePct02)
                {
                    _iCShipmentItemAdjUnitPricePct02 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjUnitPricePct03
        {
            get { return _iCShipmentItemAdjUnitPricePct03; }
            set
            {
                if (value != this._iCShipmentItemAdjUnitPricePct03)
                {
                    _iCShipmentItemAdjUnitPricePct03 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjUnitPricePct04
        {
            get { return _iCShipmentItemAdjUnitPricePct04; }
            set
            {
                if (value != this._iCShipmentItemAdjUnitPricePct04)
                {
                    _iCShipmentItemAdjUnitPricePct04 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjUnitPricePct05
        {
            get { return _iCShipmentItemAdjUnitPricePct05; }
            set
            {
                if (value != this._iCShipmentItemAdjUnitPricePct05)
                {
                    _iCShipmentItemAdjUnitPricePct05 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjDiscPct01
        {
            get { return _iCShipmentItemAdjDiscPct01; }
            set
            {
                if (value != this._iCShipmentItemAdjDiscPct01)
                {
                    _iCShipmentItemAdjDiscPct01 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjDiscPct02
        {
            get { return _iCShipmentItemAdjDiscPct02; }
            set
            {
                if (value != this._iCShipmentItemAdjDiscPct02)
                {
                    _iCShipmentItemAdjDiscPct02 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjDiscPct03
        {
            get { return _iCShipmentItemAdjDiscPct03; }
            set
            {
                if (value != this._iCShipmentItemAdjDiscPct03)
                {
                    _iCShipmentItemAdjDiscPct03 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjDiscPct04
        {
            get { return _iCShipmentItemAdjDiscPct04; }
            set
            {
                if (value != this._iCShipmentItemAdjDiscPct04)
                {
                    _iCShipmentItemAdjDiscPct04 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjDiscPct05
        {
            get { return _iCShipmentItemAdjDiscPct05; }
            set
            {
                if (value != this._iCShipmentItemAdjDiscPct05)
                {
                    _iCShipmentItemAdjDiscPct05 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjDiscFAmt01
        {
            get { return _iCShipmentItemAdjDiscFAmt01; }
            set
            {
                if (value != this._iCShipmentItemAdjDiscFAmt01)
                {
                    _iCShipmentItemAdjDiscFAmt01 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjDiscFAmt02
        {
            get { return _iCShipmentItemAdjDiscFAmt02; }
            set
            {
                if (value != this._iCShipmentItemAdjDiscFAmt02)
                {
                    _iCShipmentItemAdjDiscFAmt02 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjDiscFAmt03
        {
            get { return _iCShipmentItemAdjDiscFAmt03; }
            set
            {
                if (value != this._iCShipmentItemAdjDiscFAmt03)
                {
                    _iCShipmentItemAdjDiscFAmt03 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjDiscFAmt04
        {
            get { return _iCShipmentItemAdjDiscFAmt04; }
            set
            {
                if (value != this._iCShipmentItemAdjDiscFAmt04)
                {
                    _iCShipmentItemAdjDiscFAmt04 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjDiscFAmt05
        {
            get { return _iCShipmentItemAdjDiscFAmt05; }
            set
            {
                if (value != this._iCShipmentItemAdjDiscFAmt05)
                {
                    _iCShipmentItemAdjDiscFAmt05 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjDiscAmt01
        {
            get { return _iCShipmentItemAdjDiscAmt01; }
            set
            {
                if (value != this._iCShipmentItemAdjDiscAmt01)
                {
                    _iCShipmentItemAdjDiscAmt01 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjDiscAmt02
        {
            get { return _iCShipmentItemAdjDiscAmt02; }
            set
            {
                if (value != this._iCShipmentItemAdjDiscAmt02)
                {
                    _iCShipmentItemAdjDiscAmt02 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjDiscAmt03
        {
            get { return _iCShipmentItemAdjDiscAmt03; }
            set
            {
                if (value != this._iCShipmentItemAdjDiscAmt03)
                {
                    _iCShipmentItemAdjDiscAmt03 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjDiscAmt04
        {
            get { return _iCShipmentItemAdjDiscAmt04; }
            set
            {
                if (value != this._iCShipmentItemAdjDiscAmt04)
                {
                    _iCShipmentItemAdjDiscAmt04 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemAdjDiscAmt05
        {
            get { return _iCShipmentItemAdjDiscAmt05; }
            set
            {
                if (value != this._iCShipmentItemAdjDiscAmt05)
                {
                    _iCShipmentItemAdjDiscAmt05 = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemNetAmtTot
        {
            get { return _iCShipmentItemNetAmtTot; }
            set
            {
                if (value != this._iCShipmentItemNetAmtTot)
                {
                    _iCShipmentItemNetAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemFNetAmtTot
        {
            get { return _iCShipmentItemFNetAmtTot; }
            set
            {
                if (value != this._iCShipmentItemFNetAmtTot)
                {
                    _iCShipmentItemFNetAmtTot = value;
                }
            }
        }
        public int FK_GLBudgetID
        {
            get { return _fK_GLBudgetID; }
            set
            {
                if (value != this._fK_GLBudgetID)
                {
                    _fK_GLBudgetID = value;
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
        public int FK_GLBudgetAllocateAdjItemID
        {
            get { return _fK_GLBudgetAllocateAdjItemID; }
            set
            {
                if (value != this._fK_GLBudgetAllocateAdjItemID)
                {
                    _fK_GLBudgetAllocateAdjItemID = value;
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
        public decimal ICShipmentItemFDiscAmtTot
        {
            get { return _iCShipmentItemFDiscAmtTot; }
            set
            {
                if (value != this._iCShipmentItemFDiscAmtTot)
                {
                    _iCShipmentItemFDiscAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemDiscAmtTot
        {
            get { return _iCShipmentItemDiscAmtTot; }
            set
            {
                if (value != this._iCShipmentItemDiscAmtTot)
                {
                    _iCShipmentItemDiscAmtTot = value;
                }
            }
        }
        public int FK_ICTransferID
        {
            get { return _fK_ICTransferID; }
            set
            {
                if (value != this._fK_ICTransferID)
                {
                    _fK_ICTransferID = value;
                }
            }
        }
        public int FK_PPProductionOrdrEstRMID
        {
            get { return _fK_PPProductionOrdrEstRMID; }
            set
            {
                if (value != this._fK_PPProductionOrdrEstRMID)
                {
                    _fK_PPProductionOrdrEstRMID = value;
                }
            }
        }
        public int FK_PPProductionOrdrEstFGID
        {
            get { return _fK_PPProductionOrdrEstFGID; }
            set
            {
                if (value != this._fK_PPProductionOrdrEstFGID)
                {
                    _fK_PPProductionOrdrEstFGID = value;
                }
            }
        }
        public Nullable<DateTime> ICShipmentItemShpDate
        {
            get { return _iCShipmentItemShpDate; }
            set
            {
                if (value != this._iCShipmentItemShpDate)
                {
                    _iCShipmentItemShpDate = value;
                }
            }
        }
        public String ICShipmentItemAllocateTypeCombo
        {
            get { return _iCShipmentItemAllocateTypeCombo; }
            set
            {
                if (value != this._iCShipmentItemAllocateTypeCombo)
                {
                    _iCShipmentItemAllocateTypeCombo = value;
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
        public String ICShipmentItemDesc1
        {
            get { return _iCShipmentItemDesc1; }
            set
            {
                if (value != this._iCShipmentItemDesc1)
                {
                    _iCShipmentItemDesc1 = value;
                }
            }
        }
        public String ICShipmentItemDesc2
        {
            get { return _iCShipmentItemDesc2; }
            set
            {
                if (value != this._iCShipmentItemDesc2)
                {
                    _iCShipmentItemDesc2 = value;
                }
            }
        }
        public String ICShipmentItemDesc3
        {
            get { return _iCShipmentItemDesc3; }
            set
            {
                if (value != this._iCShipmentItemDesc3)
                {
                    _iCShipmentItemDesc3 = value;
                }
            }
        }
        public String ICShipmentItemDesc4
        {
            get { return _iCShipmentItemDesc4; }
            set
            {
                if (value != this._iCShipmentItemDesc4)
                {
                    _iCShipmentItemDesc4 = value;
                }
            }
        }
        public String ICShipmentItemDesc5
        {
            get { return _iCShipmentItemDesc5; }
            set
            {
                if (value != this._iCShipmentItemDesc5)
                {
                    _iCShipmentItemDesc5 = value;
                }
            }
        }
        public String ICShipmentItemPONumber
        {
            get { return _iCShipmentItemPONumber; }
            set
            {
                if (value != this._iCShipmentItemPONumber)
                {
                    _iCShipmentItemPONumber = value;
                }
            }
        }
        public int FK_PPProductionOrdrRelationID
        {
            get { return _fK_PPProductionOrdrRelationID; }
            set
            {
                if (value != this._fK_PPProductionOrdrRelationID)
                {
                    _fK_PPProductionOrdrRelationID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemBarQty
        {
            get { return _iCShipmentItemBarQty; }
            set
            {
                if (value != this._iCShipmentItemBarQty)
                {
                    _iCShipmentItemBarQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemRcpQty
        {
            get { return _iCShipmentItemRcpQty; }
            set
            {
                if (value != this._iCShipmentItemRcpQty)
                {
                    _iCShipmentItemRcpQty = value;
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
        public String ICShipmentItemProductPack
        {
            get { return _iCShipmentItemProductPack; }
            set
            {
                if (value != this._iCShipmentItemProductPack)
                {
                    _iCShipmentItemProductPack = value;
                }
            }
        }
        public int FK_ARCustomerProductNumberID
        {
            get { return _fK_ARCustomerProductNumberID; }
            set
            {
                if (value != this._fK_ARCustomerProductNumberID)
                {
                    _fK_ARCustomerProductNumberID = value;
                }
            }
        }
        public String ICShipmentItemPOF01Combo
        {
            get { return _iCShipmentItemPOF01Combo; }
            set
            {
                if (value != this._iCShipmentItemPOF01Combo)
                {
                    _iCShipmentItemPOF01Combo = value;
                }
            }
        }
        public String ICShipmentItemPOF02Combo
        {
            get { return _iCShipmentItemPOF02Combo; }
            set
            {
                if (value != this._iCShipmentItemPOF02Combo)
                {
                    _iCShipmentItemPOF02Combo = value;
                }
            }
        }
        public String ICShipmentItemPOF03Combo
        {
            get { return _iCShipmentItemPOF03Combo; }
            set
            {
                if (value != this._iCShipmentItemPOF03Combo)
                {
                    _iCShipmentItemPOF03Combo = value;
                }
            }
        }
        public String ICShipmentItemPOF04Combo
        {
            get { return _iCShipmentItemPOF04Combo; }
            set
            {
                if (value != this._iCShipmentItemPOF04Combo)
                {
                    _iCShipmentItemPOF04Combo = value;
                }
            }
        }
        public String ICShipmentItemPOF05Combo
        {
            get { return _iCShipmentItemPOF05Combo; }
            set
            {
                if (value != this._iCShipmentItemPOF05Combo)
                {
                    _iCShipmentItemPOF05Combo = value;
                }
            }
        }
        public String ICShipmentItemFGPOF01Combo
        {
            get { return _iCShipmentItemFGPOF01Combo; }
            set
            {
                if (value != this._iCShipmentItemFGPOF01Combo)
                {
                    _iCShipmentItemFGPOF01Combo = value;
                }
            }
        }
        public String ICShipmentItemFGPOF02Combo
        {
            get { return _iCShipmentItemFGPOF02Combo; }
            set
            {
                if (value != this._iCShipmentItemFGPOF02Combo)
                {
                    _iCShipmentItemFGPOF02Combo = value;
                }
            }
        }
        public String ICShipmentItemFGPOF03Combo
        {
            get { return _iCShipmentItemFGPOF03Combo; }
            set
            {
                if (value != this._iCShipmentItemFGPOF03Combo)
                {
                    _iCShipmentItemFGPOF03Combo = value;
                }
            }
        }
        public String ICShipmentItemFGPOF04Combo
        {
            get { return _iCShipmentItemFGPOF04Combo; }
            set
            {
                if (value != this._iCShipmentItemFGPOF04Combo)
                {
                    _iCShipmentItemFGPOF04Combo = value;
                }
            }
        }
        public String ICShipmentItemFGPOF05Combo
        {
            get { return _iCShipmentItemFGPOF05Combo; }
            set
            {
                if (value != this._iCShipmentItemFGPOF05Combo)
                {
                    _iCShipmentItemFGPOF05Combo = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemUnitPkgCBM
        {
            get { return _iCShipmentItemUnitPkgCBM; }
            set
            {
                if (value != this._iCShipmentItemUnitPkgCBM)
                {
                    _iCShipmentItemUnitPkgCBM = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemContQty
        {
            get { return _iCShipmentItemContQty; }
            set
            {
                if (value != this._iCShipmentItemContQty)
                {
                    _iCShipmentItemContQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemContFact
        {
            get { return _iCShipmentItemContFact; }
            set
            {
                if (value != this._iCShipmentItemContFact)
                {
                    _iCShipmentItemContFact = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemPkgCBM
        {
            get { return _iCShipmentItemPkgCBM; }
            set
            {
                if (value != this._iCShipmentItemPkgCBM)
                {
                    _iCShipmentItemPkgCBM = value;
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
        public int FK_ICROContID
        {
            get { return _fK_ICROContID; }
            set
            {
                if (value != this._fK_ICROContID)
                {
                    _fK_ICROContID = value;
                }
            }
        }
        public String GLTOF16Combo
        {
            get { return _gLTOF16Combo; }
            set
            {
                if (value != this._gLTOF16Combo)
                {
                    _gLTOF16Combo = value;
                }
            }
        }
        public String GLTOF17Combo
        {
            get { return _gLTOF17Combo; }
            set
            {
                if (value != this._gLTOF17Combo)
                {
                    _gLTOF17Combo = value;
                }
            }
        }
        public String GLTOF18Combo
        {
            get { return _gLTOF18Combo; }
            set
            {
                if (value != this._gLTOF18Combo)
                {
                    _gLTOF18Combo = value;
                }
            }
        }
        public String GLTOF19Combo
        {
            get { return _gLTOF19Combo; }
            set
            {
                if (value != this._gLTOF19Combo)
                {
                    _gLTOF19Combo = value;
                }
            }
        }
        public String GLTOF20Combo
        {
            get { return _gLTOF20Combo; }
            set
            {
                if (value != this._gLTOF20Combo)
                {
                    _gLTOF20Combo = value;
                }
            }
        }
        public String GLTOF21Combo
        {
            get { return _gLTOF21Combo; }
            set
            {
                if (value != this._gLTOF21Combo)
                {
                    _gLTOF21Combo = value;
                }
            }
        }
        public String GLTOF22Combo
        {
            get { return _gLTOF22Combo; }
            set
            {
                if (value != this._gLTOF22Combo)
                {
                    _gLTOF22Combo = value;
                }
            }
        }
        public String GLTOF23Combo
        {
            get { return _gLTOF23Combo; }
            set
            {
                if (value != this._gLTOF23Combo)
                {
                    _gLTOF23Combo = value;
                }
            }
        }
        public String GLTOF24Combo
        {
            get { return _gLTOF24Combo; }
            set
            {
                if (value != this._gLTOF24Combo)
                {
                    _gLTOF24Combo = value;
                }
            }
        }
        public String GLTOF25Combo
        {
            get { return _gLTOF25Combo; }
            set
            {
                if (value != this._gLTOF25Combo)
                {
                    _gLTOF25Combo = value;
                }
            }
        }
        public String GLTOF26Combo
        {
            get { return _gLTOF26Combo; }
            set
            {
                if (value != this._gLTOF26Combo)
                {
                    _gLTOF26Combo = value;
                }
            }
        }
        public String GLTOF27Combo
        {
            get { return _gLTOF27Combo; }
            set
            {
                if (value != this._gLTOF27Combo)
                {
                    _gLTOF27Combo = value;
                }
            }
        }
        public String GLTOF28Combo
        {
            get { return _gLTOF28Combo; }
            set
            {
                if (value != this._gLTOF28Combo)
                {
                    _gLTOF28Combo = value;
                }
            }
        }
        public String GLTOF29Combo
        {
            get { return _gLTOF29Combo; }
            set
            {
                if (value != this._gLTOF29Combo)
                {
                    _gLTOF29Combo = value;
                }
            }
        }
        public String GLTOF30Combo
        {
            get { return _gLTOF30Combo; }
            set
            {
                if (value != this._gLTOF30Combo)
                {
                    _gLTOF30Combo = value;
                }
            }
        }
        public String GLTOF31Combo
        {
            get { return _gLTOF31Combo; }
            set
            {
                if (value != this._gLTOF31Combo)
                {
                    _gLTOF31Combo = value;
                }
            }
        }
        public String GLTOF32Combo
        {
            get { return _gLTOF32Combo; }
            set
            {
                if (value != this._gLTOF32Combo)
                {
                    _gLTOF32Combo = value;
                }
            }
        }
        public String GLTOF33Combo
        {
            get { return _gLTOF33Combo; }
            set
            {
                if (value != this._gLTOF33Combo)
                {
                    _gLTOF33Combo = value;
                }
            }
        }
        public String GLTOF34Combo
        {
            get { return _gLTOF34Combo; }
            set
            {
                if (value != this._gLTOF34Combo)
                {
                    _gLTOF34Combo = value;
                }
            }
        }
        public String GLTOF35Combo
        {
            get { return _gLTOF35Combo; }
            set
            {
                if (value != this._gLTOF35Combo)
                {
                    _gLTOF35Combo = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICShipmentItemReturnQty
        {
            get { return _iCShipmentItemReturnQty; }
            set
            {
                if (value != this._iCShipmentItemReturnQty)
                {
                    _iCShipmentItemReturnQty = value;
                }
            }
        }

        #endregion
    }
}