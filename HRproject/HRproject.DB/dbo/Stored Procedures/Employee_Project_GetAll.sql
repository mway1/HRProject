CREATE PROCEDURE [dbo].[Employee_Project_GetAll]
	AS
BEGIN

	SELECT EP.Id,E.FirstName,E.LastName,P.Name
	FROM dbo.Employee_Project as EP
	LEFT JOIN dbo.Employee as E on (E.id=EP.EmployeeId)
	LEFT JOIN dbo.Project as P on (P.id=EP.ProjectId)

END
