/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     5/26/2022 7:02:10 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACCOUNT') and o.name = 'FK_ACCOUNT_ACCTS_BRANCH')
alter table ACCOUNT
   drop constraint FK_ACCOUNT_ACCTS_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH') and o.name = 'FK_BRANCH_BRANCHES_BANK')
alter table BRANCH
   drop constraint FK_BRANCH_BRANCHES_BANK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DEALS_WITH') and o.name = 'FK_DEALS_WI_DEALS_WIT_EMPLOYEE')
alter table DEALS_WITH
   drop constraint FK_DEALS_WI_DEALS_WIT_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DEALS_WITH') and o.name = 'FK_DEALS_WI_DEALS_WIT_CUSTOMER')
alter table DEALS_WITH
   drop constraint FK_DEALS_WI_DEALS_WIT_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'FK_EMPLOYEE_WORKS_IN_BRANCH')
alter table EMPLOYEE
   drop constraint FK_EMPLOYEE_WORKS_IN_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HAS') and o.name = 'FK_HAS_HAS_ACCOUNT')
alter table HAS
   drop constraint FK_HAS_HAS_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HAS') and o.name = 'FK_HAS_HAS2_CUSTOMER')
alter table HAS
   drop constraint FK_HAS_HAS2_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'FK_LOAN_ADDS_EMPLOYEE')
alter table LOAN
   drop constraint FK_LOAN_ADDS_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'FK_LOAN_OFFERS_BRANCH')
alter table LOAN
   drop constraint FK_LOAN_OFFERS_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAKES') and o.name = 'FK_TAKES_TAKES_LOAN')
alter table TAKES
   drop constraint FK_TAKES_TAKES_LOAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAKES') and o.name = 'FK_TAKES_TAKES2_CUSTOMER')
alter table TAKES
   drop constraint FK_TAKES_TAKES2_CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ACCOUNT')
            and   name  = 'ACCTS_FK'
            and   indid > 0
            and   indid < 255)
   drop index ACCOUNT.ACCTS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACCOUNT')
            and   type = 'U')
   drop table ACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANK')
            and   type = 'U')
   drop table BANK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BRANCH')
            and   name  = 'BRANCHES_FK'
            and   indid > 0
            and   indid < 255)
   drop index BRANCH.BRANCHES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BRANCH')
            and   type = 'U')
   drop table BRANCH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DEALS_WITH')
            and   name  = 'DEALS_WITH_FK'
            and   indid > 0
            and   indid < 255)
   drop index DEALS_WITH.DEALS_WITH_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DEALS_WITH')
            and   name  = 'DEALS_WITH2_FK'
            and   indid > 0
            and   indid < 255)
   drop index DEALS_WITH.DEALS_WITH2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DEALS_WITH')
            and   type = 'U')
   drop table DEALS_WITH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLOYEE')
            and   name  = 'WORKS_IN_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLOYEE.WORKS_IN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE')
            and   type = 'U')
   drop table EMPLOYEE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HAS')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index HAS.HAS_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HAS')
            and   name  = 'HAS2_FK'
            and   indid > 0
            and   indid < 255)
   drop index HAS.HAS2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HAS')
            and   type = 'U')
   drop table HAS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOAN')
            and   name  = 'ADDS_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOAN.ADDS_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOAN')
            and   name  = 'OFFERS_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOAN.OFFERS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAN')
            and   type = 'U')
   drop table LOAN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TAKES')
            and   name  = 'TAKES_FK'
            and   indid > 0
            and   indid < 255)
   drop index TAKES.TAKES_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TAKES')
            and   name  = 'TAKES2_FK'
            and   indid > 0
            and   indid < 255)
   drop index TAKES.TAKES2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAKES')
            and   type = 'U')
   drop table TAKES
go

create database Bank
/*==============================================================*/
/* Table: ACCOUNT                                               */
/*==============================================================*/
create table ACCOUNT (
   ANUMBER              int                  not null,
   BRANCH_NO            int                  not null,
   BALANCE              int                  not null,
   TYPE                 varchar(20)          null,
   constraint PK_ACCOUNT primary key nonclustered (ANUMBER)
)
go

/*==============================================================*/
/* Index: ACCTS_FK                                              */
/*==============================================================*/
create index ACCTS_FK on ACCOUNT (
BRANCH_NO ASC
)
go

/*==============================================================*/
/* Table: BANK                                                  */
/*==============================================================*/
create table BANK (
   NAME                 varchar(50)          not null,
   CODE                 varchar(10)          not null,
   ADDRESS              varchar(100)         null,
   constraint PK_BANK primary key nonclustered (CODE)
)
go

/*==============================================================*/
/* Table: BRANCH                                                */
/*==============================================================*/
create table BRANCH (
   BRANCH_NO            int                  not null,
   CODE                 varchar(10)          not null,
   ADDRESS              varchar(100)         null,
   constraint PK_BRANCH primary key nonclustered (BRANCH_NO)
)
go

