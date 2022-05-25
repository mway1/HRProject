CREATE PROCEDURE [dbo].[EmployeeHistory_GetAll]
	
AS
BEGIN
	SELECT Id, EmployeeId, [Date], StatusId, isDeleted
	FROM dbo.EmployeeHistory

	END
