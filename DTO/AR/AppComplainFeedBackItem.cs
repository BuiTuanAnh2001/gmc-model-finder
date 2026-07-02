using gmc_api.Entities;
using System;
using System.Collections.Generic;

namespace gmc_api.DTO.PP
{
    public class AppComplainFeedBackItem
    {
        public int ARComplainFeedBackItemID
        { get; set; }
        public Nullable<DateTime> ARComplainFeedBackItemDate
        { get; set; }
        public String ARComplainFeedBackItemDesc
        { get; set; } = string.Empty;
        public String AAStatus
        { get; set; } = "Alive";
        public Nullable<DateTime> AACreatedDate
        { get; set; }
        public String AACreatedUser
        { get; set; } = string.Empty;
        public Nullable<DateTime> AAUpdatedDate
        { get; set; }
        public String AAUpdatedUser
        { get; set; } = string.Empty;
        public int FK_HRSectionID
        { get; set; }
        public int FK_HREmployeeID
        { get; set; }
        public String ARComplainFeedBackItemStrategy
        { get; set; } = string.Empty;
        public String ARComplainFeedBackItemDetailReason
        { get; set; } = string.Empty;
        public Nullable<DateTime> ARComplainFeedBackItemConfirmCustomerDate
        { get; set; }
        public String ARComplainFeedBackItemConfirmationResult
        { get; set; } = string.Empty;
        public String ARComplainFeedBackItemPapers
        { get; set; }
        public int FK_ARComplainFeedBackID
        { get; set; }
        public int FK_ARErrorID
        { get; set; }
        public int FK_ARComplainItemID
        { get; set; }
        public int FK_ARSOID
        { get; set; }
        public int FK_ICProductID
        { get; set; }
        public int FK_ARCustomerID
        { get; set; }
        public Nullable<DateTime> ARComplainFeedBackItemRequestAnswerDate
        { get; set; }
        public int FK_ARGroupReasonID { get; set; }
        public int FK_ARReasonID { get; set; }
        public decimal ARComplainFeedBackItemCostIncurredAmt { get; set; }
        public decimal ARComplainFeedBackItemCostOtherAmt { get; set; }
        public int FK_ARComplainID { get; set; }
        public int FK_ARMappingGroupReasonID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public decimal ARComplainFeedBackItemErrorQty { get; set; }
        public decimal ARComplainFeedBackItemDoubtfulQty { get; set; }
        public bool ARComplainFeedBackItemConfirmChecked { get; set; }
        public int FK_ICUOMID { get; set; }
        public decimal ARComplainFeedBackItemHoldQty { get; set; }
        public decimal ARComplainFeedBackItemHoldConcessionQty { get; set; }
        public decimal ARComplainFeedBackItemHoldCQty { get; set; }
        public string ARComplainFeedBackItemLotNo { get; set; }
        public string ARComplainFeedBackItemBatchNo { get; set; }
        public string GLTOF01Combo { get; set; }
        public int FK_APSupplierID { get; set; }
        public string ARComplainFeedBackItemStatusCombo { get; set; }
        public List<ARComplainFeedBackImagesInfo> lstARComplainFeedBackImages
        { get; set; } = new List<ARComplainFeedBackImagesInfo>();

    }
}
