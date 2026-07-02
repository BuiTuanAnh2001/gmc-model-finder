using ExpertLib;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ARCustomerBanks")]
    public class ARCustomerBanksInfo : BaseInfo
    {
        public ARCustomerBanksInfo()
        {
        }
        #region Variables
        protected int _aRCustomerBankID;
        protected bool _aASelected = true;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aRCustomerBankNo = String.Empty;
        protected String _aRCustomerBankName = String.Empty;
        protected String _aRCustomerBankDesc = String.Empty;
        protected String _aRCustomerBankBranchName = String.Empty;
        protected String _aRCustomerBankSwiftCode = String.Empty;
        protected String _aRCustomerBankAccountName = String.Empty;
        protected String _aRCustomerBankAccountNo = String.Empty;
        protected bool _aRCustomerBankDefault = true;
        protected int _fK_GECurrencyID;
        protected int _fK_ARCustomerID;
        protected String _aRCustomerBankAccountAddr = String.Empty;
        #endregion
        [Key]
        #region Public properties
        public int ARCustomerBankID
        {
            get { return _aRCustomerBankID; }
            set
            {
                if (value != this._aRCustomerBankID)
                {
                    _aRCustomerBankID = value;
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
        public String ARCustomerBankNo
        {
            get { return _aRCustomerBankNo; }
            set
            {
                if (value != this._aRCustomerBankNo)
                {
                    _aRCustomerBankNo = value;
                }
            }
        }
        public String ARCustomerBankName
        {
            get { return _aRCustomerBankName; }
            set
            {
                if (value != this._aRCustomerBankName)
                {
                    _aRCustomerBankName = value;
                }
            }
        }
        public String ARCustomerBankDesc
        {
            get { return _aRCustomerBankDesc; }
            set
            {
                if (value != this._aRCustomerBankDesc)
                {
                    _aRCustomerBankDesc = value;
                }
            }
        }
        public String ARCustomerBankBranchName
        {
            get { return _aRCustomerBankBranchName; }
            set
            {
                if (value != this._aRCustomerBankBranchName)
                {
                    _aRCustomerBankBranchName = value;
                }
            }
        }
        public String ARCustomerBankSwiftCode
        {
            get { return _aRCustomerBankSwiftCode; }
            set
            {
                if (value != this._aRCustomerBankSwiftCode)
                {
                    _aRCustomerBankSwiftCode = value;
                }
            }
        }
        public String ARCustomerBankAccountName
        {
            get { return _aRCustomerBankAccountName; }
            set
            {
                if (value != this._aRCustomerBankAccountName)
                {
                    _aRCustomerBankAccountName = value;
                }
            }
        }
        public String ARCustomerBankAccountNo
        {
            get { return _aRCustomerBankAccountNo; }
            set
            {
                if (value != this._aRCustomerBankAccountNo)
                {
                    _aRCustomerBankAccountNo = value;
                }
            }
        }
        public bool ARCustomerBankDefault
        {
            get { return _aRCustomerBankDefault; }
            set
            {
                if (value != this._aRCustomerBankDefault)
                {
                    _aRCustomerBankDefault = value;
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
        public String ARCustomerBankAccountAddr
        {
            get { return _aRCustomerBankAccountAddr; }
            set
            {
                if (value != this._aRCustomerBankAccountAddr)
                {
                    _aRCustomerBankAccountAddr = value;
                }
            }
        }
        #endregion
    }
}
