using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PosServer.Application.UseCases.Commands;

using System.Threading.Tasks;
using PosServer.Application.UseCases.Dto;

namespace PosServer.Implementation.UseCases.Commands
{
    public class EfCreatePaymentRequestCommand : ICreatePaymentReqeustCommand
    {
        public int Id => 3;

        public string Name => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public Task ExecuteAsync(PaymentRequestDto request)
        {
            throw new NotImplementedException();
        }
    }
}
