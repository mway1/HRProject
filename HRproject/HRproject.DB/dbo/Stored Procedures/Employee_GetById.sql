CREATE PROCEDURE [dbo].[Employee_GetById]
	@Id int
AS
BEGIN

	SELECT Id,FirstName, LastName,Email, PhoneNumber, StatusId,DepartmentId, IsDeleted
	FROM dbo.Employee
	WHERE Id=@Id

END