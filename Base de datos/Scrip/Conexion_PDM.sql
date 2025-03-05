/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     18/07/2024 23:07:31                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROCESO') and o.name = 'FK_PROCESO_TIENE1_TRIBUNAL')
alter table PROCESO
   drop constraint FK_PROCESO_TIENE1_TRIBUNAL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROPOTENTE') and o.name = 'FK_PROPOTEN_TIENE_PROYECTO')
alter table PROPOTENTE
   drop constraint FK_PROPOTEN_TIENE_PROYECTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REALIZA') and o.name = 'FK_REALIZA_REALIZA_PROCESO')
alter table REALIZA
   drop constraint FK_REALIZA_REALIZA_PROCESO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REALIZA') and o.name = 'FK_REALIZA_REALIZA2_PROYECTO')
alter table REALIZA
   drop constraint FK_REALIZA_REALIZA2_PROYECTO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PROCESO')
            and   name  = 'TIENE1_FK'
            and   indid > 0
            and   indid < 255)
   drop index PROCESO.TIENE1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROCESO')
            and   type = 'U')
   drop table PROCESO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PROPOTENTE')
            and   name  = 'TIENE_FK'
            and   indid > 0
            and   indid < 255)
   drop index PROPOTENTE.TIENE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROPOTENTE')
            and   type = 'U')
   drop table PROPOTENTE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROYECTO')
            and   type = 'U')
   drop table PROYECTO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REALIZA')
            and   name  = 'REALIZA_FK'
            and   indid > 0
            and   indid < 255)
   drop index REALIZA.REALIZA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REALIZA')
            and   name  = 'REALIZA2_FK'
            and   indid > 0
            and   indid < 255)
   drop index REALIZA.REALIZA2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('REALIZA')
            and   type = 'U')
   drop table REALIZA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRIBUNAL')
            and   type = 'U')
   drop table TRIBUNAL
go

/*==============================================================*/
/* Table: PROCESO                                               */
/*==============================================================*/
create table PROCESO (
   ID_PRO               smallint             not null,
   ID_PR                smallint             null,
   ACTIVIDAD            varchar(70)          null,
   FECHA                datetime             null,
   constraint PK_PROCESO primary key (ID_PRO)
)
go

/*==============================================================*/
/* Index: TIENE1_FK                                             */
/*==============================================================*/




create nonclustered index TIENE1_FK on PROCESO (ID_PR ASC)
go

/*==============================================================*/
/* Table: PROPOTENTE                                            */
/*==============================================================*/
create table PROPOTENTE (
   ID                   int                  not null,
   ID_P                 smallint             null,
   NOMBRE               varchar(150)         null,
   SEXO                 bit                  null,
   VIGENCIA             varchar(150)         null,
   constraint PK_PROPOTENTE primary key (ID)
)
go

/*==============================================================*/
/* Index: TIENE_FK                                              */
/*==============================================================*/




create nonclustered index TIENE_FK on PROPOTENTE (ID_P ASC)
go

/*==============================================================*/
/* Table: PROYECTO                                              */
/*==============================================================*/
create table PROYECTO (
   ID_P                 smallint             not null,
   NOMBRE               varchar(150)         null,
   FECHA_INI            datetime             null,
   FECHA_FIN            datetime             null,
   constraint PK_PROYECTO primary key (ID_P)
)
go

/*==============================================================*/
/* Table: REALIZA                                               */
/*==============================================================*/
create table REALIZA (
   ID_PRO               smallint             not null,
   ID_P                 smallint             not null,
   constraint PK_REALIZA primary key (ID_PRO, ID_P)
)
go

/*==============================================================*/
/* Index: REALIZA2_FK                                           */
/*==============================================================*/




create nonclustered index REALIZA2_FK on REALIZA (ID_P ASC)
go

/*==============================================================*/
/* Index: REALIZA_FK                                            */
/*==============================================================*/




create nonclustered index REALIZA_FK on REALIZA (ID_PRO ASC)
go

/*==============================================================*/
/* Table: TRIBUNAL                                              */
/*==============================================================*/
create table TRIBUNAL (
   ID_PR                smallint             not null,
   FUNCION              varchar(100)         null,
   PROFESOR             varchar(150)         null,
   constraint PK_TRIBUNAL primary key (ID_PR)
)
go

alter table PROCESO
   add constraint FK_PROCESO_TIENE1_TRIBUNAL foreign key (ID_PR)
      references TRIBUNAL (ID_PR)
go

alter table PROPOTENTE
   add constraint FK_PROPOTEN_TIENE_PROYECTO foreign key (ID_P)
      references PROYECTO (ID_P)
go

alter table REALIZA
   add constraint FK_REALIZA_REALIZA_PROCESO foreign key (ID_PRO)
      references PROCESO (ID_PRO)
go

alter table REALIZA
   add constraint FK_REALIZA_REALIZA2_PROYECTO foreign key (ID_P)
      references PROYECTO (ID_P)
go

