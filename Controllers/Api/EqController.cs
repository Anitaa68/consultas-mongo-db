using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller {
    [HttpGet("listar-pisos")]
   public IActionResult ListarPisos(int pisos){
    // listar todos los registros de los pisos

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.Pisos, pisos);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
   }

   [HttpGet("listar-agencias")]
   public IActionResult ListarAgencias(){
    // listar todos los registros de la agencia Inmboliaria Pérez

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.Agencia,"Inmobiliaria Pérez");
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
   }

   [HttpGet("listar-agente")]
   public IActionResult ListarAgente(){
    // listar todos los registros de la agente Ana Torres

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente,"Ana Torres");
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
   }

   [HttpGet("listar-operaciones")]
   public IActionResult ListarOperaciones(){
    // listar todos los registros de las operaciones de venta

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.Operacion,"Venta");
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
   }

   [HttpGet("listar-banios")]
   public IActionResult ListarBanios(int banios){
    // listar todos los registros de los baños de 2

    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Eq(x => x.Banios, banios);
    var lista = collection.Find(filtro).ToList();
    return Ok(lista);
   }
}