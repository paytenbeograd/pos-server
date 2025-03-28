namespace PosServer.Domain.Entities
{
    public class UseCase : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //public ICollection<UserUseCase> Users { get; set; } = new List<UserUseCase>();
    }
}
