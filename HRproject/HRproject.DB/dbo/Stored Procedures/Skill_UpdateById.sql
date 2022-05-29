CREATE PROCEDURE [dbo].[Skill_UpdateById]
	 @Name nvarchar(50),
	@LevelOfSkillId int,
	@IsDeleted bit,
    @Id int
AS
	update [dbo].[Skill]
	set 
	[Name] = @Name,
	[LevelOfSkillId] = @LevelOfSkillId,
	[IsDeleted] = @IsDeleted
	
	Where Id = @Id
