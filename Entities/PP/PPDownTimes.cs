using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("PPDownTimes")]
    public class PPDownTimes 
    {
        #region Variables
        protected int _pPDownTimeID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAStatus = "Alive";
        protected bool _aASelected = true;
        protected String _pPDownTimeNo = String.Empty;
        protected String _pPDownTimeName = String.Empty;
        protected String _pPDownTimeDesc = String.Empty;
        protected decimal _pPDownTimeQty;

        #endregion
        [Key]
        #region Public properties
        public int PPDownTimeID
        {
            get { return _pPDownTimeID; }
            set
            {
                if (value != this._pPDownTimeID)
                {
                    _pPDownTimeID = value;
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
        public String PPDownTimeNo
        {
            get { return _pPDownTimeNo; }
            set
            {
                if (value != this._pPDownTimeNo)
                {
                    _pPDownTimeNo = value;
                }
            }
        }
        public String PPDownTimeName
        {
            get { return _pPDownTimeName; }
            set
            {
                if (value != this._pPDownTimeName)
                {
                    _pPDownTimeName = value;
                }
            }
        }
        public String PPDownTimeDesc
        {
            get { return _pPDownTimeDesc; }
            set
            {
                if (value != this._pPDownTimeDesc)
                {
                    _pPDownTimeDesc = value;
                }
            }
        }
        public decimal PPDownTimeQty
        {
            get { return _pPDownTimeQty; }
            set
            {
                if (value != this._pPDownTimeQty)
                {
                    _pPDownTimeQty = value;
                }
            }
        }

        #endregion
    }
}
