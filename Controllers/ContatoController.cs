using ApiAula.Context;
using ApiAula.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiAula.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {

        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;

        }


        [HttpPost]
        public IActionResult Create(Contato contato)
        {

            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            _context.Add(contato);
            _context.SaveChanges();

            return CreatedAtAction(nameof(ObterId), new { id = contato.Id }, contato);
        }


        [HttpGet("{id:int:min(1)}")]
        public IActionResult ObterId(int id)
        {
            Contato contato = _context.Contatos.Where(x => x.Id == id).First();

            if (contato == null)
            {
                return NotFound();
            }

            return Ok(contato);
        }


        [HttpGet("{name:string:min(3)}")]
        public IActionResult ObterPorNome(string name)
        {

            var contato = _context.Contatos.Where(x => x.Nome.Contains(name));

            return Ok(contato);

        }





        [HttpPut("{id:int:min(1)}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatobanco = _context.Contatos.Where(x => x.Id == id).First();

            if (contatobanco == null && !ModelState.IsValid)
            {
                return NotFound();
            }

            contatobanco.Nome = contato.Nome;
            contatobanco.Telefone = contato.Telefone;
            contatobanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatobanco);
            _context.SaveChanges();

            return Ok(contatobanco);
        }


        [HttpDelete("{id:int:min(1)}")]
        public IActionResult Delete(int id)
        {
            var contato = _context.Contatos.Where(x => x.Id == id).First();
            _context.Remove(contato);
            _context.SaveChanges();

            return Ok(contato);
        }



    }
}