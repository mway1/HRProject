CREATE PROCEDURE [dbo].[Department_Update]
	@id int,
	@Name varchar(50),
	@Description text,
	@isDeleted bit
AS
BEGIN

UPDATE dbo.Department
SET [Name]=@Name,
	[Description]=@Description,
	isDeleted=@isDeleted
WHERE id=@id

END