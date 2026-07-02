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
    [Table("ICShipmentItemSOItems")]
    public class ICShipmentItemSOItemsInfo : BaseInfo
    {
        public ICShipmentItemSOItemsInfo()
        {
        }
        #region Variables
        protected int _iCShipmentItemSOItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARSOItemID;
        protected int _fK_ICShipmentItemID;
        #endregion
        [Key]
        #region Public properties
        public int ICShipmentItemSOItemID
        {
            get { return _iCShipmentItemSOItemID; }
            set
            {
                if (value != this._iCShipmentItemSOItemID)
                {
                    _iCShipmentItemSOItemID = value;
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
        public int FK_ARSOItemID
        {
            get { return _fK_ARSOItemID; }
            set
            {
                if (value != this._fK_ARSOItemID)
                {
                    _fK_ARSOItemID = value;
                }
            }
        }
        public int FK_ICShipmentItemID
        {
            get { return _fK_ICShipmentItemID; }
            set
            {
                if (value != this._fK_ICShipmentItemID)
                {
                    _fK_ICShipmentItemID = value;
                }
            }
        }
        #endregion
    }
}
