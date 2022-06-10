CREATE PROCEDURE [dbo].[Employee_Skill_Add]
	@id int,
	@EmployeeId int,
	@SkillId int,
	@LevelOfSkill int
AS
BEGIN
INSERT INTO dbo.Employee_Skill(
        EmployeeId,
		SkillId,
		LevelOfSkill)
VALUES(
		@EmployeeId,
		@SkillId,
		@LevelOfSkill)
SET @id=SCOPE_IDENTITY()

SELECT
		EmployeeId=@EmployeeId,
		SkillId=@SkillId,
		LevelOfSkill=@LevelOfSkill
FROM dbo.Employee_Skill
END