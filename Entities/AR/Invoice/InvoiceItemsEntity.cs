using ExpertLib;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ARInvoiceItems")]
    public partial class InvoiceItemsEntity : BaseInfo
    {
        #region Variables
        protected int _aRInvoiceItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_ARInvoiceID;
        protected int _fK_ICProductID;
        protected int _fK_ICStockID;
        protected int _fK_ICStockSlotID;
        protected int _fK_ICProductTypeID;
        protected int _fK_ARPriceListID;
        protected int _fK_TXTaxCodeID;
        protected int _fK_ARDebtNoteItemID;
        protected String _aRInvoiceItemSerialNo = String.Empty;
        protected bool _aRInvoiceItemIsStkItm = true;
        protected String _aRInvoiceItemType = String.Empty;
        protected String _aRInvoiceItemDesc = String.Empty;
        protected decimal _aRInvoiceItemFact;
        protected String _aRSalePriceCombo = String.Empty;
        protected decimal _aRInvoiceItemUnitPrice;
        protected decimal _aRInvoiceItemFUnitPrice;
        protected decimal _aRInvoiceItemUnitCost;
        protected decimal _aRInvoiceItemDiscPct;
        protected decimal _aRInvoiceItemTxPct;
        protected decimal _aRInvoiceItemQty;
        protected decimal _aRInvoiceItemStkQty;
        protected decimal _aRInvoiceItemRQty;
        protected decimal _aRInvoiceItemRStkQty;
        protected decimal _aRInvoiceItemPrice;
        protected decimal _aRInvoiceItemFPrice;
        protected String _aRInvoiceItemComment = String.Empty;
        protected decimal _aRInvoiceItemUnitVol;
        protected decimal _aRInvoiceItemUnitWeight;
        protected decimal _aRInvoiceItemTxAmt;
        protected decimal _aRInvoiceItemFTxAmt;
        protected decimal _aRInvoiceItemDiscAmt;
        protected decimal _aRInvoiceItemFDiscAmt;
        protected decimal _aRInvoiceItemNetAmt;
        protected decimal _aRInvoiceItemFNetAmt;
        protected decimal _aRInvoiceItemAmtTot;
        protected decimal _aRInvoiceItemFAmtTot;
        protected decimal _aRInvoiceItemCostTot;
        protected String _aRInvoiceItemStatus = DefaultStatus;
        protected decimal _aRInvoiceItemAmt;
        protected decimal _aRInvoiceItemCAmt;
        protected int _fK_ICShipmentItemID;
        protected decimal _aRInvoiceItemReturnQty;
        protected int _fK_ARSOItemID;
        protected int _fK_ICShipmentID;
        protected int _fK_LOShpPlanID;
        protected int _fK_ARSOID;
        protected int _aRInvoiceItemSortOrder;
        protected int _fK_GLDebitAccountID;
        protected int _fK_GLCreditAccountID;
        protected int _fK_GLDebitVATAccountID;
        protected int _fK_GLCreditVATAccountID;
        protected int _fK_ARCampaignID;
        protected int _fK_ARCampaignItemID;
        protected int _fK_ARCustomerID;
        protected Nullable<DateTime> _aRInvoiceItemExpireDate;
        protected decimal _aRInvoiceItemSaleReturnRQty;
        protected String _aRInvoiceItemSaleReturnStatusCombo = DefaultStatus;
        protected decimal _aRInvoiceInterestAmtTotBeforeTax;
        protected decimal _aRInvoiceItemFeeAmtTotBeforeTax;
        protected decimal _aRInvoiceItemLenContractGocAmt;
        protected decimal _aRInvoiceItemLenContractNetAmt;
        protected decimal _aRInvoiceItemLenContractPhiAmt;
        protected decimal _aRInvoiceItemVATOriginalAmt;
        protected decimal _aRInvoiceVATFeeInterestAmt;
        protected int _fK_ARLendContractID;
        protected int _fK_GLCostCenterID;
        protected int _fK_GLProfitCenterID;
        protected int _fK_GLVoucherItemID;
        protected int _fK_ICReceiptFeeID;
        protected int _fK_ICShipmentFeeID;
        protected int _fK_LOCarAllocateItemID;
        protected int _fK_GLCostDistID;
        protected String _aRInvoiceItemLotNo = String.Empty;
        protected int _fK_ICDistributionRuleID;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected int _fK_ICWeightUOMID;
        protected int _fK_ICVolumeUOMID;
        protected decimal _aRInvoiceItemWTot;
        protected decimal _aRInvoiceItemVTot;
        protected decimal _aRInvoiceItemOrgQty;
        protected decimal _aRInvoiceItemExcQty;
        protected int _fK_ICOrgUOMID;
        protected decimal _aRInvoiceItemCQty;
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
        protected int _fK_FAAssetID;
        protected decimal _aRInvoiceItemRefundDiscPct;
        protected decimal _aRInvoiceItemRefundDiscFAmt;
        protected decimal _aRInvoiceItemRefundDiscAmt;
        protected decimal _aRInvoiceItemAdjFUnitPrice01;
        protected decimal _aRInvoiceItemAdjFUnitPrice02;
        protected decimal _aRInvoiceItemAdjFUnitPrice03;
        protected decimal _aRInvoiceItemAdjFUnitPrice04;
        protected decimal _aRInvoiceItemAdjFUnitPrice05;
        protected decimal _aRInvoiceItemOrgFUnitPrice;
        protected String _gLTOF11Combo = String.Empty;
        protected String _gLTOF12Combo = String.Empty;
        protected String _gLTOF13Combo = String.Empty;
        protected String _gLTOF14Combo = String.Empty;
        protected String _gLTOF15Combo = String.Empty;
        protected int _fK_AdjARInvoiceItemID;
        protected decimal _aRInvoiceItemGrossWTot;
        protected decimal _aRInvoiceItemNetWTot;
        protected String _aRInvoiceItemAutoCampaignNote = String.Empty;
        protected String _aRInvoiceItemManualCampaignNote = String.Empty;
        protected decimal _aRInvoiceItemAdjStkQty;
        protected decimal _aRInvoiceItemAdjUnitPricePct01;
        protected decimal _aRInvoiceItemAdjUnitPricePct02;
        protected decimal _aRInvoiceItemAdjUnitPricePct03;
        protected decimal _aRInvoiceItemAdjUnitPricePct04;
        protected decimal _aRInvoiceItemAdjUnitPricePct05;
        protected decimal _aRInvoiceItemAdjDiscPct01;
        protected decimal _aRInvoiceItemAdjDiscPct02;
        protected decimal _aRInvoiceItemAdjDiscPct03;
        protected decimal _aRInvoiceItemAdjDiscPct04;
        protected decimal _aRInvoiceItemAdjDiscPct05;
        protected decimal _aRInvoiceItemAdjDiscFAmt01;
        protected decimal _aRInvoiceItemAdjDiscFAmt02;
        protected decimal _aRInvoiceItemAdjDiscFAmt03;
        protected decimal _aRInvoiceItemAdjDiscFAmt04;
        protected decimal _aRInvoiceItemAdjDiscFAmt05;
        protected decimal _aRInvoiceItemAdjDiscAmt01;
        protected decimal _aRInvoiceItemAdjDiscAmt02;
        protected decimal _aRInvoiceItemAdjDiscAmt03;
        protected decimal _aRInvoiceItemAdjDiscAmt04;
        protected decimal _aRInvoiceItemAdjDiscAmt05;
        protected decimal _aRInvoiceItemNetAmtTot;
        protected decimal _aRInvoiceItemFNetAmtTot;
        protected int _fK_GLBudgetID;
        protected int _fK_GLBudgetCfgID;
        protected int _fK_GLBudgetAllocateAdjID;
        protected int _fK_GLBudgetAllocateAdjItemID;
        protected int _fK_GLBudgetAllocateAdjDetailID;
        protected decimal _aRInvoiceItemFDiscAmtTot;
        protected decimal _aRInvoiceItemDiscAmtTot;
        protected String _aRInvoiceItemTAN = String.Empty;
        protected String _aRInvoiceItemPR00 = String.Empty;
        protected String _aRInvoiceItemMWST = String.Empty;
        protected String _aRInvoiceItemDesc1 = String.Empty;
        protected String _aRInvoiceItemDesc2 = String.Empty;
        protected String _aRInvoiceItemDesc3 = String.Empty;
        protected String _aRInvoiceItemDesc4 = String.Empty;
        protected String _aRInvoiceItemDesc5 = String.Empty;
        #endregion
  
        #region Public properties
        public int ARInvoiceItemID
        {
            get { return _aRInvoiceItemID; }
            set
            {
                if (value != this._aRInvoiceItemID)
                {
                    _aRInvoiceItemID = value;
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
        public int FK_ARDebtNoteItemID
        {
            get { return _fK_ARDebtNoteItemID; }
            set
            {
                if (value != this._fK_ARDebtNoteItemID)
                {
                    _fK_ARDebtNoteItemID = value;
                }
            }
        }
        public String ARInvoiceItemSerialNo
        {
            get { return _aRInvoiceItemSerialNo; }
            set
            {
                if (value != this._aRInvoiceItemSerialNo)
                {
                    _aRInvoiceItemSerialNo = value;
                }
            }
        }
        public bool ARInvoiceItemIsStkItm
        {
            get { return _aRInvoiceItemIsStkItm; }
            set
            {
                if (value != this._aRInvoiceItemIsStkItm)
                {
                    _aRInvoiceItemIsStkItm = value;
                }
            }
        }
        public String ARInvoiceItemType
        {
            get { return _aRInvoiceItemType; }
            set
            {
                if (value != this._aRInvoiceItemType)
                {
                    _aRInvoiceItemType = value;
                }
            }
        }
        public String ARInvoiceItemDesc
        {
            get { return _aRInvoiceItemDesc; }
            set
            {
                if (value != this._aRInvoiceItemDesc)
                {
                    _aRInvoiceItemDesc = value;
                }
            }
        }
        public decimal ARInvoiceItemFact
        {
            get { return _aRInvoiceItemFact; }
            set
            {
                if (value != this._aRInvoiceItemFact)
                {
                    _aRInvoiceItemFact = value;
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
        public decimal ARInvoiceItemUnitPrice
        {
            get { return _aRInvoiceItemUnitPrice; }
            set
            {
                if (value != this._aRInvoiceItemUnitPrice)
                {
                    _aRInvoiceItemUnitPrice = value;
                }
            }
        }
        public decimal ARInvoiceItemFUnitPrice
        {
            get { return _aRInvoiceItemFUnitPrice; }
            set
            {
                if (value != this._aRInvoiceItemFUnitPrice)
                {
                    _aRInvoiceItemFUnitPrice = value;
                }
            }
        }
        public decimal ARInvoiceItemUnitCost
        {
            get { return _aRInvoiceItemUnitCost; }
            set
            {
                if (value != this._aRInvoiceItemUnitCost)
                {
                    _aRInvoiceItemUnitCost = value;
                }
            }
        }
        public decimal ARInvoiceItemDiscPct
        {
            get { return _aRInvoiceItemDiscPct; }
            set
            {
                if (value != this._aRInvoiceItemDiscPct)
                {
                    _aRInvoiceItemDiscPct = value;
                }
            }
        }
        public decimal ARInvoiceItemTxPct
        {
            get { return _aRInvoiceItemTxPct; }
            set
            {
                if (value != this._aRInvoiceItemTxPct)
                {
                    _aRInvoiceItemTxPct = value;
                }
            }
        }
        public decimal ARInvoiceItemQty
        {
            get { return _aRInvoiceItemQty; }
            set
            {
                if (value != this._aRInvoiceItemQty)
                {
                    _aRInvoiceItemQty = value;
                }
            }
        }
        public decimal ARInvoiceItemStkQty
        {
            get { return _aRInvoiceItemStkQty; }
            set
            {
                if (value != this._aRInvoiceItemStkQty)
                {
                    _aRInvoiceItemStkQty = value;
                }
            }
        }
        public decimal ARInvoiceItemRQty
        {
            get { return _aRInvoiceItemRQty; }
            set
            {
                if (value != this._aRInvoiceItemRQty)
                {
                    _aRInvoiceItemRQty = value;
                }
            }
        }
        public decimal ARInvoiceItemRStkQty
        {
            get { return _aRInvoiceItemRStkQty; }
            set
            {
                if (value != this._aRInvoiceItemRStkQty)
                {
                    _aRInvoiceItemRStkQty = value;
                }
            }
        }
        public decimal ARInvoiceItemPrice
        {
            get { return _aRInvoiceItemPrice; }
            set
            {
                if (value != this._aRInvoiceItemPrice)
                {
                    _aRInvoiceItemPrice = value;
                }
            }
        }
        public decimal ARInvoiceItemFPrice
        {
            get { return _aRInvoiceItemFPrice; }
            set
            {
                if (value != this._aRInvoiceItemFPrice)
                {
                    _aRInvoiceItemFPrice = value;
                }
            }
        }
        public String ARInvoiceItemComment
        {
            get { return _aRInvoiceItemComment; }
            set
            {
                if (value != this._aRInvoiceItemComment)
                {
                    _aRInvoiceItemComment = value;
                }
            }
        }
        public decimal ARInvoiceItemUnitVol
        {
            get { return _aRInvoiceItemUnitVol; }
            set
            {
                if (value != this._aRInvoiceItemUnitVol)
                {
                    _aRInvoiceItemUnitVol = value;
                }
            }
        }
        public decimal ARInvoiceItemUnitWeight
        {
            get { return _aRInvoiceItemUnitWeight; }
            set
            {
                if (value != this._aRInvoiceItemUnitWeight)
                {
                    _aRInvoiceItemUnitWeight = value;
                }
            }
        }
        public decimal ARInvoiceItemTxAmt
        {
            get { return _aRInvoiceItemTxAmt; }
            set
            {
                if (value != this._aRInvoiceItemTxAmt)
                {
                    _aRInvoiceItemTxAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemFTxAmt
        {
            get { return _aRInvoiceItemFTxAmt; }
            set
            {
                if (value != this._aRInvoiceItemFTxAmt)
                {
                    _aRInvoiceItemFTxAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemDiscAmt
        {
            get { return _aRInvoiceItemDiscAmt; }
            set
            {
                if (value != this._aRInvoiceItemDiscAmt)
                {
                    _aRInvoiceItemDiscAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemFDiscAmt
        {
            get { return _aRInvoiceItemFDiscAmt; }
            set
            {
                if (value != this._aRInvoiceItemFDiscAmt)
                {
                    _aRInvoiceItemFDiscAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemNetAmt
        {
            get { return _aRInvoiceItemNetAmt; }
            set
            {
                if (value != this._aRInvoiceItemNetAmt)
                {
                    _aRInvoiceItemNetAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemFNetAmt
        {
            get { return _aRInvoiceItemFNetAmt; }
            set
            {
                if (value != this._aRInvoiceItemFNetAmt)
                {
                    _aRInvoiceItemFNetAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemAmtTot
        {
            get { return _aRInvoiceItemAmtTot; }
            set
            {
                if (value != this._aRInvoiceItemAmtTot)
                {
                    _aRInvoiceItemAmtTot = value;
                }
            }
        }
        public decimal ARInvoiceItemFAmtTot
        {
            get { return _aRInvoiceItemFAmtTot; }
            set
            {
                if (value != this._aRInvoiceItemFAmtTot)
                {
                    _aRInvoiceItemFAmtTot = value;
                }
            }
        }
        public decimal ARInvoiceItemCostTot
        {
            get { return _aRInvoiceItemCostTot; }
            set
            {
                if (value != this._aRInvoiceItemCostTot)
                {
                    _aRInvoiceItemCostTot = value;
                }
            }
        }
        public String ARInvoiceItemStatus
        {
            get { return _aRInvoiceItemStatus; }
            set
            {
                if (value != this._aRInvoiceItemStatus)
                {
                    _aRInvoiceItemStatus = value;
                }
            }
        }
        public decimal ARInvoiceItemAmt
        {
            get { return _aRInvoiceItemAmt; }
            set
            {
                if (value != this._aRInvoiceItemAmt)
                {
                    _aRInvoiceItemAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemCAmt
        {
            get { return _aRInvoiceItemCAmt; }
            set
            {
                if (value != this._aRInvoiceItemCAmt)
                {
                    _aRInvoiceItemCAmt = value;
                }
            }
        }
        public int FK_ICShipmentItemID
        {
            get { return _fK_ICShipmentItemID; }
            set
            {
                if (value != this._fK_ICShipmentItemID)
                {
                    _fK_ICShipmentItemID = value;
                }
            }
        }
        public decimal ARInvoiceItemReturnQty
        {
            get { return _aRInvoiceItemReturnQty; }
            set
            {
                if (value != this._aRInvoiceItemReturnQty)
                {
                    _aRInvoiceItemReturnQty = value;
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
        public int ARInvoiceItemSortOrder
        {
            get { return _aRInvoiceItemSortOrder; }
            set
            {
                if (value != this._aRInvoiceItemSortOrder)
                {
                    _aRInvoiceItemSortOrder = value;
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
        public Nullable<DateTime> ARInvoiceItemExpireDate
        {
            get { return _aRInvoiceItemExpireDate; }
            set
            {
                if (value != this._aRInvoiceItemExpireDate)
                {
                    _aRInvoiceItemExpireDate = value;
                }
            }
        }
        public decimal ARInvoiceItemSaleReturnRQty
        {
            get { return _aRInvoiceItemSaleReturnRQty; }
            set
            {
                if (value != this._aRInvoiceItemSaleReturnRQty)
                {
                    _aRInvoiceItemSaleReturnRQty = value;
                }
            }
        }
        public String ARInvoiceItemSaleReturnStatusCombo
        {
            get { return _aRInvoiceItemSaleReturnStatusCombo; }
            set
            {
                if (value != this._aRInvoiceItemSaleReturnStatusCombo)
                {
                    _aRInvoiceItemSaleReturnStatusCombo = value;
                }
            }
        }
        public decimal ARInvoiceInterestAmtTotBeforeTax
        {
            get { return _aRInvoiceInterestAmtTotBeforeTax; }
            set
            {
                if (value != this._aRInvoiceInterestAmtTotBeforeTax)
                {
                    _aRInvoiceInterestAmtTotBeforeTax = value;
                }
            }
        }
        public decimal ARInvoiceItemFeeAmtTotBeforeTax
        {
            get { return _aRInvoiceItemFeeAmtTotBeforeTax; }
            set
            {
                if (value != this._aRInvoiceItemFeeAmtTotBeforeTax)
                {
                    _aRInvoiceItemFeeAmtTotBeforeTax = value;
                }
            }
        }
        public decimal ARInvoiceItemLenContractGocAmt
        {
            get { return _aRInvoiceItemLenContractGocAmt; }
            set
            {
                if (value != this._aRInvoiceItemLenContractGocAmt)
                {
                    _aRInvoiceItemLenContractGocAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemLenContractNetAmt
        {
            get { return _aRInvoiceItemLenContractNetAmt; }
            set
            {
                if (value != this._aRInvoiceItemLenContractNetAmt)
                {
                    _aRInvoiceItemLenContractNetAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemLenContractPhiAmt
        {
            get { return _aRInvoiceItemLenContractPhiAmt; }
            set
            {
                if (value != this._aRInvoiceItemLenContractPhiAmt)
                {
                    _aRInvoiceItemLenContractPhiAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemVATOriginalAmt
        {
            get { return _aRInvoiceItemVATOriginalAmt; }
            set
            {
                if (value != this._aRInvoiceItemVATOriginalAmt)
                {
                    _aRInvoiceItemVATOriginalAmt = value;
                }
            }
        }
        public decimal ARInvoiceVATFeeInterestAmt
        {
            get { return _aRInvoiceVATFeeInterestAmt; }
            set
            {
                if (value != this._aRInvoiceVATFeeInterestAmt)
                {
                    _aRInvoiceVATFeeInterestAmt = value;
                }
            }
        }
        public int FK_ARLendContractID
        {
            get { return _fK_ARLendContractID; }
            set
            {
                if (value != this._fK_ARLendContractID)
                {
                    _fK_ARLendContractID = value;
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
        public int FK_GLProfitCenterID
        {
            get { return _fK_GLProfitCenterID; }
            set
            {
                if (value != this._fK_GLProfitCenterID)
                {
                    _fK_GLProfitCenterID = value;
                }
            }
        }
        public int FK_GLVoucherItemID
        {
            get { return _fK_GLVoucherItemID; }
            set
            {
                if (value != this._fK_GLVoucherItemID)
                {
                    _fK_GLVoucherItemID = value;
                }
            }
        }
        public int FK_ICReceiptFeeID
        {
            get { return _fK_ICReceiptFeeID; }
            set
            {
                if (value != this._fK_ICReceiptFeeID)
                {
                    _fK_ICReceiptFeeID = value;
                }
            }
        }
        public int FK_ICShipmentFeeID
        {
            get { return _fK_ICShipmentFeeID; }
            set
            {
                if (value != this._fK_ICShipmentFeeID)
                {
                    _fK_ICShipmentFeeID = value;
                }
            }
        }
        public int FK_LOCarAllocateItemID
        {
            get { return _fK_LOCarAllocateItemID; }
            set
            {
                if (value != this._fK_LOCarAllocateItemID)
                {
                    _fK_LOCarAllocateItemID = value;
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
        public String ARInvoiceItemLotNo
        {
            get { return _aRInvoiceItemLotNo; }
            set
            {
                if (value != this._aRInvoiceItemLotNo)
                {
                    _aRInvoiceItemLotNo = value;
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
        public decimal ARInvoiceItemWTot
        {
            get { return _aRInvoiceItemWTot; }
            set
            {
                if (value != this._aRInvoiceItemWTot)
                {
                    _aRInvoiceItemWTot = value;
                }
            }
        }
        public decimal ARInvoiceItemVTot
        {
            get { return _aRInvoiceItemVTot; }
            set
            {
                if (value != this._aRInvoiceItemVTot)
                {
                    _aRInvoiceItemVTot = value;
                }
            }
        }
        public decimal ARInvoiceItemOrgQty
        {
            get { return _aRInvoiceItemOrgQty; }
            set
            {
                if (value != this._aRInvoiceItemOrgQty)
                {
                    _aRInvoiceItemOrgQty = value;
                }
            }
        }
        public decimal ARInvoiceItemExcQty
        {
            get { return _aRInvoiceItemExcQty; }
            set
            {
                if (value != this._aRInvoiceItemExcQty)
                {
                    _aRInvoiceItemExcQty = value;
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
        public decimal ARInvoiceItemCQty
        {
            get { return _aRInvoiceItemCQty; }
            set
            {
                if (value != this._aRInvoiceItemCQty)
                {
                    _aRInvoiceItemCQty = value;
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
        public decimal ARInvoiceItemRefundDiscPct
        {
            get { return _aRInvoiceItemRefundDiscPct; }
            set
            {
                if (value != this._aRInvoiceItemRefundDiscPct)
                {
                    _aRInvoiceItemRefundDiscPct = value;
                }
            }
        }
        public decimal ARInvoiceItemRefundDiscFAmt
        {
            get { return _aRInvoiceItemRefundDiscFAmt; }
            set
            {
                if (value != this._aRInvoiceItemRefundDiscFAmt)
                {
                    _aRInvoiceItemRefundDiscFAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemRefundDiscAmt
        {
            get { return _aRInvoiceItemRefundDiscAmt; }
            set
            {
                if (value != this._aRInvoiceItemRefundDiscAmt)
                {
                    _aRInvoiceItemRefundDiscAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjFUnitPrice01
        {
            get { return _aRInvoiceItemAdjFUnitPrice01; }
            set
            {
                if (value != this._aRInvoiceItemAdjFUnitPrice01)
                {
                    _aRInvoiceItemAdjFUnitPrice01 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjFUnitPrice02
        {
            get { return _aRInvoiceItemAdjFUnitPrice02; }
            set
            {
                if (value != this._aRInvoiceItemAdjFUnitPrice02)
                {
                    _aRInvoiceItemAdjFUnitPrice02 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjFUnitPrice03
        {
            get { return _aRInvoiceItemAdjFUnitPrice03; }
            set
            {
                if (value != this._aRInvoiceItemAdjFUnitPrice03)
                {
                    _aRInvoiceItemAdjFUnitPrice03 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjFUnitPrice04
        {
            get { return _aRInvoiceItemAdjFUnitPrice04; }
            set
            {
                if (value != this._aRInvoiceItemAdjFUnitPrice04)
                {
                    _aRInvoiceItemAdjFUnitPrice04 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjFUnitPrice05
        {
            get { return _aRInvoiceItemAdjFUnitPrice05; }
            set
            {
                if (value != this._aRInvoiceItemAdjFUnitPrice05)
                {
                    _aRInvoiceItemAdjFUnitPrice05 = value;
                }
            }
        }
        public decimal ARInvoiceItemOrgFUnitPrice
        {
            get { return _aRInvoiceItemOrgFUnitPrice; }
            set
            {
                if (value != this._aRInvoiceItemOrgFUnitPrice)
                {
                    _aRInvoiceItemOrgFUnitPrice = value;
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
        public int FK_AdjARInvoiceItemID
        {
            get { return _fK_AdjARInvoiceItemID; }
            set
            {
                if (value != this._fK_AdjARInvoiceItemID)
                {
                    _fK_AdjARInvoiceItemID = value;
                }
            }
        }
        public decimal ARInvoiceItemGrossWTot
        {
            get { return _aRInvoiceItemGrossWTot; }
            set
            {
                if (value != this._aRInvoiceItemGrossWTot)
                {
                    _aRInvoiceItemGrossWTot = value;
                }
            }
        }
        public decimal ARInvoiceItemNetWTot
        {
            get { return _aRInvoiceItemNetWTot; }
            set
            {
                if (value != this._aRInvoiceItemNetWTot)
                {
                    _aRInvoiceItemNetWTot = value;
                }
            }
        }
        public String ARInvoiceItemAutoCampaignNote
        {
            get { return _aRInvoiceItemAutoCampaignNote; }
            set
            {
                if (value != this._aRInvoiceItemAutoCampaignNote)
                {
                    _aRInvoiceItemAutoCampaignNote = value;
                }
            }
        }
        public String ARInvoiceItemManualCampaignNote
        {
            get { return _aRInvoiceItemManualCampaignNote; }
            set
            {
                if (value != this._aRInvoiceItemManualCampaignNote)
                {
                    _aRInvoiceItemManualCampaignNote = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjStkQty
        {
            get { return _aRInvoiceItemAdjStkQty; }
            set
            {
                if (value != this._aRInvoiceItemAdjStkQty)
                {
                    _aRInvoiceItemAdjStkQty = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjUnitPricePct01
        {
            get { return _aRInvoiceItemAdjUnitPricePct01; }
            set
            {
                if (value != this._aRInvoiceItemAdjUnitPricePct01)
                {
                    _aRInvoiceItemAdjUnitPricePct01 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjUnitPricePct02
        {
            get { return _aRInvoiceItemAdjUnitPricePct02; }
            set
            {
                if (value != this._aRInvoiceItemAdjUnitPricePct02)
                {
                    _aRInvoiceItemAdjUnitPricePct02 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjUnitPricePct03
        {
            get { return _aRInvoiceItemAdjUnitPricePct03; }
            set
            {
                if (value != this._aRInvoiceItemAdjUnitPricePct03)
                {
                    _aRInvoiceItemAdjUnitPricePct03 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjUnitPricePct04
        {
            get { return _aRInvoiceItemAdjUnitPricePct04; }
            set
            {
                if (value != this._aRInvoiceItemAdjUnitPricePct04)
                {
                    _aRInvoiceItemAdjUnitPricePct04 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjUnitPricePct05
        {
            get { return _aRInvoiceItemAdjUnitPricePct05; }
            set
            {
                if (value != this._aRInvoiceItemAdjUnitPricePct05)
                {
                    _aRInvoiceItemAdjUnitPricePct05 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjDiscPct01
        {
            get { return _aRInvoiceItemAdjDiscPct01; }
            set
            {
                if (value != this._aRInvoiceItemAdjDiscPct01)
                {
                    _aRInvoiceItemAdjDiscPct01 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjDiscPct02
        {
            get { return _aRInvoiceItemAdjDiscPct02; }
            set
            {
                if (value != this._aRInvoiceItemAdjDiscPct02)
                {
                    _aRInvoiceItemAdjDiscPct02 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjDiscPct03
        {
            get { return _aRInvoiceItemAdjDiscPct03; }
            set
            {
                if (value != this._aRInvoiceItemAdjDiscPct03)
                {
                    _aRInvoiceItemAdjDiscPct03 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjDiscPct04
        {
            get { return _aRInvoiceItemAdjDiscPct04; }
            set
            {
                if (value != this._aRInvoiceItemAdjDiscPct04)
                {
                    _aRInvoiceItemAdjDiscPct04 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjDiscPct05
        {
            get { return _aRInvoiceItemAdjDiscPct05; }
            set
            {
                if (value != this._aRInvoiceItemAdjDiscPct05)
                {
                    _aRInvoiceItemAdjDiscPct05 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjDiscFAmt01
        {
            get { return _aRInvoiceItemAdjDiscFAmt01; }
            set
            {
                if (value != this._aRInvoiceItemAdjDiscFAmt01)
                {
                    _aRInvoiceItemAdjDiscFAmt01 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjDiscFAmt02
        {
            get { return _aRInvoiceItemAdjDiscFAmt02; }
            set
            {
                if (value != this._aRInvoiceItemAdjDiscFAmt02)
                {
                    _aRInvoiceItemAdjDiscFAmt02 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjDiscFAmt03
        {
            get { return _aRInvoiceItemAdjDiscFAmt03; }
            set
            {
                if (value != this._aRInvoiceItemAdjDiscFAmt03)
                {
                    _aRInvoiceItemAdjDiscFAmt03 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjDiscFAmt04
        {
            get { return _aRInvoiceItemAdjDiscFAmt04; }
            set
            {
                if (value != this._aRInvoiceItemAdjDiscFAmt04)
                {
                    _aRInvoiceItemAdjDiscFAmt04 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjDiscFAmt05
        {
            get { return _aRInvoiceItemAdjDiscFAmt05; }
            set
            {
                if (value != this._aRInvoiceItemAdjDiscFAmt05)
                {
                    _aRInvoiceItemAdjDiscFAmt05 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjDiscAmt01
        {
            get { return _aRInvoiceItemAdjDiscAmt01; }
            set
            {
                if (value != this._aRInvoiceItemAdjDiscAmt01)
                {
                    _aRInvoiceItemAdjDiscAmt01 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjDiscAmt02
        {
            get { return _aRInvoiceItemAdjDiscAmt02; }
            set
            {
                if (value != this._aRInvoiceItemAdjDiscAmt02)
                {
                    _aRInvoiceItemAdjDiscAmt02 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjDiscAmt03
        {
            get { return _aRInvoiceItemAdjDiscAmt03; }
            set
            {
                if (value != this._aRInvoiceItemAdjDiscAmt03)
                {
                    _aRInvoiceItemAdjDiscAmt03 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjDiscAmt04
        {
            get { return _aRInvoiceItemAdjDiscAmt04; }
            set
            {
                if (value != this._aRInvoiceItemAdjDiscAmt04)
                {
                    _aRInvoiceItemAdjDiscAmt04 = value;
                }
            }
        }
        public decimal ARInvoiceItemAdjDiscAmt05
        {
            get { return _aRInvoiceItemAdjDiscAmt05; }
            set
            {
                if (value != this._aRInvoiceItemAdjDiscAmt05)
                {
                    _aRInvoiceItemAdjDiscAmt05 = value;
                }
            }
        }
        public decimal ARInvoiceItemNetAmtTot
        {
            get { return _aRInvoiceItemNetAmtTot; }
            set
            {
                if (value != this._aRInvoiceItemNetAmtTot)
                {
                    _aRInvoiceItemNetAmtTot = value;
                }
            }
        }
        public decimal ARInvoiceItemFNetAmtTot
        {
            get { return _aRInvoiceItemFNetAmtTot; }
            set
            {
                if (value != this._aRInvoiceItemFNetAmtTot)
                {
                    _aRInvoiceItemFNetAmtTot = value;
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
        public decimal ARInvoiceItemFDiscAmtTot
        {
            get { return _aRInvoiceItemFDiscAmtTot; }
            set
            {
                if (value != this._aRInvoiceItemFDiscAmtTot)
                {
                    _aRInvoiceItemFDiscAmtTot = value;
                }
            }
        }
        public decimal ARInvoiceItemDiscAmtTot
        {
            get { return _aRInvoiceItemDiscAmtTot; }
            set
            {
                if (value != this._aRInvoiceItemDiscAmtTot)
                {
                    _aRInvoiceItemDiscAmtTot = value;
                }
            }
        }
        public String ARInvoiceItemTAN
        {
            get { return _aRInvoiceItemTAN; }
            set
            {
                if (value != this._aRInvoiceItemTAN)
                {
                    _aRInvoiceItemTAN = value;
                }
            }
        }
        public String ARInvoiceItemPR00
        {
            get { return _aRInvoiceItemPR00; }
            set
            {
                if (value != this._aRInvoiceItemPR00)
                {
                    _aRInvoiceItemPR00 = value;
                }
            }
        }
        public String ARInvoiceItemMWST
        {
            get { return _aRInvoiceItemMWST; }
            set
            {
                if (value != this._aRInvoiceItemMWST)
                {
                    _aRInvoiceItemMWST = value;
                }
            }
        }
        public String ARInvoiceItemDesc1
        {
            get { return _aRInvoiceItemDesc1; }
            set
            {
                if (value != this._aRInvoiceItemDesc1)
                {
                    _aRInvoiceItemDesc1 = value;
                }
            }
        }
        public String ARInvoiceItemDesc2
        {
            get { return _aRInvoiceItemDesc2; }
            set
            {
                if (value != this._aRInvoiceItemDesc2)
                {
                    _aRInvoiceItemDesc2 = value;
                }
            }
        }
        public String ARInvoiceItemDesc3
        {
            get { return _aRInvoiceItemDesc3; }
            set
            {
                if (value != this._aRInvoiceItemDesc3)
                {
                    _aRInvoiceItemDesc3 = value;
                }
            }
        }
        public String ARInvoiceItemDesc4
        {
            get { return _aRInvoiceItemDesc4; }
            set
            {
                if (value != this._aRInvoiceItemDesc4)
                {
                    _aRInvoiceItemDesc4 = value;
                }
            }
        }
        public String ARInvoiceItemDesc5
        {
            get { return _aRInvoiceItemDesc5; }
            set
            {
                if (value != this._aRInvoiceItemDesc5)
                {
                    _aRInvoiceItemDesc5 = value;
                }
            }
        }
        #endregion
    }
}