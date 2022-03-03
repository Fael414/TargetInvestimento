using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TargetInvestimento.API.Data;

namespace TargetInvestimento.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Cadastro_pessoaController : ControllerBase
    {

        private readonly DataContext context;

        public Cadastro_pessoaController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Cadastro_pessoa> Get()
        {
            return context.Cadastro_Pessoas;
        }

        [HttpGet("{id}")]
        public IEnumerable<Cadastro_pessoa> GetById(int id)
        {
            return context.Cadastro_Pessoas.Where(cadastro => cadastro.Cadastro_pessoaID == id);
        }

        [HttpPost]
        public IEnumerable<Cadastro_pessoa> Post()
        {
            return context.Cadastro_Pessoas;
        }

        [HttpPost("{id}")]
        public Cadastro_pessoa PostById(int id)
        {
            return context.Cadastro_Pessoas.FirstOrDefault(cadastro => cadastro.Cadastro_pessoaID == id);
        }

    }
}

