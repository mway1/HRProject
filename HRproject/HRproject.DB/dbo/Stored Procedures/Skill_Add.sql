CREATE PROC [dbo].[Skill_Add]
	@Name nvarchar(50),
	@LevelOfSkillId int,
	@IsDeleted bit
AS
BEGIN
	insert into dbo.Skill ([Name], LevelOfSkillid,IsDeleted)
	values (@Name ,
	@LevelOfSkillId,
	@IsDeleted )
END
