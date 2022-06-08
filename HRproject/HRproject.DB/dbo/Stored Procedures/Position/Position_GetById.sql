CREATE PROCEDURE [dbo].[Position_GetById]
		@Id int
AS
BEGIN
	SELECT 
	p.Id,
	p.[Name] as PositionName,
	p.IsDeleted
	from dbo.Position p
	where (@Id = p.Id)
END
