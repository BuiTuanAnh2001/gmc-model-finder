using gmc_api.Base.Helpers;
using System;

namespace gmc_api.DTO.PP
{
    public class ProdRstItemsUpdate
    {
        public int id { get; set; }
        public decimal qty { get; set; } = Constants.DEFAULT_VALUE_INT;
        public decimal cancelQty { get; set; } = Constants.DEFAULT_VALUE_INT;
        public decimal setUpQty { get; set; } = Constants.DEFAULT_VALUE_INT;
        public decimal NCRQty { get; set; } = Constants.DEFAULT_VALUE_INT;
        public decimal PPProductionOrdrEstFGDownTimeQty { get; set; } = Constants.DEFAULT_VALUE_INT;
        public decimal PPProductionOrdrEstFGWasteQty { get; set; } = Constants.DEFAULT_VALUE_INT;
        public string qcStatus { get; set; } = null;
        public string qcDescription { get; set; } = null;
        public string description { get; set; } = null;

        public byte[] PPProductionOrdrEstFGBarCode { get; set; }
        public string PPProductionOrdrEstFGBarCodeNo { get; set; }
        public string PPProductionOrdrEstFGSerialNo { get; set; }
        public string tof05Name { get; set; }
        public string tof05No{ get; set; }
        public Nullable<DateTime> PPProductionOrdrEstFGStarTime { get; set; }
        public Nullable<DateTime> PPProductionOrdrEstFGEndTime { get; set; }
        public int resourceId { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public decimal PPProductionOrdrEstFGStkQty { get; set; }
        public decimal PPProductionOrdrEstFGBarQty { get; set; }
        public string PPProductionOrdrEstFGPOF01Combo { get; set; } = string.Empty;
        public string PPProductionOrdrEstFGPOF02Combo { get; set; } = string.Empty;
        public string PPProductionOrdrEstFGPOF03Combo { get; set; } = string.Empty;
        public string PPProductionOrdrEstFGPOF04Combo { get; set; } = string.Empty;
        public string PPProductionOrdrEstFGPOF05Combo { get; set; } = string.Empty;
        public string PPProductionOrdrEstFGFGPOF01Combo { get; set; } = string.Empty;
        public string PPProductionOrdrEstFGFGPOF02Combo { get; set; } = string.Empty;
        public string PPProductionOrdrEstFGFGPOF03Combo { get; set; } = string.Empty;
        public string PPProductionOrdrEstFGFGPOF04Combo { get; set; } = string.Empty;
        public string PPProductionOrdrEstFGFGPOF05Combo { get; set; } = string.Empty;
    }
}