/*==============================================================*/
/* Index: BRANCHES_FK                                           */
/*==============================================================*/
create index BRANCHES_FK on BRANCH (
CODE ASC
)
go

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   SSN                  int                  not null,
   CNAME                varchar(50)          not null,
   PHONE                int                  null,
   ADDRESS              varchar(100)         null,
   CUSERNAME            varchar(25)          not null,
   CPASSWORD            varchar(20)          null,
   constraint PK_CUSTOMER primary key nonclustered (SSN, CUSERNAME)
)
go

/*==============================================================*/
/* Table: DEALS_WITH                                            */
/*==============================================================*/
create table DEALS_WITH (
   BRANCH_NO            int                  not null,
   EUSERNAME            varchar(25)          not null,
   SSN                  int                  not null,
   CUSERNAME            varchar(25)          not null,
   constraint PK_DEALS_WITH primary key nonclustered (BRANCH_NO, EUSERNAME, SSN, CUSERNAME)
)
go

/*==============================================================*/
/* Index: DEALS_WITH2_FK                                        */
/*==============================================================*/
create index DEALS_WITH2_FK on DEALS_WITH (
SSN ASC,
CUSERNAME ASC
)
go

/*==============================================================*/
/* Index: DEALS_WITH_FK                                         */
/*==============================================================*/
create index DEALS_WITH_FK on DEALS_WITH (
BRANCH_NO ASC,
EUSERNAME ASC
)
go

/*==============================================================*/
/* Table: EMPLOYEE                                              */
/*==============================================================*/
create table EMPLOYEE (
   BRANCH_NO            int                  not null,
   NAME                 varchar(50)          null,
   EMAIL                varchar(200)         null,
   EUSERNAME            varchar(25)          not null,
   EPASSWORD            varchar(20)          null,
   constraint PK_EMPLOYEE primary key nonclustered (BRANCH_NO, EUSERNAME)
)
go

/*==============================================================*/
/* Index: WORKS_IN_FK                                           */
/*==============================================================*/
create index WORKS_IN_FK on EMPLOYEE (
BRANCH_NO ASC
)
go

/*==============================================================*/
/* Table: HAS                                                   */
/*==============================================================*/
create table HAS (
   ANUMBER              int                  not null,
   SSN                  int                  not null,
   CUSERNAME            varchar(25)          not null,
   constraint PK_HAS primary key nonclustered (ANUMBER, SSN, CUSERNAME)
)
go

