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
    [Table("ARCreditNotes")]
    public class ARCreditNotesInfo : BaseInfo
    {
        public ARCreditNotesInfo()
        {
        }
        #region Variables
        protected int _aRCreditNoteID;
        protected DateTime _aACreatedDate = DateTime.Now;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.Now;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_GECurrencyID;
        protected int _fK_ARCustomerID;
        protected int _fK_GEShpMthID;
        protected int _fK_ARPriceListID;
        protected int _fK_BRBranchID;
        protected int _fK_ICStockID;
        protected String _aRCreditNotePOSNo = String.Empty;
        protected String _aRSalePriceCombo = String.Empty;
        protected decimal _aRSellerComAmt;
        protected decimal _aRSellerComPct;
        protected String _aRCreditNoteStatusCombo = DefaultStatus;
        protected String _aPCreditNoteItemTypeCombo = String.Empty;
        protected String _aRCreditNotePostingStatus = DefaultStatus;
        protected String _aRCreditNoteTypeCombo = String.Empty;
        protected String _aRCreditNotePmtTerm = String.Empty;
        protected String _aRPmtMthCombo = String.Empty;
        protected String _aRCreditNoteNo = String.Empty;
        protected String _aRCreditNoteName = String.Empty;
        protected String _aRCreditNoteDesc = String.Empty;
        protected decimal _aRCreditNoteExcRate;
        protected decimal _aRCreditNoteAmt;
        protected decimal _aRCreditNoteCAmt;
        protected bool _aRCreditNoteOnHoldCheck = true;
        protected String _aRCreditNoteText = String.Empty;
        protected DateTime _aRCreditNoteDate = DateTime.Now;
        protected int _aRCreditNoteFiscPer;
        protected int _aRCreditNoteFiscYr;
        protected Nullable<DateTime> _aRCreditNoteShpDate;
        protected Nullable<DateTime> _aRCreditNoteExpireDate;
        protected decimal _aRCreditNoteDiscPct;
        protected decimal _aRCreditNoteDiscAmt;
        protected String _aRCreditNoteRef = String.Empty;
        protected String _aRCreditNoteCusRef = String.Empty;
        protected String _aRCreditNoteComment = String.Empty;
        protected decimal _aRCreditNoteWeight;
        protected decimal _aRCreditNoteVol;
        protected bool _aRCreditNoteActive = true;
        protected String _aRCreditNoteTxNo = String.Empty;
        protected String _aRCreditNoterdTypeCombo = String.Empty;
        protected String _aRCreditNoteOF01Combo = String.Empty;
        protected String _aRCreditNoteOF02Combo = String.Empty;
        protected String _aRCreditNoteOF03Combo = String.Empty;
        protected String _aRCreditNoteOF04Combo = String.Empty;
        protected String _aRCreditNoteOF05Combo = String.Empty;
        protected String _aRCreditNoteOF06Combo = String.Empty;
        protected String _aRCreditNoteOF07Combo = String.Empty;
        protected String _aRCreditNoteOF08Combo = String.Empty;
        protected String _aRCreditNoteOF09Combo = String.Empty;
        protected String _aRCreditNoteOF10Combo = String.Empty;
        protected String _aRCreditNotePrj = String.Empty;
        protected String _aRCreditNoteCustomerName = String.Empty;
        protected String _aRCreditNoteCustomerDesc = String.Empty;
        protected int _fK_ARCustomerConBTID;
        protected String _aRCreditNoteBTConName = String.Empty;
        protected String _aRCreditNoteBTConFName = String.Empty;
        protected String _aRCreditNoteBTConLName = String.Empty;
        protected String _aRCreditNoteBTConTitle = String.Empty;
        protected String _aRCreditNoteBTConHLet = String.Empty;
        protected String _aRCreditNoteBTConHMsg = String.Empty;
        protected String _aRCreditNoteBTConEmail = String.Empty;
        protected String _aRCreditNoteBTConEmail1 = String.Empty;
        protected String _aRCreditNoteBTConPhone = String.Empty;
        protected String _aRCreditNoteBTConCPhone = String.Empty;
        protected String _aRCreditNoteBTConFax = String.Empty;
        protected String _aRCreditNoteBTConInfo = String.Empty;
        protected String _aRCreditNoteBTConDept = String.Empty;
        protected String _aRCreditNoteBTConRoom = String.Empty;
        protected String _aRCreditNoteBTAddL1 = String.Empty;
        protected String _aRCreditNoteBTAddL2 = String.Empty;
        protected String _aRCreditNoteBTAddL3 = String.Empty;
        protected String _aRCreditNoteBTAddStr = String.Empty;
        protected String _aRCreditNoteBTAddCity = String.Empty;
        protected String _aRCreditNoteBTAddPCode = String.Empty;
        protected String _aRCreditNoteBTAddStProv = String.Empty;
        protected String _aRCreditNoteBTAddZCode = String.Empty;
        protected String _aRCreditNoteBTAddCountry = String.Empty;
        protected int _fK_ARCustomerConCMID;
        protected String _aRCreditNoteCMConName = String.Empty;
        protected Nullable<DateTime> _aRCreditNoteCMConBday;
        protected String _aRCreditNoteCMConFName = String.Empty;
        protected String _aRCreditNoteCMConLName = String.Empty;
        protected String _aRCreditNoteCMConTitle = String.Empty;
        protected String _aRCreditNoteCMConHLet = String.Empty;
        protected String _aRCreditNoteCMConHMsg = String.Empty;
        protected String _aRCreditNoteCMConEmail = String.Empty;
        protected String _aRCreditNoteCMConEmail1 = String.Empty;
        protected String _aRCreditNoteCMConPhone = String.Empty;
        protected String _aRCreditNoteCMConFax = String.Empty;
        protected String _aRCreditNoteCMConCPhone = String.Empty;
        protected String _aRCreditNoteCMConInfo = String.Empty;
        protected String _aRCreditNoteCMConDept = String.Empty;
        protected String _aRCreditNoteCMConRoom = String.Empty;
        protected String _aRCreditNoteCMAddL1 = String.Empty;
        protected String _aRCreditNoteCMAddL2 = String.Empty;
        protected String _aRCreditNoteCMAddL3 = String.Empty;
        protected String _aRCreditNoteCMAddStr = String.Empty;
        protected String _aRCreditNoteCMAddCity = String.Empty;
        protected String _aRCreditNoteCMAddPCode = String.Empty;
        protected String _aRCreditNoteCMAddStProv = String.Empty;
        protected String _aRCreditNoteCMAddZCode = String.Empty;
        protected String _aRCreditNoteCMAddCountry = String.Empty;
        protected int _fK_ARCustomerConSTID;
        protected String _aRCreditNoteSTConName = String.Empty;
        protected Nullable<DateTime> _aRCreditNoteSTConBday;
        protected String _aRCreditNoteSTConFName = String.Empty;
        protected String _aRCreditNoteSTConLName = String.Empty;
        protected String _aRCreditNoteSTConTitle = String.Empty;
        protected String _aRCreditNoteSTConHLet = String.Empty;
        protected String _aRCreditNoteSTConHMsg = String.Empty;
        protected String _aRCreditNoteSTConEmail = String.Empty;
        protected String _aRCreditNoteSTConEmail1 = String.Empty;
        protected String _aRCreditNoteSTConPhone = String.Empty;
        protected String _aRCreditNoteSTConCPhone = String.Empty;
        protected String _aRCreditNoteSTConFax = String.Empty;
        protected String _aRCreditNoteSTConInfo = String.Empty;
        protected String _aRCreditNoteSTConDept = String.Empty;
        protected String _aRCreditNoteSTConRoom = String.Empty;
        protected String _aRCreditNoteSTAddL1 = String.Empty;
        protected String _aRCreditNoteSTAddL2 = String.Empty;
        protected String _aRCreditNoteSTAddL3 = String.Empty;
        protected String _aRCreditNoteSTAddStr = String.Empty;
        protected String _aRCreditNoteSTAddCity = String.Empty;
        protected String _aRCreditNoteSTAddPCode = String.Empty;
        protected String _aRCreditNoteSTAddStProv = String.Empty;
        protected String _aRCreditNoteSTAddZCode = String.Empty;
        protected String _aRCreditNoteSTAddCountry = String.Empty;
        protected decimal _aRCreditNoteShpAmt;
        protected decimal _aRCreditNoteItmPriceTot;
        protected decimal _aRCreditNoteItmDiscAmtTot;
        protected decimal _aRCreditNoteItmAmtTot;
        protected decimal _aRCreditNoteTxAmtTot;
        protected decimal _aRCreditNoteNetAmtTot;
        protected decimal _aRCreditNoteAmtTot;
        protected decimal _aRCreditNoteRAmtTot;
        protected decimal _aRCreditNoteMiscChargeAmt;
        protected decimal _aRCreditNoteCostTot;
        protected decimal _aRCreditNoteMargPct;
        protected String _aAPostStatus = DefaultStatus;
        protected decimal _aRCreditNoteFRAmtTot;
        protected decimal _aRCreditNoteFAmtTot;
        protected decimal _aRCreditNoteFImpTxAmtTot;
        protected decimal _aRCreditNoteFTxAmtTot;
        protected decimal _aRCreditNoteFItmAmtTot;
        protected decimal _aRCreditNoteFItmDiscAmtTot;
        protected decimal _aRCreditNoteFItmPriceTot;
        protected decimal _aRCreditNoteItmFPriceTot;
        protected decimal _aRCreditNoteItmDiscFAmtTot;
        protected decimal _aRCreditNoteItmFAmtTot;
        protected decimal _aRCreditNoteTxFAmtTot;
        protected decimal _aRCreditNoteNetFAmtTot;
        protected decimal _aRCreditNoteRFAmtTot;
        protected String _aALastPostNo = String.Empty;
        protected Nullable<DateTime> _aALastPostDate;
        protected String _approvalStatusCombo = DefaultStatus;
        protected String _aRCreditNoteInvNo = String.Empty;
        protected String _aRCreditNoteInvSerie = String.Empty;
        protected Nullable<DateTime> _aRCreditNoteInvDate;
        protected int _fK_GEInvTypeID;
        protected String _aRCreditNoteInvForm = String.Empty;
        protected Nullable<DateTime> _aRCreditNoteJrnDate;
        protected int _fK_GLTranCfgID;
        protected String _aRCreditNoteInvDesc = String.Empty;
        protected String _aAModule = String.Empty;
        protected int _fK_APSupplierID;
        protected String _aRCreditNoteSupAdd = String.Empty;
        protected String _aRCreditNoteOptional01 = String.Empty;
        protected String _aRCreditNoteOptional02 = String.Empty;
        protected String _aRCreditNoteOptional03 = String.Empty;
        protected int _fK_GLAccountID;
        protected String _aRCreditNoteJrnNo = String.Empty;
        protected int _fK_GECurrencyExObjID;
        protected int _fK_GLOrgTranCfgID;
        protected int _fK_AROrgInvoiceID;
        protected String _aRInvoiceRef = String.Empty;

        #endregion
        [Key]
        #region Public properties
        public int ARCreditNoteID
        {
            get { return _aRCreditNoteID; }
            set
            {
                if (value != this._aRCreditNoteID)
                {
                    _aRCreditNoteID = value;
                }
            }
        }
        public DateTime AACreatedDate
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
        public DateTime AAUpdatedDate
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
        public int FK_GEShpMthID
        {
            get { return _fK_GEShpMthID; }
            set
            {
                if (value != this._fK_GEShpMthID)
                {
                    _fK_GEShpMthID = value;
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
        public int FK_BRBranchID
        {
            get { return _fK_BRBranchID; }
            set
            {
                if (value != this._fK_BRBranchID)
                {
                    _fK_BRBranchID = value;
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
        public String ARCreditNotePOSNo
        {
            get { return _aRCreditNotePOSNo; }
            set
            {
                if (value != this._aRCreditNotePOSNo)
                {
                    _aRCreditNotePOSNo = value;
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
        public decimal ARSellerComAmt
        {
            get { return _aRSellerComAmt; }
            set
            {
                if (value != this._aRSellerComAmt)
                {
                    _aRSellerComAmt = value;
                }
            }
        }
        public decimal ARSellerComPct
        {
            get { return _aRSellerComPct; }
            set
            {
                if (value != this._aRSellerComPct)
                {
                    _aRSellerComPct = value;
                 }
            }
        }
        public String ARCreditNoteStatusCombo
        {
            get { return _aRCreditNoteStatusCombo; }
            set
            {
                if (value != this._aRCreditNoteStatusCombo)
                {
                    _aRCreditNoteStatusCombo = value;
                }
            }
        }
        public String APCreditNoteItemTypeCombo
        {
            get { return _aPCreditNoteItemTypeCombo; }
            set
            {
                if (value != this._aPCreditNoteItemTypeCombo)
                {
                    _aPCreditNoteItemTypeCombo = value;
                  }
            }
        }
        public String ARCreditNotePostingStatus
        {
            get { return _aRCreditNotePostingStatus; }
            set
            {
                if (value != this._aRCreditNotePostingStatus)
                {
                    _aRCreditNotePostingStatus = value;
                }
            }
        }
        public String ARCreditNoteTypeCombo
        {
            get { return _aRCreditNoteTypeCombo; }
            set
            {
                if (value != this._aRCreditNoteTypeCombo)
                {
                    _aRCreditNoteTypeCombo = value;
                }
            }
        }
        public String ARCreditNotePmtTerm
        {
            get { return _aRCreditNotePmtTerm; }
            set
            {
                if (value != this._aRCreditNotePmtTerm)
                {
                    _aRCreditNotePmtTerm = value;
                }
            }
        }
        public String ARPmtMthCombo
        {
            get { return _aRPmtMthCombo; }
            set
            {
                if (value != this._aRPmtMthCombo)
                {
                    _aRPmtMthCombo = value;
                }
            }
        }
        public String ARCreditNoteNo
        {
            get { return _aRCreditNoteNo; }
            set
            {
                if (value != this._aRCreditNoteNo)
                {
                    _aRCreditNoteNo = value;
                }
            }
        }
        public String ARCreditNoteName
        {
            get { return _aRCreditNoteName; }
            set
            {
                if (value != this._aRCreditNoteName)
                {
                    _aRCreditNoteName = value;
                }
            }
        }
        public String ARCreditNoteDesc
        {
            get { return _aRCreditNoteDesc; }
            set
            {
                if (value != this._aRCreditNoteDesc)
                {
                    _aRCreditNoteDesc = value;
                }
            }
        }
        public decimal ARCreditNoteExcRate
        {
            get { return _aRCreditNoteExcRate; }
            set
            {
                if (value != this._aRCreditNoteExcRate)
                {
                    _aRCreditNoteExcRate = value;
                }
            }
        }
        public decimal ARCreditNoteAmt
        {
            get { return _aRCreditNoteAmt; }
            set
            {
                if (value != this._aRCreditNoteAmt)
                {
                    _aRCreditNoteAmt = value;
                 }
            }
        }
        public decimal ARCreditNoteCAmt
        {
            get { return _aRCreditNoteCAmt; }
            set
            {
                if (value != this._aRCreditNoteCAmt)
                {
                    _aRCreditNoteCAmt = value;
                }
            }
        }
        public bool ARCreditNoteOnHoldCheck
        {
            get { return _aRCreditNoteOnHoldCheck; }
            set
            {
                if (value != this._aRCreditNoteOnHoldCheck)
                {
                    _aRCreditNoteOnHoldCheck = value;
                }
            }
        }
        public String ARCreditNoteText
        {
            get { return _aRCreditNoteText; }
            set
            {
                if (value != this._aRCreditNoteText)
                {
                    _aRCreditNoteText = value;
                }
            }
        }
        public DateTime ARCreditNoteDate
        {
            get { return _aRCreditNoteDate; }
            set
            {
                if (value != this._aRCreditNoteDate)
                {
                    _aRCreditNoteDate = value;
                }
            }
        }
        public int ARCreditNoteFiscPer
        {
            get { return _aRCreditNoteFiscPer; }
            set
            {
                if (value != this._aRCreditNoteFiscPer)
                {
                    _aRCreditNoteFiscPer = value;
                }
            }
        }
        public int ARCreditNoteFiscYr
        {
            get { return _aRCreditNoteFiscYr; }
            set
            {
                if (value != this._aRCreditNoteFiscYr)
                {
                    _aRCreditNoteFiscYr = value;
                }
            }
        }
        public Nullable<DateTime> ARCreditNoteShpDate
        {
            get { return _aRCreditNoteShpDate; }
            set
            {
                if (value != this._aRCreditNoteShpDate)
                {
                    _aRCreditNoteShpDate = value;
                }
            }
        }
        public Nullable<DateTime> ARCreditNoteExpireDate
        {
            get { return _aRCreditNoteExpireDate; }
            set
            {
                if (value != this._aRCreditNoteExpireDate)
                {
                    _aRCreditNoteExpireDate = value;
                }
            }
        }
        public decimal ARCreditNoteDiscPct
        {
            get { return _aRCreditNoteDiscPct; }
            set
            {
                if (value != this._aRCreditNoteDiscPct)
                {
                    _aRCreditNoteDiscPct = value;
                }
            }
        }
        public decimal ARCreditNoteDiscAmt
        {
            get { return _aRCreditNoteDiscAmt; }
            set
            {
                if (value != this._aRCreditNoteDiscAmt)
                {
                    _aRCreditNoteDiscAmt = value;
                }
            }
        }
        public String ARCreditNoteRef
        {
            get { return _aRCreditNoteRef; }
            set
            {
                if (value != this._aRCreditNoteRef)
                {
                    _aRCreditNoteRef = value;
                }
            }
        }
        public String ARCreditNoteCusRef
        {
            get { return _aRCreditNoteCusRef; }
            set
            {
                if (value != this._aRCreditNoteCusRef)
                {
                    _aRCreditNoteCusRef = value;
                }
            }
        }
        public String ARCreditNoteComment
        {
            get { return _aRCreditNoteComment; }
            set
            {
                if (value != this._aRCreditNoteComment)
                {
                    _aRCreditNoteComment = value;
                }
            }
        }
        public decimal ARCreditNoteWeight
        {
            get { return _aRCreditNoteWeight; }
            set
            {
                if (value != this._aRCreditNoteWeight)
                {
                    _aRCreditNoteWeight = value;
                }
            }
        }
        public decimal ARCreditNoteVol
        {
            get { return _aRCreditNoteVol; }
            set
            {
                if (value != this._aRCreditNoteVol)
                {
                    _aRCreditNoteVol = value;
                }
            }
        }
        public bool ARCreditNoteActive
        {
            get { return _aRCreditNoteActive; }
            set
            {
                if (value != this._aRCreditNoteActive)
                {
                    _aRCreditNoteActive = value;
                }
            }
        }
        public String ARCreditNoteTxNo
        {
            get { return _aRCreditNoteTxNo; }
            set
            {
                if (value != this._aRCreditNoteTxNo)
                {
                    _aRCreditNoteTxNo = value;
                }
            }
        }
        public String ARCreditNoterdTypeCombo
        {
            get { return _aRCreditNoterdTypeCombo; }
            set
            {
                if (value != this._aRCreditNoterdTypeCombo)
                {
                    _aRCreditNoterdTypeCombo = value;
                }
            }
        }
        public String ARCreditNoteOF01Combo
        {
            get { return _aRCreditNoteOF01Combo; }
            set
            {
                if (value != this._aRCreditNoteOF01Combo)
                {
                    _aRCreditNoteOF01Combo = value;
                }
            }
        }
        public String ARCreditNoteOF02Combo
        {
            get { return _aRCreditNoteOF02Combo; }
            set
            {
                if (value != this._aRCreditNoteOF02Combo)
                {
                    _aRCreditNoteOF02Combo = value;
                }
            }
        }
        public String ARCreditNoteOF03Combo
        {
            get { return _aRCreditNoteOF03Combo; }
            set
            {
                if (value != this._aRCreditNoteOF03Combo)
                {
                    _aRCreditNoteOF03Combo = value;
                }
            }
        }
        public String ARCreditNoteOF04Combo
        {
            get { return _aRCreditNoteOF04Combo; }
            set
            {
                if (value != this._aRCreditNoteOF04Combo)
                {
                    _aRCreditNoteOF04Combo = value;
                }
            }
        }
        public String ARCreditNoteOF05Combo
        {
            get { return _aRCreditNoteOF05Combo; }
            set
            {
                if (value != this._aRCreditNoteOF05Combo)
                {
                    _aRCreditNoteOF05Combo = value;
                }
            }
        }
        public String ARCreditNoteOF06Combo
        {
            get { return _aRCreditNoteOF06Combo; }
            set
            {
                if (value != this._aRCreditNoteOF06Combo)
                {
                    _aRCreditNoteOF06Combo = value;
                }
            }
        }
        public String ARCreditNoteOF07Combo
        {
            get { return _aRCreditNoteOF07Combo; }
            set
            {
                if (value != this._aRCreditNoteOF07Combo)
                {
                    _aRCreditNoteOF07Combo = value;
                }
            }
        }
        public String ARCreditNoteOF08Combo
        {
            get { return _aRCreditNoteOF08Combo; }
            set
            {
                if (value != this._aRCreditNoteOF08Combo)
                {
                    _aRCreditNoteOF08Combo = value;
                }
            }
        }
        public String ARCreditNoteOF09Combo
        {
            get { return _aRCreditNoteOF09Combo; }
            set
            {
                if (value != this._aRCreditNoteOF09Combo)
                {
                    _aRCreditNoteOF09Combo = value;
                }
            }
        }
        public String ARCreditNoteOF10Combo
        {
            get { return _aRCreditNoteOF10Combo; }
            set
            {
                if (value != this._aRCreditNoteOF10Combo)
                {
                    _aRCreditNoteOF10Combo = value;
                }
            }
        }
        public String ARCreditNotePrj
        {
            get { return _aRCreditNotePrj; }
            set
            {
                if (value != this._aRCreditNotePrj)
                {
                    _aRCreditNotePrj = value;
                }
            }
        }
        public String ARCreditNoteCustomerName
        {
            get { return _aRCreditNoteCustomerName; }
            set
            {
                if (value != this._aRCreditNoteCustomerName)
                {
                    _aRCreditNoteCustomerName = value;
                }
            }
        }
        public String ARCreditNoteCustomerDesc
        {
            get { return _aRCreditNoteCustomerDesc; }
            set
            {
                if (value != this._aRCreditNoteCustomerDesc)
                {
                    _aRCreditNoteCustomerDesc = value;
                }
            }
        }
        public int FK_ARCustomerConBTID
        {
            get { return _fK_ARCustomerConBTID; }
            set
            {
                if (value != this._fK_ARCustomerConBTID)
                {
                    _fK_ARCustomerConBTID = value;
                }
            }
        }
        public String ARCreditNoteBTConName
        {
            get { return _aRCreditNoteBTConName; }
            set
            {
                if (value != this._aRCreditNoteBTConName)
                {
                    _aRCreditNoteBTConName = value;
                }
            }
        }
        public String ARCreditNoteBTConFName
        {
            get { return _aRCreditNoteBTConFName; }
            set
            {
                if (value != this._aRCreditNoteBTConFName)
                {
                    _aRCreditNoteBTConFName = value;
                }
            }
        }
        public String ARCreditNoteBTConLName
        {
            get { return _aRCreditNoteBTConLName; }
            set
            {
                if (value != this._aRCreditNoteBTConLName)
                {
                    _aRCreditNoteBTConLName = value;
                }
            }
        }
        public String ARCreditNoteBTConTitle
        {
            get { return _aRCreditNoteBTConTitle; }
            set
            {
                if (value != this._aRCreditNoteBTConTitle)
                {
                    _aRCreditNoteBTConTitle = value;
                }
            }
        }
        public String ARCreditNoteBTConHLet
        {
            get { return _aRCreditNoteBTConHLet; }
            set
            {
                if (value != this._aRCreditNoteBTConHLet)
                {
                    _aRCreditNoteBTConHLet = value;
                }
            }
        }
        public String ARCreditNoteBTConHMsg
        {
            get { return _aRCreditNoteBTConHMsg; }
            set
            {
                if (value != this._aRCreditNoteBTConHMsg)
                {
                    _aRCreditNoteBTConHMsg = value;
                }
            }
        }
        public String ARCreditNoteBTConEmail
        {
            get { return _aRCreditNoteBTConEmail; }
            set
            {
                if (value != this._aRCreditNoteBTConEmail)
                {
                    _aRCreditNoteBTConEmail = value;
                }
            }
        }
        public String ARCreditNoteBTConEmail1
        {
            get { return _aRCreditNoteBTConEmail1; }
            set
            {
                if (value != this._aRCreditNoteBTConEmail1)
                {
                    _aRCreditNoteBTConEmail1 = value;
                }
            }
        }
        public String ARCreditNoteBTConPhone
        {
            get { return _aRCreditNoteBTConPhone; }
            set
            {
                if (value != this._aRCreditNoteBTConPhone)
                {
                    _aRCreditNoteBTConPhone = value;
                   }
            }
        }
        public String ARCreditNoteBTConCPhone
        {
            get { return _aRCreditNoteBTConCPhone; }
            set
            {
                if (value != this._aRCreditNoteBTConCPhone)
                {
                    _aRCreditNoteBTConCPhone = value;
                }
            }
        }
        public String ARCreditNoteBTConFax
        {
            get { return _aRCreditNoteBTConFax; }
            set
            {
                if (value != this._aRCreditNoteBTConFax)
                {
                    _aRCreditNoteBTConFax = value;
                }
            }
        }
        public String ARCreditNoteBTConInfo
        {
            get { return _aRCreditNoteBTConInfo; }
            set
            {
                if (value != this._aRCreditNoteBTConInfo)
                {
                    _aRCreditNoteBTConInfo = value;
                }
            }
        }
        public String ARCreditNoteBTConDept
        {
            get { return _aRCreditNoteBTConDept; }
            set
            {
                if (value != this._aRCreditNoteBTConDept)
                {
                    _aRCreditNoteBTConDept = value;
                }
            }
        }
        public String ARCreditNoteBTConRoom
        {
            get { return _aRCreditNoteBTConRoom; }
            set
            {
                if (value != this._aRCreditNoteBTConRoom)
                {
                    _aRCreditNoteBTConRoom = value;
                }
            }
        }
        public String ARCreditNoteBTAddL1
        {
            get { return _aRCreditNoteBTAddL1; }
            set
            {
                if (value != this._aRCreditNoteBTAddL1)
                {
                    _aRCreditNoteBTAddL1 = value;
                }
            }
        }
        public String ARCreditNoteBTAddL2
        {
            get { return _aRCreditNoteBTAddL2; }
            set
            {
                if (value != this._aRCreditNoteBTAddL2)
                {
                    _aRCreditNoteBTAddL2 = value;
                }
            }
        }
        public String ARCreditNoteBTAddL3
        {
            get { return _aRCreditNoteBTAddL3; }
            set
            {
                if (value != this._aRCreditNoteBTAddL3)
                {
                    _aRCreditNoteBTAddL3 = value;
                }
            }
        }
        public String ARCreditNoteBTAddStr
        {
            get { return _aRCreditNoteBTAddStr; }
            set
            {
                if (value != this._aRCreditNoteBTAddStr)
                {
                    _aRCreditNoteBTAddStr = value;
                }
            }
        }
        public String ARCreditNoteBTAddCity
        {
            get { return _aRCreditNoteBTAddCity; }
            set
            {
                if (value != this._aRCreditNoteBTAddCity)
                {
                    _aRCreditNoteBTAddCity = value;
                }
            }
        }
        public String ARCreditNoteBTAddPCode
        {
            get { return _aRCreditNoteBTAddPCode; }
            set
            {
                if (value != this._aRCreditNoteBTAddPCode)
                {
                    _aRCreditNoteBTAddPCode = value;
                }
            }
        }
        public String ARCreditNoteBTAddStProv
        {
            get { return _aRCreditNoteBTAddStProv; }
            set
            {
                if (value != this._aRCreditNoteBTAddStProv)
                {
                    _aRCreditNoteBTAddStProv = value;
                }
            }
        }
        public String ARCreditNoteBTAddZCode
        {
            get { return _aRCreditNoteBTAddZCode; }
            set
            {
                if (value != this._aRCreditNoteBTAddZCode)
                {
                    _aRCreditNoteBTAddZCode = value;
                }
            }
        }
        public String ARCreditNoteBTAddCountry
        {
            get { return _aRCreditNoteBTAddCountry; }
            set
            {
                if (value != this._aRCreditNoteBTAddCountry)
                {
                    _aRCreditNoteBTAddCountry = value;
                }
            }
        }
        public int FK_ARCustomerConCMID
        {
            get { return _fK_ARCustomerConCMID; }
            set
            {
                if (value != this._fK_ARCustomerConCMID)
                {
                    _fK_ARCustomerConCMID = value;
                }
            }
        }
        public String ARCreditNoteCMConName
        {
            get { return _aRCreditNoteCMConName; }
            set
            {
                if (value != this._aRCreditNoteCMConName)
                {
                    _aRCreditNoteCMConName = value;
                }
            }
        }
        public Nullable<DateTime> ARCreditNoteCMConBday
        {
            get { return _aRCreditNoteCMConBday; }
            set
            {
                if (value != this._aRCreditNoteCMConBday)
                {
                    _aRCreditNoteCMConBday = value;
                }
            }
        }
        public String ARCreditNoteCMConFName
        {
            get { return _aRCreditNoteCMConFName; }
            set
            {
                if (value != this._aRCreditNoteCMConFName)
                {
                    _aRCreditNoteCMConFName = value;
                }
            }
        }
        public String ARCreditNoteCMConLName
        {
            get { return _aRCreditNoteCMConLName; }
            set
            {
                if (value != this._aRCreditNoteCMConLName)
                {
                    _aRCreditNoteCMConLName = value;
                }
            }
        }
        public String ARCreditNoteCMConTitle
        {
            get { return _aRCreditNoteCMConTitle; }
            set
            {
                if (value != this._aRCreditNoteCMConTitle)
                {
                    _aRCreditNoteCMConTitle = value;
                }
            }
        }
        public String ARCreditNoteCMConHLet
        {
            get { return _aRCreditNoteCMConHLet; }
            set
            {
                if (value != this._aRCreditNoteCMConHLet)
                {
                    _aRCreditNoteCMConHLet = value;
                }
            }
        }
        public String ARCreditNoteCMConHMsg
        {
            get { return _aRCreditNoteCMConHMsg; }
            set
            {
                if (value != this._aRCreditNoteCMConHMsg)
                {
                    _aRCreditNoteCMConHMsg = value;
                }
            }
        }
        public String ARCreditNoteCMConEmail
        {
            get { return _aRCreditNoteCMConEmail; }
            set
            {
                if (value != this._aRCreditNoteCMConEmail)
                {
                    _aRCreditNoteCMConEmail = value;
                }
            }
        }
        public String ARCreditNoteCMConEmail1
        {
            get { return _aRCreditNoteCMConEmail1; }
            set
            {
                if (value != this._aRCreditNoteCMConEmail1)
                {
                    _aRCreditNoteCMConEmail1 = value;
                }
            }
        }
        public String ARCreditNoteCMConPhone
        {
            get { return _aRCreditNoteCMConPhone; }
            set
            {
                if (value != this._aRCreditNoteCMConPhone)
                {
                    _aRCreditNoteCMConPhone = value;
                }
            }
        }
        public String ARCreditNoteCMConFax
        {
            get { return _aRCreditNoteCMConFax; }
            set
            {
                if (value != this._aRCreditNoteCMConFax)
                {
                    _aRCreditNoteCMConFax = value;
                }
            }
        }
        public String ARCreditNoteCMConCPhone
        {
            get { return _aRCreditNoteCMConCPhone; }
            set
            {
                if (value != this._aRCreditNoteCMConCPhone)
                {
                    _aRCreditNoteCMConCPhone = value;
                }
            }
        }
        public String ARCreditNoteCMConInfo
        {
            get { return _aRCreditNoteCMConInfo; }
            set
            {
                if (value != this._aRCreditNoteCMConInfo)
                {
                    _aRCreditNoteCMConInfo = value;
                }
            }
        }
        public String ARCreditNoteCMConDept
        {
            get { return _aRCreditNoteCMConDept; }
            set
            {
                if (value != this._aRCreditNoteCMConDept)
                {
                    _aRCreditNoteCMConDept = value;
                }
            }
        }
        public String ARCreditNoteCMConRoom
        {
            get { return _aRCreditNoteCMConRoom; }
            set
            {
                if (value != this._aRCreditNoteCMConRoom)
                {
                    _aRCreditNoteCMConRoom = value;
                }
            }
        }
        public String ARCreditNoteCMAddL1
        {
            get { return _aRCreditNoteCMAddL1; }
            set
            {
                if (value != this._aRCreditNoteCMAddL1)
                {
                    _aRCreditNoteCMAddL1 = value;
                }
            }
        }
        public String ARCreditNoteCMAddL2
        {
            get { return _aRCreditNoteCMAddL2; }
            set
            {
                if (value != this._aRCreditNoteCMAddL2)
                {
                    _aRCreditNoteCMAddL2 = value;
                }
            }
        }
        public String ARCreditNoteCMAddL3
        {
            get { return _aRCreditNoteCMAddL3; }
            set
            {
                if (value != this._aRCreditNoteCMAddL3)
                {
                    _aRCreditNoteCMAddL3 = value;
                }
            }
        }
        public String ARCreditNoteCMAddStr
        {
            get { return _aRCreditNoteCMAddStr; }
            set
            {
                if (value != this._aRCreditNoteCMAddStr)
                {
                    _aRCreditNoteCMAddStr = value;
                }
            }
        }
        public String ARCreditNoteCMAddCity
        {
            get { return _aRCreditNoteCMAddCity; }
            set
            {
                if (value != this._aRCreditNoteCMAddCity)
                {
                    _aRCreditNoteCMAddCity = value;
                }
            }
        }
        public String ARCreditNoteCMAddPCode
        {
            get { return _aRCreditNoteCMAddPCode; }
            set
            {
                if (value != this._aRCreditNoteCMAddPCode)
                {
                    _aRCreditNoteCMAddPCode = value;
                }
            }
        }
        public String ARCreditNoteCMAddStProv
        {
            get { return _aRCreditNoteCMAddStProv; }
            set
            {
                if (value != this._aRCreditNoteCMAddStProv)
                {
                    _aRCreditNoteCMAddStProv = value;
                }
            }
        }
        public String ARCreditNoteCMAddZCode
        {
            get { return _aRCreditNoteCMAddZCode; }
            set
            {
                if (value != this._aRCreditNoteCMAddZCode)
                {
                    _aRCreditNoteCMAddZCode = value;
                }
            }
        }
        public String ARCreditNoteCMAddCountry
        {
            get { return _aRCreditNoteCMAddCountry; }
            set
            {
                if (value != this._aRCreditNoteCMAddCountry)
                {
                    _aRCreditNoteCMAddCountry = value;
                }
            }
        }
        public int FK_ARCustomerConSTID
        {
            get { return _fK_ARCustomerConSTID; }
            set
            {
                if (value != this._fK_ARCustomerConSTID)
                {
                    _fK_ARCustomerConSTID = value;
                }
            }
        }
        public String ARCreditNoteSTConName
        {
            get { return _aRCreditNoteSTConName; }
            set
            {
                if (value != this._aRCreditNoteSTConName)
                {
                    _aRCreditNoteSTConName = value;
                }
            }
        }
        public Nullable<DateTime> ARCreditNoteSTConBday
        {
            get { return _aRCreditNoteSTConBday; }
            set
            {
                if (value != this._aRCreditNoteSTConBday)
                {
                    _aRCreditNoteSTConBday = value;
                }
            }
        }
        public String ARCreditNoteSTConFName
        {
            get { return _aRCreditNoteSTConFName; }
            set
            {
                if (value != this._aRCreditNoteSTConFName)
                {
                    _aRCreditNoteSTConFName = value;
                }
            }
        }
        public String ARCreditNoteSTConLName
        {
            get { return _aRCreditNoteSTConLName; }
            set
            {
                if (value != this._aRCreditNoteSTConLName)
                {
                    _aRCreditNoteSTConLName = value;
                }
            }
        }
        public String ARCreditNoteSTConTitle
        {
            get { return _aRCreditNoteSTConTitle; }
            set
            {
                if (value != this._aRCreditNoteSTConTitle)
                {
                    _aRCreditNoteSTConTitle = value;
                }
            }
        }
        public String ARCreditNoteSTConHLet
        {
            get { return _aRCreditNoteSTConHLet; }
            set
            {
                if (value != this._aRCreditNoteSTConHLet)
                {
                    _aRCreditNoteSTConHLet = value;
                }
            }
        }
        public String ARCreditNoteSTConHMsg
        {
            get { return _aRCreditNoteSTConHMsg; }
            set
            {
                if (value != this._aRCreditNoteSTConHMsg)
                {
                    _aRCreditNoteSTConHMsg = value;
                }
            }
        }
        public String ARCreditNoteSTConEmail
        {
            get { return _aRCreditNoteSTConEmail; }
            set
            {
                if (value != this._aRCreditNoteSTConEmail)
                {
                    _aRCreditNoteSTConEmail = value;
                }
            }
        }
        public String ARCreditNoteSTConEmail1
        {
            get { return _aRCreditNoteSTConEmail1; }
            set
            {
                if (value != this._aRCreditNoteSTConEmail1)
                {
                    _aRCreditNoteSTConEmail1 = value;
                }
            }
        }
        public String ARCreditNoteSTConPhone
        {
            get { return _aRCreditNoteSTConPhone; }
            set
            {
                if (value != this._aRCreditNoteSTConPhone)
                {
                    _aRCreditNoteSTConPhone = value;
                }
            }
        }
        public String ARCreditNoteSTConCPhone
        {
            get { return _aRCreditNoteSTConCPhone; }
            set
            {
                if (value != this._aRCreditNoteSTConCPhone)
                {
                    _aRCreditNoteSTConCPhone = value;
                }
            }
        }
        public String ARCreditNoteSTConFax
        {
            get { return _aRCreditNoteSTConFax; }
            set
            {
                if (value != this._aRCreditNoteSTConFax)
                {
                    _aRCreditNoteSTConFax = value;
                }
            }
        }
        public String ARCreditNoteSTConInfo
        {
            get { return _aRCreditNoteSTConInfo; }
            set
            {
                if (value != this._aRCreditNoteSTConInfo)
                {
                    _aRCreditNoteSTConInfo = value;
                }
            }
        }
        public String ARCreditNoteSTConDept
        {
            get { return _aRCreditNoteSTConDept; }
            set
            {
                if (value != this._aRCreditNoteSTConDept)
                {
                    _aRCreditNoteSTConDept = value;
                }
            }
        }
        public String ARCreditNoteSTConRoom
        {
            get { return _aRCreditNoteSTConRoom; }
            set
            {
                if (value != this._aRCreditNoteSTConRoom)
                {
                    _aRCreditNoteSTConRoom = value;
                }
            }
        }
        public String ARCreditNoteSTAddL1
        {
            get { return _aRCreditNoteSTAddL1; }
            set
            {
                if (value != this._aRCreditNoteSTAddL1)
                {
                    _aRCreditNoteSTAddL1 = value;
                }
            }
        }
        public String ARCreditNoteSTAddL2
        {
            get { return _aRCreditNoteSTAddL2; }
            set
            {
                if (value != this._aRCreditNoteSTAddL2)
                {
                    _aRCreditNoteSTAddL2 = value;
                }
            }
        }
        public String ARCreditNoteSTAddL3
        {
            get { return _aRCreditNoteSTAddL3; }
            set
            {
                if (value != this._aRCreditNoteSTAddL3)
                {
                    _aRCreditNoteSTAddL3 = value;
                }
            }
        }
        public String ARCreditNoteSTAddStr
        {
            get { return _aRCreditNoteSTAddStr; }
            set
            {
                if (value != this._aRCreditNoteSTAddStr)
                {
                    _aRCreditNoteSTAddStr = value;
                }
            }
        }
        public String ARCreditNoteSTAddCity
        {
            get { return _aRCreditNoteSTAddCity; }
            set
            {
                if (value != this._aRCreditNoteSTAddCity)
                {
                    _aRCreditNoteSTAddCity = value;
                }
            }
        }
        public String ARCreditNoteSTAddPCode
        {
            get { return _aRCreditNoteSTAddPCode; }
            set
            {
                if (value != this._aRCreditNoteSTAddPCode)
                {
                    _aRCreditNoteSTAddPCode = value;
                }
            }
        }
        public String ARCreditNoteSTAddStProv
        {
            get { return _aRCreditNoteSTAddStProv; }
            set
            {
                if (value != this._aRCreditNoteSTAddStProv)
                {
                    _aRCreditNoteSTAddStProv = value;
                }
            }
        }
        public String ARCreditNoteSTAddZCode
        {
            get { return _aRCreditNoteSTAddZCode; }
            set
            {
                if (value != this._aRCreditNoteSTAddZCode)
                {
                    _aRCreditNoteSTAddZCode = value;
                }
            }
        }
        public String ARCreditNoteSTAddCountry
        {
            get { return _aRCreditNoteSTAddCountry; }
            set
            {
                if (value != this._aRCreditNoteSTAddCountry)
                {
                    _aRCreditNoteSTAddCountry = value;
               }
            }
        }
        public decimal ARCreditNoteShpAmt
        {
            get { return _aRCreditNoteShpAmt; }
            set
            {
                if (value != this._aRCreditNoteShpAmt)
                {
                    _aRCreditNoteShpAmt = value;
                }
            }
        }
        public decimal ARCreditNoteItmPriceTot
        {
            get { return _aRCreditNoteItmPriceTot; }
            set
            {
                if (value != this._aRCreditNoteItmPriceTot)
                {
                    _aRCreditNoteItmPriceTot = value;
                }
            }
        }
        public decimal ARCreditNoteItmDiscAmtTot
        {
            get { return _aRCreditNoteItmDiscAmtTot; }
            set
            {
                if (value != this._aRCreditNoteItmDiscAmtTot)
                {
                    _aRCreditNoteItmDiscAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteItmAmtTot
        {
            get { return _aRCreditNoteItmAmtTot; }
            set
            {
                if (value != this._aRCreditNoteItmAmtTot)
                {
                    _aRCreditNoteItmAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteTxAmtTot
        {
            get { return _aRCreditNoteTxAmtTot; }
            set
            {
                if (value != this._aRCreditNoteTxAmtTot)
                {
                    _aRCreditNoteTxAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteNetAmtTot
        {
            get { return _aRCreditNoteNetAmtTot; }
            set
            {
                if (value != this._aRCreditNoteNetAmtTot)
                {
                    _aRCreditNoteNetAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteAmtTot
        {
            get { return _aRCreditNoteAmtTot; }
            set
            {
                if (value != this._aRCreditNoteAmtTot)
                {
                    _aRCreditNoteAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteRAmtTot
        {
            get { return _aRCreditNoteRAmtTot; }
            set
            {
                if (value != this._aRCreditNoteRAmtTot)
                {
                    _aRCreditNoteRAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteMiscChargeAmt
        {
            get { return _aRCreditNoteMiscChargeAmt; }
            set
            {
                if (value != this._aRCreditNoteMiscChargeAmt)
                {
                    _aRCreditNoteMiscChargeAmt = value;
                }
            }
        }
        public decimal ARCreditNoteCostTot
        {
            get { return _aRCreditNoteCostTot; }
            set
            {
                if (value != this._aRCreditNoteCostTot)
                {
                    _aRCreditNoteCostTot = value;
                }
            }
        }
        public decimal ARCreditNoteMargPct
        {
            get { return _aRCreditNoteMargPct; }
            set
            {
                if (value != this._aRCreditNoteMargPct)
                {
                    _aRCreditNoteMargPct = value;
                }
            }
        }
        public String AAPostStatus
        {
            get { return _aAPostStatus; }
            set
            {
                if (value != this._aAPostStatus)
                {
                    _aAPostStatus = value;
                }
            }
        }
        public decimal ARCreditNoteFRAmtTot
        {
            get { return _aRCreditNoteFRAmtTot; }
            set
            {
                if (value != this._aRCreditNoteFRAmtTot)
                {
                    _aRCreditNoteFRAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteFAmtTot
        {
            get { return _aRCreditNoteFAmtTot; }
            set
            {
                if (value != this._aRCreditNoteFAmtTot)
                {
                    _aRCreditNoteFAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteFImpTxAmtTot
        {
            get { return _aRCreditNoteFImpTxAmtTot; }
            set
            {
                if (value != this._aRCreditNoteFImpTxAmtTot)
                {
                    _aRCreditNoteFImpTxAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteFTxAmtTot
        {
            get { return _aRCreditNoteFTxAmtTot; }
            set
            {
                if (value != this._aRCreditNoteFTxAmtTot)
                {
                    _aRCreditNoteFTxAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteFItmAmtTot
        {
            get { return _aRCreditNoteFItmAmtTot; }
            set
            {
                if (value != this._aRCreditNoteFItmAmtTot)
                {
                    _aRCreditNoteFItmAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteFItmDiscAmtTot
        {
            get { return _aRCreditNoteFItmDiscAmtTot; }
            set
            {
                if (value != this._aRCreditNoteFItmDiscAmtTot)
                {
                    _aRCreditNoteFItmDiscAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteFItmPriceTot
        {
            get { return _aRCreditNoteFItmPriceTot; }
            set
            {
                if (value != this._aRCreditNoteFItmPriceTot)
                {
                    _aRCreditNoteFItmPriceTot = value;
                }
            }
        }
        public decimal ARCreditNoteItmFPriceTot
        {
            get { return _aRCreditNoteItmFPriceTot; }
            set
            {
                if (value != this._aRCreditNoteItmFPriceTot)
                {
                    _aRCreditNoteItmFPriceTot = value;
                }
            }
        }
        public decimal ARCreditNoteItmDiscFAmtTot
        {
            get { return _aRCreditNoteItmDiscFAmtTot; }
            set
            {
                if (value != this._aRCreditNoteItmDiscFAmtTot)
                {
                    _aRCreditNoteItmDiscFAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteItmFAmtTot
        {
            get { return _aRCreditNoteItmFAmtTot; }
            set
            {
                if (value != this._aRCreditNoteItmFAmtTot)
                {
                    _aRCreditNoteItmFAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteTxFAmtTot
        {
            get { return _aRCreditNoteTxFAmtTot; }
            set
            {
                if (value != this._aRCreditNoteTxFAmtTot)
                {
                    _aRCreditNoteTxFAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteNetFAmtTot
        {
            get { return _aRCreditNoteNetFAmtTot; }
            set
            {
                if (value != this._aRCreditNoteNetFAmtTot)
                {
                    _aRCreditNoteNetFAmtTot = value;
                }
            }
        }
        public decimal ARCreditNoteRFAmtTot
        {
            get { return _aRCreditNoteRFAmtTot; }
            set
            {
                if (value != this._aRCreditNoteRFAmtTot)
                {
                    _aRCreditNoteRFAmtTot = value;
                }
            }
        }
        public String AALastPostNo
        {
            get { return _aALastPostNo; }
            set
            {
                if (value != this._aALastPostNo)
                {
                    _aALastPostNo = value;
                }
            }
        }
        public Nullable<DateTime> AALastPostDate
        {
            get { return _aALastPostDate; }
            set
            {
                if (value != this._aALastPostDate)
                {
                    _aALastPostDate = value;
                }
            }
        }
        public String ApprovalStatusCombo
        {
            get { return _approvalStatusCombo; }
            set
            {
                if (value != this._approvalStatusCombo)
                {
                    _approvalStatusCombo = value;
                }
            }
        }
        public String ARCreditNoteInvNo
        {
            get { return _aRCreditNoteInvNo; }
            set
            {
                if (value != this._aRCreditNoteInvNo)
                {
                    _aRCreditNoteInvNo = value;
                }
            }
        }
        public String ARCreditNoteInvSerie
        {
            get { return _aRCreditNoteInvSerie; }
            set
            {
                if (value != this._aRCreditNoteInvSerie)
                {
                    _aRCreditNoteInvSerie = value;
                }
            }
        }
        public Nullable<DateTime> ARCreditNoteInvDate
        {
            get { return _aRCreditNoteInvDate; }
            set
            {
                if (value != this._aRCreditNoteInvDate)
                {
                    _aRCreditNoteInvDate = value;
                }
            }
        }
        public int FK_GEInvTypeID
        {
            get { return _fK_GEInvTypeID; }
            set
            {
                if (value != this._fK_GEInvTypeID)
                {
                    _fK_GEInvTypeID = value;
                }
            }
        }
        public String ARCreditNoteInvForm
        {
            get { return _aRCreditNoteInvForm; }
            set
            {
                if (value != this._aRCreditNoteInvForm)
                {
                    _aRCreditNoteInvForm = value;
                }
            }
        }
        public Nullable<DateTime> ARCreditNoteJrnDate
        {
            get { return _aRCreditNoteJrnDate; }
            set
            {
                if (value != this._aRCreditNoteJrnDate)
                {
                    _aRCreditNoteJrnDate = value;
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
        public String ARCreditNoteInvDesc
        {
            get { return _aRCreditNoteInvDesc; }
            set
            {
                if (value != this._aRCreditNoteInvDesc)
                {
                    _aRCreditNoteInvDesc = value;
                }
            }
        }
        public String AAModule
        {
            get { return _aAModule; }
            set
            {
                if (value != this._aAModule)
                {
                    _aAModule = value;
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
        public String ARCreditNoteSupAdd
        {
            get { return _aRCreditNoteSupAdd; }
            set
            {
                if (value != this._aRCreditNoteSupAdd)
                {
                    _aRCreditNoteSupAdd = value;
                }
            }
        }
        public String ARCreditNoteOptional01
        {
            get { return _aRCreditNoteOptional01; }
            set
            {
                if (value != this._aRCreditNoteOptional01)
                {
                    _aRCreditNoteOptional01 = value;
                }
            }
        }
        public String ARCreditNoteOptional02
        {
            get { return _aRCreditNoteOptional02; }
            set
            {
                if (value != this._aRCreditNoteOptional02)
                {
                    _aRCreditNoteOptional02 = value;
                }
            }
        }
        public String ARCreditNoteOptional03
        {
            get { return _aRCreditNoteOptional03; }
            set
            {
                if (value != this._aRCreditNoteOptional03)
                {
                    _aRCreditNoteOptional03 = value;
                }
            }
        }
        public int FK_GLAccountID
        {
            get { return _fK_GLAccountID; }
            set
            {
                if (value != this._fK_GLAccountID)
                {
                    _fK_GLAccountID = value;
                }
            }
        }
        public String ARCreditNoteJrnNo
        {
            get { return _aRCreditNoteJrnNo; }
            set
            {
                if (value != this._aRCreditNoteJrnNo)
                {
                    _aRCreditNoteJrnNo = value;
                }
            }
        }
        public int FK_GECurrencyExObjID
        {
            get { return _fK_GECurrencyExObjID; }
            set
            {
                if (value != this._fK_GECurrencyExObjID)
                {
                    _fK_GECurrencyExObjID = value;
                }
            }
        }
        public int FK_GLOrgTranCfgID
        {
            get { return _fK_GLOrgTranCfgID; }
            set
            {
                if (value != this._fK_GLOrgTranCfgID)
                {
                    _fK_GLOrgTranCfgID = value;
                }
            }
        }
        public int FK_AROrgInvoiceID
        {
            get { return _fK_AROrgInvoiceID; }
            set
            {
                if (value != this._fK_AROrgInvoiceID)
                {
                    _fK_AROrgInvoiceID = value;
                }
            }
        }
        public String ARInvoiceRef
        {
            get { return _aRInvoiceRef; }
            set
            {
                if (value != this._aRInvoiceRef)
                {
                    _aRInvoiceRef = value;
                 }
            }
        }

        #endregion
    }
}
