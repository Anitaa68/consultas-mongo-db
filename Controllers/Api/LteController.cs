using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/lte")]
public class LteController : Controller {
   [HttpGet("listar-metrosterreno")]
   public IActionResult ListarMetrosTerreno(int metrosterreno){

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosTerreno, metrosterreno);
    var list = collection.Find(filtro).ToList();
    return Ok(list);
    }

     [HttpGet("listar-metrosconstruccion")]
   public IActionResult ListarMetrosConstruccion(int metrosconstruccion){

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosConstruccion, metrosconstruccion);
    var list = collection.Find(filtro).ToList();
    return Ok(list);
    }

    [HttpGet("listar-fechas")]
public IActionResult ListarFechas (string fechapublicacion){
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.FechaPublicacion, fechapublicacion);
    var list = collection.Find(filtro).ToList();
    return Ok(list);
}

    [HttpGet("listar-costos")]
public IActionResult ListarCostos (int costo){
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.Costo, costo);
    var list = collection.Find(filtro).ToList();
    return Ok(list);
}

[HttpGet("listar-banios")]
   public IActionResult ListarBanios(int banios){

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.Banios, banios);
    var list = collection.Find(filtro).ToList();
    return Ok(list);
   }

}