using Event__Project.Domains;

namespace Event__Project.Interfaces
{
    public interface IComentarioEventoRepository
    {
        void Cadastrar(ComentarioEvento comentarioEvento);  

        void Deletar(Guid idComentario);

        List<ComentarioEvento> Listar(Guid idComentario);

        ComentarioEvento BuscarIdUsuario(Guid UsuarioID, Guid EventosID);
    }
}
