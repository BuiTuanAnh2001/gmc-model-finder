using System;
using System.Collections.Generic;

namespace gmc_api.Entities
{
    public partial class SaleReturnItemsEntity
    {
        #region List Object variables

        public List<ARSaleReturnItemInvoiceItemsInfo> _aRSaleReturnItemInvoiceItemsList;
        public List<ARSaleReturnItemShipmentItemsInfo> _aRSaleReturnItemShipmentItemsList;

        #endregion

        #region Constructor
        public SaleReturnItemsEntity()
            : base()
        {
            //TableName = "ARSaleReturnItems";
            _aRSaleReturnItemInvoiceItemsList = new List<ARSaleReturnItemInvoiceItemsInfo>();
            _aRSaleReturnItemShipmentItemsList = new List<ARSaleReturnItemShipmentItemsInfo>();
        }
        #endregion

        #region Public Properties

        public List<ARSaleReturnItemShipmentItemsInfo> ARSaleReturnItemShipmentItemsList
        {
            get { return _aRSaleReturnItemShipmentItemsList; }
            set { _aRSaleReturnItemShipmentItemsList = value; }
        }
        public List<ARSaleReturnItemInvoiceItemsInfo> ARSaleReturnItemInvoiceItemsList
        {
            get { return _aRSaleReturnItemInvoiceItemsList; }
            set { _aRSaleReturnItemInvoiceItemsList = value; }
        }

        #endregion
    }
}
