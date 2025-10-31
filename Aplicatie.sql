CREATE DATABASE Aplicatie

CREATE TABLE Client
(
	ClientID int IDENTITY(1,1) NOT NULL,
	Nume nvarchar(50) NOT NULL,
	Prenume nvarchar(50) NOT NULL,
	Email nvarchar(50) NOT NULL,
	Telefon nvarchar(50) NOT NULL,
	CONSTRAINT PK_Client PRIMARY KEY(ClientID)
)	

INSERT INTO Client (Nume, Prenume, Email, Telefon) VALUES 
	('Popescu', 'Ion', 'ion.popcorn@gmail.com', '0737321967'),
	('Ionescu', 'Maria', 'maria.ioni@yahoo.com', '0723672335'),
	('Vasilescu', 'Andrei', 'andrei_vasilescu@outlook.com', '0773782491'),
	('Dumitrescu', 'Elena', 'elena.dumitrescul@gmail.com', '0741850901'),
	('Georgescu', 'Daniel', 'daniel.georgescu11@yahoo.com', '0719067456');


CREATE TABLE Eveniment
(
	EvenimentID int IDENTITY(1,1) NOT NULL,
	Categorie nvarchar(5) NOT NULL DEFAULT 'Mic',
	Durata int NOT NULL,
	Tematica nvarchar(25) DEFAULT 'Spectacol',
	CONSTRAINT PK_Eveniment PRIMARY KEY(EvenimentID),
	CONSTRAINT CHK_Eveniment_Tematica CHECK(Tematica = 'Ceremonie' 
	OR Tematica = 'Competitie' OR Tematica = 'Intrunire' OR Tematica = 'Manifestare' OR Tematica = 'Spectacol'),
	CONSTRAINT CHK_Eveniment_Categorie CHECK(Categorie = 'Mic' OR Categorie = 'Mediu' OR Categorie = 'Mare')
)

INSERT INTO Eveniment (Categorie, Durata, Tematica) VALUES
	('Mare', 180, 'Spectacol'),
	('Mic', 60, 'Ceremonie'),
	('Mediu', 120, 'Competitie'),
	('Mic', 45, 'Intrunire'),
	('Mediu', 90, 'Manifestare');



CREATE TABLE EvenimentClient 
(
	Data smalldatetime NOT NULL,
	ClientID int NOT NULL,
	EvenimentID int NOT NULL,
	Observatii nvarchar(100),
	CONSTRAINT PK_EVENIMENTCLIENT PRIMARY KEY(Data, ClientID, EvenimentID),
	CONSTRAINT FK_EVENIMENTCLIENT_Eveniment FOREIGN KEY(EvenimentID) REFERENCES Eveniment(EvenimentID),
	CONSTRAINT FK_EVENIMENTCLIENT_Client FOREIGN KEY(ClientID) REFERENCES Client(ClientID)
)


INSERT INTO EvenimentClient (Data, ClientID, EvenimentID, Observatii) VALUES
	('2024-01-15', 1, 1, 'Participare confirmata.'),
	('2024-02-20', 2, 2, 'Are nevoie de meniu vegetarian.'),
	('2024-03-10', 3, 3, NULL),
	('2024-04-25', 4, 4, NULL),
	('2024-05-30', 5, 5, 'Nu necesita aranjamente suplimentare.');


CREATE TABLE Locatie 
(
	LocatieID int NOT NULL,
	Adresa nvarchar(200) NOT NULL,
	Capacitate int NOT NULL,
	Pret decimal(8,2) NOT NULL,
	Review nvarchar(200),
	CONSTRAINT PK_Locatie PRIMARY KEY(LocatieID)
)

INSERT INTO Locatie (LocatieID, Adresa, Capacitate, Pret, Review) VALUES
	(1, 'Strada Libertatii 10, Bucuresti', 200, 1500.00, 'Locatie moderna si spatioasa.'),
	(2, 'Strada Principala 5, Cluj-Napoca', 100, 1350.00, 'Ambianta intima si eleganta.'),
	(3, 'Bulevardul Unirii 20, Timisoara', 300, 2100.00, 'Potrivita pentru evenimente mari.'),
	(4, 'Strada Mihai Viteazu 15, Brasov', 150, 1200.00, 'Aspect rustic, dar bine echipata.'),
	(5, 'Calea Victoriei 22, Constanta', 250, 1800.00, 'Vedere spectaculoasa asupra marii.');


