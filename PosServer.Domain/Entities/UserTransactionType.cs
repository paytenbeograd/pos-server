using System.Reflection.Metadata;

namespace PosServer.Domain.Entities
{
    public class UserTransactionType : Entity
    {
        public int UserId { get; set; }
        public int TransactionTypeId { get; set; }

        public User User { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}
