CREATE PROCEDURE [dbo].[EmployeeHistory_Delete]
	@Id int
AS
BEGIN

DELETE FROM dbo.EmployeeHistory
WHERE 
Id=@Id

END

