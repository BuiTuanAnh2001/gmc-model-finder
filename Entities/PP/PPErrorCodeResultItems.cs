using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("PPErrorCodeResultItems")]
    public class PPErrorCodeResultItems :BaseInfo
    {
        #region Variables
        protected int _pPErrorCodeResultItemID;
        protected int _fK_PPErrorCodeResultID;
        protected int _fK_PPErrorCodeID;
        protected String _pPErrorCodeResultItemNote = String.Empty;
        protected decimal _pPErrorCodeResultItemFGQty;
        protected decimal _pPErrorCodeResultItemNoneQty;
        protected String _pPErrorCodeResultItemDesc = String.Empty;
        protected String _aAStatus = DefaultAAStatus;

        #endregion
        #region Public properties
        [Key]
        public int PPErrorCodeResultItemID
        {
            get { return _pPErrorCodeResultItemID; }
            set
            {
                if (value != this._pPErrorCodeResultItemID)
                {
                    _pPErrorCodeResultItemID = value;
                }
            }
        }
        public int FK_PPErrorCodeResultID
        {
            get { return _fK_PPErrorCodeResultID; }
            set
            {
                if (value != this._fK_PPErrorCodeResultID)
                {
                    _fK_PPErrorCodeResultID = value;
                }
            }
        }
        public int FK_PPErrorCodeID
        {
            get { return _fK_PPErrorCodeID; }
            set
            {
                if (value != this._fK_PPErrorCodeID)
                {
                    _fK_PPErrorCodeID = value;
                }
            }
        }
        public String PPErrorCodeResultItemNote
        {
            get { return _pPErrorCodeResultItemNote; }
            set
            {
                if (value != this._pPErrorCodeResultItemNote)
                {
                    _pPErrorCodeResultItemNote = value;
                }
            }
        }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal PPErrorCodeResultItemFGQty
        {
            get { return _pPErrorCodeResultItemFGQty; }
            set
            {
                if (value != this._pPErrorCodeResultItemFGQty)
                {
                    _pPErrorCodeResultItemFGQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal PPErrorCodeResultItemNoneQty
        {
            get { return _pPErrorCodeResultItemNoneQty; }
            set
            {
                if (value != this._pPErrorCodeResultItemNoneQty)
                {
                    _pPErrorCodeResultItemNoneQty = value;
                }
            }
        }
        public String PPErrorCodeResultItemDesc
        {
            get { return _pPErrorCodeResultItemDesc; }
            set
            {
                if (value != this._pPErrorCodeResultItemDesc)
                {
                    _pPErrorCodeResultItemDesc = value;
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
