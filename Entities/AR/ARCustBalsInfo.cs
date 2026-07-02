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
    [Table("ARCustBals")]
    public class ARCustBalsInfo : BaseInfo
    {
        public ARCustBalsInfo()
        {
        }
        #region Variables
        protected int _aRCustBalID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _aRCustBalYear;
        protected int _aRCustBalPeriod;
        protected int _fK_ARCustomerID;
        protected decimal _aRCustBalCreditLimit;
        protected decimal _aRCustBalBegin;
        protected decimal _aRCustBalEnd;
        protected decimal _aRCustBalOutStand;
        protected decimal _aRCustBalCustPmtAmt;
        protected decimal _aRCustBalSOAmt;
        protected decimal _aRCustBalShipmentAmt;
        protected decimal _aRCustBalInvoiceAmt;
        protected String _aRCustBalCalcType = String.Empty;
        protected int _aRCustBalOpenInvCount;
        protected int _aRCustBalPeriodOpenInvCount;
        protected int _aRCustBalOpenSOCount;
        protected int _aRCustBalPeriodOpenSOCount;
        protected decimal _aRCustBalCredit;
        #endregion
        [Key]
        #region Public properties
        public int ARCustBalID
        {
            get { return _aRCustBalID; }
            set
            {
                if (value != this._aRCustBalID)
                {
                    _aRCustBalID = value;
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
        public int ARCustBalYear
        {
            get { return _aRCustBalYear; }
            set
            {
                if (value != this._aRCustBalYear)
                {
                    _aRCustBalYear = value;
                }
            }
        }
        public int ARCustBalPeriod
        {
            get { return _aRCustBalPeriod; }
            set
            {
                if (value != this._aRCustBalPeriod)
                {
                    _aRCustBalPeriod = value;
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
        public decimal ARCustBalCreditLimit
        {
            get { return _aRCustBalCreditLimit; }
            set
            {
                if (value != this._aRCustBalCreditLimit)
                {
                    _aRCustBalCreditLimit = value;
                }
            }
        }
        public decimal ARCustBalBegin
        {
            get { return _aRCustBalBegin; }
            set
            {
                if (value != this._aRCustBalBegin)
                {
                    _aRCustBalBegin = value;
                }
            }
        }
        public decimal ARCustBalEnd
        {
            get { return _aRCustBalEnd; }
            set
            {
                if (value != this._aRCustBalEnd)
                {
                    _aRCustBalEnd = value;
                }
            }
        }
        public decimal ARCustBalOutStand
        {
            get { return _aRCustBalOutStand; }
            set
            {
                if (value != this._aRCustBalOutStand)
                {
                    _aRCustBalOutStand = value;
                }
            }
        }
        public decimal ARCustBalCustPmtAmt
        {
            get { return _aRCustBalCustPmtAmt; }
            set
            {
                if (value != this._aRCustBalCustPmtAmt)
                {
                    _aRCustBalCustPmtAmt = value;
                }
            }
        }
        public decimal ARCustBalSOAmt
        {
            get { return _aRCustBalSOAmt; }
            set
            {
                if (value != this._aRCustBalSOAmt)
                {
                    _aRCustBalSOAmt = value;
                }
            }
        }
        public decimal ARCustBalShipmentAmt
        {
            get { return _aRCustBalShipmentAmt; }
            set
            {
                if (value != this._aRCustBalShipmentAmt)
                {
                    _aRCustBalShipmentAmt = value;
                }
            }
        }
        public decimal ARCustBalInvoiceAmt
        {
            get { return _aRCustBalInvoiceAmt; }
            set
            {
                if (value != this._aRCustBalInvoiceAmt)
                {
                    _aRCustBalInvoiceAmt = value;
                }
            }
        }
        public String ARCustBalCalcType
        {
            get { return _aRCustBalCalcType; }
            set
            {
                if (value != this._aRCustBalCalcType)
                {
                    _aRCustBalCalcType = value;
                }
            }
        }
        public int ARCustBalOpenInvCount
        {
            get { return _aRCustBalOpenInvCount; }
            set
            {
                if (value != this._aRCustBalOpenInvCount)
                {
                    _aRCustBalOpenInvCount = value;
                }
            }
        }
        public int ARCustBalPeriodOpenInvCount
        {
            get { return _aRCustBalPeriodOpenInvCount; }
            set
            {
                if (value != this._aRCustBalPeriodOpenInvCount)
                {
                    _aRCustBalPeriodOpenInvCount = value;
                }
            }
        }
        public int ARCustBalOpenSOCount
        {
            get { return _aRCustBalOpenSOCount; }
            set
            {
                if (value != this._aRCustBalOpenSOCount)
                {
                    _aRCustBalOpenSOCount = value;
                }
            }
        }
        public int ARCustBalPeriodOpenSOCount
        {
            get { return _aRCustBalPeriodOpenSOCount; }
            set
            {
                if (value != this._aRCustBalPeriodOpenSOCount)
                {
                    _aRCustBalPeriodOpenSOCount = value;
                }
            }
        }
        public decimal ARCustBalCredit
        {
            get { return _aRCustBalCredit; }
            set
            {
                if (value != this._aRCustBalCredit)
                {
                    _aRCustBalCredit = value;
                }
            }
        }
        #endregion
    }
}
