using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    public partial class POOSItemsEntity
    {

        private List<APPOBOMItemsInfo> lstAPPOBOMItems;
        public List<APPOBOMItemsInfo> LstAPPOBOMItems
        {
            get { return lstAPPOBOMItems; }
            set { lstAPPOBOMItems = value; }
        }
        public POOSItemsEntity()
            : base()
        {

            LstAPPOBOMItems = new List<APPOBOMItemsInfo>();
        }

        
    }
}
