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
                PresencaeventosBuscado.Situacao = presenca.Situacao;
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
            try
            {
                inscreverPresenca.IdPresencaEvento = Guid.NewGuid();

                _context.PresencaEventos.Add(inscreverPresenca);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PresencaEventos> Listar()
        {
            try
            {
                List<PresencaEventos> listaPresenca = _context.PresencaEventos.ToList();
                return listaPresenca;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PresencaEventos> ListarMinhasPresencas(Guid id)
        {
            try
            {
                List<PresencaEventos> listaPresenca = _context.PresencaEventos.Where(p => p.IdUsuario == id).ToList();
                return listaPresenca;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
