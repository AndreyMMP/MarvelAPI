#PORTUGUÊS<br/>
Essa é uma reimplementação de alguns dos endpoints da [API da Marvel](https://developer.marvel.com/docs#!/public)
<br/>A aplicação está definida em arquitetura de camadas, onde cada camada possui uma responsábilidade.
<br/>Para a camada de visão do usuário foi utilizado ASP.NET Core WebAPI com Swagger.
<br/>Para a camada de negócios foi implementado o Repository Design Pattern.
<br/>Para a camada de acesso a dados foi utilizado Entity Framework Core.
<br/>Para a camada de testes unitários foi utilizado xUnit.
<br/><br/>

Endpoints implementados:<br/>
/v1/public/characters<br/>
/v1/public/characters/{characterId}<br/>
<br/>
Instruções para execução do projeto:<br/>
É necessário que uma instancia do Microsoft Sql Server esteja ativa e com acesso ao (localdb)\mssqllocaldb<br/>
Todas as dependencias, como database e inclusão de dados, serão realizadas pela própria aplicação<br/>
Por fim, defina MarvelAPI.Api como projeto de inicialização e execute o projeto<br/>
<br/><br/>
#ENGLISH<br/>
This is a reimplementation of some of the endpoints of the [Marvel's API](https://developer.marvel.com/docs#!/public)
<br/> The application is defined in layer architecture, where each layer has a responsibility.
<br/> For the user's view layer, ASP.NET Core WebAPI with Swagger was used.
<br/> The Repository Design Pattern was implemented for the business layer.
<br/> For the data access layer, Entity Framework Core was used.
<br/> For the unit testing layer, xUnit was used.
<br/> <br/>

Implemented endpoints: <br/>
/v1/public/characters<br/>
/v1/public/characters/{characterId}<br/>
<br/>
Instructions for executing the project: <br/>
It is necessary that an instance of Microsoft Sql Server be active and with access to (localdb)\mssqllocaldb <br/>
All dependencies, such as database and data inclusion, will be performed by the application <br/>
Finally, set MarvelAPI.Api as a startup project and run the project <br/>
<br/> <br/>
