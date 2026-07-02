using gmc_api.Entities;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.Base.dto
{
    public class RequestReceiptModule
    {
        public ICRequestReceipts MainObject { get; set; } = new ICRequestReceipts();
        public List<RequestReceiptItemsEntity> lstICRequestReceiptItems { get; set; } = new List<RequestReceiptItemsEntity>();
    }
}
