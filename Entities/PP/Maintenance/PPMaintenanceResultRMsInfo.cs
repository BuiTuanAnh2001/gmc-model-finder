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
    [Table("PPMaintenanceResultRMs")]
    public class PPMaintenanceResultRMsInfo : BaseInfo
    {
        public PPMaintenanceResultRMsInfo()
        {
        }
        #region Variables
        protected int _pPMaintenanceResultRMID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _pPMaintenanceResultRMDesc = String.Empty;
        protected String _pPMaintenanceResultRMStatusCombo = DefaultStatus;
        protected int _fK_PPMaintenanceResultID;
        protected int _fK_PPMaintenanceOID;
        protected int _fK_PPMaintenanceORMID;
        protected int _fK_PPCalendarMaintenanceID;
        protected int _fK_PPDeviceID;
        protected int _fK_PPWorkCenterID;
        protected decimal _pPMaintenanceResultRMQty;
        protected decimal _pPMaintenanceResultRMRQty;
        protected decimal _pPMaintenanceResultRMActQty;
        protected decimal _pPMaintenanceResultRMActRQty;
        protected decimal _pPMaintenanceResultRMStkQty;
        protected decimal _pPMaintenanceResultRMStkRQty;
        protected int _fK_ICProductID;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected decimal _pPMaintenanceResultRMFact;

        #endregion
        [Key]
        #region Public properties
        public int PPMaintenanceResultRMID
        {
            get { return _pPMaintenanceResultRMID; }
            set
            {
                if (value != this._pPMaintenanceResultRMID)
                {
                    _pPMaintenanceResultRMID = value;
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
        public String PPMaintenanceResultRMDesc
        {
            get { return _pPMaintenanceResultRMDesc; }
            set
            {
                if (value != this._pPMaintenanceResultRMDesc)
                {
                    _pPMaintenanceResultRMDesc = value;
                }
            }
        }
        public String PPMaintenanceResultRMStatusCombo
        {
            get { return _pPMaintenanceResultRMStatusCombo; }
            set
            {
                if (value != this._pPMaintenanceResultRMStatusCombo)
                {
                    _pPMaintenanceResultRMStatusCombo = value;
                }
            }
        }
        public int FK_PPMaintenanceResultID
        {
            get { return _fK_PPMaintenanceResultID; }
            set
            {
                if (value != this._fK_PPMaintenanceResultID)
                {
                    _fK_PPMaintenanceResultID = value;
                }
            }
        }
        public int FK_PPMaintenanceOID
        {
            get { return _fK_PPMaintenanceOID; }
            set
            {
                if (value != this._fK_PPMaintenanceOID)
                {
                    _fK_PPMaintenanceOID = value;
                }
            }
        }
        public int FK_PPMaintenanceORMID
        {
            get { return _fK_PPMaintenanceORMID; }
            set
            {
                if (value != this._fK_PPMaintenanceORMID)
                {
                    _fK_PPMaintenanceORMID = value;
                }
            }
        }
        public int FK_PPCalendarMaintenanceID
        {
            get { return _fK_PPCalendarMaintenanceID; }
            set
            {
                if (value != this._fK_PPCalendarMaintenanceID)
                {
                    _fK_PPCalendarMaintenanceID = value;
                }
            }
        }
        public int FK_PPDeviceID
        {
            get { return _fK_PPDeviceID; }
            set
            {
                if (value != this._fK_PPDeviceID)
                {
                    _fK_PPDeviceID = value;
                }
            }
        }
        public int FK_PPWorkCenterID
        {
            get { return _fK_PPWorkCenterID; }
            set
            {
                if (value != this._fK_PPWorkCenterID)
                {
                    _fK_PPWorkCenterID = value;
                }
            }
        }
        public decimal PPMaintenanceResultRMQty
        {
            get { return _pPMaintenanceResultRMQty; }
            set
            {
                if (value != this._pPMaintenanceResultRMQty)
                {
                    _pPMaintenanceResultRMQty = value;
                }
            }
        }
        public decimal PPMaintenanceResultRMRQty
        {
            get { return _pPMaintenanceResultRMRQty; }
            set
            {
                if (value != this._pPMaintenanceResultRMRQty)
                {
                    _pPMaintenanceResultRMRQty = value;
                }
            }
        }
        public decimal PPMaintenanceResultRMActQty
        {
            get { return _pPMaintenanceResultRMActQty; }
            set
            {
                if (value != this._pPMaintenanceResultRMActQty)
                {
                    _pPMaintenanceResultRMActQty = value;
                }
            }
        }
        public decimal PPMaintenanceResultRMActRQty
        {
            get { return _pPMaintenanceResultRMActRQty; }
            set
            {
                if (value != this._pPMaintenanceResultRMActRQty)
                {
                    _pPMaintenanceResultRMActRQty = value;
                }
            }
        }
        public decimal PPMaintenanceResultRMStkQty
        {
            get { return _pPMaintenanceResultRMStkQty; }
            set
            {
                if (value != this._pPMaintenanceResultRMStkQty)
                {
                    _pPMaintenanceResultRMStkQty = value;
                }
            }
        }
        public decimal PPMaintenanceResultRMStkRQty
        {
            get { return _pPMaintenanceResultRMStkRQty; }
            set
            {
                if (value != this._pPMaintenanceResultRMStkRQty)
                {
                    _pPMaintenanceResultRMStkRQty = value;
                }
            }
        }
        public int FK_ICProductID
        {
            get { return _fK_ICProductID; }
            set
            {
                if (value != this._fK_ICProductID)
                {
                    _fK_ICProductID = value;
                }
            }
        }
        public int FK_ICUOMID
        {
            get { return _fK_ICUOMID; }
            set
            {
                if (value != this._fK_ICUOMID)
                {
                    _fK_ICUOMID = value;
                }
            }
        }
        public int FK_ICStkUOMID
        {
            get { return _fK_ICStkUOMID; }
            set
            {
                if (value != this._fK_ICStkUOMID)
                {
                    _fK_ICStkUOMID = value;
                }
            }
        }
        public decimal PPMaintenanceResultRMFact
        {
            get { return _pPMaintenanceResultRMFact; }
            set
            {
                if (value != this._pPMaintenanceResultRMFact)
                {
                    _pPMaintenanceResultRMFact = value;
                }
            }
        }

        #endregion
    }
}
