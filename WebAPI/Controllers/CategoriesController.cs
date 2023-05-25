using Business.Abstract;
using Entities.Concrete;
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
    public List<Category> GetAll()
    {
        return _categoryManager.GetAll();
    }

    [HttpGet("{id}")]
    public Category GetById(int id)
    {
        return _categoryManager.GetById(id);
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody] Category request)
    {
        _categoryManager.Add(request);
        return Ok();
    }

    [HttpPost("update")]
    public IActionResult Update([FromBody] Category request)
    {
        _categoryManager.Update(request);
        return Ok();
    }

    [HttpPost("delete")]
    public IActionResult Delete([FromBody] Category request)
    {
        _categoryManager.Delete(request);
        return Ok();
    }
}
