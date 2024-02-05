using Business.Abstracts;
using Business.Dtos.Requests.ExamQuestion;
using Business.Dtos.Requests.Question;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class QuestionsController : ControllerBase
{
    IQuestionService _questionService;

    public QuestionsController(IQuestionService questionService)
    {
        _questionService = questionService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateQuestionRequest createQuestionRequest)
    {
        var result = await _questionService.AddAsync(createQuestionRequest);
        return Ok(result);
    }

    [HttpPost("assigntoexam")] 
    public async Task<IActionResult> AssignToExam([FromBody] CreateExamQuestionRequest createExamQuestionRequest)
    {
        var result = await _questionService.AssignQuestionAsync(createExamQuestionRequest);
        return Ok(result);
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _questionService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpGet("get")]
    public async Task<IActionResult> Get([FromQuery] GetQuestionRequest getQuestionRequest)
    {
        var result = await _questionService.GetByIdAsync(getQuestionRequest);
        return Ok(result);
    }

    [HttpGet("getlistbyexamid")] 
    public async Task<IActionResult> GetListByExamId([FromQuery] PageRequest pageRequest, Guid examId)
    {
        var result = await _questionService.GetListByExamIdAsync(examId, pageRequest);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteQuestionRequest deleteQuestionRequest)
    {
        var result = await _questionService.DeleteAsync(deleteQuestionRequest);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateQuestionRequest updateQuestionRequest)
    {
        var result = await _questionService.UpdateAsync(updateQuestionRequest);
        return Ok(result);
    }
}
