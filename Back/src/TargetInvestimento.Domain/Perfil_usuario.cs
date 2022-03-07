namespace TargetInvestimento.Domain
{
    public class Perfil_usuario
    {
        public int Id { get; set; }
        
        public string login { get; set; } // Criar um validador de login unico na base

        public string senha { get; set; }

        public string CPF { get; set; } // Este CPF foi inserido como um validador do perfil. Se o usuário é um cliente cadastrado, ele verá a opção de editar seus dados

        public string perfil { get; set; } // Se o usuario é cliente, PO, Dev, Gestor de investimento, etc

    }
}