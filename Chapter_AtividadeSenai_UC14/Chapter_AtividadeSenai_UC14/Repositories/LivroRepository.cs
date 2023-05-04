using Chapter_AtividadeSenai_UC14.Contexts;
using Chapter_AtividadeSenai_UC14.Models;

namespace Chapter_AtividadeSenai_UC14.Repositories
{
    public class LivroRepository
    {
        private readonly Sqlcontext _context;
        public LivroRepository(Sqlcontext context) 
        {
            _context = context;
        }

        public List<Livro>  Listar() 
        {
            return _context.Livros.ToList();
        }

    }
}
