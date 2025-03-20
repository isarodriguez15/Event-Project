using Event__Project.Contexts;
using Event__Project.Domains;
using Event__Project.Interfaces;

namespace Event__Project.Repositories
{
    public class ComentarioEventoRepository : IComentarioEventoRepository
    {

        private readonly EventContext _context;

        public ComentarioEventoRepository(EventContext context)
        {
            _context = context;
        }

        public ComentarioEvento BuscarIdUsuario(Guid UsuarioID, Guid EventosID)
        {
            try
            {
                ComentarioEvento comentarioEventoBuscado = _context.ComentarioEvento
                    .FirstOrDefault(c => c.IdUsuario == UsuarioID && c.IdEvento == EventosID)!;

                return comentarioEventoBuscado;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar o comentário do usuário no evento.", ex);
            }
        }

        public void Cadastrar(ComentarioEvento comentarioEvento)
        {

            try
            {
                _context.ComentarioEvento.Add(comentarioEvento);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid idComentario)
        {

            {
                ComentarioEvento comentarioEvento = _context.ComentarioEvento.Find()!;

                if (comentarioEvento != null)
                {
                    _context.ComentarioEvento.Remove(comentarioEvento);
                }
                _context.SaveChanges();
            }
        }

        public List<ComentarioEvento> Listar(Guid idComentario)
        {
            try
            {
                List<ComentarioEvento> listaDeComentarioEvento = _context.ComentarioEvento.ToList();
                return listaDeComentarioEvento;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
