using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PosServer.DataAccess;
using PosServer.Implementation;
using PosServer.Application.UseCases.Dto;
using PosServer.Application.UseCases.Queries;
using Serilog;

namespace PosServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Terminal : ControllerBase
    {
        private readonly PosServerDbContext _context;
        private readonly UseCaseHandler _useCaseHandler;

        public Terminal(
            PosServerDbContext context,
            UseCaseHandler handler)
        {
            _context = context;
            _useCaseHandler = handler;
        }

        [HttpGet]
        public async Task<IActionResult> GetTerminalsAsync(
            [FromQuery] SearchTerminalsDto reqeust,
            [FromServices]IGetTerminalsQuery query)
        {
            Log.Information("Usao u get terminals");

            var pom = _context.Terminals.FirstOrDefault();
            
            var response = await _useCaseHandler.HandleQueryAsync(query, reqeust);

            Log.Information("Izasao iz get terminals");

            return Ok(response);
        }
    }
}
