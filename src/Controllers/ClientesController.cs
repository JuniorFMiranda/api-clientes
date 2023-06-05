using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiClientes.Context;
using ApiClientes.Models;

namespace ApiClientes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteDbContext _context;

        public ClientesController(ClienteDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult Obter(int id)
        {
            var cliente = _context.Clientes.Find(id);

            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        [HttpGet]
        public IActionResult Obter()
        {
            var clientes = _context.Clientes.ToList();

            if (clientes.Count == 0)
                return NotFound();

            return Ok(clientes);
        }

        [HttpPost]
        public IActionResult Criar(Cliente cliente)
        {
            //TODO Adicionar validação para nome e documento vazios
            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return CreatedAtAction(nameof(Obter), new { Id = cliente.Id }, cliente);
        }
    }
}