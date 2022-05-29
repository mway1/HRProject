CREATE PROCEDURE [dbo].[Skill_GetAll]
	AS
BEGIN
	
	SELECT Id, [Name], LevelOfSkillId, IsDeleted
	from dbo.Skill
END
