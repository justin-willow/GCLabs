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

--Add Joe's Chicago Pizza like in the examples
INSERT INTO OrdersExercise(CustomerName, Item, Price, Quantity)
VALUES ('Joe''s Chicago Pizza', NULL, NULL, NULL);


--Exercise 4
SELECT 
    CustomerName,
    CASE 
		WHEN Item IS NULL 
			THEN '**No Orders**'
		ELSE Item
	END AS Item,
    Price,
    Quantity,
    (Price * Quantity) AS Total
FROM OrdersExercise;

--Exercise 5
SELECT 
    CustomerName,
    CASE 
        WHEN Item IS NULL 
            THEN '**No Orders**'
        ELSE Item
    END AS Item,
    Price,
    Quantity,
    Total
FROM (
    SELECT 
        CustomerName,
        Item,
        Price,
        Quantity,
        (Price * Quantity) AS Total
    FROM OrdersExercise

    UNION ALL

    SELECT 
        CustomerName,
        'GRAND TOTAL' AS Item,
        NULL AS Price,
        NULL AS Quantity,
        SUM(Price * Quantity) AS Total
    FROM OrdersExercise
    GROUP BY CustomerName
) AS CombinedData
ORDER BY 
	CustomerName,
	CASE WHEN Item = 'GRAND TOTAL' THEN 1 ELSE 0 END;

--Exercise 6
SELECT 
    CASE 
        WHEN LAG(CustomerName) OVER (ORDER BY (SELECT NULL)) = CustomerName 
            THEN NULL 
        ELSE CustomerName 
    END AS CustomerName,
    CASE 
        WHEN Item IS NULL 
            THEN '**No Orders**' 
        ELSE Item 
    END AS Item,
    Price,
    Quantity,
    (Price * Quantity) AS Total
FROM OrdersExercise;