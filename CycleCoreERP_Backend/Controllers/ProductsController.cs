using Microsoft.AspNetCore.Mvc;

namespace CycleCoreERP_Backend.Controllers;

[ApiController]
[Route("api/[Products]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetProducts()
    {
        // Beispiel-Daten
        var products = Array.Empty<Product>();

        return Ok(products);
    }

    [HttpPost]
    public IActionResult CreateProduct([FromBody] ProductDto product)
    {
        // Logik zum Speichern des Produkts
        return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
    }
}

public class ProductDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}
