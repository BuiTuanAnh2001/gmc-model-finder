using gmc_api.Base.dto;
using gmc_api.Base.Helpers;
using gmc_api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.Shipment
{
    public class ShipmentModule
    {
        public ICShipments MainObject { get; set; } = new ICShipments();
        public ShipmentItemsEntity ItemObject { get; set; } = new ShipmentItemsEntity();
        public List<ShipmentItemsEntity> lstICShipmentItems { get; set; } = new List<ShipmentItemsEntity>();
        public List<ICReceiptItemsInfo> lstICReceiptItems
        { get; set; } = new List<ICReceiptItemsInfo>();
        public List<ICShipmentPurchaseReturnsInfo> lstICShipmentPurchaseReturns { get; set; } = new List<ICShipmentPurchaseReturnsInfo>(); //link master trả hàng NCC
        public List<ICShipmentROs> lstICShipmentROs { get; set; } = new List<ICShipmentROs>(); //link master đề nghị nhập kho
        public PPProductionOrdrEstFGs objShipmentFG { get; set; }
        public List<PPProductionOrdrEstFGs> lstShipmentFG { get; set; } = new List<PPProductionOrdrEstFGs>();
        public List<ICShipmentPurchaseExchangesInfo> lstICShipmentPurchaseExchanges { get; set; }=new List<ICShipmentPurchaseExchangesInfo>(); //link master đề nghị đổi hàng
    }
}
