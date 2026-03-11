# desafio03
Gerenciador de Tarefa

<img width="1816" height="839" alt="image" src="https://github.com/user-attachments/assets/6ba588a9-a313-4363-8d70-6065b729030a" />


Task Manager API

API REST desenvolvida em C# com .NET utilizando arquitetura em camadas, separando responsabilidades entre API, Application e Communication.

O objetivo da API é permitir o gerenciamento de tarefas, possibilitando criar, listar, buscar, atualizar e excluir tarefas, seguindo regras de validação e boas práticas de organização de código.

Tecnologias Utilizadas

C#

.NET / ASP.NET Core

Swagger / OpenAPI

Arquitetura em Camadas

Arquitetura do Projeto

O projeto foi organizado em três projetos principais, cada um com responsabilidades específicas.

TaskManager
│
├── TaskManager.API
│   ├── Controllers
│   ├── Program.cs
│   └── appsettings.json
│
├── TaskManager.Application
│   └── UseCases
│
└── TaskManager.Communication
    ├── Enum
    ├── Requests
    └── Responses
Camadas da Aplicação
TaskManager.API

Responsável pela exposição da API e comunicação com o cliente.

Contém:

Controllers → recebem requisições HTTP

Program.cs → configuração da aplicação

Swagger → documentação e testes dos endpoints

Essa camada não contém regras de negócio, apenas direciona as requisições para a camada de Application.

TaskManager.Application

Responsável pela lógica de negócio da aplicação.

Contém:

UseCases → implementações das ações do sistema, como:

Criar tarefa

Listar tarefas

Buscar tarefa por ID

Atualizar tarefa

Excluir tarefa

Essa camada centraliza as regras do sistema.

TaskManager.Communication

Responsável pelos contratos de comunicação da API.

Contém:

Requests → modelos de entrada da API

Responses → modelos de saída da API

Enum → enums utilizados na aplicação (Status, Priority)

Essa separação evita que os models internos vazem diretamente para a API.

Modelo de Tarefa
Campo	Tipo	Obrigatório	Restrições
id	GUID	Sim	Gerado automaticamente
name	string	Sim	Máximo de 100 caracteres
description	string	Não	Máximo de 500 caracteres
priority	string	Sim	high, medium, low
dueDate	DateTime	Sim	Data futura
status	string	Sim	pending, inProgress, completed
Validações

A API valida as seguintes regras:

Nome

obrigatório

máximo de 100 caracteres

Descrição

máximo de 500 caracteres

Data limite

não pode ser no passado na criação

Prioridade

valores permitidos:

high

medium

low

Status

valores permitidos:

pending

inProgress

completed

Endpoints
Método	Endpoint	Descrição
POST	/api/tasks	Criar uma nova tarefa
GET	/api/tasks	Listar todas as tarefas
GET	/api/tasks/{id}	Buscar tarefa por ID
PUT	/api/tasks/{id}	Atualizar tarefa
DELETE	/api/tasks/{id}	Excluir tarefa
Status Codes
Código	Descrição
200 OK	Operações de leitura e atualização
201 Created	Tarefa criada
204 No Content	Tarefa excluída
400 Bad Request	Dados inválidos
404 Not Found	Tarefa não encontrada
Executando o Projeto
Clonar o repositório
git clone https://github.com/seu-usuario/task-manager-api.git
Entrar na pasta
cd task-manager-api
Restaurar dependências
dotnet restore
Executar a API
dotnet run
Swagger

Após iniciar a aplicação, acesse:

https://localhost:{porta}/swagger

O Swagger permite:

visualizar os endpoints

testar requisições

verificar respostas da API

Funcionalidades

✔ Criar tarefas
✔ Listar tarefas
✔ Buscar tarefa por ID
✔ Atualizar tarefa
✔ Excluir tarefa
✔ Validação de dados
✔ Arquitetura em camadas
✔ Documentação com Swagger

💡 Observação:
Essa estrutura facilita manutenção, escalabilidade e testes, pois separa claramente:

API → comunicação

Application → regras de negócio

Communication → contratos de dados
