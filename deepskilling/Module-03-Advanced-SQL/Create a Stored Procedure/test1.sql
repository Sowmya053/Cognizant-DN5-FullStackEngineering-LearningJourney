USE CompanyDB;
GO

EXEC sp_InsertEmployee
    @FirstName='Alice',
    @LastName='Brown',
    @DepartmentID=2,
    @Salary=55000,
    @JoinDate='2024-05-10';
GO

SELECT * FROM Employees;
GO