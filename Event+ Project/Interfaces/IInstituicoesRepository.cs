using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Event__Project.Interfaces
{
    public interface IInstituicoesRepository
    {
        void Deletar(Guid id);

        Instituicoes BuscarPorId(Guid id);

        void Atualizar(Guid id, Instituicoes presenca);

        List<Instituicoes> Listar();

        List<Instituicoes> ListarMinhasInstituicoes(Guid id);

        void Inscrever(Instituicoes inscreverInstituicao);

    }

    public class Instituicoes
    {
        public object? IdInstituicao { get; internal set; }
        public object? NomeFantasia { get; internal set; }
    }
}


