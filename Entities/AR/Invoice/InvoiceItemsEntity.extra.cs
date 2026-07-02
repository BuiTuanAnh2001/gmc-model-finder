using ExpertLib;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    public partial class InvoiceItemsEntity 
    {
        #region List Object variables
        private List<ARInvoiceItemShipmentItemsInfo> _ARInvoiceItemShipmentItemsList;
        private List<ARInvoiceItemSaleOrderItemsInfo> _ARInvoiceItemSaleOrderItemsList;
        #endregion

        #region Constructor
        public InvoiceItemsEntity()
            : base()
        {
            _ARInvoiceItemShipmentItemsList = new List<ARInvoiceItemShipmentItemsInfo>();
            _ARInvoiceItemSaleOrderItemsList = new List<ARInvoiceItemSaleOrderItemsInfo>();
        }

        #endregion

        #region Public Properties

        public List<ARInvoiceItemShipmentItemsInfo> ARInvoiceItemShipmentItemsList
        {
            get
            {
                return _ARInvoiceItemShipmentItemsList;
            }
            set
            {
                _ARInvoiceItemShipmentItemsList = value;
            }
        }

        public List<ARInvoiceItemSaleOrderItemsInfo> ARInvoiceItemSaleOrderItemsList
        {
            get
            {
                return _ARInvoiceItemSaleOrderItemsList;
            }
            set
            {
                _ARInvoiceItemSaleOrderItemsList = value;
            }
        }


        #endregion
    }

}