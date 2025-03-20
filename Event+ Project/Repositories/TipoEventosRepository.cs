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
            TipoEventos tiposEventosBuscado = _context.TipoEventos.Find(id)!;

            if (tiposEventosBuscado != null)
            {
                tiposEventosBuscado.IdTipoEvento = tipoEvento.IdTipoEvento;
                tiposEventosBuscado.TituloEvento = tipoEvento.TituloEvento;

                _context.TipoEventos.Update(tiposEventosBuscado);
                _context.SaveChanges();
            }
        }

        public TipoEventos BuscarPorId(Guid id)
        {
            TipoEventos tiposEventoBuscado = _context.TipoEventos.Find(id)!;
            return tiposEventoBuscado;
        }

        public void Cadastrar(TipoEventos novoTipoEvento)
        {
            try
            {
                _context.TipoEventos.Add(novoTipoEvento);
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
                TipoEventos novoTipoEvento = _context.TipoEventos.Find(id)!;

                if (novoTipoEvento != null)
                {
                    _context.TipoEventos.Remove(novoTipoEvento);
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
            return _context.TipoEventos.ToList();
        }
    }
}
