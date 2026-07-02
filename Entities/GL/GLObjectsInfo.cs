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
    [Table("GLObjects")]
    public class GLObjectsInfo : BaseInfo
    {
        public GLObjectsInfo()
        {
        }
        #region Variables
        protected int _gLObjectID;
        protected String _gLObjectNo = String.Empty;
        protected String _gLObjectName = String.Empty;
        protected String _gLObjectType = String.Empty;
        protected int _fK_ObjectRefID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAStatus = DefaultAAStatus;
        #endregion
        [Key]
        #region Public properties
        public int GLObjectID
        {
            get { return _gLObjectID; }
            set
            {
                if (value != this._gLObjectID)
                {
                    _gLObjectID = value;
                }
            }
        }
        public String GLObjectNo
        {
            get { return _gLObjectNo; }
            set
            {
                if (value != this._gLObjectNo)
                {
                    _gLObjectNo = value;
                }
            }
        }
        public String GLObjectName
        {
            get { return _gLObjectName; }
            set
            {
                if (value != this._gLObjectName)
                {
                    _gLObjectName = value;
                  }
            }
        }
        public String GLObjectType
        {
            get { return _gLObjectType; }
            set
            {
                if (value != this._gLObjectType)
                {
                    _gLObjectType = value;
                }
            }
        }
        public int FK_ObjectRefID
        {
            get { return _fK_ObjectRefID; }
            set
            {
                if (value != this._fK_ObjectRefID)
                {
                    _fK_ObjectRefID = value;
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
        #endregion
    }
}
