CREATE DATABASE MoviesDB;
GO

USE MoviesDB;
GO

CREATE TABLE Movies (
    Mid INT IDENTITY(1,1) PRIMARY KEY,
    MovieName VARCHAR(100),
    DirectorName VARCHAR(100),
    DateOfRelease DATETIME
);
INSERT INTO Movies (MovieName, DirectorName, DateOfRelease)
VALUES
('Leo', 'Lokesh', '2023-10-19'),
('Bahubali', 'Rajamouli', '2015-07-10'),
('RRR', 'Rajamouli', '2022-03-25'),
('Jailer', 'Nelson', '2023-08-10');
