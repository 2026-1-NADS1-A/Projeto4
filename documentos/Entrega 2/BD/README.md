# Banco de Dados — Projeto Messier

## Objetivo

Este documento apresenta a modelagem física do banco de dados do Projeto Messier, desenvolvida com base no modelo conceitual e lógico previamente definidos pelo grupo.

O banco de dados foi modelado utilizando Oracle SQL, com o objetivo de armazenar e gerenciar informações relacionadas às escolas cadastradas, pacotes contratados, jogos educacionais, acessos realizados e validações de IP.

---


# Modelo Físico

<!-- INSERIR IMAGEM DO MODELO FÍSICO AQUI -->

Exemplo:

(https://github.com/2026-1-NADS1-A/Projeto4/blob/main/documentos/Entrega%202/BD/Modelo_fisico.sql)



---

# Modelo Lógico

<!-- INSERIR IMAGEM DO MODELO CONCEITUAL/LÓGICO AQUI -->

Exemplo:

<img width="1238" height="712" alt="Modelo_logico" src="https://github.com/user-attachments/assets/4035fa1e-18a1-43ff-ba96-fca792be374a" />


---


# Estrutura das Tabelas

## Tabela: ESCOLA

Responsável por armazenar os dados das escolas cadastradas no sistema.

| Campo | Tipo | Restrição |
|---|---|---|
| esc_id | NUMBER(10) | PRIMARY KEY NOT NULL |
| esc_nome | VARCHAR2(200) | NOT NULL |
| esc_email | VARCHAR2(50) | NOT NULL |
| esc_senha | VARCHAR2(100) | NOT NULL |
| esc_ativo | NUMBER(1) | NOT NULL |

---

## Tabela: PACOTE

Responsável por armazenar os pacotes disponíveis para contratação.

| Campo | Tipo | Restrição |
|---|---|---|
| pac_id | NUMBER(10) | PRIMARY KEY NOT NULL |
| pac_nome | VARCHAR2(200) | NOT NULL |
| pac_limite_mensal | NUMBER(5) | NOT NULL |
| pac_preco | NUMBER(6,2) | NOT NULL |

---

## Tabela: JOGOS

Responsável por armazenar os jogos educacionais do sistema.

| Campo | Tipo | Restrição |
|---|---|---|
| jog_id | NUMBER(10) | PRIMARY KEY NOT NULL |
| jog_nome | VARCHAR2(200) | NOT NULL |
| jog_categoria | VARCHAR2(100) | NOT NULL |
| jog_tema_disciplina | VARCHAR2(50) | NOT NULL |
| jog_faixa_etaria | NUMBER(3) | NOT NULL |
| jog_status | VARCHAR2(10) | NOT NULL |

---

## Tabela: VALIDACAO_IP

Responsável por armazenar os IPs autorizados das escolas.

| Campo | Tipo | Restrição |
|---|---|---|
| val_id | NUMBER(10) | PRIMARY KEY NOT NULL |
| val_ip | VARCHAR2(15) | NOT NULL |
| FK_esc_id | NUMBER(10) | FOREIGN KEY NOT NULL |

---

## Tabela: ACESSO

Responsável por registrar os acessos realizados no sistema.

| Campo | Tipo | Restrição |
|---|---|---|
| ace_id | NUMBER(10) | PRIMARY KEY NOT NULL |
| ace_data_hora | DATE | NOT NULL |
| ace_resultado | VARCHAR2(20) | NOT NULL |
| FK_esc_id | NUMBER(10) | FOREIGN KEY NOT NULL |

---

# Relacionamentos

- Uma ESCOLA pode possuir vários registros de ACESSO.
- Uma ESCOLA pode possuir vários IPs autorizados.
- Um PACOTE pode conter vários JOGOS.
- Uma ESCOLA pode adquirir PACOTES.
- A tabela valida realiza a associação entre ACESSO e VALIDACAO_IP.

---

# Tecnologias Utilizadas

- Oracle SQL
- Oracle XE
- SQL Developer
- brModelo

---

