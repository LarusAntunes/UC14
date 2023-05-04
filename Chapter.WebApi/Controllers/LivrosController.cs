using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chapter.WebApi.Models;
using Chapter.WebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chapter.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;
        public LivrosController(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_livroRepository.Listar());
        }
        
        //get /api/livros/{id}
        [HttpGet("{id}")] //busca pelo id passado

        public IActionResult BuscarPorId(int id)
        {
            Livro livro = _livroRepository.BuscaPorId(id);
            if(livro ==null)
            {
                return NotFound();
            }
            return Ok(livro);
        }




    }
}