INSERT INTO Products (id, name)
VALUES
(1, 'Prod 1'),
(2, 'Prod 2'),
(3, 'Prod 3'),
(4, 'Prod 4'),
(5, 'Prod without cats');

INSERT INTO Categories (id, name)
VALUES
(1, 'Cat 1'),
(2, 'Cat 2'),
(3, 'Cat 3');

INSERT INTO ProductCategories (prodId, catId)
VALUES
(1, 2),
(1, 3),
(2, 1),
(3, 3),
(3, 1),
(4, 1),
(4, 2);
