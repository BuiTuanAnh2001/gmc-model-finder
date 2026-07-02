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
    [Table("GLBanks")]
    public class GLBanksInfo : BaseInfo
    {
        public GLBanksInfo()
        {
        }
        #region Variables
        protected int _gLBankID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _gLBankNo = String.Empty;
        protected String _gLBankName = String.Empty;
        protected String _gLBankDesc = String.Empty;
        protected String _gLBankAddress = String.Empty;
        protected String _gKBankOwnerName = String.Empty;
        protected Nullable<DateTime> _gLBankDate;
        protected String _gLBankAccount = String.Empty;
        protected int _fK_GLAccountID;
        protected String _gLBankReportPath = String.Empty;
        protected String _gLBankOOF01Combo = String.Empty;
        protected String _gLBankOOF02Combo = String.Empty;
        protected String _gLBankOOF03Combo = String.Empty;
        protected String _gLBankOOF04Combo = String.Empty;
        protected String _gLBankOOF05Combo = String.Empty;
        protected String _gLBankOOF06Combo = String.Empty;
        protected String _gLBankOOF07Combo = String.Empty;
        protected String _gLBankOOF08Combo = String.Empty;
        protected String _gLBankOOF09Combo = String.Empty;
        protected String _gLBankOOF10Combo = String.Empty;
        protected String _gLBankNOF01Combo = String.Empty;
        protected String _gLBankNOF02Combo = String.Empty;
        protected String _gLBankNOF03Combo = String.Empty;
        protected String _gLBankNOF04Combo = String.Empty;
        protected String _gLBankNOF05Combo = String.Empty;
        protected String _gLBankBranchName = String.Empty;
        protected String _gLBankSwiftCode = String.Empty;
        protected decimal _gLBankExcRate;
        protected Nullable<DateTime> _gLBankExcDate;
        protected int _fK_GLBankObjectID;
        protected int _fK_GECurrencyExObjID;

        #endregion
        [Key]
        #region Public properties
        public int GLBankID
        {
            get { return _gLBankID; }
            set
            {
                if (value != this._gLBankID)
                {
                    _gLBankID = value;
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
        public String GLBankNo
        {
            get { return _gLBankNo; }
            set
            {
                if (value != this._gLBankNo)
                {
                    _gLBankNo = value;
                 }
            }
        }
        public String GLBankName
        {
            get { return _gLBankName; }
            set
            {
                if (value != this._gLBankName)
                {
                    _gLBankName = value;
                }
            }
        }
        public String GLBankDesc
        {
            get { return _gLBankDesc; }
            set
            {
                if (value != this._gLBankDesc)
                {
                    _gLBankDesc = value;
                }
            }
        }
        public String GLBankAddress
        {
            get { return _gLBankAddress; }
            set
            {
                if (value != this._gLBankAddress)
                {
                    _gLBankAddress = value;
                }
            }
        }
        public String GKBankOwnerName
        {
            get { return _gKBankOwnerName; }
            set
            {
                if (value != this._gKBankOwnerName)
                {
                    _gKBankOwnerName = value;
                }
            }
        }
        public Nullable<DateTime> GLBankDate
        {
            get { return _gLBankDate; }
            set
            {
                if (value != this._gLBankDate)
                {
                    _gLBankDate = value;
                }
            }
        }
        public String GLBankAccount
        {
            get { return _gLBankAccount; }
            set
            {
                if (value != this._gLBankAccount)
                {
                    _gLBankAccount = value;
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
        public String GLBankReportPath
        {
            get { return _gLBankReportPath; }
            set
            {
                if (value != this._gLBankReportPath)
                {
                    _gLBankReportPath = value;
                }
            }
        }
        public String GLBankOOF01Combo
        {
            get { return _gLBankOOF01Combo; }
            set
            {
                if (value != this._gLBankOOF01Combo)
                {
                    _gLBankOOF01Combo = value;
                }
            }
        }
        public String GLBankOOF02Combo
        {
            get { return _gLBankOOF02Combo; }
            set
            {
                if (value != this._gLBankOOF02Combo)
                {
                    _gLBankOOF02Combo = value;
                }
            }
        }
        public String GLBankOOF03Combo
        {
            get { return _gLBankOOF03Combo; }
            set
            {
                if (value != this._gLBankOOF03Combo)
                {
                    _gLBankOOF03Combo = value;
                }
            }
        }
        public String GLBankOOF04Combo
        {
            get { return _gLBankOOF04Combo; }
            set
            {
                if (value != this._gLBankOOF04Combo)
                {
                    _gLBankOOF04Combo = value;
                }
            }
        }
        public String GLBankOOF05Combo
        {
            get { return _gLBankOOF05Combo; }
            set
            {
                if (value != this._gLBankOOF05Combo)
                {
                    _gLBankOOF05Combo = value;
                }
            }
        }
        public String GLBankOOF06Combo
        {
            get { return _gLBankOOF06Combo; }
            set
            {
                if (value != this._gLBankOOF06Combo)
                {
                    _gLBankOOF06Combo = value;
                }
            }
        }
        public String GLBankOOF07Combo
        {
            get { return _gLBankOOF07Combo; }
            set
            {
                if (value != this._gLBankOOF07Combo)
                {
                    _gLBankOOF07Combo = value;
                }
            }
        }
        public String GLBankOOF08Combo
        {
            get { return _gLBankOOF08Combo; }
            set
            {
                if (value != this._gLBankOOF08Combo)
                {
                    _gLBankOOF08Combo = value;
                }
            }
        }
        public String GLBankOOF09Combo
        {
            get { return _gLBankOOF09Combo; }
            set
            {
                if (value != this._gLBankOOF09Combo)
                {
                    _gLBankOOF09Combo = value;
                }
            }
        }
        public String GLBankOOF10Combo
        {
            get { return _gLBankOOF10Combo; }
            set
            {
                if (value != this._gLBankOOF10Combo)
                {
                    _gLBankOOF10Combo = value;
                }
            }
        }
        public String GLBankNOF01Combo
        {
            get { return _gLBankNOF01Combo; }
            set
            {
                if (value != this._gLBankNOF01Combo)
                {
                    _gLBankNOF01Combo = value;
                }
            }
        }
        public String GLBankNOF02Combo
        {
            get { return _gLBankNOF02Combo; }
            set
            {
                if (value != this._gLBankNOF02Combo)
                {
                    _gLBankNOF02Combo = value;
                }
            }
        }
        public String GLBankNOF03Combo
        {
            get { return _gLBankNOF03Combo; }
            set
            {
                if (value != this._gLBankNOF03Combo)
                {
                    _gLBankNOF03Combo = value;
                }
            }
        }
        public String GLBankNOF04Combo
        {
            get { return _gLBankNOF04Combo; }
            set
            {
                if (value != this._gLBankNOF04Combo)
                {
                    _gLBankNOF04Combo = value;
                }
            }
        }
        public String GLBankNOF05Combo
        {
            get { return _gLBankNOF05Combo; }
            set
            {
                if (value != this._gLBankNOF05Combo)
                {
                    _gLBankNOF05Combo = value;
                }
            }
        }
        public String GLBankBranchName
        {
            get { return _gLBankBranchName; }
            set
            {
                if (value != this._gLBankBranchName)
                {
                    _gLBankBranchName = value;
                }
            }
        }
        public String GLBankSwiftCode
        {
            get { return _gLBankSwiftCode; }
            set
            {
                if (value != this._gLBankSwiftCode)
                {
                    _gLBankSwiftCode = value;
                }
            }
        }
        public decimal GLBankExcRate
        {
            get { return _gLBankExcRate; }
            set
            {
                if (value != this._gLBankExcRate)
                {
                    _gLBankExcRate = value;
                }
            }
        }
        public Nullable<DateTime> GLBankExcDate
        {
            get { return _gLBankExcDate; }
            set
            {
                if (value != this._gLBankExcDate)
                {
                    _gLBankExcDate = value;
                }
            }
        }
        public int FK_GLBankObjectID
        {
            get { return _fK_GLBankObjectID; }
            set
            {
                if (value != this._fK_GLBankObjectID)
                {
                    _fK_GLBankObjectID = value;
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

        #endregion
    }
}
