CREATE PROCEDURE [dbo].[Position_GetAll]
	@Id int
AS
BEGIN
	SELECT 
	p.Id,
	p.[Name] as PositionName,
	p.IsDeleted
	from dbo.Position p
	where (p.IsDeleted = 0)
END