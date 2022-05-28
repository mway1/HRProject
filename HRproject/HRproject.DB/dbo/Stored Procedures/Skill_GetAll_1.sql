CREATE PROCEDURE [dbo].[Skill_GetAll]
	AS
BEGIN
	
	SELECT Id, SkillName, LevelOfSkillId, IsDeleted
	from dbo.Skill
END
