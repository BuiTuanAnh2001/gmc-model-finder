using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using gmc_api.Base.dto;

namespace gmc_api.DTO.ROProductionOrdr
{
	public class ARShpPlanItemsInfo
	{
		public int ARSOID { get; set; }
		public int FK_ARSOItemID { get; set; }
		public string ARSONo { get; set; }
		public Nullable<DateTime> ARShpPlanItemDueDate { get; set; }
		public int FK_ICProductID { get; set; }
		public string ICProductNo { get; set; }
		public string ICProductName { get; set; }
		public int FK_ICUOMID { get; set; }
		public string ICUOMNo { get; set; }
		public string ICUOMName { get; set; }
		public int FK_ICStkUOMID { get; set; }
		public string ICStkUOMNo { get; set; }
		public string ICStkUOMName { get; set; }
		public decimal ARShpPlanItemNTSQty { get; set; }
		public decimal ARShpPlanItemATSQty { get; set; }
		public decimal ARShpPlanItemHTSQty { get; set; }
		public decimal ARShpPlanItemFWInvQty { get; set; }
		public decimal ARShpPlanItemInvActual { get; set; }
		public decimal ARShpPlanItemQty { get; set; }
		public decimal ARShpPlanItemStkQty { get; set; }
		public int FK_ARCustomerID { get; set; }
		public string ARCustomerNo { get; set; }
		public string ARCustomerName { get; set; }
		public int ARShpPlanItemID { get; set; }
		public int FK_ARShpPlanID { get; set; }
		public decimal ARShpPlanItemUnitPrice { get; set; }
		public decimal ARShpPlanItemPkgCBM { get; set; }
		public Nullable<DateTime> ARShpPlanDueDate { get; set; }
        [Column(TypeName = "decimal(19, 12)")]
        public decimal ARShpPlanItemFact { get; set; }
		public string lotNo { get; set; }
		public int FK_ICStockID { get; set; }
		public int FK_HREmployeeID { get; set; }
		public int FK_BRBranchID { get; set; }
	}
}
