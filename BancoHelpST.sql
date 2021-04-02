--DROP DATABASE HelpST
--Create database HelpST
Use HelpST
GO

CREATE PROCEDURE InsertNovaSala
	@NomeAmbiente VARCHAR(50),
	@Data DATE,
	@CodigoSala INTEGER OUTPUT
AS
BEGIN
	INSERT INTO Ambiente values (@NomeAmbiente, @Data);
	SET @CodigoSala = SCOPE_IDENTITY();
END
GO

CREATE TABLE Usuario (
    Cod_User INTEGER IDENTITY(1,1)PRIMARY KEY,
    Login_User VARCHAR (30) not null,
    Usuario VARCHAR (70) not null,
    Senha VARCHAR (30) not null,
	Cargo varchar (30) check (Cargo in('Professor','Coordenador','Secretaria','Manutençao'))not null,
    Hierarquia VARCHAR (30) check (Hierarquia in('Administrador','Usuario'))not null, 
    Matricula VARCHAR (100)
);

CREATE TABLE Manutencao (
    Comentar VARCHAR (120) not null,
	Cod_Chamado  INTEGER FOREIGN KEY REFERENCES Chamados(Cod_Chamado),
    Cod_Manutencao INTEGER IDENTITY(1,1)PRIMARY KEY,
);

CREATE TABLE Ambiente(
    Sala VARCHAR (30) not null,
    Data_de_Criacao DATE not null,
    Cod_Ambiente INTEGER IDENTITY(1,1)PRIMARY KEY
);

select * from  Ambiente

CREATE TABLE Componente(
	Cod_Componente INTEGER IDENTITY(1,1) PRIMARY KEY,
	Pc VARCHAR(10),
    Cod_Ambiente INTEGER FOREIGN KEY REFERENCES Ambiente(Cod_Ambiente)
	);

CREATE TABLE Chamados (
    Cod_Chamado INTEGER IDENTITY(1,1)PRIMARY KEY,
	Cod_User INTEGER FOREIGN KEY REFERENCES Usuario(Cod_User),
    Titulo varchar (50)not null,
    Descricao VARCHAR (200) not null,
    Andamento VARCHAR (30)  check(Andamento in('Em Andamento','Finalizado')),
	Cod_Ambiente INTEGER FOREIGN KEY REFERENCES Ambiente(Cod_Ambiente),
	Cod_Componente INTEGER FOREIGN KEY REFERENCES Componente(Cod_Componente),
	Cod_Manutencao integer foreign key references Manutencao(Cod_Manutencao),
	Dia_Hora DATE not null,
	Nivel varchar (30), check (Nivel in('Facil','Facil/Medio','Medio','Medio/Dificil','Dificil')),
	Excluidos varchar(30) check (Excluidos in('Excluido','n')),
	Imagem VARCHAR (70),
);


insert into Usuario (Login_User,Usuario,Senha,Hierarquia,Matricula,Cargo) values ('Paulo','Paulo','1234','Administrador','20-11-2004','Manutençao')
insert into Usuario (Login_User,Usuario,Senha,Hierarquia,Matricula,Cargo) values ('Lais','Lais','4321','Usuario','01-01-2017','Professor')
insert into Usuario (Login_User,Usuario,Senha,Hierarquia,Matricula,Cargo) values ('Pedro','Pedro','7777','Usuario','10-12-2017','Secretaria')
select * from Usuario


select * from Ambiente

select * from Componente order by Cod_Ambiente
insert into Componente(Pc,Cod_Ambiente) values ('PC1',3)
insert into Componente(Pc,Cod_Ambiente) values ('PC2',3)
insert into Componente(Pc,Cod_Ambiente) values ('PC1',1)
insert into Componente(Pc,Cod_Ambiente) values ('PC1',2)
select * from Componente where Cod_Ambiente = 19

insert into Ambiente (Sala,Data_de_Criacao) values ('Lab1','01-01-2008')
insert into Ambiente (Sala,Data_de_Criacao) values ('Lab2','01-01-2008')
insert into Ambiente (Sala,Data_de_Criacao) values ('Lab3','01-01-2008')
insert into Ambiente (Sala,Data_de_Criacao) values ('Lab4','01-01-2008')
insert into Ambiente (Sala,Data_de_Criacao) values ('Lab5','01-01-2008')
insert into Ambiente (Sala,Data_de_Criacao) values ('Lab6','01-01-2008')
insert into Ambiente (Sala,Data_de_Criacao) values ('Lab7','01-01-2008')
insert into Ambiente (Sala,Data_de_Criacao) values ('Sala1','01-01-2008')
insert into Ambiente (Sala,Data_de_Criacao) values ('Sala2','01-01-2008')
insert into Ambiente (Sala,Data_de_Criacao) values ('Sala3','01-01-2008')
insert into Ambiente (Sala,Data_de_Criacao) values ('Sala4','01-01-2008')
insert into Ambiente (Sala,Data_de_Criacao) values ('Sala5','01-01-2008')
insert into Ambiente (Sala,Data_de_Criacao) values ('Sala6','01-01-2008')
insert into Ambiente (Sala,Data_de_Criacao) values ('Sala7','01-01-2008')
insert into Ambiente (Sala,Data_de_Criacao) values ('Coordenaçao','01-01-2008')
insert into Ambiente (Sala,Data_de_Criacao) values ('Secretaria','01-01-2008')

insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos,Cod_Ambiente,Cod_Componente) values ('Teste','aaaaaaaaaaa','Em Andamento','1','2014-11-01 13:00','n',3,1)
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos,Cod_Ambiente,Cod_Componente) values ('Teste1','bbbbbbbbbbb','Finalizado','2','2014-11-01 13:00','Excluido',8,2)
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos,Cod_Ambiente,Cod_Componente) values ('Teste2','cccccccccc','Em Andamento','1','2014-11-01 13:00','Excluido',4,2)
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos,Cod_Ambiente,Cod_Componente) values ('Teste3','dddddddddd','Em Andamento','2','2014-11-01 13:00','n',3,1)
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos,Cod_Ambiente,Cod_Componente) values ('Teste4','eeeeeeeeee','Em Andamento','1','2014-11-01 13:00','n',3,1)
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos,Cod_Ambiente,Cod_Componente) values ('Teste5','ffffffffff','Finalizado','1','2014-11-01 13:00','n',3,1)
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos,Cod_Ambiente,Cod_Componente) values ('Teste6','hhhhhhhhhh','Em Andamento','2','2014-11-01 13:00','n',3,1)
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos,Cod_Ambiente,Cod_Componente) values ('Teste7','gggggggggg','Em Andamento','1','2014-11-01 13:00','Excluido',3,1)
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos,Cod_Ambiente,Cod_Componente) values ('Teste8','iiiiiiiiii','Finalizado','1','2014-11-01 13:00','n',3,1)






insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia,Hora,Excluidos,Cod_Ambiente) values ('Teste','aaaaaaaaaaa','Em Andamento','2','2014-11-01','13:00','n',3)

select * from Usuario
select * from  Ambiente
select * from  Componente
select * from  Chamados

 select e1.Ambiente,v2.Cod_Componente
from Ambiente e1,Componente v2

Drop table Usuario
Drop Table Chamados
Drop Table Componente
Drop Table Ambiente
Drop Table Manutencao
Select Hierarquia from Usuario 

Select c.Nome,a.Ambiente from Componente c,Ambiente a where  a.Cod_Ambiente = c.Cod_Componente

insert into Componente(Pc,Cod_Ambiente) values ('PC2',1)
insert into Componente(Pc,Cod_Ambiente) values ('PC3',1)
insert into Componente(Pc,Cod_Ambiente) values ('PC4',1)
insert into Componente(Pc,Cod_Ambiente) values ('PC5',1)


-- testes--
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos) values ('Teste','aaaaaaaaaaa','Em Andamento','1','2014-11-01 13:00','n')
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos) values ('Teste1','bbbbbbbbbbb','Finalizado','2','2014-11-01 13:00','Excluido')
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos) values ('Teste2','cccccccccc','Em Andamento','1','2014-11-01 13:00','Excluido')
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos) values ('Teste3','dddddddddd','Em Andamento','2','2014-11-01 13:00','n')
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos) values ('Teste4','eeeeeeeeee','Em Andamento','1','2014-11-01 13:00','n')
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos) values ('Teste5','ffffffffff','Finalizado','1','2014-11-01 13:00','n')
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos) values ('Teste6','hhhhhhhhhh','Em Andamento','2','2014-11-01 13:00','n')
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos) values ('Teste7','gggggggggg','Em Andamento','1','2014-11-01 13:00','Excluido')
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos) values ('Teste8','iiiiiiiiii','Finalizado','1','2014-11-01 13:00','n')
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos) values ('Teste8','iiiiiiiiii','Finalizado','1','2014-11-01 13:00','n')
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos) values ('Teste9','iiiiiiiiii','Finalizado','3','2014-11-01 13:00','n')
insert into Chamados(Titulo,Descricao,Andamento,Cod_User,Dia_Hora,Excluidos,Cod_Ambiente,Cod_Componente) values ('Teste9','iiiiiiiiii','Finalizado','3','2014-11-01 13:00','n',3,5)
select * from  Chamados

Select u.Nome,c.Cod_Chamado from Usuario u,Chamados c where u.Cod_User = Cod_Chamado

Select c.Cod_Chamado,u.Nome,c.Titulo,c.Descricao,c.Cod_Ambiente,c.Cod_Componente,c.Dia_Hora,c.Andamento from Chamados c,Usuario u where c.Cod_User = u.Cod_User 
Select c.Cod_Chamado,u.Usuario,p.Pc,a.Sala,c.Titulo,c.Descricao,c.Dia_Hora,c.Andamento,c.Excluidos,c.Nivel from Chamados c,Usuario u, Componente p,Ambiente a where c.Cod_User = u.Cod_User and c.Cod_Componente = p.Cod_componente and c.Cod_Ambiente = a.Cod_Ambiente
Select Cod_Chamado,Usuario,Pc,Sala,Titulo,Descricao,Dia_Hora,c.Andamento,c.Excluidos,c.Nivel from Chamados c,Usuario u, Componente p,Ambiente a where c.Cod_User = u.Cod_User and c.Cod_Componente = p.Cod_componente and c.Cod_Ambiente = a.Cod_Ambiente


--Mudar os nomes das variaves no vb 

UPDATE Chamados set Titulo = 'Teste'  where Cod_Chamado = 2

select c.Cod_Chamado,u.Usuario,p.Pc,a.Sala,c.Titulo,c.Descricao,c.Dia_Hora,c.Andamento,c.Excluidos,c.Nivel from Chamados c,Usuario u, Componente p,Ambiente a


