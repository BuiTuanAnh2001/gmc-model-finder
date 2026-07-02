using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPWOPlanItemInputData
    {
        public int PPWOPlanItemID { get; set; }
        public int PPProductionCalendarID { get; set; }
        public bool AASelected { get; set; }
        public string AAStatus { get; set; }
        public Nullable<DateTime> PPProductionCalendarDate { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_PPWorkCenterID { get; set; }
        public int FK_PPRoutingID { get; set; }
        public decimal PPProductionCalendarQty { get; set; }
        public decimal PPProductionCalendarWSQty { get; set; }
        public decimal PPProductionCalendarFGQty { get; set; }
        public Nullable<DateTime> PPProductionCalendarFODate { get; set; }
        public int FK_PPWOID { get; set; }
        public int PPProductionCalendarWeek { get; set; }
        public int PPProductionCalendarPeriod { get; set; }
        public int PPProductionCalendarYear { get; set; }
        public int FK_ARShpPlanItemID { get; set; }
        public int FK_ARSOID { get; set; }
        public int FK_ARSOItemID { get; set; }
        public Nullable<DateTime> PPProductionCalendarPlanDate { get; set; }
        public string PPProductionCalendarLotNo { get; set; }
        public int FK_PPResourceID { get; set; }
        public int FK_PPShiftID { get; set; }
        public int FK_ICUOMID { get; set; }
        public int PPProductionCalendarPlanWeek { get; set; }
        public int FK_PPWORID { get; set; }
        public decimal PPProductionCalendarCQty { get; set; }
        public int PPProductionCalendarPlanYear { get; set; }
        public int PPProductionCalendarOrder { get; set; }
        public decimal PPProductionCalendarCWSQty { get; set; }
        public string PPProductionCalendarStatus { get; set; }
        public string PPProductionCalendarType { get; set; }

        public decimal PPProductionCalendarCAPQty { get; set; }
        public Nullable<DateTime> PPProductionCalendarEndDate { get; set; }
        public decimal PPProductionCalendarHourCAPQty { get; set; }

        public int FK_BRBranchID { get; set; }
        public decimal PPProductionCalendarPeopleQty { get; set; }
        public string AACreatedUser { get; set; }
        public string AAUpdatedUser { get; set; }
        public Nullable<DateTime> AACreatedDate { get; set; }
        public Nullable<DateTime> AAUpdatedDate { get; set; }
        public int FK_PPWOEstFGItemID { get; set; }
        public int FK_ICProductSpecID { get; set; }
        public int FK_ICProductFGID { get; set; }
        public int FK_ICProductRootID { get; set; }
        public int FK_PPWOPlanID { get; set; }
        public decimal PPProductionCalendarAllocateQty { get; set; }
        public decimal PPProductionCalendarAllocateRQty { get; set; }
        public int FK_PPWOPItemID { get; set; }
        public int FK_PPPhaseCfgGroupID { get; set; }
        public string PPProductionCalendarPOF01Combo { get; set; }
        public string PPProductionCalendarPOF02Combo { get; set; }
        public string PPProductionCalendarPOF03Combo { get; set; }
        public string PPProductionCalendarPOF04Combo { get; set; }
        public string PPProductionCalendarPOF05Combo { get; set; }
        public decimal PPProductionCalendarVolumnFact { get; set; }
        public decimal PPProductionCalendarVTot { get; set; }
        public decimal PPProductionCalendarSQMFact { get; set; }
        public decimal PPProductionCalendarSQMTot { get; set; }
        public decimal PPProductionCalendarPkgCBMFact { get; set; }
        public decimal PPProductionCalendarPkgCBMTot { get; set; }
        public decimal PPProductionOrdrEstFGQty { get; set; }
        public decimal PPProductionCalendarRQty { get; set; }
        public decimal PPProductionCalendarExcQty { get; set; }
        public decimal BOMQty { get; set; }
    }
}
