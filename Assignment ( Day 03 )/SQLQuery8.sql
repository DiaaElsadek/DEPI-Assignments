use ITI
-- Q1 => Data Manipulating Language
-- 1
insert into Student -- My Personal Data
values(25 ,'Diaa', 'Elsaldek', 'Sharqia', 21, 30, null)
select * from Student

-- 2
insert into Instructor
values(16, 'Mohamed Moustafa', 'Master', 4000, 30)
select * from Instructor

-- 3
update Instructor
set salary += (Salary*0.2)
select * from Instructor

-- Q2 => Restore MyCompany DB then Try to create the following Queries

use MyCompany

-- 4
select * from Employee

-- 5
select fname, lname, salary, dno from Employee

-- 6
select Pname, Plocation, Dnum from Project

-- 7
select fname+' '+lname as [Full Name] , salary + (salary*0.1) as [ANNUAL COMM] from Employee

-- 8
select ssn, fname+' '+lname as [Full Name]
from Employee
where Salary > 1000

-- 9
select ssn, fname+' '+lname as [Full Name]
from Employee
where (Salary * 12) > 10000

-- 10
select fname+' '+lname as [Full Name], salary
from Employee
where sex = 'F'

-- Q3 => Restore iti DB
-- 1
use ITI
select COUNT(*) as [number of students] from Student
where St_Age is not null