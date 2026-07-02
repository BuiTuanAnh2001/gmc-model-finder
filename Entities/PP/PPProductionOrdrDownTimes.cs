using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("PPProductionOrdrDownTimes")]
    public class PPProductionOrdrDownTimes
    {
        #region Variables
        protected int _pPProductionOrdrDownTimeID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAStatus = "Alive";
        protected bool _aASelected = true;
        protected int _fK_PPDownTimeID;
        protected String _pPProductionOrdrDownTimeDesc = String.Empty;
        protected decimal _pPProductionOrdrDownTimeQty;
        protected int _fK_PPProductionOrdrEstFGID;
        protected int _fK_PPProductionOrdrID;
        protected decimal _pPProductionOrdrDownTimeWasteQty;

        #endregion
        [Key]
        #region Public properties
        public int PPProductionOrdrDownTimeID
        {
            get { return _pPProductionOrdrDownTimeID; }
            set
            {
                if (value != this._pPProductionOrdrDownTimeID)
                {
                    _pPProductionOrdrDownTimeID = value;
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
        public int FK_PPDownTimeID
        {
            get { return _fK_PPDownTimeID; }
            set
            {
                if (value != this._fK_PPDownTimeID)
                {
                    _fK_PPDownTimeID = value;
                }
            }
        }
        public String PPProductionOrdrDownTimeDesc
        {
            get { return _pPProductionOrdrDownTimeDesc; }
            set
            {
                if (value != this._pPProductionOrdrDownTimeDesc)
                {
                    _pPProductionOrdrDownTimeDesc = value;
                }
            }
        }
        public decimal PPProductionOrdrDownTimeQty
        {
            get { return _pPProductionOrdrDownTimeQty; }
            set
            {
                if (value != this._pPProductionOrdrDownTimeQty)
                {
                    _pPProductionOrdrDownTimeQty = value;
                }
            }
        }
        public int FK_PPProductionOrdrEstFGID
        {
            get { return _fK_PPProductionOrdrEstFGID; }
            set
            {
                if (value != this._fK_PPProductionOrdrEstFGID)
                {
                    _fK_PPProductionOrdrEstFGID = value;
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
        public decimal PPProductionOrdrDownTimeWasteQty
        {
            get { return _pPProductionOrdrDownTimeWasteQty; }
            set
            {
                if (value != this._pPProductionOrdrDownTimeWasteQty)
                {
                    _pPProductionOrdrDownTimeWasteQty = value;
                }
            }
        }

        #endregion
    }
}
