CREATE PROCEDURE [dbo].[Employee_Add]
		@id int,
		@FirstName varchar(50),
		@LastName varchar(50),
		@Email varchar(50),
		@PhoneNumber decimal,
		@StatusId int,
		@DepartmentId int,
		@IsDeleted bit
AS
BEGIN
INSERT INTO dbo.Employee(
        FirstName ,
		LastName ,
		Email ,
		PhoneNumber ,
		StatusId ,
		DepartmentId,
		IsDeleted)
VALUES(
		@FirstName ,
		@LastName ,
		@Email ,
		@PhoneNumber ,
		@StatusId ,
		@DepartmentId ,
		@IsDeleted)
SET @id=SCOPE_IDENTITY()

SELECT
		FirstName=@FirstName ,
		LastName=@LastName,
		Email=@Email ,
		PhoneNumber=@PhoneNumber ,
		StatusId=@StatusId ,
		DepartmentId=@DepartmentId,
		IsDeleted=@IsDeleted
FROM dbo.Employee
WHERE id=@id
END
