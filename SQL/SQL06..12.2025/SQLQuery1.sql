CREATE DATABASE Task
USE Task


CREATE TABLE Categories(
	ID INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(35) NULL
)

CREATE TABLE Meals(
	ID INT IDENTITY,
	[Name] NVARCHAR(35) NULL,
	CategoryID int FOREIGN KEY REFERENCES Categories(ID) NULL
)



INSERT INTO Categories([Name]) VALUES
('Fast Food'),
('Dessert'),
('Drink'),
('Salad'),
('Main Course'),
(NULL),
('Seafood');




INSERT INTO Meals([NAME],CategoryID) VALUES
('Chocolate Cake',2),
('Cheeseburger',1),
('Caesar Salad',4),
('Lemonade',3),
('Pizaa',NULL),
(NULL,1),
('Meat',6),
('Grilled Chicken',5)



SELECT * FROM Meals

SELECT [Name] FROM Meals

SELECT [Name] FROM Categories

SELECT * FROM Meals where CategoryID is NULL

SELECT * FROM Categories 

WHERE NOT EXISTS (
    SELECT 1
    FROM Meals 
    WHERE Meals.CategoryID = Categories.ID
);



