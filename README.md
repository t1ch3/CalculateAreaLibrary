Task 2

#CREATE and INSERT TABLE

USE Shop
GO

CREATE TABLE dbo.Product
(
    [ID]   INT PRIMARY KEY IDENTITY,
    [Name] VARCHAR(50) NOT NULL 
);

CREATE TABLE dbo.Category
(
    [ID]   INT PRIMARY KEY IDENTITY,
    [Name] VARCHAR(50) NOT NULL
);

CREATE TABLE dbo.CategoryProduct
(
    [ProductID]  INT NOT NULL,
    [CategoryID] INT NOT NULL,
    FOREIGN KEY ([ProductID]) REFERENCES dbo.Product ([ID]),
    FOREIGN KEY ([CategoryID]) REFERENCES dbo.Category ([ID]),
    PRIMARY KEY ([ProductID], [CategoryID])
);

INSERT INTO dbo.Product
VALUES ('Процессор'),
       ('ОЗУ'),
       ('Холодильник'),
       ('СВЧ');

INSERT INTO dbo.Category
VALUES ('ПК комплектующие'),
       ('Кухонная техника');

INSERT INTO dbo.CategoryProduct
VALUES (1, 1),
       (2, 1),
	   (3, 2),
       (4, 2);
       
#SELECT

SELECT p.[Name],  c.[Name]
FROM Product AS p
        LEFT JOIN CategoryProduct cp ON cp.[ProductID] = p.[ID]        
        LEFT JOIN Category c ON cp.[CategoryID] = c.[ID]        
ORDER BY 1, 2;
