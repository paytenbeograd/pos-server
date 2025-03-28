using System.ComponentModel.DataAnnotations.Schema;

namespace PosServer.Domain.Entities
{
    [Table("tblTransactionType")]
    public class TransactionType : Entity
    {
        [Column("TransactionType")]
        public string TransactionTypeName { get; set; }
        public string UserAccessLevel { get; set; }
        
        public ICollection<UserTransactionType> TransactionTypes { get; set; } = new List<UserTransactionType>();   
    }
}