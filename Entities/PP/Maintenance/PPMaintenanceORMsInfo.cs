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
    [Table("PPMaintenanceORMs")]
    public class PPMaintenanceORMsInfo : BaseInfo
    {
        #region Variables
        protected int _pPMaintenanceORMID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _pPMaintenanceORMDesc = String.Empty;
        protected String _pPMaintenanceORMStatusCombo = DefaultStatus;
        protected int _fK_PPMaintenanceOID;
        protected int _fK_PPCalendarMaintenanceID;
        protected int _fK_PPDeviceID;
        protected int _fK_PPWorkCenterID;
        protected decimal _pPMaintenanceORMQty;
        protected decimal _pPMaintenanceORMRQty;
        protected decimal _pPMaintenanceORMStkQty;
        protected decimal _pPMaintenanceORMStkRQty;
        protected int _fK_ICProductID;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected decimal _pPMaintenanceORMFact;
        protected decimal _pPMaintenanceORMExcQty;
        protected int _fK_PPMaintenanceCategroyCfgID;
        protected decimal _pPMaintenanceORMOrgQty;

        #endregion
        #region Public properties
        [Key]
        public int PPMaintenanceORMID
        {
            get { return _pPMaintenanceORMID; }
            set
            {
                if (value != this._pPMaintenanceORMID)
                {
                    _pPMaintenanceORMID = value;
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
        public String PPMaintenanceORMDesc
        {
            get { return _pPMaintenanceORMDesc; }
            set
            {
                if (value != this._pPMaintenanceORMDesc)
                {
                    _pPMaintenanceORMDesc = value;
                }
            }
        }
        public String PPMaintenanceORMStatusCombo
        {
            get { return _pPMaintenanceORMStatusCombo; }
            set
            {
                if (value != this._pPMaintenanceORMStatusCombo)
                {
                    _pPMaintenanceORMStatusCombo = value;
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
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPMaintenanceORMQty
        {
            get { return _pPMaintenanceORMQty; }
            set
            {
                if (value != this._pPMaintenanceORMQty)
                {
                    _pPMaintenanceORMQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPMaintenanceORMRQty
        {
            get { return _pPMaintenanceORMRQty; }
            set
            {
                if (value != this._pPMaintenanceORMRQty)
                {
                    _pPMaintenanceORMRQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPMaintenanceORMStkQty
        {
            get { return _pPMaintenanceORMStkQty; }
            set
            {
                if (value != this._pPMaintenanceORMStkQty)
                {
                    _pPMaintenanceORMStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPMaintenanceORMStkRQty
        {
            get { return _pPMaintenanceORMStkRQty; }
            set
            {
                if (value != this._pPMaintenanceORMStkRQty)
                {
                    _pPMaintenanceORMStkRQty = value;
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
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPMaintenanceORMFact
        {
            get { return _pPMaintenanceORMFact; }
            set
            {
                if (value != this._pPMaintenanceORMFact)
                {
                    _pPMaintenanceORMFact = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPMaintenanceORMExcQty
        {
            get { return _pPMaintenanceORMExcQty; }
            set
            {
                if (value != this._pPMaintenanceORMExcQty)
                {
                    _pPMaintenanceORMExcQty = value;
                }
            }
        }
        public int FK_PPMaintenanceCategroyCfgID
        {
            get { return _fK_PPMaintenanceCategroyCfgID; }
            set
            {
                if (value != this._fK_PPMaintenanceCategroyCfgID)
                {
                    _fK_PPMaintenanceCategroyCfgID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPMaintenanceORMOrgQty
        {
            get { return _pPMaintenanceORMOrgQty; }
            set
            {
                if (value != this._pPMaintenanceORMOrgQty)
                {
                    _pPMaintenanceORMOrgQty = value;
                }
            }
        }

        #endregion
    }
}