/*==============================================================*/
/* Index: HAS2_FK                                               */
/*==============================================================*/
create index HAS2_FK on HAS (
SSN ASC,
CUSERNAME ASC
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/
create index HAS_FK on HAS (
ANUMBER ASC
)
go

/*==============================================================*/
/* Table: LOAN                                                  */
/*==============================================================*/
create table LOAN (
   LNUMBER              int                  not null,
   BRANCH_NO            int                  not null,
   EMP_BRANCH_NO        int                  not null,
   EUSERNAME            varchar(25)          not null,
   TYPE                 varchar(20)          not null,
   AMOUNT               int                  not null,
   constraint PK_LOAN primary key nonclustered (LNUMBER)
)
go

/*==============================================================*/
/* Index: OFFERS_FK                                             */
/*==============================================================*/
create index OFFERS_FK on LOAN (
BRANCH_NO ASC
)
go

/*==============================================================*/
/* Index: ADDS_FK                                               */
/*==============================================================*/
create index ADDS_FK on LOAN (
EMP_BRANCH_NO ASC,
EUSERNAME ASC
)
go

/*==============================================================*/
/* Table: TAKES                                                 */
/*==============================================================*/
create table TAKES (
   LNUMBER              int                  not null,
   SSN                  int                  not null,
   CUSERNAME            varchar(25)          not null,
   constraint PK_TAKES primary key nonclustered (LNUMBER, SSN, CUSERNAME)
)
go

/*==============================================================*/
/* Index: TAKES2_FK                                             */
/*==============================================================*/
create index TAKES2_FK on TAKES (
SSN ASC,
CUSERNAME ASC
)
go

/*==============================================================*/
/* Index: TAKES_FK                                              */
/*==============================================================*/
create index TAKES_FK on TAKES (
LNUMBER ASC
)
go

alter table ACCOUNT
   add constraint FK_ACCOUNT_ACCTS_BRANCH foreign key (BRANCH_NO)
      references BRANCH (BRANCH_NO)
go

alter table BRANCH
   add constraint FK_BRANCH_BRANCHES_BANK foreign key (CODE)
      references BANK (CODE)
go

alter table DEALS_WITH
   add constraint FK_DEALS_WI_DEALS_WIT_EMPLOYEE foreign key (BRANCH_NO, EUSERNAME)
      references EMPLOYEE (BRANCH_NO, EUSERNAME)
go

alter table DEALS_WITH
   add constraint FK_DEALS_WI_DEALS_WIT_CUSTOMER foreign key (SSN, CUSERNAME)
      references CUSTOMER (SSN, CUSERNAME)
go

alter table EMPLOYEE
   add constraint FK_EMPLOYEE_WORKS_IN_BRANCH foreign key (BRANCH_NO)
      references BRANCH (BRANCH_NO)
go

alter table HAS
   add constraint FK_HAS_HAS_ACCOUNT foreign key (ANUMBER)
      references ACCOUNT (ANUMBER)
go

alter table HAS
   add constraint FK_HAS_HAS2_CUSTOMER foreign key (SSN, CUSERNAME)
      references CUSTOMER (SSN, CUSERNAME)
go

alter table LOAN
   add constraint FK_LOAN_ADDS_EMPLOYEE foreign key (EMP_BRANCH_NO, EUSERNAME)
      references EMPLOYEE (BRANCH_NO, EUSERNAME)
go

alter table LOAN
   add constraint FK_LOAN_OFFERS_BRANCH foreign key (BRANCH_NO)
      references BRANCH (BRANCH_NO)
go

alter table TAKES
   add constraint FK_TAKES_TAKES_LOAN foreign key (LNUMBER)
      references LOAN (LNUMBER)
go

alter table TAKES
   add constraint FK_TAKES_TAKES2_CUSTOMER foreign key (SSN, CUSERNAME)
      references CUSTOMER (SSN, CUSERNAME)
go

alter table loan
add status varchar(10)






insert into bank 
values('cairo','c123','downtown')

insert into bank 
values('CIB','a731','cairo')


insert into branch 
values(11,'c123','6th of october')

insert into branch 
values(21,'c123','alexandria')

insert into branch 
values(12,'a731','aldoki')


insert into employee
values (11,'ali','ali2gmail.com','ali555','12347')

insert into employee
values (11,'ahmed','ahmed@gmial.com','admin111','77778')

insert into employee
values (12,'mona','mona@gmail.com','mona54','56789')


insert into employee 
values (12,'sara','sara@gmial.com','admin441','10100')


insert into customer 
values (2020,'salma',016782,'aldoki','salma','3923')

insert into customer
values (2222,'dina',0102997,'giza','dina11','2123')


insert into deals_with
values(11,'ali555',2020,'salma')

insert into deals_with
values(12,'mona54',2222,'dina11')


insert into loan
values (119,11,11,'ali555','personal',50000,'accepted')

insert into loan
values (220,11,11,'ali555','industry',100000,'accepted')


insert into takes 
values(119,2020,'salma')

insert into takes 
values(220,2020,'salma')


insert into account
values(1111,12,5500,'expenses')


insert into has
values(1111,2222,'dina11')


/* --------------------------a---------------------- */
select  distinct BRANCH.branch_no
From BRANCH, loan
where BRANCH.branch_no != loan.branch_no  
intersect 
select  distinct BRANCH.branch_no
From BRANCH, account
where BRANCH.branch_no != account.branch_no  


/* --------------------------b---------------------- */
Select distinct BRANCH.branch_no 
From BRANCH, EMPLOYEE
except
Select distinct BRANCH.branch_no 
From BRANCH, EMPLOYEE
where BRANCH.branch_no = EMPLOYEE.branch_no


/* --------------------------c---------------------- */
select top 1 L.EUSERNAME,L.BRANCH_NO, count (L.LNUMBER) as NoOfLoans 
from LOAN L
group by L.EUSERNAME,L.BRANCH_NO
order by NoOfLoans  desc


/* --------------------------d---------------------- */
SELECT distinct TAKES.SSN,CUSTOMER.CNAME, count(takes.SSN) AS number_of_loans
FROM TAKES join CUSTOMER
on CUSTOMER.SSN=TAKES.SSN
GROUP BY TAKES.SSN,CUSTOMER.CNAME


/* --------------------------e---------------------- */
SELECT distinct CUSTOMER.SSN,CUSTOMER.CNAME
FROM TAKES , CUSTOMER
WHERE  CUSTOMER.SSN<>TAKES.SSN


/* --------------------------f---------------------- */
SELECT CUSTOMER.SSN,CUSTOMER.CNAME,CUSTOMER.ADDRESS,CUSTOMER.CPASSWORD,CUSTOMER.CUSERNAME,CUSTOMER.PHONE,COUNT(EUSERNAME)AS NUM_OF_EMPLOYEE
FROM DEALS_WITH join CUSTOMER
on CUSTOMER.SSN=DEALS_WITH.SSN
GROUP BY CUSTOMER.CNAME,CUSTOMER.SSN,CUSTOMER.ADDRESS,CUSTOMER.CPASSWORD,CUSTOMER.CUSERNAME,CUSTOMER.PHONE

