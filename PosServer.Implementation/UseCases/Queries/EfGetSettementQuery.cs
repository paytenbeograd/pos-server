using Microsoft.EntityFrameworkCore;
using PosServer.DataAccess;
using PosServer.Application.UseCases.Dto;
using PosServer.Application.UseCases.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosServer.Implementation.UseCases.Queries
{
    public class EfGetSettementQuery : IGetSettlementQuery
    {
        private readonly PosServerDbContext _context;

        public EfGetSettementQuery(
            PosServerDbContext context)
        {
            _context = context;
        }

        public int Id => 2;

        public string Name => "Get settlements";

        public string Description => "Returns list of Settlements for selected date.";

        public async Task<List<SettlementDto>> ExecuteAsync(SearchSettlementDto request)
        {
            string stringDateFrom = request.DateFrom.ToString("yyy.MM.dd");
            string stringDateTo = request.DateTo.ToString("yyy.MM.dd");

            var terminalsWhoDidSettlement = await _context.PaymentResponses
                                                          .Where(x => x.ResponceDateTime.StartsWith(stringDateFrom)
                                                                   && x.Total.StartsWith("[{"))
                                                          .Select(x => new SettlementDto
                                                          {
                                                              TID = x.TID,
                                                              Total = x.Total,
                                                              ResponceDateTime = x.ResponceDateTime
                                                          })
                                                          .ToListAsync();

            return terminalsWhoDidSettlement;
        }
    }
}
