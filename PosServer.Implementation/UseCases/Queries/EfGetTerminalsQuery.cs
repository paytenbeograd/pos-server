using Microsoft.EntityFrameworkCore;
using PosServer.DataAccess;
using PosServer.Application;
using PosServer.Application.Exceptions;
using PosServer.Application.UseCases.Dto;
using PosServer.Application.UseCases.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosServer.Implementation.UseCases.Queries
{
    public class EfGetTerminalsQuery : IGetTerminalsQuery
    {
        private readonly PosServerDbContext _context;

        public EfGetTerminalsQuery(
            PosServerDbContext context)
        {
            _context = context;
        }

        public int Id => 1;

        public string Name => "Get terminals";

        public string Description => "Returns list of terminals in selected location (LocationCode).";

        public async Task<List<TerminalDto>> ExecuteAsync(SearchTerminalsDto request)
        {
            var location = await  _context.Locations
                                   .Include(x => x.Terminals)
                                   .AsNoTracking()
                                   .FirstOrDefaultAsync(x => x.LocationCode == request.LocationCode);

            if(location == null)
            {
                throw new EntityNotFoundException($"Lokacija sa identifikatorom {request.LocationCode} nije pronađena.");
            }

            var response = location.Terminals.Select(x => new TerminalDto
            {
                Tid = x.Tid,
                TerminalName = x.TerminalName
            }).ToList();

            return response;
        }
    }
}
