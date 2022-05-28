CREATE PROC [dbo].[Skill_Add]
	@SkillName nvarchar(50),
	@LevelOfSkillId int,
	@IsDeleted bit
AS
BEGIN
	insert into dbo.Skill (SkillName, LevelOfSkillid,IsDeleted)
	values (@SkillName ,
	@LevelOfSkillId,
	@IsDeleted )
END
