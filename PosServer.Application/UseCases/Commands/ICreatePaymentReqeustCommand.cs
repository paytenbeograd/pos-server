using PosServer.Application.UseCases.Dto;
using PosServer.Application.UseCases.Dto;

namespace PosServer.Application.UseCases.Commands
{
    public interface ICreatePaymentReqeustCommand : ICommand<PaymentRequestDto>
    {
    }
}
