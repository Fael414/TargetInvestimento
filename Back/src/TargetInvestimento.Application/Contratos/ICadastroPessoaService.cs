using System;
using System.Threading.Tasks;
using TargetInvestimento.Domain;

namespace Targetinvestimento.Application.Contratos
{
    public interface ICadastroPessoaService
    {
        Task<Cadastro_pessoa> AddCadastros(Cadastro_pessoa model);

        Task<Cadastro_pessoa> UpdateCadastros(int cadastroId, Cadastro_pessoa model);

        Task<Cadastro_pessoa> DeleteCadastros(int cadastroId);

        
        Task<Cadastro_pessoa[]> GetAllCadastrosByCadastrado_PlanoVipAsync(bool Cadastrado_PlanoVip, int Renda_mensal);

        Task<Cadastro_pessoa[]> GetAllCadastrosByDataCadastroAsync(DateTime DataCadastro, DateTime DataInicio, DateTime DataFim);

        Task<Cadastro_pessoa[]> GetAllCadastrosByRendaMensalAsync(int Renda_mensal);
    }
}