using Event__Project.Contexts;
using Event__Project.Domains;
using Event__Project.Interfaces;

namespace Event__Project.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        
        public EventoRepository(EventContext context)
        {
            _context = context;
        }
        
           private readonly EventContext _context;
        public void Atualizar(Guid id, Evento eventos) 
        {
            Evento EventoBuscado = _context.Eventos.Find(id)!;

            if (EventoBuscado != null)
            { 
                EventoBuscado.NomeEvento = eventos.NomeEvento;

                _context.Eventos.Update(EventoBuscado);
                _context.SaveChanges();
            }
        }
        
        public Evento BuscarPorId(Guid id)
        {
            Evento EventoBuscado = _context.Eventos.Find(id)!;
            return EventoBuscado;
        }

        public void Cadastrar(Evento eventos)
        {

            {
                _context.Eventos.Add(eventos);
                _context.SaveChanges();
            }
           
        }

        public void Deletar(Guid id)
        {

            {
                Evento eventos = _context.Eventos.Find(id)!;

                if (eventos != null)
                {
                    _context.Eventos.Remove(eventos);
                }
                _context.SaveChanges();
            }
            
        }

        public List<Evento> Listar()
        {

            try
            {
                List<Evento> listaEvento = _context.Eventos.ToList();
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
                List<Evento> listaEvento = _context.Eventos.Where(p => p.IdEvento == id).ToList();
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
                List<Evento> listarEventosProximos = _context.Eventos.Where(e => e.DataEvento > DateTime.Now).OrderBy(e => e.DataEvento).ToList();
                return listarEventosProximos;
            }

        }
    }
}
