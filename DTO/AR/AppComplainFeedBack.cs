using gmc_api.Entities;
using System;
using System.Collections.Generic;

namespace gmc_api.DTO.PP
{
    public class AppComplainFeedBack
    {
        public ARComplainFeedBacksInfo MainObject
        { get; set; } = new ARComplainFeedBacksInfo();
        public AppComplainFeedBackItem ItemObject { get; set; } = new AppComplainFeedBackItem();
        public List<AppComplainFeedBackItem> lstARComplainFeedBackItems
        { get; set; } = new List<AppComplainFeedBackItem>();
    }
}
