using Calendar.ioWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;


namespace Calendar.ioWebAPI.Controllers
{
    public class CustomersController : Controller
    {
        //instanciando uma variavel do tipo listaDeClientes para fazer a lista em memória
        private static List<Customers> clientes = new List<Customers>();
        private static int idCliente = 0;


        [HttpPost]
        public IActionResult AdcionarCliente([FromBody] Customers cliente)
        {
            cliente.Id = idCliente++;
            clientes.Add(cliente);//adcionando um cliente a listaDeClientes
            return CreatedAtAction(nameof(SelecionarClientePorId), new { id = cliente.Id }, cliente);
        }

        [HttpGet("{id}")]
        public IActionResult SelecionarClientePorId(int id)// o retorno de IActionResult é o retorno de uma ação 
        {
            var cliente = clientes.FirstOrDefault(cliente => cliente.Id == id);//retorna o cliente com o mesmo id passado no parametro
            if (cliente == null) return NotFound();
            return Ok(cliente);
        }
    }
}
