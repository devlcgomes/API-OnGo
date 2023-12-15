# ONGO API
Bem-vindo à documentação da API ONGO! Esta API foi desenvolvida para gerenciar informações relacionadas a clientes, produtos e inventário de itens. Utilizamos uma arquitetura bem estruturada, incluindo contexts, controllers, DTOs, helpers, interfaces, repositories, services, mappers, Entity Framework e PostgreSQL.

## Endpoints
A API ONGO possui os seguintes endpoints:

## 1. Clientes    
### 1.1 Listar Clientes
Endpoint: /api/Customer
Método: GET
Descrição: Retorna a lista de todos os clientes cadastrados.  

### 1.2 Obter Cliente por ID
Endpoint: /api/Customer/{id}
Método: GET
Descrição: Retorna as informações detalhadas de um cliente específico com base no ID.  


### 1.3 Adicionar Cliente
Endpoint: /api/Customer
Método: POST
Descrição: Adiciona um novo cliente. Os dados devem ser fornecidos no corpo da requisição como um DTO.  


### 1.4 Atualizar Cliente
Endpoint: /api/Customer/{id}
Método: PUT
Descrição: Atualiza as informações de um cliente específico com base no ID. Os dados devem ser fornecidos no corpo da requisição como um DTO.  


### 1.5 Excluir Cliente
Endpoint: /api/Customer/{id}
Método: DELETE
Descrição: Remove um cliente específico com base no ID.  




## 2.0 Produtos  
### 2.1 Listar Produtos
Endpoint: /api/Product
Método: GET
Descrição: Retorna a lista de todos os produtos cadastrados.  



### 2.2 Obter Produto por ID
Endpoint: /api/Product/{id}
Método: GET
Descrição: Retorna as informações detalhadas de um produto específico com base no ID.  



### 2.3 Adicionar Produto
Endpoint: /api/Product
Método: POST
Descrição: Adiciona um novo produto. Os dados devem ser fornecidos no corpo da requisição como um DTO.  


### 2.4 Atualizar Produto
Endpoint: /api/Product/{id}
Método: PUT
Descrição: Atualiza as informações de um produto específico com base no ID. Os dados devem ser fornecidos no corpo da requisição como um DTO.  


### 2.5 Excluir Produto
Endpoint: /api/Product/{id}
Método: DELETE
Descrição: Remove um produto específico com base no ID.  

## 3.0 Inventário de Itens 
### 3.1 Listar Itens do Inventário
Endpoint: /api/Inventory
Método: GET
Descrição: Retorna a lista de todos os itens no inventário.  


### 3.2 Obter Item do Inventário por ID
Endpoint: /api/Inventory/{id}
Método: GET
Descrição: Retorna as informações detalhadas de um item específico no inventário com base no ID.  


### 3.3 Adicionar Item ao Inventário
Endpoint: /api/Inventory
Método: POST
Descrição: Adiciona um novo item ao inventário. Os dados devem ser fornecidos no corpo da requisição como um DTO.  


### 3.4 Atualizar Item no Inventário
Endpoint: /api/Inventory/{id}
Método: PUT
Descrição: Atualiza as informações de um item específico no inventário com base no ID. Os dados devem ser fornecidos no corpo da requisição como um DTO.  


### 3.5 Excluir Item do Inventário
Endpoint: /api/Inventory/{id}
Método: DELETE
Descrição: Remove um item específico do inventário com base no ID.  


## Tecnologias Utilizadas
-> Entity Framework: Utilizamos o Entity Framework para mapeamento objeto-relacional e gerenciamento de banco de dados.  

-> PostgreSQL: O banco de dados utilizado é o PostgreSQL para armazenar os dados de forma segura e eficiente.  


## Estrutura do Projeto
-> A estrutura do projeto segue um padrão MVC (Model-View-Controller), utilizando conceitos como contexts, controllers, DTOs, helpers, interfaces, repositories, services e mappers para manter o código organizado e modular.  

## Não se esqueça de instalar o banco de dados e criar uma database com o nome ONGO.


