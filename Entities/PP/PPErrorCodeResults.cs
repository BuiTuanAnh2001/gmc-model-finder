using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("PPErrorCodeResults")]
    public class PPErrorCodeResults : BaseInfo
    {
        #region Variables
        protected int _pPErrorCodeResultID;
        protected String _pPErrorCodeResultNo = String.Empty;
        protected String _pPErrorCodeResultName = String.Empty;
        protected Nullable<DateTime> _pPErrorCodeResultDate;
        protected String _pPErrorCodeResultDesc = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected bool _aASelected = true;
        protected int _fK_PPProductionOrdrEstFGID;
        protected int _fK_PPProductionOrdrID;
        protected String _pPErrorCodeResultUser = String.Empty;
        protected String _pPErrorCodeResultStatus = DefaultStatus;

        #endregion
        #region Public properties
        [Key]
        public int PPErrorCodeResultID
        {
            get { return _pPErrorCodeResultID; }
            set
            {
                if (value != this._pPErrorCodeResultID)
                {
                    _pPErrorCodeResultID = value;
                }
            }
        }
        public String PPErrorCodeResultNo
        {
            get { return _pPErrorCodeResultNo; }
            set
            {
                if (value != this._pPErrorCodeResultNo)
                {
                    _pPErrorCodeResultNo = value;
                }
            }
        }
        public String PPErrorCodeResultName
        {
            get { return _pPErrorCodeResultName; }
            set
            {
                if (value != this._pPErrorCodeResultName)
                {
                    _pPErrorCodeResultName = value;
                }
            }
        }
        public Nullable<DateTime> PPErrorCodeResultDate
        {
            get { return _pPErrorCodeResultDate; }
            set
            {
                if (value != this._pPErrorCodeResultDate)
                {
                    _pPErrorCodeResultDate = value;
                }
            }
        }
        public String PPErrorCodeResultDesc
        {
            get { return _pPErrorCodeResultDesc; }
            set
            {
                if (value != this._pPErrorCodeResultDesc)
                {
                    _pPErrorCodeResultDesc = value;
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
        public String PPErrorCodeResultUser
        {
            get { return _pPErrorCodeResultUser; }
            set
            {
                if (value != this._pPErrorCodeResultUser)
                {
                    _pPErrorCodeResultUser = value;
                }
            }
        }
        public String PPErrorCodeResultStatus
        {
            get { return _pPErrorCodeResultStatus; }
            set
            {
                if (value != this._pPErrorCodeResultStatus)
                {
                    _pPErrorCodeResultStatus = value;
                }
            }
        }

        #endregion

    }
}