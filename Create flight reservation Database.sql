/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     5/3/2019 2:48:30 PM                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AIRCRAFT') and o.name = 'FK_AIRCRAFT_BELONG_TO_AIRCOMPA')
alter table AIRCRAFT
   drop constraint FK_AIRCRAFT_BELONG_TO_AIRCOMPA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FLY') and o.name = 'FK_FLY_FLY_FLIGHT')
alter table FLY
   drop constraint FK_FLY_FLY_FLIGHT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FLY') and o.name = 'FK_FLY_FLY2_AIRCRAFT')
alter table FLY
   drop constraint FK_FLY_FLY2_AIRCRAFT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TICKET') and o.name = 'FK_TICKET_BELONGS_T_FLIGHT')
alter table TICKET
   drop constraint FK_TICKET_BELONGS_T_FLIGHT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TICKET') and o.name = 'FK_TICKET_RELATIONS_PASSENGE')
alter table TICKET
   drop constraint FK_TICKET_RELATIONS_PASSENGE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AIRCOMPANY')
            and   type = 'U')
   drop table AIRCOMPANY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('AIRCRAFT')
            and   name  = 'BELONG_TO_FK'
            and   indid > 0
            and   indid < 255)
   drop index AIRCRAFT.BELONG_TO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AIRCRAFT')
            and   type = 'U')
   drop table AIRCRAFT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FLIGHT')
            and   type = 'U')
   drop table FLIGHT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FLY')
            and   name  = 'FLY2_FK'
            and   indid > 0
            and   indid < 255)
   drop index FLY.FLY2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FLY')
            and   name  = 'FLY_FK'
            and   indid > 0
            and   indid < 255)
   drop index FLY.FLY_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FLY')
            and   type = 'U')
   drop table FLY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PASSENGER')
            and   type = 'U')
   drop table PASSENGER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TICKET')
            and   name  = 'BELONGS_TO_FK'
            and   indid > 0
            and   indid < 255)
   drop index TICKET.BELONGS_TO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TICKET')
            and   name  = 'RELATIONSHIP_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index TICKET.RELATIONSHIP_1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TICKET')
            and   type = 'U')
   drop table TICKET
go

/*==============================================================*/
/* Table: AIRCOMPANY                                            */
/*==============================================================*/
create table AIRCOMPANY (
   COMPANY_NAME         varchar(50)          not null,
   LOCATION             varchar(50)          not null,
   constraint PK_AIRCOMPANY primary key nonclustered (COMPANY_NAME)
)
go

/*==============================================================*/
/* Table: AIRCRAFT                                              */
/*==============================================================*/
create table AIRCRAFT (
   MODEL                varchar(50)          not null,
   PLANE_ID             varchar(50)          not null,
   COMPANY_NAME         varchar(50)          not null,
   N_PASSENGERS         int                  not null,
   MODEL_YEAR           int                  not null,
   constraint PK_AIRCRAFT primary key nonclustered (PLANE_ID)
)
go

/*==============================================================*/
/* Index: BELONG_TO_FK                                          */
/*==============================================================*/
create index BELONG_TO_FK on AIRCRAFT (
COMPANY_NAME ASC
)
go

/*==============================================================*/
/* Table: FLIGHT                                                */
/*==============================================================*/
create table FLIGHT (
   DATE_AND_TIME        datetime             not null,
   DESTINATION_CITY     varchar(150)         not null,
   PILOT_ID             varchar(50)          not null,
   N_STOPS              int                  not null,
   DURATION             float                not null,
   DEPARTURE_CITY       varchar(150)         not null,
   FLIGHT_NO            varchar(50)          not null,
   N_AVAILABLESEATS     int                  null,
   constraint PK_FLIGHT primary key nonclustered (FLIGHT_NO, PILOT_ID)
)
go

/*==============================================================*/
/* Table: FLY                                                   */
/*==============================================================*/
create table FLY (
   FLIGHT_NO            varchar(50)          not null,
   PILOT_ID             varchar(50)          not null,
   PLANE_ID             varchar(50)          not null,
   constraint PK_FLY primary key (FLIGHT_NO, PILOT_ID, PLANE_ID)
)
go

/*==============================================================*/
/* Index: FLY_FK                                                */
/*==============================================================*/
create index FLY_FK on FLY (
FLIGHT_NO ASC,
PILOT_ID ASC
)
go

/*==============================================================*/
/* Index: FLY2_FK                                               */
/*==============================================================*/
create index FLY2_FK on FLY (
PLANE_ID ASC
)
go

/*==============================================================*/
/* Table: PASSENGER                                             */
/*==============================================================*/
create table PASSENGER (
   PASSENGER_ID         varchar(50)          not null,
   EMAIL                varchar(50)          not null,
   NAME                 varchar(50)          not null,
   TYPE                 varchar(50)          null,
   constraint PK_PASSENGER primary key nonclustered (PASSENGER_ID, EMAIL)
)
go

/*==============================================================*/
/* Table: TICKET                                                */
/*==============================================================*/
create table TICKET (
   PASSENGER_ID         varchar(50)          not null,
   EMAIL                varchar(50)          not null,
   SEAT_NO              varchar(50)          not null,
   TICKET_NO            varchar(50)          not null,
   CLASS                varchar(20)          not null,
   FLIGHT_NO            varchar(50)          not null,
   PILOT_ID             varchar(50)          not null,
   constraint PK_TICKET primary key nonclustered (PASSENGER_ID, EMAIL, SEAT_NO, TICKET_NO)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_1_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_1_FK on TICKET (
PASSENGER_ID ASC,
EMAIL ASC
)
go

/*==============================================================*/
/* Index: BELONGS_TO_FK                                         */
/*==============================================================*/
create index BELONGS_TO_FK on TICKET (
FLIGHT_NO ASC,
PILOT_ID ASC
)
go

alter table AIRCRAFT
   add constraint FK_AIRCRAFT_BELONG_TO_AIRCOMPA foreign key (COMPANY_NAME)
      references AIRCOMPANY (COMPANY_NAME)
go

alter table FLY
   add constraint FK_FLY_FLY_FLIGHT foreign key (FLIGHT_NO, PILOT_ID)
      references FLIGHT (FLIGHT_NO, PILOT_ID)
go

alter table FLY
   add constraint FK_FLY_FLY2_AIRCRAFT foreign key (PLANE_ID)
      references AIRCRAFT (PLANE_ID)
go

alter table TICKET
   add constraint FK_TICKET_BELONGS_T_FLIGHT foreign key (FLIGHT_NO, PILOT_ID)
      references FLIGHT (FLIGHT_NO, PILOT_ID)
go

alter table TICKET
   add constraint FK_TICKET_RELATIONS_PASSENGE foreign key (PASSENGER_ID, EMAIL)
      references PASSENGER (PASSENGER_ID, EMAIL)
go
