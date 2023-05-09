using Chapter_AtividadeSenai_UC14.Contexts;
using Chapter_AtividadeSenai_UC14.Interfaces;
using Chapter_AtividadeSenai_UC14.Models;

namespace Chapter_AtividadeSenai_UC14.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Sqlcontext _context;

        public UsuarioRepository(Sqlcontext context) 
        {
            _context = context;
        }

        public void Atualizar(int id, Usuario usuario)
        {
            Usuario usuarioBuscado = _context.Usuarios.Find(id);

            if (usuarioBuscado != null)
            {
                usuarioBuscado.Email = usuario.Email;
                usuarioBuscado.Senha = usuario.Senha;
                usuarioBuscado.Tipo = usuario.Tipo;

                _context.Usuarios.Update(usuarioBuscado);

                _context.SaveChanges();
            }
        }

        public Usuario BuscarPorId(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            _context.Usuarios.Add(novoUsuario);

            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario usuario = _context.Usuarios.Find(id);

            _context.Usuarios.Remove(usuario);

            _context.SaveChanges();

        }

        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario Login(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
