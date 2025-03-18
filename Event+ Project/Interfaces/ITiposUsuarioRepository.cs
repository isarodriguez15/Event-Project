using Event__Project.Domains;

namespace Event__Project.Interfaces
{
    public interface ITiposUsuarioRepository
    {

        void Cadastrar(TiposUsuario tipoUsuario);

        List<TiposUsuario> Listar();

        void Atualizar(Guid id, TiposUsuario tipoUsuario);

        void Deletar(Guid id);

        TiposUsuario BuscarPorId(Guid id);
    }
}
