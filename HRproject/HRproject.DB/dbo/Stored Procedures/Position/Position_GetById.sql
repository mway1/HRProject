CREATE PROCEDURE [dbo].[Position_GetById]
		@Id int
AS
BEGIN
	SELECT 
	p.Id,
	p.[Name] as PositionName,
	lop.[Name] as PositionLevel,
	p.IsDeleted
	from dbo.Position p
	left join [LevelOfPosition] lop on lop.Id = p.LevelOfPositionId
	where (@Id = p.Id)
END
