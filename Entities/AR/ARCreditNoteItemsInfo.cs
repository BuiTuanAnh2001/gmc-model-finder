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
    [Table("ARCreditNoteItems")]
    public class ARCreditNoteItemsInfo : BaseInfo
    {
        public ARCreditNoteItemsInfo()
        {
        }
        #region Variables
        protected int _aRCreditNoteItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARCreditNoteID;
        protected int _fK_ICProductID;
        protected int _fK_ICStockID;
        protected int _fK_ICStockSlotID;
        protected int _fK_ICProductTypeID;
        protected int _fK_ARPriceListID;
        protected int _fK_TXTaxCodeID;
        protected int _fK_ARInvoiceID;
        protected String _aRCreditNoteItemSerialNo = String.Empty;
        protected bool _aRCreditNoteItemIsStkItm = true;
        protected String _aRCreditNoteItemTypeCombo = String.Empty;
        protected String _aRCreditNoteItemDesc = String.Empty;
        protected decimal _aRCreditNoteItemFact;
        protected String _aRSalePriceCombo = String.Empty;
        protected decimal _aRCreditNoteItemUnitPrice;
        protected decimal _aRCreditNoteItemUnitCost;
        protected decimal _aRCreditNoteItemDiscPct;
        protected decimal _aRCreditNoteItemTxPct;
        protected decimal _aRCreditNoteItemQty;
        protected decimal _aRCreditNoteItemStkQty;
        protected decimal _aRCreditNoteItemRQty;
        protected decimal _aRCreditNoteItemShpRQty;
        protected decimal _aRCreditNoteItemRStkQty;
        protected decimal _aRCreditNoteItemPrice;
        protected String _aRCreditNoteItemComment = String.Empty;
        protected decimal _aRCreditNoteItemUnitVol;
        protected decimal _aRCreditNoteItemUnitWeight;
        protected decimal _aRCreditNoteItemTxAmt;
        protected decimal _aRCreditNoteItemDiscAmt;
        protected decimal _aRCreditNoteItemNetAmt;
        protected decimal _aRCreditNoteItemAmtTot;
        protected decimal _aRCreditNoteItemCostTot;
        protected String _aRCreditNoteItemStatus = DefaultStatus;
        protected decimal _aRCreditNoteItemAmt;
        protected decimal _aRCreditNoteItemCAmt;
        protected bool _aASelected = true;
        protected int _fK_GLDebitAccountID;
        protected int _fK_GLCreditAccountID;
        protected int _fK_GLDebitVATAccountID;
        protected int _fK_GLCreditVATAccountID;
        protected decimal _aRCreditNoteItemFUnitPrice;
        protected decimal _aRCreditNoteItemFPrice;
        protected decimal _aRCreditNoteItemFTxAmt;
        protected decimal _aRCreditNoteItemFNetAmt;
        protected decimal _aRCreditNoteItemFAmtTot;
        protected decimal _aRCreditNoteItemFImpTxAmt;
        protected decimal _aRCreditNoteItemFDiscAmt;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected int _fK_ICWeightUOMID;
        protected int _fK_ICVolumeUOMID;
        protected decimal _aRCreditNoteItemWTot;
        protected decimal _aRCreditNoteItemVTot;
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
        protected int _fK_ICOrgUOMID;
        protected decimal _aRCreditNoteItemExcQty;
        protected decimal _aRCreditNoteItemOrgQty;
        protected String _gLTOF11Combo = String.Empty;
        protected String _gLTOF12Combo = String.Empty;
        protected String _gLTOF13Combo = String.Empty;
        protected String _gLTOF14Combo = String.Empty;
        protected String _gLTOF15Combo = String.Empty;
        protected decimal _aRCreditNoteItemInvoiceRFAmtTot;
        protected int _fK_ARCampaignID;
        protected decimal _aRCreditNoteItemAdjStkQty;
        protected decimal _aRCreditNoteItemAdjUnitPricePct01;
        protected decimal _aRCreditNoteItemAdjUnitPricePct02;
        protected decimal _aRCreditNoteItemAdjUnitPricePct03;
        protected decimal _aRCreditNoteItemAdjUnitPricePct04;
        protected decimal _aRCreditNoteItemAdjUnitPricePct05;
        protected decimal _aRCreditNoteItemAdjDiscPct01;
        protected decimal _aRCreditNoteItemAdjDiscPct02;
        protected decimal _aRCreditNoteItemAdjDiscPct03;
        protected decimal _aRCreditNoteItemAdjDiscPct04;
        protected decimal _aRCreditNoteItemAdjDiscPct05;
        protected decimal _aRCreditNoteItemAdjDiscFAmt01;
        protected decimal _aRCreditNoteItemAdjDiscFAmt02;
        protected decimal _aRCreditNoteItemAdjDiscFAmt03;
        protected decimal _aRCreditNoteItemAdjDiscFAmt04;
        protected decimal _aRCreditNoteItemAdjDiscFAmt05;
        protected decimal _aRCreditNoteItemAdjDiscAmt01;
        protected decimal _aRCreditNoteItemAdjDiscAmt02;
        protected decimal _aRCreditNoteItemAdjDiscAmt03;
        protected decimal _aRCreditNoteItemAdjDiscAmt04;
        protected decimal _aRCreditNoteItemAdjDiscAmt05;
        protected decimal _aRCreditNoteItemNetAmtTot;
        protected decimal _aRCreditNoteItemFNetAmtTot;
        protected decimal _aRCreditNoteItemFDiscAmtTot;
        protected decimal _aRCreditNoteItemDiscAmtTot;
        protected decimal _aRCreditNoteItemOrgFUnitPrice;
        #endregion
        [Key]
        #region Public properties
        public int ARCreditNoteItemID
        {
            get { return _aRCreditNoteItemID; }
            set
            {
                if (value != this._aRCreditNoteItemID)
                {
                    _aRCreditNoteItemID = value;
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
        public int FK_ARCreditNoteID
        {
            get { return _fK_ARCreditNoteID; }
            set
            {
                if (value != this._fK_ARCreditNoteID)
                {
                    _fK_ARCreditNoteID = value;
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
        public String ARCreditNoteItemSerialNo
        {
            get { return _aRCreditNoteItemSerialNo; }
            set
            {
                if (value != this._aRCreditNoteItemSerialNo)
                {
                    _aRCreditNoteItemSerialNo = value;
                }
            }
        }
        public bool ARCreditNoteItemIsStkItm
        {
            get { return _aRCreditNoteItemIsStkItm; }
            set
            {
                if (value != this._aRCreditNoteItemIsStkItm)
                {
                    _aRCreditNoteItemIsStkItm = value;
                }
            }
        }
        public String ARCreditNoteItemTypeCombo
        {
            get { return _aRCreditNoteItemTypeCombo; }
            set
            {
                if (value != this._aRCreditNoteItemTypeCombo)
                {
                    _aRCreditNoteItemTypeCombo = value;
                }
            }
        }
        public String ARCreditNoteItemDesc
        {
            get { return _aRCreditNoteItemDesc; }
            set
            {
                if (value != this._aRCreditNoteItemDesc)
                {
                    _aRCreditNoteItemDesc = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 12)")]
        public decimal ARCreditNoteItemFact
        {
            get { return _aRCreditNoteItemFact; }
            set
            {
                if (value != this._aRCreditNoteItemFact)
                {
                    _aRCreditNoteItemFact = value;
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
        public decimal ARCreditNoteItemUnitPrice
        {
            get { return _aRCreditNoteItemUnitPrice; }
            set
            {
                if (value != this._aRCreditNoteItemUnitPrice)
                {
                    _aRCreditNoteItemUnitPrice = value;
                }
            }
        }
        public decimal ARCreditNoteItemUnitCost
        {
            get { return _aRCreditNoteItemUnitCost; }
            set
            {
                if (value != this._aRCreditNoteItemUnitCost)
                {
                    _aRCreditNoteItemUnitCost = value;
                }
            }
        }
        public decimal ARCreditNoteItemDiscPct
        {
            get { return _aRCreditNoteItemDiscPct; }
            set
            {
                if (value != this._aRCreditNoteItemDiscPct)
                {
                    _aRCreditNoteItemDiscPct = value;
                }
            }
        }
        public decimal ARCreditNoteItemTxPct
        {
            get { return _aRCreditNoteItemTxPct; }
            set
            {
                if (value != this._aRCreditNoteItemTxPct)
                {
                    _aRCreditNoteItemTxPct = value;
                }
            }
        }
        public decimal ARCreditNoteItemQty
        {
            get { return _aRCreditNoteItemQty; }
            set
            {
                if (value != this._aRCreditNoteItemQty)
                {
                    _aRCreditNoteItemQty = value;
                }
            }
        }
        public decimal ARCreditNoteItemStkQty
        {
            get { return _aRCreditNoteItemStkQty; }
            set
            {
                if (value != this._aRCreditNoteItemStkQty)
                {
                    _aRCreditNoteItemStkQty = value;
                }
            }
        }
        public decimal ARCreditNoteItemRQty
        {
            get { return _aRCreditNoteItemRQty; }
            set
            {
                if (value != this._aRCreditNoteItemRQty)
                {
                    _aRCreditNoteItemRQty = value;
                }
            }
        }
        public decimal ARCreditNoteItemShpRQty
        {
            get { return _aRCreditNoteItemShpRQty; }
            set
            {
                if (value != this._aRCreditNoteItemShpRQty)
                {
                    _aRCreditNoteItemShpRQty = value;
                }
            }
        }
        public decimal ARCreditNoteItemRStkQty
        {
            get { return _aRCreditNoteItemRStkQty; }
            set
            {
                if (value != this._aRCreditNoteItemRStkQty)
                {
                    _aRCreditNoteItemRStkQty = value;
                }
            }
        }
        public decimal ARCreditNoteItemPrice
        {
            get { return _aRCreditNoteItemPrice; }
            set
            {
                if (value != this._aRCreditNoteItemPrice)
                {
                    _aRCreditNoteItemPrice = value;
                }
            }
        }
        public String ARCreditNoteItemComment
        {
            get { return _aRCreditNoteItemComment; }
            set
            {
                if (value != this._aRCreditNoteItemComment)
                {
                    _aRCreditNoteItemComment = value;
                }
            }
        }
        public decimal ARCreditNoteItemUnitVol
        {
            get { return _aRCreditNoteItemUnitVol; }
            set
            {
                if (value != this._aRCreditNoteItemUnitVol)
                {
                    _aRCreditNoteItemUnitVol = value;
                }
            }
        }
        public decimal ARCreditNoteItemUnitWeight
        {
            get { return _aRCreditNoteItemUnitWeight; }
            set
            {
                if (value != this._aRCreditNoteItemUnitWeight)
                {
                    _aRCreditNoteItemUnitWeight = value;
                }
            }
        }
        public decimal ARCreditNoteItemTxAmt
        {
            get { return _aRCreditNoteItemTxAmt; }
            set
            {
                if (value != this._aRCreditNoteItemTxAmt)
                {
                    _aRCreditNoteItemTxAmt = value;
                }
            }
        }
        public decimal ARCreditNoteItemDiscAmt
        {
            get { return _aRCreditNoteItemDiscAmt; }
            set
            {
                if (value != this._aRCreditNoteItemDiscAmt)
                {
                    _aRCreditNoteItemDiscAmt = value;
                }
            }
        }
        public decimal ARCreditNoteItemNetAmt
        {
            get { return _aRCreditNoteItemNetAmt; }
            set
            {
                if (value != this._aRCreditNoteItemNetAmt)
                {
                    _aRCreditNoteItemNetAmt = value;
                }
            }
        }
        public decimal ARCreditNoteItemAmtTot
        {
            get { return _aRCreditNoteItemAmtTot; }
            set
            {
                if (value != this._aRCreditNoteItemAmtTot)
                {
                    _aRCreditNoteItemAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteItemCostTot
        {
            get { return _aRCreditNoteItemCostTot; }
            set
            {
                if (value != this._aRCreditNoteItemCostTot)
                {
                    _aRCreditNoteItemCostTot = value;
                }
            }
        }
        public String ARCreditNoteItemStatus
        {
            get { return _aRCreditNoteItemStatus; }
            set
            {
                if (value != this._aRCreditNoteItemStatus)
                {
                    _aRCreditNoteItemStatus = value;
                }
            }
        }
        public decimal ARCreditNoteItemAmt
        {
            get { return _aRCreditNoteItemAmt; }
            set
            {
                if (value != this._aRCreditNoteItemAmt)
                {
                    _aRCreditNoteItemAmt = value;
                }
            }
        }
        public decimal ARCreditNoteItemCAmt
        {
            get { return _aRCreditNoteItemCAmt; }
            set
            {
                if (value != this._aRCreditNoteItemCAmt)
                {
                    _aRCreditNoteItemCAmt = value;
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
        public decimal ARCreditNoteItemFUnitPrice
        {
            get { return _aRCreditNoteItemFUnitPrice; }
            set
            {
                if (value != this._aRCreditNoteItemFUnitPrice)
                {
                    _aRCreditNoteItemFUnitPrice = value;
                }
            }
        }
        public decimal ARCreditNoteItemFPrice
        {
            get { return _aRCreditNoteItemFPrice; }
            set
            {
                if (value != this._aRCreditNoteItemFPrice)
                {
                    _aRCreditNoteItemFPrice = value;
                }
            }
        }
        public decimal ARCreditNoteItemFTxAmt
        {
            get { return _aRCreditNoteItemFTxAmt; }
            set
            {
                if (value != this._aRCreditNoteItemFTxAmt)
                {
                    _aRCreditNoteItemFTxAmt = value;
                }
            }
        }
        public decimal ARCreditNoteItemFNetAmt
        {
            get { return _aRCreditNoteItemFNetAmt; }
            set
            {
                if (value != this._aRCreditNoteItemFNetAmt)
                {
                    _aRCreditNoteItemFNetAmt = value;
                }
            }
        }
        public decimal ARCreditNoteItemFAmtTot
        {
            get { return _aRCreditNoteItemFAmtTot; }
            set
            {
                if (value != this._aRCreditNoteItemFAmtTot)
                {
                    _aRCreditNoteItemFAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteItemFImpTxAmt
        {
            get { return _aRCreditNoteItemFImpTxAmt; }
            set
            {
                if (value != this._aRCreditNoteItemFImpTxAmt)
                {
                    _aRCreditNoteItemFImpTxAmt = value;
                 }
            }
        }
        public decimal ARCreditNoteItemFDiscAmt
        {
            get { return _aRCreditNoteItemFDiscAmt; }
            set
            {
                if (value != this._aRCreditNoteItemFDiscAmt)
                {
                    _aRCreditNoteItemFDiscAmt = value;
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
        public decimal ARCreditNoteItemWTot
        {
            get { return _aRCreditNoteItemWTot; }
            set
            {
                if (value != this._aRCreditNoteItemWTot)
                {
                    _aRCreditNoteItemWTot = value;
                }
            }
        }
        public decimal ARCreditNoteItemVTot
        {
            get { return _aRCreditNoteItemVTot; }
            set
            {
                if (value != this._aRCreditNoteItemVTot)
                {
                    _aRCreditNoteItemVTot = value;
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
        public decimal ARCreditNoteItemExcQty
        {
            get { return _aRCreditNoteItemExcQty; }
            set
            {
                if (value != this._aRCreditNoteItemExcQty)
                {
                    _aRCreditNoteItemExcQty = value;
                }
            }
        }
        public decimal ARCreditNoteItemOrgQty
        {
            get { return _aRCreditNoteItemOrgQty; }
            set
            {
                if (value != this._aRCreditNoteItemOrgQty)
                {
                    _aRCreditNoteItemOrgQty = value;
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
        public decimal ARCreditNoteItemInvoiceRFAmtTot
        {
            get { return _aRCreditNoteItemInvoiceRFAmtTot; }
            set
            {
                if (value != this._aRCreditNoteItemInvoiceRFAmtTot)
                {
                    _aRCreditNoteItemInvoiceRFAmtTot = value;
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
        public decimal ARCreditNoteItemAdjStkQty
        {
            get { return _aRCreditNoteItemAdjStkQty; }
            set
            {
                if (value != this._aRCreditNoteItemAdjStkQty)
                {
                    _aRCreditNoteItemAdjStkQty = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjUnitPricePct01
        {
            get { return _aRCreditNoteItemAdjUnitPricePct01; }
            set
            {
                if (value != this._aRCreditNoteItemAdjUnitPricePct01)
                {
                    _aRCreditNoteItemAdjUnitPricePct01 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjUnitPricePct02
        {
            get { return _aRCreditNoteItemAdjUnitPricePct02; }
            set
            {
                if (value != this._aRCreditNoteItemAdjUnitPricePct02)
                {
                    _aRCreditNoteItemAdjUnitPricePct02 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjUnitPricePct03
        {
            get { return _aRCreditNoteItemAdjUnitPricePct03; }
            set
            {
                if (value != this._aRCreditNoteItemAdjUnitPricePct03)
                {
                    _aRCreditNoteItemAdjUnitPricePct03 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjUnitPricePct04
        {
            get { return _aRCreditNoteItemAdjUnitPricePct04; }
            set
            {
                if (value != this._aRCreditNoteItemAdjUnitPricePct04)
                {
                    _aRCreditNoteItemAdjUnitPricePct04 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjUnitPricePct05
        {
            get { return _aRCreditNoteItemAdjUnitPricePct05; }
            set
            {
                if (value != this._aRCreditNoteItemAdjUnitPricePct05)
                {
                    _aRCreditNoteItemAdjUnitPricePct05 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjDiscPct01
        {
            get { return _aRCreditNoteItemAdjDiscPct01; }
            set
            {
                if (value != this._aRCreditNoteItemAdjDiscPct01)
                {
                    _aRCreditNoteItemAdjDiscPct01 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjDiscPct02
        {
            get { return _aRCreditNoteItemAdjDiscPct02; }
            set
            {
                if (value != this._aRCreditNoteItemAdjDiscPct02)
                {
                    _aRCreditNoteItemAdjDiscPct02 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjDiscPct03
        {
            get { return _aRCreditNoteItemAdjDiscPct03; }
            set
            {
                if (value != this._aRCreditNoteItemAdjDiscPct03)
                {
                    _aRCreditNoteItemAdjDiscPct03 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjDiscPct04
        {
            get { return _aRCreditNoteItemAdjDiscPct04; }
            set
            {
                if (value != this._aRCreditNoteItemAdjDiscPct04)
                {
                    _aRCreditNoteItemAdjDiscPct04 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjDiscPct05
        {
            get { return _aRCreditNoteItemAdjDiscPct05; }
            set
            {
                if (value != this._aRCreditNoteItemAdjDiscPct05)
                {
                    _aRCreditNoteItemAdjDiscPct05 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjDiscFAmt01
        {
            get { return _aRCreditNoteItemAdjDiscFAmt01; }
            set
            {
                if (value != this._aRCreditNoteItemAdjDiscFAmt01)
                {
                    _aRCreditNoteItemAdjDiscFAmt01 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjDiscFAmt02
        {
            get { return _aRCreditNoteItemAdjDiscFAmt02; }
            set
            {
                if (value != this._aRCreditNoteItemAdjDiscFAmt02)
                {
                    _aRCreditNoteItemAdjDiscFAmt02 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjDiscFAmt03
        {
            get { return _aRCreditNoteItemAdjDiscFAmt03; }
            set
            {
                if (value != this._aRCreditNoteItemAdjDiscFAmt03)
                {
                    _aRCreditNoteItemAdjDiscFAmt03 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjDiscFAmt04
        {
            get { return _aRCreditNoteItemAdjDiscFAmt04; }
            set
            {
                if (value != this._aRCreditNoteItemAdjDiscFAmt04)
                {
                    _aRCreditNoteItemAdjDiscFAmt04 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjDiscFAmt05
        {
            get { return _aRCreditNoteItemAdjDiscFAmt05; }
            set
            {
                if (value != this._aRCreditNoteItemAdjDiscFAmt05)
                {
                    _aRCreditNoteItemAdjDiscFAmt05 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjDiscAmt01
        {
            get { return _aRCreditNoteItemAdjDiscAmt01; }
            set
            {
                if (value != this._aRCreditNoteItemAdjDiscAmt01)
                {
                    _aRCreditNoteItemAdjDiscAmt01 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjDiscAmt02
        {
            get { return _aRCreditNoteItemAdjDiscAmt02; }
            set
            {
                if (value != this._aRCreditNoteItemAdjDiscAmt02)
                {
                    _aRCreditNoteItemAdjDiscAmt02 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjDiscAmt03
        {
            get { return _aRCreditNoteItemAdjDiscAmt03; }
            set
            {
                if (value != this._aRCreditNoteItemAdjDiscAmt03)
                {
                    _aRCreditNoteItemAdjDiscAmt03 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjDiscAmt04
        {
            get { return _aRCreditNoteItemAdjDiscAmt04; }
            set
            {
                if (value != this._aRCreditNoteItemAdjDiscAmt04)
                {
                    _aRCreditNoteItemAdjDiscAmt04 = value;
                }
            }
        }
        public decimal ARCreditNoteItemAdjDiscAmt05
        {
            get { return _aRCreditNoteItemAdjDiscAmt05; }
            set
            {
                if (value != this._aRCreditNoteItemAdjDiscAmt05)
                {
                    _aRCreditNoteItemAdjDiscAmt05 = value;
                }
            }
        }
        public decimal ARCreditNoteItemNetAmtTot
        {
            get { return _aRCreditNoteItemNetAmtTot; }
            set
            {
                if (value != this._aRCreditNoteItemNetAmtTot)
                {
                    _aRCreditNoteItemNetAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteItemFNetAmtTot
        {
            get { return _aRCreditNoteItemFNetAmtTot; }
            set
            {
                if (value != this._aRCreditNoteItemFNetAmtTot)
                {
                    _aRCreditNoteItemFNetAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteItemFDiscAmtTot
        {
            get { return _aRCreditNoteItemFDiscAmtTot; }
            set
            {
                if (value != this._aRCreditNoteItemFDiscAmtTot)
                {
                    _aRCreditNoteItemFDiscAmtTot = value;
                 }
            }
        }
        public decimal ARCreditNoteItemDiscAmtTot
        {
            get { return _aRCreditNoteItemDiscAmtTot; }
            set
            {
                if (value != this._aRCreditNoteItemDiscAmtTot)
                {
                    _aRCreditNoteItemDiscAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteItemOrgFUnitPrice
        {
            get { return _aRCreditNoteItemOrgFUnitPrice; }
            set
            {
                if (value != this._aRCreditNoteItemOrgFUnitPrice)
                {
                    _aRCreditNoteItemOrgFUnitPrice = value;
                   }
            }
        }
        #endregion
    }
}
