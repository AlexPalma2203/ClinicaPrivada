create database SistemaClinico
go
use SistemaClinico
Go
Create table Usuario(
Id_Usuario nvarchar (20) adminprimary key ,
Nombre_Usuario varchar(50),
Apellido_Usuario varchar(50),
Cargo_Usuario varchar(30),
Contraseña_Usuasio nvarchar(10)
);
Go
Create table Paciente(
Dui int primary key not null,
Nombre_Paciente varchar(50),
Apellidos_Paciente varchar(50),
Sexo_Paciente nvarchar(1),
Telefono_Paciente int,
Direccion_Paciente varchar(250),
EstadoCivil nvarchar(20),
FechaNacimiento nvarchar(20),
);
Go
Create table Expediente(
Num_Expediente int identity (1,1) primary key,
FechaCreacion datetime,
Antecedentes_Clinicos varchar(100),
Medicamentos_Escritos varchar(200),
tipo_sangre varchar(5),
dui int references Paciente(Dui)
);
Go
Create table Diagnostico(
Id_Diagnostico int primary key identity(1,1),
Estado varchar(50),
Enfermedad nvarchar(250),
Peso float,
estatura float,
presion float,
fechaDiagnostico datetime,
temperatura float,
detalles varchar(200),
recomendaciones varchar(200),
Num_Expediente int references Expediente(Num_Expediente)
);
Go

Create table Citas(
num_cita int primary key identity(1,1),
Fecha_HoraCreacion datetime,
Fecha_HoraCita datetime unique,
Motivo varchar(100),
CreadoPor nvarchar(100),
Precio float,
dui int references Paciente(dui));
Go
Create table Movimientos(
Id_Movimiento int primary key identity (1,1),
Tipo_Movimiento nvarchar(50),
Fecha date,
Detalles nvarchar(150),
num_cita int references Citas(num_cita ),
Num_Expediente int references Expediente(Num_Expediente),
Id_Usuario nvarchar (20) references Usuario(Id_Usuario)
);

go
insert into Usuario values ('admin','Alex','Palma','Administrador','admin')

go
insert into Paciente values (1,'Nombre','Apellido','M',7875457,'Soyapango','ALoneLikeJosue','17/04/2001')

go
insert into Expediente values (SYSDATETIME(),'','','O RH+',1)
go
update Usuario set Id_Usuario='admin',Nombre_Usuario='',Apellido_Usuario='',Cargo_Usuario='',Contraseña_Usuasio='admin' where Id_Usuario='admin'
--select *  from Expediente E inner join Paciente P on E.dui = P.Dui where E.dui = 1 and P.Dui=1
--select * from Citas where dui = 2 and Fecha_HoraCita=(select min(Fecha_HoraCita) from Citas where Fecha_HoraCita >= SYSDATETIME() and dui =2)
--drop database SistemaClinico
--insert into Citas values (SYSDATETIME(),convert(datetime,'21-05-20',5),'',1)
--insert into Citas values (SYSDATETIME(),convert(datetime,'21-05-19',5),'',1)
--insert into Citas values (SYSDATETIME(),convert(datetime,'22-06-21',5),'',1)
--select* from Paciente P inner join Citas C on C.dui = P.Dui where P.dui = 1 and C.dui = 1
--select* from Paciente P inner join Citas C on C.dui = P.Dui where P.dui = 2 and C.dui = 2
--select* from Paciente P inner join Citas C on C.dui = P.Dui where P.dui = 2 and C.dui = 2 and Fecha_HoraCita = (select min(Fecha_HoraCita) from Citas where Fecha_HoraCita >= SYSDATETIME() and dui =2) 
-- select * from Usuario
--delete from Citas where dui = 1
--Update Citas set Fecha_HoraCita=SYSDATETIME(),Motivo='',CreadoPor='',Precio=10 where dui = 2 and Fecha_HoraCita=(select min(Fecha_HoraCita) from Citas where Fecha_HoraCita >= SYSDATETIME() and dui =2)
--select* from Paciente P inner join Citas C on C.dui = P.Dui where P.dui = 2 and C.dui = 2 and Fecha_HoraCita = (select min(Fecha_HoraCita) from Citas where Fecha_HoraCita >= SYSDATETIME() and dui=2)