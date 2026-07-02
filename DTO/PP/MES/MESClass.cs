using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using gmc_api.Entities;

namespace gmc_api.DTO.PP
{
    public class MESResourceEntities
    {
        public PPMESResources MainObject { get; set; } = new PPMESResources();
        public PPMESRolls RollObject { get; set; }
        public PPMESRolls SubRollObject { get; set; }
        public PPMESWastes WasteObject { get; set; }
        public PPMESDownTimes DownTimeObject { get; set; }
        public PPMESBoxs BoxObject { get; set; }
        public MESPalletItemEntity PalletObject { get; set; }
        public MESNCRItemEntity NCRObject { get; set; }
        public List<PPMESRolls> lstPPMESRolls { get; set; } = new List<PPMESRolls>();
        public List<PPMESWastes> lstPPMESWastes { get; set; } = new List<PPMESWastes>();
        public List<PPMESDownTimes> lstPPMESDownTimes { get; set; } = new List<PPMESDownTimes>();
        public List<PPMESBoxs> lstPPMESBoxs { get; set; } = new List<PPMESBoxs>();
        public List<MESPalletItemEntity> lstPPMESPallets { get; set; } = new List<MESPalletItemEntity>();
        public List<MESNCRItemEntity> lstPPMESNCRs { get; set; } = new List<MESNCRItemEntity>();
    }
    public class ScanRollMES
    {
        [Required]
        [JsonPropertyName("barcode")]
        public string PPProductionOrdrEstFGBarCodeNo { get; set; }
        [JsonPropertyName("barcodeSub")]
        public string PPProductionOrdrEstFGSubBarCodeNo { get; set; }
        public string PPProductionOrdrNo { get; set; } = string.Empty;
        public string PPResourceNo { get; set; } = string.Empty;
        public decimal PPMESRollSpeedQty { get; set; }
        public decimal PPMESRollSubSpeedQty { get; set; }
        public decimal PPMESRollBeatQty { get; set; }
        public decimal PPMESRollSubBeatQty { get; set; }
        public bool isSocketAPP { get; set; } = true;
    }
    public class SendRollMES
    {
        public string PPProductionOrdrNo { get; set; } = string.Empty;
        public string PPResourceNo { get; set; } = string.Empty;
        public decimal PPMESRollSpeedQty { get; set; }
        public decimal PPMESRollSubSpeedQty { get; set; }
        public decimal PPMESRollBeatQty { get; set; }
        public decimal PPMESRollSubBeatQty { get; set; }
        public decimal PPMESRollActQty { get; set; }
        public decimal PPMESRollSubActQty { get; set; }
        public decimal PPMESRollTotalCutQty { get; set; }
        public bool isSocketAPP { get; set; } = true;
    }
    public class CheckPwd
    {
        public string type { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
       
    }
    public class IP
    {
        public string ip { get; set; } = string.Empty;

    }
}
