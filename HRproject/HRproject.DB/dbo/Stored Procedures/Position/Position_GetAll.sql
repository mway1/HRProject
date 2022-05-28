CREATE PROCEDURE [dbo].[Position_GetAll]
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
	where (p.IsDeleted = 0)
END