using Microsoft.AspNetCore.Mvc;
using PosServer.Domain.Entities;
using PosServer.Implementation;
using PosServer.Application.UseCases.Dto;
using PosServer.Application.UseCases.Queries;

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
            var response = _useCaseHandler.HandleQueryAsync(query, request);

            return Ok(response);
        }

        [HttpPost("test")]
        public async Task<IActionResult> TestAsync()
        {
            return Ok("TEST");
        }

        [HttpGet("getSettlementInfo")]
        public async Task<IActionResult> GetSettlementInfo(
            [FromQuery]SearchSettlementDto request,
            [FromServices]IGetSettlementQuery query
            )
        {
            var response = await _useCaseHandler.HandleQueryAsync(query, request);

            return Ok(response);
        }
    }
}
