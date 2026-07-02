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
    [Table("PPPkgStocks")]
    public class PPPkgStocksInfo : BaseInfo
    {
        public PPPkgStocksInfo()
        {
        }
        #region Variables
        protected int _pPPkgStockID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_ICStockID;
        protected String _pPPkgStockDesc = String.Empty;
        protected bool _pPPkgStockIsUpdateInv = true;
        #endregion
        [Key]
        #region Public properties
        public int PPPkgStockID
        {
            get { return _pPPkgStockID; }
            set
            {
                if (value != this._pPPkgStockID)
                {
                    _pPPkgStockID = value;
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
        public String PPPkgStockDesc
        {
            get { return _pPPkgStockDesc; }
            set
            {
                if (value != this._pPPkgStockDesc)
                {
                    _pPPkgStockDesc = value;
                }
            }
        }
        public bool PPPkgStockIsUpdateInv
        {
            get { return _pPPkgStockIsUpdateInv; }
            set
            {
                if (value != this._pPPkgStockIsUpdateInv)
                {
                    _pPPkgStockIsUpdateInv = value;
                }
            }
        }
        #endregion
    }
}
