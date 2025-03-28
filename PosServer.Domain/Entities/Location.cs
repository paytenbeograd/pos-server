using System.ComponentModel.DataAnnotations.Schema;

namespace PosServer.Domain.Entities
{
    [Table("tblLocation")]
    public class Location : Entity
    {
        public string LocationName { get; set; }
        public string LocationCode { get; set; }
        [Column("LocationStatus")]
        public int? StatusId { get; set; }


        public virtual ICollection<Terminal> Terminals {get; set; } = new List<Terminal>();
        public virtual Status? Status { get; set; }
    }
}
