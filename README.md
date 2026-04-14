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

## 🛠 Estrutura de pastas

---
```text
Raiz
|
|--> documentos
|   |--> antigos
|   |--> BD.pdf (Modelo Entidade-Relacionamento)
|   |--> Algoritmos_e_Lógica_de_Programação.pdf
|   |--> Regras_em_Lógica.pdf (Matemática Discreta)
|   |--> Redes_Entrega_1_PI.pdf (Logs e IPs)
|   |--> Modelagem_de_Software_Entrega_1.docx
|
|--> executáveis
|   |--> windows (Aplicação Messier Manager .exe)
|
|--> imagens
|   |--> DER_Peter_Chen.png (Modelo de Dados)
|   |--> Protótipos_Interface.png (Telas do Sistema)
|
|--> src
|   |--> App_Messier (Código fonte em C# / WinForms)
|   |--> Database (Scripts e banco SQLite)
|
|--> readme.md (Guia geral do projeto)

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

