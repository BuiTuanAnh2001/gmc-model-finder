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
    [Table("PPPlanMaintenanceItemCategorys")]
    public class PPPlanMaintenanceItemCategorysInfo : BaseInfo
    {
        public PPPlanMaintenanceItemCategorysInfo()
        {
        }
        #region Variables
        protected int _pPPlanMaintenanceItemCategoryID;
        protected int _fK_PPDeviceID;
        protected int _fK_PPMaintenanceCategroyID;
        protected Nullable<DateTime> _pPMaintenanceDate;
        protected int _fK_PPPlanMaintenanceItemID;
        protected int _fK_PPPlanMaintenanceID;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected decimal _pPPlanMaintenanceItemCategoryQty;
        protected decimal _pPPlanMaintenanceItemCategoryRQty;
        protected int _fK_PPMaintenanceCategroyCfgID;
        protected Nullable<DateTime> _pPPlanMaintenanceItemCategoryFDate;
        protected Nullable<DateTime> _pPPlanMaintenanceItemCategoryTDate;
        protected int _pPPlanMaintenanceItemCategoryTime;
        protected Nullable<DateTime> _pPPlanMaintenanceItemCategoryNearestDate;

        #endregion
        #region Public properties
        [Key]
        public int PPPlanMaintenanceItemCategoryID
        {
            get { return _pPPlanMaintenanceItemCategoryID; }
            set
            {
                if (value != this._pPPlanMaintenanceItemCategoryID)
                {
                    _pPPlanMaintenanceItemCategoryID = value;
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
        public Nullable<DateTime> PPMaintenanceDate
        {
            get { return _pPMaintenanceDate; }
            set
            {
                if (value != this._pPMaintenanceDate)
                {
                    _pPMaintenanceDate = value;
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
        [Column(TypeName = "decimal(16, 9)")]
        public decimal PPPlanMaintenanceItemCategoryQty
        {
            get { return _pPPlanMaintenanceItemCategoryQty; }
            set
            {
                if (value != this._pPPlanMaintenanceItemCategoryQty)
                {
                    _pPPlanMaintenanceItemCategoryQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(16, 9)")]
        public decimal PPPlanMaintenanceItemCategoryRQty
        {
            get { return _pPPlanMaintenanceItemCategoryRQty; }
            set
            {
                if (value != this._pPPlanMaintenanceItemCategoryRQty)
                {
                    _pPPlanMaintenanceItemCategoryRQty = value;
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
        public Nullable<DateTime> PPPlanMaintenanceItemCategoryFDate
        {
            get { return _pPPlanMaintenanceItemCategoryFDate; }
            set
            {
                if (value != this._pPPlanMaintenanceItemCategoryFDate)
                {
                    _pPPlanMaintenanceItemCategoryFDate = value;
                }
            }
        }
        public Nullable<DateTime> PPPlanMaintenanceItemCategoryTDate
        {
            get { return _pPPlanMaintenanceItemCategoryTDate; }
            set
            {
                if (value != this._pPPlanMaintenanceItemCategoryTDate)
                {
                    _pPPlanMaintenanceItemCategoryTDate = value;
                }
            }
        }
        public int PPPlanMaintenanceItemCategoryTime
        {
            get { return _pPPlanMaintenanceItemCategoryTime; }
            set
            {
                if (value != this._pPPlanMaintenanceItemCategoryTime)
                {
                    _pPPlanMaintenanceItemCategoryTime = value;
                }
            }
        }
        public Nullable<DateTime> PPPlanMaintenanceItemCategoryNearestDate
        {
            get { return _pPPlanMaintenanceItemCategoryNearestDate; }
            set
            {
                if (value != this._pPPlanMaintenanceItemCategoryNearestDate)
                {
                    _pPPlanMaintenanceItemCategoryNearestDate = value;
                }
            }
        }

        #endregion

    }
}
