CREATE PROCEDURE [dbo].[Position_Add]
	@PositionName		nvarchar (255),
	@LevelOfPositionId	int

	
AS
BEGIN
	INSERT INTO dbo.Position ([Name],LevelOfPositionId)
	VALUES (@PositionName,@LevelOfPositionId)
END
