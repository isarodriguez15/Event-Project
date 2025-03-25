using Event__Project.Domains;

namespace Event__Project.Interfaces
{
    public interface IUsuariosRepository
    {
        void Cadastrar(Usuarios novoUsuario);

        Usuarios BuscarPorId(Guid id);

        Usuarios BuscarPorEmailESenha(string email, string senha);
    }
}
