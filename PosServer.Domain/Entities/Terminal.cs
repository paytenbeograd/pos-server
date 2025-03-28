using System.ComponentModel.DataAnnotations.Schema;


namespace PosServer.Domain.Entities
{
    [Table("tblTerminal")]
    public class Terminal : Entity
    {
        public string Tid { get; set; }
        public string TerminalName { get; set; }
        [Column("Terminal_LocationId")]
        public int LocationId { get; set; }
        public string IpAdress { get; set; }
        [Column("TerminalStatus")]
        public int StatusId { get; set; }
        public int Settlement {  get; set; }
        public string SettlementDate { get; set; }


        public virtual Location Location { get; set; }
        public virtual Status Status { get; set; }       
    }
}
