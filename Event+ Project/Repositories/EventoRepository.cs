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
            return _context.Eventos.ToList();
        }

        public List<Evento> ListarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Evento> ListarProximosEventos(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
