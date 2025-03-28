using Microsoft.AspNetCore.Mvc;
using PosServer.Domain.Entities;
using PosServer.Implementation;
using PosServer.Application.UseCases.Dto;
using PosServer.Application.UseCases.Queries;
using Serilog;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PosServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly UseCaseHandler _useCaseHandler;

        public PaymentController(
            UseCaseHandler useCaseHandler   )
        {
            _useCaseHandler = useCaseHandler;
        }

        [HttpPost("pay")]
        public async Task<IActionResult> PayAsync(
            [FromBody] PaymentRequestDto request,
            [FromServices] IGetPaymentResponseQuery query)
        {
            Log.Information("Usao u pay endpoint");

            var response = _useCaseHandler.HandleQueryAsync(query, request);

            Log.Information("Izlazim iz pay endpoint");

            return Ok(response);
        }

        [HttpGet("getSettlementInfo")]
        public async Task<IActionResult> GetSettlementInfo(
            [FromQuery]SearchSettlementDto request,
            [FromServices]IGetSettlementQuery query
            )
        {
            Log.Information("Usao u getSettlementInfo endpoint");

            var response = await _useCaseHandler.HandleQueryAsync(query, request);

            Log.Information("Izlazim iz getSettlementInfo endpoint");

            return Ok(response);
        }
    }
}
