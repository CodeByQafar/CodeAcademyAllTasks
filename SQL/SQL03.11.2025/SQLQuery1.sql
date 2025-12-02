CREATE DATABASE BookStore;
USE BookStore;

CREATE TABLE book (
  ID INT IDENTITY(1,1) PRIMARY KEY,
  Title VARCHAR(100) NOT NULL,
  Author VARCHAR(50) NOT NULL,
  Price INT NOT NULL DEFAULT 0 CHECK (Price >= 0 AND Price <= 200),
  PageCount INT NOT NULL DEFAULT 0 CHECK (PageCount >= 0),
  Genre VARCHAR(20) NOT NULL DEFAULT 'Dram',
  ReleaseYear INT NOT NULL
);

ALTER TABLE book ADD Language VARCHAR(50) NOT NULL DEFAULT 'English';
ALTER TABLE book DROP COLUMN Language;

INSERT INTO book (Title, Author, Price, PageCount, Genre, ReleaseYear) VALUES
('A Tale of Love', 'Anna Brown', 25, 320, 'Drama', 2005),
('Mystic Forest', 'Brian King', 15, 280, 'Fantasy', 2012),
('Night Terror', 'C. D. Evans', 30, 410, 'Horror', 2018),
('Old Horizons', 'Adam Smith', 10, 150, 'History', 1998),
('Love in Winter', 'Alicia Keys', 20, 90, 'Romance', 2011),
('Dragons Rise', 'Evan Archer', 45, 500, 'Fantasy', 2020);

UPDATE book SET Price = 22 WHERE Title = 'Mystic Forest';
DELETE FROM book WHERE Title = 'Old Horizons';

SELECT * FROM book;
SELECT Title, Author FROM book;
SELECT * FROM book WHERE Price > 20;
SELECT * FROM book WHERE Genre = 'Fantasy';
SELECT * FROM book WHERE ReleaseYear < 2010;
SELECT * FROM book WHERE Price BETWEEN 10 AND 30;
SELECT * FROM book WHERE PageCount < 100 AND Price > 15;
SELECT * FROM book WHERE Author LIKE 'A%';
SELECT * FROM book WHERE Title LIKE '%love%';
SELECT * FROM book WHERE Genre IN ('Fantasy','Horror');
SELECT * FROM book WHERE ReleaseYear > 2000 AND PageCount > 300;
SELECT * FROM book WHERE Price IN (10,20,30);
SELECT * FROM book ORDER BY Price;
SELECT * FROM book ORDER BY PageCount DESC;
SELECT MAX(Price) FROM book;
SELECT MIN(PageCount) FROM book;
SELECT COUNT(*) FROM book;
SELECT AVG(Price) FROM book;
