using Microsoft.EntityFrameworkCore;
using PosServer.Domain.Entities;

namespace PosServer.DataAccess
{
    public class PosServerDbContext : DbContext
    {
        public PosServerDbContext(
            DbContextOptions opetions = null) : base(opetions)
        {

        }

        public DbSet<AccessLevel> AccessLevels { get; set; }
        public DbSet<AcqTotal> AcqTotals { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LogEntity> Logs { get; set; }
        public DbSet<LogType> LogTypes { get; set; }
        public DbSet<PaymentRequest> PaymentRequests { get; set; }
        public DbSet<PaymentResponse> PaymentResponses { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        //public DbSet<UseCase> UseCases { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserTransactionType> UserTransactionTypes { get; set; }
    }
}
