CREATE PROCEDURE [dbo].[Employee_Position_Delete]
	@id int
AS
BEGIN

DELETE FROM dbo.Employee_Position
WHERE 
Id=@Id

END


