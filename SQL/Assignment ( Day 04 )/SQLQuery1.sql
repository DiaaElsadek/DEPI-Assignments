use MyCompany

-- Q1 -> Restore MyCompany DB then Try to create the following Queries:

-- 11
-- Display each department id, name which managed by a manager with id equals 968574.
Select dept.Dnum, dept.Dname
from Departments Dept inner join Employee Emp
on Emp.SSN = Dept.MGRSSN and Emp.SSN = 968574

-- 12
-- Dispaly the ids, names and locations of  the pojects which controled with department 10.
Select P.Pnumber, P.Pname, P.Plocation
from Project P inner join Departments Dept
on p.Dnum = dept.Dnum and p.Dnum = 10

-- Q2 -> Restore iti DB then

use ITI

-- 2
select ins.Ins_Name
from Instructor ins
group by ins.Ins_Name

-- 3
select ins.Ins_Name, dept.Dept_Name
from Instructor ins left outer join Department dept
on ins.Dept_Id = dept.Dept_Id

-- 4

select St_Fname+' '+St_Lname [Full Name],  Co.Crs_Name
from Student S right outer join Stud_Course C
on S.St_Id = C.St_Id
inner join Course Co
on co.Crs_Id = C.Crs_Id

-- 5
select Count(*) [Number of courses], T.Top_Name
from Course C join Topic T on C.Top_Id = T.Top_Id
group by C.Top_Id, T.Top_Name
order by [Number of courses]

-- 6
select st.St_Fname as Student_Name , sup.St_Fname as supervisorName
from student st, Student sup
where sup.St_Id = st.St_super