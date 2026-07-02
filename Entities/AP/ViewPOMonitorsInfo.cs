
using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ViewPOMonitors")]

    public class ViewPOMonitorsInfo : BaseInfo
    {
        public ViewPOMonitorsInfo()
        {
        }
        #region Variables
		protected int _viewPOMonitorID;
		protected int _fK_APPOID;
		protected int _fK_APSupplierID;
		protected int _fK_APPOItemID;
		protected int _fK_ICProductID;
		protected decimal _viewPOMonitorReceiptQty;
		protected decimal _viewPOMonitorPInvoiceQty;
		protected decimal _viewPOMonitorPurchaseReturnQty;
		protected decimal _viewPOMonitorShipmentQty;
		protected decimal _viewPOMonitorCreditNoteQty;
		protected int _fK_ICUOMID;
		protected decimal _viewPOMonitorReceiptRQty;
		protected decimal _viewPOMonitorPInvoiceRQty;
		protected String _viewPOMonitorComment = String.Empty;
		protected String _viewPOMonitorStatus = DefaultStatus;
		protected decimal _viewPOMonitorQty;
		protected decimal _viewPOMonitorRQty;
		protected decimal _viewPOMonitorQty1;
		protected decimal _viewPOMonitorQty2;
		protected decimal _viewPOMonitorQty4;
		protected decimal _viewPOMonitorRcpPct;
		protected Nullable<DateTime> _viewPOMonitorArrivalDate;
		protected Nullable<DateTime> _viewPOMonitorLastDate;
		protected String _viewPOMonitorSerialNo = String.Empty;
		protected Nullable<DateTime> _viewPOMonitorSerialDate;
		protected int _fK_HRDepartmentID;
		protected int _fK_APPRID;
		protected decimal _viewPOMonitorQty3;
        protected String _aPPOStatusCombo = String.Empty;
		
        #endregion

        #region Public properties
		public int ViewPOMonitorID
		{
			get { return _viewPOMonitorID; }
			set
			{
				if (value != this._viewPOMonitorID)
				{
					_viewPOMonitorID = value;
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
		public decimal ViewPOMonitorReceiptQty
		{
			get { return _viewPOMonitorReceiptQty; }
			set
			{
				if (value != this._viewPOMonitorReceiptQty)
				{
					_viewPOMonitorReceiptQty = value;
				}
			}
		}
		public decimal ViewPOMonitorPInvoiceQty
		{
			get { return _viewPOMonitorPInvoiceQty; }
			set
			{
				if (value != this._viewPOMonitorPInvoiceQty)
				{
					_viewPOMonitorPInvoiceQty = value;
				}
			}
		}
		public decimal ViewPOMonitorPurchaseReturnQty
		{
			get { return _viewPOMonitorPurchaseReturnQty; }
			set
			{
				if (value != this._viewPOMonitorPurchaseReturnQty)
				{
					_viewPOMonitorPurchaseReturnQty = value;
				}
			}
		}
		public decimal ViewPOMonitorShipmentQty
		{
			get { return _viewPOMonitorShipmentQty; }
			set
			{
				if (value != this._viewPOMonitorShipmentQty)
				{
					_viewPOMonitorShipmentQty = value;
				}
			}
		}
		public decimal ViewPOMonitorCreditNoteQty
		{
			get { return _viewPOMonitorCreditNoteQty; }
			set
			{
				if (value != this._viewPOMonitorCreditNoteQty)
				{
					_viewPOMonitorCreditNoteQty = value;
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
		public decimal ViewPOMonitorReceiptRQty
		{
			get { return _viewPOMonitorReceiptRQty; }
			set
			{
				if (value != this._viewPOMonitorReceiptRQty)
				{
					_viewPOMonitorReceiptRQty = value;
				}
			}
		}
		public decimal ViewPOMonitorPInvoiceRQty
		{
			get { return _viewPOMonitorPInvoiceRQty; }
			set
			{
				if (value != this._viewPOMonitorPInvoiceRQty)
				{
					_viewPOMonitorPInvoiceRQty = value;
				}
			}
		}
		public String ViewPOMonitorComment
		{
			get { return _viewPOMonitorComment; }
			set
			{
				if (value != this._viewPOMonitorComment)
				{
					_viewPOMonitorComment = value;
				}
			}
		}
        public String APPOStatusCombo
        {
            get { return _aPPOStatusCombo; }
            set
            {
                if (value != this._aPPOStatusCombo)
                {
                    _aPPOStatusCombo = value;
                }
            }
        }
		public String ViewPOMonitorStatus
		{
			get { return _viewPOMonitorStatus; }
			set
			{
				if (value != this._viewPOMonitorStatus)
				{
					_viewPOMonitorStatus = value;
				}
			}
		}
		public decimal ViewPOMonitorQty
		{
			get { return _viewPOMonitorQty; }
			set
			{
				if (value != this._viewPOMonitorQty)
				{
					_viewPOMonitorQty = value;
				}
			}
		}
		public decimal ViewPOMonitorRQty
		{
			get { return _viewPOMonitorRQty; }
			set
			{
				if (value != this._viewPOMonitorRQty)
				{
					_viewPOMonitorRQty = value;
				}
			}
		}
		public decimal ViewPOMonitorQty1
		{
			get { return _viewPOMonitorQty1; }
			set
			{
				if (value != this._viewPOMonitorQty1)
				{
					_viewPOMonitorQty1 = value;
				}
			}
		}
		public decimal ViewPOMonitorQty2
		{
			get { return _viewPOMonitorQty2; }
			set
			{
				if (value != this._viewPOMonitorQty2)
				{
					_viewPOMonitorQty2 = value;
				}
			}
		}
		public decimal ViewPOMonitorQty4
		{
			get { return _viewPOMonitorQty4; }
			set
			{
				if (value != this._viewPOMonitorQty4)
				{
					_viewPOMonitorQty4 = value;
				}
			}
		}
		public decimal ViewPOMonitorRcpPct
		{
			get { return _viewPOMonitorRcpPct; }
			set
			{
				if (value != this._viewPOMonitorRcpPct)
				{
					_viewPOMonitorRcpPct = value;
				}
			}
		}
		public Nullable<DateTime> ViewPOMonitorArrivalDate
		{
			get { return _viewPOMonitorArrivalDate; }
			set
			{
				if (value != this._viewPOMonitorArrivalDate)
				{
					_viewPOMonitorArrivalDate = value;
				}
			}
		}
		public Nullable<DateTime> ViewPOMonitorLastDate
		{
			get { return _viewPOMonitorLastDate; }
			set
			{
				if (value != this._viewPOMonitorLastDate)
				{
					_viewPOMonitorLastDate = value;
				}
			}
		}
		public String ViewPOMonitorSerialNo
		{
			get { return _viewPOMonitorSerialNo; }
			set
			{
				if (value != this._viewPOMonitorSerialNo)
				{
					_viewPOMonitorSerialNo = value;
				}
			}
		}
		public Nullable<DateTime> ViewPOMonitorSerialDate
		{
			get { return _viewPOMonitorSerialDate; }
			set
			{
				if (value != this._viewPOMonitorSerialDate)
				{
					_viewPOMonitorSerialDate = value;
				}
			}
		}
		public int FK_HRDepartmentID
		{
			get { return _fK_HRDepartmentID; }
			set
			{
				if (value != this._fK_HRDepartmentID)
				{
					_fK_HRDepartmentID = value;
				}
			}
		}
		public int FK_APPRID
		{
			get { return _fK_APPRID; }
			set
			{
				if (value != this._fK_APPRID)
				{
					_fK_APPRID = value;
				}
			}
		}
		public decimal ViewPOMonitorQty3
		{
			get { return _viewPOMonitorQty3; }
			set
			{
				if (value != this._viewPOMonitorQty3)
				{
					_viewPOMonitorQty3 = value;
				}
			}
		}
		public string APPONo { get; set; }
        public Nullable<DateTime> APPODate { get; set; }
        public string APSupplierNo { get; set; }
        public string APSupplierName { get; set; }
        public string ICProductNo { get; set; }
        public string ICProductName { get; set; }
        public string ICUOMNo { get; set; }
        public string APPOItemComment { get; set; }
        public string APPOItemDesc { get; set; }
        public decimal APPOItemQty { get; set; }
        public decimal APPOItemStkQty { get; set; }
        #endregion
    }
}