CREATE PROCEDURE [dbo].[Employee_Delete]
		@id int,
		@FirstName varchar(50),
		@SecondName varchar(50),
		@LastName varchar(50),
		@BirthDate date,
		@Email varchar(50),
		@PhoneNumber decimal,
		@StatusId int,
		@DepartmentId int
AS
BEGIN

UPDATE dbo.Employee
SET		FirstName=@FirstName ,
		SecondName=@SecondName,
		LastName=@LastName,
		BirthDate=@BirthDate,
		Email=@Email ,
		PhoneNumber=@PhoneNumber ,
		StatusId=@StatusId ,
		DepartmentId=@DepartmentId,
		IsDeleted=1
WHERE id = @id

END
