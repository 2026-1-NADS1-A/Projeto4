# FECAP - Fundação de Comércio Álvares Penteado

<p align="center">
  <img width="225" height="225" alt="Fecap_imagem" src="https://github.com/user-attachments/assets/24c0ce36-f452-400a-9a6b-e71baa5f05f4" />
</p>

## Messier Game Manager


## Grupo 4 / Projeto PI - Goats


**Integrantes:** [Cauã Santos Nascimento](https://www.linkedin.com/in/caua-nascimento/), [Pedro Henrique Santos da Silva](https://www.linkedin.com/in/pedrossilva15/), Paulo Miguel Miranda Marcelli, Gabriel Vaz Fereira Neves

**Professores Orientadores:** [Aimar Martins Lopes](https://www.linkedin.com/in/aimarlopes/), [Eduardo Savino Gomes](https://www.linkedin.com/in/eduardo-savino-gomes-77833a10/), [Lucy Mari Tabuti](https://www.linkedin.com/in/lucymari/), [Renata Muniz do Nascimento](https://www.linkedin.com/in/remuniz/), [Ronaldo Araujo Pinto](https://www.linkedin.com/in/ronaldo-araujo-pinto-3542811a/)

---


## Descrição

A Messier Data & Creative é uma empresa especializada no desenvolvimento de jogos e experiências interativas voltadas ao engajamento educacional.

Este projeto tem como objetivo desenvolver uma aplicação Desktop para gerenciamento de assinaturas de jogos educacionais por escolas. O sistema permite controlar pacotes contratados, validar IPs autorizados, registrar acessos e gerar relatórios de uso mensal.

## 🛠 Estrutura de pastas

---
````text
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
````

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

[Acesse Aqui](documentos/Entrega%201/Fundamentos%20de%20Banco%20de%20Dados/BD.png)

A documentação da modelagem física do banco de dados está disponível no link abaixo:

(https://github.com/2026-1-NADS1-A/Projeto4/blob/main/documentos/Entrega%202/BD/README.md)

---

<a href="https://github.com/2026-1-NADS1-A/Projeto4">Grupo 4</a> © 2026 by <a href="https://github.com/caua-nascto">Cauã Santos Nascimento, Pedro Henrique Santos da Silva, Paulo Miguel Miranda Marcelli, Gabriel Vaz Fereira Neves</a> is licensed under, Fecap <a href="https://creativecommons.org/licenses/by/4.0/">Creative Commons Attribution 4.0 International</a><img src="https://mirrors.creativecommons.org/presskit/icons/cc.svg" alt="" style="max-width: 1em;max-height:1em;margin-left: .2em;"><img src="https://mirrors.creativecommons.org/presskit/icons/by.svg" alt="" style="max-width: 1em;max-height:1em;margin-left: .2em;">

