
# 🛡️ RpgApi - DS - Aula 06 - Conexão com Banco de Dados
 - Atividade A09 (Desenvolvimento de Sistemas)

Este repositório contém a entrega da **Atividade A09** da disciplina de Desenvolvimento de Sistemas. A atividade teve como objetivo publicar uma API no servidor **Somee** com banco de dados remoto em SQL Server, além de comprovar o funcionamento com testes no **Postman**.

---

## 📂 Estrutura da Entrega

- Código-fonte da API (`RpgApi`)
- Pasta **`RespostaAtividadeA09`** contendo os seguintes prints:
  - Banco de dados criado e acessado remotamente
  - Website da API publicado no somee
  - Testes no Postman (`GET`, `POST`) com status 200
  - Select * via SQL Server Management Studio ou T-SQL Console do Somee

---

## ⚙️ Etapas Realizadas

1. 🔽 Baixamos o projeto base do GitHub
2. 🛠️ Abrimos e configuramos o projeto no VS Code
3. 🔐 Substituímos a **Connection String** no `appsettings.json` com os dados do banco do Somee
4. 🧱 Criamos o controller `WeatherForecastController.cs` com retorno de previsão do tempo (GET)
5. 📦 Geramos a pasta `publish` com `dotnet publish`
6. 📁 Compactamos os arquivos e subimos no painel do Somee
7. 🌐 Criamos o website e convertemos a pasta em aplicação via **IIS Application**
8. 🧪 Realizamos testes no navegador e Postman

---

## ⚠️ Problema Encontrado (Erro 500)

Mesmo após todos os passos corretamente seguidos, a API publicada retorna:
O erro 500, que permanece **ainda não resolvido** no ambiente de produção.
