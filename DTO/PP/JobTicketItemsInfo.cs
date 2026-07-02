namespace gmc_api.DTO.PP
{
    public class JobTicketItemsInfo
    {
        public int itemID { get; set; }
        public decimal qty { get; set; }
        public decimal rqty { get; set; }
        public string remark { get; set; }
        public int productId { get; set; }
        public string productNo { get; set; }
        public string productName { get; set; }
        public int phaseId { get; set; }
        public string phaseNo { get; set; }
        public string phaseName { get; set; }
        public string unit { get; set; }
        public int resourceId { get; set; }
        public string resourceNo { get; set; }
        public string resourceName { get; set; }
        public decimal dQty { get; set; }
        public string tof05Name { get; set; }
        public string tof05No { get; set; }
        public string oldCode { get; set; }
        public int FK_PPWOEstFGItemID { get; set; }
        public byte [] PPProductionOrdrEstFGBarCode { get; set; }
        public string PPProductionOrdrEstFGBarCodeNo { get; set; }
        public string PPProductionOrdrEstFGLotNo { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public string icstkUOMNo { get; set; }
        public decimal PPProductionOrdrEstFGStkQty { get; set; }
        public int FK_PPWOID { get; set; }
        public decimal PPProductionOrdrEstFGBarQty { get; set; }
        //public int FK_PPWOPlanID { get; set; }
        //public string PPWOPlanNo { get; set; }
        //public string PPWOPlanDesc { get; set; }
    }
}
