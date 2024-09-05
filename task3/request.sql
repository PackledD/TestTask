SELECT p.name, c.name
FROM Products as p LEFT JOIN ProductCategories as pc
                   ON p.id = pc.prodId
                   LEFT JOIN Categories as c
                   ON pc.catId = c.id