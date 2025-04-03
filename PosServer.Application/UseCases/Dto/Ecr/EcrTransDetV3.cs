using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosServer.Application.UseCases.Dto.Ecr
{
    public class EcrTransDetV3
    {
        public string InvoiceNumber { get; set; }
        public string DateTime { get; set; }
        public string TransactionName { get; set; }
        public string Pan { get; set; }
        public string CardName { get; set; }
        public string ResponseCode { get; set; }
        public string CardDataSource { get; set; }
        public string ApprovalCode { get; set; }
        public string TransactionAmount { get; set; }
        public string CashAmount { get; set; }
        public string AmountCurrency { get; set; }
        public string InstallmentsNumber { get; set; }
        public string EMVData { get; set; }
        public string SignatureLine { get; set; }
        public string RRN { get; set; }
        public string PinFla { get; set; }
    }
}