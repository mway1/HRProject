CREATE PROCEDURE [dbo].[LevelOfPosition_Get]
AS
BEGIN
	SELECT *
	FROM dbo.LevelOfPosition
	WHERE id=@id
END
