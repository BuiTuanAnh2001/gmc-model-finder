//using gmc_api.Base.dto;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace gmc_api.Entities
//{
//    public class DrillDownChartSaleAnalysisStatistics
//    {
//        public DrillDownChartSaleAnalysisStatistics()
//        {

//        }

//        public DrillDownChartSaleAnalysisStatistics(String Module, DateTime DateFrom, DateTime DateTo, String Type, int iCustomerID, int iCustomerGroupID, int iProductID, int iProductGroupID, Boolean ExistProfit)
//        {
//            _module = Module;
//            _dateFrom = DateFrom;
//            _dateTo = DateTo;
//            _type = Type;
//            _fk_ARCustomerID = iCustomerID;
//            _fk_ARCustomerGroupID = iCustomerGroupID;
//            _fk_ICProductID = iProductID;
//            _fk_ICProductGroupID = iProductGroupID;
//            _existProfit = ExistProfit;
//        }

//        public String _module;
//        public DateTime _dateFrom;
//        public DateTime _dateTo;
//        public String _type;
//        public int _fk_ARCustomerID;
//        public int _fk_ARCustomerGroupID;
//        public int _fk_ICProductID;
//        public int _fk_ICProductGroupID;
//        public Boolean _existProfit;
//        public String _viewNo;
//        public String _viewName;

//        public String ViewNo
//        {
//            get { return _viewNo; }
//            set { _viewNo = value; }
//        }
//        public String ViewName
//        {
//            get { return _viewName; }
//            set { _viewName = value; }
//        }
//        public String Module
//        {
//            get { return _module; }
//            set { _module = value; }
//        }
//        public DateTime DateFrom
//        {
//            get { return _dateFrom; }
//            set { _dateFrom = value; }
//        }

//        public DateTime DateTo
//        {
//            get { return _dateTo; }
//            set { _dateTo = value; }
//        }
//        public String Type
//        {
//            get { return _type; }
//            set { _type = value; }
//        }
//        public int FK_ARCustomerID
//        {
//            get { return _fk_ARCustomerID; }
//            set { _fk_ARCustomerID = value; }
//        }
//        public int FK_ARCustomerGroupID
//        {
//            get { return _fk_ARCustomerGroupID; }
//            set { _fk_ARCustomerGroupID = value; }
//        }

//        public int FK_ICProductID
//        {
//            get { return _fk_ICProductID; }
//            set { _fk_ICProductID = value; }
//        }
//        public int FK_ICProductGroupID
//        {
//            get { return _fk_ICProductGroupID; }
//            set { _fk_ICProductGroupID = value; }
//        }
//        public Boolean ExistProfit
//        {
//            get { return _existProfit; }
//            set { _existProfit = value; }
//        }
//    }
//}
