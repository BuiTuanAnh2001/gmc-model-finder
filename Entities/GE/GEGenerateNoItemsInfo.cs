using ExpertLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities.GE
{
    [Table("GEGenerateNoItems")]
    public class GEGenerateNoItemsInfo : BaseInfo
    {
        public GEGenerateNoItemsInfo()
        {
        }
        #region Variables
        protected int _gEGenerateNoItemID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected bool _aASelected = true;
        protected int _fK_GEGenerateNoID;
        protected String _gEGenerateNoItemTypeCombo = String.Empty;
        protected String _gEGenerateNoItemColumnName = String.Empty;
        protected String _gEGenerateNoItemForeignTableName = String.Empty;
        protected String _gEGenerateNoItemForeignColumnName = String.Empty;
        protected int _gEGenerateNoItemLength;
        protected String _gEGenerateNoItemSeperatorCombo = String.Empty;
        protected String _gEGenerateNoItemFormatCombo = String.Empty;
        protected String _gEGenerateNoItemValue = String.Empty;
        protected int _gEGenerateNoItemOrderBy;
        protected bool _gEGenerateNoItemIsGetValueLastCheck = true;
        #endregion
        [Key]
        #region Public properties
        public int GEGenerateNoItemID
        {
            get { return _gEGenerateNoItemID; }
            set
            {
                if (value != this._gEGenerateNoItemID)
                {
                    _gEGenerateNoItemID = value;
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
        public int FK_GEGenerateNoID
        {
            get { return _fK_GEGenerateNoID; }
            set
            {
                if (value != this._fK_GEGenerateNoID)
                {
                    _fK_GEGenerateNoID = value;
                }
            }
        }
        public String GEGenerateNoItemTypeCombo
        {
            get { return _gEGenerateNoItemTypeCombo; }
            set
            {
                if (value != this._gEGenerateNoItemTypeCombo)
                {
                    _gEGenerateNoItemTypeCombo = value;
                }
            }
        }
        public String GEGenerateNoItemColumnName
        {
            get { return _gEGenerateNoItemColumnName; }
            set
            {
                if (value != this._gEGenerateNoItemColumnName)
                {
                    _gEGenerateNoItemColumnName = value;
                }
            }
        }
        public String GEGenerateNoItemForeignTableName
        {
            get { return _gEGenerateNoItemForeignTableName; }
            set
            {
                if (value != this._gEGenerateNoItemForeignTableName)
                {
                    _gEGenerateNoItemForeignTableName = value;
                }
            }
        }
        public String GEGenerateNoItemForeignColumnName
        {
            get { return _gEGenerateNoItemForeignColumnName; }
            set
            {
                if (value != this._gEGenerateNoItemForeignColumnName)
                {
                    _gEGenerateNoItemForeignColumnName = value;
                }
            }
        }
        public int GEGenerateNoItemLength
        {
            get { return _gEGenerateNoItemLength; }
            set
            {
                if (value != this._gEGenerateNoItemLength)
                {
                    _gEGenerateNoItemLength = value;
                }
            }
        }
        public String GEGenerateNoItemSeperatorCombo
        {
            get { return _gEGenerateNoItemSeperatorCombo; }
            set
            {
                if (value != this._gEGenerateNoItemSeperatorCombo)
                {
                    _gEGenerateNoItemSeperatorCombo = value;
                }
            }
        }
        public String GEGenerateNoItemFormatCombo
        {
            get { return _gEGenerateNoItemFormatCombo; }
            set
            {
                if (value != this._gEGenerateNoItemFormatCombo)
                {
                    _gEGenerateNoItemFormatCombo = value;
                }
            }
        }
        public String GEGenerateNoItemValue
        {
            get { return _gEGenerateNoItemValue; }
            set
            {
                if (value != this._gEGenerateNoItemValue)
                {
                    _gEGenerateNoItemValue = value;
                }
            }
        }
        public int GEGenerateNoItemOrderBy
        {
            get { return _gEGenerateNoItemOrderBy; }
            set
            {
                if (value != this._gEGenerateNoItemOrderBy)
                {
                    _gEGenerateNoItemOrderBy = value;
                }
            }
        }
        public bool GEGenerateNoItemIsGetValueLastCheck
        {
            get { return _gEGenerateNoItemIsGetValueLastCheck; }
            set
            {
                if (value != this._gEGenerateNoItemIsGetValueLastCheck)
                {
                    _gEGenerateNoItemIsGetValueLastCheck = value;
                }
            }
        }
        #endregion
    }
}
