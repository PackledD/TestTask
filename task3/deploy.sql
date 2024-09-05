CREATE TABLE Products (
	id INT PRIMARY KEY,
	name TEXT
);

CREATE TABLE Categories (
	id INT PRIMARY KEY,
	name TEXT
);

CREATE TABLE ProductCategories (
	prodId INT REFERENCES Products(id),
	catId INT REFERENCES Categories(id)
);