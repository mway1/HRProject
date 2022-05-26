CREATE PROCEDURE [dbo].[Comment_Update]
	@id int,
	@EmployeeId int,
	@Description text,
	@IsDeleted bit
AS
BEGIN

UPDATE dbo.Comment
SET	EmployeeId=@EmployeeId,
	Description=@Description,
	IsDeleted=@IsDeleted
WHERE Id = @Id

END
