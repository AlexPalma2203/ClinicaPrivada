create database SistemaClinico
go
use SistemaClinico
Go
Create table Usuario(
Id_Usuario nvarchar (20) primary key ,
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


go


select num_cita,Fecha_HoraCita,Fecha_HoraCreacion,Motivo,CreadoPor,Precio,P.dui,Nombre_Paciente,Apellidos_Paciente from Citas C inner join Paciente P on C.dui = P.Dui 



/*Insertar Usuarios
roles:
Administrador
Doctor
Enfermera
*/

insert into Usuario values ('UserName','Nombre','Apellido','Administrador','Contraseña')


/*Insertar Paciente Y Expediente
--Sexo: F o M
--Estado Civil: 
Soltero
Casado
Divorsiado
--Sangre:
O -
O +
A -
A +
B -
B +
AB -
AB +
*/
insert into Paciente values (Dui,'Nombre','Apellido','M',telefono,'Direccion','Soltero','FechaNac')
go
insert into Expediente values (SYSDATETIME(),'Antecedentes','Medicamentos','Sangre',Dui);

/*Insertar Diagnostico*/
insert into Diagnostico values ('Enfermedad','Estado',peso,estatura,presion,SYSDATETIME(),temperatura,'detalles','recomendaciones',numExpe)

/*Insertar Citas*/
insert into Citas values (SYSDATETIME(),fecha,'Motivo','Nombre de Usuario',precio,dui)


--Paciente
--1
--select * from Expediente E inner join Paciente P on E.dui = P.Dui where E.dui = @dui and P.Dui=@dui 
--2
--select* from Paciente P inner join Citas C on C.dui = P.Dui where P.dui = @dui and C.dui = @dui and Fecha_HoraCita = (select min(Fecha_HoraCita) from Citas where Fecha_HoraCita >= SYSDATETIME() and dui=@dui)
--3
--update Expediente set Antecedentes_Clinicos = @antecendetes, Medicamentos_Escritos= @medicamentos, tipo_sangre= @sangre where dui = @dui 
--4
--update Paciente set Nombre_Paciente= @nombre , Apellidos_Paciente = @apellido , Sexo_Paciente = @sexo, Telefono_Paciente = @telefono, Direccion_Paciente = @direccion ,EstadoCivil = @estadocivil , FechaNacimiento =@fechanac where dui = @dui
--5
--Insert into Paciente values(@dui,@nombre,@apellido,@sexo,@telefono,@direccion,@estadocivil,@fechanac)
--6
--insert into Expediente values (SYSDATETIME(),@antecendetes,@medicamentos,@sangre,@dui)
--7
--delete from Expediente where dui = @dui ; delete from Paciente where Dui = @dui
--8
--
--9
--insert into Citas values (SYSDATETIME(),@fechaCita,@motivo,@CreadoPor,@Precio,@dui)
--10
--Update Citas set Fecha_HoraCita=@fechaCita,Motivo=@motivo,CreadoPor=@CreadoPor,Precio=@Precio where dui = @dui and Fecha_HoraCita=(select min(Fecha_HoraCita) from Citas where Fecha_HoraCita >= SYSDATETIME() and dui =@dui)
--11
--delete from citas where dui = @dui and Fecha_HoraCita=(select min(Fecha_HoraCita) from Citas where Fecha_HoraCita >= SYSDATETIME() and dui =@dui)
--Usuario
--1
--Select * from Usuario where Id_Usuario = @usuario and Contraseña_Usuasio = @contraseña
--2
--update Usuario set Id_Usuario=@usuario,Nombre_Usuario=@nombre,Apellido_Usuario=@apellido,Contraseña_Usuasio=@contraseña where Id_Usuario=@usuario















