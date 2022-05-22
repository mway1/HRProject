CREATE PROCEDURE [dbo].[Employee_Delete]
	@Id int

AS
BEGIN

DELETE FROM dbo.Employee
WHERE Id=@Id

END