Use EstrelaDaMorte;
GO
Use master;
GO
DROP DATABASE EstrelaDaMorte;
GO
CREATE TABLE Planetas(
IdPlaneta int primary key  NOT NULL,
Nome varchar(50) NOT NULL,
Rotacao float NOT NULL,
Orbita float NOT NULL,
Diametro float NOT NULL,
Clima varchar(50) NOT NULL,
Populacao int NOT NULL
)
GO

CREATE TABLE Pilotos(
IdPiloto int NOT NULL,
Nome varchar(200) NOT NULL,
AnoNascimento varchar(10) NOT NULL,
IdPlaneta int NOT NULL
)
GO
ALTER TABLE Pilotos ADD CONSTRAINT FK_Pilotos_Planetas FOREIGN KEY(IdPlaneta)
REFERENCES Planetas (IdPlaneta)
GO
ALTER TABLE Pilotos ADD CONSTRAINT PK_Pilotos PRIMARY KEY (IdPiloto);
GO

CREATE TABLE [dbo].[Naves](
	[idNave] [int] NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Modelo] [varchar](150) NOT NULL,
	[Passageiros] [int] NOT NULL,
	[Carga] [float] NOT NULL,
	[Classe] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Naves] PRIMARY KEY CLUSTERED 
(
	[idNave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



CREATE TABLE PilotosNaves(
IdPiloto int NOT NULL,
IdNave int NOT NULL,
FlagAutorizado bit NOT NULL
)
GO
ALTER TABLE PilotosNaves ADD CONSTRAINT PK_PilotosNaves PRIMARY KEY(IdPiloto, IdNave);
GO
ALTER TABLE PilotosNaves ADD CONSTRAINT FK_PilotosNaves_Pilotos FOREIGN KEY(IdPiloto)
REFERENCES Pilotos (IdPiloto)
GO
ALTER TABLE PilotosNaves ADD CONSTRAINT FK_PilotosNaves_Naves FOREIGN KEY(IdNave)
REFERENCES Naves (IdNave)
GO
ALTER TABLE PilotosNaves ADD CONSTRAINT DF_PilotosNaves_FlagAutorizado DEFAULT (1) FOR FlagAutorizado
GO

CREATE TABLE HistoricoViagens(
IdNave int NOT NULL,
IdPiloto int NOT NULL,
DtSaida datetime NOT NULL,
DtChegada datetime NULL
)
GO

ALTER TABLE HistoricoViagens ADD CONSTRAINT FK_HistoricoViagens_PilotosNaves FOREIGN KEY(idNave, idPiloto)
REFERENCES PilotosNaves (IdPiloto, IdNave)

go
select * from Pilotos;
select * from Planetas;
select * from Naves;