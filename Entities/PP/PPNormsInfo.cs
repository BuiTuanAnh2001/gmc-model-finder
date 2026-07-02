using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("PPNorms")]
    public class PPNormsInfo : BaseInfo
    {
        #region Variables
        protected int _pPNormID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _pPNormNo = String.Empty;
        protected String _pPNormName = String.Empty;
        protected String _pPNormDesc = String.Empty;
        protected Nullable<DateTime> _pPNormDate;
        protected int _fK_ICProductID;
        protected int _fK_ICStockID;
        protected int _fK_ARCustomerID;
        protected decimal _pPNormEstRMCost;
        protected decimal _pPNormEstLabourCost;
        protected decimal _pPNormEstOverheadCost;
        protected decimal _pPNormEstCost;
        protected String _approvalStatusCombo = DefaultStatus;
        protected String _pPNormRevision = String.Empty;
        protected int _pPNormAllocatePct;
        protected bool _aASelected = true;
        protected bool _pPNormActiveCheck = true;
        protected bool _pPNormIsOutSource = false;
        protected int _fK_BRBranchID;
        protected decimal _pPNormQty;
        protected String _aAModule = String.Empty;
        protected int _fK_ICStkUOMID;
        protected int _fK_ADApprovalProcID;
        protected int _fK_PPRoutingID;

        #endregion
        #region Public properties
        [Key]
        public int PPNormID
        {
            get { return _pPNormID; }
            set
            {
                if (value != this._pPNormID)
                {
                    _pPNormID = value;
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
        public String PPNormNo
        {
            get { return _pPNormNo; }
            set
            {
                if (value != this._pPNormNo)
                {
                    _pPNormNo = value;
                }
            }
        }
        public String PPNormName
        {
            get { return _pPNormName; }
            set
            {
                if (value != this._pPNormName)
                {
                    _pPNormName = value;
                }
            }
        }
        public String PPNormDesc
        {
            get { return _pPNormDesc; }
            set
            {
                if (value != this._pPNormDesc)
                {
                    _pPNormDesc = value;
                }
            }
        }
        public Nullable<DateTime> PPNormDate
        {
            get { return _pPNormDate; }
            set
            {
                if (value != this._pPNormDate)
                {
                    _pPNormDate = value;
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
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPNormEstRMCost
        {
            get { return _pPNormEstRMCost; }
            set
            {
                if (value != this._pPNormEstRMCost)
                {
                    _pPNormEstRMCost = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPNormEstLabourCost
        {
            get { return _pPNormEstLabourCost; }
            set
            {
                if (value != this._pPNormEstLabourCost)
                {
                    _pPNormEstLabourCost = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPNormEstOverheadCost
        {
            get { return _pPNormEstOverheadCost; }
            set
            {
                if (value != this._pPNormEstOverheadCost)
                {
                    _pPNormEstOverheadCost = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPNormEstCost
        {
            get { return _pPNormEstCost; }
            set
            {
                if (value != this._pPNormEstCost)
                {
                    _pPNormEstCost = value;
                }
            }
        }
        public String ApprovalStatusCombo
        {
            get { return _approvalStatusCombo; }
            set
            {
                if (value != this._approvalStatusCombo)
                {
                    _approvalStatusCombo = value;
                }
            }
        }
        public String PPNormRevision
        {
            get { return _pPNormRevision; }
            set
            {
                if (value != this._pPNormRevision)
                {
                    _pPNormRevision = value;
                }
            }
        }
        public int PPNormAllocatePct
        {
            get { return _pPNormAllocatePct; }
            set
            {
                if (value != this._pPNormAllocatePct)
                {
                    _pPNormAllocatePct = value;
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
        public bool PPNormActiveCheck
        {
            get { return _pPNormActiveCheck; }
            set
            {
                if (value != this._pPNormActiveCheck)
                {
                    _pPNormActiveCheck = value;
                }
            }
        }
        public bool PPNormIsOutSource
        {
            get { return _pPNormIsOutSource; }
            set
            {
                if (value != this._pPNormIsOutSource)
                {
                    _pPNormIsOutSource = value;
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
        [Column(TypeName = "decimal(19, 6)")]
        public decimal PPNormQty
        {
            get { return _pPNormQty; }
            set
            {
                if (value != this._pPNormQty)
                {
                    _pPNormQty = value;
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
        public int FK_ADApprovalProcID
        {
            get { return _fK_ADApprovalProcID; }
            set
            {
                if (value != this._fK_ADApprovalProcID)
                {
                    _fK_ADApprovalProcID = value;
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

        #endregion
    }

}