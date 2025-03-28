using System.ComponentModel.DataAnnotations.Schema;

namespace PosServer.Domain.Entities
{
    [Table("tblStatus")]
    public class Status : Entity
    {
        public string StatusDescription { get; set; }

        public ICollection<Location> Locations { get; set; } = new List<Location>();
        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<Terminal> Terminals { get; set; } = new List<Terminal>();
    }
}
