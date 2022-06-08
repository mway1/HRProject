﻿CREATE PROCEDURE [dbo].[Employee_GetByDepartment]
	@DepartmentId int
AS
BEGIN

	SELECT Id,FirstName,SecondName, LastName,BirthDate,Email, PhoneNumber, StatusId,DepartmentId, IsDeleted
	FROM dbo.Employee
	WHERE DepartmentId=@DepartmentId

END