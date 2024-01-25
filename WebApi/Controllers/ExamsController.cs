﻿using Business.Abstracts;
using Business.Dtos.Requests.Course;
using Business.Dtos.Requests.Exam;
using Business.Dtos.Requests.UserExam;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExamsController : ControllerBase
{
    private readonly IExamService _examService;
    public ExamsController(IExamService examService)
    {
        _examService = examService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateExamRequest examRequest)
    {
        var result = await _examService.AddAsync(examRequest);
        return Ok(result);
    }

    [HttpPost("AssignToUser")]
    public async Task<IActionResult> AssignToUser([FromBody] CreateUserExamRequest createUserExamRequest)
    {
        var result = await _examService.AssignExamAsync(createUserExamRequest);
        return Ok(result);
    }

    [HttpGet("Get")]
    public async Task<IActionResult> Get([FromQuery] GetExamRequest getExamRequest)
    {
        var result = await _examService.GetByIdAsync(getExamRequest);
        return Ok(result);
    }

    [HttpGet("GetListByUserId")]
    public async Task<IActionResult> GetListByUserIdAsync([FromQuery] PageRequest pageRequest, Guid userId)
    {
        var result = await _examService.GetListByUserIdAsync(userId, pageRequest);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        var result = await _examService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteExamRequest deleteExamRequest)
    {
        var result = await _examService.DeleteAsync(deleteExamRequest);
        return Ok(result);
    }
}
