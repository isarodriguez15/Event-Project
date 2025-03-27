using Event__Project.Contexts;
using Event__Project.Domains;
using Event__Project.Interfaces;
using static Event__Project.Repositories.TiposUsuarioRepository;

namespace Event__Project.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        private readonly EventContext _context;
     
        public TiposUsuarioRepository(EventContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, TiposUsuario tipoUsuario)
        {

            TiposUsuario tiposUsuarioBuscado = _context.TiposUsuario.Find(id)!;

            if (tiposUsuarioBuscado != null)
            {
                tiposUsuarioBuscado.TituloTipoUsuario = tipoUsuario.TituloTipoUsuario;

                _context.SaveChanges();
            }
        }

        public TiposUsuario BuscarPorId(Guid id)
        {

            TiposUsuario tiposUsuarioBuscado = _context.TiposUsuario.Find(id)!;
            return tiposUsuarioBuscado;
        }

        public void Cadastrar(TiposUsuario tipoUsuario)
        {
            try
            {
                _context.TiposUsuario.Add(tipoUsuario);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {

            try
            {
                TiposUsuario tiposUsuario = _context.TiposUsuario.Find(id)!;

                if (tiposUsuario != null)
                {
                    _context.TiposUsuario.Remove(tiposUsuario);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TiposUsuario> Listar()
        {
            try
            {
                List<TiposUsuario> listaDeUsuarios = _context.TiposUsuario.ToList();
                return listaDeUsuarios;
            }
            catch (Exception)
            {

                throw;
            }
          
        }
    }
}  

