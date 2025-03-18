using Event__Project.Domains;

namespace Event__Project.Interfaces
{
    public interface IEventoRepository
    {
        List<Evento> Listar();

        void Cadastrar(Evento eventos);

        void Atualizar (Guid id, Evento evento);

        void Deletar (Guid id);

        List<Evento> ListarPorId(Guid id);  

        Evento BuscarPorId(Guid id);

        List <Evento> ListarProximosEventos(Guid id);
    }
}
