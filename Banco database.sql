Create database Banco_Eje
go
use Banco_Eje
go

create table cliente (
cod_cliente int,
nombre varchar(50),
apellido varchar(50),
dni int
constraint pk_cod_cliente primary key (cod_cliente)
)
go

create table Tipo(
cod_tipo int,
tipo varchar (50)
constraint pk_cod_tipo primary key (cod_tipo)
)
go

create table Cuenta(
cod_cuenta int identity (1,1),
cbu int,
saldo int,
cod_tipo int,
cod_cliente int,
ultimoMovimiento varchar(50)

constraint pk_cod_cuenta primary key (cod_cuenta),
constraint fk_tipo foreign key (cod_tipo) references Tipo(cod_tipo),
constraint fk_cliente foreign key (cod_cliente) references cliente(cod_cliente)

)
go


insert into  cliente values(1,'pedro','carerez',34234674)
insert into  cliente values(2,'Julian','Alfonso',34234674)
insert into  cliente values(3,'Martina','Rivetta',34234674)


insert into Tipo values (1,'Corriente')
insert into Tipo values (2,'Trabajo')
insert into Tipo values (3,'Peronal')

	

create Procedure SP_CONSULTAR_CLIENTES
AS
begin
select * from cliente
end
go

create Procedure SP_CONSULTAR_tipo
AS
begin
select * from Tipo
end
go



