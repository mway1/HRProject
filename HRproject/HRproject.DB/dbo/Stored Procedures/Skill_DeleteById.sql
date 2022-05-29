CREATE PROCEDURE [dbo].[Skill_DeleteById]
	  @Id int
AS
	update [dbo].[Skill]
	set 
	[isDeleted] = 1
	Where Id = @Id
