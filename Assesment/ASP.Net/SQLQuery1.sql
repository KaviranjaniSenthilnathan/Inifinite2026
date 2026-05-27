CREATE DATABASE FoodDB;

USE FoodDB;

CREATE TABLE MenuItems (
    MenuId INT IDENTITY(1,1) PRIMARY KEY,
    ItemName NVARCHAR(100),
    Category NVARCHAR(50),
    FoodType NVARCHAR(20),
    Price DECIMAL(10,2),
    AvailableQuantity INT,
    IsAvailable BIT,
    CreatedDate DATETIME DEFAULT GETDATE()
);
USE FoodDB;

CREATE USER [INFICS\kaviranjanis] FOR LOGIN [INFICS\kaviranjanis];
ALTER ROLE db_owner ADD MEMBER [INFICS\kaviranjanis];

SELECT * FROM MenuItems;
