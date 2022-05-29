CREATE PROCEDURE [dbo].[Position_Update]
	@Id int,
	@PositionName nvarchar(50),
	@LevelOfPositionId int
AS
	update [dbo].[Position]
	set 
	[Name] = @PositionName,
	[LevelOfPositionId] = @LevelOfPositionId
	
	Where Id = @Id