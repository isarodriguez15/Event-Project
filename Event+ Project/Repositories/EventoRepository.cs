 using Event__Project.Contexts;
using Event__Project.Domains;
using Event__Project.Interfaces;

namespace Event__Project.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly EventContext _context;

        public EventoRepository(EventContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, Evento eventos)
        {
            Evento EventoBuscado = _context.Evento.Find(id)!;

            if (EventoBuscado != null)
            {
                EventoBuscado.NomeEvento = eventos.NomeEvento;

                _context.Evento.Update(EventoBuscado);
                _context.SaveChanges();
            }
        }

        public Evento BuscarPorId(Guid id)
        {
            Evento EventoBuscado = _context.Evento.Find(id)!;
            return EventoBuscado;
        }

        public void Cadastrar(Evento eventos)
        {

            {
                _context.Evento.Add(eventos);
                _context.SaveChanges();
            }

        }

        public void Deletar(Guid id)
        {

            {
                Evento eventos = _context.Evento.Find(id)!;

                if (eventos != null)
                {
                    _context.Evento.Remove(eventos);
                }
                _context.SaveChanges();
            }

        }

        public List<Evento> Listar()
        {

            try
            {
                List<Evento> listaEvento = _context.Evento.ToList();
                return listaEvento;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<Evento> ListarPorId(Guid id)
        {

            try
            {
                List<Evento> listaEvento = _context.Evento.Where(p => p.IdEvento == id).ToList();
                return listaEvento;
            }
            catch (Exception)
            {
                throw;
            }


        }

        public List<Evento> ListarProximosEventos(Guid id)
        {

            {
                List<Evento> listarEventosProximos = _context.Evento.Where(e => e.DataEvento > DateTime.Now).OrderBy(e => e.DataEvento).ToList();
                return listarEventosProximos;
            }

        }
    }
}
