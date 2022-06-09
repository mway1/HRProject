CREATE PROCEDURE [dbo].[Employee_Add]
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
	INSERT INTO dbo.Employee(
			FirstName ,
			SecondName,
			LastName ,
			BirthDate,
			Email ,
			PhoneNumber ,
			StatusId ,
			DepartmentId)
	VALUES(
			@FirstName ,
			@SecondName,
			@LastName ,
			@BirthDate,
			@Email ,
			@PhoneNumber ,
			@StatusId ,
			@DepartmentId);

	SELECT
		*
	FROM
		dbo.Employee
	WHERE
		id=SCOPE_IDENTITY()
END

