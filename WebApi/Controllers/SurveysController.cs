﻿using Business.Abstracts;
using Business.Dtos.Requests.Survey;
using Business.Dtos.Requests.UserSurvey;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SurveysController : ControllerBase
{
    private readonly ISurveyService _surveyService;
    public SurveysController(ISurveyService surveyService)
    {
        _surveyService = surveyService;
    }
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateSurveyRequest surveyRequest)
    {
        var result = await _surveyService.AddAsync(surveyRequest);
        return Ok(result);
    }
    [HttpGet("Get")]
    public async Task<IActionResult> Get([FromQuery] GetSurveyRequest getSurveyRequest)
    {
        var result = await _surveyService.GetByIdAsync(getSurveyRequest);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        var result = await _surveyService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpGet("GetByUserId")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest, Guid userId)
    {
        var result = await _surveyService.GetByUserId(userId, pageRequest);
        return Ok(result);
    }

    [HttpPost("AssignUser")]
    public async Task<IActionResult> AssignLike([FromBody] CreateUserSurveyRequest createUserSurveyRequest)
    {
        var result = await _surveyService.AssignSurveyAsync(createUserSurveyRequest);
        return Ok(result);
    }


    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteSurveyRequest deleteSurveyRequest)
    {
        var result = await _surveyService.DeleteAsync(deleteSurveyRequest);
        return Ok(result);
    }
}
