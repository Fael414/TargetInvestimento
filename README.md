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

V.0.45 : Organização de multiplas camadas e novo migrations

## Checklist de pendência do escopo do projeto:

## Metodo Post para solicitar dados de cadastro:

O esqueleto do Post foi criado, porém o metodo não foi implementado

## Json com os campos de cadastrado e planovip
Não implementado

## Integração com API IBGE
Não implementado


## Metodo oferencendo o plano vip para os clientes com renda superior a 6k após o cadastro
Não implementado

## Metodo consultando clientes dado um valor minimo de renda mensal
Não implementado

## Metodo consultando clientes dado uma janela de data de cadastro
Não implementado


## Metodo onde o cliente consulta seus dados de endereço e atualiza caso queira 
Não implementado

## Metodo consultando adesão dos clientes que podem aderir ao plano vip
Não implementado



## Aplicações necessárias para rodar o projeto

Dotnet SDK 5.0.405 // https://dotnet.microsoft.com/en-us/download/dotnet/5.0
Node.Js: '12.16.3' // https://nodejs.org/dist/v12.16.3/
Angular CLI: 12.2.16 // https://www.npmjs.com/package/@angular/cli/v/12.2.16



## Iniciar a aplicação do projeto

Após as instalações necessárias, Para iniciar a aplicação, abra o local da pasta em um terminal, realize um split e digite em cada um dos terminais:

1°terminal:
cd back/src/TargetInvestimento.Api/ em seguida digite dotnet run

2°terminal:
cd front/TargetInvestimento-App em seguida digite ng serve

## Explicação do diagrama UML anexado ao projeto

O acesso ao sistema será permitido dado após criação do acesso com um login e senha, que está associado a tabela Perfil_usuário. Por default, todos os logins criados estarão associados ao perfil "Cliente", onde este pode utilizar o sistema de cadastro para cadastrar suas informações e consulta-las (Apenas poderá consultar e alterar os cadastros que forem criados pelo próprio perfil).

O perfil de "Desenvolvedor" dentro da tabela perfil de usuário, podera alterar o tipo de perfil_usuário de cada registro por fora da aplicação, quando solicitado

O perfil de Product Owner poderá consultar as informações referentes a KPI dentro da aplicação

O perfil de Gestor de investimento, poderá realizar consultar com base nas informações de renda mensal e data de cadastro de cada cliente registrado no sistema.

Todos os perfis de usuário podem realizar novos cadastros, o que difere cada um é a forma que estará disponivel de consulta de informações.

A tabela "Cadastro de pessoa" contem um formulario com informações a serem preenchidas para efetivação do cadastro.





