using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICTransferItems")]
    public class TransferItemsEntity:BaseInfo
    {
        #region Variables
        protected int _iCTransferItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_ICTransferID;
        protected int _fK_ICProductID;
        protected int _fK_ICFromStockID;
        protected int _fK_ICToStockID;
        protected int _fK_ICTransitStockID;
        protected int _fK_ICStockSlotID;
        protected int _fK_ICProductTypeID;
        protected int _fK_ARPriceListID;
        protected int _fK_TXTaxCodeID;
        protected String _iCTransferItemSerialNo = String.Empty;
        protected bool _iCTransferItemIsStkItm = true;
        protected String _iCTransferItemType = String.Empty;
        protected String _iCTransferItemDesc = String.Empty;
        protected decimal _iCTransferItemFact;
        protected String _iCSalePriceCombo = String.Empty;
        protected decimal _iCTransferItemUnitPrice;
        protected decimal _iCTransferItemUnitCost;
        protected decimal _iCTransferItemDiscPct;
        protected decimal _iCTransferItemTxPct;
        protected decimal _iCTransferItemVolume;
        protected decimal _iCTransferItemQty;
        protected decimal _iCTransferItemStkQty;
        protected decimal _iCTransferItemRQty;
        protected decimal _iCTransferItemRStkQty;
        protected decimal _iCTransferItemPrice;
        protected String _iCTransferItemComment = String.Empty;
        protected decimal _iCTransferItemUnitVol;
        protected decimal _iCTransferItemUnitWeight;
        protected decimal _iCTransferItemTxAmt;
        protected decimal _iCTransferItemDiscAmt;
        protected decimal _iCTransferItemNetAmt;
        protected decimal _iCTransferItemAmtTot;
        protected decimal _iCTransferItemCostTot;
        protected String _iCTransferItemStatus = DefaultStatus;
        protected decimal _iCTransferItemAmt;
        protected decimal _iCTransferItemCAmt;
        protected String _iCTransferItemLotNo = String.Empty;
        protected int _fK_PPWOID;
        protected int _fK_PPPrdQCItemID;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected int _fK_ICWeightUOMID;
        protected int _fK_ICVolumeUOMID;
        protected decimal _iCTransferItemWTot;
        protected decimal _iCTransferItemVTot;
        protected Nullable<DateTime> _iCTransferItemExpireDate;
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
        protected int _fK_ICReceiptItemID;
        protected int _fK_ICFromStockSlotID;
        protected int _fK_ICToStockSlotID;
        protected int _fK_PPProductionOrdrEstRMID;
        protected String _iCTransferItemFGLotNo = String.Empty;
        protected int _fK_ICProductIDWO;
        protected String _gLTOF11Combo = String.Empty;
        protected String _gLTOF12Combo = String.Empty;
        protected String _gLTOF13Combo = String.Empty;
        protected String _gLTOF14Combo = String.Empty;
        protected String _gLTOF15Combo = String.Empty;
        protected decimal _iCTransferItemAdjStkQty;
        protected int _fK_ICTransferOSInItemID;
        protected bool _iCTransferItemIsIdentifyCost = false;
        protected decimal _iCTransferItemInvQty;
        protected String _iCTransferItemBarCodeNo = String.Empty;
        protected byte[] _iCTransferItemBarCode;
        protected decimal _iCTransferItemNeedQCQty;
        protected decimal _iCTransferItemNeedQCStkQty;
        protected int _fK_ARSOID;
        protected decimal _iCTransferItemActQty;
        protected int _fK_ICProductParentID;
        protected decimal _iCTransferItemOrgQty;
        protected int _fK_APSupplierID;
        protected String _iCTransferItemProductPack = String.Empty;
        protected String _iCTransferItemUOM = String.Empty;
        protected String _iCTransferItemStkUOM = String.Empty;
        protected String _iCTransferItemTAN = String.Empty;
        protected decimal _iCTransferItemExcQty;
        protected int _fK_ICOrgUOMID;
        protected decimal _iCTransferItemFUnitPrice;
        protected int _fK_ARCampaignID;
        protected int _fK_ARSOItemID;
        protected int _fK_PPPhaseCfgID;
        protected String _iCTransferItemPOF01Combo = String.Empty;
        protected String _iCTransferItemPOF02Combo = String.Empty;
        protected String _iCTransferItemPOF03Combo = String.Empty;
        protected String _iCTransferItemPOF04Combo = String.Empty;
        protected String _iCTransferItemPOF05Combo = String.Empty;
        protected String _iCTransferItemFGPOF01Combo = String.Empty;
        protected String _iCTransferItemFGPOF02Combo = String.Empty;
        protected String _iCTransferItemFGPOF03Combo = String.Empty;
        protected String _iCTransferItemFGPOF04Combo = String.Empty;
        protected String _iCTransferItemFGPOF05Combo = String.Empty;
        protected int _fK_APPOItemID;
        protected int _fK_APPOBOMItemID;
        protected decimal _iCTransferItemPOBOMQty;
        protected decimal _iCTransferItemPOBOMRqtQty;
        protected decimal _iCTransferItemPOBOMRQty;
        protected decimal _iCTransferItemWOQty;
        protected int _fK_ICProductRootID;
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
        protected String _iCTransferItemKeyQCCombo = String.Empty;

        #endregion
        #region Public properties
        public int ICTransferItemID
        {
            get { return _iCTransferItemID; }
            set
            {
                if (value != this._iCTransferItemID)
                {
                    _iCTransferItemID = value;
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
        public int FK_ICTransitStockID
        {
            get { return _fK_ICTransitStockID; }
            set
            {
                if (value != this._fK_ICTransitStockID)
                {
                    _fK_ICTransitStockID = value;
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
        public String ICTransferItemSerialNo
        {
            get { return _iCTransferItemSerialNo; }
            set
            {
                if (value != this._iCTransferItemSerialNo)
                {
                    _iCTransferItemSerialNo = value;
                }
            }
        }
        public bool ICTransferItemIsStkItm
        {
            get { return _iCTransferItemIsStkItm; }
            set
            {
                if (value != this._iCTransferItemIsStkItm)
                {
                    _iCTransferItemIsStkItm = value;
                }
            }
        }
        public String ICTransferItemType
        {
            get { return _iCTransferItemType; }
            set
            {
                if (value != this._iCTransferItemType)
                {
                    _iCTransferItemType = value;
                }
            }
        }
        public String ICTransferItemDesc
        {
            get { return _iCTransferItemDesc; }
            set
            {
                if (value != this._iCTransferItemDesc)
                {
                    _iCTransferItemDesc = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemFact
        {
            get { return _iCTransferItemFact; }
            set
            {
                if (value != this._iCTransferItemFact)
                {
                    _iCTransferItemFact = value;
                }
            }
        }
        public String ICSalePriceCombo
        {
            get { return _iCSalePriceCombo; }
            set
            {
                if (value != this._iCSalePriceCombo)
                {
                    _iCSalePriceCombo = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemUnitPrice
        {
            get { return _iCTransferItemUnitPrice; }
            set
            {
                if (value != this._iCTransferItemUnitPrice)
                {
                    _iCTransferItemUnitPrice = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemUnitCost
        {
            get { return _iCTransferItemUnitCost; }
            set
            {
                if (value != this._iCTransferItemUnitCost)
                {
                    _iCTransferItemUnitCost = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemDiscPct
        {
            get { return _iCTransferItemDiscPct; }
            set
            {
                if (value != this._iCTransferItemDiscPct)
                {
                    _iCTransferItemDiscPct = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemTxPct
        {
            get { return _iCTransferItemTxPct; }
            set
            {
                if (value != this._iCTransferItemTxPct)
                {
                    _iCTransferItemTxPct = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemVolume
        {
            get { return _iCTransferItemVolume; }
            set
            {
                if (value != this._iCTransferItemVolume)
                {
                    _iCTransferItemVolume = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemQty
        {
            get { return _iCTransferItemQty; }
            set
            {
                if (value != this._iCTransferItemQty)
                {
                    _iCTransferItemQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemStkQty
        {
            get { return _iCTransferItemStkQty; }
            set
            {
                if (value != this._iCTransferItemStkQty)
                {
                    _iCTransferItemStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemRQty
        {
            get { return _iCTransferItemRQty; }
            set
            {
                if (value != this._iCTransferItemRQty)
                {
                    _iCTransferItemRQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemRStkQty
        {
            get { return _iCTransferItemRStkQty; }
            set
            {
                if (value != this._iCTransferItemRStkQty)
                {
                    _iCTransferItemRStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemPrice
        {
            get { return _iCTransferItemPrice; }
            set
            {
                if (value != this._iCTransferItemPrice)
                {
                    _iCTransferItemPrice = value;
                }
            }
        }
        public String ICTransferItemComment
        {
            get { return _iCTransferItemComment; }
            set
            {
                if (value != this._iCTransferItemComment)
                {
                    _iCTransferItemComment = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemUnitVol
        {
            get { return _iCTransferItemUnitVol; }
            set
            {
                if (value != this._iCTransferItemUnitVol)
                {
                    _iCTransferItemUnitVol = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemUnitWeight
        {
            get { return _iCTransferItemUnitWeight; }
            set
            {
                if (value != this._iCTransferItemUnitWeight)
                {
                    _iCTransferItemUnitWeight = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemTxAmt
        {
            get { return _iCTransferItemTxAmt; }
            set
            {
                if (value != this._iCTransferItemTxAmt)
                {
                    _iCTransferItemTxAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemDiscAmt
        {
            get { return _iCTransferItemDiscAmt; }
            set
            {
                if (value != this._iCTransferItemDiscAmt)
                {
                    _iCTransferItemDiscAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemNetAmt
        {
            get { return _iCTransferItemNetAmt; }
            set
            {
                if (value != this._iCTransferItemNetAmt)
                {
                    _iCTransferItemNetAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemAmtTot
        {
            get { return _iCTransferItemAmtTot; }
            set
            {
                if (value != this._iCTransferItemAmtTot)
                {
                    _iCTransferItemAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemCostTot
        {
            get { return _iCTransferItemCostTot; }
            set
            {
                if (value != this._iCTransferItemCostTot)
                {
                    _iCTransferItemCostTot = value;
                }
            }
        }
        public String ICTransferItemStatus
        {
            get { return _iCTransferItemStatus; }
            set
            {
                if (value != this._iCTransferItemStatus)
                {
                    _iCTransferItemStatus = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemAmt
        {
            get { return _iCTransferItemAmt; }
            set
            {
                if (value != this._iCTransferItemAmt)
                {
                    _iCTransferItemAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemCAmt
        {
            get { return _iCTransferItemCAmt; }
            set
            {
                if (value != this._iCTransferItemCAmt)
                {
                    _iCTransferItemCAmt = value;
                }
            }
        }
        public String ICTransferItemLotNo
        {
            get { return _iCTransferItemLotNo; }
            set
            {
                if (value != this._iCTransferItemLotNo)
                {
                    _iCTransferItemLotNo = value;
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
        public int FK_PPPrdQCItemID
        {
            get { return _fK_PPPrdQCItemID; }
            set
            {
                if (value != this._fK_PPPrdQCItemID)
                {
                    _fK_PPPrdQCItemID = value;
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
        public decimal ICTransferItemWTot
        {
            get { return _iCTransferItemWTot; }
            set
            {
                if (value != this._iCTransferItemWTot)
                {
                    _iCTransferItemWTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemVTot
        {
            get { return _iCTransferItemVTot; }
            set
            {
                if (value != this._iCTransferItemVTot)
                {
                    _iCTransferItemVTot = value;
                }
            }
        }
        public Nullable<DateTime> ICTransferItemExpireDate
        {
            get { return _iCTransferItemExpireDate; }
            set
            {
                if (value != this._iCTransferItemExpireDate)
                {
                    _iCTransferItemExpireDate = value;
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
        public int FK_ICFromStockSlotID
        {
            get { return _fK_ICFromStockSlotID; }
            set
            {
                if (value != this._fK_ICFromStockSlotID)
                {
                    _fK_ICFromStockSlotID = value;
                }
            }
        }
        public int FK_ICToStockSlotID
        {
            get { return _fK_ICToStockSlotID; }
            set
            {
                if (value != this._fK_ICToStockSlotID)
                {
                    _fK_ICToStockSlotID = value;
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
        public String ICTransferItemFGLotNo
        {
            get { return _iCTransferItemFGLotNo; }
            set
            {
                if (value != this._iCTransferItemFGLotNo)
                {
                    _iCTransferItemFGLotNo = value;
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
        public decimal ICTransferItemAdjStkQty
        {
            get { return _iCTransferItemAdjStkQty; }
            set
            {
                if (value != this._iCTransferItemAdjStkQty)
                {
                    _iCTransferItemAdjStkQty = value;
                }
            }
        }
        public int FK_ICTransferOSInItemID
        {
            get { return _fK_ICTransferOSInItemID; }
            set
            {
                if (value != this._fK_ICTransferOSInItemID)
                {
                    _fK_ICTransferOSInItemID = value;
                }
            }
        }
        public bool ICTransferItemIsIdentifyCost
        {
            get { return _iCTransferItemIsIdentifyCost; }
            set
            {
                if (value != this._iCTransferItemIsIdentifyCost)
                {
                    _iCTransferItemIsIdentifyCost = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemInvQty
        {
            get { return _iCTransferItemInvQty; }
            set
            {
                if (value != this._iCTransferItemInvQty)
                {
                    _iCTransferItemInvQty = value;
                }
            }
        }
        public String ICTransferItemBarCodeNo
        {
            get { return _iCTransferItemBarCodeNo; }
            set
            {
                if (value != this._iCTransferItemBarCodeNo)
                {
                    _iCTransferItemBarCodeNo = value;
                }
            }
        }
        public byte[] ICTransferItemBarCode
        {
            get { return _iCTransferItemBarCode; }
            set
            {
                if (value != this._iCTransferItemBarCode)
                {
                    _iCTransferItemBarCode = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemNeedQCQty
        {
            get { return _iCTransferItemNeedQCQty; }
            set
            {
                if (value != this._iCTransferItemNeedQCQty)
                {
                    _iCTransferItemNeedQCQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemNeedQCStkQty
        {
            get { return _iCTransferItemNeedQCStkQty; }
            set
            {
                if (value != this._iCTransferItemNeedQCStkQty)
                {
                    _iCTransferItemNeedQCStkQty = value;
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
        public decimal ICTransferItemActQty
        {
            get { return _iCTransferItemActQty; }
            set
            {
                if (value != this._iCTransferItemActQty)
                {
                    _iCTransferItemActQty = value;
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
        public decimal ICTransferItemOrgQty
        {
            get { return _iCTransferItemOrgQty; }
            set
            {
                if (value != this._iCTransferItemOrgQty)
                {
                    _iCTransferItemOrgQty = value;
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
        public String ICTransferItemProductPack
        {
            get { return _iCTransferItemProductPack; }
            set
            {
                if (value != this._iCTransferItemProductPack)
                {
                    _iCTransferItemProductPack = value;
                }
            }
        }
        public String ICTransferItemUOM
        {
            get { return _iCTransferItemUOM; }
            set
            {
                if (value != this._iCTransferItemUOM)
                {
                    _iCTransferItemUOM = value;
                }
            }
        }
        public String ICTransferItemStkUOM
        {
            get { return _iCTransferItemStkUOM; }
            set
            {
                if (value != this._iCTransferItemStkUOM)
                {
                    _iCTransferItemStkUOM = value;
                }
            }
        }
        public String ICTransferItemTAN
        {
            get { return _iCTransferItemTAN; }
            set
            {
                if (value != this._iCTransferItemTAN)
                {
                    _iCTransferItemTAN = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemExcQty
        {
            get { return _iCTransferItemExcQty; }
            set
            {
                if (value != this._iCTransferItemExcQty)
                {
                    _iCTransferItemExcQty = value;
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
        public decimal ICTransferItemFUnitPrice
        {
            get { return _iCTransferItemFUnitPrice; }
            set
            {
                if (value != this._iCTransferItemFUnitPrice)
                {
                    _iCTransferItemFUnitPrice = value;
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
        public String ICTransferItemPOF01Combo
        {
            get { return _iCTransferItemPOF01Combo; }
            set
            {
                if (value != this._iCTransferItemPOF01Combo)
                {
                    _iCTransferItemPOF01Combo = value;
                }
            }
        }
        public String ICTransferItemPOF02Combo
        {
            get { return _iCTransferItemPOF02Combo; }
            set
            {
                if (value != this._iCTransferItemPOF02Combo)
                {
                    _iCTransferItemPOF02Combo = value;
                }
            }
        }
        public String ICTransferItemPOF03Combo
        {
            get { return _iCTransferItemPOF03Combo; }
            set
            {
                if (value != this._iCTransferItemPOF03Combo)
                {
                    _iCTransferItemPOF03Combo = value;
                }
            }
        }
        public String ICTransferItemPOF04Combo
        {
            get { return _iCTransferItemPOF04Combo; }
            set
            {
                if (value != this._iCTransferItemPOF04Combo)
                {
                    _iCTransferItemPOF04Combo = value;
                }
            }
        }
        public String ICTransferItemPOF05Combo
        {
            get { return _iCTransferItemPOF05Combo; }
            set
            {
                if (value != this._iCTransferItemPOF05Combo)
                {
                    _iCTransferItemPOF05Combo = value;
                }
            }
        }
        public String ICTransferItemFGPOF01Combo
        {
            get { return _iCTransferItemFGPOF01Combo; }
            set
            {
                if (value != this._iCTransferItemFGPOF01Combo)
                {
                    _iCTransferItemFGPOF01Combo = value;
                }
            }
        }
        public String ICTransferItemFGPOF02Combo
        {
            get { return _iCTransferItemFGPOF02Combo; }
            set
            {
                if (value != this._iCTransferItemFGPOF02Combo)
                {
                    _iCTransferItemFGPOF02Combo = value;
                }
            }
        }
        public String ICTransferItemFGPOF03Combo
        {
            get { return _iCTransferItemFGPOF03Combo; }
            set
            {
                if (value != this._iCTransferItemFGPOF03Combo)
                {
                    _iCTransferItemFGPOF03Combo = value;
                }
            }
        }
        public String ICTransferItemFGPOF04Combo
        {
            get { return _iCTransferItemFGPOF04Combo; }
            set
            {
                if (value != this._iCTransferItemFGPOF04Combo)
                {
                    _iCTransferItemFGPOF04Combo = value;
                }
            }
        }
        public String ICTransferItemFGPOF05Combo
        {
            get { return _iCTransferItemFGPOF05Combo; }
            set
            {
                if (value != this._iCTransferItemFGPOF05Combo)
                {
                    _iCTransferItemFGPOF05Combo = value;
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
        public int FK_APPOBOMItemID
        {
            get { return _fK_APPOBOMItemID; }
            set
            {
                if (value != this._fK_APPOBOMItemID)
                {
                    _fK_APPOBOMItemID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemPOBOMQty
        {
            get { return _iCTransferItemPOBOMQty; }
            set
            {
                if (value != this._iCTransferItemPOBOMQty)
                {
                    _iCTransferItemPOBOMQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemPOBOMRqtQty
        {
            get { return _iCTransferItemPOBOMRqtQty; }
            set
            {
                if (value != this._iCTransferItemPOBOMRqtQty)
                {
                    _iCTransferItemPOBOMRqtQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemPOBOMRQty
        {
            get { return _iCTransferItemPOBOMRQty; }
            set
            {
                if (value != this._iCTransferItemPOBOMRQty)
                {
                    _iCTransferItemPOBOMRQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItemWOQty
        {
            get { return _iCTransferItemWOQty; }
            set
            {
                if (value != this._iCTransferItemWOQty)
                {
                    _iCTransferItemWOQty = value;
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
        public String ICTransferItemKeyQCCombo
        {
            get { return _iCTransferItemKeyQCCombo; }
            set
            {
                if (value != this._iCTransferItemKeyQCCombo)
                {
                    _iCTransferItemKeyQCCombo = value;
                }
            }
        }

        #endregion

        public List<ICTransferItemROItems> lstICTransferItemROItems { get; set; } = new List<ICTransferItemROItems>();
        public List<ICTransferItemQCItemsInfo> ICTransferItemQCItemsList { get; set; } = new List<ICTransferItemQCItemsInfo>();

    }
}
