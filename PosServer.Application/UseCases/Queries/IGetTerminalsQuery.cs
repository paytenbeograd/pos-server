
using PosServer.Application.UseCases.Dto;

namespace PosServer.Application.UseCases.Queries
{
    public interface IGetTerminalsQuery : IQuery<SearchTerminalsDto, List<TerminalDto>>
    {
    }
}
