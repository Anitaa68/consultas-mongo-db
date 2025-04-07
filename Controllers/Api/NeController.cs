using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/ne")]
public class NeController : Controller {
   [HttpGet("listar-operaciones")]
   public IActionResult ListarOperaciones(string operacion){

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.Operacion, operacion);
    var list = collection.Find(filtro).ToList();
    return Ok(list);
}

[HttpGet("listar-tipos")]
   public IActionResult ListarTipos(string tipo){

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.Tipo, tipo);
    var list = collection.Find(filtro).ToList();
    return Ok(list);
}

[HttpGet("listar-patios")]
   public IActionResult ListarPatios(bool tienepatio){

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.TienePatio, tienepatio);
    var list = collection.Find(filtro).ToList();
    return Ok(list);
}

[HttpGet("listar-pisos")]
   public IActionResult ListarPisos(int pisos){

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.Pisos, pisos);
    var list = collection.Find(filtro).ToList();
    return Ok(list);
}

[HttpGet("listar-banios")]
   public IActionResult ListarBanios(int banios){

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.Banios, banios);
    var list = collection.Find(filtro).ToList();
    return Ok(list);
}
}