using Event__Project.Domains;

namespace Event__Project.Interfaces
{
    public interface ITipoEventosRepository
    {

        List<TipoEventos> Listar();
        void Cadastrar(TipoEventos novoTipoEvento);

        void Atualizar(Guid id, TipoEventos tipoEvento);
        void Deletar(Guid id);

        TipoEventos BuscarPorId(Guid id);
    }
}
