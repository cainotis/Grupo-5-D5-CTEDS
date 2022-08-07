# **MovieFinder**, Documento de arquitetura de software

### Introdução:

O MovieFinder é uma aplicação web que encontra para o usuário um filme dentre as plataformas legais de streamming.

### Tecnologias

A aplicação usa o ASP .NET Core para o front e para o back end. Usa também o PostgreSQL como banco de dados.

### Arquitetura

![Imagem do fluxograma da arquitetura](/assets/fluxogramaArquitetura.png "Fluxograma da arquitetura")

O back end coordena toda a comunicação entre o usuário, atravéz do front end web, o banco de dados e o api de busca. \
Quando uma busca é solicitada pelo usuário, o back end confere se o objeto de busca existe no banco de dados. Caso exista, ele o retorna e apresenta para o usuário. Caso não exista, o back end aciona o api de busca web, obtem um novo objeto, o salva no banco de dados e retorna para o usuário.