CREATE PROCEDURE [dbo].[EmployeeRequestSkill_Create]
	@EmployeeRequestId INT,
	@SkillId INT,
	@SkillLevel INT
AS
BEGIN
INSERT INTO dbo.EmployeeRequest_Skill(
        EmployeeRequestId,
		SkillId,
		LevelOfSkill)
VALUES(
		@EmployeeRequestId,
		@SkillId,
		@SkillLevel)
SELECT SCOPE_IDENTITY() 
END
