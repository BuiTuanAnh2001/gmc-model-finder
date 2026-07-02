using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("PPProductionOrdrFGReferens")]
    public class PPProductionOrdrFGReferensInfo : BaseInfo
    {
        #region Variables
        protected int _pPProductionOrdrFGReferenID;
        protected int _fK_PPProductionOrdrEstFGID;
        protected int _fK_PPFromProductionOrdrEstFGID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected bool _aASelected = true;
        protected int _fK_PPProductionOrdrID;
        protected int _fK_PPFromProductionOrdrID;
        protected decimal _pPProductionOrdrFGReferenQty;

        #endregion
        [Key]
        #region Public properties
        public int PPProductionOrdrFGReferenID
        {
            get { return _pPProductionOrdrFGReferenID; }
            set
            {
                if (value != this._pPProductionOrdrFGReferenID)
                {
                    _pPProductionOrdrFGReferenID = value;
                }
            }
        }
        public int FK_PPProductionOrdrEstFGID
        {
            get { return _fK_PPProductionOrdrEstFGID; }
            set
            {
                if (value != this._fK_PPProductionOrdrEstFGID)
                {
                    _fK_PPProductionOrdrEstFGID = value;
                }
            }
        }
        public int FK_PPFromProductionOrdrEstFGID
        {
            get { return _fK_PPFromProductionOrdrEstFGID; }
            set
            {
                if (value != this._fK_PPFromProductionOrdrEstFGID)
                {
                    _fK_PPFromProductionOrdrEstFGID = value;
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
        public int FK_PPProductionOrdrID
        {
            get { return _fK_PPProductionOrdrID; }
            set
            {
                if (value != this._fK_PPProductionOrdrID)
                {
                    _fK_PPProductionOrdrID = value;
                }
            }
        }
        public int FK_PPFromProductionOrdrID
        {
            get { return _fK_PPFromProductionOrdrID; }
            set
            {
                if (value != this._fK_PPFromProductionOrdrID)
                {
                    _fK_PPFromProductionOrdrID = value;
                }
            }
        }
        public decimal PPProductionOrdrFGReferenQty
        {
            get { return _pPProductionOrdrFGReferenQty; }
            set
            {
                if (value != this._pPProductionOrdrFGReferenQty)
                {
                    _pPProductionOrdrFGReferenQty = value;
                }
            }
        }

        #endregion


    }
}
