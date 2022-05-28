CREATE PROCEDURE [dbo].[Skill_UpdateById]
	 @SkillName nvarchar(50),
	@LevelOfSkillId int,
	@IsDeleted bit,
    @Id int
AS
	update [dbo].[Skill]
	set 
	[SkillName] = @SkillName,
	[LevelOfSkillId] = @LevelOfSkillId,
	[IsDeleted] = @IsDeleted
	
	Where Id = @Id
