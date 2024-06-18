CREATE TABLE Products
(
    [Id] INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
    [Name] NCHAR(30)
);

INSERT INTO Products
VALUES ('Product1'),
       ('Product2'),
       ('Product3'),
       ('Product4');

CREATE TABLE Categories
(
    [Id] INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
    [Name] NCHAR(30)
);

INSERT INTO Categories
VALUES ('Category1'),
       ('Category2'),
       ('Category3'),
       ('Category4');

CREATE TABLE ProductsAndCategories
(
    [Id] INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
    [ProductId] INT FOREIGN KEY REFERENCES Products(Id),
    [CategoryId] INT FOREIGN KEY REFERENCES Categories(Id)
);

INSERT INTO ProductsAndCategories
VALUES (1, 3),
       (2, 1),
       (2, 2),
       (2, 3),
       (4, 4),
       (2, 4);

SELECT Products.Name AS Product, ISNULL(Categories.Name, 'Нет категории') AS Categoria
  FROM Products
  LEFT JOIN ProductsAndCategories
    ON Products.Id = ProductsAndCategories.ProductId
       LEFT JOIN Categories
         ON ProductsAndCategories.CategoryId = Categories.Id;