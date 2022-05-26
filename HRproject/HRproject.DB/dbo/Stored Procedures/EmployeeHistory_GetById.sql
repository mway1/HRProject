CREATE PROCEDURE [dbo].[EmployeeHistory_GetById]
	@Id int
AS
BEGIN
	SELECT Id, EmployeeId, [Date], StatusId, isDeleted
	FROM dbo.EmployeeHistory
	WHERE Id=@Id
END
