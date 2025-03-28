using System.ComponentModel.DataAnnotations.Schema;

namespace PosServer.Domain.Entities
{
    [Table("tblResponce")]
    public class PaymentResponse : Entity
    {
        public string ResponceDateTime { get; set; }

        public string UniqueTrans { get; set; }

        public string Username { get; set; }

        public string HardwareId { get; set; }

        public string TID { get; set; }

        public string SessionId { get; set; }

        public int? ResponceCode { get; set; }

        public string TerminalId { get; set; }

        public string SeqNumber { get; set; }

        public string TransactionType { get; set; }

        public string PrinterFlag { get; set; }

        public string CashierId { get; set; }

        public string TransactionNumber { get; set; }

        public string TransactionAmount1 { get; set; }

        public string AmountCurrency { get; set; }

        public string AuthorizationCode { get; set; }

        public string InputLabel { get; set; }

        public string InsurancePolicyNumber { get; set; }

        public string InstallmentsNumber { get; set; }

        public string LanguageID { get; set; }

        public string PrintData { get; set; }

        public string CashierId2 { get; set; }

        public string CashAmount { get; set; }

        public string PayServices { get; set; }

        public string BalanceInquiry { get; set; }

        public string OfflineCryptogram { get; set; }

        public string LoyaltyData { get; set; }

        public string TacData { get; set; }

        public string FormattedTextToPrint { get; set; }

        public string specificProcessingFlag { get; set; }

        public string TransactionFlag { get; set; }

        public string BatchNumber { get; set; }

        public string TransactionDate { get; set; }

        public string TransactionTime { get; set; }

        public string CardDataSource { get; set; }

        public string CardNumber { get; set; }

        public string TidNumber { get; set; }


        public string MidNumber { get; set; }

        public string CompanyName { get; set; }

        public string EmvData { get; set; }

        public string SignatureLine { get; set; }

        public string FullResponseCode { get; set; }

        public string TransactionStatus { get; set; }

        public string PINBlock { get; set; }

        public string CardholderName { get; set; }

        public string retrievalReferenceNumber { get; set; }

        public string displayMessage { get; set; }

        public string PinFlag { get; set; }

        public string dccStatus { get; set; }

        public string qrCodeData { get; set; }

        public string IPReferenceNumber { get; set; }

        public string PersonalVehicleCardData { get; set; }

        public string mifareCardType { get; set; }

        public string mifareCardUID { get; set; }

        public string F4Gcode { get; set; }

        public string radcomSpecificData { get; set; }

        public string AcquirerID { get; set; }

        public string Ticket { get; set; }

        public string InputData { get; set; }

        public string DccData { get; set; }
        public string Total { get; set; }
        public string TransDet { get; set; }

        [Column("ResponceStatus")]
        public int? StatusId { get; set; }


        public ICollection<Terminal> Terminals { get; set; } = new List<Terminal>();
        public virtual Status Status { get; set; }
    }
}
