# Advanced SQL Notes

## Overview

Advanced SQL goes beyond basic CRUD operations and focuses on writing efficient, optimized, and maintainable queries. The main objective is to understand how databases process queries and how to improve their performance.

---

## Topics Covered

- Common Table Expressions (CTEs)
- Window Functions
- Query Optimization
- Indexing
- Transactions
- Advanced Joins
- JSON Support in SQL Server
- Performance Tuning

---

## 1. Common Table Expressions (CTEs)

A CTE is a temporary result set that makes complex queries easier to read and maintain.

Example:

```sql
WITH EmployeeSalary AS
(
    SELECT Name, Salary
    FROM Employees
)
SELECT *
FROM EmployeeSalary;
```

Recursive CTEs are useful for hierarchical data like employees and managers.

---

## 2. Window Functions

Window functions perform calculations without grouping rows.

Common functions include:

- ROW_NUMBER()
- RANK()
- DENSE_RANK()
- LAG()
- LEAD()
- SUM() OVER()
- AVG() OVER()

Example:

```sql
SELECT
    Name,
    Salary,
    RANK() OVER(ORDER BY Salary DESC) AS SalaryRank
FROM Employees;
```

---

## 3. Indexes

Indexes improve query performance by reducing the number of rows scanned.

Types:

- Clustered Index
- Non-Clustered Index
- Composite Index
- Unique Index

Example:

```sql
CREATE INDEX idx_email
ON Users(Email);
```

Indexes improve read performance but slightly slow down insert and update operations.

---

## 4. Query Optimization

Some common optimization techniques include:

- Select only required columns.
- Avoid unnecessary subqueries.
- Use indexes properly.
- Filter data early using WHERE.
- Analyze execution plans.

Poor:

```sql
SELECT *
FROM Orders;
```

Better:

```sql
SELECT OrderID, CustomerID
FROM Orders
WHERE Status='Completed';
```

---

## 5. Transactions

Transactions ensure data consistency.

Properties of ACID:

- Atomicity
- Consistency
- Isolation
- Durability

Example:

```sql
BEGIN TRANSACTION;

UPDATE Accounts
SET Balance = Balance - 500
WHERE AccountID = 1;

UPDATE Accounts
SET Balance = Balance + 500
WHERE AccountID = 2;

COMMIT;
```

If any statement fails:

```sql
ROLLBACK;
```

---

## 6. Advanced Joins

Different joins are used depending on the requirement.

- INNER JOIN
- LEFT JOIN
- RIGHT JOIN
- FULL JOIN
- CROSS JOIN
- SELF JOIN

Example:

```sql
SELECT e.Name,
       m.Name AS Manager
FROM Employees e
JOIN Employees m
ON e.ManagerID = m.EmployeeID;
```

---

## 7. JSON in SQL Server

SQL Server supports storing and querying JSON data.

Useful functions:

- JSON_VALUE()
- JSON_QUERY()
- JSON_MODIFY()

Example:

```sql
SELECT JSON_VALUE(Data,'$.Name')
FROM Users;
```

---

## 8. Performance Tuning

Performance can be improved by:

- Creating appropriate indexes
- Avoiding SELECT *
- Reducing nested queries
- Using execution plans
- Optimizing joins

---

## Key Learnings

- CTEs make complex queries easier to understand.
- Window functions simplify ranking and analytical calculations.
- Proper indexing greatly improves performance.
- Transactions maintain data integrity.
- Query optimization is essential when working with large datasets.

---

## Exercises Completed

- Exercise 1
- Exercise 2
- Exercise 3
- Exercise 4
- Exercise 5
- Exercise 6
- Exercise 7
- Exercise 8

---

## Summary

Advanced SQL is mainly about writing efficient queries rather than simply retrieving data. Understanding indexes, execution plans, transactions, and window functions helps build scalable database applications.
