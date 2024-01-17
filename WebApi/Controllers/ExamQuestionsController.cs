using Business.Abstracts;
using Business.Dtos.Requests.ExamQuestion;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExamQuestionsController : ControllerBase
{
    IExamQuestionService _examQuestionService;

    public ExamQuestionsController(IExamQuestionService examQuestionService)
    {
        _examQuestionService = examQuestionService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateExamQuestionRequest createExamQuestionRequest)
    {
        var result = await _examQuestionService.AddAsync(createExamQuestionRequest);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _examQuestionService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteExamQuestionRequest deleteExamQuestionRequest)
    {
        var result = await _examQuestionService.DeleteAsync(deleteExamQuestionRequest);
        return Ok(result);
    }
}
