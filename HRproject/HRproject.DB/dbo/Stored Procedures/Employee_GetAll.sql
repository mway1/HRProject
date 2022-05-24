CREATE PROCEDURE [dbo].[Employee_GetAll]
	
AS
BEGIN

	SELECT E.Id,E.FirstName,E.SecondName, E.LastName,E.BirthDate,E.Email, E.PhoneNumber, S.Name,D.Name, E.IsDeleted
	FROM dbo.Employee as E
	LEFT JOIN dbo.Status as S on (S.id=E.StatusId)
	LEFT JOIN dbo.Department as D on(D.id=E.DepartmentId)

END