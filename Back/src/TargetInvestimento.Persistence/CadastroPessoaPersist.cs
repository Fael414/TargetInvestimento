using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TargetInvestimento.Domain;

namespace TargetInvestimento.Persistence
{
    public class CadastroPessoaPersist : ICadastroPessoaPersist
    {
        private readonly TargeInvestimentoContext context;

        public CadastroPessoaPersist(TargeInvestimentoContext context)
        {
            this.context = context;

        }

        // Retornar todos os potenciais clientes do plano VIP e sua situação de cadastro
        public async Task<Cadastro_pessoa[]> GetAllCadastrosByCadastrado_PlanoVipAsync(bool Cadastrado_PlanoVip, int Renda_mensal)
        {
            IQueryable<Cadastro_pessoa> query = context.Cadastro_Pessoas;

            query = query.OrderBy(c => c.DataCadastro)
            .Where(c => c.Renda_mensal >= 6000);

            return await query.ToArrayAsync();
        }

        public async Task<Cadastro_pessoa[]> GetAllCadastrosByDataCadastroAsync(DateTime DataCadastro, DateTime DataInicio, DateTime DataFim)
        {
            IQueryable<Cadastro_pessoa> query = context.Cadastro_Pessoas;

            query = query.OrderBy(c => c.Id)
            .Where(c => c.DataCadastro > DataInicio && c.DataCadastro < DataFim);

            return await query.ToArrayAsync();
        }

        public async Task<Cadastro_pessoa[]> GetAllCadastrosByRendaMensalAsync(int Renda_mensal)
        {
            IQueryable<Cadastro_pessoa> query = context.Cadastro_Pessoas;
            query = query.OrderBy(c => c.Id);
            return await query.ToArrayAsync();
            // Esse metodo necessita de correção
        }
    }

}