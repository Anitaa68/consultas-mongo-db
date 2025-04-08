using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/nin")]
public class NinController : Controller {
    [HttpGet("listar-tipos-casaterreno")]
   public IActionResult ListarTiposCasaTerreno(){
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

     List<string> tipo = new List<string>();
     tipo.Add("Casa");

     var filtroTipo = Builders<Inmueble>.Filter.Nin(x => x.Tipo, tipo);

     var list = collection.Find(filtroTipo).ToList();

    return Ok(list);
   }

   [HttpGet("listar-propiedades-agente")]
   public IActionResult ListarPropiedadesAgente(){
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

     List<string> agentes = new List<string>();
     agentes.Add("Ana Torres");
     agentes.Add("Juan Pérez");

     var filtroAgentes = Builders<Inmueble>.Filter.Nin(x => x.NombreAgente, agentes);

     var list = collection.Find(filtroAgentes).ToList();
     
    return Ok(list);
   }

    [HttpGet("listar-propiedades-agencia")]
   public IActionResult ListarPropiedadesAgencia(){
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

     List<string> agencia = new List<string>();
     agencia.Add("Inmobiliaria Pérez");
     agencia.Add("Torres Realty");

     var filtroAgencias = Builders<Inmueble>.Filter.Nin(x => x.Agencia, agencia);

     var list = collection.Find(filtroAgencias).ToList();
     
    return Ok(list);
   }

   [HttpGet("listar-propiedades-costos")]
   public IActionResult ListarPropiedadesCostos(){
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

     List<int> costo = new List<int>();
     costo.Add(33421);
     costo.Add(43141);

     var filtroCostos = Builders<Inmueble>.Filter.Nin(x => x.Costo, costo);

     var list = collection.Find(filtroCostos).ToList();
     
    return Ok(list);
   }

   [HttpGet("listar-metros-terreno")]
   public IActionResult ListarMetrosTerreno(){
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

     List<int> terreno = new List<int>();
     terreno.Add(518);
     terreno.Add(479);

     var filtroTerreno = Builders<Inmueble>.Filter.Nin(x => x.MetrosTerreno, terreno);

     var list = collection.Find(filtroTerreno).ToList();
     
    return Ok(list);
   }
}