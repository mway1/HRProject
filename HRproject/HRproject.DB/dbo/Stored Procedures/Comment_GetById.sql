CREATE PROCEDURE [dbo].[Comment_GetById]
	@id int,
	@EmployeeId int,
	@Description text,
	@IsDeleted bit
AS
BEGIN
	SELECT id,EmployeeId,Description,IsDeleted
	FROM dbo.Comment
	WHERE id=@id
END
