CREATE PROCEDURE [dbo].[LevelOfPosition_Delete]
		@id int,
		@Name varchar(50)
AS
BEGIN

UPDATE dbo.LevelOfPosition
SET	Name=@Name,
	isDeleted=1
WHERE Id = @Id

END
