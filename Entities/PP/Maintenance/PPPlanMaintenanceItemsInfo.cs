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
    [Table("PPPlanMaintenanceItems")]
    public class PPPlanMaintenanceItemsInfo : BaseInfo
    {
        public PPPlanMaintenanceItemsInfo()
        {
        }
        #region Variables
        protected int _pPPlanMaintenanceItemID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _pPPlanMaintenanceItemDesc = String.Empty;
        protected int _fK_PPPlanMaintenanceID;
        protected int _fK_PPCalendarMaintenanceID;
        protected int _fK_PPCalendarMaintenanceItemID;
        protected int _fK_PPWorkCenterID;
        protected int _fK_PPDeviceID;
        protected Nullable<DateTime> _pPPlanMaintenanceItemStarDate;
        protected Nullable<DateTime> _pPPlanMaintenanceItemEndDate;
        protected decimal _pPPlanMaintenanceItemQty;
        protected decimal _pPPlanMaintenanceItemRQty;
        protected int _fK_PPMaintenanceCategroyID;

        #endregion
        #region Public properties
        [Key]
        public int PPPlanMaintenanceItemID
        {
            get { return _pPPlanMaintenanceItemID; }
            set
            {
                if (value != this._pPPlanMaintenanceItemID)
                {
                    _pPPlanMaintenanceItemID = value;
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
        public String PPPlanMaintenanceItemDesc
        {
            get { return _pPPlanMaintenanceItemDesc; }
            set
            {
                if (value != this._pPPlanMaintenanceItemDesc)
                {
                    _pPPlanMaintenanceItemDesc = value;
                }
            }
        }
        public int FK_PPPlanMaintenanceID
        {
            get { return _fK_PPPlanMaintenanceID; }
            set
            {
                if (value != this._fK_PPPlanMaintenanceID)
                {
                    _fK_PPPlanMaintenanceID = value;
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
        public int FK_PPCalendarMaintenanceItemID
        {
            get { return _fK_PPCalendarMaintenanceItemID; }
            set
            {
                if (value != this._fK_PPCalendarMaintenanceItemID)
                {
                    _fK_PPCalendarMaintenanceItemID = value;
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
        public Nullable<DateTime> PPPlanMaintenanceItemStarDate
        {
            get { return _pPPlanMaintenanceItemStarDate; }
            set
            {
                if (value != this._pPPlanMaintenanceItemStarDate)
                {
                    _pPPlanMaintenanceItemStarDate = value;
                }
            }
        }
        public Nullable<DateTime> PPPlanMaintenanceItemEndDate
        {
            get { return _pPPlanMaintenanceItemEndDate; }
            set
            {
                if (value != this._pPPlanMaintenanceItemEndDate)
                {
                    _pPPlanMaintenanceItemEndDate = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPPlanMaintenanceItemQty
        {
            get { return _pPPlanMaintenanceItemQty; }
            set
            {
                if (value != this._pPPlanMaintenanceItemQty)
                {
                    _pPPlanMaintenanceItemQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPPlanMaintenanceItemRQty
        {
            get { return _pPPlanMaintenanceItemRQty; }
            set
            {
                if (value != this._pPPlanMaintenanceItemRQty)
                {
                    _pPPlanMaintenanceItemRQty = value;
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

        #endregion

    }
}
