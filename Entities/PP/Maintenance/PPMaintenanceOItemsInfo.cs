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
    [Table("PPMaintenanceOItems")]
    public class PPMaintenanceOItemsInfo : BaseInfo
    {
        public PPMaintenanceOItemsInfo()
        {
        }
        #region Variables
        protected int _pPMaintenanceOItemID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _pPMaintenanceOItemDesc = String.Empty;
        protected String _pPMaintenanceOItemStatusCombo = DefaultStatus;
        protected String _pPMaintenanceOItemTypeCombo = String.Empty;
        protected int _fK_PPMaintenanceOID;
        protected int _fK_PPPlanMaintenanceID;
        protected int _fK_PPPlanMaintenanceItemID;
        protected int _fK_PPRequestMaintenanceID;
        protected int _fK_PPCalendarMaintenanceID;
        protected int _fK_PPDeviceID;
        protected int _fK_PPWorkCenterID;
        protected Nullable<DateTime> _pPMaintenanceOItemStarDate;
        protected Nullable<DateTime> _pPMaintenanceOItemEndDate;
        protected decimal _pPMaintenanceOItemQty;
        protected decimal _pPMaintenanceOItemRQty;
        protected int _fK_PPRequestMaintenanceItemID;
        protected int _fK_PPMaintenanceCategroyID;
        protected int _fK_PPPlanMaintenanceItemCategoryID;
        protected int _fK_PPMaintenanceCategroyCfgID;
        protected int _pPMaintenanceOItemTime;

        #endregion
        #region Public properties
        [Key]
        public int PPMaintenanceOItemID
        {
            get { return _pPMaintenanceOItemID; }
            set
            {
                if (value != this._pPMaintenanceOItemID)
                {
                    _pPMaintenanceOItemID = value;
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
        public String PPMaintenanceOItemDesc
        {
            get { return _pPMaintenanceOItemDesc; }
            set
            {
                if (value != this._pPMaintenanceOItemDesc)
                {
                    _pPMaintenanceOItemDesc = value;
                }
            }
        }
        public String PPMaintenanceOItemStatusCombo
        {
            get { return _pPMaintenanceOItemStatusCombo; }
            set
            {
                if (value != this._pPMaintenanceOItemStatusCombo)
                {
                    _pPMaintenanceOItemStatusCombo = value;
                }
            }
        }
        public String PPMaintenanceOItemTypeCombo
        {
            get { return _pPMaintenanceOItemTypeCombo; }
            set
            {
                if (value != this._pPMaintenanceOItemTypeCombo)
                {
                    _pPMaintenanceOItemTypeCombo = value;
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
        public int FK_PPPlanMaintenanceItemID
        {
            get { return _fK_PPPlanMaintenanceItemID; }
            set
            {
                if (value != this._fK_PPPlanMaintenanceItemID)
                {
                    _fK_PPPlanMaintenanceItemID = value;
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
        public Nullable<DateTime> PPMaintenanceOItemStarDate
        {
            get { return _pPMaintenanceOItemStarDate; }
            set
            {
                if (value != this._pPMaintenanceOItemStarDate)
                {
                    _pPMaintenanceOItemStarDate = value;
                }
            }
        }
        public Nullable<DateTime> PPMaintenanceOItemEndDate
        {
            get { return _pPMaintenanceOItemEndDate; }
            set
            {
                if (value != this._pPMaintenanceOItemEndDate)
                {
                    _pPMaintenanceOItemEndDate = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPMaintenanceOItemQty
        {
            get { return _pPMaintenanceOItemQty; }
            set
            {
                if (value != this._pPMaintenanceOItemQty)
                {
                    _pPMaintenanceOItemQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPMaintenanceOItemRQty
        {
            get { return _pPMaintenanceOItemRQty; }
            set
            {
                if (value != this._pPMaintenanceOItemRQty)
                {
                    _pPMaintenanceOItemRQty = value;
                }
            }
        }
        public int FK_PPRequestMaintenanceItemID
        {
            get { return _fK_PPRequestMaintenanceItemID; }
            set
            {
                if (value != this._fK_PPRequestMaintenanceItemID)
                {
                    _fK_PPRequestMaintenanceItemID = value;
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
        public int FK_PPPlanMaintenanceItemCategoryID
        {
            get { return _fK_PPPlanMaintenanceItemCategoryID; }
            set
            {
                if (value != this._fK_PPPlanMaintenanceItemCategoryID)
                {
                    _fK_PPPlanMaintenanceItemCategoryID = value;
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
        public int PPMaintenanceOItemTime
        {
            get { return _pPMaintenanceOItemTime; }
            set
            {
                if (value != this._pPMaintenanceOItemTime)
                {
                    _pPMaintenanceOItemTime = value;
                }
            }
        }

        #endregion

    }
}
