using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Entities.Models.Requests;
using Entities.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private ICategoryService _categoryManager;

    public CategoriesController(ICategoryService categoryManager)
    {
        _categoryManager = categoryManager;
    }

    [HttpGet("getall")]
    public List<CategoryResponse> GetAll()
    {
        return _categoryManager.GetAll();
    }

    [HttpGet("getallwithinclude")]
    public List<CategoryResponse> GetAllWithInclude()
    {
        return _categoryManager.GetAllWithInclude();
    }

    [HttpGet("{id}")]
    public CategoryResponse GetById(int id)
    {
        return _categoryManager.GetById(id);
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody] CategoryRequest request)
    {
        _categoryManager.Add(request);
        return Ok();
    }

    [HttpPost("update")]
    public IActionResult Update([FromBody] CategoryRequest request)
    {
        _categoryManager.Update(request);
        return Ok();
    }

    [HttpPost("delete")]
    public IActionResult Delete([FromBody] int id)
    {
        _categoryManager.Delete(id);
        return Ok();
    }
}
