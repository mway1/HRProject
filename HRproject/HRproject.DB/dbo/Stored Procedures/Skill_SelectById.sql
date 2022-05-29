CREATE PROCEDURE [dbo].[Skill_SelectById]
		@Id int
AS
BEGIN
	SELECT 
	s.Id,
	s.[Name],
	s.LevelOfSkillId,
	s.IsDeleted
	from dbo.Skill s
	where @Id = s.Id
END
