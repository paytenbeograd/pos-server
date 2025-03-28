using PosServer.Application.UseCases.Dto;
using PosServer.Application.UseCases.Queries;

namespace PosServer.Implementation.UseCases.Queries
{
    public class EfGetPaymentResponseQuery : IGetPaymentResponseQuery
    {
        public int Id => 3;

        public string Name => "Get payment response";

        public string Description => "Excute pay function and retrning respose to balkan bet.";

        public Task<PaymentResponseDto> ExecuteAsync(PaymentRequestDto request)
        {
            // upisi sve u bazu

            // posalji terminalu

            // upisi response sa terminala

            // vratipodatke

            throw new NotImplementedException();
        }
    }
}
