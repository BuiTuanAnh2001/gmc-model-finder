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
    [Table("GLVoucherTransactionItems")]
    public class GLVoucherTransactionItemsInfo : BaseInfo
    {
        public GLVoucherTransactionItemsInfo()
        {
        }
        #region Variables
        protected int _gLVoucherTransactionItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_GLVoucherID;
        protected int _fK_APPInvoiceID;
        protected int _fK_APCreditNoteID;
        protected int _fK_GLDebitAccountID;
        protected int _fK_GLCreditAccountID;
        protected int _fK_GLDebitVATAccountID;
        protected int _fK_GLCreditVATAccountID;
        protected int _fK_GECurrencyID;
        protected decimal _gLVoucherTransactionItemExcRate;
        protected decimal _gLVoucherTransactionItemFDocAmt;
        protected decimal _gLVoucherTransactionItemDocAmt;
        protected decimal _gLVoucherTransactionItemDocRFAmt;
        protected decimal _gLVoucherTransactionItemDocRAmt;
        protected decimal _gLVoucherTransactionItemNeedPmtFAmtTot;
        protected decimal _gLVoucherTransactionItemNeedPmtAmtTot;
        protected decimal _gLVoucherTransactionItemFPmtAmt;
        protected decimal _gLVoucherTransactionItemPmtAmt;
        protected decimal _gLVoucherTransactionItemBeforeDueDateCount;
        protected decimal _gLVoucherTransactionItemDiscPct;
        protected decimal _gLVoucherTransactionItemDiscFAmt;
        protected decimal _gLVoucherTransactionItemDiscAmt;
        protected decimal _gLVoucherTransactionItemOverDueDateCount;
        protected decimal _gLVoucherTransactionItemOverDueDatePct;
        protected decimal _gLVoucherTransactionItemOverDueDateFAmt;
        protected decimal _gLVoucherTransactionItemOverDueDateAmt;
        protected String _gLVoucherTransactionItemInvNo = String.Empty;
        protected String _gLVoucherTransactionItemInvSerie = String.Empty;
        protected Nullable<DateTime> _gLVoucherTransactionItemInvDate;
        protected String _gLVoucherTransactionItemDocNo = String.Empty;
        protected String _gLVoucherTransactionItemDesc = String.Empty;
        protected Nullable<DateTime> _gLVoucherTransactionItemDocDate;
        protected Nullable<DateTime> _gLVoucherTransactionItemDueDate;
        protected Nullable<DateTime> _gLVoucherTransactionItemLastPmtDate;
        protected int _fK_ARInvoiceID;
        protected int _fK_ARCreditNoteID;
        protected decimal _gLVoucherTransactionItemDocFPrice;
        protected decimal _gLVoucherTransactionItemDocPrice;
        protected decimal _gLVoucherTransactionItemDocTxFAmt;
        protected decimal _gLVoucherTransactionItemDocTxAmt;
        protected decimal _gLVoucherTransactionItemDocFAmt;
        protected int _fK_GLCostCenter1ID;
        protected int _fK_GLCostCenter2ID;
        protected int _fK_GLCostCenter3ID;
        protected int _fK_GLCostCenter4ID;
        protected int _fK_GLCostCenter5ID;
        protected int _fK_GLCostDistID;
        protected int _fK_APPOID;
        protected int _fK_GLVoucherItemID;
        protected decimal _gLVoucherTransactionItemPmtReqAmtTot;
        protected decimal _gLVoucherTransactionItemPmtReqFAmtTot;
        protected int _fK_GLPaymentVoucherID;
        protected int _fK_PPCostCenterID;
        protected int _fK_ARCustomerID;
        protected int _fK_HREmployeeID;
        protected int _fK_APSupplierID;
        protected int _fK_GLCreditVoucherItemID;
        protected int _fK_GLDebitVoucherItemID;
        protected decimal _gLVoucherTransactionItemDiffAmt;
        protected int _fK_GLExchangeAccountID;
        protected String _gLVoucherTransactionItemPmtNo = String.Empty;
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
        protected Nullable<DateTime> _gLVoucherTransactionItemLastPostDate;
        protected String _gLVoucherTransactionItemNo = String.Empty;

        #endregion
        [Key]
        #region Public properties
        public int GLVoucherTransactionItemID
        {
            get { return _gLVoucherTransactionItemID; }
            set
            {
                if (value != this._gLVoucherTransactionItemID)
                {
                    _gLVoucherTransactionItemID = value;
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
        public int FK_GLVoucherID
        {
            get { return _fK_GLVoucherID; }
            set
            {
                if (value != this._fK_GLVoucherID)
                {
                    _fK_GLVoucherID = value;
                }
            }
        }
        public int FK_APPInvoiceID
        {
            get { return _fK_APPInvoiceID; }
            set
            {
                if (value != this._fK_APPInvoiceID)
                {
                    _fK_APPInvoiceID = value;
                }
            }
        }
        public int FK_APCreditNoteID
        {
            get { return _fK_APCreditNoteID; }
            set
            {
                if (value != this._fK_APCreditNoteID)
                {
                    _fK_APCreditNoteID = value;
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
        public int FK_GECurrencyID
        {
            get { return _fK_GECurrencyID; }
            set
            {
                if (value != this._fK_GECurrencyID)
                {
                    _fK_GECurrencyID = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemExcRate
        {
            get { return _gLVoucherTransactionItemExcRate; }
            set
            {
                if (value != this._gLVoucherTransactionItemExcRate)
                {
                    _gLVoucherTransactionItemExcRate = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemFDocAmt
        {
            get { return _gLVoucherTransactionItemFDocAmt; }
            set
            {
                if (value != this._gLVoucherTransactionItemFDocAmt)
                {
                    _gLVoucherTransactionItemFDocAmt = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemDocAmt
        {
            get { return _gLVoucherTransactionItemDocAmt; }
            set
            {
                if (value != this._gLVoucherTransactionItemDocAmt)
                {
                    _gLVoucherTransactionItemDocAmt = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemDocRFAmt
        {
            get { return _gLVoucherTransactionItemDocRFAmt; }
            set
            {
                if (value != this._gLVoucherTransactionItemDocRFAmt)
                {
                    _gLVoucherTransactionItemDocRFAmt = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemDocRAmt
        {
            get { return _gLVoucherTransactionItemDocRAmt; }
            set
            {
                if (value != this._gLVoucherTransactionItemDocRAmt)
                {
                    _gLVoucherTransactionItemDocRAmt = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemNeedPmtFAmtTot
        {
            get { return _gLVoucherTransactionItemNeedPmtFAmtTot; }
            set
            {
                if (value != this._gLVoucherTransactionItemNeedPmtFAmtTot)
                {
                    _gLVoucherTransactionItemNeedPmtFAmtTot = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemNeedPmtAmtTot
        {
            get { return _gLVoucherTransactionItemNeedPmtAmtTot; }
            set
            {
                if (value != this._gLVoucherTransactionItemNeedPmtAmtTot)
                {
                    _gLVoucherTransactionItemNeedPmtAmtTot = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemFPmtAmt
        {
            get { return _gLVoucherTransactionItemFPmtAmt; }
            set
            {
                if (value != this._gLVoucherTransactionItemFPmtAmt)
                {
                    _gLVoucherTransactionItemFPmtAmt = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemPmtAmt
        {
            get { return _gLVoucherTransactionItemPmtAmt; }
            set
            {
                if (value != this._gLVoucherTransactionItemPmtAmt)
                {
                    _gLVoucherTransactionItemPmtAmt = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemBeforeDueDateCount
        {
            get { return _gLVoucherTransactionItemBeforeDueDateCount; }
            set
            {
                if (value != this._gLVoucherTransactionItemBeforeDueDateCount)
                {
                    _gLVoucherTransactionItemBeforeDueDateCount = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemDiscPct
        {
            get { return _gLVoucherTransactionItemDiscPct; }
            set
            {
                if (value != this._gLVoucherTransactionItemDiscPct)
                {
                    _gLVoucherTransactionItemDiscPct = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemDiscFAmt
        {
            get { return _gLVoucherTransactionItemDiscFAmt; }
            set
            {
                if (value != this._gLVoucherTransactionItemDiscFAmt)
                {
                    _gLVoucherTransactionItemDiscFAmt = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemDiscAmt
        {
            get { return _gLVoucherTransactionItemDiscAmt; }
            set
            {
                if (value != this._gLVoucherTransactionItemDiscAmt)
                {
                    _gLVoucherTransactionItemDiscAmt = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemOverDueDateCount
        {
            get { return _gLVoucherTransactionItemOverDueDateCount; }
            set
            {
                if (value != this._gLVoucherTransactionItemOverDueDateCount)
                {
                    _gLVoucherTransactionItemOverDueDateCount = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemOverDueDatePct
        {
            get { return _gLVoucherTransactionItemOverDueDatePct; }
            set
            {
                if (value != this._gLVoucherTransactionItemOverDueDatePct)
                {
                    _gLVoucherTransactionItemOverDueDatePct = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemOverDueDateFAmt
        {
            get { return _gLVoucherTransactionItemOverDueDateFAmt; }
            set
            {
                if (value != this._gLVoucherTransactionItemOverDueDateFAmt)
                {
                    _gLVoucherTransactionItemOverDueDateFAmt = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemOverDueDateAmt
        {
            get { return _gLVoucherTransactionItemOverDueDateAmt; }
            set
            {
                if (value != this._gLVoucherTransactionItemOverDueDateAmt)
                {
                    _gLVoucherTransactionItemOverDueDateAmt = value;
                }
            }
        }
        public String GLVoucherTransactionItemInvNo
        {
            get { return _gLVoucherTransactionItemInvNo; }
            set
            {
                if (value != this._gLVoucherTransactionItemInvNo)
                {
                    _gLVoucherTransactionItemInvNo = value;
                }
            }
        }
        public String GLVoucherTransactionItemInvSerie
        {
            get { return _gLVoucherTransactionItemInvSerie; }
            set
            {
                if (value != this._gLVoucherTransactionItemInvSerie)
                {
                    _gLVoucherTransactionItemInvSerie = value;
                }
            }
        }
        public Nullable<DateTime> GLVoucherTransactionItemInvDate
        {
            get { return _gLVoucherTransactionItemInvDate; }
            set
            {
                if (value != this._gLVoucherTransactionItemInvDate)
                {
                    _gLVoucherTransactionItemInvDate = value;
                }
            }
        }
        public String GLVoucherTransactionItemDocNo
        {
            get { return _gLVoucherTransactionItemDocNo; }
            set
            {
                if (value != this._gLVoucherTransactionItemDocNo)
                {
                    _gLVoucherTransactionItemDocNo = value;
                }
            }
        }
        public String GLVoucherTransactionItemDesc
        {
            get { return _gLVoucherTransactionItemDesc; }
            set
            {
                if (value != this._gLVoucherTransactionItemDesc)
                {
                    _gLVoucherTransactionItemDesc = value;
                }
            }
        }
        public Nullable<DateTime> GLVoucherTransactionItemDocDate
        {
            get { return _gLVoucherTransactionItemDocDate; }
            set
            {
                if (value != this._gLVoucherTransactionItemDocDate)
                {
                    _gLVoucherTransactionItemDocDate = value;
                }
            }
        }
        public Nullable<DateTime> GLVoucherTransactionItemDueDate
        {
            get { return _gLVoucherTransactionItemDueDate; }
            set
            {
                if (value != this._gLVoucherTransactionItemDueDate)
                {
                    _gLVoucherTransactionItemDueDate = value;
                }
            }
        }
        public Nullable<DateTime> GLVoucherTransactionItemLastPmtDate
        {
            get { return _gLVoucherTransactionItemLastPmtDate; }
            set
            {
                if (value != this._gLVoucherTransactionItemLastPmtDate)
                {
                    _gLVoucherTransactionItemLastPmtDate = value;
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
        public decimal GLVoucherTransactionItemDocFPrice
        {
            get { return _gLVoucherTransactionItemDocFPrice; }
            set
            {
                if (value != this._gLVoucherTransactionItemDocFPrice)
                {
                    _gLVoucherTransactionItemDocFPrice = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemDocPrice
        {
            get { return _gLVoucherTransactionItemDocPrice; }
            set
            {
                if (value != this._gLVoucherTransactionItemDocPrice)
                {
                    _gLVoucherTransactionItemDocPrice = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemDocTxFAmt
        {
            get { return _gLVoucherTransactionItemDocTxFAmt; }
            set
            {
                if (value != this._gLVoucherTransactionItemDocTxFAmt)
                {
                    _gLVoucherTransactionItemDocTxFAmt = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemDocTxAmt
        {
            get { return _gLVoucherTransactionItemDocTxAmt; }
            set
            {
                if (value != this._gLVoucherTransactionItemDocTxAmt)
                {
                    _gLVoucherTransactionItemDocTxAmt = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemDocFAmt
        {
            get { return _gLVoucherTransactionItemDocFAmt; }
            set
            {
                if (value != this._gLVoucherTransactionItemDocFAmt)
                {
                    _gLVoucherTransactionItemDocFAmt = value;
                }
            }
        }
        public int FK_GLCostCenter1ID
        {
            get { return _fK_GLCostCenter1ID; }
            set
            {
                if (value != this._fK_GLCostCenter1ID)
                {
                    _fK_GLCostCenter1ID = value;
                }
            }
        }
        public int FK_GLCostCenter2ID
        {
            get { return _fK_GLCostCenter2ID; }
            set
            {
                if (value != this._fK_GLCostCenter2ID)
                {
                    _fK_GLCostCenter2ID = value;
                }
            }
        }
        public int FK_GLCostCenter3ID
        {
            get { return _fK_GLCostCenter3ID; }
            set
            {
                if (value != this._fK_GLCostCenter3ID)
                {
                    _fK_GLCostCenter3ID = value;
                }
            }
        }
        public int FK_GLCostCenter4ID
        {
            get { return _fK_GLCostCenter4ID; }
            set
            {
                if (value != this._fK_GLCostCenter4ID)
                {
                    _fK_GLCostCenter4ID = value;
                }
            }
        }
        public int FK_GLCostCenter5ID
        {
            get { return _fK_GLCostCenter5ID; }
            set
            {
                if (value != this._fK_GLCostCenter5ID)
                {
                    _fK_GLCostCenter5ID = value;
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
        public decimal GLVoucherTransactionItemPmtReqAmtTot
        {
            get { return _gLVoucherTransactionItemPmtReqAmtTot; }
            set
            {
                if (value != this._gLVoucherTransactionItemPmtReqAmtTot)
                {
                    _gLVoucherTransactionItemPmtReqAmtTot = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemPmtReqFAmtTot
        {
            get { return _gLVoucherTransactionItemPmtReqFAmtTot; }
            set
            {
                if (value != this._gLVoucherTransactionItemPmtReqFAmtTot)
                {
                    _gLVoucherTransactionItemPmtReqFAmtTot = value;
                }
            }
        }
        public int FK_GLPaymentVoucherID
        {
            get { return _fK_GLPaymentVoucherID; }
            set
            {
                if (value != this._fK_GLPaymentVoucherID)
                {
                    _fK_GLPaymentVoucherID = value;
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
        public int FK_GLCreditVoucherItemID
        {
            get { return _fK_GLCreditVoucherItemID; }
            set
            {
                if (value != this._fK_GLCreditVoucherItemID)
                {
                    _fK_GLCreditVoucherItemID = value;
                }
            }
        }
        public int FK_GLDebitVoucherItemID
        {
            get { return _fK_GLDebitVoucherItemID; }
            set
            {
                if (value != this._fK_GLDebitVoucherItemID)
                {
                    _fK_GLDebitVoucherItemID = value;
                }
            }
        }
        public decimal GLVoucherTransactionItemDiffAmt
        {
            get { return _gLVoucherTransactionItemDiffAmt; }
            set
            {
                if (value != this._gLVoucherTransactionItemDiffAmt)
                {
                    _gLVoucherTransactionItemDiffAmt = value;
                }
            }
        }
        public int FK_GLExchangeAccountID
        {
            get { return _fK_GLExchangeAccountID; }
            set
            {
                if (value != this._fK_GLExchangeAccountID)
                {
                    _fK_GLExchangeAccountID = value;
                }
            }
        }
        public String GLVoucherTransactionItemPmtNo
        {
            get { return _gLVoucherTransactionItemPmtNo; }
            set
            {
                if (value != this._gLVoucherTransactionItemPmtNo)
                {
                    _gLVoucherTransactionItemPmtNo = value;
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
        public Nullable<DateTime> GLVoucherTransactionItemLastPostDate
        {
            get { return _gLVoucherTransactionItemLastPostDate; }
            set
            {
                if (value != this._gLVoucherTransactionItemLastPostDate)
                {
                    _gLVoucherTransactionItemLastPostDate = value;
                }
            }
        }
        public String GLVoucherTransactionItemNo
        {
            get { return _gLVoucherTransactionItemNo; }
            set
            {
                if (value != this._gLVoucherTransactionItemNo)
                {
                    _gLVoucherTransactionItemNo = value;
                }
            }
        }

        #endregion
    }
}
