using Business.EmailSenderProcess;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MailsController : ControllerBase
{
    IEmailManager _emailManager;
    public MailsController(IEmailManager emailManager)
    {
        _emailManager = emailManager;
    }

    [HttpPost]
    public async Task<IActionResult> SendMail([FromBody] EmailMessageModel emailMessageModel)
    {
        return Ok(await _emailManager.SendMailAsync(emailMessageModel));
    }
}