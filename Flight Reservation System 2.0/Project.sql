/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     03/05/2018 05:01:32 ã                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Has_Booking') and o.name = 'FK_HAS_BOOK_HAS_BOOKI_FLIGHT')
alter table Has_Booking
   drop constraint FK_HAS_BOOK_HAS_BOOKI_FLIGHT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Has_Booking') and o.name = 'FK_HAS_BOOK_HAS_BOOKI_BOOKING_')
alter table Has_Booking
   drop constraint FK_HAS_BOOK_HAS_BOOKI_BOOKING_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Land_on') and o.name = 'FK_LAND_ON_LAND_ON_AIRPORT')
alter table Land_on
   drop constraint FK_LAND_ON_LAND_ON_AIRPORT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Land_on') and o.name = 'FK_LAND_ON_LAND_ON2_AIRPLANE')
alter table Land_on
   drop constraint FK_LAND_ON_LAND_ON2_AIRPLANE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Passenger') and o.name = 'FK_PASSENGE_BOOK_TICK_BOOKING_')
alter table Passenger
   drop constraint FK_PASSENGE_BOOK_TICK_BOOKING_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Passenger') and o.name = 'FK_PASSENGE_SERVE_ADMIN')
alter table Passenger
   drop constraint FK_PASSENGE_SERVE_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('reserves') and o.name = 'FK_RESERVES_RESERVES_PASSENGE')
alter table reserves
   drop constraint FK_RESERVES_RESERVES_PASSENGE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('reserves') and o.name = 'FK_RESERVES_RESERVES2_FLIGHT')
alter table reserves
   drop constraint FK_RESERVES_RESERVES2_FLIGHT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Admin')
            and   type = 'U')
   drop table Admin
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Airplane')
            and   type = 'U')
   drop table Airplane
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Airport')
            and   type = 'U')
   drop table Airport
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Booking_office')
            and   type = 'U')
   drop table Booking_office
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Flight')
            and   type = 'U')
   drop table Flight
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Has_Booking')
            and   name  = 'Has_Booking2_FK'
            and   indid > 0
            and   indid < 255)
   drop index Has_Booking.Has_Booking2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Has_Booking')
            and   name  = 'Has_Booking_FK'
            and   indid > 0
            and   indid < 255)
   drop index Has_Booking.Has_Booking_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Has_Booking')
            and   type = 'U')
   drop table Has_Booking
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Land_on')
            and   name  = 'Land_on2_FK'
            and   indid > 0
            and   indid < 255)
   drop index Land_on.Land_on2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Land_on')
            and   name  = 'Land_on_FK'
            and   indid > 0
            and   indid < 255)
   drop index Land_on.Land_on_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Land_on')
            and   type = 'U')
   drop table Land_on
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Passenger')
            and   name  = 'Book_ticket_FK'
            and   indid > 0
            and   indid < 255)
   drop index Passenger.Book_ticket_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Passenger')
            and   name  = 'serve_FK'
            and   indid > 0
            and   indid < 255)
   drop index Passenger.serve_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Passenger')
            and   type = 'U')
   drop table Passenger
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('reserves')
            and   name  = 'reserves2_FK'
            and   indid > 0
            and   indid < 255)
   drop index reserves.reserves2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('reserves')
            and   name  = 'reserves_FK'
            and   indid > 0
            and   indid < 255)
   drop index reserves.reserves_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('reserves')
            and   type = 'U')
   drop table reserves
go

/*==============================================================*/
/* Table: Admin                                                 */
/*==============================================================*/
create table Admin (
   Aname                varchar(20)          not null,
   Apass                varchar(8)           null,
   constraint PK_ADMIN primary key nonclustered (Aname)
)
go

/*==============================================================*/
/* Table: Airplane                                              */
/*==============================================================*/
create table Airplane (
   Seats                int                  null,
   Reg_num              varchar(20)          not null,
   Airoplane_type       varchar(20)          null,
   constraint PK_AIRPLANE primary key nonclustered (Reg_num)
)
go

/*==============================================================*/
/* Table: Airport                                               */
/*==============================================================*/
create table Airport (
   name                 varchar(20)          null,
   code                 varchar(20)          not null,
   City                 varchar(20)          null,
   Country              varchar(20)          null,
   constraint PK_AIRPORT primary key nonclustered (code)
)
go

/*==============================================================*/
/* Table: Booking_office                                        */
/*==============================================================*/
create table Booking_office (
   Office_id            int                  not null,
   Office_name          varchar(20)          null,
   constraint PK_BOOKING_OFFICE primary key nonclustered (Office_id)
)
go

