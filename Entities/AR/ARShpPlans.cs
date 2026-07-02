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
    [Table("ARShpPlans")]
    public class ARShpPlans : BaseInfo
    {
        public ARShpPlans()
        {
        }
        #region Variables
        protected int _aRShpPlanID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _aRShpPlanNo = String.Empty;
        protected String _aRShpPlanName = String.Empty;
        protected DateTime _aRShpPlanDate = DateTime.Now;
        protected String _aRShpPlanDesc = String.Empty;
        protected Nullable<DateTime> _aRShpPlanDueDate;
        protected int _aRShpPlanPeriod;
        protected int _aRShpPlanYear;
        protected String _aRShpPlanStatusCombo = DefaultStatus;
        protected int _fK_ARCustomerID;
        protected int _fK_ADUserID;
        protected decimal _aRShpPlanAmtTotal;
        protected decimal _aRShpPlanHTSAmtTotal;
        protected decimal _aRShpPlanATSAmtTotal;
        protected int _fK_HREmployeeID;
        protected int _fK_GLTranCfgID;

        #endregion
        [Key]
        #region Public properties
        public int ARShpPlanID
        {
            get { return _aRShpPlanID; }
            set
            {
                if (value != this._aRShpPlanID)
                {
                    _aRShpPlanID = value;
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
        public String ARShpPlanNo
        {
            get { return _aRShpPlanNo; }
            set
            {
                if (value != this._aRShpPlanNo)
                {
                    _aRShpPlanNo = value;
                }
            }
        }
        public String ARShpPlanName
        {
            get { return _aRShpPlanName; }
            set
            {
                if (value != this._aRShpPlanName)
                {
                    _aRShpPlanName = value;
                }
            }
        }
        public DateTime ARShpPlanDate
        {
            get { return _aRShpPlanDate; }
            set
            {
                if (value != this._aRShpPlanDate)
                {
                    _aRShpPlanDate = value;
                }
            }
        }
        public String ARShpPlanDesc
        {
            get { return _aRShpPlanDesc; }
            set
            {
                if (value != this._aRShpPlanDesc)
                {
                    _aRShpPlanDesc = value;
                }
            }
        }
        public Nullable<DateTime> ARShpPlanDueDate
        {
            get { return _aRShpPlanDueDate; }
            set
            {
                if (value != this._aRShpPlanDueDate)
                {
                    _aRShpPlanDueDate = value;
                }
            }
        }
        public int ARShpPlanPeriod
        {
            get { return _aRShpPlanPeriod; }
            set
            {
                if (value != this._aRShpPlanPeriod)
                {
                    _aRShpPlanPeriod = value;
                }
            }
        }
        public int ARShpPlanYear
        {
            get { return _aRShpPlanYear; }
            set
            {
                if (value != this._aRShpPlanYear)
                {
                    _aRShpPlanYear = value;
                }
            }
        }
        public String ARShpPlanStatusCombo
        {
            get { return _aRShpPlanStatusCombo; }
            set
            {
                if (value != this._aRShpPlanStatusCombo)
                {
                    _aRShpPlanStatusCombo = value;
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
        public int FK_ADUserID
        {
            get { return _fK_ADUserID; }
            set
            {
                if (value != this._fK_ADUserID)
                {
                    _fK_ADUserID = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanAmtTotal
        {
            get { return _aRShpPlanAmtTotal; }
            set
            {
                if (value != this._aRShpPlanAmtTotal)
                {
                    _aRShpPlanAmtTotal = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanHTSAmtTotal
        {
            get { return _aRShpPlanHTSAmtTotal; }
            set
            {
                if (value != this._aRShpPlanHTSAmtTotal)
                {
                    _aRShpPlanHTSAmtTotal = value;
                }
            }
        }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanATSAmtTotal
        {
            get { return _aRShpPlanATSAmtTotal; }
            set
            {
                if (value != this._aRShpPlanATSAmtTotal)
                {
                    _aRShpPlanATSAmtTotal = value;
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

        #endregion
    }
}
