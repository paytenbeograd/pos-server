using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosServer.Application.UseCases.Dto.Ecr
{
    public class EcrTotalV3New
    {
        public string AcquirerIssuerName { get; set; }
        public string DebitTransactionCount { get; set; }
        public string DebitTransactionAmount { get; set; }
        public string RefundTransactionCount { get; set; }
        public string RefundTransactionAmount { get; set; }
        public string BatchNumber { get; set; }
        public string MoreMessages { get; set; }
        public string SpdhTerminalTotals { get; set; }
        public string SpdhHostTotals { get; set; }
        public string HostID { get; set; }
        public string AcquirerID { get; set; }
    }
}
