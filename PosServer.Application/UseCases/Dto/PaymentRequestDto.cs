using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosServer.Application.UseCases.Dto
{
    public class PaymentRequestDto
    {
        public string UniqueTrans { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string HardwareId { get; set; } = string.Empty;
        public string TID { get; set; } = string.Empty;
        public string SessionId { get; set; } = string.Empty;

        // MESSAGE
        public string TerminalID { get; set; } = string.Empty;
        public string SourceId { get; set; } = string.Empty;
        public string SeqNumber { get; set; } = string.Empty;
        public string TransactionType { get; set; } = string.Empty;
        public string PrinterFlag { get; set; } = string.Empty;
        public string CashierID { get; set; } = string.Empty;
        public string TransactionNumber { get; set; } = string.Empty;
        public string TransactionAmount { get; set; } = string.Empty;
        public string AmountExponent { get; set; } = "+0";
        public string AmountCurrency { get; set; } = string.Empty;
        public string AuthorisationCodeForOfflineSale { get; set; } = string.Empty;
        public string InputLabel { get; set; } = string.Empty;
        public string InsurancePolicyNumber { get; set; } = string.Empty;
        public string InstallmentNumber { get; set; } = string.Empty;
        public string MinimumInputLength { get; set; } = string.Empty;
        public string MaximumInputLength { get; set; } = string.Empty;
        public string MaskInputData { get; set; } = string.Empty;
        public string LanguageID { get; set; } = string.Empty;
        public string PrintData { get; set; } = string.Empty;
        public string CashierIDExtended { get; set; } = string.Empty;
        public string CashAmount { get; set; } = string.Empty;
        public string Payservices { get; set; } = string.Empty;
        public string TacData { get; set; } = string.Empty;
        public string IPReferenceNumber { get; set; } = string.Empty;
        public string QRcodeData { get; set; } = string.Empty;
        public string SpecificProcessingFlag { get; set; } = string.Empty;
        public string RadcomData { get; set; } = string.Empty;
    }
}
