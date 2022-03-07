using System;
using System.Threading.Tasks;
using TargetInvestimento.Domain;

namespace TargetInvestimento.Persistence
{
    public interface ICadastroPessoaPersist
    {
        // Cadastro pessoa

        
        //Metodo para buscar os cadastros de pessoas que aderiram ao plano VIP frente ao total de cadastros
        Task<Cadastro_pessoa[]> GetAllCadastrosByCadastrado_PlanoVipAsync(bool Cadastrado_PlanoVip, int Renda_mensal);

        //Metodo para buscar os cadastros de  pessoas  entre duas datas de cadastro
        Task<Cadastro_pessoa[]> GetAllCadastrosByDataCadastroAsync(DateTime DataCadastro, DateTime DataInicio, DateTime DataFim);


        //Metodo para buscar os cadastros de  pessoas por valor minimo de Renda mensal informada
        Task<Cadastro_pessoa[]> GetAllCadastrosByRendaMensalAsync(int Renda_mensal);


    }
}