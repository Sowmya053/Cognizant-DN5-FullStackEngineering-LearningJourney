USE CompanyDB;
GO

EXEC sp_InsertEmployee
    @FirstName='John',
    @LastName='Smith',
    @DepartmentID=1,
    @Salary=45000,
    @JoinDate='2024-01-15';
GO

SELECT * FROM Employees;
GO