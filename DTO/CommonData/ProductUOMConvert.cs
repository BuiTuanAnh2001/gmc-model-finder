using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.CommonData
{
    public class ProductUOMConvert
    {
        public int stockDefault {get; set;}
        public int productId { get; set; }
        public List<ProductUOM> covert { get; set; }
    }
}
