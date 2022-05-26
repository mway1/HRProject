CREATE PROCEDURE [dbo].[Department_Delete]
	@id int
AS
BEGIN

DELETE FROM dbo.Department
WHERE id=@id

END
