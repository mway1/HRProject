CREATE PROCEDURE [dbo].[Employee_Project_Delete]
	@Id int

AS
BEGIN

DELETE FROM dbo.Employee_Project
WHERE Id=@Id

END