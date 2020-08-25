--------------------------------------------------------
--  Fichier créé - vendredi-mai-29-2020   
   CREATE SEQUENCE  "P1"."ARTICLE_SEQ"  MINVALUE 1 MAXVALUE 999999999999999999999999999 INCREMENT BY 1 START WITH 61 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence CLIENT_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "P1"."CLIENT_SEQ"  MINVALUE 1 MAXVALUE 999999999999999999999999999 INCREMENT BY 1 START WITH 41 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence LIGNE_COMMANDE_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "P1"."LIGNE_COMMANDE_SEQ"  MINVALUE 1 MAXVALUE 999999999999999999999999999 INCREMENT BY 1 START WITH 81 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence MACHINE_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "P1"."MACHINE_SEQ"  MINVALUE 1 MAXVALUE 999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Table ARTICLE
--------------------------------------------------------

  CREATE TABLE "P1"."ARTICLE" 
   (	"REF_ART" VARCHAR2(40 BYTE), 
	"TYP_ART" VARCHAR2(30 BYTE), 
	"PRIX_ART" NUMBER(10,3), 
	"MOULE" VARCHAR2(30 BYTE)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$BEo9YFI2TpWFU1j63Yu0wQ==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TABLE "BIN$BEo9YFI2TpWFU1j63Yu0wQ==$0" 
(
  NOM VARCHAR2(30 BYTE) NOT NULL 
, PAS VARCHAR2(30 BYTE) NOT NULL 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$b1KHMPf4TUWvfRXLTYzWQw==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TABLE "BIN$b1KHMPf4TUWvfRXLTYzWQw==$0" 
(
  NUM_COM NUMBER NOT NULL 
, DAT_COM DATE NOT NULL 
, DAT_LIV DATE NOT NULL 
, MNT_TOT NUMBER NOT NULL 
, NUM_CLI NUMBER NOT NULL 
, CONSTRAINT "BIN$9G2waM1tRNGEEMKGXN3dmw==$0" PRIMARY KEY 
  (
    NUM_COM 
  )
  ENABLE 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$DeIeG5NQSKOyKE2sG2jMrA==$0 avec DBMS_METADATA tentant le générateur interne.
ALTER TABLE "BIN$DeIeG5NQSKOyKE2sG2jMrA==$0"
ADD CONSTRAINT "BIN$7nmDV1W7QZuiVq1UQNgI4A==$0" CHECK 
("TYPE_CLI" IS NOT NULL)
ENABLE
ALTER TABLE "BIN$DeIeG5NQSKOyKE2sG2jMrA==$0"
ADD CONSTRAINT "BIN$BHR1/mPwRPW3zxhg2m+LpA==$0" CHECK 
("NOM_CLI" IS NOT NULL)
ENABLECREATE TABLE "BIN$DeIeG5NQSKOyKE2sG2jMrA==$0" 
(
  NUM_CLI NUMBER NOT NULL 
, NOM_CLI VARCHAR2(40 BYTE) NOT NULL 
, TYPE_CLI VARCHAR2(20 BYTE) NOT NULL 
, NUM_COM NUMBER 
, CONSTRAINT "BIN$koNJoY/mTV+bLnUUg+BaKw==$0" PRIMARY KEY 
  (
    NUM_CLI 
  )
  ENABLE 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$dUcJZTHzTWy9MsMewwxPQQ==$0 avec DBMS_METADATA tentant le générateur interne.
ALTER TABLE "BIN$dUcJZTHzTWy9MsMewwxPQQ==$0"
ADD CONSTRAINT "BIN$LiekCH5iRgGY9bYfnZ+clQ==$0" CHECK 
("NUM_ART" IS NOT NULL)
ENABLE
ALTER TABLE "BIN$dUcJZTHzTWy9MsMewwxPQQ==$0"
ADD CONSTRAINT "BIN$wXbNZQWoR7GReO82mNUjeg==$0" CHECK 
("COD_MACH" IS NOT NULL)
ENABLECREATE TABLE "BIN$dUcJZTHzTWy9MsMewwxPQQ==$0" 
(
  QTE_MAX NUMBER 
, NUM_ART NUMBER NOT NULL 
, COD_MACH NUMBER NOT NULL 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$G3CxwMRuRRuFQScXLnN9NQ==$0 avec DBMS_METADATA tentant le générateur interne.
ALTER TABLE "BIN$G3CxwMRuRRuFQScXLnN9NQ==$0"
ADD CONSTRAINT "BIN$Av+OhP5cTgas+WQmTYvlPA==$0" CHECK 
("NUM_COM" IS NOT NULL)
ENABLE
ALTER TABLE "BIN$G3CxwMRuRRuFQScXLnN9NQ==$0"
ADD CONSTRAINT "BIN$K7ZiU825R5yPIMRGh3/Sag==$0" CHECK 
("NUM_ART" IS NOT NULL)
ENABLE
ALTER TABLE "BIN$G3CxwMRuRRuFQScXLnN9NQ==$0"
ADD CONSTRAINT "BIN$g7DdvqsqQsaQwqTBf/NGYQ==$0" CHECK 
("QTE_COM" IS NOT NULL)
ENABLECREATE TABLE "BIN$G3CxwMRuRRuFQScXLnN9NQ==$0" 
(
  QTE_COM NUMBER NOT NULL 
, NUM_COM NUMBER NOT NULL 
, NUM_ART NUMBER NOT NULL 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$/HnANdISRYqrCkGFtTEDSA==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TABLE "BIN$/HnANdISRYqrCkGFtTEDSA==$0" 
(
  COD_ART NUMBER NOT NULL 
, TYP_ART VARCHAR2(25 BYTE) 
, PRIX_ART NUMBER 
, MOULE VARCHAR2(25 BYTE) 
, CONSTRAINT "BIN$+7pBXH6WSLe2zXXStup2yg==$0" PRIMARY KEY 
  (
    COD_ART 
  )
  ENABLE 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$JYg4lCL4TeWtOSlv1XSsXQ==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TABLE "BIN$JYg4lCL4TeWtOSlv1XSsXQ==$0" 
(
  USER_NAME VARCHAR2(30 BYTE) NOT NULL 
, PASSWORD VARCHAR2(30 BYTE) NOT NULL 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$kS6re2jnSUGrRkCdhtffyw==$0 avec DBMS_METADATA tentant le générateur interne.
ALTER TABLE "BIN$kS6re2jnSUGrRkCdhtffyw==$0"
ADD CONSTRAINT "BIN$IloPLg5USvGJW97j1z0/Uw==$0" CHECK 
("NUM_ART" IS NOT NULL)
ENABLE
ALTER TABLE "BIN$kS6re2jnSUGrRkCdhtffyw==$0"
ADD CONSTRAINT "BIN$hIU+DLJVS8+7V9aijza22Q==$0" CHECK 
("COD_MACH" IS NOT NULL)
ENABLEALTER TABLE "BIN$kS6re2jnSUGrRkCdhtffyw==$0"
ADD CONSTRAINT "BIN$ZzQuuT9OTiimgZZzSHMmnQ==$0" UNIQUE 
(
  COD_MACH 
, NUM_ART 
)
ENABLECREATE TABLE "BIN$kS6re2jnSUGrRkCdhtffyw==$0" 
(
  QTE_MAX NUMBER 
, COD_MACH NUMBER NOT NULL 
, NUM_ART NUMBER NOT NULL 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$lqkJoppUSTG0KzW53SEPtw==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TABLE "BIN$lqkJoppUSTG0KzW53SEPtw==$0" 
(
  QTE_COM NUMBER NOT NULL 
, NUM_COM NUMBER 
, REF_ART VARCHAR2(40 BYTE) 
, MNT_LIG_COM NUMBER(*, 3) NOT NULL 
, NUM_LIGNE NUMBER NOT NULL 
, CONSTRAINT "BIN$RFuwqx7sQcuNA+/oZe28Dw==$0" PRIMARY KEY 
  (
    NUM_LIGNE 
  )
  ENABLE 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$oMOFHdK8Sa+Oc7O6ohmOwg==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TABLE "BIN$oMOFHdK8Sa+Oc7O6ohmOwg==$0" 
(
  COD_MACH NUMBER NOT NULL 
, NOM_MACH VARCHAR2(60 BYTE) NOT NULL 
, DISP_MACH NUMBER NOT NULL 
, CONSTRAINT "BIN$xtimJTy/RLaQR/ts5nne5A==$0" PRIMARY KEY 
  (
    COD_MACH 
  )
  ENABLE 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$pA1KbtgjRVyWQSDVzhg1FA==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TABLE "BIN$pA1KbtgjRVyWQSDVzhg1FA==$0" 
(
  NUM_COM NUMBER NOT NULL 
, DATE_COM NUMBER NOT NULL 
, DATE_LIV NUMBER NOT NULL 
, MONT_TOT NUMBER NOT NULL 
, CONSTRAINT "BIN$cyFDfJINQBStT8rrNxkrJQ==$0" PRIMARY KEY 
  (
    NUM_COM 
  )
  ENABLE 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$Pk73gd3URpGmA3Vkd8385w==$0 avec DBMS_METADATA tentant le générateur interne.
ALTER TABLE "BIN$Pk73gd3URpGmA3Vkd8385w==$0"
ADD CONSTRAINT "BIN$23CR1YMJSNmJSAVNReoWcw==$0" UNIQUE 
(
  COD_MACH 
)
ENABLECREATE TABLE "BIN$Pk73gd3URpGmA3Vkd8385w==$0" 
(
  QTE_MAX NUMBER NOT NULL 
, COD_MACH NUMBER NOT NULL 
, NUM_ART NUMBER NOT NULL 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$WIBbfPbdSyy0tyJNOWKd7w==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TABLE "BIN$WIBbfPbdSyy0tyJNOWKd7w==$0" 
(
  REF_ART VARCHAR2(40 BYTE) NOT NULL 
, TYP_ART VARCHAR2(30 BYTE) NOT NULL 
, PRIX_ART NUMBER NOT NULL 
, MOULE VARCHAR2(20 BYTE) NOT NULL 
, CONSTRAINT "BIN$xe2wpHgpTjWb5UnMWsO+bw==$0" PRIMARY KEY 
  (
    REF_ART 
  )
  ENABLE 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$xzIufzudSECIlS4Nx31BMw==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TABLE "BIN$xzIufzudSECIlS4Nx31BMw==$0" 
(
  REF_ART VARCHAR2(40 BYTE) NOT NULL 
, TYP_ART VARCHAR2(30 BYTE) NOT NULL 
, PRIX_ART NUMBER NOT NULL 
, MOULE VARCHAR2(20 BYTE) NOT NULL 
, CONSTRAINT "BIN$KSqhktSBSCynBwe57V5vlg==$0" PRIMARY KEY 
  (
    REF_ART 
  )
  ENABLE 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$Zk3N3rWHTDCtfCU7NZ4HWg==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TABLE "BIN$Zk3N3rWHTDCtfCU7NZ4HWg==$0" 
(
  NOM VARCHAR2(30 BYTE) NOT NULL 
, MT VARCHAR2(30 BYTE) NOT NULL 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$ZWRqRhq4Ro2LGr9fYt/VRQ==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TABLE "BIN$ZWRqRhq4Ro2LGr9fYt/VRQ==$0" 
(
  QTE_COM NUMBER 
, NUM_ART NUMBER 
, NUM_COM NUMBER 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$1/P1SAwWRVyuIH5GtE+WRg==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TABLE "BIN$1/P1SAwWRVyuIH5GtE+WRg==$0" 
(
  QTE_COM NUMBER NOT NULL 
, NUM_COM NUMBER NOT NULL 
, REF_ART NUMBER NOT NULL 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$4uTGyvvrRnCwD1hItpJitw==$0 avec DBMS_METADATA tentant le générateur interne.
ALTER TABLE "BIN$4uTGyvvrRnCwD1hItpJitw==$0"
ADD CONSTRAINT "BIN$rSLT+pl2RPqBnXYenK+fQg==$0" CHECK 
("NUM_CLI" IS NOT NULL)
ENABLECREATE TABLE "BIN$4uTGyvvrRnCwD1hItpJitw==$0" 
(
  NUM_COM NUMBER NOT NULL 
, DAT_COM DATE 
, DAT_LIV_COM DATE 
, MONT_TOT_COM NUMBER 
, NUM_CLI NUMBER NOT NULL 
, CONSTRAINT "BIN$kSDM4wF8QYidTW0LnkNyjA==$0" PRIMARY KEY 
  (
    NUM_COM 
  )
  ENABLE 
)
-- Impossible d'afficher le langage DDL TABLE pour l'objet P1.BIN$7DapRAfTSjCHHITGdibqEw==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TABLE "BIN$7DapRAfTSjCHHITGdibqEw==$0" 
(
  NUM_ART NUMBER NOT NULL 
, TYPE_ART VARCHAR2(20 BYTE) NOT NULL 
, PRIX_ART NUMBER(10, 3) NOT NULL 
, MOULE VARCHAR2(20 BYTE) NOT NULL 
, CONSTRAINT "BIN$353aU5DfTdym1slaVvEqzw==$0" PRIMARY KEY 
  (
    NUM_ART 
  )
  ENABLE 
)
--------------------------------------------------------
--  DDL for Table CLIENT
--------------------------------------------------------

  CREATE TABLE "P1"."CLIENT" 
   (	"REF_CLI" VARCHAR2(50 BYTE), 
	"NOM_CLI" VARCHAR2(30 BYTE), 
	"REMISE" NUMBER
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table COMMANDE
--------------------------------------------------------

  CREATE TABLE "P1"."COMMANDE" 
   (	"NUM_COM" NUMBER, 
	"DAT_COM" DATE, 
	"DAT_LIV_COM" DATE, 
	"MNT_TOT_COM" NUMBER(10,3), 
	"REF_CLI" VARCHAR2(50 BYTE), 
	"LIVRAISON" NUMBER
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table COMPTE
--------------------------------------------------------

  CREATE TABLE "P1"."COMPTE" 
   (	"USER_NAME" VARCHAR2(30 BYTE), 
	"PASSWORD" VARCHAR2(30 BYTE), 
	"FONCTION" VARCHAR2(30 BYTE)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table FABRIQUER
--------------------------------------------------------

  CREATE TABLE "P1"."FABRIQUER" 
   (	"QTE_MAX" NUMBER, 
	"COD_MACH" VARCHAR2(20 BYTE), 
	"REF_ART" VARCHAR2(40 BYTE)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table HTMLDB_PLAN_TABLE
--------------------------------------------------------

  CREATE TABLE "P1"."HTMLDB_PLAN_TABLE" 
   (	"STATEMENT_ID" VARCHAR2(30 BYTE), 
	"PLAN_ID" NUMBER, 
	"TIMESTAMP" DATE, 
	"REMARKS" VARCHAR2(4000 BYTE), 
	"OPERATION" VARCHAR2(30 BYTE), 
	"OPTIONS" VARCHAR2(255 BYTE), 
	"OBJECT_NODE" VARCHAR2(128 BYTE), 
	"OBJECT_OWNER" VARCHAR2(30 BYTE), 
	"OBJECT_NAME" VARCHAR2(30 BYTE), 
	"OBJECT_ALIAS" VARCHAR2(65 BYTE), 
	"OBJECT_INSTANCE" NUMBER(*,0), 
	"OBJECT_TYPE" VARCHAR2(30 BYTE), 
	"OPTIMIZER" VARCHAR2(255 BYTE), 
	"SEARCH_COLUMNS" NUMBER, 
	"ID" NUMBER(*,0), 
	"PARENT_ID" NUMBER(*,0), 
	"DEPTH" NUMBER(*,0), 
	"POSITION" NUMBER(*,0), 
	"COST" NUMBER(*,0), 
	"CARDINALITY" NUMBER(*,0), 
	"BYTES" NUMBER(*,0), 
	"OTHER_TAG" VARCHAR2(255 BYTE), 
	"PARTITION_START" VARCHAR2(255 BYTE), 
	"PARTITION_STOP" VARCHAR2(255 BYTE), 
	"PARTITION_ID" NUMBER(*,0), 
	"OTHER" LONG, 
	"DISTRIBUTION" VARCHAR2(30 BYTE), 
	"CPU_COST" NUMBER(*,0), 
	"IO_COST" NUMBER(*,0), 
	"TEMP_SPACE" NUMBER(*,0), 
	"ACCESS_PREDICATES" VARCHAR2(4000 BYTE), 
	"FILTER_PREDICATES" VARCHAR2(4000 BYTE), 
	"PROJECTION" VARCHAR2(4000 BYTE), 
	"TIME" NUMBER(*,0), 
	"QBLOCK_NAME" VARCHAR2(30 BYTE)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table LIGNE_COMMANDE
--------------------------------------------------------

  CREATE TABLE "P1"."LIGNE_COMMANDE" 
   (	"NUM_LIGNE" NUMBER, 
	"REF_ART" VARCHAR2(40 BYTE), 
	"QTE_COM" NUMBER, 
	"MNT_LIG_COM" NUMBER(10,3), 
	"NUM_COM" NUMBER
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table MACHINE
--------------------------------------------------------

  CREATE TABLE "P1"."MACHINE" 
   (	"COD_MACH" VARCHAR2(20 BYTE), 
	"NOM_MACH" VARCHAR2(25 BYTE), 
	"DISP_MACH" NUMBER
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index ARTICLE_CON
--------------------------------------------------------

  CREATE UNIQUE INDEX "P1"."ARTICLE_CON" ON "P1"."ARTICLE" ("MOULE") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index ARTICLE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "P1"."ARTICLE_PK" ON "P1"."ARTICLE" ("REF_ART") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
-- Impossible d'afficher le langage DDL INDEX pour l'objet P1.BIN$e/+gqRa3TMqReDalDCgvYA==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE INDEX "BIN$e/+gqRa3TMqReDalDCgvYA==$0" ON ()
-- Impossible d'afficher le langage DDL INDEX pour l'objet P1.BIN$hNWcMxF0QveYrTZOiAmZ4A==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE INDEX "BIN$hNWcMxF0QveYrTZOiAmZ4A==$0" ON ()
-- Impossible d'afficher le langage DDL INDEX pour l'objet P1.BIN$jD1x215PTMyUn3yX738oRA==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE INDEX "BIN$jD1x215PTMyUn3yX738oRA==$0" ON ()
-- Impossible d'afficher le langage DDL INDEX pour l'objet P1.BIN$jk+6sK0uQmimfxvAjlo+4A==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE INDEX "BIN$jk+6sK0uQmimfxvAjlo+4A==$0" ON ()
-- Impossible d'afficher le langage DDL INDEX pour l'objet P1.BIN$LdXar5DiQQ204txLz5aE3g==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE INDEX "BIN$LdXar5DiQQ204txLz5aE3g==$0" ON ()
-- Impossible d'afficher le langage DDL INDEX pour l'objet P1.BIN$LiNZskqZTkqz9fXGjLU39Q==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE INDEX "BIN$LiNZskqZTkqz9fXGjLU39Q==$0" ON ()
-- Impossible d'afficher le langage DDL INDEX pour l'objet P1.BIN$nWE9MOpTTBymBnEK9hHYfQ==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE INDEX "BIN$nWE9MOpTTBymBnEK9hHYfQ==$0" ON ()
-- Impossible d'afficher le langage DDL INDEX pour l'objet P1.BIN$qywi3KfRRT+rLfXx5FzyDw==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE INDEX "BIN$qywi3KfRRT+rLfXx5FzyDw==$0" ON ()
-- Impossible d'afficher le langage DDL INDEX pour l'objet P1.BIN$YmG09wyWTUOCT1dn6pnZng==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE INDEX "BIN$YmG09wyWTUOCT1dn6pnZng==$0" ON ()
-- Impossible d'afficher le langage DDL INDEX pour l'objet P1.BIN$2gwMjWuMQ3KifykUQhO21g==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE INDEX "BIN$2gwMjWuMQ3KifykUQhO21g==$0" ON ()
-- Impossible d'afficher le langage DDL INDEX pour l'objet P1.BIN$5I3VLNewTl6Q8Odjt8cfMQ==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE INDEX "BIN$5I3VLNewTl6Q8Odjt8cfMQ==$0" ON ()
-- Impossible d'afficher le langage DDL INDEX pour l'objet P1.BIN$6VubfHFgTYS3IGoBn+UFng==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE INDEX "BIN$6VubfHFgTYS3IGoBn+UFng==$0" ON ()
--------------------------------------------------------
--  DDL for Index CLIENT_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "P1"."CLIENT_PK" ON "P1"."CLIENT" ("REF_CLI") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index COMMANDE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "P1"."COMMANDE_PK" ON "P1"."COMMANDE" ("NUM_COM") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index COMPTE_UK1
--------------------------------------------------------

  CREATE UNIQUE INDEX "P1"."COMPTE_UK1" ON "P1"."COMPTE" ("USER_NAME") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index FABRIQUER_CON
--------------------------------------------------------

  CREATE UNIQUE INDEX "P1"."FABRIQUER_CON" ON "P1"."FABRIQUER" ("COD_MACH", "REF_ART") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index LIGNE_COMMANDE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "P1"."LIGNE_COMMANDE_PK" ON "P1"."LIGNE_COMMANDE" ("NUM_LIGNE") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index MACHINE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "P1"."MACHINE_PK" ON "P1"."MACHINE" ("COD_MACH") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table ARTICLE
--------------------------------------------------------

  ALTER TABLE "P1"."ARTICLE" ADD CONSTRAINT "ARTICLE_CON" UNIQUE ("MOULE")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE;
 
  ALTER TABLE "P1"."ARTICLE" ADD CONSTRAINT "ARTICLE_PK" PRIMARY KEY ("REF_ART")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE;
 
  ALTER TABLE "P1"."ARTICLE" MODIFY ("REF_ART" NOT NULL ENABLE);
 
  ALTER TABLE "P1"."ARTICLE" MODIFY ("TYP_ART" NOT NULL ENABLE);
 
  ALTER TABLE "P1"."ARTICLE" MODIFY ("PRIX_ART" NOT NULL ENABLE);
 
  ALTER TABLE "P1"."ARTICLE" MODIFY ("MOULE" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table CLIENT
--------------------------------------------------------

  ALTER TABLE "P1"."CLIENT" ADD CONSTRAINT "CLIENT_PK" PRIMARY KEY ("REF_CLI")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table COMMANDE
--------------------------------------------------------

  ALTER TABLE "P1"."COMMANDE" ADD CONSTRAINT "COMMANDE_PK" PRIMARY KEY ("NUM_COM")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE;
 
  ALTER TABLE "P1"."COMMANDE" MODIFY ("NUM_COM" NOT NULL ENABLE);
 
  ALTER TABLE "P1"."COMMANDE" MODIFY ("REF_CLI" NOT NULL ENABLE);
 
  ALTER TABLE "P1"."COMMANDE" MODIFY ("MNT_TOT_COM" NOT NULL ENABLE);
 
  ALTER TABLE "P1"."COMMANDE" MODIFY ("DAT_COM" NOT NULL ENABLE);
 
  ALTER TABLE "P1"."COMMANDE" MODIFY ("DAT_LIV_COM" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table COMPTE
--------------------------------------------------------

  ALTER TABLE "P1"."COMPTE" ADD CONSTRAINT "COMPTE_UK1" UNIQUE ("USER_NAME")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE;
 
  ALTER TABLE "P1"."COMPTE" MODIFY ("USER_NAME" NOT NULL ENABLE);
 
  ALTER TABLE "P1"."COMPTE" MODIFY ("PASSWORD" NOT NULL ENABLE);
 
  ALTER TABLE "P1"."COMPTE" MODIFY ("FONCTION" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table FABRIQUER
--------------------------------------------------------

  ALTER TABLE "P1"."FABRIQUER" ADD CONSTRAINT "FABRIQUER_CON" PRIMARY KEY ("COD_MACH", "REF_ART")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE;
 
  ALTER TABLE "P1"."FABRIQUER" MODIFY ("QTE_MAX" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table LIGNE_COMMANDE
--------------------------------------------------------

  ALTER TABLE "P1"."LIGNE_COMMANDE" ADD CONSTRAINT "LIGNE_COMMANDE_PK" PRIMARY KEY ("NUM_LIGNE")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE;
 
  ALTER TABLE "P1"."LIGNE_COMMANDE" MODIFY ("NUM_LIGNE" NOT NULL ENABLE);
 
  ALTER TABLE "P1"."LIGNE_COMMANDE" MODIFY ("QTE_COM" NOT NULL ENABLE);
 
  ALTER TABLE "P1"."LIGNE_COMMANDE" MODIFY ("MNT_LIG_COM" NOT NULL ENABLE);
 
  ALTER TABLE "P1"."LIGNE_COMMANDE" MODIFY ("NUM_COM" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table MACHINE
--------------------------------------------------------

  ALTER TABLE "P1"."MACHINE" ADD CONSTRAINT "MACHINE_CK1" CHECK (disp_mach=0 or disp_mach=1) ENABLE;
 
  ALTER TABLE "P1"."MACHINE" ADD CONSTRAINT "MACHINE_PK" PRIMARY KEY ("COD_MACH")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE;
 
  ALTER TABLE "P1"."MACHINE" MODIFY ("NOM_MACH" NOT NULL ENABLE);
 
  ALTER TABLE "P1"."MACHINE" MODIFY ("DISP_MACH" NOT NULL ENABLE);
--------------------------------------------------------
--  Ref Constraints for Table COMMANDE
--------------------------------------------------------

  ALTER TABLE "P1"."COMMANDE" ADD CONSTRAINT "COMMANDE_FK" FOREIGN KEY ("REF_CLI")
	  REFERENCES "P1"."CLIENT" ("REF_CLI") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table FABRIQUER
--------------------------------------------------------

  ALTER TABLE "P1"."FABRIQUER" ADD CONSTRAINT "FABRIQUER_FK2" FOREIGN KEY ("COD_MACH")
	  REFERENCES "P1"."MACHINE" ("COD_MACH") ON DELETE CASCADE ENABLE;
 
  ALTER TABLE "P1"."FABRIQUER" ADD CONSTRAINT "FABRIQUER_FK3" FOREIGN KEY ("REF_ART")
	  REFERENCES "P1"."ARTICLE" ("REF_ART") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table LIGNE_COMMANDE
--------------------------------------------------------

  ALTER TABLE "P1"."LIGNE_COMMANDE" ADD CONSTRAINT "LIGNE_COMMANDE_CON" FOREIGN KEY ("NUM_COM")
	  REFERENCES "P1"."COMMANDE" ("NUM_COM") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  DDL for Trigger BI_ARTICLE
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "P1"."BI_ARTICLE" 
  before insert on "ARTICLE"               
  for each row  
begin   
    select "ARTICLE_SEQ".nextval into :NEW.REF_ART from dual; 
end; 

/
ALTER TRIGGER "P1"."BI_ARTICLE" DISABLE;
--------------------------------------------------------
--  DDL for Trigger BI_COMMANDE
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "P1"."BI_COMMANDE" 
  before insert on "COMMANDE"               
  for each row  
begin   
    select "COMMANDE_SEQ".nextval into :NEW.NUM_COM from dual; 
end; 

/
ALTER TRIGGER "P1"."BI_COMMANDE" DISABLE;
--------------------------------------------------------
--  DDL for Trigger BI_LIGNE_COMMANDE
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "P1"."BI_LIGNE_COMMANDE" 
  before insert on "LIGNE_COMMANDE"               
  for each row  
begin   
    select "LIGNE_COMMANDE_SEQ".nextval into :NEW.NUM_LIGNE from dual; 
end; 

/
ALTER TRIGGER "P1"."BI_LIGNE_COMMANDE" ENABLE;
-- Impossible d'afficher le langage DDL TRIGGER pour l'objet P1.BIN$AhSk0i8vQzWUIDTUuzpyGA==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TRIGGER 
"BIN$AhSk0i8vQzWUIDTUuzpyGA==$0"   
  before insert on "BIN$pA1KbtgjRVyWQSDVzhg1FA==$0"               
  for each row  
begin   
    select "COMMANDE_SEQ".nextval into :NEW.NUM_COM from dual; 
end;
-- Impossible d'afficher le langage DDL TRIGGER pour l'objet P1.BIN$DwE0IO2rRZ6mkbcTXIG7QQ==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TRIGGER 
"BIN$DwE0IO2rRZ6mkbcTXIG7QQ==$0"   
  before insert on "BIN$4uTGyvvrRnCwD1hItpJitw==$0"               
  for each row  
begin   
    select "COMMANDE_SEQ".nextval into :NEW.NUM_COM from dual; 
end;
-- Impossible d'afficher le langage DDL TRIGGER pour l'objet P1.BIN$gDC/Xq2GRCW34/R0pQIO0g==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TRIGGER 
"BIN$gDC/Xq2GRCW34/R0pQIO0g==$0"   
  before insert on "BIN$xzIufzudSECIlS4Nx31BMw==$0"               
  for each row  
begin   
    select "ARTICLE_SEQ".nextval into :NEW.REF_ART from dual; 
end; 
              NEWOLD  "BI_MACHINE"
-- Impossible d'afficher le langage DDL TRIGGER pour l'objet P1.BIN$Gw4WQuRpRWe26hr0gdbPSQ==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TRIGGER 
"BIN$Gw4WQuRpRWe26hr0gdbPSQ==$0"   
  before insert on "BIN$/HnANdISRYqrCkGFtTEDSA==$0"               
  for each row  
begin   
    select "ARTICLE_SEQ".nextval into :NEW.NUM_ART from dual; 
end; 
                              µ À¨ú
-- Impossible d'afficher le langage DDL TRIGGER pour l'objet P1.BIN$K+7vxJ4HTry4wkr+KCV2KQ==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TRIGGER 
"BIN$K+7vxJ4HTry4wkr+KCV2KQ==$0"   
  before insert on "BIN$oMOFHdK8Sa+Oc7O6ohmOwg==$0"               
  for each row  
begin   
    select "MACHINE_SEQ".nextval into :NEW.COD_MACH from dual; 
end;
-- Impossible d'afficher le langage DDL TRIGGER pour l'objet P1.BIN$O7YClA93SMK/GCOJDCOF8g==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TRIGGER 
"BIN$O7YClA93SMK/GCOJDCOF8g==$0"   
  before insert on "BIN$7DapRAfTSjCHHITGdibqEw==$0"               
  for each row  
begin   
    select "FABRIQUER_SEQ".nextval into :NEW.NUM_ART from dual; 
end;
-- Impossible d'afficher le langage DDL TRIGGER pour l'objet P1.BIN$vatZednjTieMM1UOmK5uRQ==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TRIGGER 
"BIN$vatZednjTieMM1UOmK5uRQ==$0"   
  before insert on "BIN$b1KHMPf4TUWvfRXLTYzWQw==$0"               
  for each row  
begin   
    select "COMMANDE_SEQ".nextval into :NEW.NUM_COM from dual; 
end; 
  Àµ
-- Impossible d'afficher le langage DDL TRIGGER pour l'objet P1.BIN$Zc9d37cRQRiYZAmViwKdVQ==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TRIGGER 
"BIN$Zc9d37cRQRiYZAmViwKdVQ==$0" 
AFTER
insert on "BIN$Pk73gd3URpGmA3Vkd8385w==$0"
begin
declare 
cursor c1 is select * from machine;
cursor c2 is select cod_mach from fabriquer;
a machine.cod_mach%type;
begin 
for  record1 in c1
loop 
for record2 in c2
loop
if record1.cod_mach=record2.cod_mach then
a:=record1.cod_mach;
update machine set disp_mach=0 where cod_mach=a;
end if;
end loop;
end loop;

end;

end;
-- Impossible d'afficher le langage DDL TRIGGER pour l'objet P1.BIN$ZLZ6HfQuRCSQoL2kQi9fJw==$0 avec DBMS_METADATA tentant le générateur interne.
CREATE TRIGGER 
"BIN$ZLZ6HfQuRCSQoL2kQi9fJw==$0"   
  before insert on "BIN$DeIeG5NQSKOyKE2sG2jMrA==$0"               
  for each row  
begin   
    select "CLIENT_SEQ".nextval into :NEW.NUM_CLI from dual; 
end;
--------------------------------------------------------
--  DDL for Synonymn DUAL
--------------------------------------------------------
insert into "P1"."COMPTE" values ('admin','admin','administration');
  CREATE OR REPLACE PUBLIC SYNONYM "DUAL" FOR "SYS"."DUAL";
