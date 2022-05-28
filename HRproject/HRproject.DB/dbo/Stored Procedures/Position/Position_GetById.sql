CREATE PROCEDURE [dbo].[Position_GetById]
		@Id int
AS
BEGIN
	SELECT 
	p.Id,
	p.PositionName,
	lop.LevelOfPositionName,
	p.IsDeleted
	from dbo.Position p
	left join [LevelOfPosition] lop on lop.Id = p.LevelOfPositionId
	where (@Id = p.Id)
END
