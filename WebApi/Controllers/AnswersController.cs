using Business.Abstracts;
using Business.Dtos.Requests.Answer;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnswersController : ControllerBase
{
    IAnswerService _answerService;
    public AnswersController(IAnswerService answerService)
    {
        _answerService = answerService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateAnswerRequest createAnswerRequest)
    {
        var result = await _answerService.AddAsync(createAnswerRequest);
        return Ok(result);
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _answerService.GetListAsync(pageRequest);
        return Ok(result);
    }
    [HttpGet("get")]
    public async Task<IActionResult> Get([FromQuery] GetAnswerRequest getAnswerRequest)
    {
        var result = await _answerService.GetByIdAsync(getAnswerRequest);
        return Ok(result);
    }
    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteAnswerRequest deleteAnswerRequest)
    {
        var result = await _answerService.DeleteAsync(deleteAnswerRequest);
        return Ok(result);
    }
    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateAnswerRequest updateAnswerRequest)
    {
        var result = await _answerService.UpdateAsync(updateAnswerRequest);
        return Ok(result);
    } 
    
    [HttpGet("getbyquestionid")]
    
    public async Task<IActionResult> GetListByQuestionId([FromQuery] PageRequest pageRequest, Guid questionId)
    {
        var result = await _answerService.GetListByQuestionIdAsync(pageRequest, questionId);
        return Ok(result);
    }
    
}