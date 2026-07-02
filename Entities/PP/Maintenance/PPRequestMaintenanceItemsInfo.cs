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
    [Table("PPRequestMaintenanceItems")]
    public class PPRequestMaintenanceItemsInfo : BaseInfo
    {
        public PPRequestMaintenanceItemsInfo()
        {
        }
        #region Variables
        protected int _pPRequestMaintenanceItemID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _pPRequestMaintenanceItemDesc = String.Empty;
        protected int _fK_PPRequestMaintenanceID;
        protected int _fK_PPWorkCenterID;
        protected int _fK_PPDeviceID;
        protected Nullable<DateTime> _pPRequestMaintenanceItemStarDate;
        protected Nullable<DateTime> _pPRequestMaintenanceItemEndDate;
        protected decimal _pPRequestMaintenanceItemQty;
        protected decimal _pPRequestMaintenanceItemRQty;
        protected int _fK_PPMaintenanceCategroyID;
        protected int _fK_PPMaintenanceCategroyCfgID;
        protected int _pPRequestMaintenanceItemTime;
        protected String _pPRequestMaintenanceItemNote = String.Empty;

        #endregion
        [Key]
        #region Public properties
        public int PPRequestMaintenanceItemID
        {
            get { return _pPRequestMaintenanceItemID; }
            set
            {
                if (value != this._pPRequestMaintenanceItemID)
                {
                    _pPRequestMaintenanceItemID = value;
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
        public String PPRequestMaintenanceItemDesc
        {
            get { return _pPRequestMaintenanceItemDesc; }
            set
            {
                if (value != this._pPRequestMaintenanceItemDesc)
                {
                    _pPRequestMaintenanceItemDesc = value;
                 }
            }
        }
        public int FK_PPRequestMaintenanceID
        {
            get { return _fK_PPRequestMaintenanceID; }
            set
            {
                if (value != this._fK_PPRequestMaintenanceID)
                {
                    _fK_PPRequestMaintenanceID = value;
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
        public Nullable<DateTime> PPRequestMaintenanceItemStarDate
        {
            get { return _pPRequestMaintenanceItemStarDate; }
            set
            {
                if (value != this._pPRequestMaintenanceItemStarDate)
                {
                    _pPRequestMaintenanceItemStarDate = value;
                }
            }
        }
        public Nullable<DateTime> PPRequestMaintenanceItemEndDate
        {
            get { return _pPRequestMaintenanceItemEndDate; }
            set
            {
                if (value != this._pPRequestMaintenanceItemEndDate)
                {
                    _pPRequestMaintenanceItemEndDate = value;
                }
            }
        }
        public decimal PPRequestMaintenanceItemQty
        {
            get { return _pPRequestMaintenanceItemQty; }
            set
            {
                if (value != this._pPRequestMaintenanceItemQty)
                {
                    _pPRequestMaintenanceItemQty = value;
                }
            }
        }
        public decimal PPRequestMaintenanceItemRQty
        {
            get { return _pPRequestMaintenanceItemRQty; }
            set
            {
                if (value != this._pPRequestMaintenanceItemRQty)
                {
                    _pPRequestMaintenanceItemRQty = value;
                }
            }
        }
        public int FK_PPMaintenanceCategroyID
        {
            get { return _fK_PPMaintenanceCategroyID; }
            set
            {
                if (value != this._fK_PPMaintenanceCategroyID)
                {
                    _fK_PPMaintenanceCategroyID = value;
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
        public int PPRequestMaintenanceItemTime
        {
            get { return _pPRequestMaintenanceItemTime; }
            set
            {
                if (value != this._pPRequestMaintenanceItemTime)
                {
                    _pPRequestMaintenanceItemTime = value;
                }
            }
        }
        public String PPRequestMaintenanceItemNote
        {
            get { return _pPRequestMaintenanceItemNote; }
            set
            {
                if (value != this._pPRequestMaintenanceItemNote)
                {
                    _pPRequestMaintenanceItemNote = value;
                }
            }
        }

        #endregion
    }
}
