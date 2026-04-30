-- CREATE DATABASE
CREATE DATABASE Assessment5;
GO

USE Assessment5;
GO

---------------------------------------------------
-- QUESTION 1: BOOKS TABLE
---------------------------------------------------

CREATE TABLE books (
    id INT IDENTITY(1,1) PRIMARY KEY,
    title NVARCHAR(200) NOT NULL,
    author NVARCHAR(100) NOT NULL,
    isbn BIGINT UNIQUE NOT NULL,
    published_date DATETIME NOT NULL
);

INSERT INTO books (title, author, isbn, published_date)
VALUES
('My First SQL Book', 'Mary Parker', 981483029127, '2012-02-22 12:08:17'),
('My Second SQL Book', 'John Mayer', 857300923713, '1972-07-03 09:22:45'),
('My Third SQL Book', 'Cary Flint', 523120967812, '2015-10-18 14:05:44');

-- Authors ending with 'er'
SELECT * 
FROM books 
WHERE author LIKE '%er';

---------------------------------------------------
-- QUESTION 2: INNER JOIN
---------------------------------------------------

SELECT 
    b.title,
    b.author,
    r.reviewer_name
FROM books b
INNER JOIN reviews r 
ON b.id = r.book_id;

---------------------------------------------------
-- QUESTION 3: REVIEWER MORE THAN ONE BOOK
---------------------------------------------------

SELECT reviewer_name
FROM reviews
GROUP BY reviewer_name
HAVING COUNT(DISTINCT book_id) > 1;S

---------------------------------------------------
-- QUESTION 4: CUSTOMER TABLE
---------------------------------------------------

CREATE TABLE customer (
    id INT PRIMARY KEY,
    name NVARCHAR(50),
    age INT,
    address NVARCHAR(50),
    salary DECIMAL(10,2)
);

INSERT INTO customer (id, name, age, address, salary)
VALUES
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'MP', 4500.00),
(7, 'Muffy', 24, 'Indore', 10000.00);

-- Same address + contains 'o'
SELECT name
FROM customer
WHERE address LIKE '%o%'
AND address IN (
    SELECT address
    FROM customer
    GROUP BY address
    HAVING COUNT(*) > 1
);

---------------------------------------------------
-- QUESTION 5: ORDERS TABLE
---------------------------------------------------

CREATE TABLE orders (
    oid INT PRIMARY KEY,
    order_date DATETIME,
    customer_id INT,
    amount DECIMAL(10,2),
    FOREIGN KEY (customer_id) REFERENCES customer(id)
);

INSERT INTO orders (oid, order_date, customer_id, amount)
VALUES
(102, '2009-10-08 00:00:00', 3, 3000.00),
(100, '2009-10-08 00:00:00', 3, 1500.00),
(101, '2009-11-20 00:00:00', 2, 1560.00),
(103, '2008-05-20 00:00:00', 4, 2060.00);

-- Customers per date
SELECT 
    order_date,
    COUNT(customer_id) AS total_customers
FROM orders
GROUP BY order_date;

---------------------------------------------------
-- QUESTION 6: EMPLOYEE TABLE
---------------------------------------------------

CREATE TABLE employee (
    id INT PRIMARY KEY,
    name NVARCHAR(50),
    age INT,
    address NVARCHAR(50),
    salary DECIMAL(10,2)
);

INSERT INTO employee (id, name, age, address, salary)
VALUES
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'MP', NULL),
(7, 'Muffy', 24, 'Indore', NULL);

-- Lowercase names where salary is NULL
SELECT LOWER(name) AS name
FROM employee
WHERE salary IS NULL;

---------------------------------------------------
-- QUESTION 7: STUDENT DETAILS
---------------------------------------------------

CREATE TABLE studentdetails (
    registerno INT PRIMARY KEY,
    name NVARCHAR(50),
    age INT,
    qualification NVARCHAR(20),
    mobileno BIGINT,
    mail_id NVARCHAR(100),
    location NVARCHAR(50),
    gender CHAR(1)
);

INSERT INTO studentdetails
(registerno, name, age, qualification, mobileno, mail_id, location, gender)
VALUES
(2, 'Sai', 22, 'B.E', 9952836777, 'sai@gmail.com', 'Chennai', 'M'),
(3, 'Kumar', 20, 'BSC', 7890125648, 'kumar@gmail.com', 'Madurai', 'M'),
(4, 'Selvi', 22, 'B.Tech', 8904567342, 'selvi@gmail.com', 'Salem', 'F'),
(5, 'Nisha', 25, 'M.E', 7834672310, 'nisha@gmail.com', 'Theni', 'F'),
(6, 'Saisaran', 21, 'B.A', 7890345678, 'saran@gmail.com', 'Madurai', 'F'),
(7, 'Tom', 23, 'BCA', 8901234675, 'tom@gmail.com', 'Pune', 'M');

-- Gender count
SELECT 
    gender,
    COUNT(*) AS total_count
FROM studentdetails
GROUP BY gender;