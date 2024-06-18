# FigureLibrary
Тестовое задание от компании Mindbox
---
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

- Юнит-тесты

- Легкость добавления других фигур

- Вычисление площади фигуры без знания типа фигуры в compile-time

- Проверку на то, является ли треугольник прямоугольным

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

Создание и заполнение таблиц:
```sql
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
```

SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
```sql
SELECT Products.Name AS Product, ISNULL(Categories.Name, 'Нет категории') AS Categoria
  FROM Products
  LEFT JOIN ProductsAndCategories
    ON Products.Id = ProductsAndCategories.ProductId
       LEFT JOIN Categories
         ON ProductsAndCategories.CategoryId = Categories.Id;
```

Вывод

```sql
Product     | Categoria
----------- | -------------
Product1    | Category3
Product2    | Category1
Product2    | Category2
Product2    | Category3
Product2    | Category4
Product3    | Нет категории
Product4    | Category4
```
