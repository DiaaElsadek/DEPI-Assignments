--Use ITI DB

use ITI

CREATE FUNCTION GetMonthNameOfDate (@Date Date)
returns varchar(20)
begin
	declare @MonthName varchar(20) 
	SELECT @MonthName =  DATENAME(MONTH, GETDATE())
	return @MonthName
end

select dbo.GetMonthNameOfDate(GetDate()) As MonthOfThisyear


Create Function GetAllIntegersBetweenTwoNumbers(@num1 int, @num2 int)
Returns @Result Table
(
Number Int
)
With Encryption
As
Begin	
	 declare @Min_Num int
	 declare @Max_Num int
	 if @num1<=@num2
		Begin
			set @Min_Num = @num1
			set @Max_Num = @num2
		End
	else 
		Begin
			set @Min_Num = @num2
			set @Max_Num = @num1
		End
	Declare @Start int = @Min_Num + 1; 
	while @Start < @Max_Num
		Begin
			Insert Into @Result 
			Values (@Start) 
		Set @Start = @Start + 1 
		End
	return 
end

select *from GetAllIntegersBetweenTwoNumbers(4,9)

Create Function GetDeptNameOfSudentNo(@StudentNo int)
Returns Table
As
Return 
	(
		select Fullname = s.St_Fname + ' ' + s.St_Lname , DepartmentName =  D.Dept_Name  
		From Student s Inner Join Department D
		On s.Dept_Id = D.Dept_Id
		Where @StudentNo = s.St_Id
	)


select* From GetDeptNameOfSudentNo(1)

Create Function CheckFullname(@StudentId int)
Returns varchar(max)
With Encryption 
As
Begin
	declare @FirstName varchar(max)
	declare @LastName varchar(max)
	declare @Result varchar(max)
	select @FirstName = St_Fname , @LastName = St_Lname
	From Student 
	Begin
		If @FirstName Is Null And @LastName Is Null
			Set @Result =  'First name & last name are null' 
		else If @FirstName Is Null
			Set @Result =  'first name is null'
		else If @LastName Is Null
			Set @Result = 'last name is null'
		Else
			Set @Result = 'First name & last name are not null'
	End
	return @Result
End

select dbo.CheckFullname(3) As CheckFullName


Create Function DisplayDetailOfManager(@hireDate Date)
Returns Table
As 
Return
(
	Select Dep.Dept_Name As [Department Name] , Ins.Ins_Name As [Manager Name] , Dep.Manager_hiredate As [HiringDate]
	From Department Dep Inner Join Instructor Ins
	On Dep.Dept_Manager = Ins.Ins_Id
	Where @hireDate = Dep.Manager_hiredate
)

select* From  DisplayDetailOfManager('2000-01-01')


Create Function GetStudentName(@Type NVARCHAR(50))
RETURNS @Result TABLE
(
    StudentId INT,
    Value nvarchar(200)
)
AS
BEGIN
    IF @Type = 'first name'
    BEGIN
        INSERT INTO @Result
        SELECT 
            s.St_Id,
            ISNULL(s.St_Fname, 'No First Name')
        FROM Student s
    END
    ELSE IF @Type = 'last name'
    BEGIN
        INSERT INTO @Result
        SELECT 
            s.St_Id,
            ISNULL(s.St_Lname, 'No Last Name')
        FROM Student s
    END
    ELSE IF @Type = 'full name'
    BEGIN
        INSERT INTO @Result
        SELECT 
            s.St_Id,
            ISNULL(s.St_Id, '') + ' ' + ISNULL(s.St_Lname, '')
        FROM Student s
    END
    RETURN
END

select * from GetStudentName('first name')

--- Use MyCompanyDB

use MyCompany

Create Function DisplayEmployeeInProject(@ProNumber int)
Returns Table 
As 
Return 
(
Select E.*
From Employee E Inner Join Works_for W
On E.SSN = W.ESSn
Inner Join Project P
On P.Pnumber = W.Pno
Where P.Pnumber = @ProNumber
)

select *From DisplayEmployeeInProject(100)