using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("HRPeriods")]
    public class HRPeriods : BaseInfo
    {
        #region Variables
        protected int _hRPeriodID;
        protected String _hRPeriodNo = String.Empty;
        protected String _hRPeriodName = String.Empty;
        protected Nullable<DateTime> _hRPeriodDate;
        protected String _hRPeriodDesc = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected bool _aASelected = true;
        protected int _hRPeriodYear;
        protected Nullable<DateTime> _hRPeriodFromDate;
        protected Nullable<DateTime> _hRPeriodToDate;
        protected bool _hRPeriodCloseCheck = true;
        protected int _hRPeriodNumber;
        protected double _hRPeriodStdDay;
        protected double _hRPeriodCalDay;
        protected double _hRPeriodIndirect;

#endregion
        [Key]
        #region Public properties
        public int HRPeriodID
        {
            get { return _hRPeriodID; }
            set
            {
                if (value != this._hRPeriodID)
                {
                    _hRPeriodID = value;
                }
            }
        }
        public String HRPeriodNo
        {
            get { return _hRPeriodNo; }
            set
            {
                if (value != this._hRPeriodNo)
                {
                    _hRPeriodNo = value;
                }
            }
        }
        public String HRPeriodName
        {
            get { return _hRPeriodName; }
            set
            {
                if (value != this._hRPeriodName)
                {
                    _hRPeriodName = value;
                }
            }
        }
        public Nullable<DateTime> HRPeriodDate
        {
            get { return _hRPeriodDate; }
            set
            {
                if (value != this._hRPeriodDate)
                {
                    _hRPeriodDate = value;
                }
            }
        }
        public String HRPeriodDesc
        {
            get { return _hRPeriodDesc; }
            set
            {
                if (value != this._hRPeriodDesc)
                {
                    _hRPeriodDesc = value;
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
        public int HRPeriodYear
        {
            get { return _hRPeriodYear; }
            set
            {
                if (value != this._hRPeriodYear)
                {
                    _hRPeriodYear = value;
                }
            }
        }
        public Nullable<DateTime> HRPeriodFromDate
        {
            get { return _hRPeriodFromDate; }
            set
            {
                if (value != this._hRPeriodFromDate)
                {
                    _hRPeriodFromDate = value;
                }
            }
        }
        public Nullable<DateTime> HRPeriodToDate
        {
            get { return _hRPeriodToDate; }
            set
            {
                if (value != this._hRPeriodToDate)
                {
                    _hRPeriodToDate = value;
                }
            }
        }
        public bool HRPeriodCloseCheck
        {
            get { return _hRPeriodCloseCheck; }
            set
            {
                if (value != this._hRPeriodCloseCheck)
                {
                    _hRPeriodCloseCheck = value;
                }
            }
        }
        public int HRPeriodNumber
        {
            get { return _hRPeriodNumber; }
            set
            {
                if (value != this._hRPeriodNumber)
                {
                    _hRPeriodNumber = value;
                }
            }
        }
        public double HRPeriodStdDay
        {
            get { return _hRPeriodStdDay; }
            set
            {
                if (value != this._hRPeriodStdDay)
                {
                    _hRPeriodStdDay = value;
                }
            }
        }
        public double HRPeriodCalDay
        {
            get { return _hRPeriodCalDay; }
            set
            {
                if (value != this._hRPeriodCalDay)
                {
                    _hRPeriodCalDay = value;
                }
            }
        }
        public double HRPeriodIndirect
        {
            get { return _hRPeriodIndirect; }
            set
            {
                if (value != this._hRPeriodIndirect)
                {
                    _hRPeriodIndirect = value;
                }
            }
        }

        #endregion

    }
}
