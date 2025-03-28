using System.ComponentModel.DataAnnotations.Schema;

namespace PosServer.Domain.Entities
{
    [Table("tblAcqTotals")]
    public class AcqTotal : Entity
    {
        public string Tid { get; set; }
        public string TotalsDate { get; set; }
        public string Totals { get; set; }
        [Column("AcqTotalsStatus")]
        public int StatusId { get; set; }

    }
}
