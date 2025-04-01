using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller {
    [HttpGet("listar-pisos")]
   public IActionResult ListarPisos(){
    // listar todos los registros de los pisos

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    return Ok();
   }
}