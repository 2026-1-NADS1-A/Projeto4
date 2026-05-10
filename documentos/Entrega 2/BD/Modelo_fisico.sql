/* Lógico_BD 2: */

CREATE TABLE JOGOS (
    jog_id NUMBER(10) PRIMARY KEY, NOT NULL,
    jog_nome VARCHAR2(200) NOT NULL,
    jog_categoria VARCHAR2(100) NOT NULL,
    jog_tema_disciplina VARCHAR2(50) NOT NULL,
    jog_faixa_etaria NUMBER(3) NOT NULL,
    jog_status VARCHAR2(10) NOT NULL
);

CREATE TABLE PACOTE (
    pac_id NUMBER(10) PRIMARY KEY, NOT NULL,
    pac_nome VARCHAR2(200) NOT NULL,
    pac_limite_mensal NUMBER(5) NOT NULL,
    pac_preco NUMBER(6,2) NOT NULL
);

CREATE TABLE VALIDACAO_IP (
    val_id NUMBER(10) PRIMARY KEY, NOT NULL,
    val_ip VARCHAR2(15) NOT NULL,
    FK_esc_id NUMBER(10) NOT NULL
);

CREATE TABLE ESCOLA (
    esc_id NUMBER(10) PRIMARY KEY, NOT NULL,
    esc_nome VARCHAR2(200) NOT NULL,
    esc_email VARCHAR2(50) NOT NULL,
    esc_senha VARCHAR2(100) NOT NULL,
    esc_ativo NUMBER(1) NOT NULL
);

CREATE TABLE ACESSO (
    ace_id NUMBER(10) PRIMARY KEY, NOT NULL,
    ace_data_hora DATE NOT NULL,
    ace_resultado VARCHAR2(20) NOT NULL,
    FK_esc_id NUMBER(10) NOT NULL
);

CREATE TABLE valida (
    FK_ace_id NUMBER(10) NOT NULL,
    FK_val_id NUMBER(10) NOT NULL
);

CREATE TABLE adquire (
    FK_pac_id NUMBER(10) NOT NULL,
    FK_esc_id NUMBER(10) NOT NULL
);

CREATE TABLE contem_game (
    FK_pac_id NUMBER(10) NOT NULL,
    FK_jog_id NUMBER(10) NOT NULL
);
 
ALTER TABLE VALIDACAO_IP ADD CONSTRAINT FK_VALIDACAO_IP_1
    FOREIGN KEY (FK_esc_id)
    REFERENCES ESCOLA (esc_id)
    ON DELETE CASCADE;

ALTER TABLE ACESSO ADD CONSTRAINT FK_ACESSO_1
    FOREIGN KEY (FK_esc_id)
    REFERENCES ESCOLA (esc_id);

ALTER TABLE valida ADD CONSTRAINT FK_valida_1
    FOREIGN KEY (FK_ace_id)
    REFERENCES ACESSO (ace_id)
    ON DELETE CASCADE;

ALTER TABLE valida ADD CONSTRAINT FK_valida_2
    FOREIGN KEY (FK_val_id)
    REFERENCES VALIDACAO_IP (val_id)
    ON DELETE CASCADE;

ALTER TABLE adquire ADD CONSTRAINT FK_adquire_1
    FOREIGN KEY (FK_pac_id)
    REFERENCES PACOTE (pac_id)
    ON DELETE CASCADE;

ALTER TABLE adquire ADD CONSTRAINT FK_adquire_2
    FOREIGN KEY (FK_esc_id)
    REFERENCES ESCOLA (esc_id)
    ON DELETE CASCADE;

ALTER TABLE contem_game ADD CONSTRAINT FK_contem_game_1
    FOREIGN KEY (FK_pac_id)
    REFERENCES PACOTE (pac_id)
    ON DELETE CASCADE;

ALTER TABLE contem_game ADD CONSTRAINT FK_contem_game_2
    FOREIGN KEY (FK_jog_id)
    REFERENCES JOGOS (jog_id)
    ON DELETE CASCADE;