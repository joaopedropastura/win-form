use master

go

if (exists(select * from sys.databases where name = 'crudWinForm'))
	drop database crudWinForm
go


create database crudWinForm

go

use crudWinForm

go

create table PRODUTO
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	NAME VARCHAR(100),
	PRECO MONEY
)


create table ESTOQUE
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	PRODUTO_ID INT REFERENCES PRODUTO(ID),
	QUANTIDADE INT
)


select * from ESTOQUE