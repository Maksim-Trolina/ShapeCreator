MS SQL script

CREATE TABLE Products (
	Id INT PRIMARY KEY,
	name TEXT
);

INSERT INTO Products
VALUES
	(1, 'Banana'),
	(2, 'Tesla');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	name TEXT
);

INSERT INTO Categories
VALUES
	(1, 'Car'),
	(2, 'Education'),
	(3, 'Technique');

CREATE TABLE ProductCategories (
	productId INT FOREIGN KEY REFERENCES Products(Id),
	categoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(2, 1),
	(2, 3);

SELECT p.name, c.name
FROM Products p
LEFT JOIN ProductCategories pc
	ON p.Id = pc.productId
LEFT JOIN Categories c
	ON pc.categoryId = c.Id;
