CREATE PROCEDURE [dbo].[Position_GetAll]
AS
BEGIN
	SELECT 
	p.Id as id,
	p.[Name] as Name,
	p.IsDeleted as IsDeleted
	from dbo.Position p
	where (p.IsDeleted = 0)
END