using System.ComponentModel.DataAnnotations.Schema;

namespace PosServer.Domain.Entities
{
    [Table("tblPaymentRequest")]
    public class PaymentRequest : Entity
    {
        public int TerminalId { get; set; }
        public string Tid { get; set; }
        public DateTime CreatedAt { get; set; }
        public string SessionId { get; set; }
        public string UniqueTransactionId { get; set; } // wtf
        public string Username { get; set; } // wtf
        public string HardwareId { get; set; } // wtf
        public int SourceId { get; set; } // wtf
        public int SequesnceNumber { get; set; } //
        public int TransactionTypeId { get; set; }
        public string PrinterFlag { get; set; }
        public int CashierId { get; set; } // wtf

        public int TransactionNumber { get; set; }
        public decimal TransactionAmount { get; set; }

        public int AmountExponent { get; set; } // wtf
        public string AmountCurrency { get; set; }

        public string AuthorisationCodeForOfflineSale { get; set; }
        public string InputLabel { get; set; } 
        public string InsurancePolicyNumber { get; set; } // wtf
        public int InstallmentNumber { get; set; } // tip podatka, da li je potrebna kolona
        public int MinimumInputLength { get; set; }
        public int MaximumInputLength { get; set; }
        public int MaskInputData { get; set; }
        public int LanguageId { get; set; }
        public string PrintData { get; set; }
        public int CashierIdExtended { get; set; } // wtf
        public decimal TransactionAmount2 { get; set; } // wtf
        public string PayService { get; set; }
        public string TacData { get; set; }
        public string IpReference { get; set; }
        public string QrCodeData { get; set; }
        public string SpecificProcessingFlag { get; set; }
        public string RadcomData { get; set; } // wtf
        [Column("RequestStatusId")]
        public int StatusId { get; set; }

    }
}