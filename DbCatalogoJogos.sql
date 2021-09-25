USE master;
GO
DROP DATABASE DbCatalogoJogos;
GO

CREATE DATABASE DbCatalogoJogos;
GO

USE DbCatalogoJogos;
GO

CREATE TABLE jogos(
Id UNIQUEIDENTIFIER primary key default NEWID(),
Nome varchar(200) not null,
Produtora varchar(200) not null,
Preco float not null
);


INSERT INTO jogos(Id, Nome, Produtora, Preco) 
VALUES(default, 'Fifa 21', 'EA', '200'),
(default, 'Fifa 20', 'EA', '190'),
(default, 'Fifa 19', 'EA', '180'),
(default, 'Fifa 18', 'EA', '170'),
(default, 'Street Fighter V', 'Capcom', '80'),
(default, 'Grand Theft Auto V', 'Rockstar', '190');

select * from jogos;
		