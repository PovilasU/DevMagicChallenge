--thinking process

-- 1. create database "tribeca_test"
CREATE DATABASE tribeca_test;

-- 2. create table "clients". Primary key makes sure that id is unique
CREATE TABLE Clients (
    clientId int PRIMARY KEY NOT NULL,	
	Name VARCHAR(255)
);

-- 3. create table "Offices"
-- foreign keys creates clear relactionships with tables: consistant and valid
-- foreign keys link tables with referential relationships
--(i.e. Offices.ClientID references Clients.clientId
-- used bit for boolean value if it is clints head office

CREATE TABLE Offices (
    OfficeID int PRIMARY KEY NOT NULL,
    ClientID int NOT NULL,
    Address VARCHAR(255) NOT NULL,
	IsHeadOffice bit NULL DEFAULT 0,	
    FOREIGN KEY (ClientID) REFERENCES Clients(ClientID)
);

-- 4. create table "Employees"
CREATE TABLE Employees (
    EmployeeID int,
    ClientID int,
    Name VARCHAR(255) NOT NULL,
    PRIMARY KEY (ClientID, Name),
    FOREIGN KEY (ClientID) REFERENCES Clients(ClientID)
);

-- 5. insert data Clients into "Clients" database
INSERT INTO Clients (ClientID, Name)
VALUES
(1, 'Client A'),
(2, 'Client B'),
(3, 'Client C');

-- 6. insert office info into "Offices" table
INSERT INTO Offices (OfficeID, ClientID, Address, IsHeadOffice)
 VALUES
(1, 1, '123 Street',0),
(2, 1, '66 Road',0),
(3, 1, '11 Spooner Road',1),
(4, 2, '123 Flight Street',0),
(5, 2, '64 Zoo Lane',1),
(6, 2, '22 Round Tree Road',0),
(7, 3, '33 Mile Street',1),
(8, 3, '66 Road',0),
(9, 3, '44 Sprinkle Road',0);

-- Insert data into Employees table
INSERT INTO Employees (EmployeeID, ClientID, Name)
 VALUES
(1, 1, 'Sam Fisher'),
(2, 1, 'John Fisher'),
(3, 1, 'Peter Fisher'),
(4, 2, 'Sam Kemp'),
(5, 2, 'John Kemp'),
(6, 2, 'Peter Kemp'),
(7, 3, 'John Doe'),
(8, 3, 'Jane Doe'),
(9, 3, 'Peter Doe');