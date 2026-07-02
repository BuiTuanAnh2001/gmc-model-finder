using ExpertLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities.GE
{
    [Table("GEGenerateNos")]
    public class GEGenerateNosInfo : BaseInfo
    {
        public GEGenerateNosInfo()
        {
        }
        #region Variables
        protected int _gEGenerateNoID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _gEGenerateNoNo = String.Empty;
        protected String _gEGenerateNoName = String.Empty;
        protected DateTime _gEGenerateNoDate = DateTime.Now;
        protected String _gEGenerateNoDesc = String.Empty;
        protected int _fK_STModuleDescriptionID;
        protected int _fK_STModuleID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _gEGenerateNoTypeCombo = String.Empty;

        #endregion
        [Key]
        #region Public properties
        public int GEGenerateNoID
        {
            get { return _gEGenerateNoID; }
            set
            {
                if (value != this._gEGenerateNoID)
                {
                    _gEGenerateNoID = value;
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
        public String GEGenerateNoNo
        {
            get { return _gEGenerateNoNo; }
            set
            {
                if (value != this._gEGenerateNoNo)
                {
                    _gEGenerateNoNo = value;
                }
            }
        }
        public String GEGenerateNoName
        {
            get { return _gEGenerateNoName; }
            set
            {
                if (value != this._gEGenerateNoName)
                {
                    _gEGenerateNoName = value;
                }
            }
        }
        public DateTime GEGenerateNoDate
        {
            get { return _gEGenerateNoDate; }
            set
            {
                if (value != this._gEGenerateNoDate)
                {
                    _gEGenerateNoDate = value;
                }
            }
        }
        public String GEGenerateNoDesc
        {
            get { return _gEGenerateNoDesc; }
            set
            {
                if (value != this._gEGenerateNoDesc)
                {
                    _gEGenerateNoDesc = value;
                }
            }
        }
        public int FK_STModuleDescriptionID
        {
            get { return _fK_STModuleDescriptionID; }
            set
            {
                if (value != this._fK_STModuleDescriptionID)
                {
                    _fK_STModuleDescriptionID = value;
                }
            }
        }
        public int FK_STModuleID
        {
            get { return _fK_STModuleID; }
            set
            {
                if (value != this._fK_STModuleID)
                {
                    _fK_STModuleID = value;
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
        public String GEGenerateNoTypeCombo
        {
            get { return _gEGenerateNoTypeCombo; }
            set
            {
                if (value != this._gEGenerateNoTypeCombo)
                {
                    _gEGenerateNoTypeCombo = value;
                }
            }
        }

        #endregion
    }
}
