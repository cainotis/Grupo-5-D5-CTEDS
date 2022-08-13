# Grupo-5-D5-CTEDS
Atividade do modulo 5 do curso CTEDS

## Visão Geral
<div style="text-align: justify">  
O *MovieFinder* é uma aplicação web que permite o usuário inserir o nome de um filme e a aplicação retorna quais plataformas legais existem para assistir o filme desejado. Essa aplicação tem como público alvo pessoas que utilizam múltiplas plataformas de *streaming*, pensando principalmente em um público de 20 à 60 anos de idade.
</div>

## Organização do projeto
No presente repositório constam as entregas solicitadas pela disciplina D5 do curso CTEDS. As localizações dos arquivos das entregas em questão podem ser acessadas abaixo:

* [Documento com registro das reuniões](https://github.com/cainotis/Grupo-5-D5-CTEDS/blob/main/REGISTRO.md)
* [Arquivo de competências](https://github.com/cainotis/Grupo-5-D5-CTEDS/blob/main/COMPETENCIAS.md)
* [Documento de arquitetura](https://github.com/cainotis/Grupo-5-D5-CTEDS/blob/main/ARQUITETURA.md)
* [Documento com feedback fornecidos pela professora](https://github.com/cainotis/Grupo-5-D5-CTEDS/blob/main/FEEDBACK.md)
* [User stories](https://github.com/cainotis/Grupo-5-D5-CTEDS/issues#workspaces/cteds-grupo-5-62f1a57574399800164e77ec/board)

Algumas outras entregas solicitadas, como as tencologias utilizadas no projeto, encontram-se no presente arquivo.

## Tecnologias 

| Finalidade         | Tecnologia                        |
|--------------------|-----------------------------------|
| **Banco de Dados** | PostgreSQL                        |
| **Front End**      | ASP.NET Core, React               |
| **Back End**       | ASP.NET Core                      |

## O que o **MovieFinder** poderá fazer?

- Buscar nas plataformas de streaming: Essa busca será feita através de algumas ferramentas, optando por um api já existente para uma plataforma de streaming ou fazendo um crawler que recolhe informações de um site de busca (como o Google) e tratando os dados. Quando a busca for finalizada, os dados são salvos no banco de dados para futuras buscas.
- Buscar no banco de dados: O banco de dados interno da aplicação procura pelo filme desejado, caso não haja essa informação no banco, será buscado o filme e inserido no banco de dados para exibição.
 
## Protótipo

Abaixo temos o desenho do protótipo de baixa fidelidade

![Protótipo de baixa fidelidade](/assets/Prototipo_de_baixa_fidelidade.png "Protótipo de baixa fidelidade")

Foi feito também um protótipo de alta fidelidade com o figma, ele está disponível clicando [aqui](https://www.figma.com/file/rMVBBpQ9P3HtsG7iwqfv8o/MovieFinder?node-id=1%3A7).
