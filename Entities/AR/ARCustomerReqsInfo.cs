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
    [Table("ARCustomerReqs")]
    public class ARCustomerReqsInfo : BaseInfo
    {
        public ARCustomerReqsInfo()
        {
        }
        #region Variables
        protected int _aRCustomerReqID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _aRCustomerReqNo = String.Empty;
        protected String _aRCustomerReqName = String.Empty;
        protected DateTime _aRCustomerReqDate = DateTime.Now;
        protected String _aRCustomerReqDesc = String.Empty;
        protected String _aRCustomerReqStatusCombo = DefaultStatus;
        protected int _fK_ICProductModelID;
        protected String _aRCustomerReqProductName = String.Empty;
        protected String _aRCustomerReqFillBy = String.Empty;
        protected int _fK_ARCustomerID;
        protected int _fK_ICProductTypeID;
        protected String _aRCustomerReqTypeCombo = String.Empty;
        protected String _aAModule = String.Empty;
        protected int _fK_HREmployeeID;
        protected Nullable<DateTime> _aRCustomerReqShpDate;
        protected Nullable<DateTime> _aRCustomerReqExpireDate;
        protected int _fK_GLTranCfgID;
        protected String _approvalStatusCombo = DefaultStatus;
        protected int _fK_ADApprovalProcID;

        #endregion
        [Key]
        #region Public properties
        public int ARCustomerReqID
        {
            get { return _aRCustomerReqID; }
            set
            {
                if (value != this._aRCustomerReqID)
                {
                    _aRCustomerReqID = value;
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
        public String ARCustomerReqNo
        {
            get { return _aRCustomerReqNo; }
            set
            {
                if (value != this._aRCustomerReqNo)
                {
                    _aRCustomerReqNo = value;
                }
            }
        }
        public String ARCustomerReqName
        {
            get { return _aRCustomerReqName; }
            set
            {
                if (value != this._aRCustomerReqName)
                {
                    _aRCustomerReqName = value;
                }
            }
        }
        public DateTime ARCustomerReqDate
        {
            get { return _aRCustomerReqDate; }
            set
            {
                if (value != this._aRCustomerReqDate)
                {
                    _aRCustomerReqDate = value;
                }
            }
        }
        public String ARCustomerReqDesc
        {
            get { return _aRCustomerReqDesc; }
            set
            {
                if (value != this._aRCustomerReqDesc)
                {
                    _aRCustomerReqDesc = value;
                }
            }
        }
        public String ARCustomerReqStatusCombo
        {
            get { return _aRCustomerReqStatusCombo; }
            set
            {
                if (value != this._aRCustomerReqStatusCombo)
                {
                    _aRCustomerReqStatusCombo = value;
                }
            }
        }
        public int FK_ICProductModelID
        {
            get { return _fK_ICProductModelID; }
            set
            {
                if (value != this._fK_ICProductModelID)
                {
                    _fK_ICProductModelID = value;
                }
            }
        }
        public String ARCustomerReqProductName
        {
            get { return _aRCustomerReqProductName; }
            set
            {
                if (value != this._aRCustomerReqProductName)
                {
                    _aRCustomerReqProductName = value;
                }
            }
        }
        public String ARCustomerReqFillBy
        {
            get { return _aRCustomerReqFillBy; }
            set
            {
                if (value != this._aRCustomerReqFillBy)
                {
                    _aRCustomerReqFillBy = value;
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
        public int FK_ICProductTypeID
        {
            get { return _fK_ICProductTypeID; }
            set
            {
                if (value != this._fK_ICProductTypeID)
                {
                    _fK_ICProductTypeID = value;
                }
            }
        }
        public String ARCustomerReqTypeCombo
        {
            get { return _aRCustomerReqTypeCombo; }
            set
            {
                if (value != this._aRCustomerReqTypeCombo)
                {
                    _aRCustomerReqTypeCombo = value;
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
        public Nullable<DateTime> ARCustomerReqShpDate
        {
            get { return _aRCustomerReqShpDate; }
            set
            {
                if (value != this._aRCustomerReqShpDate)
                {
                    _aRCustomerReqShpDate = value;
                }
            }
        }
        public Nullable<DateTime> ARCustomerReqExpireDate
        {
            get { return _aRCustomerReqExpireDate; }
            set
            {
                if (value != this._aRCustomerReqExpireDate)
                {
                    _aRCustomerReqExpireDate = value;
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

        #endregion
    }
}
