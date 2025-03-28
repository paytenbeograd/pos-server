using PosServer.Application.UseCases.Dto;

namespace PosServer.Application.UseCases.Queries
{
    public interface IGetPaymentResponseQuery : IQuery<PaymentRequestDto, PaymentResponseDto>
    {
    }
}