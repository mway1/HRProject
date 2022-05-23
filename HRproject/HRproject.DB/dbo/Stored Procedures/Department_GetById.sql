CREATE PROCEDURE [dbo].[Department_GetById]
	@id int
AS
BEGIN
	SELECT id, [Name], [Description], isDeleted
	FROM dbo.Department
	WHERE id=@id
END
