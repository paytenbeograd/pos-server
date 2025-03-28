using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PosServer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosServer.DataAccess.Configurations
{
    public class PaymentResponseConfiguration : IEntityTypeConfiguration<PaymentResponse>
    {
        public void Configure(EntityTypeBuilder<PaymentResponse> builder)
        {
            throw new NotImplementedException();
        }
    }
}
