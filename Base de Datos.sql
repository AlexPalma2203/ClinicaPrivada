create database SistemaClinico
go
use SistemaClinico
Go
Create table Usuario(
Id_Usuario nvarchar (20) primary key,
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
Enfermedad varchar(250),
Estado varchar(50),
peso double,
estatura double,
presion double,
fechaDiagnostico datetime,
temperatura double,
detalles varchar(200),
recomendaciones varchar(200),
Num_Expediente int references Expediente(Num_Expediente)
);
Go

Create table Citas(
num_cita int primary key identity(1,1),
Fecha_Hora datetime,
Motivo varchar(100),
Id_Diagnostico int references Diagnostico(Id_Diagnostico ),
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
select * from Expediente E inner join Paciente P on E.dui = P.Dui where E.dui = 1 and P.Dui=1


