using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICTransfers")]
    public class ICTransfers : BaseInfo
    {
        #region Variables
        protected int _iCTransferID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_GECurrencyID;
        protected int _fK_GEShpMthID;
        protected int _fK_ICFromStockID;
        protected int _fK_ICToStockID;
        protected int _fK_ICTransitStockID;
        protected int _fK_BRBranchID;
        protected String _iCTransferStatusCombo = DefaultStatus;
        protected String _iCTransferTypeCombo = String.Empty;
        protected String _iCPmtMthCombo = String.Empty;
        protected String _iCTransferNo = String.Empty;
        protected String _iCTransferName = String.Empty;
        protected String _iCTransferDesc = String.Empty;
        protected bool _iCTransferOnHoldCheck = true;
        protected String _iCTransferText = String.Empty;
        protected DateTime _iCTransferDate = DateTime.Now;
        protected int _iCTransferFiscPer;
        protected int _iCTransferFiscYr;
        protected Nullable<DateTime> _iCTransferShpDate;
        protected Nullable<DateTime> _iCTransferExpireDate;
        protected String _iCTransferRef = String.Empty;
        protected String _iCTransferCusRef = String.Empty;
        protected String _iCTransferComment = String.Empty;
        protected decimal _iCTransferWeight;
        protected decimal _iCTransferVol;
        protected bool _iCTransferActive = true;
        protected String _iCTransferTxNo = String.Empty;
        protected decimal _iCTransferExcRate;
        protected decimal _iCTransferAmt;
        protected decimal _iCTransferCAmt;
        protected String _iCTransferOF01Combo = String.Empty;
        protected String _iCTransferOF02Combo = String.Empty;
        protected String _iCTransferOF03Combo = String.Empty;
        protected String _iCTransferOF04Combo = String.Empty;
        protected String _iCTransferOF05Combo = String.Empty;
        protected String _iCTransferOF06Combo = String.Empty;
        protected String _iCTransferOF07Combo = String.Empty;
        protected String _iCTransferOF08Combo = String.Empty;
        protected String _iCTransferOF09Combo = String.Empty;
        protected String _iCTransferOF10Combo = String.Empty;
        protected String _iCTransferPrj = String.Empty;
        protected String _iCTransferStkFConName = String.Empty;
        protected String _iCTransferStkFConFName = String.Empty;
        protected String _iCTransferStkFConLName = String.Empty;
        protected String _iCTransferStkFConTitle = String.Empty;
        protected String _iCTransferStkFConHLet = String.Empty;
        protected String _iCTransferStkFConHMsg = String.Empty;
        protected String _iCTransfeStkFConEmail = String.Empty;
        protected String _iCTransferBTConEmail1 = String.Empty;
        protected String _iCTransferStkFConPhone = String.Empty;
        protected String _iCTransferStkFConCPhone = String.Empty;
        protected String _iCTransferStkFConFax = String.Empty;
        protected String _iCTransferStkFConInfo = String.Empty;
        protected String _iCTransferStkFConDept = String.Empty;
        protected String _iCTransferStkFConRoom = String.Empty;
        protected String _iCTransferStkFAddL1 = String.Empty;
        protected String _iCTransferStkFAddL2 = String.Empty;
        protected String _iCTransferStkFAddL3 = String.Empty;
        protected String _iCTransferStkFAddStr = String.Empty;
        protected String _iCTransferStkFAddCity = String.Empty;
        protected String _iCTransferStkFAddPCode = String.Empty;
        protected String _iCTransferStkFAddStProv = String.Empty;
        protected String _iCTransferStkFAddZCode = String.Empty;
        protected String _iCTransferStkFAddCountry = String.Empty;
        protected String _iCTransferStkTrsConName = String.Empty;
        protected Nullable<DateTime> _iCTransferStkTrsConBday;
        protected String _iCTransferStkTrsConFName = String.Empty;
        protected String _iCTransferStkTrsConLName = String.Empty;
        protected String _iCTransferStkTrsConTitle = String.Empty;
        protected String _iCTransferStkTrsConHLet = String.Empty;
        protected String _iCTransferStkTrsConHMsg = String.Empty;
        protected String _iCTransferStkTrsConEmail = String.Empty;
        protected String _iCTransferStkTrsConEmail1 = String.Empty;
        protected String _iCTransferStkTrsConPhone = String.Empty;
        protected String _iCTransferStkTrsConFax = String.Empty;
        protected String _iCTransferStkTrsConCPhone = String.Empty;
        protected String _iCTransferStkTrsConInfo = String.Empty;
        protected String _iCTransferStkTrsConDept = String.Empty;
        protected String _iCTransferStkTrsConRoom = String.Empty;
        protected String _iCTransferStkTrsAddL1 = String.Empty;
        protected String _iCTransferStkTrsAddL2 = String.Empty;
        protected String _iCTransferStkTrsAddL3 = String.Empty;
        protected String _iCTransferStkTrsAddStr = String.Empty;
        protected String _iCTransferStkTrsAddCity = String.Empty;
        protected String _iCTransferStkTrsAddPCode = String.Empty;
        protected String _iCTransferStkTrsAddStProv = String.Empty;
        protected String _iCTransferStkTrsAddZCode = String.Empty;
        protected String _iCTransferStkTrsAddCountry = String.Empty;
        protected String _iCTransferStkTConName = String.Empty;
        protected Nullable<DateTime> _iCTransferStkTConBday;
        protected String _iCTransferStkTConFName = String.Empty;
        protected String _iCTransferStkTConLName = String.Empty;
        protected String _iCTransferStkTConTitle = String.Empty;
        protected String _iCTransferStkTConHLet = String.Empty;
        protected String _iCTransferStkTConHMsg = String.Empty;
        protected String _iCTransferStkTConEmail = String.Empty;
        protected String _iCTransferStkTConEmail1 = String.Empty;
        protected String _iCTransferStkTConPhone = String.Empty;
        protected String _iCTransferStkTConCPhone = String.Empty;
        protected String _iCTransferStkTConFax = String.Empty;
        protected String _iCTransferStkTConInfo = String.Empty;
        protected String _iCTransferStkTConDept = String.Empty;
        protected String _iCTransferStkTConRoom = String.Empty;
        protected String _iCTransferStkTAddL1 = String.Empty;
        protected String _iCTransferStkTAddL2 = String.Empty;
        protected String _iCTransferStkTAddL3 = String.Empty;
        protected String _iCTransferStkTAddStr = String.Empty;
        protected String _iCTransferStkTAddCity = String.Empty;
        protected String _iCTransferStkTAddPCode = String.Empty;
        protected String _iCTransferStkTAddStProv = String.Empty;
        protected String _iCTransferStkTAddZCode = String.Empty;
        protected String _iCTransferStkTAddCountry = String.Empty;
        protected decimal _iCTransferShpAmt;
        protected decimal _iCTransferItmPriceTot;
        protected decimal _iCTransferItmDiscAmtTot;
        protected decimal _iCTransferItmAmtTot;
        protected decimal _iCTransferTxAmtTot;
        protected decimal _iCTransferNetAmtTot;
        protected decimal _iCTransferAmtTot;
        protected decimal _iCTransferMiscChargeAmt;
        protected decimal _iCTransferCostTot;
        protected decimal _iCTransferMargPct;
        protected String _aAPostStatus = DefaultStatus;
        protected String _aALastPostNo = String.Empty;
        protected Nullable<DateTime> _aALastPostDate;
        protected int _fK_GLTranCfgID;
        protected String _iCTransferLotNo = String.Empty;
        protected String _aACompanyTypeCombo = String.Empty;
        protected String _aAThueRemark = String.Empty;
        protected String _aAOrgDocNo = String.Empty;
        protected int _fK_APSupplierID;
        protected int _fK_ARCustomerID;
        protected int _fK_HREmployeeID;
        protected int _fK_APSupplierConID;
        protected int _fK_PPWOID;
        protected Nullable<DateTime> _iCTransferJrnDate;
        protected String _aAModule = String.Empty;
        protected int _fK_PPProductionOrdrID;
        protected String _iCTransferJrnNo = String.Empty;
        protected String _iCTransferInvSerie = String.Empty;
        protected int _fK_ARCustomerConBTID;
        protected String _iCTransferBTConName = String.Empty;
        protected String _iCTransferBTConEmail = String.Empty;
        protected String _iCTransferBTConPhone = String.Empty;
        protected String _iCTransferBTConDept = String.Empty;
        protected String _iCTransferBTAddL1 = String.Empty;
        protected String _iCTransferBTAddL2 = String.Empty;
        protected String _iCTransferSTConName = String.Empty;
        protected String _iCTransferSTConEmail = String.Empty;
        protected String _iCTransferSTConPhone = String.Empty;
        protected String _iCTransferSTConDept = String.Empty;
        protected String _iCTransferSTAddL1 = String.Empty;
        protected String _iCTransferSTAddL2 = String.Empty;
        protected String _iCTransferBTConFax = String.Empty;
        protected String _iCTransferInvNo = String.Empty;
        protected Nullable<DateTime> _iCTransferInvDate;
        protected String _iCTransferInvForm = String.Empty;
        protected String _iCTransferInvDesc = String.Empty;
        protected int _fK_GELanguageID;
        protected String _iCTransferBTConInfo = String.Empty;
        protected int _fK_ARCustomerConSTID;
        protected String _iCTransferSTConFName = String.Empty;
        protected String _iCTransferSTConFax = String.Empty;
        protected String _iCTransferOOF12Combo = String.Empty;
        protected String _iCTransferOF11Combo = String.Empty;
        protected String _iCTransferOF12Combo = String.Empty;
        protected String _iCTransferOF13Combo = String.Empty;
        protected String _iCTransferOF14Combo = String.Empty;
        protected int _fK_APPOID;
        protected int _fK_LOConsigneeID;
        protected String _iCTransferConsigneeName = String.Empty;
        protected String _iCTransferConsigneeAddress = String.Empty;
        protected String _iCTransferConsigneeTaxNo = String.Empty;
        protected String _iCTransferShipperTaxNo = String.Empty;
        protected String _iCTransferShipperAddress = String.Empty;
        protected String _iCTransferShipperName = String.Empty;
        protected String _iCTransferLadingNo = String.Empty;
        protected Nullable<DateTime> _iCTransferLadingDate;
        protected String _iCTransferDeclarationNo = String.Empty;
        protected Nullable<DateTime> _iCTransferDeclarationDate;
        protected String _iCTransferSupAdd = String.Empty;
        protected String _iCTransferOptional01 = String.Empty;
        protected String _iCTransferOptional02 = String.Empty;
        protected String _iCTransferOptional03 = String.Empty;

        #endregion
        #region Public properties
        [Key]
        public int ICTransferID
        {
            get { return _iCTransferID; }
            set
            {
                if (value != this._iCTransferID)
                {
                    _iCTransferID = value;
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
        public String ICTransferStatusCombo
        {
            get { return _iCTransferStatusCombo; }
            set
            {
                if (value != this._iCTransferStatusCombo)
                {
                    _iCTransferStatusCombo = value;
                }
            }
        }
        public String ICTransferTypeCombo
        {
            get { return _iCTransferTypeCombo; }
            set
            {
                if (value != this._iCTransferTypeCombo)
                {
                    _iCTransferTypeCombo = value;
                }
            }
        }
        public String ICPmtMthCombo
        {
            get { return _iCPmtMthCombo; }
            set
            {
                if (value != this._iCPmtMthCombo)
                {
                    _iCPmtMthCombo = value;
                }
            }
        }
        public String ICTransferNo
        {
            get { return _iCTransferNo; }
            set
            {
                if (value != this._iCTransferNo)
                {
                    _iCTransferNo = value;
                }
            }
        }
        public String ICTransferName
        {
            get { return _iCTransferName; }
            set
            {
                if (value != this._iCTransferName)
                {
                    _iCTransferName = value;
                }
            }
        }
        public String ICTransferDesc
        {
            get { return _iCTransferDesc; }
            set
            {
                if (value != this._iCTransferDesc)
                {
                    _iCTransferDesc = value;
                }
            }
        }
        public bool ICTransferOnHoldCheck
        {
            get { return _iCTransferOnHoldCheck; }
            set
            {
                if (value != this._iCTransferOnHoldCheck)
                {
                    _iCTransferOnHoldCheck = value;
                }
            }
        }
        public String ICTransferText
        {
            get { return _iCTransferText; }
            set
            {
                if (value != this._iCTransferText)
                {
                    _iCTransferText = value;
                }
            }
        }
        public DateTime ICTransferDate
        {
            get { return _iCTransferDate; }
            set
            {
                if (value != this._iCTransferDate)
                {
                    _iCTransferDate = value;
                }
            }
        }
        public int ICTransferFiscPer
        {
            get { return _iCTransferFiscPer; }
            set
            {
                if (value != this._iCTransferFiscPer)
                {
                    _iCTransferFiscPer = value;
                }
            }
        }
        public int ICTransferFiscYr
        {
            get { return _iCTransferFiscYr; }
            set
            {
                if (value != this._iCTransferFiscYr)
                {
                    _iCTransferFiscYr = value;
                }
            }
        }
        public Nullable<DateTime> ICTransferShpDate
        {
            get { return _iCTransferShpDate; }
            set
            {
                if (value != this._iCTransferShpDate)
                {
                    _iCTransferShpDate = value;
                }
            }
        }
        public Nullable<DateTime> ICTransferExpireDate
        {
            get { return _iCTransferExpireDate; }
            set
            {
                if (value != this._iCTransferExpireDate)
                {
                    _iCTransferExpireDate = value;
                }
            }
        }
        public String ICTransferRef
        {
            get { return _iCTransferRef; }
            set
            {
                if (value != this._iCTransferRef)
                {
                    _iCTransferRef = value;
                }
            }
        }
        public String ICTransferCusRef
        {
            get { return _iCTransferCusRef; }
            set
            {
                if (value != this._iCTransferCusRef)
                {
                    _iCTransferCusRef = value;
                }
            }
        }
        public String ICTransferComment
        {
            get { return _iCTransferComment; }
            set
            {
                if (value != this._iCTransferComment)
                {
                    _iCTransferComment = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferWeight
        {
            get { return _iCTransferWeight; }
            set
            {
                if (value != this._iCTransferWeight)
                {
                    _iCTransferWeight = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferVol
        {
            get { return _iCTransferVol; }
            set
            {
                if (value != this._iCTransferVol)
                {
                    _iCTransferVol = value;
                }
            }
        }
        public bool ICTransferActive
        {
            get { return _iCTransferActive; }
            set
            {
                if (value != this._iCTransferActive)
                {
                    _iCTransferActive = value;
                }
            }
        }
        public String ICTransferTxNo
        {
            get { return _iCTransferTxNo; }
            set
            {
                if (value != this._iCTransferTxNo)
                {
                    _iCTransferTxNo = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferExcRate
        {
            get { return _iCTransferExcRate; }
            set
            {
                if (value != this._iCTransferExcRate)
                {
                    _iCTransferExcRate = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferAmt
        {
            get { return _iCTransferAmt; }
            set
            {
                if (value != this._iCTransferAmt)
                {
                    _iCTransferAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferCAmt
        {
            get { return _iCTransferCAmt; }
            set
            {
                if (value != this._iCTransferCAmt)
                {
                    _iCTransferCAmt = value;
                }
            }
        }
        public String ICTransferOF01Combo
        {
            get { return _iCTransferOF01Combo; }
            set
            {
                if (value != this._iCTransferOF01Combo)
                {
                    _iCTransferOF01Combo = value;
                }
            }
        }
        public String ICTransferOF02Combo
        {
            get { return _iCTransferOF02Combo; }
            set
            {
                if (value != this._iCTransferOF02Combo)
                {
                    _iCTransferOF02Combo = value;
                }
            }
        }
        public String ICTransferOF03Combo
        {
            get { return _iCTransferOF03Combo; }
            set
            {
                if (value != this._iCTransferOF03Combo)
                {
                    _iCTransferOF03Combo = value;
                }
            }
        }
        public String ICTransferOF04Combo
        {
            get { return _iCTransferOF04Combo; }
            set
            {
                if (value != this._iCTransferOF04Combo)
                {
                    _iCTransferOF04Combo = value;
                }
            }
        }
        public String ICTransferOF05Combo
        {
            get { return _iCTransferOF05Combo; }
            set
            {
                if (value != this._iCTransferOF05Combo)
                {
                    _iCTransferOF05Combo = value;
                }
            }
        }
        public String ICTransferOF06Combo
        {
            get { return _iCTransferOF06Combo; }
            set
            {
                if (value != this._iCTransferOF06Combo)
                {
                    _iCTransferOF06Combo = value;
                }
            }
        }
        public String ICTransferOF07Combo
        {
            get { return _iCTransferOF07Combo; }
            set
            {
                if (value != this._iCTransferOF07Combo)
                {
                    _iCTransferOF07Combo = value;
                }
            }
        }
        public String ICTransferOF08Combo
        {
            get { return _iCTransferOF08Combo; }
            set
            {
                if (value != this._iCTransferOF08Combo)
                {
                    _iCTransferOF08Combo = value;
                }
            }
        }
        public String ICTransferOF09Combo
        {
            get { return _iCTransferOF09Combo; }
            set
            {
                if (value != this._iCTransferOF09Combo)
                {
                    _iCTransferOF09Combo = value;
                }
            }
        }
        public String ICTransferOF10Combo
        {
            get { return _iCTransferOF10Combo; }
            set
            {
                if (value != this._iCTransferOF10Combo)
                {
                    _iCTransferOF10Combo = value;
                }
            }
        }
        public String ICTransferPrj
        {
            get { return _iCTransferPrj; }
            set
            {
                if (value != this._iCTransferPrj)
                {
                    _iCTransferPrj = value;
                }
            }
        }
        public String ICTransferStkFConName
        {
            get { return _iCTransferStkFConName; }
            set
            {
                if (value != this._iCTransferStkFConName)
                {
                    _iCTransferStkFConName = value;
                }
            }
        }
        public String ICTransferStkFConFName
        {
            get { return _iCTransferStkFConFName; }
            set
            {
                if (value != this._iCTransferStkFConFName)
                {
                    _iCTransferStkFConFName = value;
                }
            }
        }
        public String ICTransferStkFConLName
        {
            get { return _iCTransferStkFConLName; }
            set
            {
                if (value != this._iCTransferStkFConLName)
                {
                    _iCTransferStkFConLName = value;
                }
            }
        }
        public String ICTransferStkFConTitle
        {
            get { return _iCTransferStkFConTitle; }
            set
            {
                if (value != this._iCTransferStkFConTitle)
                {
                    _iCTransferStkFConTitle = value;
                }
            }
        }
        public String ICTransferStkFConHLet
        {
            get { return _iCTransferStkFConHLet; }
            set
            {
                if (value != this._iCTransferStkFConHLet)
                {
                    _iCTransferStkFConHLet = value;
                }
            }
        }
        public String ICTransferStkFConHMsg
        {
            get { return _iCTransferStkFConHMsg; }
            set
            {
                if (value != this._iCTransferStkFConHMsg)
                {
                    _iCTransferStkFConHMsg = value;
                }
            }
        }
        public String ICTransfeStkFConEmail
        {
            get { return _iCTransfeStkFConEmail; }
            set
            {
                if (value != this._iCTransfeStkFConEmail)
                {
                    _iCTransfeStkFConEmail = value;
                }
            }
        }
        public String ICTransferBTConEmail1
        {
            get { return _iCTransferBTConEmail1; }
            set
            {
                if (value != this._iCTransferBTConEmail1)
                {
                    _iCTransferBTConEmail1 = value;
                }
            }
        }
        public String ICTransferStkFConPhone
        {
            get { return _iCTransferStkFConPhone; }
            set
            {
                if (value != this._iCTransferStkFConPhone)
                {
                    _iCTransferStkFConPhone = value;
                }
            }
        }
        public String ICTransferStkFConCPhone
        {
            get { return _iCTransferStkFConCPhone; }
            set
            {
                if (value != this._iCTransferStkFConCPhone)
                {
                    _iCTransferStkFConCPhone = value;
                }
            }
        }
        public String ICTransferStkFConFax
        {
            get { return _iCTransferStkFConFax; }
            set
            {
                if (value != this._iCTransferStkFConFax)
                {
                    _iCTransferStkFConFax = value;
                }
            }
        }
        public String ICTransferStkFConInfo
        {
            get { return _iCTransferStkFConInfo; }
            set
            {
                if (value != this._iCTransferStkFConInfo)
                {
                    _iCTransferStkFConInfo = value;
                }
            }
        }
        public String ICTransferStkFConDept
        {
            get { return _iCTransferStkFConDept; }
            set
            {
                if (value != this._iCTransferStkFConDept)
                {
                    _iCTransferStkFConDept = value;
                }
            }
        }
        public String ICTransferStkFConRoom
        {
            get { return _iCTransferStkFConRoom; }
            set
            {
                if (value != this._iCTransferStkFConRoom)
                {
                    _iCTransferStkFConRoom = value;
                }
            }
        }
        public String ICTransferStkFAddL1
        {
            get { return _iCTransferStkFAddL1; }
            set
            {
                if (value != this._iCTransferStkFAddL1)
                {
                    _iCTransferStkFAddL1 = value;
                }
            }
        }
        public String ICTransferStkFAddL2
        {
            get { return _iCTransferStkFAddL2; }
            set
            {
                if (value != this._iCTransferStkFAddL2)
                {
                    _iCTransferStkFAddL2 = value;
                }
            }
        }
        public String ICTransferStkFAddL3
        {
            get { return _iCTransferStkFAddL3; }
            set
            {
                if (value != this._iCTransferStkFAddL3)
                {
                    _iCTransferStkFAddL3 = value;
                }
            }
        }
        public String ICTransferStkFAddStr
        {
            get { return _iCTransferStkFAddStr; }
            set
            {
                if (value != this._iCTransferStkFAddStr)
                {
                    _iCTransferStkFAddStr = value;
                }
            }
        }
        public String ICTransferStkFAddCity
        {
            get { return _iCTransferStkFAddCity; }
            set
            {
                if (value != this._iCTransferStkFAddCity)
                {
                    _iCTransferStkFAddCity = value;
                }
            }
        }
        public String ICTransferStkFAddPCode
        {
            get { return _iCTransferStkFAddPCode; }
            set
            {
                if (value != this._iCTransferStkFAddPCode)
                {
                    _iCTransferStkFAddPCode = value;
                }
            }
        }
        public String ICTransferStkFAddStProv
        {
            get { return _iCTransferStkFAddStProv; }
            set
            {
                if (value != this._iCTransferStkFAddStProv)
                {
                    _iCTransferStkFAddStProv = value;
                }
            }
        }
        public String ICTransferStkFAddZCode
        {
            get { return _iCTransferStkFAddZCode; }
            set
            {
                if (value != this._iCTransferStkFAddZCode)
                {
                    _iCTransferStkFAddZCode = value;
                }
            }
        }
        public String ICTransferStkFAddCountry
        {
            get { return _iCTransferStkFAddCountry; }
            set
            {
                if (value != this._iCTransferStkFAddCountry)
                {
                    _iCTransferStkFAddCountry = value;
                }
            }
        }
        public String ICTransferStkTrsConName
        {
            get { return _iCTransferStkTrsConName; }
            set
            {
                if (value != this._iCTransferStkTrsConName)
                {
                    _iCTransferStkTrsConName = value;
                }
            }
        }
        public Nullable<DateTime> ICTransferStkTrsConBday
        {
            get { return _iCTransferStkTrsConBday; }
            set
            {
                if (value != this._iCTransferStkTrsConBday)
                {
                    _iCTransferStkTrsConBday = value;
                }
            }
        }
        public String ICTransferStkTrsConFName
        {
            get { return _iCTransferStkTrsConFName; }
            set
            {
                if (value != this._iCTransferStkTrsConFName)
                {
                    _iCTransferStkTrsConFName = value;
                }
            }
        }
        public String ICTransferStkTrsConLName
        {
            get { return _iCTransferStkTrsConLName; }
            set
            {
                if (value != this._iCTransferStkTrsConLName)
                {
                    _iCTransferStkTrsConLName = value;
                }
            }
        }
        public String ICTransferStkTrsConTitle
        {
            get { return _iCTransferStkTrsConTitle; }
            set
            {
                if (value != this._iCTransferStkTrsConTitle)
                {
                    _iCTransferStkTrsConTitle = value;
                }
            }
        }
        public String ICTransferStkTrsConHLet
        {
            get { return _iCTransferStkTrsConHLet; }
            set
            {
                if (value != this._iCTransferStkTrsConHLet)
                {
                    _iCTransferStkTrsConHLet = value;
                }
            }
        }
        public String ICTransferStkTrsConHMsg
        {
            get { return _iCTransferStkTrsConHMsg; }
            set
            {
                if (value != this._iCTransferStkTrsConHMsg)
                {
                    _iCTransferStkTrsConHMsg = value;
                }
            }
        }
        public String ICTransferStkTrsConEmail
        {
            get { return _iCTransferStkTrsConEmail; }
            set
            {
                if (value != this._iCTransferStkTrsConEmail)
                {
                    _iCTransferStkTrsConEmail = value;
                }
            }
        }
        public String ICTransferStkTrsConEmail1
        {
            get { return _iCTransferStkTrsConEmail1; }
            set
            {
                if (value != this._iCTransferStkTrsConEmail1)
                {
                    _iCTransferStkTrsConEmail1 = value;
                }
            }
        }
        public String ICTransferStkTrsConPhone
        {
            get { return _iCTransferStkTrsConPhone; }
            set
            {
                if (value != this._iCTransferStkTrsConPhone)
                {
                    _iCTransferStkTrsConPhone = value;
                }
            }
        }
        public String ICTransferStkTrsConFax
        {
            get { return _iCTransferStkTrsConFax; }
            set
            {
                if (value != this._iCTransferStkTrsConFax)
                {
                    _iCTransferStkTrsConFax = value;
                }
            }
        }
        public String ICTransferStkTrsConCPhone
        {
            get { return _iCTransferStkTrsConCPhone; }
            set
            {
                if (value != this._iCTransferStkTrsConCPhone)
                {
                    _iCTransferStkTrsConCPhone = value;
                }
            }
        }
        public String ICTransferStkTrsConInfo
        {
            get { return _iCTransferStkTrsConInfo; }
            set
            {
                if (value != this._iCTransferStkTrsConInfo)
                {
                    _iCTransferStkTrsConInfo = value;
                }
            }
        }
        public String ICTransferStkTrsConDept
        {
            get { return _iCTransferStkTrsConDept; }
            set
            {
                if (value != this._iCTransferStkTrsConDept)
                {
                    _iCTransferStkTrsConDept = value;
                }
            }
        }
        public String ICTransferStkTrsConRoom
        {
            get { return _iCTransferStkTrsConRoom; }
            set
            {
                if (value != this._iCTransferStkTrsConRoom)
                {
                    _iCTransferStkTrsConRoom = value;
                }
            }
        }
        public String ICTransferStkTrsAddL1
        {
            get { return _iCTransferStkTrsAddL1; }
            set
            {
                if (value != this._iCTransferStkTrsAddL1)
                {
                    _iCTransferStkTrsAddL1 = value;
                }
            }
        }
        public String ICTransferStkTrsAddL2
        {
            get { return _iCTransferStkTrsAddL2; }
            set
            {
                if (value != this._iCTransferStkTrsAddL2)
                {
                    _iCTransferStkTrsAddL2 = value;
                }
            }
        }
        public String ICTransferStkTrsAddL3
        {
            get { return _iCTransferStkTrsAddL3; }
            set
            {
                if (value != this._iCTransferStkTrsAddL3)
                {
                    _iCTransferStkTrsAddL3 = value;
                }
            }
        }
        public String ICTransferStkTrsAddStr
        {
            get { return _iCTransferStkTrsAddStr; }
            set
            {
                if (value != this._iCTransferStkTrsAddStr)
                {
                    _iCTransferStkTrsAddStr = value;
                }
            }
        }
        public String ICTransferStkTrsAddCity
        {
            get { return _iCTransferStkTrsAddCity; }
            set
            {
                if (value != this._iCTransferStkTrsAddCity)
                {
                    _iCTransferStkTrsAddCity = value;
                }
            }
        }
        public String ICTransferStkTrsAddPCode
        {
            get { return _iCTransferStkTrsAddPCode; }
            set
            {
                if (value != this._iCTransferStkTrsAddPCode)
                {
                    _iCTransferStkTrsAddPCode = value;
                }
            }
        }
        public String ICTransferStkTrsAddStProv
        {
            get { return _iCTransferStkTrsAddStProv; }
            set
            {
                if (value != this._iCTransferStkTrsAddStProv)
                {
                    _iCTransferStkTrsAddStProv = value;
                }
            }
        }
        public String ICTransferStkTrsAddZCode
        {
            get { return _iCTransferStkTrsAddZCode; }
            set
            {
                if (value != this._iCTransferStkTrsAddZCode)
                {
                    _iCTransferStkTrsAddZCode = value;
                }
            }
        }
        public String ICTransferStkTrsAddCountry
        {
            get { return _iCTransferStkTrsAddCountry; }
            set
            {
                if (value != this._iCTransferStkTrsAddCountry)
                {
                    _iCTransferStkTrsAddCountry = value;
                }
            }
        }
        public String ICTransferStkTConName
        {
            get { return _iCTransferStkTConName; }
            set
            {
                if (value != this._iCTransferStkTConName)
                {
                    _iCTransferStkTConName = value;
                }
            }
        }
        public Nullable<DateTime> ICTransferStkTConBday
        {
            get { return _iCTransferStkTConBday; }
            set
            {
                if (value != this._iCTransferStkTConBday)
                {
                    _iCTransferStkTConBday = value;
                }
            }
        }
        public String ICTransferStkTConFName
        {
            get { return _iCTransferStkTConFName; }
            set
            {
                if (value != this._iCTransferStkTConFName)
                {
                    _iCTransferStkTConFName = value;
                }
            }
        }
        public String ICTransferStkTConLName
        {
            get { return _iCTransferStkTConLName; }
            set
            {
                if (value != this._iCTransferStkTConLName)
                {
                    _iCTransferStkTConLName = value;
                }
            }
        }
        public String ICTransferStkTConTitle
        {
            get { return _iCTransferStkTConTitle; }
            set
            {
                if (value != this._iCTransferStkTConTitle)
                {
                    _iCTransferStkTConTitle = value;
                }
            }
        }
        public String ICTransferStkTConHLet
        {
            get { return _iCTransferStkTConHLet; }
            set
            {
                if (value != this._iCTransferStkTConHLet)
                {
                    _iCTransferStkTConHLet = value;
                }
            }
        }
        public String ICTransferStkTConHMsg
        {
            get { return _iCTransferStkTConHMsg; }
            set
            {
                if (value != this._iCTransferStkTConHMsg)
                {
                    _iCTransferStkTConHMsg = value;
                }
            }
        }
        public String ICTransferStkTConEmail
        {
            get { return _iCTransferStkTConEmail; }
            set
            {
                if (value != this._iCTransferStkTConEmail)
                {
                    _iCTransferStkTConEmail = value;
                }
            }
        }
        public String ICTransferStkTConEmail1
        {
            get { return _iCTransferStkTConEmail1; }
            set
            {
                if (value != this._iCTransferStkTConEmail1)
                {
                    _iCTransferStkTConEmail1 = value;
                }
            }
        }
        public String ICTransferStkTConPhone
        {
            get { return _iCTransferStkTConPhone; }
            set
            {
                if (value != this._iCTransferStkTConPhone)
                {
                    _iCTransferStkTConPhone = value;
                }
            }
        }
        public String ICTransferStkTConCPhone
        {
            get { return _iCTransferStkTConCPhone; }
            set
            {
                if (value != this._iCTransferStkTConCPhone)
                {
                    _iCTransferStkTConCPhone = value;
                }
            }
        }
        public String ICTransferStkTConFax
        {
            get { return _iCTransferStkTConFax; }
            set
            {
                if (value != this._iCTransferStkTConFax)
                {
                    _iCTransferStkTConFax = value;
                }
            }
        }
        public String ICTransferStkTConInfo
        {
            get { return _iCTransferStkTConInfo; }
            set
            {
                if (value != this._iCTransferStkTConInfo)
                {
                    _iCTransferStkTConInfo = value;
                }
            }
        }
        public String ICTransferStkTConDept
        {
            get { return _iCTransferStkTConDept; }
            set
            {
                if (value != this._iCTransferStkTConDept)
                {
                    _iCTransferStkTConDept = value;
                }
            }
        }
        public String ICTransferStkTConRoom
        {
            get { return _iCTransferStkTConRoom; }
            set
            {
                if (value != this._iCTransferStkTConRoom)
                {
                    _iCTransferStkTConRoom = value;
                }
            }
        }
        public String ICTransferStkTAddL1
        {
            get { return _iCTransferStkTAddL1; }
            set
            {
                if (value != this._iCTransferStkTAddL1)
                {
                    _iCTransferStkTAddL1 = value;
                }
            }
        }
        public String ICTransferStkTAddL2
        {
            get { return _iCTransferStkTAddL2; }
            set
            {
                if (value != this._iCTransferStkTAddL2)
                {
                    _iCTransferStkTAddL2 = value;
                }
            }
        }
        public String ICTransferStkTAddL3
        {
            get { return _iCTransferStkTAddL3; }
            set
            {
                if (value != this._iCTransferStkTAddL3)
                {
                    _iCTransferStkTAddL3 = value;
                }
            }
        }
        public String ICTransferStkTAddStr
        {
            get { return _iCTransferStkTAddStr; }
            set
            {
                if (value != this._iCTransferStkTAddStr)
                {
                    _iCTransferStkTAddStr = value;
                }
            }
        }
        public String ICTransferStkTAddCity
        {
            get { return _iCTransferStkTAddCity; }
            set
            {
                if (value != this._iCTransferStkTAddCity)
                {
                    _iCTransferStkTAddCity = value;
                }
            }
        }
        public String ICTransferStkTAddPCode
        {
            get { return _iCTransferStkTAddPCode; }
            set
            {
                if (value != this._iCTransferStkTAddPCode)
                {
                    _iCTransferStkTAddPCode = value;
                }
            }
        }
        public String ICTransferStkTAddStProv
        {
            get { return _iCTransferStkTAddStProv; }
            set
            {
                if (value != this._iCTransferStkTAddStProv)
                {
                    _iCTransferStkTAddStProv = value;
                }
            }
        }
        public String ICTransferStkTAddZCode
        {
            get { return _iCTransferStkTAddZCode; }
            set
            {
                if (value != this._iCTransferStkTAddZCode)
                {
                    _iCTransferStkTAddZCode = value;
                }
            }
        }
        public String ICTransferStkTAddCountry
        {
            get { return _iCTransferStkTAddCountry; }
            set
            {
                if (value != this._iCTransferStkTAddCountry)
                {
                    _iCTransferStkTAddCountry = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferShpAmt
        {
            get { return _iCTransferShpAmt; }
            set
            {
                if (value != this._iCTransferShpAmt)
                {
                    _iCTransferShpAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItmPriceTot
        {
            get { return _iCTransferItmPriceTot; }
            set
            {
                if (value != this._iCTransferItmPriceTot)
                {
                    _iCTransferItmPriceTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItmDiscAmtTot
        {
            get { return _iCTransferItmDiscAmtTot; }
            set
            {
                if (value != this._iCTransferItmDiscAmtTot)
                {
                    _iCTransferItmDiscAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferItmAmtTot
        {
            get { return _iCTransferItmAmtTot; }
            set
            {
                if (value != this._iCTransferItmAmtTot)
                {
                    _iCTransferItmAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferTxAmtTot
        {
            get { return _iCTransferTxAmtTot; }
            set
            {
                if (value != this._iCTransferTxAmtTot)
                {
                    _iCTransferTxAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferNetAmtTot
        {
            get { return _iCTransferNetAmtTot; }
            set
            {
                if (value != this._iCTransferNetAmtTot)
                {
                    _iCTransferNetAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferAmtTot
        {
            get { return _iCTransferAmtTot; }
            set
            {
                if (value != this._iCTransferAmtTot)
                {
                    _iCTransferAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferMiscChargeAmt
        {
            get { return _iCTransferMiscChargeAmt; }
            set
            {
                if (value != this._iCTransferMiscChargeAmt)
                {
                    _iCTransferMiscChargeAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferCostTot
        {
            get { return _iCTransferCostTot; }
            set
            {
                if (value != this._iCTransferCostTot)
                {
                    _iCTransferCostTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICTransferMargPct
        {
            get { return _iCTransferMargPct; }
            set
            {
                if (value != this._iCTransferMargPct)
                {
                    _iCTransferMargPct = value;
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
        public String ICTransferLotNo
        {
            get { return _iCTransferLotNo; }
            set
            {
                if (value != this._iCTransferLotNo)
                {
                    _iCTransferLotNo = value;
                }
            }
        }
        public String AACompanyTypeCombo
        {
            get { return _aACompanyTypeCombo; }
            set
            {
                if (value != this._aACompanyTypeCombo)
                {
                    _aACompanyTypeCombo = value;
                }
            }
        }
        public String AAThueRemark
        {
            get { return _aAThueRemark; }
            set
            {
                if (value != this._aAThueRemark)
                {
                    _aAThueRemark = value;
                }
            }
        }
        public String AAOrgDocNo
        {
            get { return _aAOrgDocNo; }
            set
            {
                if (value != this._aAOrgDocNo)
                {
                    _aAOrgDocNo = value;
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
        public int FK_APSupplierConID
        {
            get { return _fK_APSupplierConID; }
            set
            {
                if (value != this._fK_APSupplierConID)
                {
                    _fK_APSupplierConID = value;
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
        public Nullable<DateTime> ICTransferJrnDate
        {
            get { return _iCTransferJrnDate; }
            set
            {
                if (value != this._iCTransferJrnDate)
                {
                    _iCTransferJrnDate = value;
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
        public String ICTransferJrnNo
        {
            get { return _iCTransferJrnNo; }
            set
            {
                if (value != this._iCTransferJrnNo)
                {
                    _iCTransferJrnNo = value;
                }
            }
        }
        public String ICTransferInvSerie
        {
            get { return _iCTransferInvSerie; }
            set
            {
                if (value != this._iCTransferInvSerie)
                {
                    _iCTransferInvSerie = value;
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
        public String ICTransferBTConName
        {
            get { return _iCTransferBTConName; }
            set
            {
                if (value != this._iCTransferBTConName)
                {
                    _iCTransferBTConName = value;
                }
            }
        }
        public String ICTransferBTConEmail
        {
            get { return _iCTransferBTConEmail; }
            set
            {
                if (value != this._iCTransferBTConEmail)
                {
                    _iCTransferBTConEmail = value;
                }
            }
        }
        public String ICTransferBTConPhone
        {
            get { return _iCTransferBTConPhone; }
            set
            {
                if (value != this._iCTransferBTConPhone)
                {
                    _iCTransferBTConPhone = value;
                }
            }
        }
        public String ICTransferBTConDept
        {
            get { return _iCTransferBTConDept; }
            set
            {
                if (value != this._iCTransferBTConDept)
                {
                    _iCTransferBTConDept = value;
                }
            }
        }
        public String ICTransferBTAddL1
        {
            get { return _iCTransferBTAddL1; }
            set
            {
                if (value != this._iCTransferBTAddL1)
                {
                    _iCTransferBTAddL1 = value;
                }
            }
        }
        public String ICTransferBTAddL2
        {
            get { return _iCTransferBTAddL2; }
            set
            {
                if (value != this._iCTransferBTAddL2)
                {
                    _iCTransferBTAddL2 = value;
                }
            }
        }
        public String ICTransferSTConName
        {
            get { return _iCTransferSTConName; }
            set
            {
                if (value != this._iCTransferSTConName)
                {
                    _iCTransferSTConName = value;
                }
            }
        }
        public String ICTransferSTConEmail
        {
            get { return _iCTransferSTConEmail; }
            set
            {
                if (value != this._iCTransferSTConEmail)
                {
                    _iCTransferSTConEmail = value;
                }
            }
        }
        public String ICTransferSTConPhone
        {
            get { return _iCTransferSTConPhone; }
            set
            {
                if (value != this._iCTransferSTConPhone)
                {
                    _iCTransferSTConPhone = value;
                }
            }
        }
        public String ICTransferSTConDept
        {
            get { return _iCTransferSTConDept; }
            set
            {
                if (value != this._iCTransferSTConDept)
                {
                    _iCTransferSTConDept = value;
                }
            }
        }
        public String ICTransferSTAddL1
        {
            get { return _iCTransferSTAddL1; }
            set
            {
                if (value != this._iCTransferSTAddL1)
                {
                    _iCTransferSTAddL1 = value;
                }
            }
        }
        public String ICTransferSTAddL2
        {
            get { return _iCTransferSTAddL2; }
            set
            {
                if (value != this._iCTransferSTAddL2)
                {
                    _iCTransferSTAddL2 = value;
                }
            }
        }
        public String ICTransferBTConFax
        {
            get { return _iCTransferBTConFax; }
            set
            {
                if (value != this._iCTransferBTConFax)
                {
                    _iCTransferBTConFax = value;
                }
            }
        }
        public String ICTransferInvNo
        {
            get { return _iCTransferInvNo; }
            set
            {
                if (value != this._iCTransferInvNo)
                {
                    _iCTransferInvNo = value;
                }
            }
        }
        public Nullable<DateTime> ICTransferInvDate
        {
            get { return _iCTransferInvDate; }
            set
            {
                if (value != this._iCTransferInvDate)
                {
                    _iCTransferInvDate = value;
                }
            }
        }
        public String ICTransferInvForm
        {
            get { return _iCTransferInvForm; }
            set
            {
                if (value != this._iCTransferInvForm)
                {
                    _iCTransferInvForm = value;
                }
            }
        }
        public String ICTransferInvDesc
        {
            get { return _iCTransferInvDesc; }
            set
            {
                if (value != this._iCTransferInvDesc)
                {
                    _iCTransferInvDesc = value;
                }
            }
        }
        public int FK_GELanguageID
        {
            get { return _fK_GELanguageID; }
            set
            {
                if (value != this._fK_GELanguageID)
                {
                    _fK_GELanguageID = value;
                }
            }
        }
        public String ICTransferBTConInfo
        {
            get { return _iCTransferBTConInfo; }
            set
            {
                if (value != this._iCTransferBTConInfo)
                {
                    _iCTransferBTConInfo = value;
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
        public String ICTransferSTConFName
        {
            get { return _iCTransferSTConFName; }
            set
            {
                if (value != this._iCTransferSTConFName)
                {
                    _iCTransferSTConFName = value;
                }
            }
        }
        public String ICTransferSTConFax
        {
            get { return _iCTransferSTConFax; }
            set
            {
                if (value != this._iCTransferSTConFax)
                {
                    _iCTransferSTConFax = value;
                }
            }
        }
        public String ICTransferOOF12Combo
        {
            get { return _iCTransferOOF12Combo; }
            set
            {
                if (value != this._iCTransferOOF12Combo)
                {
                    _iCTransferOOF12Combo = value;
                }
            }
        }
        public String ICTransferOF11Combo
        {
            get { return _iCTransferOF11Combo; }
            set
            {
                if (value != this._iCTransferOF11Combo)
                {
                    _iCTransferOF11Combo = value;
                }
            }
        }
        public String ICTransferOF12Combo
        {
            get { return _iCTransferOF12Combo; }
            set
            {
                if (value != this._iCTransferOF12Combo)
                {
                    _iCTransferOF12Combo = value;
                }
            }
        }
        public String ICTransferOF13Combo
        {
            get { return _iCTransferOF13Combo; }
            set
            {
                if (value != this._iCTransferOF13Combo)
                {
                    _iCTransferOF13Combo = value;
                }
            }
        }
        public String ICTransferOF14Combo
        {
            get { return _iCTransferOF14Combo; }
            set
            {
                if (value != this._iCTransferOF14Combo)
                {
                    _iCTransferOF14Combo = value;
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
        public int FK_LOConsigneeID
        {
            get { return _fK_LOConsigneeID; }
            set
            {
                if (value != this._fK_LOConsigneeID)
                {
                    _fK_LOConsigneeID = value;
                }
            }
        }
        public String ICTransferConsigneeName
        {
            get { return _iCTransferConsigneeName; }
            set
            {
                if (value != this._iCTransferConsigneeName)
                {
                    _iCTransferConsigneeName = value;
                }
            }
        }
        public String ICTransferConsigneeAddress
        {
            get { return _iCTransferConsigneeAddress; }
            set
            {
                if (value != this._iCTransferConsigneeAddress)
                {
                    _iCTransferConsigneeAddress = value;
                }
            }
        }
        public String ICTransferConsigneeTaxNo
        {
            get { return _iCTransferConsigneeTaxNo; }
            set
            {
                if (value != this._iCTransferConsigneeTaxNo)
                {
                    _iCTransferConsigneeTaxNo = value;
                }
            }
        }
        public String ICTransferShipperTaxNo
        {
            get { return _iCTransferShipperTaxNo; }
            set
            {
                if (value != this._iCTransferShipperTaxNo)
                {
                    _iCTransferShipperTaxNo = value;
                }
            }
        }
        public String ICTransferShipperAddress
        {
            get { return _iCTransferShipperAddress; }
            set
            {
                if (value != this._iCTransferShipperAddress)
                {
                    _iCTransferShipperAddress = value;
                }
            }
        }
        public String ICTransferShipperName
        {
            get { return _iCTransferShipperName; }
            set
            {
                if (value != this._iCTransferShipperName)
                {
                    _iCTransferShipperName = value;
                }
            }
        }
        public String ICTransferLadingNo
        {
            get { return _iCTransferLadingNo; }
            set
            {
                if (value != this._iCTransferLadingNo)
                {
                    _iCTransferLadingNo = value;
                }
            }
        }
        public Nullable<DateTime> ICTransferLadingDate
        {
            get { return _iCTransferLadingDate; }
            set
            {
                if (value != this._iCTransferLadingDate)
                {
                    _iCTransferLadingDate = value;
                }
            }
        }
        public String ICTransferDeclarationNo
        {
            get { return _iCTransferDeclarationNo; }
            set
            {
                if (value != this._iCTransferDeclarationNo)
                {
                    _iCTransferDeclarationNo = value;
                }
            }
        }
        public Nullable<DateTime> ICTransferDeclarationDate
        {
            get { return _iCTransferDeclarationDate; }
            set
            {
                if (value != this._iCTransferDeclarationDate)
                {
                    _iCTransferDeclarationDate = value;
                }
            }
        }
        public String ICTransferSupAdd
        {
            get { return _iCTransferSupAdd; }
            set
            {
                if (value != this._iCTransferSupAdd)
                {
                    _iCTransferSupAdd = value;
                }
            }
        }
        public String ICTransferOptional01
        {
            get { return _iCTransferOptional01; }
            set
            {
                if (value != this._iCTransferOptional01)
                {
                    _iCTransferOptional01 = value;
                }
            }
        }
        public String ICTransferOptional02
        {
            get { return _iCTransferOptional02; }
            set
            {
                if (value != this._iCTransferOptional02)
                {
                    _iCTransferOptional02 = value;
                }
            }
        }
        public String ICTransferOptional03
        {
            get { return _iCTransferOptional03; }
            set
            {
                if (value != this._iCTransferOptional03)
                {
                    _iCTransferOptional03 = value;
                }
            }
        }
        #endregion
    }
}