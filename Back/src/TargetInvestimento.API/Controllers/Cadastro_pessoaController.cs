using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TargetInvestimento.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Cadastro_pessoaController : ControllerBase
    {
        public IEnumerable<Cadastro_pessoa> _Cadastro_pessoa = new Cadastro_pessoa[]{
                new Cadastro_pessoa(){
                    Cadastro_pessoaID= 1,
                    NomeCompleto = "Jose da Silva",
                    DataNascimento = "21/05/1990",
                    CPF = "11122233344" ,
                    Logradouro = "Rua dos bobos",
                    Bairro = "Taquara",
                    CEP= "12345678",
                    Cidade = "Rio de Janeiro",
                    UF = "RJ",
                    Complemento = "casa",
                    Renda_mensal = 5000,
                },
                new Cadastro_pessoa(){
                    Cadastro_pessoaID= 2,
                    NomeCompleto = "Lucas Mota",
                    DataNascimento = "08/09/1993",
                    CPF = "22233344455" ,
                    Logradouro = "Rua Visconde de Inhauma",
                    Bairro = "Centro",
                    CEP= "87654321",
                    Cidade = "Rio de Janeiro",
                    UF = "RJ",
                    Complemento = "Apt 201",
                    Renda_mensal = 8000,
                }
            };

        public Cadastro_pessoaController()
        {
        }

        [HttpGet]
        public IEnumerable<Cadastro_pessoa> Get()
        {
            return _Cadastro_pessoa;
        }

        [HttpGet("{id}")]
        public IEnumerable<Cadastro_pessoa> GetById(int id)
        {
            return _Cadastro_pessoa.Where(evento => evento.Cadastro_pessoaID == id);
        }
        // usando o postman, o professor deu exemplos com metodo Post
        [HttpPost]
        public IEnumerable<Cadastro_pessoa> Post()
        {
            return _Cadastro_pessoa;
        }

        [HttpPost("{id}")]
        public IEnumerable<Cadastro_pessoa> PostById(int id)
        {
            return _Cadastro_pessoa.Where(evento => evento.Cadastro_pessoaID == id);
        }

    }
}

