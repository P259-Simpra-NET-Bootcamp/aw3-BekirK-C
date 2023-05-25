using Business.Abstract;
using Entities.Concrete;
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
    public List<Product> GetAll()
    {
        return _productManager.GetAll();
    }

    [HttpGet("{id}")]
    public Product GetById(int id)
    {
        return _productManager.GetById(id);
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody] Product request)
    {
        _productManager.Add(request);
        return Ok();
    }

    [HttpPost("update")]
    public IActionResult Update([FromBody] Product request)
    {
        _productManager.Update(request);
        return Ok();
    }

    [HttpPost("delete")]
    public IActionResult Delete([FromBody] Product request)
    {
        _productManager.Delete(request);
        return Ok();
    }
}
