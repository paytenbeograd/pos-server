using System.ComponentModel.DataAnnotations.Schema;


namespace PosServer.Domain.Entities
{
    [Table("tblLogType")]
    public class LogType : Entity
    {
        public string LogTypeName { get; set; }
        [Column("LogTypeStatus")]
        public int StatusId { get; set; }
    }
}
