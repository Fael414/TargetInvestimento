using System;

namespace TargetInvestimento.Domain
{
    public class Cadastro_pessoa
    {
        public int Id { get; set; }

        public string NomeCompleto { get; set; }

        public DateTime DataNascimento { get; set; }

        public string CPF { get; set; }
        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string CEP { get; set; }

        public string Cidade { get; set; }
    
        public string UF { get; set; }
        public string Complemento { get; set; }

        public int Renda_mensal { get; set; }

        public DateTime DataCadastro{ get; set; } // Informação será retornada automaticamente ao concluir o cadastro

        public bool Cadastrado_PlanoVip { get; set; }
        public bool Oferecer_PlanoVip { get; set; } // A oferta só será feita se a renda for maior ou igual a  6k
        

    }
}
