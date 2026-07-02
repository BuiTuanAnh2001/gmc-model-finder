using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ARPriceLists")]
    public class ARPriceLists : BaseInfo
    {
        #region Variables
        protected int _aRPriceListID;
        protected String _aAStatus = "Alive";
        protected bool _aASelected = true;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected int _fK_GECurrencyID;
        protected int _fK_ARCustomerID;
        protected String _aRPriceListNo = String.Empty;
        protected String _aRPriceListName = String.Empty;
        protected String _aRPriceListDesc = String.Empty;
        protected String _aRPriceListInfo = String.Empty;
        protected Nullable<DateTime> _aRPriceListStartDate;
        protected Nullable<DateTime> _aRPriceListEndDate;
        protected String _aRPriceListOOF01Combo = String.Empty;
        protected String _aRPriceListOOF02Combo = String.Empty;
        protected String _aRPriceListOOF03Combo = String.Empty;
        protected String _aRPriceListOOF04Combo = String.Empty;
        protected String _aRPriceListOOF05Combo = String.Empty;
        protected String _aRPriceListOOF06Combo = String.Empty;
        protected String _aRPriceListOOF07Combo = String.Empty;
        protected String _aRPriceListOOF08Combo = String.Empty;
        protected String _aRPriceListOOF09Combo = String.Empty;
        protected String _aRPriceListOOF10Combo = String.Empty;
        protected bool _aRPriceListActiveCheck = true;
        protected decimal _aRPriceListDiscountPct;
        protected decimal _aRPriceListIncreasePct;
        protected String _aAOrgDocNo = String.Empty;
        protected String _aRPriceListTypeCombo = String.Empty;
        protected int _fK_ARCustomerGroupID;
        protected String _approvalStatusCombo = DefaultStatus;
        protected DateTime _aRPriceListDate = DateTime.Now;
        protected int _fK_GLTranCfgID;
        protected int _fK_ADApprovalProcID;
        protected String _aRPriceListObjectSQL = String.Empty;

        #endregion
        #region Public properties
        [Key]
        public int ARPriceListID
        {
            get { return _aRPriceListID; }
            set
            {
                if (value != this._aRPriceListID)
                {
                    _aRPriceListID = value;
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
        public int FK_GECurrencyID
        {
            get { return _fK_GECurrencyID; }
            set
            {
                if (value != this._fK_GECurrencyID)
                {
                    _fK_GECurrencyID = value;
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
        public String ARPriceListNo
        {
            get { return _aRPriceListNo; }
            set
            {
                if (value != this._aRPriceListNo)
                {
                    _aRPriceListNo = value;
                }
            }
        }
        public String ARPriceListName
        {
            get { return _aRPriceListName; }
            set
            {
                if (value != this._aRPriceListName)
                {
                    _aRPriceListName = value;
                }
            }
        }
        public String ARPriceListDesc
        {
            get { return _aRPriceListDesc; }
            set
            {
                if (value != this._aRPriceListDesc)
                {
                    _aRPriceListDesc = value;
                }
            }
        }
        public String ARPriceListInfo
        {
            get { return _aRPriceListInfo; }
            set
            {
                if (value != this._aRPriceListInfo)
                {
                    _aRPriceListInfo = value;
                }
            }
        }
        public Nullable<DateTime> ARPriceListStartDate
        {
            get { return _aRPriceListStartDate; }
            set
            {
                if (value != this._aRPriceListStartDate)
                {
                    _aRPriceListStartDate = value;
                }
            }
        }
        public Nullable<DateTime> ARPriceListEndDate
        {
            get { return _aRPriceListEndDate; }
            set
            {
                if (value != this._aRPriceListEndDate)
                {
                    _aRPriceListEndDate = value;
                }
            }
        }
        public String ARPriceListOOF01Combo
        {
            get { return _aRPriceListOOF01Combo; }
            set
            {
                if (value != this._aRPriceListOOF01Combo)
                {
                    _aRPriceListOOF01Combo = value;
                }
            }
        }
        public String ARPriceListOOF02Combo
        {
            get { return _aRPriceListOOF02Combo; }
            set
            {
                if (value != this._aRPriceListOOF02Combo)
                {
                    _aRPriceListOOF02Combo = value;
                }
            }
        }
        public String ARPriceListOOF03Combo
        {
            get { return _aRPriceListOOF03Combo; }
            set
            {
                if (value != this._aRPriceListOOF03Combo)
                {
                    _aRPriceListOOF03Combo = value;
                }
            }
        }
        public String ARPriceListOOF04Combo
        {
            get { return _aRPriceListOOF04Combo; }
            set
            {
                if (value != this._aRPriceListOOF04Combo)
                {
                    _aRPriceListOOF04Combo = value;
                }
            }
        }
        public String ARPriceListOOF05Combo
        {
            get { return _aRPriceListOOF05Combo; }
            set
            {
                if (value != this._aRPriceListOOF05Combo)
                {
                    _aRPriceListOOF05Combo = value;
                }
            }
        }
        public String ARPriceListOOF06Combo
        {
            get { return _aRPriceListOOF06Combo; }
            set
            {
                if (value != this._aRPriceListOOF06Combo)
                {
                    _aRPriceListOOF06Combo = value;
                }
            }
        }
        public String ARPriceListOOF07Combo
        {
            get { return _aRPriceListOOF07Combo; }
            set
            {
                if (value != this._aRPriceListOOF07Combo)
                {
                    _aRPriceListOOF07Combo = value;
                }
            }
        }
        public String ARPriceListOOF08Combo
        {
            get { return _aRPriceListOOF08Combo; }
            set
            {
                if (value != this._aRPriceListOOF08Combo)
                {
                    _aRPriceListOOF08Combo = value;
                }
            }
        }
        public String ARPriceListOOF09Combo
        {
            get { return _aRPriceListOOF09Combo; }
            set
            {
                if (value != this._aRPriceListOOF09Combo)
                {
                    _aRPriceListOOF09Combo = value;
                }
            }
        }
        public String ARPriceListOOF10Combo
        {
            get { return _aRPriceListOOF10Combo; }
            set
            {
                if (value != this._aRPriceListOOF10Combo)
                {
                    _aRPriceListOOF10Combo = value;
                }
            }
        }
        public bool ARPriceListActiveCheck
        {
            get { return _aRPriceListActiveCheck; }
            set
            {
                if (value != this._aRPriceListActiveCheck)
                {
                    _aRPriceListActiveCheck = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ARPriceListDiscountPct
        {
            get { return _aRPriceListDiscountPct; }
            set
            {
                if (value != this._aRPriceListDiscountPct)
                {
                    _aRPriceListDiscountPct = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")]
        public decimal ARPriceListIncreasePct
        {
            get { return _aRPriceListIncreasePct; }
            set
            {
                if (value != this._aRPriceListIncreasePct)
                {
                    _aRPriceListIncreasePct = value;
                }
            }
        }
        public String AAOrgDocNo
        {
            get { return _aAOrgDocNo; }
            set
            {
                if (value != this._aAOrgDocNo)
                {
                    _aAOrgDocNo = value;
                }
            }
        }
        public String ARPriceListTypeCombo
        {
            get { return _aRPriceListTypeCombo; }
            set
            {
                if (value != this._aRPriceListTypeCombo)
                {
                    _aRPriceListTypeCombo = value;
                }
            }
        }
        public int FK_ARCustomerGroupID
        {
            get { return _fK_ARCustomerGroupID; }
            set
            {
                if (value != this._fK_ARCustomerGroupID)
                {
                    _fK_ARCustomerGroupID = value;
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
        public DateTime ARPriceListDate
        {
            get { return _aRPriceListDate; }
            set
            {
                if (value != this._aRPriceListDate)
                {
                    _aRPriceListDate = value;
                }
            }
        }
        public int FK_GLTranCfgID
        {
            get { return _fK_GLTranCfgID; }
            set
            {
                if (value != this._fK_GLTranCfgID)
                {
                    _fK_GLTranCfgID = value;
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
        public String ARPriceListObjectSQL
        {
            get { return _aRPriceListObjectSQL; }
            set
            {
                if (value != this._aRPriceListObjectSQL)
                {
                    _aRPriceListObjectSQL = value;
                }
            }
        }

        #endregion
    }
}
