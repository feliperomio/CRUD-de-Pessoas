# Sistema de Cadastro de Pessoas - C# WinForms + MySQL

Este projeto consiste em um sistema CRUD de Pessoas completo desenvolvido com **C# (Windows Forms)** e banco de dados **MySQL**, permitindo o gerenciamento de registros com funcionalidades de cadastro, leitura, atualização e exclusão.

> Aplicação desktop focada em simplicidade, integração com banco de dados e experiência prática com WinForms.

## Objetivo

Crie uma aplicação desktop funcional que permita:
- Gerenciar registros de forma prática via interface gráfica
- Utilizar banco de dados real (MySQL) com conexão segura
- Servir como base de estudo para projetos maiores

## Tecnologias Utilizadas

 Tecnologia - C# / Windows Forms / MySql / MySql.Data (NuGet)    

## Funcionalidades

- Cadastro de registros
- Edição com atualização no banco
- Exclusão com confirmação
- Busca por ID
- Integração com MySQL

##  Estrutura da Tabela

```sql
CREATE TABLE Dados (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100),
    email VARCHAR(100),
    telefone VARCHAR(20),
    sexo VARCHAR(10)
);
