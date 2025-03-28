using System.ComponentModel.DataAnnotations.Schema;

namespace PosServer.Domain.Entities
{
    [Table("tblLog")]
    public class LogEntity :Entity
    {
        public string LogDateTime { get; set; }
        public string LogTypeName { get; set; } 
        public string LogUsername { get; set; }
        public string LogDirection { get; set; }
        public string LogResult { get; set; }
        public string LogDescription { get; set; }
        public string LogSession { get; set; }
        [Column("LogStatus")]
        public int StatusId { get; set; }
    }
}
