CREATE TABLE InfiniteDB

(

    empid INT PRIMARY KEY,

    empname VARCHAR(50),

    salary INT

);

INSERT INTO InfiniteDB VALUES (1, 'ravi', 36000);
INSERT INTO InfiniteDB  VALUES (2, 'anita', 40000);
INSERT INTO InfiniteDB VALUES (3, 'kiran', 35000);
INSERT INTO InfiniteDB VALUES (4, 'meena', 45000);
 
 USE InfiniteDB;
 GO 
 CREATE 
 USER [INFICS\kaviranjanis] 
 FOR LOGIN [INFICS\kaviranjanis];
 ALTER ROLE db_owner 
 ADD MEMBER [INFICS\kaviranjanis];
 