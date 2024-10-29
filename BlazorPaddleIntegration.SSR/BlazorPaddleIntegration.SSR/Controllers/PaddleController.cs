using BlazorPaddleIntegration.SSR.ValueObjects;
using Microsoft.AspNetCore.Mvc;

namespace BlazorPaddleIntegration.SSR.Controllers
{
    [Route("api/paddle")]
    [ApiController]
    public class PaddleController : ControllerBase
    {
        [HttpPost("transaction-completed")]
        public async Task<IActionResult> TransactionCompletedAsync([FromBody] WebhookEvent webhookEvent, CancellationToken cancellationToken)
        {
            return Ok(webhookEvent.Data.CustomData);
        }
    }
}