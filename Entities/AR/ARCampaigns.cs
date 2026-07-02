using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ARCampaigns")]
    public class ARCampaigns : FixFiveProps
    {
        [Key]
        public int ARCampaignID { get; set; }
        public Boolean AASelected { get; set; }
        public string ARCampaignNo { get; set; }
        public string ARCampaignDescription { get; set; }
        public Nullable<DateTime> ARCampaignStartDate { get; set; }
        public Nullable<DateTime> ARCampaignEndDate { get; set; }
        public string ARCampaignTypeCombo { get; set; }
        public string ARCampaignGroupCombo { get; set; }
        public int FK_GECurrencyID { get; set; }
        public decimal ARCampaignExRate { get; set; }
        public int FK_ICStockID { get; set; }
        public string ARCampaignName { get; set; }
        public string ARCampaignSituation { get; set; }
        public string ARCampaignObjective { get; set; }
        public string ARCampaignMechanism { get; set; }
        public string ARCampaignMethod { get; set; }
        public string ARCampaignRemark { get; set; }
        public string ARCampaignContent { get; set; }
        public string ARCampaignOperation { get; set; }
        public string ARCampaignStrategy { get; set; }
        public string ARCampaignOF01Combo { get; set; }
        public string ARCampaignOF02Combo { get; set; }
        public string ARCampaignOF03Combo { get; set; }
        public string ARCampaignOF04Combo { get; set; }
        public string ARCampaignOF05Combo { get; set; }
        public string ARCampaignOF06Combo { get; set; }
        public string ARCampaignOF07Combo { get; set; }
        public string ARCampaignOF08Combo { get; set; }
        public string ARCampaignOF09Combo { get; set; }
        public string ARCampaignOF10Combo { get; set; }
        public string ApprovalStatusCombo { get; set; }
        public Boolean ARCampaignIsAuto { get; set; }
        public string ARCampaignSaleTypeCombo { get; set; }
        public Nullable<DateTime> ARCampaignDate { get; set; }
        public decimal ARCampaignCostOnSale { get; set; }
        public string GLTOF01Combo { get; set; }
        public string GLTOF02Combo { get; set; }
        public string GLTOF03Combo { get; set; }
        public string GLTOF04Combo { get; set; }
        public string GLTOF05Combo { get; set; }
        public string GLTOF06Combo { get; set; }
        public string GLTOF07Combo { get; set; }
        public string GLTOF08Combo { get; set; }
        public string GLTOF09Combo { get; set; }
        public string GLTOF10Combo { get; set; }
        public string GLTOF11Combo { get; set; }
        public string GLTOF12Combo { get; set; }
        public string GLTOF13Combo { get; set; }
        public string GLTOF14Combo { get; set; }
        public string GLTOF15Combo { get; set; }
        public int FK_GLTranCfgID { get; set; }
        public int FK_ADApprovalProcID { get; set; }
        public Boolean ARCampaignActiveCheck { get; set; }

    }
}
