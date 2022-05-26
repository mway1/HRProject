CREATE PROCEDURE [dbo].[Comment_add]
	@id int,
	@EmployeeId int,
	@Description text,
	@IsDeleted bit
AS
BEGIN
INSERT INTO dbo.Comment(
        EmployeeId,
		Description,
		IsDeleted)
VALUES(
		@EmployeeId,
		@Description,
		@IsDeleted)
SET @id=SCOPE_IDENTITY()

SELECT
		EmployeeId=@EmployeeId,
		Description=@Description,
		IsDeleted=@IsDeleted
FROM dbo.Comment
WHERE id=@id
END
