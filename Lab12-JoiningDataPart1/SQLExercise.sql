CREATE TABLE OrdersExercise (
	OrderID INT PRIMARY KEY IDENTITY(1,1),
    CustomerName VARCHAR(255),
    Item VARCHAR(255),
    Price DECIMAL(10, 2),
    Quantity INT
);

INSERT INTO OrdersExercise (CustomerName, Item, Price, Quantity)
VALUES
    ('Acme Hardware', 'Mouse', 25.00, 3),
    ('Acme Hardware', 'Keyboard', 45.00, 2),
    ('Falls Realty', 'Macbook', 800.00, 2),
    ('Julie''s Morning Diner', 'iPad', 525.00, 1),
    ('Julie''s Morning Diner', 'Credit Card Reader', 45.00, 1);


--Exercise 1
SELECT CustomerName,
       Item,
       Price,
       Quantity,
       (Price * Quantity) AS Total
FROM OrdersExercise
ORDER BY CustomerName;

--Exercise 2
SELECT CustomerName,
       Item,
       Price,
       Quantity,
       (Price * Quantity) AS Total
FROM OrdersExercise
UNION ALL
SELECT CustomerName,
       NULL AS Item,
       NULL AS Price,
       NULL AS Quantity,
       SUM(Price * Quantity) AS Total
FROM OrdersExercise
GROUP BY CustomerName
ORDER BY CustomerName, Item

--Exercise 3
SELECT CASE WHEN RowNum = 1 THEN CustomerName ELSE NULL END AS Customer,
       Item,
       Price,
       Quantity,
       (Price * Quantity) AS Total
FROM (
    SELECT CustomerName,
           Item,
           Price,
           Quantity,
           ROW_NUMBER() OVER(PARTITION BY CustomerName ORDER BY Item) AS RowNum
    FROM OrdersExercise
) AS OrderedData
ORDER BY CustomerName, Item;