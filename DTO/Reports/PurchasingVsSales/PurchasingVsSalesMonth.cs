using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.PurchasingVsSales
{
    public class PurchasingVsSalesMonth
    {
        public int DataYear { get; set; }
        public decimal DataAmtTot { get; set; }
        public decimal Data1AmtTot { get; set; }
        public decimal Data2AmtTot { get; set; }
        public decimal Data3AmtTot { get; set; }
        public decimal Data4AmtTot { get; set; }
        public decimal Data5AmtTot { get; set; }
        public decimal Data6AmtTot { get; set; }
        public decimal Data7AmtTot { get; set; }
        public decimal Data8AmtTot { get; set; }
        public decimal Data9AmtTot { get; set; }
        public decimal Data10AmtTot { get; set; }
        public decimal Data11AmtTot { get; set; }
        public decimal Data12AmtTot { get; set; }
    }
}
