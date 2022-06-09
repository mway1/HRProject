CREATE PROCEDURE [dbo].[Employee_Skill_GetById]
	@EmployeeId int
AS
BEGIN

	SELECT ES.id,ES.EmployeeId,S.Name as SkillName,ES.LevelOfSkill
	FROM dbo.Employee_Skill as ES
	LEFT JOIN dbo.Skill as S on (ES.SkillId=S.id)
	
	WHERE EmployeeId=@EmployeeId

END
