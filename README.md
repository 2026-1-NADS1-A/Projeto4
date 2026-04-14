# FECAP - Fundação de Comércio Álvares Penteado

<p align="center">
  <img width="225" height="225" alt="Fecap_imagem" src="https://github.com/user-attachments/assets/24c0ce36-f452-400a-9a6b-e71baa5f05f4" />
</p>

## Nome do Projeto
Messier Game Manager

## Nome do Grupo
Grupo 4

**Integrantes:** Cauã Santos Nascimento, Pedro Henrique Santos da Silva, Paulo Miguel Miranda Marcelli, Gabriel Vaz Fereira Neves

**Professores Orientadores:** Eduardo Savino  

---

## Descrição

A Messier Data & Creative é uma empresa especializada no desenvolvimento de jogos e experiências interativas voltadas ao engajamento educacional.

Este projeto tem como objetivo desenvolver uma aplicação Desktop para gerenciamento de assinaturas de jogos educacionais por escolas. O sistema permite controlar pacotes contratados, validar IPs autorizados, registrar acessos e gerar relatórios de uso mensal.

---

## 🔄 Fluxo do Sistema

**Login:**  
A escola realiza autenticação, valida pacote ativo e IP autorizado.

**Catálogo:**  
Exibição dos jogos disponíveis conforme o pacote adquirido.

**Acesso:**  
Registro de acesso ao jogo, controle de limite mensal e bloqueio ao atingir o limite.

---

## 🎯 Objetivos

**Objetivo Geral:**  
Desenvolver uma aplicação Desktop com banco de dados relacional para gerenciar assinaturas de jogos educacionais.

**Objetivos Específicos:**
- Aplicar lógica de programação e algoritmos  
- Modelar banco de dados relacional  
- Implementar validações de acesso  
- Criar relatórios  
- Aplicar conceitos de redes (IP)  
- Utilizar lógica proposicional  

---

## 🧠 Lógica do Sistema


T ↔ (P ∧ Q ∧ R ∧ S)


Onde:
- P: Escola possui pacote ativo  
- Q: IP autorizado  
- R: Limite mensal não atingido  
- S: Jogo disponível  

---

## 🗄 Banco de Dados

Entidades principais:
- Escola  
- Pacote  
- Jogos  
- Acesso  
- Validação_IP  

Relacionamentos:
- Escola adquire pacote  
- Pacote contém jogos  
- Escola gera acessos  
- Acesso vinculado a jogo e IP  

Modelo baseado no padrão **Entidade-Relacionamento (Peter Chen)**.

---

## 🛠 Estrutura de pastas

-Raiz  
|  
|-->documentos  
 |-->antigos  
 |Documentacao.docx  
|-->executaveis  
 |-->windows  
|-->imagens  
|-->src  
 |-->Backend  
 |-->Frontend  
|readme.md  

A pasta raiz contém:

**README.MD:** Guia geral do projeto.

Pastas:
- **documentos:** documentação  
- **executaveis:** binários  
- **imagens:** imagens do sistema  
- **src:** código fonte  

---

## 🛠 Instalação

### Windows:
Não há instalação! Apenas executável.  
Execute o arquivo `.exe` na pasta executáveis.

---

## 💻 Configuração para Desenvolvimento

Para abrir este projeto você necessita das seguintes ferramentas:

- Visual Studio  
- .NET  


git clone (repositorio)
abrir no Visual Studio
executar projeto


---

## 📋 Licença/License

Este projeto utiliza a licença:  
https://chooser-beta.creativecommons.org/  

Creative Commons CC BY 4.0.

---

## 🎓 Referências

https://github.com/iuricode/readme-template  
https://github.com/gabrieldejesus/readme-model  
https://chooser-beta.creativecommons.org/  
https://www.toptal.com/developers/gitignore  

---

## 🚀 Considerações Finais

O projeto integra conceitos de banco de dados, programação, redes e engenhar
