using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaClienteAPI.Modelo;

namespace PruebaClienteAPI.Controllers
{
    [Route("Carro")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        [HttpGet]
        [Route("listarCarros")]
        public dynamic ListarCarros()
        {
            List<Carro> carrosList = new List<Carro>()
            {
                new Carro
                {
                    id="1",
                    marca="Toyota",
                    modelo="Camry",
                    anio="2016",
                    color="Gris",
                },
                new Carro
                {
                    id ="2",
                    marca="Honda",
                    modelo="Civic",
                    anio="2018",
                    color="Rojo",
                },
                new Carro
                {
                    id ="3",
                    marca="Hyundai",
                    modelo="Tucson",
                    anio="2014",
                    color="Blanco",
                }
            };
            return carrosList;
        }

        [HttpPost]
        [Route("guardarCarro")]
        public dynamic guardarCarro(Carro carro)
        {

            carro.id = "4";
            return new
            {
                success = true,
                message = "Carro guardado",
                Results = carro
            };
        }

    }
}
