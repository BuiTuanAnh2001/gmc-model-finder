using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("HREmployeeLeaveConfigs")]
    public class HREmployeeLeaveConfigs : BaseInfo
    {
        #region Variables
        protected int _hREmployeeLeaveConfigID;
        protected int _hREmployeeLeaveConfigDftDays;
        protected bool _hREmployeeLeaveConfigPreDaysCheck = true;
        protected bool _hREmployeeLeaveConfigExpDaysCheck = true;
        protected int _hREmployeeLeaveConfigYearApply;
        protected String _aAStatus = DefaultAAStatus;
        protected Nullable<DateTime> _aACreatedDate;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected bool _aASelected = true;
        protected int _hREmployeeLeaveConfigExpDayTMonth;
        protected String _hREmployeeLeaveConfigTypeCombo = String.Empty;
        protected decimal _hREmployeeLeaveConfigWorkingHour;
        protected String _hREmployeeLeaveConfigAppTypeCombo = String.Empty;
        protected int _hREmployeeLeaveConfigRemainDaysOldYear;

        #endregion
        #region Public properties
        [Key]
        public int HREmployeeLeaveConfigID
        {
            get { return _hREmployeeLeaveConfigID; }
            set
            {
                if (value != this._hREmployeeLeaveConfigID)
                {
                    _hREmployeeLeaveConfigID = value;
                }
            }
        }
        public int HREmployeeLeaveConfigDftDays
        {
            get { return _hREmployeeLeaveConfigDftDays; }
            set
            {
                if (value != this._hREmployeeLeaveConfigDftDays)
                {
                    _hREmployeeLeaveConfigDftDays = value;
                }
            }
        }
        public bool HREmployeeLeaveConfigPreDaysCheck
        {
            get { return _hREmployeeLeaveConfigPreDaysCheck; }
            set
            {
                if (value != this._hREmployeeLeaveConfigPreDaysCheck)
                {
                    _hREmployeeLeaveConfigPreDaysCheck = value;
                }
            }
        }
        public bool HREmployeeLeaveConfigExpDaysCheck
        {
            get { return _hREmployeeLeaveConfigExpDaysCheck; }
            set
            {
                if (value != this._hREmployeeLeaveConfigExpDaysCheck)
                {
                    _hREmployeeLeaveConfigExpDaysCheck = value;
                }
            }
        }
        public int HREmployeeLeaveConfigYearApply
        {
            get { return _hREmployeeLeaveConfigYearApply; }
            set
            {
                if (value != this._hREmployeeLeaveConfigYearApply)
                {
                    _hREmployeeLeaveConfigYearApply = value;
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
        public int HREmployeeLeaveConfigExpDayTMonth
        {
            get { return _hREmployeeLeaveConfigExpDayTMonth; }
            set
            {
                if (value != this._hREmployeeLeaveConfigExpDayTMonth)
                {
                    _hREmployeeLeaveConfigExpDayTMonth = value;
                }
            }
        }
        public String HREmployeeLeaveConfigTypeCombo
        {
            get { return _hREmployeeLeaveConfigTypeCombo; }
            set
            {
                if (value != this._hREmployeeLeaveConfigTypeCombo)
                {
                    _hREmployeeLeaveConfigTypeCombo = value;
                }
            }
        }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal HREmployeeLeaveConfigWorkingHour
        {
            get { return _hREmployeeLeaveConfigWorkingHour; }
            set
            {
                if (value != this._hREmployeeLeaveConfigWorkingHour)
                {
                    _hREmployeeLeaveConfigWorkingHour = value;
                }
            }
        }
        public String HREmployeeLeaveConfigAppTypeCombo
        {
            get { return _hREmployeeLeaveConfigAppTypeCombo; }
            set
            {
                if (value != this._hREmployeeLeaveConfigAppTypeCombo)
                {
                    _hREmployeeLeaveConfigAppTypeCombo = value;
                }
            }
        }
        public int HREmployeeLeaveConfigRemainDaysOldYear
        {
            get { return _hREmployeeLeaveConfigRemainDaysOldYear; }
            set
            {
                if (value != this._hREmployeeLeaveConfigRemainDaysOldYear)
                {
                    _hREmployeeLeaveConfigRemainDaysOldYear = value;
                }
            }
        }

        #endregion
    }
}
