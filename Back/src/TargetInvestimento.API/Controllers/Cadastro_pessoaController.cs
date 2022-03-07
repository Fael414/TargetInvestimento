using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TargetInvestimento.Persistence;
using TargetInvestimento.Domain;

namespace TargetInvestimento.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Cadastro_pessoaController : ControllerBase
    {

        private readonly TargeInvestimentoContext context;

        public Cadastro_pessoaController(TargeInvestimentoContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Cadastro_pessoa> Get()
        {
            return context.Cadastro_Pessoas;
        }

        [HttpGet("{id}")]
        public IEnumerable<Cadastro_pessoa> GetByCPF(string cpf)
        {
            return context.Cadastro_Pessoas.Where(cadastro => cadastro.CPF == cpf);
        }

        [HttpGet("{DataCadastro}")]
        public IEnumerable<Cadastro_pessoa> GetbyDataCadastro(DateTime Datacadastro)
        // Retorno por data de cadastro. Falta implementar a "janela" entre datas
        {
            return context.Cadastro_Pessoas.Where(cadastro => cadastro.DataCadastro == Datacadastro);
        }

        [HttpPut("{id}")]
        public IEnumerable<Cadastro_pessoa> PutById(int id)
        // Metodo Put para atualizar endereço - Não implementado
        {
            return context.Cadastro_Pessoas.Where(cadastro => cadastro.Id == id);
        }

        [HttpPost]
        public IEnumerable<Cadastro_pessoa> Post()
        {
            return context.Cadastro_Pessoas;
        }

        [HttpPost("{id}")]
        public Cadastro_pessoa PostById(int id)
        {
            return context.Cadastro_Pessoas.FirstOrDefault(cadastro => cadastro.Id == id);
        }

    }
}

