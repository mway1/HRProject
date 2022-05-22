CREATE PROCEDURE [dbo].[Employee_GetAll]
	
AS
BEGIN

	SELECT Id,FirstName, LastName,Email, PhoneNumber, StatusId,DepartmentId, IsDeleted
	FROM dbo.Employee

END