using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ViewProductSales")]

    public class ViewProductSalesInfo:BaseInfo
	{
		public ViewProductSalesInfo()
		{
		}
		#region Variables
		protected int _viewPruductSaleID;
		protected int _fK_ICProductID;
		protected String _iCProductName=String.Empty;
		protected decimal _saleQty;
		protected decimal _returnTralaiQty;
		protected decimal _returnHuyQty;
		protected decimal _tralaiPct;
		protected decimal _huyPct;
		#endregion
		[Key]
		#region Public properties
		public int ViewPruductSaleID
		{
			get{return _viewPruductSaleID;}
			set
			{
				if (value != this._viewPruductSaleID)
				{
				_viewPruductSaleID=value;
				}
			}
		}
		public int FK_ICProductID
		{
			get{return _fK_ICProductID;}
			set
			{
				if (value != this._fK_ICProductID)
				{
				_fK_ICProductID=value;
				}
			}
		}
		public String ICProductName
		{
			get{return _iCProductName;}
			set
			{
				if (value != this._iCProductName)
				{
				_iCProductName=value;
				}
			}
		}
		public decimal SaleQty
		{
			get{return _saleQty;}
			set
			{
				if (value != this._saleQty)
				{
				_saleQty=value;
				}
			}
		}
		public decimal ReturnTralaiQty
		{
			get{return _returnTralaiQty;}
			set
			{
				if (value != this._returnTralaiQty)
				{
				_returnTralaiQty=value;
				}
			}
		}
		public decimal ReturnHuyQty
		{
			get{return _returnHuyQty;}
			set
			{
				if (value != this._returnHuyQty)
				{
				_returnHuyQty=value;
				}
			}
		}
		public decimal TralaiPct
		{
			get{return _tralaiPct;}
			set
			{
				if (value != this._tralaiPct)
				{
				_tralaiPct=value;
				}
			}
		}
		public decimal HuyPct
		{
			get{return _huyPct;}
			set
			{
				if (value != this._huyPct)
				{
				_huyPct=value;
				}
			}
		}
		#endregion
	}
}