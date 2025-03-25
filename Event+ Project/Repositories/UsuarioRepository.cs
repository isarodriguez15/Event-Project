using Event__Project.Contexts;
using Event__Project.Domains;
using Event__Project.Interfaces;
using EventPlus_.Utils;
using Microsoft.EntityFrameworkCore;

namespace Event__Project.Repositories
{
    public class UsuarioRepository : IUsuariosRepository
    {
        private readonly EventContext _context;

        public UsuarioRepository(EventContext context)
        {
            _context = context;
        }
        public Usuarios BuscarPorEmailESenha(string email, string senha)
        {
            try
            {
                Usuarios novoUsuarioBuscado = _context.Usuarios.FirstOrDefault(u => u.Email == email)!;

                if (novoUsuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, novoUsuarioBuscado.Senha!);

                    if (confere)
                    {
                        return novoUsuarioBuscado;
                    }
                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public Usuarios BuscarPorId(Guid id)
        {
            Usuarios novoUsuarioBuscado = _context.Usuarios.Find(id)!;
            return novoUsuarioBuscado;
        }

        public void Cadastrar(Usuarios novoUsuario)
        {
            try
            {
                _context.Usuarios.Add(novoUsuario);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
