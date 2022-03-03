using System;

namespace TargetInvestimento.API
{
    public class Cadastro_pessoa
    {
        public int Cadastro_pessoaID { get; set; }

        public string NomeCompleto { get; set; }

        public string DataNascimento { get; set; }

        public string CPF { get; set; }
        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string CEP { get; set; }

        public string Cidade { get; set; }
    
        public string UF { get; set; }
        public string Complemento { get; set; }

        public int Renda_mensal { get; set; }

        public bool Cadastrado_PlanoVip { get; set; }
        public bool Oferecer_PlanoVip { get; set; }
        

    }
}
