CREATE PROCEDURE [dbo].[LevelOfPosition_Delete]
	@Id int

AS
BEGIN

DELETE FROM dbo.LevelOfPosition
WHERE Id=@Id

END