CREATE PROCEDURE [dbo].[Employee_Update]
		@id int,
		@FirstName varchar(50),
		@SecondName varchar(50),
		@LastName varchar(50),
		@BirthDate date,
		@Email varchar(50),
		@PhoneNumber decimal,
		@StatusId int,
		@DepartmentId int,
		@IsDeleted bit
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
		IsDeleted=@IsDeleted
WHERE Id = @Id

END
