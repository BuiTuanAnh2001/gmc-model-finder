using System.Collections.Generic;

namespace gmc_api.DTO.IC
{
    public class CodeGenRequest
    {
        public int receiptId { get; set; }
        public List<int> receiptItemId { get; set; }
    }
}
