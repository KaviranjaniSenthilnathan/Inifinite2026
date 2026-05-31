CREATE DATABASE RailSys;
USE RailSys;
 
-- USERS TABLE
CREATE TABLE AccountUsers
(
    UserId INT IDENTITY PRIMARY KEY,
    UserName VARCHAR(50) UNIQUE,
    Password VARCHAR(50),
    UserRole VARCHAR(10)
);
 
-- TRAINS
CREATE TABLE TrainMaster
(
    TrainId INT PRIMARY KEY,
    TrainTitle VARCHAR(100),
    Source VARCHAR(50),
    Destination VARCHAR(50),
 
    TotalSeats INT,
    Fare DECIMAL(10,2),
 
    Departure TIME,
    Arrival TIME,
 
    IsActive BIT DEFAULT 1
);
 
-- BOOKINGS
CREATE TABLE TicketBooking
(
    PNR INT PRIMARY KEY,
    BookingTime DATETIME,
    TrainId INT,
    PassengerCount INT CHECK(PassengerCount <= 3),
    TotalAmount DECIMAL(10,2),
    UserId INT,
 
    FOREIGN KEY (TrainId) REFERENCES TrainMaster(TrainId)
);
 
-- PASSENGERS
CREATE TABLE Travellers
(
    TravellerId INT IDENTITY PRIMARY KEY,
    PNR INT,
    FullName VARCHAR(50),
    Age INT,
    Gender VARCHAR(10),
    ProofType VARCHAR(20),
    ProofNumber VARCHAR(30),
    SeatNo INT,
    IsCancelled BIT DEFAULT 0,
 
    FOREIGN KEY (PNR) REFERENCES TicketBooking(PNR)
);
 