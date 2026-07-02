using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ADApprovalProcs")]
    public class ADApprovalProcsInfo:BaseInfo
    {
        #region Variables
        protected int _aDApprovalProcID;
        protected String _aDApprovalProcNo = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aDDocumentType = String.Empty;
        protected bool _aDApprovalProcBroadcast = true;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected bool _aDApprovalProcActive = true;
        protected String _documentQueryCritical = String.Empty;
        protected String _aAModule = String.Empty;
        protected String _aDApprovalProcName = String.Empty;
        protected bool _aDApprovalProcStrictUser = true;

        #endregion
        [Key]
        #region Public properties
        public int ADApprovalProcID
        {
            get { return _aDApprovalProcID; }
            set
            {
                if (value != this._aDApprovalProcID)
                {
                    _aDApprovalProcID = value;
          
                }
            }
        }
        public String ADApprovalProcNo
        {
            get { return _aDApprovalProcNo; }
            set
            {
                if (value != this._aDApprovalProcNo)
                {
                    _aDApprovalProcNo = value;
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
        public String ADDocumentType
        {
            get { return _aDDocumentType; }
            set
            {
                if (value != this._aDDocumentType)
                {
                    _aDDocumentType = value;
                }
            }
        }
        public bool ADApprovalProcBroadcast
        {
            get { return _aDApprovalProcBroadcast; }
            set
            {
                if (value != this._aDApprovalProcBroadcast)
                {
                    _aDApprovalProcBroadcast = value;
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
        public bool ADApprovalProcActive
        {
            get { return _aDApprovalProcActive; }
            set
            {
                if (value != this._aDApprovalProcActive)
                {
                    _aDApprovalProcActive = value;
                }
            }
        }
        public String DocumentQueryCritical
        {
            get { return _documentQueryCritical; }
            set
            {
                if (value != this._documentQueryCritical)
                {
                    _documentQueryCritical = value;
                }
            }
        }
        public String AAModule
        {
            get { return _aAModule; }
            set
            {
                if (value != this._aAModule)
                {
                    _aAModule = value;
                }
            }
        }
        public String ADApprovalProcName
        {
            get { return _aDApprovalProcName; }
            set
            {
                if (value != this._aDApprovalProcName)
                {
                    _aDApprovalProcName = value;
                }
            }
        }
        public bool ADApprovalProcStrictUser
        {
            get { return _aDApprovalProcStrictUser; }
            set
            {
                if (value != this._aDApprovalProcStrictUser)
                {
                    _aDApprovalProcStrictUser = value;
                }
            }
        }

        #endregion
    }
}
