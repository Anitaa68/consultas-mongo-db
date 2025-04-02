using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gt")]
public class GtController : Controller {
    [HttpGet("listar-terreno")]
public IActionResult ListarMetrosTerreno (int metrosterreno){
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gt(x => x.MetrosTerreno, metrosterreno);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
}

[HttpGet("listar-costos")]
public IActionResult ListarCostos (int costos){
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gt(x => x.Costo, costos);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
}

[HttpGet("listar-pisos")]
public IActionResult ListarPisos (int pisos){
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gt(x => x.Pisos, pisos);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
}
}