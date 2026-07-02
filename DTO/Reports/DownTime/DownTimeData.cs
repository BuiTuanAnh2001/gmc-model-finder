using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DownTime
{
    public class DownTimeData
    {
        public List<DownTimePct> pct { get; set; }
        public List<DownTimeHour> hour { get; set; }
        public List<DownTimeResource> resource { get; set; }
        public List<DownTimeDetail> detail { get; set; }
        public List<DownTimeSum> sum { get; set; }

    }
}