CREATE TABLE EvenimentLocatie
(
	Data smalldatetime NOT NULL,
	Observatii nvarchar(200),
	EvenimentID int NOT NULL,
	LocatieID int NOT NULL,
	CONSTRAINT PK_EVENIMENTLOCATIE PRIMARY KEY(Data, LocatieID, EvenimentID),
	CONSTRAINT FK_EVENIMENTLOCATIE_Eveniment FOREIGN KEY(EvenimentID) REFERENCES Eveniment(EvenimentID),
	CONSTRAINT FK_EVENIMENTLOCATIE_Locatie FOREIGN KEY(LocatieID) REFERENCES Locatie(LocatieID)
)

INSERT INTO EvenimentLocatie (Data, Observatii, EvenimentID, LocatieID) VALUES
	('2024-01-15', 'Setup complet pentru eveniment.', 1, 1),
	('2024-02-20', 'Meniu vegetarian inclus.', 2, 2),
	('2024-03-10', NULL, 3, 3),
	('2024-04-25', 'Decor floral special.', 4, 4),
	('2024-05-30', 'Transport echipament inclus.', 5, 5);


CREATE TABLE Sponsor
(
	SponsorID int IDENTITY(1, 1) NOT NULL,
	NumeSponsor nvarchar(100) NOT NULL,
	Categorie nvarchar(25) NOT NULL DEFAULT 'Finante',
	Suma decimal(8, 2) NOT NULL,
	CONSTRAINT PK_Sponsor PRIMARY KEY(SponsorID),
	CONSTRAINT CHK_Sponsor_Categorie CHECK (Categorie = 'Finante' OR Categorie = 'Skincare' OR
	Categorie = 'Case de jocuri' OR Categorie = 'Bauturi' OR Categorie = 'Alimente')
)

INSERT INTO Sponsor (NumeSponsor, Categorie, Suma) VALUES
	('TechCorp', 'Finante', 5000.00),
	('GlowCare', 'Skincare', 3000.00),
	('PlayZone', 'Case de jocuri', 2000.00),
	('AquaLife', 'Bauturi', 1500.00),
	('Foodie', 'Alimente', 2500.00);


CREATE TABLE EvenimentSponsor
(
	Data smalldatetime NOT NULL,
	Observatii nvarchar(200),
	SponsorID int NOT NULL,
	EvenimentID int NOT NULL,
	CONSTRAINT PK_EVENIMENTSPONSOR PRIMARY KEY(Data, SponsorID, EvenimentID),
	CONSTRAINT FK_EVENIMENTSPONSOR_Eveniment FOREIGN KEY(EvenimentID) REFERENCES Eveniment(EvenimentID),
	CONSTRAINT FK_EVENIMENTSPONSOR_Sponsor FOREIGN KEY(SponsorID) REFERENCES Sponsor(SponsorID)
)

INSERT INTO EvenimentSponsor (Data, Observatii, SponsorID, EvenimentID) VALUES
	('2024-01-15', 'Sponsorizare pentru decor.', 1, 1),
	('2024-02-20', NULL, 2, 2),
	('2024-03-10', 'Sponsorizare pentru premii.', 3, 3),
	('2024-04-25', NULL, 4, 4),
	('2024-05-30', NULL, 5, 5);


CREATE TABLE Departament
(
	DepartamentID int IDENTITY(1, 1) NOT NULL,
	NumeDepartament nvarchar(50) NOT NULL,
	Cod int NOT NULL,
	Program nvarchar(50) NOT NULL,
	CONSTRAINT PK_Departament PRIMARY KEY(DepartamentID)
)

