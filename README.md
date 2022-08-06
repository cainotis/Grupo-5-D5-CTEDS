# Grupo-5-D5-CTEDS
Atividade do modulo 5 do curso CTEDS

## Visão Geral
<div style="text-align: justify">  
O *MovieFinder* é uma aplicação *web* que permite o usuário inserir o nome de um filme e a aplicação retorna quais plataformas legais existem para assistir o filme desejado. Essa aplicação tem como público alvo pessoas que utilizam múltiplas plataformas de *streaming*, pensando principalmente em um público de 20 à 60 anos de idade.
</div>

## Tecnologias 

| Finalidade         | Tecnologia                        |
|--------------------|-----------------------------------|
| **Banco de Dados** | PostgreSQL                        |
| **Front End**      | ASP.NET Core, React               |
| **Back End**       | ASP.NET Core                      |

## O que o **MovieFinder** pode fazer?
- Crawler: Inspeciona os resultados de busca de alguma *search engine* (ex: Google), e retorna os dados relevantes ao usuário, tal como plataformas disponíveis para ver o filme.

- Ferramenta de busca: O banco de dados interno da aplicação procura pelo filme desejado, caso não haja essa informação no banco, será buscado o filme e inserido no banco de dados para exibição.