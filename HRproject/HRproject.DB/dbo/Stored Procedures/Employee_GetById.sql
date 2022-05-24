CREATE PROCEDURE [dbo].[Employee_GetById]
	@Id int
AS
BEGIN

	SELECT Id,FirstName,SecondName, LastName,BirthDate,Email, PhoneNumber, StatusId,DepartmentId, IsDeleted
	FROM dbo.Employee
	WHERE Id=@Id

END