using ExpertLib;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{

    [Table("ARInvoiceItemKits")]
    public class ARInvoiceItemKitsInfo : BaseInfo
    {
        public ARInvoiceItemKitsInfo()
        {
        }
        #region Variables
        protected int _aRInvoiceItemKitID;
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
        protected String _aRInvoiceItemKitSerialNo = String.Empty;
        protected bool _aRInvoiceItemKitIsStkItm = true;
        protected String _aRInvoiceItemKitType = String.Empty;
        protected String _aRInvoiceItemKitDesc = String.Empty;
        protected decimal _aRInvoiceItemKitFact;
        protected String _aRSalePriceCombo = String.Empty;
        protected decimal _aRInvoiceItemKitUnitPrice;
        protected decimal _aRInvoiceItemKitFUnitPrice;
        protected decimal _aRInvoiceItemKitUnitCost;
        protected decimal _aRInvoiceItemKitDiscPct;
        protected decimal _aRInvoiceItemKitTxPct;
        protected decimal _aRInvoiceItemKitQty;
        protected decimal _aRInvoiceItemKitStkQty;
        protected decimal _aRInvoiceItemKitRQty;
        protected decimal _aRInvoiceItemKitRStkQty;
        protected decimal _aRInvoiceItemKitPrice;
        protected decimal _aRInvoiceItemKitFPrice;
        protected String _aRInvoiceItemKitComment = String.Empty;
        protected decimal _aRInvoiceItemKitUnitVol;
        protected decimal _aRInvoiceItemKitUnitWeight;
        protected decimal _aRInvoiceItemKitTxAmt;
        protected decimal _aRInvoiceItemKitFTxAmt;
        protected decimal _aRInvoiceItemKitDiscAmt;
        protected decimal _aRInvoiceItemKitFDiscAmt;
        protected decimal _aRInvoiceItemKitNetAmt;
        protected decimal _aRInvoiceItemKitFNetAmt;
        protected decimal _aRInvoiceItemKitAmtTot;
        protected decimal _aRInvoiceItemKitFAmtTot;
        protected decimal _aRInvoiceItemKitCostTot;
        protected String _aRInvoiceItemKitStatus = DefaultStatus;
        protected decimal _aRInvoiceItemKitAmt;
        protected decimal _aRInvoiceItemKitCAmt;
        protected int _fK_ICShipmentItemID;
        protected decimal _aRInvoiceItemKitReturnQty;
        protected int _fK_ARSOItemID;
        protected int _fK_ICShipmentID;
        protected int _fK_LOShpPlanID;
        protected int _fK_ARSOID;
        protected int _aRInvoiceItemKitSortOrder;
        protected int _fK_GLDebitAccountID;
        protected int _fK_GLCreditAccountID;
        protected int _fK_GLDebitVATAccountID;
        protected int _fK_GLCreditVATAccountID;
        protected int _fK_ARCampaignID;
        protected int _fK_ARCampaignItemID;
        protected int _fK_ARCustomerID;
        protected Nullable<DateTime> _aRInvoiceItemKitExpireDate;
        protected decimal _aRInvoiceItemKitSaleReturnRQty;
        protected String _aRInvoiceItemKitSaleReturnStatusCombo = DefaultStatus;
        protected decimal _aRInvoiceInterestAmtTotBeforeTax;
        protected decimal _aRInvoiceItemKitFeeAmtTotBeforeTax;
        protected decimal _aRInvoiceItemKitLenContractGocAmt;
        protected decimal _aRInvoiceItemKitLenContractNetAmt;
        protected decimal _aRInvoiceItemKitLenContractPhiAmt;
        protected decimal _aRInvoiceItemKitVATOriginalAmt;
        protected decimal _aRInvoiceVATFeeInterestAmt;
        protected int _fK_ARLendContractID;
        protected int _fK_GLCostCenterID;
        protected int _fK_GLProfitCenterID;
        protected int _fK_GLVoucherItemID;
        protected int _fK_ICReceiptFeeID;
        protected int _fK_ICShipmentFeeID;
        protected int _fK_LOCarAllocateItemID;
        protected int _fK_GLCostDistID;
        protected String _aRInvoiceItemKitLotNo = String.Empty;
        protected int _fK_ICDistributionRuleID;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected int _fK_ICWeightUOMID;
        protected int _fK_ICVolumeUOMID;
        protected decimal _aRInvoiceItemKitWTot;
        protected decimal _aRInvoiceItemKitVTot;
        protected decimal _aRInvoiceItemKitOrgQty;
        protected decimal _aRInvoiceItemKitExcQty;
        protected int _fK_ICOrgUOMID;
        protected decimal _aRInvoiceItemKitCQty;
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
        protected decimal _aRInvoiceItemKitRefundDiscPct;
        protected decimal _aRInvoiceItemKitRefundDiscFAmt;
        protected decimal _aRInvoiceItemKitRefundDiscAmt;
        protected decimal _aRInvoiceItemKitAdjFUnitPrice01;
        protected decimal _aRInvoiceItemKitAdjFUnitPrice02;
        protected decimal _aRInvoiceItemKitAdjFUnitPrice03;
        protected decimal _aRInvoiceItemKitAdjFUnitPrice04;
        protected decimal _aRInvoiceItemKitAdjFUnitPrice05;
        protected decimal _aRInvoiceItemKitOrgFUnitPrice;
        protected String _gLTOF11Combo = String.Empty;
        protected String _gLTOF12Combo = String.Empty;
        protected String _gLTOF13Combo = String.Empty;
        protected String _gLTOF14Combo = String.Empty;
        protected String _gLTOF15Combo = String.Empty;
        protected int _fK_AdjARInvoiceItemKitID;
        protected decimal _aRInvoiceItemKitGrossWTot;
        protected decimal _aRInvoiceItemKitNetWTot;
        protected String _aRInvoiceItemKitAutoCampaignNote = String.Empty;
        protected String _aRInvoiceItemKitManualCampaignNote = String.Empty;
        protected decimal _aRInvoiceItemKitAdjStkQty;
        protected decimal _aRInvoiceItemKitAdjUnitPricePct01;
        protected decimal _aRInvoiceItemKitAdjUnitPricePct02;
        protected decimal _aRInvoiceItemKitAdjUnitPricePct03;
        protected decimal _aRInvoiceItemKitAdjUnitPricePct04;
        protected decimal _aRInvoiceItemKitAdjUnitPricePct05;
        protected decimal _aRInvoiceItemKitAdjDiscPct01;
        protected decimal _aRInvoiceItemKitAdjDiscPct02;
        protected decimal _aRInvoiceItemKitAdjDiscPct03;
        protected decimal _aRInvoiceItemKitAdjDiscPct04;
        protected decimal _aRInvoiceItemKitAdjDiscPct05;
        protected decimal _aRInvoiceItemKitAdjDiscFAmt01;
        protected decimal _aRInvoiceItemKitAdjDiscFAmt02;
        protected decimal _aRInvoiceItemKitAdjDiscFAmt03;
        protected decimal _aRInvoiceItemKitAdjDiscFAmt04;
        protected decimal _aRInvoiceItemKitAdjDiscFAmt05;
        protected decimal _aRInvoiceItemKitAdjDiscAmt01;
        protected decimal _aRInvoiceItemKitAdjDiscAmt02;
        protected decimal _aRInvoiceItemKitAdjDiscAmt03;
        protected decimal _aRInvoiceItemKitAdjDiscAmt04;
        protected decimal _aRInvoiceItemKitAdjDiscAmt05;
        protected decimal _aRInvoiceItemKitNetAmtTot;
        protected decimal _aRInvoiceItemKitFNetAmtTot;
        protected int _fK_GLBudgetID;
        protected int _fK_GLBudgetCfgID;
        protected int _fK_GLBudgetAllocateAdjID;
        protected int _fK_GLBudgetAllocateAdjItemID;
        protected int _fK_GLBudgetAllocateAdjDetailID;
        protected decimal _aRInvoiceItemKitFDiscAmtTot;
        protected decimal _aRInvoiceItemKitDiscAmtTot;
        protected String _aRInvoiceItemKitTAN = String.Empty;
        protected String _aRInvoiceItemKitPR00 = String.Empty;
        protected String _aRInvoiceItemKitMWST = String.Empty;

        #endregion
        [Key]
        #region Public properties
        public int ARInvoiceItemKitID
        {
            get { return _aRInvoiceItemKitID; }
            set
            {
                if (value != this._aRInvoiceItemKitID)
                {
                    _aRInvoiceItemKitID = value;
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
        public String ARInvoiceItemKitSerialNo
        {
            get { return _aRInvoiceItemKitSerialNo; }
            set
            {
                if (value != this._aRInvoiceItemKitSerialNo)
                {
                    _aRInvoiceItemKitSerialNo = value;
                }
            }
        }
        public bool ARInvoiceItemKitIsStkItm
        {
            get { return _aRInvoiceItemKitIsStkItm; }
            set
            {
                if (value != this._aRInvoiceItemKitIsStkItm)
                {
                    _aRInvoiceItemKitIsStkItm = value;
                }
            }
        }
        public String ARInvoiceItemKitType
        {
            get { return _aRInvoiceItemKitType; }
            set
            {
                if (value != this._aRInvoiceItemKitType)
                {
                    _aRInvoiceItemKitType = value;
                }
            }
        }
        public String ARInvoiceItemKitDesc
        {
            get { return _aRInvoiceItemKitDesc; }
            set
            {
                if (value != this._aRInvoiceItemKitDesc)
                {
                    _aRInvoiceItemKitDesc = value;
                }
            }
        }
        public decimal ARInvoiceItemKitFact
        {
            get { return _aRInvoiceItemKitFact; }
            set
            {
                if (value != this._aRInvoiceItemKitFact)
                {
                    _aRInvoiceItemKitFact = value;
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
        public decimal ARInvoiceItemKitUnitPrice
        {
            get { return _aRInvoiceItemKitUnitPrice; }
            set
            {
                if (value != this._aRInvoiceItemKitUnitPrice)
                {
                    _aRInvoiceItemKitUnitPrice = value;
                }
            }
        }
        public decimal ARInvoiceItemKitFUnitPrice
        {
            get { return _aRInvoiceItemKitFUnitPrice; }
            set
            {
                if (value != this._aRInvoiceItemKitFUnitPrice)
                {
                    _aRInvoiceItemKitFUnitPrice = value;
                }
            }
        }
        public decimal ARInvoiceItemKitUnitCost
        {
            get { return _aRInvoiceItemKitUnitCost; }
            set
            {
                if (value != this._aRInvoiceItemKitUnitCost)
                {
                    _aRInvoiceItemKitUnitCost = value;
                }
            }
        }
        public decimal ARInvoiceItemKitDiscPct
        {
            get { return _aRInvoiceItemKitDiscPct; }
            set
            {
                if (value != this._aRInvoiceItemKitDiscPct)
                {
                    _aRInvoiceItemKitDiscPct = value;
                }
            }
        }
        public decimal ARInvoiceItemKitTxPct
        {
            get { return _aRInvoiceItemKitTxPct; }
            set
            {
                if (value != this._aRInvoiceItemKitTxPct)
                {
                    _aRInvoiceItemKitTxPct = value;
                }
            }
        }
        public decimal ARInvoiceItemKitQty
        {
            get { return _aRInvoiceItemKitQty; }
            set
            {
                if (value != this._aRInvoiceItemKitQty)
                {
                    _aRInvoiceItemKitQty = value;
                }
            }
        }
        public decimal ARInvoiceItemKitStkQty
        {
            get { return _aRInvoiceItemKitStkQty; }
            set
            {
                if (value != this._aRInvoiceItemKitStkQty)
                {
                    _aRInvoiceItemKitStkQty = value;
                }
            }
        }
        public decimal ARInvoiceItemKitRQty
        {
            get { return _aRInvoiceItemKitRQty; }
            set
            {
                if (value != this._aRInvoiceItemKitRQty)
                {
                    _aRInvoiceItemKitRQty = value;
                }
            }
        }
        public decimal ARInvoiceItemKitRStkQty
        {
            get { return _aRInvoiceItemKitRStkQty; }
            set
            {
                if (value != this._aRInvoiceItemKitRStkQty)
                {
                    _aRInvoiceItemKitRStkQty = value;
                }
            }
        }
        public decimal ARInvoiceItemKitPrice
        {
            get { return _aRInvoiceItemKitPrice; }
            set
            {
                if (value != this._aRInvoiceItemKitPrice)
                {
                    _aRInvoiceItemKitPrice = value;
                }
            }
        }
        public decimal ARInvoiceItemKitFPrice
        {
            get { return _aRInvoiceItemKitFPrice; }
            set
            {
                if (value != this._aRInvoiceItemKitFPrice)
                {
                    _aRInvoiceItemKitFPrice = value;
                }
            }
        }
        public String ARInvoiceItemKitComment
        {
            get { return _aRInvoiceItemKitComment; }
            set
            {
                if (value != this._aRInvoiceItemKitComment)
                {
                    _aRInvoiceItemKitComment = value;
                }
            }
        }
        public decimal ARInvoiceItemKitUnitVol
        {
            get { return _aRInvoiceItemKitUnitVol; }
            set
            {
                if (value != this._aRInvoiceItemKitUnitVol)
                {
                    _aRInvoiceItemKitUnitVol = value;
                }
            }
        }
        public decimal ARInvoiceItemKitUnitWeight
        {
            get { return _aRInvoiceItemKitUnitWeight; }
            set
            {
                if (value != this._aRInvoiceItemKitUnitWeight)
                {
                    _aRInvoiceItemKitUnitWeight = value;
                  }
            }
        }
        public decimal ARInvoiceItemKitTxAmt
        {
            get { return _aRInvoiceItemKitTxAmt; }
            set
            {
                if (value != this._aRInvoiceItemKitTxAmt)
                {
                    _aRInvoiceItemKitTxAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemKitFTxAmt
        {
            get { return _aRInvoiceItemKitFTxAmt; }
            set
            {
                if (value != this._aRInvoiceItemKitFTxAmt)
                {
                    _aRInvoiceItemKitFTxAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemKitDiscAmt
        {
            get { return _aRInvoiceItemKitDiscAmt; }
            set
            {
                if (value != this._aRInvoiceItemKitDiscAmt)
                {
                    _aRInvoiceItemKitDiscAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemKitFDiscAmt
        {
            get { return _aRInvoiceItemKitFDiscAmt; }
            set
            {
                if (value != this._aRInvoiceItemKitFDiscAmt)
                {
                    _aRInvoiceItemKitFDiscAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemKitNetAmt
        {
            get { return _aRInvoiceItemKitNetAmt; }
            set
            {
                if (value != this._aRInvoiceItemKitNetAmt)
                {
                    _aRInvoiceItemKitNetAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemKitFNetAmt
        {
            get { return _aRInvoiceItemKitFNetAmt; }
            set
            {
                if (value != this._aRInvoiceItemKitFNetAmt)
                {
                    _aRInvoiceItemKitFNetAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAmtTot
        {
            get { return _aRInvoiceItemKitAmtTot; }
            set
            {
                if (value != this._aRInvoiceItemKitAmtTot)
                {
                    _aRInvoiceItemKitAmtTot = value;
                }
            }
        }
        public decimal ARInvoiceItemKitFAmtTot
        {
            get { return _aRInvoiceItemKitFAmtTot; }
            set
            {
                if (value != this._aRInvoiceItemKitFAmtTot)
                {
                    _aRInvoiceItemKitFAmtTot = value;
                }
            }
        }
        public decimal ARInvoiceItemKitCostTot
        {
            get { return _aRInvoiceItemKitCostTot; }
            set
            {
                if (value != this._aRInvoiceItemKitCostTot)
                {
                    _aRInvoiceItemKitCostTot = value;
                }
            }
        }
        public String ARInvoiceItemKitStatus
        {
            get { return _aRInvoiceItemKitStatus; }
            set
            {
                if (value != this._aRInvoiceItemKitStatus)
                {
                    _aRInvoiceItemKitStatus = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAmt
        {
            get { return _aRInvoiceItemKitAmt; }
            set
            {
                if (value != this._aRInvoiceItemKitAmt)
                {
                    _aRInvoiceItemKitAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemKitCAmt
        {
            get { return _aRInvoiceItemKitCAmt; }
            set
            {
                if (value != this._aRInvoiceItemKitCAmt)
                {
                    _aRInvoiceItemKitCAmt = value;
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
        public decimal ARInvoiceItemKitReturnQty
        {
            get { return _aRInvoiceItemKitReturnQty; }
            set
            {
                if (value != this._aRInvoiceItemKitReturnQty)
                {
                    _aRInvoiceItemKitReturnQty = value;
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
        public int ARInvoiceItemKitSortOrder
        {
            get { return _aRInvoiceItemKitSortOrder; }
            set
            {
                if (value != this._aRInvoiceItemKitSortOrder)
                {
                    _aRInvoiceItemKitSortOrder = value;
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
        public Nullable<DateTime> ARInvoiceItemKitExpireDate
        {
            get { return _aRInvoiceItemKitExpireDate; }
            set
            {
                if (value != this._aRInvoiceItemKitExpireDate)
                {
                    _aRInvoiceItemKitExpireDate = value;
                }
            }
        }
        public decimal ARInvoiceItemKitSaleReturnRQty
        {
            get { return _aRInvoiceItemKitSaleReturnRQty; }
            set
            {
                if (value != this._aRInvoiceItemKitSaleReturnRQty)
                {
                    _aRInvoiceItemKitSaleReturnRQty = value;
                }
            }
        }
        public String ARInvoiceItemKitSaleReturnStatusCombo
        {
            get { return _aRInvoiceItemKitSaleReturnStatusCombo; }
            set
            {
                if (value != this._aRInvoiceItemKitSaleReturnStatusCombo)
                {
                    _aRInvoiceItemKitSaleReturnStatusCombo = value;
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
        public decimal ARInvoiceItemKitFeeAmtTotBeforeTax
        {
            get { return _aRInvoiceItemKitFeeAmtTotBeforeTax; }
            set
            {
                if (value != this._aRInvoiceItemKitFeeAmtTotBeforeTax)
                {
                    _aRInvoiceItemKitFeeAmtTotBeforeTax = value;
                }
            }
        }
        public decimal ARInvoiceItemKitLenContractGocAmt
        {
            get { return _aRInvoiceItemKitLenContractGocAmt; }
            set
            {
                if (value != this._aRInvoiceItemKitLenContractGocAmt)
                {
                    _aRInvoiceItemKitLenContractGocAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemKitLenContractNetAmt
        {
            get { return _aRInvoiceItemKitLenContractNetAmt; }
            set
            {
                if (value != this._aRInvoiceItemKitLenContractNetAmt)
                {
                    _aRInvoiceItemKitLenContractNetAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemKitLenContractPhiAmt
        {
            get { return _aRInvoiceItemKitLenContractPhiAmt; }
            set
            {
                if (value != this._aRInvoiceItemKitLenContractPhiAmt)
                {
                    _aRInvoiceItemKitLenContractPhiAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemKitVATOriginalAmt
        {
            get { return _aRInvoiceItemKitVATOriginalAmt; }
            set
            {
                if (value != this._aRInvoiceItemKitVATOriginalAmt)
                {
                    _aRInvoiceItemKitVATOriginalAmt = value;
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
        public String ARInvoiceItemKitLotNo
        {
            get { return _aRInvoiceItemKitLotNo; }
            set
            {
                if (value != this._aRInvoiceItemKitLotNo)
                {
                    _aRInvoiceItemKitLotNo = value;
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
        public decimal ARInvoiceItemKitWTot
        {
            get { return _aRInvoiceItemKitWTot; }
            set
            {
                if (value != this._aRInvoiceItemKitWTot)
                {
                    _aRInvoiceItemKitWTot = value;
                }
            }
        }
        public decimal ARInvoiceItemKitVTot
        {
            get { return _aRInvoiceItemKitVTot; }
            set
            {
                if (value != this._aRInvoiceItemKitVTot)
                {
                    _aRInvoiceItemKitVTot = value;
                }
            }
        }
        public decimal ARInvoiceItemKitOrgQty
        {
            get { return _aRInvoiceItemKitOrgQty; }
            set
            {
                if (value != this._aRInvoiceItemKitOrgQty)
                {
                    _aRInvoiceItemKitOrgQty = value;
                }
            }
        }
        public decimal ARInvoiceItemKitExcQty
        {
            get { return _aRInvoiceItemKitExcQty; }
            set
            {
                if (value != this._aRInvoiceItemKitExcQty)
                {
                    _aRInvoiceItemKitExcQty = value;
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
        public decimal ARInvoiceItemKitCQty
        {
            get { return _aRInvoiceItemKitCQty; }
            set
            {
                if (value != this._aRInvoiceItemKitCQty)
                {
                    _aRInvoiceItemKitCQty = value;
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
        public decimal ARInvoiceItemKitRefundDiscPct
        {
            get { return _aRInvoiceItemKitRefundDiscPct; }
            set
            {
                if (value != this._aRInvoiceItemKitRefundDiscPct)
                {
                    _aRInvoiceItemKitRefundDiscPct = value;
                }
            }
        }
        public decimal ARInvoiceItemKitRefundDiscFAmt
        {
            get { return _aRInvoiceItemKitRefundDiscFAmt; }
            set
            {
                if (value != this._aRInvoiceItemKitRefundDiscFAmt)
                {
                    _aRInvoiceItemKitRefundDiscFAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemKitRefundDiscAmt
        {
            get { return _aRInvoiceItemKitRefundDiscAmt; }
            set
            {
                if (value != this._aRInvoiceItemKitRefundDiscAmt)
                {
                    _aRInvoiceItemKitRefundDiscAmt = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjFUnitPrice01
        {
            get { return _aRInvoiceItemKitAdjFUnitPrice01; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjFUnitPrice01)
                {
                    _aRInvoiceItemKitAdjFUnitPrice01 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjFUnitPrice02
        {
            get { return _aRInvoiceItemKitAdjFUnitPrice02; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjFUnitPrice02)
                {
                    _aRInvoiceItemKitAdjFUnitPrice02 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjFUnitPrice03
        {
            get { return _aRInvoiceItemKitAdjFUnitPrice03; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjFUnitPrice03)
                {
                    _aRInvoiceItemKitAdjFUnitPrice03 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjFUnitPrice04
        {
            get { return _aRInvoiceItemKitAdjFUnitPrice04; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjFUnitPrice04)
                {
                    _aRInvoiceItemKitAdjFUnitPrice04 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjFUnitPrice05
        {
            get { return _aRInvoiceItemKitAdjFUnitPrice05; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjFUnitPrice05)
                {
                    _aRInvoiceItemKitAdjFUnitPrice05 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitOrgFUnitPrice
        {
            get { return _aRInvoiceItemKitOrgFUnitPrice; }
            set
            {
                if (value != this._aRInvoiceItemKitOrgFUnitPrice)
                {
                    _aRInvoiceItemKitOrgFUnitPrice = value;
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
        public int FK_AdjARInvoiceItemKitID
        {
            get { return _fK_AdjARInvoiceItemKitID; }
            set
            {
                if (value != this._fK_AdjARInvoiceItemKitID)
                {
                    _fK_AdjARInvoiceItemKitID = value;
                }
            }
        }
        public decimal ARInvoiceItemKitGrossWTot
        {
            get { return _aRInvoiceItemKitGrossWTot; }
            set
            {
                if (value != this._aRInvoiceItemKitGrossWTot)
                {
                    _aRInvoiceItemKitGrossWTot = value;
                }
            }
        }
        public decimal ARInvoiceItemKitNetWTot
        {
            get { return _aRInvoiceItemKitNetWTot; }
            set
            {
                if (value != this._aRInvoiceItemKitNetWTot)
                {
                    _aRInvoiceItemKitNetWTot = value;
                }
            }
        }
        public String ARInvoiceItemKitAutoCampaignNote
        {
            get { return _aRInvoiceItemKitAutoCampaignNote; }
            set
            {
                if (value != this._aRInvoiceItemKitAutoCampaignNote)
                {
                    _aRInvoiceItemKitAutoCampaignNote = value;
                }
            }
        }
        public String ARInvoiceItemKitManualCampaignNote
        {
            get { return _aRInvoiceItemKitManualCampaignNote; }
            set
            {
                if (value != this._aRInvoiceItemKitManualCampaignNote)
                {
                    _aRInvoiceItemKitManualCampaignNote = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjStkQty
        {
            get { return _aRInvoiceItemKitAdjStkQty; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjStkQty)
                {
                    _aRInvoiceItemKitAdjStkQty = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjUnitPricePct01
        {
            get { return _aRInvoiceItemKitAdjUnitPricePct01; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjUnitPricePct01)
                {
                    _aRInvoiceItemKitAdjUnitPricePct01 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjUnitPricePct02
        {
            get { return _aRInvoiceItemKitAdjUnitPricePct02; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjUnitPricePct02)
                {
                    _aRInvoiceItemKitAdjUnitPricePct02 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjUnitPricePct03
        {
            get { return _aRInvoiceItemKitAdjUnitPricePct03; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjUnitPricePct03)
                {
                    _aRInvoiceItemKitAdjUnitPricePct03 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjUnitPricePct04
        {
            get { return _aRInvoiceItemKitAdjUnitPricePct04; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjUnitPricePct04)
                {
                    _aRInvoiceItemKitAdjUnitPricePct04 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjUnitPricePct05
        {
            get { return _aRInvoiceItemKitAdjUnitPricePct05; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjUnitPricePct05)
                {
                    _aRInvoiceItemKitAdjUnitPricePct05 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjDiscPct01
        {
            get { return _aRInvoiceItemKitAdjDiscPct01; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjDiscPct01)
                {
                    _aRInvoiceItemKitAdjDiscPct01 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjDiscPct02
        {
            get { return _aRInvoiceItemKitAdjDiscPct02; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjDiscPct02)
                {
                    _aRInvoiceItemKitAdjDiscPct02 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjDiscPct03
        {
            get { return _aRInvoiceItemKitAdjDiscPct03; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjDiscPct03)
                {
                    _aRInvoiceItemKitAdjDiscPct03 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjDiscPct04
        {
            get { return _aRInvoiceItemKitAdjDiscPct04; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjDiscPct04)
                {
                    _aRInvoiceItemKitAdjDiscPct04 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjDiscPct05
        {
            get { return _aRInvoiceItemKitAdjDiscPct05; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjDiscPct05)
                {
                    _aRInvoiceItemKitAdjDiscPct05 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjDiscFAmt01
        {
            get { return _aRInvoiceItemKitAdjDiscFAmt01; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjDiscFAmt01)
                {
                    _aRInvoiceItemKitAdjDiscFAmt01 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjDiscFAmt02
        {
            get { return _aRInvoiceItemKitAdjDiscFAmt02; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjDiscFAmt02)
                {
                    _aRInvoiceItemKitAdjDiscFAmt02 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjDiscFAmt03
        {
            get { return _aRInvoiceItemKitAdjDiscFAmt03; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjDiscFAmt03)
                {
                    _aRInvoiceItemKitAdjDiscFAmt03 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjDiscFAmt04
        {
            get { return _aRInvoiceItemKitAdjDiscFAmt04; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjDiscFAmt04)
                {
                    _aRInvoiceItemKitAdjDiscFAmt04 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjDiscFAmt05
        {
            get { return _aRInvoiceItemKitAdjDiscFAmt05; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjDiscFAmt05)
                {
                    _aRInvoiceItemKitAdjDiscFAmt05 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjDiscAmt01
        {
            get { return _aRInvoiceItemKitAdjDiscAmt01; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjDiscAmt01)
                {
                    _aRInvoiceItemKitAdjDiscAmt01 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjDiscAmt02
        {
            get { return _aRInvoiceItemKitAdjDiscAmt02; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjDiscAmt02)
                {
                    _aRInvoiceItemKitAdjDiscAmt02 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjDiscAmt03
        {
            get { return _aRInvoiceItemKitAdjDiscAmt03; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjDiscAmt03)
                {
                    _aRInvoiceItemKitAdjDiscAmt03 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjDiscAmt04
        {
            get { return _aRInvoiceItemKitAdjDiscAmt04; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjDiscAmt04)
                {
                    _aRInvoiceItemKitAdjDiscAmt04 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitAdjDiscAmt05
        {
            get { return _aRInvoiceItemKitAdjDiscAmt05; }
            set
            {
                if (value != this._aRInvoiceItemKitAdjDiscAmt05)
                {
                    _aRInvoiceItemKitAdjDiscAmt05 = value;
                }
            }
        }
        public decimal ARInvoiceItemKitNetAmtTot
        {
            get { return _aRInvoiceItemKitNetAmtTot; }
            set
            {
                if (value != this._aRInvoiceItemKitNetAmtTot)
                {
                    _aRInvoiceItemKitNetAmtTot = value;
                }
            }
        }
        public decimal ARInvoiceItemKitFNetAmtTot
        {
            get { return _aRInvoiceItemKitFNetAmtTot; }
            set
            {
                if (value != this._aRInvoiceItemKitFNetAmtTot)
                {
                    _aRInvoiceItemKitFNetAmtTot = value;
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
        public decimal ARInvoiceItemKitFDiscAmtTot
        {
            get { return _aRInvoiceItemKitFDiscAmtTot; }
            set
            {
                if (value != this._aRInvoiceItemKitFDiscAmtTot)
                {
                    _aRInvoiceItemKitFDiscAmtTot = value;
                }
            }
        }
        public decimal ARInvoiceItemKitDiscAmtTot
        {
            get { return _aRInvoiceItemKitDiscAmtTot; }
            set
            {
                if (value != this._aRInvoiceItemKitDiscAmtTot)
                {
                    _aRInvoiceItemKitDiscAmtTot = value;
                }
            }
        }
        public String ARInvoiceItemKitTAN
        {
            get { return _aRInvoiceItemKitTAN; }
            set
            {
                if (value != this._aRInvoiceItemKitTAN)
                {
                    _aRInvoiceItemKitTAN = value;
                }
            }
        }
        public String ARInvoiceItemKitPR00
        {
            get { return _aRInvoiceItemKitPR00; }
            set
            {
                if (value != this._aRInvoiceItemKitPR00)
                {
                    _aRInvoiceItemKitPR00 = value;
                }
            }
        }
        public String ARInvoiceItemKitMWST
        {
            get { return _aRInvoiceItemKitMWST; }
            set
            {
                if (value != this._aRInvoiceItemKitMWST)
                {
                    _aRInvoiceItemKitMWST = value;
                }
            }
        }

        #endregion
    }
}