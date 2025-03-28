using System.ComponentModel.DataAnnotations.Schema;

namespace PosServer.Domain.Entities
{
    public class User : Entity
    {
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        [Column("UserAccessLevel_AccessLevelId")]
        public int AccessLevelId { get; set; }
        [Column("UserStatus")]
        public int StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual AccessLevel AccessLevel { get; set; }
        //public ICollection<UserUseCase> UseCases { get; set; } = new List<UserUseCase>();
    }
}