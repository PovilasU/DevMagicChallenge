--thinking process

-- 1. create database "tribeca_test"
CREATE DATABAS tribeca_test;

-- 2. create table "clients". Primary key makes sure that id is unique
CREATE TABLE Clients (
    clientId int PRIMARY KEY NOT NULL,
	Name VARCHAR(255)
);

-- 3. create table "Offices"
-- foreign keys creates clear relactionships with tables: consistant and valid
-- foreign keys link tables with referential relationships
--(i.e. Offices.ClientID references Clients.clientId

CREATE TABLE Offices (
    OfficeID int PRIMARY KEY NOT NULL,
    ClientID int NOT NULL,
    Address VARCHAR(255) NOT NULL,    
    FOREIGN KEY (ClientID) REFERENCES Clients(ClientID)
);

-- 4. create table "Employees"