CREATE PROCEDURE [dbo].[LevelOfPosition_Update]
		@id int,
		@Name varchar(50),
		@isDeleted bit
AS
BEGIN

UPDATE dbo.LevelOfPosition
SET	Name=@Name,
	isDeleted=@isDeleted
WHERE Id = @Id

END
