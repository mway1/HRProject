CREATE PROCEDURE [dbo].[Skill_GetAll]
AS
BEGIN
SELECT * FROM dbo.Skill 
WHERE dbo.Skill.isDeleted = 0
END