INSERT INTO Departament (NumeDepartament, Cod, Program) VALUES
	('Organizare', 101, '09:00-17:00'),
	('Marketing', 102, '10:00-18:00'),
	('Logistica', 103, '08:00-16:00'),
	('HR', 104, '09:00-17:00'),
	('IT', 105, '10:00-18:00');


CREATE TABLE Angajat (
	AngajatID int IDENTITY(1, 1) NOT NULL,
	DepartamentID int NOT NULL, 
	EvenimentID int NOT NULL,
	NumeAngajat nvarchar(50) NOT NULL,
	PrenumeAngajat nvarchar(50) NOT NULL,
	EmailAngajat nvarchar(50) NOT NULL,
	TelefonAngajat nvarchar(50) NOT NULL,
	Sex char(1) DEFAULT 'F',
	CONSTRAINT PK_Angajat PRIMARY KEY(AngajatID),
	CONSTRAINT CHK_Angajat_Sex CHECK (Sex = 'M' OR Sex = 'F'),
	CONSTRAINT FK_ANGAJAT_Departament FOREIGN KEY(DepartamentID) REFERENCES Departament(DepartamentID),
	CONSTRAINT FK_ANGAJAT_Eveniment FOREIGN KEY(EvenimentID) REFERENCES Eveniment(EvenimentID)
)


INSERT INTO Angajat (DepartamentID, EvenimentID, NumeAngajat, PrenumeAngajat, EmailAngajat, TelefonAngajat, Sex) VALUES
	(1, 1, 'Popa', 'Adriana', 'adriana.popa@firma.com', '0723123456', 'F'),
	(2, 2, 'Ionescu', 'Vlad', 'vlad.ionescu@firma.com', '0733123456', 'M'),
	(3, 3, 'Radu', 'Diana', 'diana.radu@firma.com', '0743123456', 'F'),
	(4, 4, 'Marin', 'Andrei', 'andrei.marin@firma.com', '0753123456', 'M'),
	(5, 5, 'Dobre', 'Cristina', 'cristina.dobre@firma.com', '0763123456', 'F');


CREATE TABLE Furnizor (
	FurnizorID int IDENTITY(1, 1) NOT NULL,
	Tip char(25) NOT NULL DEFAULT 'Echipament video',
	CantitateFurnizor int NOT NULL,
	PretFurnizor decimal(8, 2) NOT NULL,
	CONSTRAINT PK_FURNIZOR PRIMARY KEY(FurnizorID),
	CONSTRAINT CHK_FURNIZOR_Tip CHECK(Tip = 'Echipament video' OR Tip = 'Mancare' OR Tip = 'Echipament audio'
	 OR Tip = 'Costumatie' OR Tip = 'Invitati speciali')
)

INSERT INTO Furnizor (Tip, CantitateFurnizor, PretFurnizor) VALUES
	('Echipament video', 10, 5000.00),
	('Mancare', 200, 3000.00),
	('Echipament audio', 15, 4000.00),
	('Costumatie', 50, 2500.00),
	('Invitati speciali', 5, 8000.00);


CREATE TABLE EvenimentFurnizor(
	Data smalldatetime NOT NULL,
	Observatii nvarchar(200),
	EvenimentID int NOT NULL,
	FurnizorID int NOT NULL,
	CONSTRAINT PK_EVENIMENTFURNIZOR PRIMARY KEY(Data, FurnizorID, EvenimentID),
	CONSTRAINT FK_EVENIMENTFURNIZOR_Eveniment FOREIGN KEY(EvenimentID) REFERENCES Eveniment(EvenimentID),
	CONSTRAINT FK_EVENIMENTFURNIZOR_Furnizor FOREIGN KEY(FurnizorID) REFERENCES Furnizor(FurnizorID)
)

INSERT INTO EvenimentFurnizor (Data, Observatii, EvenimentID, FurnizorID) VALUES
	('2024-01-15', NULL, 1, 1),
	('2024-02-20', 'Meniu livrat.', 2, 2),
	('2024-03-10', NULL, 3, 3),
	('2024-04-25', 'Livrare costumatii.', 4, 4),
	('2024-05-30', 'Invitati confirmati.', 5, 5);

