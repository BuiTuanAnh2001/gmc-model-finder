using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ViewChartSaleAnalysisStatistics")]
    public class ViewChartSaleAnalysisStatisticsInfo:BaseInfo
	{
		public ViewChartSaleAnalysisStatisticsInfo()
		{
		}
		#region Variables
		protected int _viewChartSaleAnalysisStatisticID;
		protected String _viewChartSaleAnalysisStatisticNo=String.Empty;
		protected String _viewChartSaleAnalysisStatisticName=String.Empty;
		protected String _viewChartSaleAnalysisStatisticCustomerGroup=String.Empty;
		protected decimal _viewChartSaleAnalysisStatisticAnnualTotal;
		protected String _viewChartSaleAnalysisStatisticTime=String.Empty;
		protected decimal _viewChartSaleAnalysisStatisticRevenues;
		protected decimal _viewChartSaleAnalysisStatisticProfit;
		protected int _viewChartSaleAnalysisStatisticYear;
		protected String _viewChartSaleAnalysisStatisticKey=String.Empty;
		#endregion
		[Key]
		#region Public properties
		public int ViewChartSaleAnalysisStatisticID
		{
			get{return _viewChartSaleAnalysisStatisticID;}
			set
			{
				if (value != this._viewChartSaleAnalysisStatisticID)
				{
				_viewChartSaleAnalysisStatisticID=value;
				}
			}
		}
		public String ViewChartSaleAnalysisStatisticNo
		{
			get{return _viewChartSaleAnalysisStatisticNo;}
			set
			{
				if (value != this._viewChartSaleAnalysisStatisticNo)
				{
				_viewChartSaleAnalysisStatisticNo=value;
				}
			}
		}
		public String ViewChartSaleAnalysisStatisticName
		{
			get{return _viewChartSaleAnalysisStatisticName;}
			set
			{
				if (value != this._viewChartSaleAnalysisStatisticName)
				{
				_viewChartSaleAnalysisStatisticName=value;
				}
			}
		}
		public String ViewChartSaleAnalysisStatisticCustomerGroup
		{
			get{return _viewChartSaleAnalysisStatisticCustomerGroup;}
			set
			{
				if (value != this._viewChartSaleAnalysisStatisticCustomerGroup)
				{
				_viewChartSaleAnalysisStatisticCustomerGroup=value;
				}
			}
		}
		public decimal ViewChartSaleAnalysisStatisticAnnualTotal
		{
			get{return _viewChartSaleAnalysisStatisticAnnualTotal;}
			set
			{
				if (value != this._viewChartSaleAnalysisStatisticAnnualTotal)
				{
				_viewChartSaleAnalysisStatisticAnnualTotal=value;
				}
			}
		}
		public String ViewChartSaleAnalysisStatisticTime
		{
			get{return _viewChartSaleAnalysisStatisticTime;}
			set
			{
				if (value != this._viewChartSaleAnalysisStatisticTime)
				{
				_viewChartSaleAnalysisStatisticTime=value;
				}
			}
		}
		public decimal ViewChartSaleAnalysisStatisticRevenues
		{
			get{return _viewChartSaleAnalysisStatisticRevenues;}
			set
			{
				if (value != this._viewChartSaleAnalysisStatisticRevenues)
				{
				_viewChartSaleAnalysisStatisticRevenues=value;
				}
			}
		}
		public decimal ViewChartSaleAnalysisStatisticProfit
		{
			get{return _viewChartSaleAnalysisStatisticProfit;}
			set
			{
				if (value != this._viewChartSaleAnalysisStatisticProfit)
				{
				_viewChartSaleAnalysisStatisticProfit=value;
				}
			}
		}
		public int ViewChartSaleAnalysisStatisticYear
		{
			get{return _viewChartSaleAnalysisStatisticYear;}
			set
			{
				if (value != this._viewChartSaleAnalysisStatisticYear)
				{
				_viewChartSaleAnalysisStatisticYear=value;
				}
			}
		}
		public String ViewChartSaleAnalysisStatisticKey
		{
			get{return _viewChartSaleAnalysisStatisticKey;}
			set
			{
				if (value != this._viewChartSaleAnalysisStatisticKey)
				{
				_viewChartSaleAnalysisStatisticKey=value;
				}
			}
		}
		#endregion
	}
}