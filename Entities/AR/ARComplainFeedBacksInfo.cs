using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ARComplainFeedBacks")]
    public class ARComplainFeedBacksInfo : BaseInfo
    {
        #region Variables
        protected int _aRComplainFeedBackID;
        protected String _aRComplainFeedBackNo = String.Empty;
        protected String _aRComplainFeedBackName = String.Empty;
        protected Nullable<DateTime> _aRComplainFeedBackDate;
        protected String _aRComplainFeedBackDesc = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAModule = String.Empty;
        protected int _fK_ARCustomerID;
        protected int _fK_ARSOID;
        protected int _fK_HRSectionID;
        protected int _fK_HREmployeeID;
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
        protected String _aRComplainFeedBackTypeCombo = String.Empty;
        protected int _fK_ICProductID;
        protected int _fK_ICShipmentID;
        protected int _fK_ICShipmentItemID;
        protected decimal _aRComplainFeedBackQty;
        protected decimal _aRComplainFeedBackDrawingQty;
        protected decimal _aRComplainFeedBackRatioQty;
        protected decimal _aRComplainFeedBackStkQty;
        protected decimal _aRComplainFeedBackFact;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected bool _aASelected = true;
        protected decimal _aRComplainFeedBackRQty;
        protected decimal _aRComplainFeedBackExcQty;
        protected int _fK_ARComplainID;
        protected String _aRComplainSectionList = String.Empty;
        protected Nullable<DateTime> _aRComplainFeedBackConsumersBuyDate;
        protected Nullable<DateTime> _aRComplainFeedBackConsumersComplainDate;
        protected int _fK_BRBranchID;
        protected int _fK_APPOID;
        protected int _fK_APSupplierID;
        protected int _fK_ICReceiptID;
        protected int _fK_ICReceiptItemID;
        protected Nullable<DateTime> _aRComplainFeedBackCloseDate;
        protected Nullable<DateTime> _aRComplainFeedBackCloseCustomerDate;
        protected bool _aRComplainFeedBackCloseCheck = false;

        #endregion
        #region Public properties
        [Key]
        public int ARComplainFeedBackID
        {
            get { return _aRComplainFeedBackID; }
            set
            {
                if (value != this._aRComplainFeedBackID)
                {
                    _aRComplainFeedBackID = value;
                }
            }
        }
        public String ARComplainFeedBackNo
        {
            get { return _aRComplainFeedBackNo; }
            set
            {
                if (value != this._aRComplainFeedBackNo)
                {
                    _aRComplainFeedBackNo = value;
                }
            }
        }
        public String ARComplainFeedBackName
        {
            get { return _aRComplainFeedBackName; }
            set
            {
                if (value != this._aRComplainFeedBackName)
                {
                    _aRComplainFeedBackName = value;
                }
            }
        }
        public Nullable<DateTime> ARComplainFeedBackDate
        {
            get { return _aRComplainFeedBackDate; }
            set
            {
                if (value != this._aRComplainFeedBackDate)
                {
                    _aRComplainFeedBackDate = value;
                }
            }
        }
        public String ARComplainFeedBackDesc
        {
            get { return _aRComplainFeedBackDesc; }
            set
            {
                if (value != this._aRComplainFeedBackDesc)
                {
                    _aRComplainFeedBackDesc = value;
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
        public int FK_ARCustomerID
        {
            get { return _fK_ARCustomerID; }
            set
            {
                if (value != this._fK_ARCustomerID)
                {
                    _fK_ARCustomerID = value;
                }
            }
        }
        public int FK_ARSOID
        {
            get { return _fK_ARSOID; }
            set
            {
                if (value != this._fK_ARSOID)
                {
                    _fK_ARSOID = value;
                }
            }
        }
        public int FK_HRSectionID
        {
            get { return _fK_HRSectionID; }
            set
            {
                if (value != this._fK_HRSectionID)
                {
                    _fK_HRSectionID = value;
                }
            }
        }
        public int FK_HREmployeeID
        {
            get { return _fK_HREmployeeID; }
            set
            {
                if (value != this._fK_HREmployeeID)
                {
                    _fK_HREmployeeID = value;
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
        public String ARComplainFeedBackTypeCombo
        {
            get { return _aRComplainFeedBackTypeCombo; }
            set
            {
                if (value != this._aRComplainFeedBackTypeCombo)
                {
                    _aRComplainFeedBackTypeCombo = value;
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
        public int FK_ICShipmentID
        {
            get { return _fK_ICShipmentID; }
            set
            {
                if (value != this._fK_ICShipmentID)
                {
                    _fK_ICShipmentID = value;
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
        [Column(TypeName = "decimal(18, 5)")]
        public decimal ARComplainFeedBackQty
        {
            get { return _aRComplainFeedBackQty; }
            set
            {
                if (value != this._aRComplainFeedBackQty)
                {
                    _aRComplainFeedBackQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal ARComplainFeedBackDrawingQty
        {
            get { return _aRComplainFeedBackDrawingQty; }
            set
            {
                if (value != this._aRComplainFeedBackDrawingQty)
                {
                    _aRComplainFeedBackDrawingQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal ARComplainFeedBackRatioQty
        {
            get { return _aRComplainFeedBackRatioQty; }
            set
            {
                if (value != this._aRComplainFeedBackRatioQty)
                {
                    _aRComplainFeedBackRatioQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal ARComplainFeedBackStkQty
        {
            get { return _aRComplainFeedBackStkQty; }
            set
            {
                if (value != this._aRComplainFeedBackStkQty)
                {
                    _aRComplainFeedBackStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal ARComplainFeedBackFact
        {
            get { return _aRComplainFeedBackFact; }
            set
            {
                if (value != this._aRComplainFeedBackFact)
                {
                    _aRComplainFeedBackFact = value;
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
        [Column(TypeName = "decimal(18, 5)")]
        public decimal ARComplainFeedBackRQty
        {
            get { return _aRComplainFeedBackRQty; }
            set
            {
                if (value != this._aRComplainFeedBackRQty)
                {
                    _aRComplainFeedBackRQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal ARComplainFeedBackExcQty
        {
            get { return _aRComplainFeedBackExcQty; }
            set
            {
                if (value != this._aRComplainFeedBackExcQty)
                {
                    _aRComplainFeedBackExcQty = value;
                }
            }
        }
        public int FK_ARComplainID
        {
            get { return _fK_ARComplainID; }
            set
            {
                if (value != this._fK_ARComplainID)
                {
                    _fK_ARComplainID = value;
                }
            }
        }
        public String ARComplainSectionList
        {
            get { return _aRComplainSectionList; }
            set
            {
                if (value != this._aRComplainSectionList)
                {
                    _aRComplainSectionList = value;
                }
            }
        }
        public Nullable<DateTime> ARComplainFeedBackConsumersBuyDate
        {
            get { return _aRComplainFeedBackConsumersBuyDate; }
            set
            {
                if (value != this._aRComplainFeedBackConsumersBuyDate)
                {
                    _aRComplainFeedBackConsumersBuyDate = value;
                }
            }
        }
        public Nullable<DateTime> ARComplainFeedBackConsumersComplainDate
        {
            get { return _aRComplainFeedBackConsumersComplainDate; }
            set
            {
                if (value != this._aRComplainFeedBackConsumersComplainDate)
                {
                    _aRComplainFeedBackConsumersComplainDate = value;
                }
            }
        }
        public int FK_BRBranchID
        {
            get { return _fK_BRBranchID; }
            set
            {
                if (value != this._fK_BRBranchID)
                {
                    _fK_BRBranchID = value;
                }
            }
        }
        public int FK_APPOID
        {
            get { return _fK_APPOID; }
            set
            {
                if (value != this._fK_APPOID)
                {
                    _fK_APPOID = value;
                }
            }
        }
        public int FK_APSupplierID
        {
            get { return _fK_APSupplierID; }
            set
            {
                if (value != this._fK_APSupplierID)
                {
                    _fK_APSupplierID = value;
                }
            }
        }
        public int FK_ICReceiptID
        {
            get { return _fK_ICReceiptID; }
            set
            {
                if (value != this._fK_ICReceiptID)
                {
                    _fK_ICReceiptID = value;
                }
            }
        }
        public int FK_ICReceiptItemID
        {
            get { return _fK_ICReceiptItemID; }
            set
            {
                if (value != this._fK_ICReceiptItemID)
                {
                    _fK_ICReceiptItemID = value;
                }
            }
        }
        public Nullable<DateTime> ARComplainFeedBackCloseDate
        {
            get { return _aRComplainFeedBackCloseDate; }
            set
            {
                if (value != this._aRComplainFeedBackCloseDate)
                {
                    _aRComplainFeedBackCloseDate = value;
                }
            }
        }
        public Nullable<DateTime> ARComplainFeedBackCloseCustomerDate
        {
            get { return _aRComplainFeedBackCloseCustomerDate; }
            set
            {
                if (value != this._aRComplainFeedBackCloseCustomerDate)
                {
                    _aRComplainFeedBackCloseCustomerDate = value;
                }
            }
        }
        public bool ARComplainFeedBackCloseCheck
        {
            get { return _aRComplainFeedBackCloseCheck; }
            set
            {
                if (value != this._aRComplainFeedBackCloseCheck)
                {
                    _aRComplainFeedBackCloseCheck = value;
                }
            }
        }

        #endregion

    }
}