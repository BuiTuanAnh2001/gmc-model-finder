using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPWOPlanInputData
    {
        public string AACreatedUser { get; set; }
        public string AAUpdatedUser { get; set; }
        public Nullable<DateTime> AACreatedDate { get; set; }
        public Nullable<DateTime> AAUpdatedDate { get; set; }
        public string PPWOPlanItemDesc { get; set; }
        public Nullable<DateTime> PPWOPlanItemDate { get; set; }
        public bool AASelected { get; set; }

        public int FK_PPWOPlanID { get; set; }
        public int FK_PPWOID { get; set; }
        public int FK_PPWOPItemID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_PPPhaseCfgGroupID { get; set; }

        public decimal PPWOPlanItemQty { get; set; }
        public decimal PPWOPlanItemRQty { get; set; }
        public decimal PPWOPlanItemExcQty { get; set; }
        public decimal PPWOPlanItemFact { get; set; }

        public int FK_ARSOID { get; set; }
        public int FK_ARSOItemID { get; set; }

        public decimal PPWOPlanItemVolumnFact { get; set; }
        public decimal PPWOPlanItemVTot { get; set; }

        public decimal PPWOPlanItemSQMFact { get; set; }
        public decimal PPWOPlanItemSQMTot { get; set; }

        public decimal PPWOPlanItemPkgCBMFact { get; set; }
        public decimal PPWOPlanItemPkgCBMTot { get; set; }

        public int FK_PPPhaseCfgID { get; set; }

        public decimal RQty { get; set; }
    }
}
