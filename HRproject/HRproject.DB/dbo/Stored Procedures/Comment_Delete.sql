CREATE PROCEDURE [dbo].[Comment_Delete]
	@id int,
	@EmployeeId int,
	@Description text
AS
BEGIN

UPDATE dbo.Comment
SET	EmployeeId=@EmployeeId,
	Description=@Description,
	IsDeleted=1
WHERE Id = @Id

END
