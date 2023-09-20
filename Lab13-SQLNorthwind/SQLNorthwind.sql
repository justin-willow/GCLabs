--1. Select all the rows from the "Customers" table. 
SELECT *
FROM Customers;

--2. Get distinct countries from the Customers table.
SELECT DISTINCT Country
FROM Customers;

--3. Get all the rows from the table Customers where the Customer’s ID starts with “BL”.
SELECT *
FROM Customers
WHERE CustomerID LIKE 'BL%';

--4. Get the first 100 records of the orders table. DISCUSS: Why would you do this? What else would you likely need to include in this query?
--You might only request the first 100 for performance reasons or if you just want to test if a query works without it running on the entire dataset. 
--What else you would likely need to include seems somewhat vague as it depends on the specific reason you only want the first 100 and there could be a few possibilities. 
--But if it was because only the top 100 were relevant you might need to include an ORDER BY line. You might also need to consider WITH TIES if ties were relevant. I could also see a WHERE clause being relevant to filter the 100 results but would need more info on the specific objective.
SELECT TOP 100 *
FROM Orders;

--5. Get all customers that live in the postal codes 1010, 3012, 12209, and 05023.
SELECT *
FROM Customers
WHERE PostalCode IN ('1010', '3012', '12209', '05023');

--6. Get all orders where the ShipRegion is not equal to NULL.
SELECT *
FROM Orders
WHERE ShipRegion IS NOT NULL;

--7. Get all customers ordered by the country, then by the city.
SELECT *
FROM Customers
ORDER BY Country, City;

--8. Add a new customer to the customers table. You can use whatever values.
INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax)
VALUES ('NASA', 'Moon Force Alpha', 'Armis Strong', 'Owner', '123 Real St', 'Moon Base', 'MN', '90001', 'SPACE', '555-5555', '555-5555');

--9. Update all ShipRegion to the value ‘EuroZone’ in the Orders table, where the ShipCountry is equal to France.  
UPDATE Orders 
SET ShipRegion = 'EuroZone' 
WHERE ShipCountry = 'France';

--10. Delete all orders from OrderDetails that have quantity of 1. 
DELETE FROM [Order Details]
WHERE Quantity = 1;

--11. Find the CustomerID that placed order 10290 (orders table).
SELECT CustomerID 
FROM Orders 
WHERE OrderID = 10290;

--12. Join the orders table to the customers table.
SELECT *
FROM Orders o
JOIN Customers c ON o.CustomerID = c.CustomerID;

--13. Get employees’ firstname for all employees who report to no one.
SELECT FirstName 
FROM Employees 
WHERE ReportsTo IS NULL;

--14. Get employees’ firstname for all employees who report to Andrew.
SELECT FirstName 
FROM Employees 
WHERE ReportsTo = 2;

--EXTRA CHALLENGES

--1. Calculate the average, max, and min of the quantity at the orderdetails table, grouped by the orderid. 
SELECT 
    OrderID,
    AVG(Quantity) AS AverageQuantity,
    MAX(Quantity) AS MaxQuantity,
    MIN(Quantity) AS MinQuantity
FROM [Order Details]
GROUP BY OrderID;

--2. Calculate the average, max, and min of the quantity at the orderdetails table.
SELECT 
    AVG(Quantity) AS AverageQuantity,
    MAX(Quantity) AS MaxQuantity,
    MIN(Quantity) AS MinQuantity
FROM [Order Details];

--3. Find all customers living in London or Paris
SELECT *
FROM Customers
WHERE City IN ('London', 'Paris');

--4. Do an inner join, left join, right join on orders and customers tables. 
SELECT *
FROM Orders o
INNER JOIN Customers c ON o.CustomerID = c.CustomerID;

SELECT *
FROM Orders o
LEFT JOIN Customers c ON o.CustomerID = c.CustomerID;

SELECT *
FROM Orders o
RIGHT JOIN Customers c ON o.CustomerID = c.CustomerID;

--5. Make a list of cities where customers are coming from. The list should not have any duplicates or nulls.
SELECT DISTINCT City 
FROM Customers 
WHERE City IS NOT NULL;

--6. Show a sorted list of employees’ first names. 
SELECT FirstName 
FROM Employees 
ORDER BY FirstName;

--7. Find total for each order
SELECT 
    OrderID,
    SUM(Quantity * UnitPrice) AS Total
FROM [Order Details]
GROUP BY OrderID;

--8. Get a list of all employees who got hired between 1/1/1994 and today
SELECT *
FROM Employees
WHERE HireDate BETWEEN '1994-01-01' AND GETDATE();

--9. Find how long employees have been working for Northwind (in years!)
SELECT 
    EmployeeID,
    FirstName,
    LastName,
    DATEDIFF(YEAR, HireDate, GETDATE()) AS YearsWorked
FROM Employees;

--10. Get a list of all products sorted by quantity (ascending and descending order)
SELECT * 
FROM Products 
ORDER BY UnitsInStock ASC;

SELECT * 
FROM Products 
ORDER BY UnitsInStock DESC;

--11. Find all products that are low on stock (quantity less than 6)
SELECT * 
FROM Products 
WHERE UnitsInStock < 6;

--12. Find a list of all discontinued products. 
SELECT * 
FROM Products 
WHERE Discontinued = 1;

--13. Find a list of all products that have Tofu in the product name.
SELECT * 
FROM Products 
WHERE ProductName LIKE '%Tofu%';

--14. Find the product that has the highest unit price. 
SELECT TOP 1 WITH TIES *
FROM Products
ORDER BY UnitPrice DESC;

--15. Get a list of all employees who got hired after 1/1/1993
SELECT *
FROM Employees
WHERE HireDate > '1993-01-01';

--16. Get all employees who have title : “Ms.” And “Mrs.”
SELECT *
FROM Employees
WHERE TitleOfCourtesy IN ('Ms.', 'Mrs.');

--17. Get all employees who have a Home phone number that has area code 206
--WOO SEATTLE AREA CODE
SELECT *
FROM Employees
WHERE HomePhone LIKE '(206)%';