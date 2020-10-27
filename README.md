# ProjetoDB2

- Projeto para disciplina de **Banco de Dados II**, também tem o objetivo de ser um projeto base para C# sem utilizar o **Entity Framework**.


# Atenção: instruções para configurar o banco

- A configuração será feita pelo arquivo **config.json**



![configJSON](https://user-images.githubusercontent.com/22552633/97258945-68a67600-17f8-11eb-887b-b7bce85cae9f.png)






- Altere os parametros de acordo com o seu banco.
- **InitialCatalog** é o seu banco exemplo: **Northwind**.
- Se **RodarLocal**  estiver marcado como **"s"** não é necessário preencher os campos **User** nem **Password**. Altere o campo *Authentication* para **Windows Authentication**.

![Configurações](https://user-images.githubusercontent.com/22552633/97257856-df8e3f80-17f5-11eb-8da4-b69abbddc289.png)




- O arquivo **config.json** serve para montar uma __conection string__ para o SQL Server.
- Compilar o projeto.
- Mover o **Config.json** para a pasta **ProjetoBase.NET\ProjetoBase.NET\ProjetoBase.NET\bin\debug  ou \release**.
- Executar o projeto e test suas querys ;).




![Programa](https://user-images.githubusercontent.com/22552633/97258778-f5046900-17f7-11eb-819e-db6d4d988f60.png)





# OBS: 
- O arquivo **QueryPrincipal.sql** já contém uma Store Procedure e um exemplo da mesma. 
