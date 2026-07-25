CREATE DATABASE StudentDB;
GO

USE StudentDB;
GO

CREATE TABLE Students
(
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50),
    Department VARCHAR(50),
    Age INT,
    Marks INT
);

INSERT INTO Students VALUES
(1,'Madhumitha','CSE',21,90),
(2,'Rahul','ECE',22,80),
(3,'Sneha','CSE',20,95),
(4,'Arjun','EEE',23,75),
(5,'Priya','IT',21,88);

SELECT * FROM Students;