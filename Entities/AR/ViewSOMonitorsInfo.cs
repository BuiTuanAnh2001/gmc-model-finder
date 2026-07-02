
using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ViewSOMonitors")]


    public class ViewSOMonitorsInfo : BaseInfo
    {
        public ViewSOMonitorsInfo()
        {
        }
        #region Variables
		protected int _viewSOMonitorID;
		protected int _viewSOMonitorSTT;
		protected int _fK_ARSOID;
		protected int _fK_APPOID;
		protected int _fK_ICProductID;
		protected int _fK_ARCustomerID;
		protected int _fK_APSupplierID;
		protected decimal _sOQty;
		protected decimal _pOQty;
		protected String _pOStatus = DefaultStatus;
		protected Nullable<DateTime> _arivalDate;
		protected decimal _inStockQty;
		protected int _fK_ICStockID;
		protected String _pOShippingStatus = DefaultStatus;
		protected String _pOPaymentStatus = DefaultStatus;
		protected Nullable<DateTime> _sOShpDate;
		protected String _status = DefaultStatus;
		protected Nullable<DateTime> _viewSOMonitorDate;
		protected Nullable<DateTime> _viewSOMonitorShpDate;
		protected decimal _viewSOMonitorQty;
		protected decimal _viewSOMonitorRQty;
		protected decimal _viewSOMonitorShpQty;
		protected decimal _viewSOMonitorShipmentQty;
		protected decimal _viewSOMonitorShipmentPct;
		protected String _viewSOMonitorPerformance = String.Empty;
		protected int _fK_ARShpPlanID;
		protected int _fK_ICShipmentItemID;
		protected int _fK_ICROItemID;
		protected int _fK_ARInvoiceItemID;
		protected decimal _viewSOMonitorROQty;
		protected decimal _viewSOMonitorInvoiceQty;
		protected decimal _viewSOMonitorReceiptQty;
		protected int _fK_ICReceiptItemID;
		protected int _fK_ARCreditNoteItemID;
		protected decimal _viewSOMonitorCreditNoteQty;
		protected decimal _viewSOMonitorSOQty;
		protected int _fK_ARSOItemID;
		protected int _fK_ICROID;
		protected int _fK_ICReceiptID;
		protected int _fK_ICShipmentID;
		protected int _fK_ARInvoiceID;
		protected int _fK_ARCreditNoteID;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		protected decimal _viewSOMonitorRORQty;
		protected decimal _viewSOMonitorShipmentRQty;
		protected decimal _viewSOMonitorInvoiceRQty;
		protected decimal _viewSOMonitorReceiptRQty;
		protected decimal _viewSOMonitorCreditNoteRQty;
		protected decimal _viewSOMonitorSORQty;
		protected String _oCode05 = String.Empty;
		protected decimal _viewSOMonitorSOCQty;
		protected String _aRSONo = String.Empty;
		protected String _aRSOName = String.Empty;
		protected Nullable<DateTime> _aRSODate;
		protected String _aRSODesc = String.Empty;
		protected String _iCProductNo = String.Empty;
		protected String _iCProductName = String.Empty;
		protected String _iCProductEngName = String.Empty;
		protected String _iCProductDesc = String.Empty;
		protected String _iCProductIOF01Combo = String.Empty;
		protected String _iCProductIOF02Combo = String.Empty;
		protected String _iCProductIOF03Combo = String.Empty;
		protected String _iCProductIOF04Combo = String.Empty;
		protected String _iCProductIOF05Combo = String.Empty;
		protected String _iCProductIOF06Combo = String.Empty;
		protected String _iCProductIOF07Combo = String.Empty;
		protected String _iCProductIOF08Combo = String.Empty;
		protected String _iCProductIOF09Combo = String.Empty;
		protected String _iCProductIOF10Combo = String.Empty;
		protected String _iCProductIOF11Combo = String.Empty;
		protected String _iCProductIOF12Combo = String.Empty;
		protected String _iCProductIOF13Combo = String.Empty;
		protected String _iCProductIOF14Combo = String.Empty;
		protected String _iCProductIOF15Combo = String.Empty;
		protected String _aRCustomerNo = String.Empty;
		protected String _aRCustomerName = String.Empty;
		protected String _aRCustomerDesc = String.Empty;
		protected String _aRCustomerOOF01Combo = String.Empty;
		protected String _aRCustomerOOF02Combo = String.Empty;
		protected String _aRCustomerOOF03Combo = String.Empty;
		protected String _aRCustomerOOF04Combo = String.Empty;
		protected String _aRCustomerOOF05Combo = String.Empty;
		protected String _aRCustomerOOF06Combo = String.Empty;
		protected String _aRCustomerOOF07Combo = String.Empty;
		protected String _aRCustomerOOF08Combo = String.Empty;
		protected String _aRCustomerOOF09Combo = String.Empty;
		protected String _aRCustomerOOF10Combo = String.Empty;
		protected String _aRCustomerOOF11Combo = String.Empty;
		protected String _aRCustomerOOF12Combo = String.Empty;
		protected String _aRCustomerOOF13Combo = String.Empty;
		protected String _aRCustomerOOF14Combo = String.Empty;
		protected String _aRCustomerOOF15Combo = String.Empty;
		protected String _aRCampaignNo = String.Empty;
		protected String _aRCampaignName = String.Empty;
		protected Nullable<DateTime> _aRCampaignDate;
		protected String _aRCampaignDescription = String.Empty;
		protected String _iCStockNo = String.Empty;
		protected String _iCStockName = String.Empty;
		protected String _iCUOMNo = String.Empty;
		protected String _iCUOMName = String.Empty;
		protected String _iCStkUOMNo = String.Empty;
		protected String _iCStkUOMName = String.Empty;
		protected String _aRSOItemTAN = String.Empty;
		protected String _aRSOItemDesc = String.Empty;
		protected Nullable<DateTime> _aRSOItemShpDate;
		protected String _aRCustomerSTConNo = String.Empty;
		protected String _aRSOSTAddL1 = String.Empty;
		protected String _aRSOSTAddL2 = String.Empty;
		protected String _aPSupplierNo = String.Empty;
		protected String _aPSupplierName = String.Empty;
		protected String _aPSupplierDesc = String.Empty;
		protected int _viewSOMonitor01Combo;
		protected int _viewSOMonitor02Combo;
		protected decimal _viewSOMonitor03Combo;
		protected decimal _viewSOMonitor04Combo;
		protected decimal _viewSOMonitor05Combo;
		protected String _viewSOMonitor06Combo = String.Empty;
		protected String _viewSOMonitor07Combo = String.Empty;
		protected String _viewSOMonitor08Combo = String.Empty;
		protected String _viewSOMonitor09Combo = String.Empty;
		protected String _viewSOMonitor10Combo = String.Empty;
		protected String _viewSOMonitor11Combo = String.Empty;
		protected String _viewSOMonitor12Combo = String.Empty;
        protected decimal _viewSOMonitorInvoiceAmtTot;
        protected decimal _viewSOMonitorInvoicePmtAmtTot;
        protected decimal _viewSOMonitorInvoiceRAmtTot;

        #endregion
        [Key]
        #region Public properties
		public int ViewSOMonitorID
		{
			get { return _viewSOMonitorID; }
			set
			{
				if (value != this._viewSOMonitorID)
				{
					_viewSOMonitorID = value;
				}
			}
		}
		public int ViewSOMonitorSTT
		{
			get { return _viewSOMonitorSTT; }
			set
			{
				if (value != this._viewSOMonitorSTT)
				{
					_viewSOMonitorSTT = value;
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
		public decimal SOQty
		{
			get { return _sOQty; }
			set
			{
				if (value != this._sOQty)
				{
					_sOQty = value;
				}
			}
		}
		public decimal POQty
		{
			get { return _pOQty; }
			set
			{
				if (value != this._pOQty)
				{
					_pOQty = value;
				}
			}
		}
		public String POStatus
		{
			get { return _pOStatus; }
			set
			{
				if (value != this._pOStatus)
				{
					_pOStatus = value;
				}
			}
		}
		public Nullable<DateTime> ArivalDate
		{
			get { return _arivalDate; }
			set
			{
				if (value != this._arivalDate)
				{
					_arivalDate = value;
				}
			}
		}
		public decimal InStockQty
		{
			get { return _inStockQty; }
			set
			{
				if (value != this._inStockQty)
				{
					_inStockQty = value;
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
		public String POShippingStatus
		{
			get { return _pOShippingStatus; }
			set
			{
				if (value != this._pOShippingStatus)
				{
					_pOShippingStatus = value;
				}
			}
		}
		public String POPaymentStatus
		{
			get { return _pOPaymentStatus; }
			set
			{
				if (value != this._pOPaymentStatus)
				{
					_pOPaymentStatus = value;
				}
			}
		}
		public Nullable<DateTime> SOShpDate
		{
			get { return _sOShpDate; }
			set
			{
				if (value != this._sOShpDate)
				{
					_sOShpDate = value;
				}
			}
		}
		public String Status
		{
			get { return _status; }
			set
			{
				if (value != this._status)
				{
					_status = value;
				}
			}
		}
		public Nullable<DateTime> ViewSOMonitorDate
		{
			get { return _viewSOMonitorDate; }
			set
			{
				if (value != this._viewSOMonitorDate)
				{
					_viewSOMonitorDate = value;
				}
			}
		}
		public Nullable<DateTime> ViewSOMonitorShpDate
		{
			get { return _viewSOMonitorShpDate; }
			set
			{
				if (value != this._viewSOMonitorShpDate)
				{
					_viewSOMonitorShpDate = value;
				}
			}
		}
		public decimal ViewSOMonitorQty
		{
			get { return _viewSOMonitorQty; }
			set
			{
				if (value != this._viewSOMonitorQty)
				{
					_viewSOMonitorQty = value;
				}
			}
		}
		public decimal ViewSOMonitorRQty
		{
			get { return _viewSOMonitorRQty; }
			set
			{
				if (value != this._viewSOMonitorRQty)
				{
					_viewSOMonitorRQty = value;
				}
			}
		}
		public decimal ViewSOMonitorShpQty
		{
			get { return _viewSOMonitorShpQty; }
			set
			{
				if (value != this._viewSOMonitorShpQty)
				{
					_viewSOMonitorShpQty = value;
				}
			}
		}
		public decimal ViewSOMonitorShipmentQty
		{
			get { return _viewSOMonitorShipmentQty; }
			set
			{
				if (value != this._viewSOMonitorShipmentQty)
				{
					_viewSOMonitorShipmentQty = value;
				}
			}
		}
		public decimal ViewSOMonitorShipmentPct
		{
			get { return _viewSOMonitorShipmentPct; }
			set
			{
				if (value != this._viewSOMonitorShipmentPct)
				{
					_viewSOMonitorShipmentPct = value;
				}
			}
		}
		public String ViewSOMonitorPerformance
		{
			get { return _viewSOMonitorPerformance; }
			set
			{
				if (value != this._viewSOMonitorPerformance)
				{
					_viewSOMonitorPerformance = value;
				}
			}
		}
		public int FK_ARShpPlanID
		{
			get { return _fK_ARShpPlanID; }
			set
			{
				if (value != this._fK_ARShpPlanID)
				{
					_fK_ARShpPlanID = value;
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
		public int FK_ICROItemID
		{
			get { return _fK_ICROItemID; }
			set
			{
				if (value != this._fK_ICROItemID)
				{
					_fK_ICROItemID = value;
				}
			}
		}
		public int FK_ARInvoiceItemID
		{
			get { return _fK_ARInvoiceItemID; }
			set
			{
				if (value != this._fK_ARInvoiceItemID)
				{
					_fK_ARInvoiceItemID = value;
				}
			}
		}
		public decimal ViewSOMonitorROQty
		{
			get { return _viewSOMonitorROQty; }
			set
			{
				if (value != this._viewSOMonitorROQty)
				{
					_viewSOMonitorROQty = value;
				}
			}
		}
		public decimal ViewSOMonitorInvoiceQty
		{
			get { return _viewSOMonitorInvoiceQty; }
			set
			{
				if (value != this._viewSOMonitorInvoiceQty)
				{
					_viewSOMonitorInvoiceQty = value;
				}
			}
		}
		public decimal ViewSOMonitorReceiptQty
		{
			get { return _viewSOMonitorReceiptQty; }
			set
			{
				if (value != this._viewSOMonitorReceiptQty)
				{
					_viewSOMonitorReceiptQty = value;
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
		public int FK_ARCreditNoteItemID
		{
			get { return _fK_ARCreditNoteItemID; }
			set
			{
				if (value != this._fK_ARCreditNoteItemID)
				{
					_fK_ARCreditNoteItemID = value;
				}
			}
		}
		public decimal ViewSOMonitorCreditNoteQty
		{
			get { return _viewSOMonitorCreditNoteQty; }
			set
			{
				if (value != this._viewSOMonitorCreditNoteQty)
				{
					_viewSOMonitorCreditNoteQty = value;
				}
			}
		}
		public decimal ViewSOMonitorSOQty
		{
			get { return _viewSOMonitorSOQty; }
			set
			{
				if (value != this._viewSOMonitorSOQty)
				{
					_viewSOMonitorSOQty = value;
				}
			}
		}
		public int FK_ARSOItemID
		{
			get { return _fK_ARSOItemID; }
			set
			{
				if (value != this._fK_ARSOItemID)
				{
					_fK_ARSOItemID = value;
				}
			}
		}
		public int FK_ICROID
		{
			get { return _fK_ICROID; }
			set
			{
				if (value != this._fK_ICROID)
				{
					_fK_ICROID = value;
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
		public int FK_ARInvoiceID
		{
			get { return _fK_ARInvoiceID; }
			set
			{
				if (value != this._fK_ARInvoiceID)
				{
					_fK_ARInvoiceID = value;
				}
			}
		}
		public int FK_ARCreditNoteID
		{
			get { return _fK_ARCreditNoteID; }
			set
			{
				if (value != this._fK_ARCreditNoteID)
				{
					_fK_ARCreditNoteID = value;
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
		public decimal ViewSOMonitorRORQty
		{
			get { return _viewSOMonitorRORQty; }
			set
			{
				if (value != this._viewSOMonitorRORQty)
				{
					_viewSOMonitorRORQty = value;
				}
			}
		}
		public decimal ViewSOMonitorShipmentRQty
		{
			get { return _viewSOMonitorShipmentRQty; }
			set
			{
				if (value != this._viewSOMonitorShipmentRQty)
				{
					_viewSOMonitorShipmentRQty = value;
				}
			}
		}
		public decimal ViewSOMonitorInvoiceRQty
		{
			get { return _viewSOMonitorInvoiceRQty; }
			set
			{
				if (value != this._viewSOMonitorInvoiceRQty)
				{
					_viewSOMonitorInvoiceRQty = value;
				}
			}
		}
		public decimal ViewSOMonitorReceiptRQty
		{
			get { return _viewSOMonitorReceiptRQty; }
			set
			{
				if (value != this._viewSOMonitorReceiptRQty)
				{
					_viewSOMonitorReceiptRQty = value;
				}
			}
		}
		public decimal ViewSOMonitorCreditNoteRQty
		{
			get { return _viewSOMonitorCreditNoteRQty; }
			set
			{
				if (value != this._viewSOMonitorCreditNoteRQty)
				{
					_viewSOMonitorCreditNoteRQty = value;
				}
			}
		}
		public decimal ViewSOMonitorSORQty
		{
			get { return _viewSOMonitorSORQty; }
			set
			{
				if (value != this._viewSOMonitorSORQty)
				{
					_viewSOMonitorSORQty = value;
				}
			}
		}
		public String OCode05
		{
			get { return _oCode05; }
			set
			{
				if (value != this._oCode05)
				{
					_oCode05 = value;
				}
			}
		}
		public decimal ViewSOMonitorSOCQty
		{
			get { return _viewSOMonitorSOCQty; }
			set
			{
				if (value != this._viewSOMonitorSOCQty)
				{
					_viewSOMonitorSOCQty = value;
				}
			}
		}
		public String ARSONo
		{
			get { return _aRSONo; }
			set
			{
				if (value != this._aRSONo)
				{
					_aRSONo = value;
				}
			}
		}
		public String ARSOName
		{
			get { return _aRSOName; }
			set
			{
				if (value != this._aRSOName)
				{
					_aRSOName = value;
				}
			}
		}
		public Nullable<DateTime> ARSODate
		{
			get { return _aRSODate; }
			set
			{
				if (value != this._aRSODate)
				{
					_aRSODate = value;
				}
			}
		}
		public String ARSODesc
		{
			get { return _aRSODesc; }
			set
			{
				if (value != this._aRSODesc)
				{
					_aRSODesc = value;
				}
			}
		}
		public String ICProductNo
		{
			get { return _iCProductNo; }
			set
			{
				if (value != this._iCProductNo)
				{
					_iCProductNo = value;
				}
			}
		}
		public String ICProductName
		{
			get { return _iCProductName; }
			set
			{
				if (value != this._iCProductName)
				{
					_iCProductName = value;
				}
			}
		}
		public String ICProductEngName
		{
			get { return _iCProductEngName; }
			set
			{
				if (value != this._iCProductEngName)
				{
					_iCProductEngName = value;
				}
			}
		}
		public String ICProductDesc
		{
			get { return _iCProductDesc; }
			set
			{
				if (value != this._iCProductDesc)
				{
					_iCProductDesc = value;
				}
			}
		}
		public String ICProductIOF01Combo
		{
			get { return _iCProductIOF01Combo; }
			set
			{
				if (value != this._iCProductIOF01Combo)
				{
					_iCProductIOF01Combo = value;
				}
			}
		}
		public String ICProductIOF02Combo
		{
			get { return _iCProductIOF02Combo; }
			set
			{
				if (value != this._iCProductIOF02Combo)
				{
					_iCProductIOF02Combo = value;
				}
			}
		}
		public String ICProductIOF03Combo
		{
			get { return _iCProductIOF03Combo; }
			set
			{
				if (value != this._iCProductIOF03Combo)
				{
					_iCProductIOF03Combo = value;
				}
			}
		}
		public String ICProductIOF04Combo
		{
			get { return _iCProductIOF04Combo; }
			set
			{
				if (value != this._iCProductIOF04Combo)
				{
					_iCProductIOF04Combo = value;
				}
			}
		}
		public String ICProductIOF05Combo
		{
			get { return _iCProductIOF05Combo; }
			set
			{
				if (value != this._iCProductIOF05Combo)
				{
					_iCProductIOF05Combo = value;
				}
			}
		}
		public String ICProductIOF06Combo
		{
			get { return _iCProductIOF06Combo; }
			set
			{
				if (value != this._iCProductIOF06Combo)
				{
					_iCProductIOF06Combo = value;
				}
			}
		}
		public String ICProductIOF07Combo
		{
			get { return _iCProductIOF07Combo; }
			set
			{
				if (value != this._iCProductIOF07Combo)
				{
					_iCProductIOF07Combo = value;
				}
			}
		}
		public String ICProductIOF08Combo
		{
			get { return _iCProductIOF08Combo; }
			set
			{
				if (value != this._iCProductIOF08Combo)
				{
					_iCProductIOF08Combo = value;
				}
			}
		}
		public String ICProductIOF09Combo
		{
			get { return _iCProductIOF09Combo; }
			set
			{
				if (value != this._iCProductIOF09Combo)
				{
					_iCProductIOF09Combo = value;
				}
			}
		}
		public String ICProductIOF10Combo
		{
			get { return _iCProductIOF10Combo; }
			set
			{
				if (value != this._iCProductIOF10Combo)
				{
					_iCProductIOF10Combo = value;
				}
			}
		}
		public String ICProductIOF11Combo
		{
			get { return _iCProductIOF11Combo; }
			set
			{
				if (value != this._iCProductIOF11Combo)
				{
					_iCProductIOF11Combo = value;
				}
			}
		}
		public String ICProductIOF12Combo
		{
			get { return _iCProductIOF12Combo; }
			set
			{
				if (value != this._iCProductIOF12Combo)
				{
					_iCProductIOF12Combo = value;
				}
			}
		}
		public String ICProductIOF13Combo
		{
			get { return _iCProductIOF13Combo; }
			set
			{
				if (value != this._iCProductIOF13Combo)
				{
					_iCProductIOF13Combo = value;
				}
			}
		}
		public String ICProductIOF14Combo
		{
			get { return _iCProductIOF14Combo; }
			set
			{
				if (value != this._iCProductIOF14Combo)
				{
					_iCProductIOF14Combo = value;
				}
			}
		}
		public String ICProductIOF15Combo
		{
			get { return _iCProductIOF15Combo; }
			set
			{
				if (value != this._iCProductIOF15Combo)
				{
					_iCProductIOF15Combo = value;
				}
			}
		}
		public String ARCustomerNo
		{
			get { return _aRCustomerNo; }
			set
			{
				if (value != this._aRCustomerNo)
				{
					_aRCustomerNo = value;
				}
			}
		}
		public String ARCustomerName
		{
			get { return _aRCustomerName; }
			set
			{
				if (value != this._aRCustomerName)
				{
					_aRCustomerName = value;
				}
			}
		}
		public String ARCustomerDesc
		{
			get { return _aRCustomerDesc; }
			set
			{
				if (value != this._aRCustomerDesc)
				{
					_aRCustomerDesc = value;
				}
			}
		}
		public String ARCustomerOOF01Combo
		{
			get { return _aRCustomerOOF01Combo; }
			set
			{
				if (value != this._aRCustomerOOF01Combo)
				{
					_aRCustomerOOF01Combo = value;
				}
			}
		}
		public String ARCustomerOOF02Combo
		{
			get { return _aRCustomerOOF02Combo; }
			set
			{
				if (value != this._aRCustomerOOF02Combo)
				{
					_aRCustomerOOF02Combo = value;
				}
			}
		}
		public String ARCustomerOOF03Combo
		{
			get { return _aRCustomerOOF03Combo; }
			set
			{
				if (value != this._aRCustomerOOF03Combo)
				{
					_aRCustomerOOF03Combo = value;
				}
			}
		}
		public String ARCustomerOOF04Combo
		{
			get { return _aRCustomerOOF04Combo; }
			set
			{
				if (value != this._aRCustomerOOF04Combo)
				{
					_aRCustomerOOF04Combo = value;
				}
			}
		}
		public String ARCustomerOOF05Combo
		{
			get { return _aRCustomerOOF05Combo; }
			set
			{
				if (value != this._aRCustomerOOF05Combo)
				{
					_aRCustomerOOF05Combo = value;
				}
			}
		}
		public String ARCustomerOOF06Combo
		{
			get { return _aRCustomerOOF06Combo; }
			set
			{
				if (value != this._aRCustomerOOF06Combo)
				{
					_aRCustomerOOF06Combo = value;
				}
			}
		}
		public String ARCustomerOOF07Combo
		{
			get { return _aRCustomerOOF07Combo; }
			set
			{
				if (value != this._aRCustomerOOF07Combo)
				{
					_aRCustomerOOF07Combo = value;
				}
			}
		}
		public String ARCustomerOOF08Combo
		{
			get { return _aRCustomerOOF08Combo; }
			set
			{
				if (value != this._aRCustomerOOF08Combo)
				{
					_aRCustomerOOF08Combo = value;
				}
			}
		}
		public String ARCustomerOOF09Combo
		{
			get { return _aRCustomerOOF09Combo; }
			set
			{
				if (value != this._aRCustomerOOF09Combo)
				{
					_aRCustomerOOF09Combo = value;
				}
			}
		}
		public String ARCustomerOOF10Combo
		{
			get { return _aRCustomerOOF10Combo; }
			set
			{
				if (value != this._aRCustomerOOF10Combo)
				{
					_aRCustomerOOF10Combo = value;
				}
			}
		}
		public String ARCustomerOOF11Combo
		{
			get { return _aRCustomerOOF11Combo; }
			set
			{
				if (value != this._aRCustomerOOF11Combo)
				{
					_aRCustomerOOF11Combo = value;
				}
			}
		}
		public String ARCustomerOOF12Combo
		{
			get { return _aRCustomerOOF12Combo; }
			set
			{
				if (value != this._aRCustomerOOF12Combo)
				{
					_aRCustomerOOF12Combo = value;
				}
			}
		}
		public String ARCustomerOOF13Combo
		{
			get { return _aRCustomerOOF13Combo; }
			set
			{
				if (value != this._aRCustomerOOF13Combo)
				{
					_aRCustomerOOF13Combo = value;
				}
			}
		}
		public String ARCustomerOOF14Combo
		{
			get { return _aRCustomerOOF14Combo; }
			set
			{
				if (value != this._aRCustomerOOF14Combo)
				{
					_aRCustomerOOF14Combo = value;
				}
			}
		}
		public String ARCustomerOOF15Combo
		{
			get { return _aRCustomerOOF15Combo; }
			set
			{
				if (value != this._aRCustomerOOF15Combo)
				{
					_aRCustomerOOF15Combo = value;
				}
			}
		}
		public String ARCampaignNo
		{
			get { return _aRCampaignNo; }
			set
			{
				if (value != this._aRCampaignNo)
				{
					_aRCampaignNo = value;
				}
			}
		}
		public String ARCampaignName
		{
			get { return _aRCampaignName; }
			set
			{
				if (value != this._aRCampaignName)
				{
					_aRCampaignName = value;
				}
			}
		}
		public Nullable<DateTime> ARCampaignDate
		{
			get { return _aRCampaignDate; }
			set
			{
				if (value != this._aRCampaignDate)
				{
					_aRCampaignDate = value;
				}
			}
		}
		public String ARCampaignDescription
		{
			get { return _aRCampaignDescription; }
			set
			{
				if (value != this._aRCampaignDescription)
				{
					_aRCampaignDescription = value;
				}
			}
		}
		public String ICStockNo
		{
			get { return _iCStockNo; }
			set
			{
				if (value != this._iCStockNo)
				{
					_iCStockNo = value;
				}
			}
		}
		public String ICStockName
		{
			get { return _iCStockName; }
			set
			{
				if (value != this._iCStockName)
				{
					_iCStockName = value;
				}
			}
		}
		public String ICUOMNo
		{
			get { return _iCUOMNo; }
			set
			{
				if (value != this._iCUOMNo)
				{
					_iCUOMNo = value;
				}
			}
		}
		public String ICUOMName
		{
			get { return _iCUOMName; }
			set
			{
				if (value != this._iCUOMName)
				{
					_iCUOMName = value;
				}
			}
		}
		public String ICStkUOMNo
		{
			get { return _iCStkUOMNo; }
			set
			{
				if (value != this._iCStkUOMNo)
				{
					_iCStkUOMNo = value;
				}
			}
		}
		public String ICStkUOMName
		{
			get { return _iCStkUOMName; }
			set
			{
				if (value != this._iCStkUOMName)
				{
					_iCStkUOMName = value;
				}
			}
		}
		public String ARSOItemTAN
		{
			get { return _aRSOItemTAN; }
			set
			{
				if (value != this._aRSOItemTAN)
				{
					_aRSOItemTAN = value;
				}
			}
		}
		public String ARSOItemDesc
		{
			get { return _aRSOItemDesc; }
			set
			{
				if (value != this._aRSOItemDesc)
				{
					_aRSOItemDesc = value;
				}
			}
		}
		public Nullable<DateTime> ARSOItemShpDate
		{
			get { return _aRSOItemShpDate; }
			set
			{
				if (value != this._aRSOItemShpDate)
				{
					_aRSOItemShpDate = value;
				}
			}
		}
		public String ARCustomerSTConNo
		{
			get { return _aRCustomerSTConNo; }
			set
			{
				if (value != this._aRCustomerSTConNo)
				{
					_aRCustomerSTConNo = value;
				}
			}
		}
		public String ARSOSTAddL1
		{
			get { return _aRSOSTAddL1; }
			set
			{
				if (value != this._aRSOSTAddL1)
				{
					_aRSOSTAddL1 = value;
				}
			}
		}
		public String ARSOSTAddL2
		{
			get { return _aRSOSTAddL2; }
			set
			{
				if (value != this._aRSOSTAddL2)
				{
					_aRSOSTAddL2 = value;
				}
			}
		}
		public String APSupplierNo
		{
			get { return _aPSupplierNo; }
			set
			{
				if (value != this._aPSupplierNo)
				{
					_aPSupplierNo = value;
				}
			}
		}
		public String APSupplierName
		{
			get { return _aPSupplierName; }
			set
			{
				if (value != this._aPSupplierName)
				{
					_aPSupplierName = value;
				}
			}
		}
		public String APSupplierDesc
		{
			get { return _aPSupplierDesc; }
			set
			{
				if (value != this._aPSupplierDesc)
				{
					_aPSupplierDesc = value;
				}
			}
		}
		public int ViewSOMonitor01Combo
		{
			get { return _viewSOMonitor01Combo; }
			set
			{
				if (value != this._viewSOMonitor01Combo)
				{
					_viewSOMonitor01Combo = value;
				}
			}
		}
		public int ViewSOMonitor02Combo
		{
			get { return _viewSOMonitor02Combo; }
			set
			{
				if (value != this._viewSOMonitor02Combo)
				{
					_viewSOMonitor02Combo = value;
				}
			}
		}
		public decimal ViewSOMonitor03Combo
		{
			get { return _viewSOMonitor03Combo; }
			set
			{
				if (value != this._viewSOMonitor03Combo)
				{
					_viewSOMonitor03Combo = value;
				}
			}
		}
		public decimal ViewSOMonitor04Combo
		{
			get { return _viewSOMonitor04Combo; }
			set
			{
				if (value != this._viewSOMonitor04Combo)
				{
					_viewSOMonitor04Combo = value;
				}
			}
		}
		public decimal ViewSOMonitor05Combo
		{
			get { return _viewSOMonitor05Combo; }
			set
			{
				if (value != this._viewSOMonitor05Combo)
				{
					_viewSOMonitor05Combo = value;
				}
			}
		}
		public String ViewSOMonitor06Combo
		{
			get { return _viewSOMonitor06Combo; }
			set
			{
				if (value != this._viewSOMonitor06Combo)
				{
					_viewSOMonitor06Combo = value;
				}
			}
		}
		public String ViewSOMonitor07Combo
		{
			get { return _viewSOMonitor07Combo; }
			set
			{
				if (value != this._viewSOMonitor07Combo)
				{
					_viewSOMonitor07Combo = value;
				}
			}
		}
		public String ViewSOMonitor08Combo
		{
			get { return _viewSOMonitor08Combo; }
			set
			{
				if (value != this._viewSOMonitor08Combo)
				{
					_viewSOMonitor08Combo = value;
				}
			}
		}
		public String ViewSOMonitor09Combo
		{
			get { return _viewSOMonitor09Combo; }
			set
			{
				if (value != this._viewSOMonitor09Combo)
				{
					_viewSOMonitor09Combo = value;
				}
			}
		}
		public String ViewSOMonitor10Combo
		{
			get { return _viewSOMonitor10Combo; }
			set
			{
				if (value != this._viewSOMonitor10Combo)
				{
					_viewSOMonitor10Combo = value;
				}
			}
		}
		public String ViewSOMonitor11Combo
		{
			get { return _viewSOMonitor11Combo; }
			set
			{
				if (value != this._viewSOMonitor11Combo)
				{
					_viewSOMonitor11Combo = value;
				}
			}
		}
		public String ViewSOMonitor12Combo
		{
			get { return _viewSOMonitor12Combo; }
			set
			{
				if (value != this._viewSOMonitor12Combo)
				{
					_viewSOMonitor12Combo = value;
				}
			}
		}
        public decimal ViewSOMonitorInvoiceAmtTot
        {
            get { return _viewSOMonitorInvoiceAmtTot; }
            set
            {
                if (value != this._viewSOMonitorInvoiceAmtTot)
                {
                    _viewSOMonitorInvoiceAmtTot = value;
                }
            }
        }
        public decimal ViewSOMonitorInvoiceRAmtTot
        {
            get { return _viewSOMonitorInvoiceRAmtTot; }
            set
            {
                if (value != this._viewSOMonitorInvoiceRAmtTot)
                {
                    _viewSOMonitorInvoiceRAmtTot = value;
                }
            }
        }
        public decimal ViewSOMonitorInvoicePmtAmtTot
        {
            get { return _viewSOMonitorInvoicePmtAmtTot; }
            set
            {
                if (value != this._viewSOMonitorInvoicePmtAmtTot)
                {
                    _viewSOMonitorInvoicePmtAmtTot = value;
                }
            }
        }
        public decimal ARSOItemUnitPrice { get; set; }
        public decimal ARSOItemPrice { get; set; }
        public decimal ARSOItemFUnitPrice { get; set; }
        public decimal ARSOItemFPrice { get; set; }
        public int FK_BRBranchID { get; set; }
		public decimal PPWOPItemQty { get; set; }
        public decimal PPProductionOrdrEstFGQty { get; set; }
        #endregion
    }

}