using System;
using System.Text.Json.Serialization;

namespace gmc_api.Base.dto
{
    public class ICProductBasic
    {
        [JsonPropertyName("productId")]
        public int ICProductID { get; set; }
        [JsonPropertyName("productNo")]
        public string ICProductNo { get; set; }
        [JsonPropertyName("productName")]
        public string ICProductName { get; set; }
        [JsonPropertyName("uomID")]
        public int FK_ICStkUOMID { get; set; }
        [JsonPropertyName("uomNo")]
        public string ICUOMNo { get; set; }
        [JsonPropertyName("uomName")]
        public string ICUOMName { get; set; }
        public string ICProductSticker { get; set; }
        public string ICProductIOF01Combo { get; set; }
        public string ICProductIOF02Combo { get; set; }
        public string ICProductIOF03Combo { get; set; }
        public string ICProductIOF04Combo { get; set; }
        public string ICProductIOF05Combo { get; set; }
        public string ICProductIOF06Combo { get; set; }
        public string ICProductIOF07Combo { get; set; }
        public string ICProductIOF08Combo { get; set; }
        public string ICProductIOF09Combo { get; set; }
        public string ICProductIOF10Combo { get; set; }
        public string ICProductIOF11Combo { get; set; }
        public string ICProductIOF12Combo { get; set; }
        public string ICProductIOF13Combo { get; set; }
        public string ICProductIOF14Combo { get; set; }
        public string ICProductIOF15Combo { get; set; }
        //public string IOFName01 { get; set; }
        //public string IOFName02 { get; set; }
        //public string IOFName03 { get; set; }
        //public string IOFName04 { get; set; }
        //public string IOFName05 { get; set; }
        //public string IOFName06 { get; set; }
        //public string IOFName07 { get; set; }
        //public string IOFName08 { get; set; }
        //public string IOFName09 { get; set; }
        //public string IOFName10 { get; set; }
        //public string IOFName11 { get; set; }
        //public string IOFName12 { get; set; }
        //public string IOFName13 { get; set; }
        //public string IOFName14 { get; set; }
        //public string IOFName15 { get; set; }

    }
}
