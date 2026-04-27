# 🎵 ScreenSound: LINQ, APIs e Práticas de C#

Este repositório contém o desenvolvimento do projeto **ScreenSound**, realizado durante a formação de C# da **Alura**, além de um laboratório pessoal de experimentos práticos com **LINQ**. O foco principal é o consumo de dados reais via API e o processamento inteligente dessas informações.

## 🚀 O Projeto Principal

A aplicação consome um endpoint de músicas para realizar filtragens complexas, ordenação e exportação de dados.

### Funcionalidades:
- **Consumo de API:** Uso de `HttpClient` para buscar dados dinâmicos de um repositório remoto.
- **Filtros Avançados (LINQ):** - Listagem de gêneros musicais únicos.
  - Busca de artistas por gênero.
  - Filtro de músicas por tonalidade (ex: Músicas em C#).
- **Gerenciamento de Favoritos:** Criação de listas personalizadas e exportação para arquivos **JSON**.

---

## 🧪 Laboratório de Treino (Pasta `/Treino`)

Além do projeto principal, desenvolvi desafios extras para consolidar o domínio sobre consultas LINQ em diferentes contextos:

### 📚 Prática: Gestão de Livros
- **Foco:** Filtros temporais e ordenação.
- **Cenário:** Seleção de títulos publicados após o ano 2000, ordenados alfabeticamente usando `.Where()` e `.OrderBy()`.

### 🛒 Prática: Análise de Produtos
- **Foco:** Operações de agregação.
- **Cenário:** Cálculo de preço médio de uma lista de produtos utilizando o método `.Average()`.

---

## 🧠 Conceitos Técnicos Aplicados

- **LINQ (Language Integrated Query):** Uso extensivo de `.Where()`, `.Select()`, `.Distinct()`, `.OrderBy()` e `.Average()`.
- **Manipulação de JSON:** Uso da biblioteca `System.Text.Json` para Deserialização (leitura da API) e Serialização (geração do arquivo de favoritos).
- **Tratamento de Exceções:** Implementação de `try-catch` para lidar com possíveis falhas de conexão ou erros de API.
- **Lógica de Domínio:** Criação de *Getters* inteligentes para converter IDs numéricos em tonalidades musicais reais (C, C#, D, etc).

## 🛠️ Tecnologias

- **Linguagem:** C#
- **Plataforma:** .NET 6+ / Console Application
- **IDE:** Visual Studio Code

---

## 📂 Como Explorar

1. O código principal de execução está no `Program.cs`.
2. As classes de modelo e lógica de filtro estão organizadas em seus respectivos arquivos.
3. Os treinos rápidos podem ser encontrados na pasta `Treino`, acompanhados de exemplos de uso comentados.

---
*Desenvolvido por **Pedro Gustavo** como parte dos estudos de Backend em C#.*
