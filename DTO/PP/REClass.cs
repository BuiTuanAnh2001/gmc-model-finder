using System;
using System.Collections.Generic;
using gmc_api.Entities;

namespace gmc_api.DTO.PP
{
    #region Class RE
    public class REViewProductionOrdrEstFG:Entities.PPProductionOrdrEstFGs
    {
       public List<Entities.PPProductionOrdrEstFGs> lstSegment { get; set; } = new List<Entities.PPProductionOrdrEstFGs> ();
    }
    public class REnotifyProductionOrder
    {
        public List<string> errors { get; set; } = new List<string>();
        public bool success { get; set; }
    }
    public class APIAsync
    {
        public string MachineNo { get; set; }
        public string WorkOrderNo { get; set; }
        public string status { get; set; }
    }
    public class APIData
    {
        public string WinderNo { get; set; }
        public string RollNo { get; set; }
        public string MachineNo { get; set; }
        public string WorkOrderNo { get; set; }
        public DateTime? startTime { get; set; }
        public DateTime? Endtime { get; set; }
        public decimal RollLength { get; set; }
        public bool Warning { get; set; }
    }
    public class REProductionOrders
    {
        public Nullable<DateTime> scheduledEndTime { get; set; }
        public Nullable<DateTime> scheduledStartTime { get; set; }
        public Nullable<DateTime> actualEndTime { get; set; }
        public Nullable<DateTime> actualStartTime { get; set; }
        public string asetIdentifier { get; set; } = string.Empty;
        public string orderNumber { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
        public List<RERolls> rolls { get; set; } = new List<RERolls>();
        public REReport report { get; set; } = new REReport();
    }
    public class RERolls
    {
        public Nullable<DateTime> startTime { get; set; }
        public Nullable<DateTime> endTime { get; set; }
        public string name { get; set; } = string.Empty;
        public REReport report { get; set; } = new REReport();
    }
    public class REReport
    {
        public REReportValueQty totalEnergy { get; set; } = new REReportValueQty();
        public REReportValue totalLength { get; set; } = new REReportValue();
        public REReportValueQty totalMaterial { get; set; } = new REReportValueQty();
        public List<REOrderedExtruderConsumptions> orderedExtruderConsumptions { get; set; } = new List<REOrderedExtruderConsumptions>();
        public List<REproductionSpecificationCompliance> productionSpecificationCompliance { get; set; } = new List<REproductionSpecificationCompliance>();
    }
    public class REOrderedExtruderConsumptions
    {
        public string extruderNameSuffix { get; set; } = string.Empty;
        public REReportValueQty totalConsumption { get; set; } = new REReportValueQty();
    }
    public class REproductionSpecificationCompliance
    {
        public string propertyName { get; set; } = string.Empty;
        public decimal target { get; set; }
        public string mean { get; set; } = string.Empty;
    }
    public class REReportValue
    {
        public string value { get; set; }
        public string unit { get; set; }
    }
    public class REReportValueQty
    {
        public decimal value { get; set; }
        public string unit { get; set; }
    }
    #endregion
    #region ClassPLC
    public class PLCMachineData
    {
        public string ProductionOrderNo { get; set; } = string.Empty;
        public string WorkOrderNo { get; set; } = string.Empty;
        public string MachineNo { get; set; } = string.Empty;
        public string TagError { get; set; } = string.Empty;
        public Nullable<DateTime> Starttime { get; set; }
        public Nullable<DateTime> Endtime { get; set; }
    }
    #endregion
    #region ClassView
    public class ProductionFGFromProductionData
    {
        public ViewReportsInfo objDataTotal { get; set; }
        public List<PPProductionOrdrRMTotalsInfo> lstCreatFGPaperCut { get; set; }
        public List<PPProductionOrdrEstFGs> lstPPProductionOrdrEstFGFromPaperCuts { get; set; }
        public List<ICShipmentItems> lstRMPaperCut { get; set; }
    }
    #endregion
}
