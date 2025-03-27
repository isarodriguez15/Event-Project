using Event__Project.Contexts;
using Event__Project.Domains;
using Event__Project.Interfaces;

namespace Event__Project.Repositories
{
    public class TipoEventosRepository : ITipoEventosRepository
    {
        private readonly EventContext _context;

        public TipoEventosRepository(EventContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, TipoEventos tipoEvento)
        {
            TipoEventos tiposEventosBuscado = _context.TipoEvento.Find(id)!;

            if (tiposEventosBuscado != null)
            {
                tiposEventosBuscado.TituloEvento = tipoEvento.TituloEvento;

                _context.TipoEvento.Update(tiposEventosBuscado);
                _context.SaveChanges();
            }
        }

        public TipoEventos BuscarPorId(Guid id)
        {
            try
            {
                TipoEventos tiposEventoBuscado = _context.TipoEvento.Find(id)!;
                return tiposEventoBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(TipoEventos novoTipoEvento)
        {
            try
            {
                _context.TipoEvento.Add(novoTipoEvento);
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
                TipoEventos novoTipoEvento = _context.TipoEvento.Find(id)!;

                if (novoTipoEvento != null)
                {
                    _context.TipoEvento.Remove(novoTipoEvento);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TipoEventos> Listar()
        {
            try
            {
                List<TipoEventos> ListarEventos = _context.TipoEvento.ToList();
                return _context.TipoEvento.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
