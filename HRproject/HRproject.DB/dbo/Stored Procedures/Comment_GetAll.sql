CREATE PROCEDURE [dbo].[Comment_GetAll]
AS
BEGIN

	SELECT C.Id,E.FirstName,E.LastName,C.Description,C.isDeleted
	FROM dbo.Comment as C
	LEFT JOIN dbo.Employee as E on (E.id=C.EmployeeId)

END
