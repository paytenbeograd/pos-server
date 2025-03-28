using System.ComponentModel.DataAnnotations.Schema;

namespace PosServer.Domain.Entities
{
    [Table("tblAccessLevel")]
    public class AccessLevel : Entity
    {
        public string AccessDescription { get; set; }
        [Column("AccessLevelStatus")]
        public int StatusId { get; set; }
    }
}
