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
    [Table("PPMaintenanceNormRMs")]
    public class PPMaintenanceNormRMsInfo : BaseInfo
    {
        public PPMaintenanceNormRMsInfo()
        {
        }
        #region Variables
        protected int _pPMaintenanceNormRMID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected decimal _pPMaintenanceNormRMQty;
        protected String _pPMaintenanceNormRMDesc = String.Empty;
        protected int _fK_PPMaintenanceNormID;
        protected int _fK_ICProductID;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected decimal _pPMaintenanceNormRMStkQty;
        protected decimal _pPMaintenanceNormRMFact;
        protected int _fK_PPMaintenanceCategroyCfgID;

        #endregion
        #region Public properties
        [Key]
        public int PPMaintenanceNormRMID
        {
            get { return _pPMaintenanceNormRMID; }
            set
            {
                if (value != this._pPMaintenanceNormRMID)
                {
                    _pPMaintenanceNormRMID = value;
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
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPMaintenanceNormRMQty
        {
            get { return _pPMaintenanceNormRMQty; }
            set
            {
                if (value != this._pPMaintenanceNormRMQty)
                {
                    _pPMaintenanceNormRMQty = value;
                }
            }
        }
        public String PPMaintenanceNormRMDesc
        {
            get { return _pPMaintenanceNormRMDesc; }
            set
            {
                if (value != this._pPMaintenanceNormRMDesc)
                {
                    _pPMaintenanceNormRMDesc = value;
                }
            }
        }
        public int FK_PPMaintenanceNormID
        {
            get { return _fK_PPMaintenanceNormID; }
            set
            {
                if (value != this._fK_PPMaintenanceNormID)
                {
                    _fK_PPMaintenanceNormID = value;
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
        public decimal PPMaintenanceNormRMStkQty
        {
            get { return _pPMaintenanceNormRMStkQty; }
            set
            {
                if (value != this._pPMaintenanceNormRMStkQty)
                {
                    _pPMaintenanceNormRMStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPMaintenanceNormRMFact
        {
            get { return _pPMaintenanceNormRMFact; }
            set
            {
                if (value != this._pPMaintenanceNormRMFact)
                {
                    _pPMaintenanceNormRMFact = value;
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

        #endregion

    }
}