/*==============================================================*/
/* Table: Flight                                                */
/*==============================================================*/
create table Flight (
   "From"               varchar(10)          null,
   "To"                 varchar(10)          null,
   Dep_date             datetime             null,
   Arrive_date          datetime             null,
   Flight_id            int                  not null,
   Class                varchar(2)           null,
   Arrive_time          datetime             null,
   Dep_time             datetime             null,
   Airlines             varchar(20)          null,
   constraint PK_FLIGHT primary key nonclustered (Flight_id)
)
go

/*==============================================================*/
/* Table: Has_Booking                                           */
/*==============================================================*/
create table Has_Booking (
   Flight_id            int                  not null,
   Office_id            int                  not null,
   constraint PK_HAS_BOOKING primary key (Flight_id, Office_id)
)
go

/*==============================================================*/
/* Index: Has_Booking_FK                                        */
/*==============================================================*/
create index Has_Booking_FK on Has_Booking (
Flight_id ASC
)
go

/*==============================================================*/
/* Index: Has_Booking2_FK                                       */
/*==============================================================*/
create index Has_Booking2_FK on Has_Booking (
Office_id ASC
)
go

/*==============================================================*/
/* Table: Land_on                                               */
/*==============================================================*/
create table Land_on (
   code                 varchar(20)          not null,
   Reg_num              varchar(20)          not null,
   constraint PK_LAND_ON primary key (code, Reg_num)
)
go

/*==============================================================*/
/* Index: Land_on_FK                                            */
/*==============================================================*/
create index Land_on_FK on Land_on (
code ASC
)
go

/*==============================================================*/
/* Index: Land_on2_FK                                           */
/*==============================================================*/
create index Land_on2_FK on Land_on (
Reg_num ASC
)
go

/*==============================================================*/
/* Table: Passenger                                             */
/*==============================================================*/
create table Passenger (
   Gender               binary(8)            null,
   Age                  int                  null,
   Pname                varchar(25)          null,
   P_id                 int                  not null,
   Aname                varchar(20)          null,
   Office_id            int                  null,
   address              varchar(20)          null,
   Contact              varchar(15)          null,
   E_mail               varchar(20)          null,
   constraint PK_PASSENGER primary key nonclustered (P_id)
)
go

/*==============================================================*/
/* Index: serve_FK                                              */
/*==============================================================*/
create index serve_FK on Passenger (
Aname ASC
)
go

/*==============================================================*/
/* Index: Book_ticket_FK                                        */
/*==============================================================*/
create index Book_ticket_FK on Passenger (
Office_id ASC
)
go

/*==============================================================*/
/* Table: reserves                                              */
/*==============================================================*/
create table reserves (
   P_id                 int                  not null,
   Flight_id            int                  not null,
   constraint PK_RESERVES primary key (P_id, Flight_id)
)
go

/*==============================================================*/
/* Index: reserves_FK                                           */
/*==============================================================*/
create index reserves_FK on reserves (
P_id ASC
)
go

/*==============================================================*/
/* Index: reserves2_FK                                          */
/*==============================================================*/
create index reserves2_FK on reserves (
Flight_id ASC
)
go

alter table Has_Booking
   add constraint FK_HAS_BOOK_HAS_BOOKI_FLIGHT foreign key (Flight_id)
      references Flight (Flight_id)
go

alter table Has_Booking
   add constraint FK_HAS_BOOK_HAS_BOOKI_BOOKING_ foreign key (Office_id)
      references Booking_office (Office_id)
go

alter table Land_on
   add constraint FK_LAND_ON_LAND_ON_AIRPORT foreign key (code)
      references Airport (code)
go

alter table Land_on
   add constraint FK_LAND_ON_LAND_ON2_AIRPLANE foreign key (Reg_num)
      references Airplane (Reg_num)
go

alter table Passenger
   add constraint FK_PASSENGE_BOOK_TICK_BOOKING_ foreign key (Office_id)
      references Booking_office (Office_id)
go

alter table Passenger
   add constraint FK_PASSENGE_SERVE_ADMIN foreign key (Aname)
      references Admin (Aname)
go

alter table reserves
   add constraint FK_RESERVES_RESERVES_PASSENGE foreign key (P_id)
      references Passenger (P_id)
go

alter table reserves
   add constraint FK_RESERVES_RESERVES2_FLIGHT foreign key (Flight_id)
      references Flight (Flight_id)
go

