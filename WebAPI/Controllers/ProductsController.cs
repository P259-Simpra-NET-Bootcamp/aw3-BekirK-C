using Business.Abstract;
using Entities.Concrete;
using Entities.Models.Requests;
using Entities.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private IProductService _productManager;

    public ProductsController(IProductService productManager)
    {
        _productManager = productManager;
    }

    [HttpGet("getall")]
    public List<ProductResponse> GetAll()
    {
        return _productManager.GetAll();
    }

    [HttpGet("{id}")]
    public ProductResponse GetById(int id)
    {
        return _productManager.GetById(id);
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody] ProductRequest request)
    {
        _productManager.Add(request);
        return Ok();
    }

    [HttpPost("update")]
    public IActionResult Update([FromBody] ProductRequest request)
    {
        _productManager.Update(request);
        return Ok();
    }

    [HttpPost("delete")]
    public IActionResult Delete([FromBody] int id)
    {
        _productManager.Delete(id);
        return Ok();
    }
}
