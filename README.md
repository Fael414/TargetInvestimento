# TargetInvestimentoApp - Implementar uma API C# que irá fazer onboarding e algumas consultas de novos clientes. 

Historinha 
TARGET vai lançar um novo app somente para investimentos chamado Target Investimento, 
com ele, o caminhoneiro vai poder comprar ativos da bolsa e brincar de 'trader'. 
Você será responsável por fazer endpoints relacionados ao onboarding e consultas dos novos 
clientes da TARGET Investimento Digital. 
 
Histórias 
Como desenvolvedor, gostaria de permitir o cadastro de novos clientes (Pessoa Física) 
informando seus dados. 
Requisito(s) 
1) Criar um método POST para solicitar os seguintes dados: 
Dados da Pessoa: NomeCompleto, DataNascimento, CPF. 
Dados do endereço da Pessoa: Logradouro, Bairro, CEP, Cidade, UF, Complemento. 
Dados financeiros da pessoa: Renda mensal. 
2) Retornar um Json com no mínimo os seguintes campos: 
Cadastrado (bool), OferecerPlanoVip (bool) 
3) Validar consistência dos dados informados pelo cliente. 
Obrigatória validação do CPF, se é no mínimo válido. 
Obrigatório em caso de mais de um dado inválido, informar para o cliente quais dados 
não foram válidos, para a devida correção. 
4) Necessário ter 2 métodos auxiliares, um para listar UFS e outro para listar Cidades 
dada UF, a fim de facilitar o preenchimento. 
É obrigatório fazer uma integração com API IBGE para isso. 
5) Para o banco de dados utilizado criar o modelo de dados e anexar no repositório todos 
os scripts SQL. 
 
 
Como PO, gostaria de oferecer nosso 'plano vip' no cadastro de novos clientes, quando a 
renda for igual ou superior a seis mil reais. 
Requisito(s) 
1) No método de cadastro de cliente. Se o cadastro for concluído com sucesso e, renda 
superior ou igual à 6k (Seis mil reais) 
Retornar campo 'OferecerPlanoVip' true 
2) Método GET para o app requisitar os detalhes do plano VIP. 
O conteúdo do plano vip deve ter no mínimo uma descrição e preço para o app exibir. O preço 
é de 50.00 (cinquenta reais mensais) a descrição ficou a sua escolha. 
O que o plano VIP proporciona segundo o PO: 'O plano vip vai possibilitar o cliente a ter um 
robô que avisará sobre tendências de investimentos, e sugerir a compra de ações de uma 
determinada empresa.' 
3) Método POST para o cliente confirmar que aceita o plano VIP. 
Como desenvolvedor, só irei permitir requests para aqueles que tenham api-key. 
Requisito(s) 
1) Criar scheme 'API-KEY' que deverá ser informado no header de cada request, se 'APIKEY' for inválida, retornar 401. 
Como gestor de investimento, gostaria de poder consultar os dados dos clientes dado uma 
janela de data do Cadastro. 
Requisito(s) 
1) Criar um método GET que irá listar todos os clientes cadastrados dada janela 'data do 
cadastro' (início / fim). 
 
Como gestor de investimento, gostaria de poder consultar clientes dado um valor mínimo de 
renda mensal. 
Requisito(s) 
1) Criar um método GET que irá listar todos os clientes com renda igual ou superior a 
informada. 
 
Como cliente, gostaria de poder editar meu endereço se por acaso eu informar algo errado e 
ou quiser atualizar. 
Requisito(s) 
1) Criar um método GET que retorne dados de endereço do cliente. 
2) Criar um método PUT para atualizar dados de endereço do cliente. 
Como analisa de KPI, gostaria de saber o índice GERAL de adesão do plano vip. 
Requisito(s) 
1) Criar um método GET que retornará o índice de adesão GERAL do plano VIP, para 
clientes que podem aderir ao plano VIP. 
Nome dos campos e response a sua escolha. 


## Sobre as versões lançadas

V 0.1 : Criação do projeto em NET CORE 5

V 0.2 : Criação do contexto, migrations e database

V 0.3 : Instalação do Angular e os primeiros passados dados ao frontend do projeto

V 0.4 : Criação de Navbar, Grid e alguns ajustes no layout do frontend


## Softwares necessários para rodar a aplicação


Em breve serão listados.


## Iniciar a aplicação

Para iniciar a aplicação, abra o local da pasta em um terminal, realize um split e digite em cada um dos terminais:

1°terminal:
cd back/src/TargetInvestimento.Api/ em seguida digite dotnet run

2°terminal:
cd front/TargetInvestimento-App em seguida digite ng serve