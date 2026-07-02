using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICCountInventoryResultItems")]
    public class ICCountInventoryResultItemsInfo: BaseInfo
    {
        #region Variables
        protected int _iCCountInventoryResultItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_ICCountInventoryResultID;
        protected int _fK_ICProductID;
        protected int _fK_ICStockID;
        protected int _fK_ICStockUOMID;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected String _iCCountInventoryResultItemLotNo = String.Empty;
        protected decimal _iCCountInventoryResultItemQty;
        protected decimal _iCCountInventoryResultItemStkQty;
        protected decimal _iCCountInventoryResultItemExcessQty;
        protected decimal _iCCountInventoryResultItemExcessStkQty;
        protected decimal _iCCountInventoryResultItemDeficientQty;
        protected decimal _iCCountInventoryResultItemDeficientStkQty;
        protected decimal _iCCountInventoryResultItemActualQty;
        protected decimal _iCCountInventoryResultItemActualStkQty;
        protected decimal _iCCountInventoryResultItemUnitCost;
        protected decimal _iCCountInventoryResultItemCostTot;
        protected decimal _iCCountInventoryResultItemExcessUnitCost;
        protected decimal _iCCountInventoryResultItemExcessCostTot;
        protected decimal _iCCountInventoryResultItemDeficientUnitCost;
        protected decimal _iCCountInventoryResultItemDeficientCostTot;
        protected decimal _iCCountInventoryResultItemActualUnitCost;
        protected decimal _iCCountInventoryResultItemActualCostTot;
        protected int _fK_ICCountInventoryItemID;
        protected decimal _iCCountInventoryResultItemActualAdjStkQty;
        protected decimal _iCCountInventoryResultItemFact;
        protected String _iCCountInventoryResultItemBarCodeNo = String.Empty;
        protected String _iCCountInventoryResultItemDesc = String.Empty;
        protected String _iCCountInventoryResultItemSerialNo = String.Empty;
        protected String _gLTOF01Combo = String.Empty;
        protected String _gLTOF02Combo = String.Empty;
        protected String _gLTOF03Combo = String.Empty;
        protected String _gLTOF04Combo = String.Empty;
        protected String _gLTOF05Combo = String.Empty;
        protected String _gLTOF06Combo = String.Empty;
        protected String _gLTOF07Combo = String.Empty;
        protected String _gLTOF08Combo = String.Empty;
        protected String _gLTOF09Combo = String.Empty;
        protected String _gLTOF10Combo = String.Empty;
        protected String _gLTOF11Combo = String.Empty;
        protected String _gLTOF12Combo = String.Empty;
        protected String _gLTOF13Combo = String.Empty;
        protected String _gLTOF14Combo = String.Empty;
        protected String _gLTOF15Combo = String.Empty;
        protected String _gLTOF16Combo = String.Empty;

        #endregion
        #region Public properties
        [Key]
        public int ICCountInventoryResultItemID
        {
            get { return _iCCountInventoryResultItemID; }
            set
            {
                if (value != this._iCCountInventoryResultItemID)
                {
                    _iCCountInventoryResultItemID = value;
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
        public int FK_ICCountInventoryResultID
        {
            get { return _fK_ICCountInventoryResultID; }
            set
            {
                if (value != this._fK_ICCountInventoryResultID)
                {
                    _fK_ICCountInventoryResultID = value;
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
        public String ICCountInventoryResultItemLotNo
        {
            get { return _iCCountInventoryResultItemLotNo; }
            set
            {
                if (value != this._iCCountInventoryResultItemLotNo)
                {
                    _iCCountInventoryResultItemLotNo = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemQty
        {
            get { return _iCCountInventoryResultItemQty; }
            set
            {
                if (value != this._iCCountInventoryResultItemQty)
                {
                    _iCCountInventoryResultItemQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemStkQty
        {
            get { return _iCCountInventoryResultItemStkQty; }
            set
            {
                if (value != this._iCCountInventoryResultItemStkQty)
                {
                    _iCCountInventoryResultItemStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemExcessQty
        {
            get { return _iCCountInventoryResultItemExcessQty; }
            set
            {
                if (value != this._iCCountInventoryResultItemExcessQty)
                {
                    _iCCountInventoryResultItemExcessQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemExcessStkQty
        {
            get { return _iCCountInventoryResultItemExcessStkQty; }
            set
            {
                if (value != this._iCCountInventoryResultItemExcessStkQty)
                {
                    _iCCountInventoryResultItemExcessStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemDeficientQty
        {
            get { return _iCCountInventoryResultItemDeficientQty; }
            set
            {
                if (value != this._iCCountInventoryResultItemDeficientQty)
                {
                    _iCCountInventoryResultItemDeficientQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemDeficientStkQty
        {
            get { return _iCCountInventoryResultItemDeficientStkQty; }
            set
            {
                if (value != this._iCCountInventoryResultItemDeficientStkQty)
                {
                    _iCCountInventoryResultItemDeficientStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemActualQty
        {
            get { return _iCCountInventoryResultItemActualQty; }
            set
            {
                if (value != this._iCCountInventoryResultItemActualQty)
                {
                    _iCCountInventoryResultItemActualQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemActualStkQty
        {
            get { return _iCCountInventoryResultItemActualStkQty; }
            set
            {
                if (value != this._iCCountInventoryResultItemActualStkQty)
                {
                    _iCCountInventoryResultItemActualStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemUnitCost
        {
            get { return _iCCountInventoryResultItemUnitCost; }
            set
            {
                if (value != this._iCCountInventoryResultItemUnitCost)
                {
                    _iCCountInventoryResultItemUnitCost = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemCostTot
        {
            get { return _iCCountInventoryResultItemCostTot; }
            set
            {
                if (value != this._iCCountInventoryResultItemCostTot)
                {
                    _iCCountInventoryResultItemCostTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemExcessUnitCost
        {
            get { return _iCCountInventoryResultItemExcessUnitCost; }
            set
            {
                if (value != this._iCCountInventoryResultItemExcessUnitCost)
                {
                    _iCCountInventoryResultItemExcessUnitCost = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemExcessCostTot
        {
            get { return _iCCountInventoryResultItemExcessCostTot; }
            set
            {
                if (value != this._iCCountInventoryResultItemExcessCostTot)
                {
                    _iCCountInventoryResultItemExcessCostTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemDeficientUnitCost
        {
            get { return _iCCountInventoryResultItemDeficientUnitCost; }
            set
            {
                if (value != this._iCCountInventoryResultItemDeficientUnitCost)
                {
                    _iCCountInventoryResultItemDeficientUnitCost = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemDeficientCostTot
        {
            get { return _iCCountInventoryResultItemDeficientCostTot; }
            set
            {
                if (value != this._iCCountInventoryResultItemDeficientCostTot)
                {
                    _iCCountInventoryResultItemDeficientCostTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemActualUnitCost
        {
            get { return _iCCountInventoryResultItemActualUnitCost; }
            set
            {
                if (value != this._iCCountInventoryResultItemActualUnitCost)
                {
                    _iCCountInventoryResultItemActualUnitCost = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemActualCostTot
        {
            get { return _iCCountInventoryResultItemActualCostTot; }
            set
            {
                if (value != this._iCCountInventoryResultItemActualCostTot)
                {
                    _iCCountInventoryResultItemActualCostTot = value;
                }
            }
        }
        public int FK_ICCountInventoryItemID
        {
            get { return _fK_ICCountInventoryItemID; }
            set
            {
                if (value != this._fK_ICCountInventoryItemID)
                {
                    _fK_ICCountInventoryItemID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemActualAdjStkQty
        {
            get { return _iCCountInventoryResultItemActualAdjStkQty; }
            set
            {
                if (value != this._iCCountInventoryResultItemActualAdjStkQty)
                {
                    _iCCountInventoryResultItemActualAdjStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ICCountInventoryResultItemFact
        {
            get { return _iCCountInventoryResultItemFact; }
            set
            {
                if (value != this._iCCountInventoryResultItemFact)
                {
                    _iCCountInventoryResultItemFact = value;
                }
            }
        }
        public String ICCountInventoryResultItemBarCodeNo
        {
            get { return _iCCountInventoryResultItemBarCodeNo; }
            set
            {
                if (value != this._iCCountInventoryResultItemBarCodeNo)
                {
                    _iCCountInventoryResultItemBarCodeNo = value;
                }
            }
        }
        public String ICCountInventoryResultItemDesc
        {
            get { return _iCCountInventoryResultItemDesc; }
            set
            {
                if (value != this._iCCountInventoryResultItemDesc)
                {
                    _iCCountInventoryResultItemDesc = value;
                }
            }
        }
        public String ICCountInventoryResultItemSerialNo
        {
            get { return _iCCountInventoryResultItemSerialNo; }
            set
            {
                if (value != this._iCCountInventoryResultItemSerialNo)
                {
                    _iCCountInventoryResultItemSerialNo = value;
                }
            }
        }
        public String GLTOF01Combo
        {
            get { return _gLTOF01Combo; }
            set
            {
                if (value != this._gLTOF01Combo)
                {
                    _gLTOF01Combo = value;
                }
            }
        }
        public String GLTOF02Combo
        {
            get { return _gLTOF02Combo; }
            set
            {
                if (value != this._gLTOF02Combo)
                {
                    _gLTOF02Combo = value;
                }
            }
        }
        public String GLTOF03Combo
        {
            get { return _gLTOF03Combo; }
            set
            {
                if (value != this._gLTOF03Combo)
                {
                    _gLTOF03Combo = value;
                }
            }
        }
        public String GLTOF04Combo
        {
            get { return _gLTOF04Combo; }
            set
            {
                if (value != this._gLTOF04Combo)
                {
                    _gLTOF04Combo = value;
                }
            }
        }
        public String GLTOF05Combo
        {
            get { return _gLTOF05Combo; }
            set
            {
                if (value != this._gLTOF05Combo)
                {
                    _gLTOF05Combo = value;
                }
            }
        }
        public String GLTOF06Combo
        {
            get { return _gLTOF06Combo; }
            set
            {
                if (value != this._gLTOF06Combo)
                {
                    _gLTOF06Combo = value;
                }
            }
        }
        public String GLTOF07Combo
        {
            get { return _gLTOF07Combo; }
            set
            {
                if (value != this._gLTOF07Combo)
                {
                    _gLTOF07Combo = value;
                }
            }
        }
        public String GLTOF08Combo
        {
            get { return _gLTOF08Combo; }
            set
            {
                if (value != this._gLTOF08Combo)
                {
                    _gLTOF08Combo = value;
                }
            }
        }
        public String GLTOF09Combo
        {
            get { return _gLTOF09Combo; }
            set
            {
                if (value != this._gLTOF09Combo)
                {
                    _gLTOF09Combo = value;
                }
            }
        }
        public String GLTOF10Combo
        {
            get { return _gLTOF10Combo; }
            set
            {
                if (value != this._gLTOF10Combo)
                {
                    _gLTOF10Combo = value;
                }
            }
        }
        public String GLTOF11Combo
        {
            get { return _gLTOF11Combo; }
            set
            {
                if (value != this._gLTOF11Combo)
                {
                    _gLTOF11Combo = value;
                }
            }
        }
        public String GLTOF12Combo
        {
            get { return _gLTOF12Combo; }
            set
            {
                if (value != this._gLTOF12Combo)
                {
                    _gLTOF12Combo = value;
                }
            }
        }
        public String GLTOF13Combo
        {
            get { return _gLTOF13Combo; }
            set
            {
                if (value != this._gLTOF13Combo)
                {
                    _gLTOF13Combo = value;
                }
            }
        }
        public String GLTOF14Combo
        {
            get { return _gLTOF14Combo; }
            set
            {
                if (value != this._gLTOF14Combo)
                {
                    _gLTOF14Combo = value;
                }
            }
        }
        public String GLTOF15Combo
        {
            get { return _gLTOF15Combo; }
            set
            {
                if (value != this._gLTOF15Combo)
                {
                    _gLTOF15Combo = value;
                }
            }
        }
        public String GLTOF16Combo
        {
            get { return _gLTOF16Combo; }
            set
            {
                if (value != this._gLTOF16Combo)
                {
                    _gLTOF16Combo = value;
                }
            }
        }

        #endregion
    }
}