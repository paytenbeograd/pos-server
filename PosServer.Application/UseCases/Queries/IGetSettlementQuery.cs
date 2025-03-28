
using PosServer.Application.UseCases.Dto;

namespace PosServer.Application.UseCases.Queries
{
    public interface IGetSettlementQuery : IQuery<SearchSettlementDto, List<SettlementDto>>
    {
    }
}
