using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace gmc_api.Entities
{
    #region ViewInvQuerys
    // [Table("ViewInvQuerys")]
    public class ViewInvQuerysInfo : BaseInfo
    {
        #region Variables
        protected int _viewInvQueryID;
        protected bool _aASelected = true;
        protected String _viewInvQueryMasterNo = String.Empty;
        protected Nullable<DateTime> _viewInvQueryMasterDate;
        protected String _viewInvQueryMasterModule = String.Empty;
        protected int _fK_ICProductID;
        protected int _fK_ICStockID;
        protected String _viewInvQueryDesc = String.Empty;
        protected decimal _viewInvQueryUnitPrice;
        protected decimal _viewInvQueryUnitCost;
        protected decimal _viewInvQueryQty;
        protected decimal _viewInvQueryStkQty;
        protected decimal _viewInvQueryRQty;
        protected decimal _viewInvQueryRStkQty;
        protected decimal _viewInvQueryPrice;
        protected decimal _viewInvQueryNetAmt;
        protected decimal _viewInvQueryAmtTot;
        protected decimal _viewInvQueryCostTot;
        protected decimal _viewInvQueryAmt;
        protected decimal _viewInvQueryCAmt;
        protected decimal _viewInvQueryShpAmt;
        protected int _fK_PPPhaseCfgID;
        protected int _fK_ICProductFGID;
        protected decimal _viewInvQueryFUnitPrice;
        protected decimal _viewInvQueryFPrice;
        protected decimal _viewInvQueryFNetAmt;
        protected decimal _viewInvQueryFAmtTot;
        protected int _fK_GLDebitAccountID;
        protected int _fK_GLCreditAccountID;
        protected int _fK_GLDebitVATAccountID;
        protected int _fK_GLCreditVATAccountID;
        protected String _viewInvQueryLotNo = String.Empty;
        protected decimal _viewInvQueryFreightAmt;
        protected decimal _viewInvQueryAllocateQty;
        protected decimal _viewInvQueryPOQty;
        protected int _fK_PPRoutingID;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected decimal _viewInvQueryCQty;
        protected int _fK_PPCostCenterID;
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
        protected int _fK_APPOItemID;
        protected int _fK_APSupplierID;
        protected decimal _viewInvQueryAdjStkQty;
        protected decimal _viewInvQueryNetAmtTot;
        protected decimal _viewInvQueryFNetAmtTot;
        protected int _fK_GLBudgetCfgID;
        protected int _fK_GLBudgetAllocateAdjID;
        protected int _fK_GLBudgetAllocateAdjDetailID;
        protected decimal _viewInvQueryDiscAmtTot;
        protected decimal _viewInvQueryFDiscAmtTot;
        protected decimal _viewInvQueryFDiscAmt;
        protected String _viewInvQueryFGLotNo = String.Empty;
        protected bool _viewInvQueryIsIdentifyCost = false;
        protected bool _viewInvQueryIsAVGCost = false;
        protected int _fK_ARCustomerID;
        protected String _aAPostStatus = DefaultStatus;
        protected String _viewInvQueryItemDesc = String.Empty;
        protected String _viewInvQueryType = String.Empty;
        protected String _viewInvQueryPOF01Combo = String.Empty;
        protected String _viewInvQueryPOF02Combo = String.Empty;
        protected String _viewInvQueryPOF03Combo = String.Empty;
        protected String _viewInvQueryPOF04Combo = String.Empty;
        protected String _viewInvQueryPOF05Combo = String.Empty;

        #endregion
        #region Public properties
        //   [Key]
        public int ViewInvQueryID
        {
            get { return _viewInvQueryID; }
            set
            {
                if (value != this._viewInvQueryID)
                {
                    _viewInvQueryID = value;
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
        public String ViewInvQueryMasterNo
        {
            get { return _viewInvQueryMasterNo; }
            set
            {
                if (value != this._viewInvQueryMasterNo)
                {
                    _viewInvQueryMasterNo = value;
                }
            }
        }
        public Nullable<DateTime> ViewInvQueryMasterDate
        {
            get { return _viewInvQueryMasterDate; }
            set
            {
                if (value != this._viewInvQueryMasterDate)
                {
                    _viewInvQueryMasterDate = value;
                }
            }
        }
        public String ViewInvQueryMasterModule
        {
            get { return _viewInvQueryMasterModule; }
            set
            {
                if (value != this._viewInvQueryMasterModule)
                {
                    _viewInvQueryMasterModule = value;
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
        public String ViewInvQueryDesc
        {
            get { return _viewInvQueryDesc; }
            set
            {
                if (value != this._viewInvQueryDesc)
                {
                    _viewInvQueryDesc = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryUnitPrice
        {
            get { return _viewInvQueryUnitPrice; }
            set
            {
                if (value != this._viewInvQueryUnitPrice)
                {
                    _viewInvQueryUnitPrice = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryUnitCost
        {
            get { return _viewInvQueryUnitCost; }
            set
            {
                if (value != this._viewInvQueryUnitCost)
                {
                    _viewInvQueryUnitCost = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryQty
        {
            get { return _viewInvQueryQty; }
            set
            {
                if (value != this._viewInvQueryQty)
                {
                    _viewInvQueryQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryStkQty
        {
            get { return _viewInvQueryStkQty; }
            set
            {
                if (value != this._viewInvQueryStkQty)
                {
                    _viewInvQueryStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryRQty
        {
            get { return _viewInvQueryRQty; }
            set
            {
                if (value != this._viewInvQueryRQty)
                {
                    _viewInvQueryRQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryRStkQty
        {
            get { return _viewInvQueryRStkQty; }
            set
            {
                if (value != this._viewInvQueryRStkQty)
                {
                    _viewInvQueryRStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryPrice
        {
            get { return _viewInvQueryPrice; }
            set
            {
                if (value != this._viewInvQueryPrice)
                {
                    _viewInvQueryPrice = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryNetAmt
        {
            get { return _viewInvQueryNetAmt; }
            set
            {
                if (value != this._viewInvQueryNetAmt)
                {
                    _viewInvQueryNetAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryAmtTot
        {
            get { return _viewInvQueryAmtTot; }
            set
            {
                if (value != this._viewInvQueryAmtTot)
                {
                    _viewInvQueryAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryCostTot
        {
            get { return _viewInvQueryCostTot; }
            set
            {
                if (value != this._viewInvQueryCostTot)
                {
                    _viewInvQueryCostTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryAmt
        {
            get { return _viewInvQueryAmt; }
            set
            {
                if (value != this._viewInvQueryAmt)
                {
                    _viewInvQueryAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryCAmt
        {
            get { return _viewInvQueryCAmt; }
            set
            {
                if (value != this._viewInvQueryCAmt)
                {
                    _viewInvQueryCAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryShpAmt
        {
            get { return _viewInvQueryShpAmt; }
            set
            {
                if (value != this._viewInvQueryShpAmt)
                {
                    _viewInvQueryShpAmt = value;
                }
            }
        }
        public int FK_PPPhaseCfgID
        {
            get { return _fK_PPPhaseCfgID; }
            set
            {
                if (value != this._fK_PPPhaseCfgID)
                {
                    _fK_PPPhaseCfgID = value;
                }
            }
        }
        public int FK_ICProductFGID
        {
            get { return _fK_ICProductFGID; }
            set
            {
                if (value != this._fK_ICProductFGID)
                {
                    _fK_ICProductFGID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryFUnitPrice
        {
            get { return _viewInvQueryFUnitPrice; }
            set
            {
                if (value != this._viewInvQueryFUnitPrice)
                {
                    _viewInvQueryFUnitPrice = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryFPrice
        {
            get { return _viewInvQueryFPrice; }
            set
            {
                if (value != this._viewInvQueryFPrice)
                {
                    _viewInvQueryFPrice = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryFNetAmt
        {
            get { return _viewInvQueryFNetAmt; }
            set
            {
                if (value != this._viewInvQueryFNetAmt)
                {
                    _viewInvQueryFNetAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryFAmtTot
        {
            get { return _viewInvQueryFAmtTot; }
            set
            {
                if (value != this._viewInvQueryFAmtTot)
                {
                    _viewInvQueryFAmtTot = value;
                }
            }
        }
        public int FK_GLDebitAccountID
        {
            get { return _fK_GLDebitAccountID; }
            set
            {
                if (value != this._fK_GLDebitAccountID)
                {
                    _fK_GLDebitAccountID = value;
                }
            }
        }
        public int FK_GLCreditAccountID
        {
            get { return _fK_GLCreditAccountID; }
            set
            {
                if (value != this._fK_GLCreditAccountID)
                {
                    _fK_GLCreditAccountID = value;
                }
            }
        }
        public int FK_GLDebitVATAccountID
        {
            get { return _fK_GLDebitVATAccountID; }
            set
            {
                if (value != this._fK_GLDebitVATAccountID)
                {
                    _fK_GLDebitVATAccountID = value;
                }
            }
        }
        public int FK_GLCreditVATAccountID
        {
            get { return _fK_GLCreditVATAccountID; }
            set
            {
                if (value != this._fK_GLCreditVATAccountID)
                {
                    _fK_GLCreditVATAccountID = value;
                }
            }
        }
        public String ViewInvQueryLotNo
        {
            get { return _viewInvQueryLotNo; }
            set
            {
                if (value != this._viewInvQueryLotNo)
                {
                    _viewInvQueryLotNo = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryFreightAmt
        {
            get { return _viewInvQueryFreightAmt; }
            set
            {
                if (value != this._viewInvQueryFreightAmt)
                {
                    _viewInvQueryFreightAmt = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryAllocateQty
        {
            get { return _viewInvQueryAllocateQty; }
            set
            {
                if (value != this._viewInvQueryAllocateQty)
                {
                    _viewInvQueryAllocateQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryPOQty
        {
            get { return _viewInvQueryPOQty; }
            set
            {
                if (value != this._viewInvQueryPOQty)
                {
                    _viewInvQueryPOQty = value;
                }
            }
        }
        public int FK_PPRoutingID
        {
            get { return _fK_PPRoutingID; }
            set
            {
                if (value != this._fK_PPRoutingID)
                {
                    _fK_PPRoutingID = value;
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
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryCQty
        {
            get { return _viewInvQueryCQty; }
            set
            {
                if (value != this._viewInvQueryCQty)
                {
                    _viewInvQueryCQty = value;
                }
            }
        }
        public int FK_PPCostCenterID
        {
            get { return _fK_PPCostCenterID; }
            set
            {
                if (value != this._fK_PPCostCenterID)
                {
                    _fK_PPCostCenterID = value;
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
        public int FK_APPOItemID
        {
            get { return _fK_APPOItemID; }
            set
            {
                if (value != this._fK_APPOItemID)
                {
                    _fK_APPOItemID = value;
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
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryAdjStkQty
        {
            get { return _viewInvQueryAdjStkQty; }
            set
            {
                if (value != this._viewInvQueryAdjStkQty)
                {
                    _viewInvQueryAdjStkQty = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryNetAmtTot
        {
            get { return _viewInvQueryNetAmtTot; }
            set
            {
                if (value != this._viewInvQueryNetAmtTot)
                {
                    _viewInvQueryNetAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryFNetAmtTot
        {
            get { return _viewInvQueryFNetAmtTot; }
            set
            {
                if (value != this._viewInvQueryFNetAmtTot)
                {
                    _viewInvQueryFNetAmtTot = value;
                }
            }
        }
        public int FK_GLBudgetCfgID
        {
            get { return _fK_GLBudgetCfgID; }
            set
            {
                if (value != this._fK_GLBudgetCfgID)
                {
                    _fK_GLBudgetCfgID = value;
                }
            }
        }
        public int FK_GLBudgetAllocateAdjID
        {
            get { return _fK_GLBudgetAllocateAdjID; }
            set
            {
                if (value != this._fK_GLBudgetAllocateAdjID)
                {
                    _fK_GLBudgetAllocateAdjID = value;
                }
            }
        }
        public int FK_GLBudgetAllocateAdjDetailID
        {
            get { return _fK_GLBudgetAllocateAdjDetailID; }
            set
            {
                if (value != this._fK_GLBudgetAllocateAdjDetailID)
                {
                    _fK_GLBudgetAllocateAdjDetailID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryDiscAmtTot
        {
            get { return _viewInvQueryDiscAmtTot; }
            set
            {
                if (value != this._viewInvQueryDiscAmtTot)
                {
                    _viewInvQueryDiscAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryFDiscAmtTot
        {
            get { return _viewInvQueryFDiscAmtTot; }
            set
            {
                if (value != this._viewInvQueryFDiscAmtTot)
                {
                    _viewInvQueryFDiscAmtTot = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ViewInvQueryFDiscAmt
        {
            get { return _viewInvQueryFDiscAmt; }
            set
            {
                if (value != this._viewInvQueryFDiscAmt)
                {
                    _viewInvQueryFDiscAmt = value;
                }
            }
        }
        public String ViewInvQueryFGLotNo
        {
            get { return _viewInvQueryFGLotNo; }
            set
            {
                if (value != this._viewInvQueryFGLotNo)
                {
                    _viewInvQueryFGLotNo = value;
                }
            }
        }
        public bool ViewInvQueryIsIdentifyCost
        {
            get { return _viewInvQueryIsIdentifyCost; }
            set
            {
                if (value != this._viewInvQueryIsIdentifyCost)
                {
                    _viewInvQueryIsIdentifyCost = value;
                }
            }
        }
        public bool ViewInvQueryIsAVGCost
        {
            get { return _viewInvQueryIsAVGCost; }
            set
            {
                if (value != this._viewInvQueryIsAVGCost)
                {
                    _viewInvQueryIsAVGCost = value;
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
        public String AAPostStatus
        {
            get { return _aAPostStatus; }
            set
            {
                if (value != this._aAPostStatus)
                {
                    _aAPostStatus = value;
                }
            }
        }
        public String ViewInvQueryItemDesc
        {
            get { return _viewInvQueryItemDesc; }
            set
            {
                if (value != this._viewInvQueryItemDesc)
                {
                    _viewInvQueryItemDesc = value;
                }
            }
        }
        public String ViewInvQueryType
        {
            get { return _viewInvQueryType; }
            set
            {
                if (value != this._viewInvQueryType)
                {
                    _viewInvQueryType = value;
                }
            }
        }
        public String ViewInvQueryPOF01Combo
        {
            get { return _viewInvQueryPOF01Combo; }
            set
            {
                if (value != this._viewInvQueryPOF01Combo)
                {
                    _viewInvQueryPOF01Combo = value;
                }
            }
        }
        public String ViewInvQueryPOF02Combo
        {
            get { return _viewInvQueryPOF02Combo; }
            set
            {
                if (value != this._viewInvQueryPOF02Combo)
                {
                    _viewInvQueryPOF02Combo = value;
                }
            }
        }
        public String ViewInvQueryPOF03Combo
        {
            get { return _viewInvQueryPOF03Combo; }
            set
            {
                if (value != this._viewInvQueryPOF03Combo)
                {
                    _viewInvQueryPOF03Combo = value;
                }
            }
        }
        public String ViewInvQueryPOF04Combo
        {
            get { return _viewInvQueryPOF04Combo; }
            set
            {
                if (value != this._viewInvQueryPOF04Combo)
                {
                    _viewInvQueryPOF04Combo = value;
                }
            }
        }
        public String ViewInvQueryPOF05Combo
        {
            get { return _viewInvQueryPOF05Combo; }
            set
            {
                if (value != this._viewInvQueryPOF05Combo)
                {
                    _viewInvQueryPOF05Combo = value;
                }
            }
        }
        #endregion
        public int FK_BRBranchID { get; set; }
        public string ViewInvQuerySerialNo { get; set; }
    }
    #endregion
}