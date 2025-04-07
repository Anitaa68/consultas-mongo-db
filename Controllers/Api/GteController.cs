using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gte")]
public class GteController : Controller {
    [HttpGet("listar-banios")]
   public IActionResult ListarBanios(int banios){

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gte(x => x.Banios, banios);
    var list = collection.Find(filtro).ToList();
    return Ok(list);
   }
   
[HttpGet("listar-pisos")]
   public IActionResult ListarPisos(int pisos){

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gte(x => x.Pisos, pisos);
    var list = collection.Find(filtro).ToList();
    return Ok(list);
   }

[HttpGet("listar-fechas")]
public IActionResult ListarFechas (string fechapublicacion){
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gte(x => x.FechaPublicacion, fechapublicacion);
    var list = collection.Find(filtro).ToList();
    return Ok(list);
}

[HttpGet("listar-metrosterreno")]
   public IActionResult ListarMetrosTerreno(int metrosterreno){

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gte(x => x.MetrosTerreno, metrosterreno);
    var list = collection.Find(filtro).ToList();
    return Ok(list);
   }

[HttpGet("listar-metrosconstruccion")]
   public IActionResult ListarMetrosConstruccion(int metrosconstruccion){

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Gte(x => x.MetrosConstruccion, metrosconstruccion);
    var list = collection.Find(filtro).ToList();
    return Ok(list);
   }

}