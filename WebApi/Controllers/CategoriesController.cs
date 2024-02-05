using Business.Abstracts;
using Business.Dtos.Requests.Category;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateCategoryRequest catRequest)
    {
        return Ok(await _categoryService.AddAsync(catRequest));
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        return Ok(await _categoryService.GetListAsync(pageRequest));
    }

    [HttpGet("get")]
    public async Task<IActionResult> Get(GetCategoryRequest getCategoryRequest)
    {
        return Ok(await _categoryService.GetByIdAsync(getCategoryRequest));
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(DeleteCategoryRequest deleteCategoryRequest)
    {
        return Ok(await _categoryService.DeleteAsync(deleteCategoryRequest));
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateCategoryRequest updateCategoryRequest)
    {
        return Ok(await _categoryService.UpdateAsync(updateCategoryRequest));
    }
}