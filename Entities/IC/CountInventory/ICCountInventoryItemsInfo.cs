using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICCountInventoryItems")]
    public class ICCountInventoryItemsInfo
    {
        //[Key]
        #region Variables
        protected int _iCCountInventoryItemID;
        protected String _aAStatus = "Alive";
        protected bool _aASelected = true;
        protected int _fK_ICCountInventoryID;
        protected int _fK_ICProductID;
        protected int _fK_ICStockID;
        protected int _fK_ICStockUOMID;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected decimal _iCCountInventoryItemQty;
        protected decimal _iCCountInventoryItemStkQty;
        protected String _iCCountInventoryItemLotNo = String.Empty;
        protected decimal _iCCountInventoryItemUnitCost;
        protected decimal _iCCountInventoryItemCostTot;
        protected decimal _iCCountInventoryItemAdjStkQty;
        protected decimal _iCCountInventoryItemFact;
        protected String _iCCountInventoryItemBarCodeNo = String.Empty;
        protected String _iCCountInventoryItemSerialNo = String.Empty;

        #endregion
        #region Public properties
        public int ICCountInventoryItemID
        {
            get { return _iCCountInventoryItemID; }
            set
            {
                if (value != this._iCCountInventoryItemID)
                {
                    _iCCountInventoryItemID = value;
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
        public int FK_ICCountInventoryID
        {
            get { return _fK_ICCountInventoryID; }
            set
            {
                if (value != this._fK_ICCountInventoryID)
                {
                    _fK_ICCountInventoryID = value;
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
        public int FK_ICStockID
        {
            get { return _fK_ICStockID; }
            set
            {
                if (value != this._fK_ICStockID)
                {
                    _fK_ICStockID = value;
                }
            }
        }
        public int FK_ICStockUOMID
        {
            get { return _fK_ICStockUOMID; }
            set
            {
                if (value != this._fK_ICStockUOMID)
                {
                    _fK_ICStockUOMID = value;
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
        public decimal ICCountInventoryItemQty
        {
            get { return _iCCountInventoryItemQty; }
            set
            {
                if (value != this._iCCountInventoryItemQty)
                {
                    _iCCountInventoryItemQty = value;
                }
            }
        }
        public decimal ICCountInventoryItemStkQty
        {
            get { return _iCCountInventoryItemStkQty; }
            set
            {
                if (value != this._iCCountInventoryItemStkQty)
                {
                    _iCCountInventoryItemStkQty = value;
                }
            }
        }
        public String ICCountInventoryItemLotNo
        {
            get { return _iCCountInventoryItemLotNo; }
            set
            {
                if (value != this._iCCountInventoryItemLotNo)
                {
                    _iCCountInventoryItemLotNo = value;
                }
            }
        }
        public decimal ICCountInventoryItemUnitCost
        {
            get { return _iCCountInventoryItemUnitCost; }
            set
            {
                if (value != this._iCCountInventoryItemUnitCost)
                {
                    _iCCountInventoryItemUnitCost = value;
                }
            }
        }
        public decimal ICCountInventoryItemCostTot
        {
            get { return _iCCountInventoryItemCostTot; }
            set
            {
                if (value != this._iCCountInventoryItemCostTot)
                {
                    _iCCountInventoryItemCostTot = value;
                }
            }
        }
        public decimal ICCountInventoryItemAdjStkQty
        {
            get { return _iCCountInventoryItemAdjStkQty; }
            set
            {
                if (value != this._iCCountInventoryItemAdjStkQty)
                {
                    _iCCountInventoryItemAdjStkQty = value;
                }
            }
        }
        public decimal ICCountInventoryItemFact
        {
            get { return _iCCountInventoryItemFact; }
            set
            {
                if (value != this._iCCountInventoryItemFact)
                {
                    _iCCountInventoryItemFact = value;
                }
            }
        }
        public String ICCountInventoryItemBarCodeNo
        {
            get { return _iCCountInventoryItemBarCodeNo; }
            set
            {
                if (value != this._iCCountInventoryItemBarCodeNo)
                {
                    _iCCountInventoryItemBarCodeNo = value;
                }
            }
        }
        public String ICCountInventoryItemSerialNo
        {
            get { return _iCCountInventoryItemSerialNo; }
            set
            {
                if (value != this._iCCountInventoryItemSerialNo)
                {
                    _iCCountInventoryItemSerialNo = value;
                }
            }
        }

        #endregion
    }
}
