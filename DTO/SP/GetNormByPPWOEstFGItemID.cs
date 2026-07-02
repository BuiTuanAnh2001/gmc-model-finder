using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.SP
{
    public class GetNormByPPWOEstFGItemID
    {
        public int FK_ICFGProductID { get; set; }
        public string PPProductionOrdrEstRMFGLotNo { get; set; }
        public int FK_PPRoutingID { get; set; }
        public int FK_ARSOID { get; set; }
        public int FK_ARSOItemID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICProductParentID { get; set; }
        public string PPProductionOrdrEstRMDesc { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_PPWorkCenterID { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public decimal PPProductionOrdrEstRMQty { get; set; }
        public decimal PPProductionOrdrEstRMStkQty { get; set; }
        public decimal PPProductionOrdrEstRMRQty { get; set; }
        public int FK_ICWeightUOMID { get; set; }
        public int FK_ICVolumeUOMID { get; set; }
        public decimal PPProductionOrdrEstRMFact { get; set; }
        public int FK_PPWOID { get; set; }
    }
}
