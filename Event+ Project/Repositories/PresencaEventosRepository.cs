using Event__Project.Contexts;
using Event__Project.Domains;
using Event__Project.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Event__Project.Repositories
{
    public class PresencaEventosRepository : IPresencaEventosRepository
    {
        private readonly EventContext? _context;

        public PresencaEventosRepository(EventContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, PresencaEventos presenca)
        {
            PresencaEventos PresencaeventosBuscado = _context.PresencaEventos.Find(id)!;

            if (PresencaeventosBuscado != null)
            {
                PresencaeventosBuscado.NomePresencaeventos = presenca.NomePresencaeventos;
            }
        }

        public PresencaEventos BuscarPorId(Guid id)
        {

            PresencaEventos PresencaeventosBuscado = _context.PresencaEventos.Find(id)!;
            return PresencaeventosBuscado;
        }

        public void Deletar(Guid id)
        {
            {
                PresencaEventos Presencaeventos = _context.PresencaEventos.Find(id)!;

                if (Presencaeventos != null)
                {
                    _context.PresencaEventos.Remove(Presencaeventos);
                }
                _context.SaveChanges();
            }
        }

        public void Inscrever(PresencaEventos inscreverPresenca)
        {
            throw new NotImplementedException();
        }

        public List<PresencaEventos> Listar()
        {
            return _context.PresencaEventos.ToList();
        }

        public List<PresencaEventos> ListarMinhasPresencas(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
