CREATE DATABASE Book;

USE Book;

CREATE TABLE Category(
    ID INT PRIMARY KEY IDENTITY,
    [Name] VARCHAR(100) NOT NULL
);

CREATE TABLE Author(
    ID INT PRIMARY KEY IDENTITY,
    [Name] VARCHAR(100) NOT NULL
);

CREATE TABLE Book(
    ID INT PRIMARY KEY IDENTITY,
    [Name] VARCHAR(100) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    CategoryId INT FOREIGN KEY REFERENCES Category(ID),
    AuthorId INT FOREIGN KEY REFERENCES Author(ID)
);

CREATE VIEW Information AS
SELECT 
    b.Name AS BookName,
    b.Price AS BookPrice,
    c.Name AS CategoryName,
    a.Name AS AuthorName
FROM Book b
JOIN Category c ON b.CategoryId = c.ID
JOIN Author a ON b.AuthorId = a.ID;

CREATE FUNCTION Capitalize(@word VARCHAR(100))
RETURNS VARCHAR(100)
AS
BEGIN
    SET @word = UPPER(LEFT(@word,1)) + LOWER(SUBSTRING(@word,2, LEN(@word)));
    RETURN @word;
END;

CREATE PROCEDURE AddBook
(
    @name VARCHAR(100),
    @price DECIMAL(10,2),
    @categoryId INT,
    @authorId INT
)
AS
BEGIN
    SET @name = dbo.Capitalize(@name);

    INSERT INTO Book(Name, Price, CategoryId, AuthorId)
    VALUES(@name, @price, @categoryId, @authorId);
END;

CREATE FUNCTION IdFunction(@id INT)
RETURNS VARCHAR(300)
AS
BEGIN
    DECLARE @result VARCHAR(300);

    SELECT @result = b.Name + ' ' + a.Name
    FROM Book b
    JOIN Author a ON b.AuthorId = a.ID
    WHERE b.ID = @id;

    RETURN @result;
END;

CREATE PROCEDURE PlusPrice
(
    @id INT,
    @price DECIMAL(10,2)
)
AS
BEGIN
    UPDATE Book
    SET Price = Price + @price
    WHERE ID = @id;
END;

CREATE FUNCTION GetBookAndCategory(@id INT)
RETURNS VARCHAR(200)
AS
BEGIN
    DECLARE @result VARCHAR(200);

    SELECT @result = b.Name + ' ' + c.Name
    FROM Book b
    JOIN Category c ON b.CategoryId = c.ID
    WHERE b.ID = @id;

    RETURN @result;
END;
