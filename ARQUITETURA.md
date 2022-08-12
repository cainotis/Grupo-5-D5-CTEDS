# **MovieFinder**, Documento de arquitetura de software

### Introdução:

O MovieFinder é uma aplicação web que encontra para o usuário um filme dentre as plataformas legais de streamming.

### Tecnologias

Para evitar a falha do programa, será usado um Load Balancer, e multiplas instancias da aplicação.\
O front end será feito usando o ASP.NET Core (6.0), react. \
O back end será feito usando o ASP.NET Core (6.0).\
O banco de dados utilizado será o PostgreSQL.\
A ferramenta de busca utilizará uma das duas tecnologias a seguir:
- [ ] Crawler
- [ ] Api já existente

### Arquitetura
##### A arquitetura da aplicação é a seguinte:

![Diagrama da aplicação](/assets/ApplicationDiagram.jpeg "Diagrama da aplicação")

Como já dito anteriormente, a aplicação terá um Load Balancer, que será reponsável por encaminhar o usuário a uma instância da aplicação. Em seguida, o usuário fará requisições e receberá informações atravéz da interface web criada pelo front end. O back end é reponsável por toda a parte da aplicação que não é vista pelo usuário.\

Dentro do back end, existirá um web server que fará toda a comunicação e lógica do programa. Ao solicitar uma busca, o front end envia essa solicitação para o web server, que confere se esta informação já existe no banco de dados. Caso não exista, o web server acionará uma das tecnologias de busca, que vai retornar essa informação. Em posse da informação, o web server retorna a solicitação do front end, que a disponibiliza para o usuário.


##### Para o projeto final da disciplina, será feito um protótipo simplificado da aplicação. Sua arquitetura será do tipo:

![Diagrama do protótipo](/assets/PrototypeDiagram.jpeg "Diagrama do protótipo")

O protótipo funcionará de maneira similar à aplicação, porém sem o Load Balancer, e sendo capaz de procurar apenas em uma plataforma de streamming.

### Referências
https://litslink.com/blog/web-application-architecture/amp 